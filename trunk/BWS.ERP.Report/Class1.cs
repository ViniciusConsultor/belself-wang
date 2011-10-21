using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastReport;

namespace DECO.Report
{
    public partial class frmReportPreview : Form
    {
        private FastReport.Report PreRepot;
        public frmReportPreview()
        {
            InitializeComponent();
        }
        public frmReportPreview(FastReport.Report rp)
        {
            InitializeComponent();
            PreRepot = rp;
        }
        private void ReportPreview_Load(object sender, EventArgs e)
        {
            PreRepot.Preview = previewControl1;
            PreRepot.Prepare();
            PreRepot.ShowPrepared();

        }
       
    }
}

 

 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FastReport;
using System.Collections;
using System.Configuration;
using System.IO;
namespace DECO.Report
{
    public class InitReport
    {
        private DataTable dtReport;
        private byte[] bt;
        private int iDefaultChecked;
        private int iOldID;
        public ContextMenuStrip menubtnPrint;
        public ToolStripMenuItem tsmPrintReport;
        private ToolStripMenuItem tsmChooseReport;
        private ToolStripMenuItem tsmDesginReport;
        private ToolStripMenuItem tsmAddReport;
        private ToolStripMenuItem tsmPreviewReport;
        private ToolStripMenuItem[] tsmChooseDetail;
        public string sAuth;
        private FastReport.Report report;
        //设置报表数据集，支持DataSet,DataTable,DataView，还可以扩展支持
        List<DataSet> LDataSet = new List<DataSet>();
        List<string> LDataSetName = new List<string>();
        List<DataTable> LDataTable = new List<DataTable>();
        List<string> LDataTableName = new List<string>();
        List<DataView> LDataView = new List<DataView>();
        List<string> LDataViewName = new List<string>();
        SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        private string rpGUID;

        /// <summary>
        /// 初始化报表类
        /// </summary>
        public InitReport()
        {

        }
        /// <summary>
        /// 初始化报表类
        /// </summary>
        /// <param name="ReportGUID">报表模块GUID</param>
        /// <param name="Auth">权限字符串</param>
        public InitReport(string ReportGUID,string Auth)
        {
            //权限控制
            sAuth = Auth;
            rpGUID = ReportGUID;
            //初始化菜单
            CreateMenu();
        }
        /// <summary>
        /// 初始化报表菜单
        /// </summary>
        private void CreateMenu()
        {
            //初始化报表类型
            conn.Open();
            dtReport = new DataTable();
            dtReport.Load(new SqlCommand("SELECT * FROM sysReport WHERE ReportGUID='" + rpGUID + "' ORDER BY ReportName", conn).ExecuteReader());
            tsmChooseDetail = new ToolStripMenuItem[dtReport.Rows.Count];
            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtReport.Rows[i]["IsDefault"]))
                {
                    tsmChooseDetail.SetValue(new ToolStripMenuItem(dtReport.Rows[i]["ReportName"].ToString() + "(默认)"),i);
                    tsmChooseDetail[i].Name = dtReport.Rows[i]["ID"].ToString();
                    tsmChooseDetail[i].Checked = true;
                    iDefaultChecked = i;
                    iOldID = i;
                    bt = (byte[])dtReport.Rows[i]["Report"];
                }
                else
                {
                    tsmChooseDetail.SetValue(new ToolStripMenuItem(dtReport.Rows[i]["ReportName"].ToString()), i);
                    tsmChooseDetail[i].Name = dtReport.Rows[i]["ID"].ToString();

                }
            }
            conn.Close();
            menubtnPrint = new ContextMenuStrip();
            tsmPrintReport = new ToolStripMenuItem("打印");
            tsmChooseReport = new ToolStripMenuItem("选择报表");
            tsmDesginReport = new ToolStripMenuItem("设计报表");
            tsmAddReport = new ToolStripMenuItem("新增报表");
            tsmPreviewReport = new ToolStripMenuItem("打印预览");
            ToolStripSeparator tss1 = new ToolStripSeparator();
            ToolStripSeparator tss2 = new ToolStripSeparator();
            tsmChooseReport.DropDownItems.AddRange(tsmChooseDetail);
            menubtnPrint.Items.Add(tsmPrintReport);
            menubtnPrint.Items.Add(tss1);
            menubtnPrint.Items.Add(tsmChooseReport);
            //权限控制，只有管理员才拥有设计报表和新增报表权限
            if (sAuth == "admin")
            {
                menubtnPrint.Items.Add(tsmDesginReport);
                menubtnPrint.Items.Add(tsmAddReport);
            }
            menubtnPrint.Items.Add(tss2);
            menubtnPrint.Items.Add(tsmPreviewReport);
            //代理打印预览事件
            tsmPreviewReport.Click += new EventHandler(tsmPreviewReport_Click);
            //代理报表设计事件
            tsmDesginReport.Click += new EventHandler(tsmDesginReport_Click);
            //代理选择报表事件
            tsmChooseReport.DropDown.ItemClicked += new ToolStripItemClickedEventHandler(DropDown_ItemClicked);
            //代理打印事件
            tsmPrintReport.Click += new EventHandler(tsmPrintReport_Click);
            //代理新增事件
            tsmAddReport.Click += new EventHandler(tsmAddReport_Click);
        }

        private void GetData(string id)
        {
            if (iOldID != iDefaultChecked)
            {
                conn.Open();
                dtReport = new DataTable();
                dtReport.Load(new SqlCommand("SELECT Report FROM sysReport WHERE ID=" + id, conn).ExecuteReader());
                bt = (byte[])dtReport.Rows[0]["Report"];
                iOldID = iDefaultChecked;
                conn.Close();
            }
        }
        /// <summary>
        /// 新增报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tsmAddReport_Click(object sender, EventArgs e)
        {
            report = new FastReport.Report();
            RegReportData();
            frmReportDesign rp = new frmReportDesign(report);
            rp.ReportGUID = rpGUID;
            rp.ShowDialog();
            report.Dispose();
            //ClearListData();
            CreateMenu();
        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tsmPrintReport_Click(object sender, EventArgs e)
        {
            report = new FastReport.Report();
            if (!report.IsPrinting)
            {
                GetData(tsmChooseDetail[iDefaultChecked].Name);
                report.Load(new MemoryStream(bt));
                RegReportData();
            }
            report.Print();
            report.Dispose();
        }
        /// <summary>
        /// 设计报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tsmDesginReport_Click(object sender, EventArgs e)
        {
            report = new FastReport.Report();
            if (!report.IsDesigning)
            {
                GetData(tsmChooseDetail[iDefaultChecked].Name);
                report.Load(new MemoryStream(bt));
                RegReportData();
            }
            frmReportDesign rp = new frmReportDesign(report);
            rp.ReportGUID = rpGUID;
            rp.ShowDialog();
            report.Dispose();
            //刷新菜单
            CreateMenu();
        }
        /// <summary>
        /// 打印预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tsmPreviewReport_Click(object sender, EventArgs e)
        {
            report = new FastReport.Report();
            if (!report.IsRunning)
            {
                GetData(tsmChooseDetail[iDefaultChecked].Name);
                report.Load(new MemoryStream(bt));
                RegReportData();
            }
            frmReportPreview rp = new frmReportPreview(report);
            rp.ShowDialog();
            report.Dispose();
        }

        /// <summary>
        /// 选择报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DropDown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            for (int i = 0; i < tsmChooseReport.DropDownItems.Count; i++)
            {
                if (tsmChooseDetail[i].Name == e.ClickedItem.Name)
                {
                    iDefaultChecked = i;
                    tsmChooseDetail[i].Checked = true;
                }
                else
                {
                    tsmChooseDetail[i].Checked = false;
                }
            }
            //选择报表后立即打印预览
            tsmPreviewReport_Click(sender, e);
        }
        /// <summary>
        /// 添加报表数据集
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="dsName">数据集别名</param>
        public void AddReportData(DataSet ds, string dsName)
        {
            LDataSet.Add(ds);
            LDataSetName.Add(dsName);
        }
        /// <summary>
        /// 添加报表数据集
        /// </summary>
        /// <param name="ds">DataSet</param>
        public void AddReportData(DataSet ds)
        {
            LDataSet.Add(ds);
            LDataSetName.Add("");
        }
        /// <summary>
        /// 添加报表数据集
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="dtName">数据集别名</param>
        public void AddReportData(DataTable dt, string dtName)
        {
            LDataTable.Add(dt);
            LDataTableName.Add(dtName);
        }
        /// <summary>
        /// 添加报表数据集
        /// </summary>
        /// <param name="dt">DataTable</param>
        public void AddReportData(DataTable dt)
        {
            LDataTable.Add(dt);
            LDataTableName.Add("");
        }
        /// <summary>
        /// 添加报表数据集
        /// </summary>
        /// <param name="dv">DataView</param>
        /// <param name="dvName">数据集别名</param>
        public void AddReportData(DataView dv, string dvName)
        {
            LDataView.Add(dv);
            LDataViewName.Add(dvName);
        }
        /// <summary>
        /// 添加报表数据集
        /// </summary>
        /// <param name="dv">DataView</param>
        public void AddReportData(DataView dv)
        {
            LDataView.Add(dv);
            LDataViewName.Add("");
        }
        /// <summary>
        /// 注册报表数据集
        /// </summary>
        private void RegReportData()
        {
            //report.RegisterData(FData);
            if (LDataSet.Count > 0)
            {
                for (int i = 0; i < LDataSet.Count; i++)
                {
                    report.RegisterData(LDataSet[i], LDataSetName[i]);
                }
            }
            if (LDataTable.Count > 0)
            {
                for (int i = 0; i < LDataTable.Count; i++)
                {
                    report.RegisterData(LDataTable[i], LDataTableName[i]);
                }
            }
            if (LDataView.Count > 0)
            {
                for (int i = 0; i < LDataView.Count; i++)
                {
                    report.RegisterData(LDataView[i], LDataViewName[i]);
                }
            }
        }
       
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using FastReport;
using System.IO;

using DECO.DBUtility; 

namespace DECO.Report
{
    public partial class frmSaveReport : Form
    {
        private string rpguid;
        private string DataFlag;
        private bool IsFirstLoad = false;
        private FastReport.Report report;
        public frmSaveReport()
        {
            InitializeComponent();
        }
        public frmSaveReport(FastReport.Report rp, string rpGUID)
        {
            InitializeComponent();
            report = rp;
            rpguid = rpGUID;
            GetReportData(rpguid);
            initButtonsState("View");
        }
        private void GetReportData(string ReportGUID)
        {
            gcReport.DataSource = DbHelperSQL.Query("SELECT * FROM sysReport WHERE ReportGUID='" + ReportGUID + "' ORDER BY ReportName");
            gcReport.DataMember = "ds";
        }
        /// <summary>
        /// 设置控制按钮初始状态
        /// </summary>
        /// <param name="OperateFlag">操作状态</param>       
        private void initButtonsState(string OperateFlag)
        {
            switch (OperateFlag)
            {
                case "View":
                    {
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnClose.Enabled = true;
                        txtReportName.Enabled = false;
                        txtRemark.Enabled = false;
                        DataFlag = "View";
                        break;
                    }
                case "Add":
                    {
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = true;
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnClose.Enabled = true;
                        txtReportName.Enabled = true;
                        txtRemark.Enabled = true;
                        gcReport.Enabled = false;
                        DataFlag = "Add";
                        break;
                    }
                case "Edit":
                    {
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = true;
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnClose.Enabled = true;
                        txtReportName.Enabled = true;
                        txtRemark.Enabled = true;
                        gcReport.Enabled = false;
                        DataFlag = "Edit";
                        break;
                    }
                case "Cancel":
                    {
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnClose.Enabled = true;
                        txtReportName.Enabled = false;
                        txtRemark.Enabled = false;
                        gcReport.Enabled = true;
                        DataFlag = "View";
                        break;
                    }
                case "Save":
                    {
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnClose.Enabled = true;
                        txtReportName.Enabled = false;
                        txtRemark.Enabled = false;
                        gcReport.Enabled = true;
                        DataFlag = "View";
                        break;
                    }
                case "Delete":
                    {
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnClose.Enabled = true;
                        txtReportName.Enabled = false;
                        txtRemark.Enabled = false;
                        DataFlag = "View";
                        break;
                    }
                default:
                    {
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnClose.Enabled = true;
                        txtReportName.Enabled = false;
                        txtRemark.Enabled = false;
                        DataFlag = "View";
                        break;
                    }
            }
        }
        /// <summary>
        /// 显示数据
        /// </summary>
        /// <param name="ID"></param>
        private void ShowInfo(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            this.txtID.TextBoxText = gvReport.GetDataRow(gv.FocusedRowHandle)["ID"].ToString();
            this.txtReportName.TextBoxText = gvReport.GetDataRow(gv.FocusedRowHandle)["ReportName"].ToString();
            this.txtRemark.TextBoxText = gvReport.GetDataRow(gv.FocusedRowHandle)["Remark"].ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            report.Save(stream);
            byte[] bt = stream.ToArray();
            if (DataFlag == "Add")
            {
                try
                {
                    string InsertSql = "INSERT INTO sysReport(ReportGUID,ReportName,Report,IsDefault,Remark) VALUES(@ReportGUID,@ReportName,@Report,@IsDefault,@Remark)";
                    SqlParameter[] parameters = {
     new SqlParameter("@ReportGUID", SqlDbType.VarChar ,50),
     new SqlParameter("@ReportName", SqlDbType.VarChar,50),
     new SqlParameter("@Report", SqlDbType.Image),
     new SqlParameter("@IsDefault", SqlDbType.Bit),
     new SqlParameter("@Remark", SqlDbType.VarChar,100)};
                    parameters[0].Value = rpguid;
                    parameters[1].Value = txtReportName.TextBoxText;
                    parameters[2].Value = bt;
                    parameters[3].Value = 0;
                    parameters[4].Value = txtRemark.TextBoxText;
                    DbHelperSQL.ExecuteSql(InsertSql,parameters);
                    initButtonsState("Save");
                    GetReportData(rpguid);
                    MessageBox.Show("保存成功","系统信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(DataFlag=="Edit")
            {
                if (txtID.TextBoxText == "")
                {
                    return;
                }
                else
                {
                    string UpdateSql = "UPDATE sysReport SET ReportName=@ReportName,Report=@Report,Remark=@Remark WHERE ID=" + txtID.TextBoxText;
                    SqlParameter[] parameters = {
     new SqlParameter("@ReportName", SqlDbType.VarChar,50),
     new SqlParameter("@Report", SqlDbType.Image),
     new SqlParameter("@Remark", SqlDbType.VarChar,100)};
                    parameters[0].Value = txtReportName.TextBoxText;
                    parameters[1].Value = bt;
                    parameters[2].Value = txtRemark.TextBoxText;
                    DbHelperSQL.ExecuteSql(UpdateSql, parameters);
                    initButtonsState("Save");
                    GetReportData(rpguid);
                    MessageBox.Show("保存成功", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DataFlag == "View" && txtID.TextBoxText != "")
            {
                if (MessageBox.Show("是否删除该报表？", "系统信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        DbHelperSQL.ExecuteSql("DELETE FROM SysReport WHERE ID=" + txtID.TextBoxText);
                        GetReportData(rpguid);
                        MessageBox.Show("删除成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败！" + ex.Message, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            initButtonsState("Add");
            txtReportName.TextBoxText = "";
            txtID.TextBoxText = "";
            txtRemark.TextBoxText = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.TextBoxText == "")
            {
                return;
            }
            initButtonsState("Edit");
        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            if (txtID.TextBoxText == "")
            {
                return;
            }
            if (MessageBox.Show("是否设置为默认报表？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DbHelperSQL.ExecuteSql("UPDATE sysReport SET IsDefault=0 WHERE ReportGUID='" + rpguid + "'");
                    DbHelperSQL.ExecuteSql("UPDATE sysReport SET IsDefault=1 WHERE ID=" + txtID.TextBoxText);
                    GetReportData(rpguid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void frmSaveReport_Load(object sender, EventArgs e)
        {
            initButtonsState("View");
            GetReportData(rpguid);
            //这个一定要放在最后
            IsFirstLoad = true;
            gvReport.FocusedRowHandle = 1;
            gvReport.FocusedRowHandle = 0;
            if (gvReport.RowCount == 1)
            {
                ShowInfo(gvReport);
            }
        }

        private void gvReport_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0 && IsFirstLoad == true)
            {
                ShowInfo(gvReport);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (gvReport.RowCount > 0)
            {
                ShowInfo(gvReport);
            }
            initButtonsState("Cancel");
        }
        

    }
}

 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using FastReport;

namespace DECO.Report
{
    public partial class frmReportDesign : Form
    {
        private FastReport.Report report;
        private string rpGUID;
        public frmReportDesign()
        {
            InitializeComponent();
        }
        public frmReportDesign(FastReport.Report rp)
        {
            InitializeComponent();
            report = rp;
        }

        private void ReportDesign_Load(object sender, EventArgs e)
        {
            FastReport.Utils.Config.DesignerSettings.Text = "DecoReport-";
            //设置报表控件新增数据源连接字符串
            FastReport.Utils.Config.DesignerSettings.ApplicationConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            designerControl1.cmdAbout.CustomAction += new EventHandler(cmdAbout_CustomAction);
            designerControl1.cmdPreview.CustomAction += new EventHandler(DesignerSettings_CustomPreviewReport);
            designerControl1.cmdSave.CustomAction += new EventHandler(cmdSave_CustomAction);
            FastReport.Utils.Config.DesignerSettings.CustomPreviewReport += new EventHandler(DesignerSettings_CustomPreviewReport);
            //FastReport.Data.SystemVariables aa = new FastReport.Data.SystemVariables();
//            、、aa.Add

            
            

            designerControl1.Report = report;
            designerControl1.RefreshLayout();

        }

        void DesignerSettings_CustomPreviewReport(object sender, EventArgs e)
        {
            frmReportPreview rp = new frmReportPreview(report);
            rp.ShowDialog();
        }

        void cmdSave_CustomAction(object sender, EventArgs e)
        {
            frmSaveReport sr = new frmSaveReport(report,rpGUID);
            sr.ShowDialog();
        }

        void cmdAbout_CustomAction(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
        /// <summary>
        /// 当前报表模块GUID
        /// </summary>
        public string ReportGUID
        {
            set
            {
                rpGUID = value;
            }
        }
    }
}
