using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraCharts;

namespace BWS.ERP.Module.SystemManage
{
    public partial class frmsysQueryReport : BWS.ERP.BaseForm.frmForm
    {
        DataTable dtMain = new DataTable();
        DataTable dtDetail = new DataTable();
        DataTable dtSearch = new DataTable();
        /// <summary>
        /// 主查询SQL
        /// </summary>
        string sMainSQL = "";
        /// <summary>
        /// 处理字段
        /// </summary>
        string sDealFields = "*";
        /// <summary>
        /// 排序字段
        /// </summary>
        string sSortFields = "";
        /// <summary>
        /// 设置SQL
        /// </summary>
        string sExecSQL = "";
        /// <summary>
        /// 是否存在分组
        /// </summary>
        bool IsGroup = false;
        /// <summary>
        /// 是否显示图表
        /// </summary>
        bool IsChart = false;
        /// <summary>
        /// 是否自动运行查询
        /// </summary>
        bool IsAutoRun = false;
        public frmsysQueryReport(int formid, string formtext)
            : base(formid, formtext)
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
        }

        private void frmsysQueryReport_Load(object sender, EventArgs e)
        {
            InitBaseData();
            CreatSearchControl();
            CreateGridColumn();
            //控制是否自动执行查询
            if (IsAutoRun)
            {
                InitGridData("1=1 " + GetSearchFilterSQL());
                if (tbDetail.SelectedTabPageIndex == 1)
                {
                    ShowChart();
                }
            }
            else
            {
                InitGridData("1=2");
            }

        }


        #region 私有方法
        /// <summary>
        /// 创建查询条件控件
        /// </summary>
        private void CreatSearchControl()
        {
            try
            {
                if (dtDetail != null && dtMain != null && dtMain.Rows.Count > 0)
                {
                    //每行控件数
                    int iControlColumn = Convert.ToInt32(dtMain.Rows[0]["iControlColumn"]);
                    //控件间距
                    int iControlSpace = Convert.ToInt32(dtMain.Rows[0]["iControlSpace"]);
                    //先计算需要生成查询的数据
                    DataRow[] dr = dtDetail.Select("bIsQuery=1");
                    if (dr.Length > 0)
                    {
                        //计算控件总共行数
                        int iRows = 0;
                        if (dr.Length % iControlColumn != 0)
                        {
                            iRows = (int)Math.Floor(Convert.ToDecimal(dr.Length / iControlColumn)) + 1;
                        }
                        else
                        {
                            iRows = Convert.ToInt32(dr.Length / iControlColumn);
                        }


                        //设置控件数计数
                        int iControl = 0;
                        for (int j = 0; j < iRows; j++)
                        {
                            for (int i = 0; i < iControlColumn; i++)
                            {
                                //控件类型
                                string sColumnType = dr[iControl]["sColumnType"].ToString();
                                //取得查询条件默认值
                                object oColumnDefaultValue = dr[iControl]["sDefaultValue"];
                                if (oColumnDefaultValue.ToString().ToLower() == "<userid>")
                                {
                                    oColumnDefaultValue = BWS.ERP.Security.SecurityCenter.CurrentUserID;
                                }
                                //默认值中日期类型解析
                                if (oColumnDefaultValue.ToString().ToLower().Contains("<getdate>") && sColumnType == "D")
                                {
                                    if (oColumnDefaultValue.ToString().Length == 9)
                                    {
                                        oColumnDefaultValue = DateTime.Now.ToShortDateString();
                                    }
                                    else if (oColumnDefaultValue.ToString().ToLower().Contains("+"))
                                    {
                                        int iDays = Convert.ToInt32(oColumnDefaultValue.ToString().Trim().Substring(10));
                                        oColumnDefaultValue = DateTime.Now.AddDays(iDays);
                                    }
                                    else if (oColumnDefaultValue.ToString().ToLower().Contains("-"))
                                    {
                                        int iDays = Convert.ToInt32(oColumnDefaultValue.ToString().Trim().Substring(10));
                                        oColumnDefaultValue = DateTime.Now.AddDays(-iDays);
                                    }
                                }
                                if (oColumnDefaultValue.ToString() != "" && sColumnType == "K" && Convert.ToInt32(oColumnDefaultValue.ToString()) == 1)
                                {
                                    oColumnDefaultValue = true;
                                }
                                else if (oColumnDefaultValue.ToString() != "" && sColumnType == "K" && Convert.ToInt32(oColumnDefaultValue.ToString()) == 0)
                                {
                                    oColumnDefaultValue = false;
                                }


                                //创建控件
                                //Lable大小控制为80X21，其他输入控件大小为120X21
                                Label lbl = new Label();
                                lbl.AutoSize = false;
                                lbl.Size = new Size(80, 21);
                                lbl.Location = new Point(10 + (80 + 120 + iControlSpace) * i, 20 + (21 + 10) * j);
                                //控件命名规则：lbl+字段名+数据行号
                                lbl.Name = "lbl" + dr[iControl]["sColumnFieldName"].ToString() + iControl.ToString();
                                lbl.TextAlign = ContentAlignment.BottomLeft;
                                //当控件类型为复选框时不创建Lable控件
                                if (sColumnType != "K")
                                {
                                    lbl.Text = dr[iControl]["sColumnCaption"].ToString();
                                }
                                grbFilter.Controls.Add(lbl);
                                //不同类型创建不同控件
                                switch (sColumnType)
                                {
                                    //字符型,数字型
                                    case "S":
                                    case "N":
                                        {
                                            DevExpress.XtraEditors.TextEdit txt = new DevExpress.XtraEditors.TextEdit();
                                            txt.Size = new Size(120, 21);
                                            txt.Name = "txt" + dr[iControl]["sColumnFieldName"].ToString() + iControl.ToString();
                                            txt.Location = new Point(10 + (80 + 120 + iControlSpace) * i + 80, 20 + (21 + 10) * j);
                                            txt.Text = oColumnDefaultValue.ToString();
                                            //用Tag来存储查询类型
                                            txt.Tag = dr[iControl]["sColumnFieldName"].ToString() + " " + dr[iControl]["sSearchType"].ToString();
                                            grbFilter.Controls.Add(txt);
                                            break;
                                        }
                                    //ComboBox类型
                                    case "C":
                                        {
                                            DevExpress.XtraEditors.ComboBoxEdit cbx = new DevExpress.XtraEditors.ComboBoxEdit();
                                            cbx.Size = new Size(120, 21);
                                            cbx.Name = "cbx" + dr[iControl]["sColumnFieldName"].ToString() + iControl.ToString();
                                            cbx.Location = new Point(10 + (80 + 120 + iControlSpace) * i + 80, 20 + (21 + 10) * j);
                                            cbx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                                            //写入ComboBox选择值
                                            foreach (var item in dr[iControl]["sReturnValue"].ToString().Replace("，", ",").Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                                            {
                                                cbx.Properties.Items.Add(item);
                                            }


                                            if (dr[iControl]["sReturnValue"].ToString() != "")
                                            {
                                                if (oColumnDefaultValue.ToString() != "" && dr[iControl]["sReturnValue"].ToString().Contains(oColumnDefaultValue.ToString()))
                                                {
                                                    cbx.Text = oColumnDefaultValue.ToString();
                                                }
                                                else
                                                {
                                                    cbx.SelectedIndex = -1;
                                                }
                                            }
                                            //用Tag来存储查询类型
                                            cbx.Tag = dr[iControl]["sColumnFieldName"].ToString() + " " + dr[iControl]["sSearchType"].ToString();
                                            grbFilter.Controls.Add(cbx);
                                            break;
                                        }
                                    //日期型
                                    case "D":
                                        {
                                            DevExpress.XtraEditors.DateEdit det = new DevExpress.XtraEditors.DateEdit();
                                            det.Size = new Size(120, 21);
                                            det.Name = "det" + dr[iControl]["sColumnFieldName"].ToString() + iControl.ToString();
                                            det.Location = new Point(10 + (80 + 120 + iControlSpace) * i + 80, 20 + (21 + 10) * j);
                                            det.Tag = dr[iControl]["sColumnFieldName"].ToString() + " " + dr[iControl]["sSearchType"].ToString();
                                            if (oColumnDefaultValue.ToString() != "")
                                            {
                                                det.DateTime = Convert.ToDateTime(oColumnDefaultValue);
                                            }
                                            else
                                            {
                                                det.EditValue = null;
                                            }
                                            grbFilter.Controls.Add(det);
                                            break;
                                        }
                                    //复选框
                                    case "K":
                                        {
                                            DevExpress.XtraEditors.CheckEdit chk = new DevExpress.XtraEditors.CheckEdit();
                                            chk.Size = new Size(120, 21);
                                            chk.Name = "chk" + dr[iControl]["sColumnFieldName"].ToString() + iControl.ToString();
                                            chk.Location = new Point(10 + (80 + 120 + iControlSpace) * i + 80, 20 + (21 + 10) * j);
                                            //CheckBox过滤条件特殊处理
                                            string sReturnValue = "";
                                            if (dr[iControl]["sSearchType"].ToString().Contains("LIKE"))
                                            {
                                                sReturnValue = " '%" + dr[iControl]["sReturnValue"].ToString() + "%'";
                                            }
                                            else
                                            {
                                                sReturnValue = " '" + dr[iControl]["sReturnValue"].ToString() + "'";
                                            }
                                            chk.Tag = dr[iControl]["sColumnFieldName"].ToString() + " " + dr[iControl]["sSearchType"].ToString() + sReturnValue;
                                            if (oColumnDefaultValue.ToString() != "")
                                            {
                                                chk.Checked = Convert.ToBoolean(oColumnDefaultValue);
                                            }
                                            else
                                            {
                                                chk.CheckState = CheckState.Unchecked;
                                            }
                                            chk.Text = dr[iControl]["sColumnCaption"].ToString();
                                            grbFilter.Controls.Add(chk);
                                            break;
                                        }


                                }
                                iControl++;
                                //当计数大于等于要创建的控件数量时则退出循环
                                if (iControl >= dr.Length)
                                {
                                    break;
                                }


                            }
                        }
                        //分组条件控件设置
                        grbGroup.Visible = IsGroup;
                        //grbGroup.Location = new Point(10, iRows * 31 + toolStrip1.Height);
                        grbGroup.Location = new Point(10, iRows * 31 );
                        grbGroup.Controls.Clear();
                        for (int i = 0; i < dtDetail.Select("bIsGroup=1").Length; i++)
                        {
                            DevExpress.XtraEditors.CheckEdit chk = new DevExpress.XtraEditors.CheckEdit();
                            chk.Size = new Size(80, 21);
                            chk.Location = new Point(5 + (80 + 5) * i, 15);
                            chk.Name = "chkGrp" + dtDetail.Select("bIsGroup=1")[i]["sColumnFieldName"].ToString() + i.ToString();
                            chk.Text = dtDetail.Select("bIsGroup=1")[i]["sColumnCaption"].ToString();
                            chk.Tag = dtDetail.Select("bIsGroup=1")[i]["sColumnFieldName"].ToString();
                            chk.Checked = true;
                            grbGroup.Controls.Add(chk);
                        }
                        grbGroup.Width = dtDetail.Select("bIsGroup=1").Length * 85 + 10;


                        //设置查询条件面板高度
                        grbFilter.Height = iRows * 31 + 40 + (IsGroup == true ? grbGroup.Height : 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建查询条件控件错误！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 通过ReportNo初始化基础数据
        /// </summary>
        private void InitBaseData()
        {
            try
            {
                if (ReportNo != "")
                {
                    string sSql = "SELECT * FROM sysQueryReportMaster WHERE ReportNo='" + ReportNo + "'";
                    dtMain = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
                    if (dtMain.Rows.Count > 0)
                    {
                        sMainSQL = dtMain.Rows[0]["sReportSQL"].ToString();
                        //解析查询SQL
                        if (sMainSQL.ToLower().Contains("<userid>"))
                        {
                            sMainSQL = sMainSQL.Replace("<UserID>", BWS.ERP.Security.SecurityCenter.CurrentUserID);
                        }
                        if (sMainSQL.ToLower().Contains("<getdate>"))
                        {
                            sMainSQL = sMainSQL.Replace("<GetDate>", DateTime.Now.ToShortDateString());
                        }
                        sExecSQL = dtMain.Rows[0]["sExecSQL"].ToString();
                        sDealFields = dtMain.Rows[0]["sDealFields"].ToString();
                        sSortFields = dtMain.Rows[0]["sSortFields"].ToString();
                        //控制界面布局显示
                        btnSet.Visible = Convert.ToBoolean(dtMain.Rows[0]["bIsShowExecBtn"]);
                        btnSet.Text = dtMain.Rows[0]["sExecBtnText"].ToString() == "" ? "执行(&R)" : dtMain.Rows[0]["sExecBtnText"].ToString();
                        btnPrint.Visible = Convert.ToBoolean(dtMain.Rows[0]["bIsShowPrintBtn"]);
                        this.Text = this.Text == "" ? dtMain.Rows[0]["sReportName"].ToString() : this.Text;
                        IsChart = Convert.ToBoolean(dtMain.Rows[0]["bIsChart"].ToString());
                        IsAutoRun = Convert.ToBoolean(dtMain.Rows[0]["bIsAutoRun"].ToString());
                        if (!IsChart)
                        {
                            tbDetail.TabPages.Remove(tpChart);
                        }


                        sSql = "SELECT * FROM sysQueryReportDetail WHERE MainID=" + dtMain.Rows[0]["ID"].ToString() + " ORDER BY Sort";
                        dtDetail = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
                        //检测是否含有分组情况
                        if (dtDetail != null)
                        {
                            IsGroup = dtDetail.Select("bIsGroup").Length > 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化数据错误！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 创建Grid列
        /// </summary>
        private void CreateGridColumn()
        {
            try
            {
                gvSearch.Columns.Clear();
                int i = 0;
                List<DataRow> LDataRows = dtDetail.Select("bIsShow=1").ToList();
                if (IsGroup)
                {
                    string sDisGroupField = "";
                    foreach (var item in GetGroupFields().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        sDisGroupField += "'" + item + "',";
                    }
                    if (sDisGroupField != "")
                    {
                        sDisGroupField = "(" + sDisGroupField.Substring(0, sDisGroupField.Length - 1) + ")";
                        //将统计字段也加入Grid列中
                        LDataRows = dtDetail.Select("bIsShow=1 AND bIsGroup=1 AND ColumnFieldName IN " + sDisGroupField).Union(dtDetail.Select("bIsStat=1")).ToList();
                    }
                    else
                    {
                        throw new Exception("必须至少选择一列分组字段!");
                    }

                }
                foreach (DataRow dr in LDataRows)
                {
                    DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
                    col.FieldName = dr["ColumnFieldName"].ToString();
                    col.Caption = dr["ColumnCaption"].ToString();
                    col.Name = "col" + dr["ColumnFieldName"].ToString() + i.ToString();
                    col.Width = 100;
                    col.Visible = true;
                    col.VisibleIndex = i;
                    if (dr["ColumnType"].ToString() == "K")
                    {
                        DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit colItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                        colItem.AutoHeight = false;
                        colItem.Name = "repositoryItem" + dr["ColumnFieldName"].ToString() + i.ToString();
                        colItem.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
                        col.ColumnEdit = colItem;
                        gcSearch.RepositoryItems.Add(colItem);
                    }
                    //先计算有没有合计的，再计算计数
                    if (dr["bIsSum"].ToString() != "" && Convert.ToBoolean(dr["bIsSum"]))
                    {
                        col.SummaryItem.FieldName = dr["ColumnFieldName"].ToString();
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        //显示分组脚注后也要合计
                        gvSearch.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, dr["ColumnFieldName"].ToString(), col);


                    }
                    if (dr["bIsCount"].ToString() != "" && Convert.ToBoolean(dr["bIsCount"]))
                    {
                        col.SummaryItem.FieldName = dr["ColumnFieldName"].ToString();
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                        gvSearch.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, dr["ColumnFieldName"].ToString(), col);
                    }
                    gvSearch.Columns.Add(col);
                    i++;
                }

                //添加图表值字段到ComboBox中
                if (IsChart)
                {
                    //数据值
                    cbxChartType.SelectedIndex = 0;
                    DataTable dtTemp = dtDetail.Clone();
                    foreach (DataRow item in dtDetail.Select("bChartValue"))
                    {
                        //DataRow dr = dtTemp.NewRow();
                        //dr["sColumnFieldName"] = item["sColumnFieldName"];
                        //dr["sColumnCaption"] = item["sColumnCaption"];
                        //dtTemp.Rows.Add(dr);
                        cbxValueType.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(item["sColumnCaption"].ToString(), item["sColumnFieldName"]));
                    }
                    //cbxValueType.DataSource = dtTemp;
                    //cbxValueType.ValueMember = "sColumnFieldName";
                    //cbxValueType.DisplayMember = "sColumnCaption";


                    //比较值
                    DataTable dtField = dtDetail.Clone();
                    foreach (DataRow item in dtDetail.Select("bChartField"))
                    {
                        //DataRow dr = dtField.NewRow();
                        //dr["sColumnFieldName"] = item["sColumnFieldName"];
                        //dr["sColumnCaption"] = item["sColumnCaption"];
                        //dtField.Rows.Add(dr);
                        cbxField.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(item["sColumnCaption"].ToString(), item["sColumnFieldName"]));
                    }
                    //cbxField.DataSource = dtField;
                    //cbxField.ValueMember = "sColumnFieldName";
                    //cbxField.DisplayMember = "sColumnCaption";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建查询Grid列错误！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 初始化Grid数据
        /// </summary>
        /// <param name="pwhere">查询条件</param>
        private void InitGridData(string pwhere)
        {
            try
            {
                string sSql = "";
                if (IsGroup)
                {
                    string sGroup = GetGroupFields();
                    if (sGroup.Length > 0)
                    {
                        sSql = "SELECT " + sGroup + sDealFields + " FROM (" + sMainSQL + ") A WHERE " + pwhere + " GROUP BY " + sGroup.Substring(0, sGroup.Length - 1) + (sSortFields == "" ? "" : (" ORDER BY " + sSortFields));
                    }
                    else
                    {
                        throw new Exception("必须至少选择一列分组字段!");
                    }


                }
                else
                {
                    sSql = "SELECT " + sDealFields + " FROM (" + sMainSQL + ") A WHERE " + pwhere + (sSortFields == "" ? "" : (" ORDER BY " + sSortFields));
                }
                dtSearch = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
                gcSearch.DataSource = dtSearch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建查询Grid数据错误！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsbView_Click(object sender, EventArgs e)
        {
            if (IsGroup)
            {
                CreateGridColumn();
            }
            InitGridData("1=1 " + GetSearchFilterSQL());
            if (tbDetail.SelectedTabPageIndex == 1)
            {
                ShowChart();
            }
        }


        private void tsbClear_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in grbFilter.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    else if (item is DevExpress.XtraEditors.DateEdit)
                    {
                        ((DevExpress.XtraEditors.DateEdit)item).EditValue = null;
                        //item.Text = "";
                    }
                    else if (item is DevExpress.XtraEditors.TextEdit)
                    {
                        item.Text = "";
                    }
                    else if (item is DevExpress.XtraEditors.ComboBoxEdit)
                    {
                        ((DevExpress.XtraEditors.ComboBoxEdit)item).SelectedIndex = -1;
                    }
                    else if (item is DevExpress.XtraEditors.CheckEdit)
                    {
                        ((DevExpress.XtraEditors.CheckEdit)item).Checked = false;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("清除过滤条件错误！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtSearch.Rows.Count > 0)
                {
                    //DECO.Report.frmSelectReport frm = new DECO.Report.frmSelectReport("QueryReport" + ReportNo, UserID, "100");
                    //frm.AddReportData(dtSearch, "查询信息");
                    //frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请先查询出数据后再打印！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印错误，请关闭窗口重试！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsbSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtSearch.Rows.Count > 0)
                {
                    if (gvSearch.FocusedRowHandle >= 0 && sExecSQL != "")
                    {
                        if (MessageBox.Show("确认执行？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //解析执行SQL
                            foreach (DataColumn item in dtSearch.Columns)
                            {
                                if (sExecSQL.ToLower().Contains("<userid>"))
                                {
                                    sExecSQL = sExecSQL.Replace("<UserID>", BWS.ERP.Security.SecurityCenter.CurrentUserID);
                                }
                                if (sExecSQL.ToLower().Contains("<getdate>"))
                                {
                                    sExecSQL = sExecSQL.Replace("<GetDate>", DateTime.Now.ToShortDateString());
                                }
                                string sReplaceField = "<" + item.ColumnName + ">";
                                if (sExecSQL.Contains(sReplaceField))
                                {
                                    sExecSQL = sExecSQL.Replace(sReplaceField, gvSearch.GetDataRow(gvSearch.FocusedRowHandle)[item.ColumnName].ToString());
                                }
                            }
                            BWS.ERP.DataAccess.DbHelperSQL.ExecuteSql(sExecSQL);
                            MessageBox.Show("执行成功，请重新查询数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sExecSQL = dtMain.Rows[0]["sExecSQL"].ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请先查询出数据后再执行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("执行错误，请关闭窗口重试！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 生成过滤条件
        /// </summary>
        /// <returns></returns>
        private string GetSearchFilterSQL()
        {
            try
            {
                string sResult = "";
                foreach (Control item in grbFilter.Controls)
                {
                    if (item is TextBox && item.Text != "")
                    {
                        if (item.Tag.ToString().Contains("LIKE"))
                        {
                            sResult += " AND " + item.Tag.ToString() + " '%" + item.Text + "%'";
                        }
                        else
                        {
                            sResult += " AND " + item.Tag.ToString() + " '" + item.Text + "'";
                        }
                    }
                    else if (item is DevExpress.XtraEditors.TextEdit && item.Text != "")
                    {
                        if (item.Tag.ToString().Contains("LIKE"))
                        {
                            sResult += " AND " + item.Tag.ToString() + " '%" + item.Text + "%'";
                        }
                        else
                        {
                            sResult += " AND " + item.Tag.ToString() + " '" + item.Text + "'";
                        }
                    }
                    else if (item is DevExpress.XtraEditors.DateEdit)
                    {
                        if (item.Text != "")
                        {
                            sResult += " AND " + item.Tag.ToString() + " '" + item.Text + "'";
                        }
                    }
                    else if (item is DevExpress.XtraEditors.CheckEdit)
                    {
                        if (((DevExpress.XtraEditors.CheckEdit)item).Checked)
                        {
                            sResult += " AND " + item.Tag.ToString();
                        }
                    }


                }
                return sResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("生成过滤条件错误！" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "1=2";
            }
        }


        /// <summary>
        /// 界面上选择分组字段
        /// </summary>
        /// <returns></returns>
        private string GetGroupFields()
        {
            string sResult = "";
            try
            {
                //返回界面上选择分组字段
                foreach (Control item in grbGroup.Controls)
                {
                    if (item is DevExpress.XtraEditors.CheckEdit)
                    {
                        if (((DevExpress.XtraEditors.CheckEdit)item).Checked)
                        {
                            sResult += item.Tag.ToString() + ",";
                        }
                    }
                }
                return sResult;
            }
            catch (Exception)
            {
                //异常则返回所有分组字段
                if (dtDetail != null)
                {
                    foreach (DataRow item in dtDetail.Select("bIsShow=1 AND bIsGroup=1"))
                    {
                        sResult += item["sColumnFieldName"].ToString() + ",";
                    }
                }
                return sResult;
            }
        }


        private void tbDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbDetail.SelectedTabPageIndex == 1)
                {
                    ShowChart();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 显示图表
        /// </summary>
        private void ShowChart()
        {
            try
            {
                switch (cbxChartType.SelectedItem.ToString())
                {
                    case "柱图":
                        {
                            ShowBar();
                            break;
                        }
                    case "饼图":
                        {
                            ShowPie();
                            break;
                        }
                    case "线图":
                        {
                            ShowLine();
                            break;
                        }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 显示柱图
        /// </summary>
        private void ShowBar()
        {
            if (cbxValueType.SelectedText != null && cbxValueType.SelectedText != "")
            {
                if (dtSearch != null && dtSearch.Rows.Count > 0)
                {
                    chtMain.DataSource = dtSearch;
                    chtMain.Series.Clear();
                    //chtMain.Titles.Clear();
                    //ChartTitle title = new ChartTitle();
                    //title.Text = dtMain.Rows[0]["ReportName"].ToString();
                    //chtMain.Titles.Add(title);
                    foreach (DataRow item in dtDetail.Select("bChartValue"))
                    {
                        Series series = new Series(item["sColumnCaption"].ToString(), ViewType.Bar);
                        series.ArgumentDataMember = cbxField.SelectedText;
                        series.ValueDataMembers[0] = item["sColumnFieldName"].ToString();
                        chtMain.Series.Add(series);
                    }
                }



            }
        }


        /// <summary>
        /// 显示饼图
        /// </summary>
        private void ShowPie()
        {
            if (cbxValueType.SelectedText != null && cbxValueType.SelectedText != "")
            {
                if (dtSearch != null && dtSearch.Rows.Count > 0)
                {
                    chtMain.DataSource = dtSearch;
                    chtMain.Series.Clear();
                    //chtMain.Titles.Clear();
                    //ChartTitle title = new ChartTitle();
                    //title.Text = dtMain.Rows[0]["ReportName"].ToString();
                    //chtMain.Titles.Add(title);
                    foreach (DataRow item in dtDetail.Select("bChartValue"))
                    {
                        Series series = new Series(item["sColumnCaption"].ToString(), ViewType.Pie);
                        ((PiePointOptions)series.PointOptions).PointView = PointView.ArgumentAndValues;
                        ((PiePointOptions)series.PointOptions).PercentOptions.ValueAsPercent = false;
                        series.ArgumentDataMember = cbxField.SelectedText;
                        series.ValueDataMembers[0] = item["sColumnFieldName"].ToString();
                        chtMain.Series.Add(series);
                    }
                }
            }
        }


        /// <summary>
        /// 显示线图
        /// </summary>
        private void ShowLine()
        {
            if (cbxValueType.SelectedText != null && cbxValueType.SelectedText != "")
            {
                if (dtSearch != null && dtSearch.Rows.Count > 0)
                {
                    chtMain.DataSource = dtSearch;
                    chtMain.Series.Clear();


                    //chtMain.Titles.Clear();
                    //ChartTitle title = new ChartTitle();
                    //title.Text = dtMain.Rows[0]["ReportName"].ToString();
                    //chtMain.Titles.Add(title);
                    foreach (DataRow item in dtDetail.Select("bChartValue"))
                    {
                        Series series = new Series(item["sColumnCaption"].ToString(), ViewType.Line);
                        series.ArgumentDataMember = cbxField.SelectedText;
                        series.ValueDataMembers[0] = item["sColumnFieldName"].ToString();
                        chtMain.Series.Add(series);
                    }
                }
            }
        }


        private void cbxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbDetail.SelectedTabPageIndex == 1)
            {
                ShowChart();
            }
        }


        #endregion


        #region 属性设置
        private string _reportno = "";
        /// <summary>
        /// 查询报表编号
        /// </summary>
        public string ReportNo
        {
            get
            {
                return _reportno;
            }
            set
            {
                _reportno = value;
            }
        }
        #endregion


    }
}
