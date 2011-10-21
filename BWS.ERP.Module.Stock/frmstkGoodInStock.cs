using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.Stock
{
    public partial class frmstkGoodInStock : BWS.ERP.BaseForm.frmMasterDetail
    {
        //初始化报表
        BWS.ERP.Report.InitReport report = new BWS.ERP.Report.InitReport("E546F390-5647-4AA7-99D8-7F55C07375B4");
        public frmstkGoodInStock(int formid,string formtext):base(formid,"stkGoodInStockMasterDAL","AND 1=1","sStockInNo")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtfTotalAmount.DataBindings.Add("EditValue", bdsMain, "fTotalAmount");
            txtfTotalQuantity.DataBindings.Add("EditValue", bdsMain, "fTotalQuantity");
            txtsRemark.DataBindings.Add("EditValue", bdsMain, "sRemark");
            txtsStockInNo.DataBindings.Add("EditValue", bdsMain, "sStockInNo");
            txtsTradeBillNo.DataBindings.Add("EditValue", bdsMain, "sTradeBillNo");
            detdStockInDate.DataBindings.Add("EditValue", bdsMain, "dStockInDate");
            lkpsBussinessManID.DataBindings.Add("EditValue", bdsMain, "sBussinessManID");
            lkpsStockInType.DataBindings.Add("EditValue", bdsMain, "sStockInType");
            lkpsSupplierID.DataBindings.Add("EditValue", bdsMain, "sSupplierID");
            lkpFlag.DataBindings.Add("EditValue", bdsMain, "iFlag");
            BWS.ERP.Common.SystemPublic.InitLkpDataDict(lkpsStockInType, "1016");
            BWS.ERP.Common.SystemPublic.InitLkpSystemUser(lkpsBussinessManID,"sUserID");
            BWS.ERP.Common.SystemPublic.InitLkpSupplier(lkpsSupplierID,"sSupplierID");
            BWS.ERP.Common.SystemPublic.InitLkpGoodInfo(lkpsGoodID);
            BWS.ERP.Common.SystemPublic.InitLkpFlag(lkpFlag);
            
            //lkpFlag.AutoSetValue(ref gvMain, "sFlagName", "sFlagName");

        }

        private void frmstkGoodInStock_Load(object sender, EventArgs e)
        {
            AddDetailData("stkGoodInStockDetailDAL", "MainID", "ID");
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("stkGoodInStockDetailDAL")];
            gcDetail.DataMember = "ds";

            lkpsGoodID.DataBindings.Add("EditValue", LDetailDataSet[LDetailDALName.IndexOf("stkGoodInStockDetailDAL")], "ds.sGoodID");
            colbtnsGoodID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(colbtnsGoodID_ButtonClick);

            lkpsGoodID.AutoSetValue(ref gvDetail, "sGoodID", "sGoodID");
            lkpsGoodID.AutoSetValue(ref gvDetail, "sGoodCName", "sGoodCName");
            lkpsGoodID.AutoSetValue(ref gvDetail, "sUnitCName", "sUnitCName");
            lkpsGoodID.AutoSetValue(ref gvDetail, "fBasePrice", "fBasePrice");
            lkpsGoodID.AutoSetValue(ref gvDetail, "fSalePrice", "fSalePrice");
            lkpFlag.AutoSetValue(ref gvMain, "sFlagName", "sFlagName");
            lkpsStockInType.AutoSetValue(ref gvMain, "sStockInTypeName", "sDictDataCName");
            DataStateChange(sender, e);

        }

        void colbtnsGoodID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            lkpsGoodID.LookUpSelfClick(sender, e);
        }

        public override void DataStateChange(object sender, EventArgs e)
        {
            base.DataStateChange(sender, e);
            if (FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsEdit || FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsInsert)
            {
                gvDetail.OptionsBehavior.Editable = true;
                pnlDetailMenu.Enabled = true;
                btnAuditing.Enabled = false;
                btnUnAuditing.Enabled = false;
            }
            else
            {
                gvDetail.OptionsBehavior.Editable = false;
                pnlDetailMenu.Enabled = false;
                btnAuditing.Enabled = true;
                btnUnAuditing.Enabled = true;
            }
        }
        public override void initBase()
        {
            AddNotNullFields(new string[] { "txtsStockInNo", "lkpsSupplierID", "lkpsStockInType","detdStockInDate" });
            AddNotCopyFields(new string[] { "sStockInNo", "sUserID", "iFlag", "dInStockDate","fTotalQuantity","fTotalAmount","sFlagName" });
            base.initBase();
        }
        public override void MasterAllScroll(object sender, EventArgs e)
        {
            base.MasterAllScroll(sender, e);
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("stkGoodInStockDetailDAL")];
            lkpsGoodID.DataBindings.Clear();
            lkpsGoodID.DataBindings.Add("EditValue", LDetailDataSet[LDetailDALName.IndexOf("stkGoodInStockDetailDAL")], "ds.sGoodID");
        }
        public override bool DoAppend()
        {
            base.DoAppend();
            //新增默认值
            BWS.ERP.Common.SystemPublic.GetBillNo(FormID, (DataRowView)bdsMain.Current);
            ((DataRowView)bdsMain.Current).Row["sBussinessManID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            ((DataRowView)bdsMain.Current).Row["dStockInDate"] = DateTime.Now.Date;
            ((DataRowView)bdsMain.Current).Row["sStockInType"] = "001";
            bdsMain.EndEdit();
            return true;
        }

        public override bool DoBeforeSave()
        {
            //保存前汇总数量和金额
            if (gvDetail.RowCount > 0)
            {
                gvDetail.Columns["fQuantity"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:0.00}");
                gvDetail.Columns["fAmount"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:0.00}");
                ((DataRowView)bdsMain.Current).Row["fTotalQuantity"] = gvDetail.Columns["fQuantity"].SummaryItem.SummaryValue;
                ((DataRowView)bdsMain.Current).Row["fTotalAmount"] = gvDetail.Columns["fAmount"].SummaryItem.SummaryValue;
                bdsMain.EndEdit();
            }
            return base.DoBeforeSave();
        }
        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            gvDetail.AddNewRow();
            
        }

        private void btnDetailDelete_Click(object sender, EventArgs e)
        {
            if (gvDetail.FocusedRowHandle >= 0)
            {
                gvDetail.DeleteRow(gvDetail.FocusedRowHandle);
            }
        }

        private void gvDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //LDetailDataSet[LDetailDALName.IndexOf("stkGoodInStockDetailDAL")].AcceptChanges();
            gvDetail.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            gvDetail.GetFocusedDataRow()["iSort"] = gvDetail.RowCount;
            gvDetail.GetFocusedDataRow()["fQuantity"] = 0;
            //gvDetail.GetFocusedDataRow()["sGoodID"] = "1211";
        }

        private void gvDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "fQuantity" || e.Column.FieldName == "fSalePrice")
            {
                gvDetail.SetFocusedRowCellValue("fAmount",
                    decimal.Parse(gvDetail.GetFocusedDataRow()["fSalePrice"].ToString()) * decimal.Parse(gvDetail.GetFocusedDataRow()["fQuantity"].ToString()));
            }
        }
        public override void DoPrint()
        {
            base.DoPrint();
            report.AddReportData((DataRowView)bdsMain.Current,"主表");
            report.AddReportData(LDetailDataSet[LDetailDALName.IndexOf("stkGoodInStockDetailDAL")].Tables[0], "入库明细");
            report.ReportMenu.Show(btnPrint, new Point(0, btnPrint.Height));
        }

        private void btnAuditing_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BWS.ERP.Security.SecurityCenter.IsAdmin)
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("您没有审核权限！");
                    return;
                }
                if (bdsMain.Current != null && ((DataRowView)bdsMain.Current).Row["iFlag"].ToString() != "4")
                {
                    if (BWS.ERP.BaseControl.Public.SystemInfo("是否完成审核？", 4) == DialogResult.Yes)
                    {
                        string sSql = "UPDATE stkGoodInStockMaster SET iFlag=4 WHERE ID=" + BillID.ToString();
                        BWS.ERP.DataAccess.DbHelperSQL.ExecuteSql(sSql);
                        ((DataRowView)bdsMain.Current).Row["iFlag"] = 4;
                        bdsMain.EndEdit();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnUnAuditing_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BWS.ERP.Security.SecurityCenter.IsAdmin)
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("您没有反审核权限！");
                    return;
                }
                if (bdsMain.Current != null && ((DataRowView)bdsMain.Current).Row["iFlag"].ToString() == "4")
                {
                    if (BWS.ERP.BaseControl.Public.SystemInfo("是否反审核？", 4) == DialogResult.Yes)
                    {
                        string sSql = "UPDATE stkGoodInStockMaster SET iFlag=2 WHERE ID=" + BillID.ToString();
                        BWS.ERP.DataAccess.DbHelperSQL.ExecuteSql(sSql);
                        ((DataRowView)bdsMain.Current).Row["iFlag"] = 2;
                        bdsMain.EndEdit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void DoView()
        {
            BWS.ERP.BaseForm.frmSearchForm frmSearch = new BWS.ERP.BaseForm.frmSearchForm();
            frmSearch.AddSearchItem("入库单号", "sStockInNo", BWS.ERP.BasePublic.FiledType.S);
            frmSearch.AddSearchItem("供应商", "sSupplierCName", BWS.ERP.BasePublic.FiledType.S);
            frmSearch.AddSearchItem("入库类型", "sStockInTypeName", BWS.ERP.BasePublic.FiledType.S);
            frmSearch.AddSearchItem("入库员", "sBussinessManName", BWS.ERP.BasePublic.FiledType.S);
            frmSearch.AddSearchItem("入库日期", "dStockInDate", BWS.ERP.BasePublic.FiledType.D);
            frmSearch.AddSearchItem("送货单号", "sTradeBillNo", BWS.ERP.BasePublic.FiledType.S);
            if (frmSearch.ShowDialog() == DialogResult.OK)
            {
                MasterFilerSQL = " AND " + frmSearch.SearchSQL;
            }
            base.DoView();
        }
    }
}
