using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemManage
{
    public partial class frmsysQueryReportSet : BWS.ERP.BaseForm.frmMasterDetail
    {
        public frmsysQueryReportSet(int formid, string formtext)
            : base(formid, "sysQueryReportMasterDAL", "AND 1=1", "sReportNo")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtiControlColumn.DataBindings.Add("EditValue", bdsMain, "iControlColumn");
            txtiControlSpace.DataBindings.Add("EditValue", bdsMain, "iControlSpace");
            txtsDealFields.DataBindings.Add("EditValue", bdsMain, "sDealFields");
            txtsExecBtnText.DataBindings.Add("EditValue", bdsMain, "sExecBtnText");
            txtsExecSQL.DataBindings.Add("EditValue", bdsMain, "sExecSQL");
            txtsReportName.DataBindings.Add("EditValue", bdsMain, "sReportName");
            txtsReportNo.DataBindings.Add("EditValue", bdsMain, "sReportNo");
            txtsReportSQL.DataBindings.Add("EditValue", bdsMain, "sReportSQL");
            txtsSortFields.DataBindings.Add("EditValue", bdsMain, "sSortFields");
            chkbIsAutoRun.DataBindings.Add("EditValue", bdsMain, "bIsAutoRun");
            chkbIsChart.DataBindings.Add("EditValue", bdsMain, "bIsChart");
            chkbIsShowExecBtn.DataBindings.Add("EditValue", bdsMain, "bIsShowExecBtn");
            chkbIsShowPrintBtn.DataBindings.Add("EditValue", bdsMain, "bIsShowPrintBtn");
        }

        private void frmsysQueryReportSet_Load(object sender, EventArgs e)
        {
            AddDetailData("sysQueryReportDetailDAL", "MainID", "ID", "iSort");
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("sysQueryReportDetailDAL")];
            gcDetail.DataMember = "ds";
            DataStateChange(sender, e);
        }
        public override void DataStateChange(object sender, EventArgs e)
        {
            base.DataStateChange(sender, e);
            if (FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsEdit || FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsInsert)
            {
                gvDetail.OptionsBehavior.Editable = true;
                pnlDetailMenu.Enabled = true;
            }
            else
            {
                gvDetail.OptionsBehavior.Editable = false;
                pnlDetailMenu.Enabled = false;
            }
        }
        public override void initBase()
        {
            AddNotNullFields(new string[] { "txtsReportNo", "txtsReportName", "txtsReportSQL" });
            AddNotCopyFields(new string[] { "sUserID", "iFlag" });
            base.initBase();
        }
        public override void MasterAllScroll(object sender, EventArgs e)
        {
            base.MasterAllScroll(sender, e);
            AutoSetFieldNameToComboBox(((DataRowView)(bdsMain.Current))["sReportSQL"].ToString());
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("sysQueryReportDetailDAL")];
        }
        public override bool DoAppend()
        {
            base.DoAppend();
            //新增默认值
            BWS.ERP.Common.SystemPublic.GetBillNo(FormID, (DataRowView)bdsMain.Current);
            ((DataRowView)bdsMain.Current).Row["iControlSpace"] = 10;
            ((DataRowView)bdsMain.Current).Row["iControlColumn"] = 3;
            ((DataRowView)bdsMain.Current).Row["bIsShowPrintBtn"] = false;
            ((DataRowView)bdsMain.Current).Row["bIsShowExecBtn"] = false;
            ((DataRowView)bdsMain.Current).Row["bIsChart"] = false;
            ((DataRowView)bdsMain.Current).Row["bIsAutoRun"] = false;
            ((DataRowView)bdsMain.Current).Row["sDealFields"] = "*";
            bdsMain.EndEdit();
            return true;
        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            gvDetail.AddNewRow();
        }

        private void btnDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDetail.RowCount > 0 && gvDetail.FocusedRowHandle >= 0)
                {
                    gvDetail.DeleteRow(gvDetail.FocusedRowHandle);
                }
            }
            catch (Exception)
            {
            }

        }

        private void gvDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (gvDetail.RowCount == 1)
            {
                gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["iSort"] = gvDetail.RowCount;
            }
            else if (gvDetail.RowCount > 1)
            {
                gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["iSort"] = Convert.ToInt32(gvDetail.GetDataRow(gvDetail.RowCount - 2)["iSort"]) + 1;
            }
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bIsShow"] = 0;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bIsQuery"] = 0;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bChartField"] = 0;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bChartValue"] = 0;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bIsGroup"] = 0;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bIsCount"] = 0;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bIsSum"] = 0;
            gvDetail.GetDataRow(gvDetail.FocusedRowHandle)["bIsStat"] = 0;

        }
        /// <summary>
        /// 自动设置查询SQL中的字段到明细中的字段列
        /// </summary>
        private void AutoSetFieldNameToComboBox(string MainSQL)
        {
            try
            {
                cbxFieldName.Items.Clear();
                string sSql = "SELECT A.* FROM (" + MainSQL + ") A WHERE 1=2 ";
                DataTable dtTemp = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
                if (dtTemp != null)
                {
                    foreach (DataColumn item in dtTemp.Columns)
                    {
                        cbxFieldName.Items.Add(item.ColumnName);
                    }
                }

            }
            catch (Exception)
            {
            }
        }

        private void cbxFieldName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (bdsMain.Current != null)
            {
                if (cbxFieldName.Items.Count <= 0)
                {
                    AutoSetFieldNameToComboBox(((DataRowView)(bdsMain.Current))["sReportSQL"].ToString());
                }
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsBrowse)
            {
                if (bdsMain.Current != null)
                {

                }
            }
            //frmsysQueryReport frm=
        }

    }
}
