﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;

namespace BWS.ERP.Controls
{
    public partial class frmLookUpSearch : DevExpress.XtraEditors.XtraForm
    {
        private List<string> LColumnText = new List<string>();
        private List<string> LDisplayFields = new List<string>();
        private string sDataSQL;
        private DataSet dsSearch;
        private string sEditFormName;
        private string sEditFormFilter;
        private int EditFormID;

        private DataTable _dt = new DataTable();

        public frmLookUpSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化选择结果窗体
        /// </summary>
        /// <param name="sql">查询SQL</param>
        /// <param name="columntext">列显示名称</param>
        /// <param name="field">列显示字段</param>
        /// <param name="fromtext">窗体标题</param>
        /// <param name="ismulti">是否支持多选</param>
        /// <param name="isedit">是否显示编辑按钮</param>
        /// <param name="seditform">弹出编辑窗体的名称</param>
        public frmLookUpSearch(string sql, string columntext, string field, string fromtext, bool ismulti, bool isedit, string seditform, string seditformfilter, int editformid)
        {
            InitializeComponent();
            sDataSQL = sql;
            sEditFormName = seditform;
            sEditFormFilter = seditformfilter;
            EditFormID = editformid;
            //设置编辑按钮是否显示
            btnEdit.Visible = isedit;
            //将列显示名分割
            if (columntext != null)
            {
                foreach (string s in columntext.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    LColumnText.Add(s);
                }
            }
            //将显示字段分割
            if (field != null)
            {
                foreach (string s in field.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    LDisplayFields.Add(s);
                }
            }
            this.Text = "选择" + fromtext;
            gvSearch.OptionsSelection.MultiSelect = ismulti;
        }

        private void frmLookUpSearch_Load(object sender, EventArgs e)
        {
            //设置GRID列显示
            int iCount;
            if (LColumnText.Count > LDisplayFields.Count)
            {
                iCount = LDisplayFields.Count;
            }
            else
            {
                iCount = LColumnText.Count;
            }
            for (int i = 0; i < iCount; i++)
            {
                DevExpress.XtraGrid.Columns.GridColumn clm = new DevExpress.XtraGrid.Columns.GridColumn();
                clm.Name = "clm" + LDisplayFields[i];
                clm.Caption = LColumnText[i];
                clm.FieldName = LDisplayFields[i];
                clm.Width = 100;
                clm.Visible = true;
                clm.VisibleIndex = i;
                gvSearch.Columns.Add(clm);
            }
            //获取数据源
            dsSearch = BWS.ERP.DataAccess.DbHelperSQL.Query(sDataSQL);
            gcSearch.DataSource = dsSearch;
            gcSearch.DataMember = "ds";
            gvSearch.BestFitColumns();

        }

        /// <summary>
        /// 以DataTable形式返回结果，单选的话结果中数据表只有一条记录
        /// </summary>
        public DataTable ReturnData
        {
            get
            {
                return _dt;
            }
            set
            {
                _dt = value;
            }
        }

        private void gcSearch_DoubleClick(object sender, EventArgs e)
        {
            if (gvSearch.GetFocusedDataRow() != null)
            {
                btnSelect_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //获取数据源
            dsSearch = BWS.ERP.DataAccess.DbHelperSQL.Query(sDataSQL);
            gcSearch.DataSource = dsSearch;
            gcSearch.DataMember = "ds";
            gvSearch.BestFitColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ReturnData = dsSearch.Tables[0].Clone();
            //多选模式
            if (gvSearch.OptionsSelection.MultiSelect)
            {
                for (int i = 0; i < gvSearch.GetSelectedRows().Length; i++)
                {
                    if (gvSearch.GetSelectedRows()[i] > 0)
                    {
                        ReturnData.ImportRow(gvSearch.GetDataRow(gvSearch.GetSelectedRows()[i]));
                    }
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                //单选模式
                ReturnData.ImportRow(gvSearch.GetFocusedDataRow());
                DialogResult = DialogResult.OK;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmsSave.Show((DevExpress.XtraEditors.SimpleButton)sender, new Point(0, btnSave.Height));
        }

        private void tsmHtml_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.html(网页文件)|*.html";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gvSearch.ExportToHtml(saveFileDialog1.FileName);
            }
        }

        private void tsmExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.xls(Excel文件)|*.xls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gvSearch.ExportToXls(saveFileDialog1.FileName);
            }
        }

        private void tsmWord_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.doc(Word文件)|*.doc";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gvSearch.ExportToRtf(saveFileDialog1.FileName);
            }
        }

        private void tsmPdf_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.pdf(pdf文件)|*.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gvSearch.ExportToPdf(saveFileDialog1.FileName);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Form formobj = (Form)Assembly.LoadFile(Application.StartupPath + @"\SystemLib\" + tvMemu.FocusedNode.GetValue("FormDLL").ToString()).CreateInstance(tvMemu.FocusedNode.GetValue("form").ToString(), false, BindingFlags.CreateInstance, null, new object[] { GetFormID(Convert.ToInt32(tvMemu.FocusedNode.GetValue("ID"))), tvMemu.FocusedNode.GetValue("grname") }, null, null);
            string DLLName = Application.StartupPath + @"\SystemLib\" + sEditFormName.Replace(BWS.ERP.BaseControl.Public.GetLastSubString(sEditFormName, "."), "dll");
            string EXEName = Application.StartupPath + @"\SystemLib\" + sEditFormName.Replace(BWS.ERP.BaseControl.Public.GetLastSubString(sEditFormName, "."), "exe");
            string FileName = "";
            if (System.IO.File.Exists(DLLName))
            {
                FileName = DLLName;
            }
            else if (System.IO.File.Exists(EXEName))
            {
                FileName = EXEName;
            }
            else
            {
                BWS.ERP.BaseControl.Public.SystemInfo("系统组件" + sEditFormName + "不存在", true);
                return;
            }

            try
            {
                //Form formobj = (Form)Assembly.LoadFile(Application.StartupPath + @"\DECOERP.exe").CreateInstance("DECOERP.frmBasDict", false, BindingFlags.CreateInstance, null, new object[] { 10000, "数据字典", "dcNo=1003" }, null, null);
                Form formobj = (Form)Assembly.LoadFile(FileName).CreateInstance(sEditFormName, false, BindingFlags.CreateInstance, null, new object[] { EditFormID, "", sEditFormFilter }, null, null);
                formobj.StartPosition = FormStartPosition.CenterScreen;
                formobj.WindowState = FormWindowState.Normal;
                formobj.ShowDialog();
            }
            catch (Exception ex)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("系统组件中窗体对象不存在!\r\n" + ex.Message, true);
            }
        }

    }
}