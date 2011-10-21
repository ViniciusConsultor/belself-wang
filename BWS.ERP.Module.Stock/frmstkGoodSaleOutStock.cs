using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.Stock
{
    public partial class frmstkGoodSaleOutStock : BWS.ERP.BaseForm.frmMasterDetail
    {
        //是否打印收银条
        bool IsPrint = true;
        //初始化报表
        BWS.ERP.Report.InitReport report = new BWS.ERP.Report.InitReport("69FDB639-E151-4E9E-94F6-27C89D451AE5");
        public frmstkGoodSaleOutStock(int formid, string formtext)
            : base(formid, "stkGoodOutStockMasterDAL", " AND 1=2")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtfSaleAmount.DataBindings.Add("EditValue", bdsMain, "fSaleAmount");
            txtsStockOutNo.DataBindings.Add("EditValue", bdsMain, "sStockOutNo");
            //暂时还没有做会员功能
            //txtsVipCardInfo.DataBindings.Add("EditValue", bdsMain, "sVipCardInfo");
            txtsVipCardNo.DataBindings.Add("EditValue", bdsMain, "sVipCardNo");
            detdStockOutDate.DataBindings.Add("EditValue", bdsMain, "dStockOutDate");
            lkpsShopID.DataBindings.Add("EditValue", bdsMain, "sShopID");
            lkpsUserID.DataBindings.Add("EditValue", bdsMain, "sUserID");
            //初始化LookUp控件
            BWS.ERP.Common.SystemPublic.InitLkpShopID(lkpsShopID);
            BWS.ERP.Common.SystemPublic.InitLkpSystemUser(lkpsUserID, "sUserID");
            BWS.ERP.Common.SystemPublic.InitLkpGoodInfoFromStock(lkpsGoodID);
            IsPrint = bool.Parse(BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["IsPrint"].ToString().ToLower());
        }

        private void frmstkGoodSaleOutStock_Load(object sender, EventArgs e)
        {
            AddDetailData("stkGoodOutStockDetailDAL", "MainID", "ID");
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("stkGoodOutStockDetailDAL")];
            gcDetail.DataMember = "ds";
            btnPrintBill.Visible = bool.Parse(BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["IsShowPrintButton"].ToString().ToLower());
            DataStateChange(sender, e);
            //自动新增
            btnAdd_Click(sender, e);

        }

        public override void DataStateChange(object sender, EventArgs e)
        {
            base.DataStateChange(sender, e);
            if (FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsEdit || FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsInsert)
            {
                gvDetail.OptionsBehavior.Editable = true;
            }
            else
            {
                gvDetail.OptionsBehavior.Editable = false;
            }
        }
        public override void initBase()
        {
            //AddNotNullFields(new string[] { "txtsStockInNo", "lkpsSupplierID", "lkpsStockInType", "detdStockInDate" });
            //AddNotCopyFields(new string[] { "sStockInNo", "sUserID", "iFlag", "dInStockDate", "fTotalQuantity", "fTotalAmount", "sFlagName" });
            base.initBase();
        }
        public override bool DoAppend()
        {
            base.DoAppend();
            //新增默认值
            BWS.ERP.Common.SystemPublic.GetBillNo(FormID, (DataRowView)bdsMain.Current);
            ((DataRowView)bdsMain.Current).Row["dStockOutDate"] = DateTime.Now.Date;
            //新增的单据直接为已经审核的单据.因为是直接销售
            ((DataRowView)bdsMain.Current).Row["iFlag"] = 4;
            ((DataRowView)bdsMain.Current).Row["sShopID"] = "001";
            bdsMain.EndEdit();
            return true;
        }

        private void gvDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvDetail.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            gvDetail.GetFocusedDataRow()["fQuantity"] = 1;
            gvDetail.GetFocusedDataRow()["fDiscount"] = 100;
            gvDetail.GetFocusedDataRow()["fDiscountMoney"] = 0;
        }

        private void gvDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "sGoodID")
                {
                    string sSql = "SELECT sGoodID,sSpec,fBasePrice,fSalePrice,fQuantity,sGoodCName,sGoodEName,sGoodTypeID, "
                                + "sUnitID,sShopID,sGoodTypeName,sShopCName,sUnitName "
                                + "FROM vwstkGoodStkInfoView "
                                + "WHERE sGoodID LIKE '%" + e.Value.ToString() + "%'";
                    DataTable dtTemp = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
                    //如果为空则提示商品编号错误
                    if (dtTemp != null && dtTemp.Rows.Count == 0)
                    {
                        BWS.ERP.BaseControl.Public.SystemInfo("商品编号不存在！");
                        gvDetail.GetFocusedDataRow()["sGoodID"] = "";
                        gvDetail.FocusedColumn = gvDetail.Columns[0];
                    }
                    else
                    {
                        if (dtTemp.Rows.Count == 1)
                        {
                            if (Convert.ToInt32(dtTemp.Rows[0]["fQuantity"]) <= 0)
                            {
                                BWS.ERP.BaseControl.Public.SystemInfo("商品库存为0，不能够销售！");
                                gvDetail.GetFocusedDataRow()["sGoodID"] = "";
                                gvDetail.FocusedColumn = gvDetail.Columns[0];
                            }
                            else
                            {
                                gvDetail.GetFocusedDataRow()["sGoodID"] = dtTemp.Rows[0]["sGoodID"];
                                gvDetail.GetFocusedDataRow()["sGoodCName"] = dtTemp.Rows[0]["sGoodCName"];
                                gvDetail.GetFocusedDataRow()["sSpec"] = dtTemp.Rows[0]["sSpec"];
                                gvDetail.GetFocusedDataRow()["fSalePrice"] = dtTemp.Rows[0]["fSalePrice"];
                                gvDetail.GetFocusedDataRow()["fBasePrice"] = dtTemp.Rows[0]["fBasePrice"];
                                AutoSetDetail(true);
                                AppendDetaiData();
                            }
                        }
                        else
                        {
                            lkpsGoodID.SQL = sSql;
                            lkpsGoodID.LookUpSelfClick(sender, null);
                            if (lkpsGoodID.ReturnData.Rows.Count == 1)
                            {
                                if (Convert.ToInt32(lkpsGoodID.ReturnData.Rows[0]["fQuantity"]) <= 0)
                                {
                                    BWS.ERP.BaseControl.Public.SystemInfo("商品库存为0，不能够销售！");
                                    gvDetail.GetFocusedDataRow()["sGoodID"] = "";
                                    gvDetail.FocusedColumn = gvDetail.Columns[0];
                                }
                                else
                                {
                                    gvDetail.GetFocusedDataRow()["sGoodID"] = lkpsGoodID.ReturnData.Rows[0]["sGoodID"];
                                    gvDetail.GetFocusedDataRow()["sGoodCName"] = lkpsGoodID.ReturnData.Rows[0]["sGoodCName"];
                                    gvDetail.GetFocusedDataRow()["sSpec"] = lkpsGoodID.ReturnData.Rows[0]["sSpec"];
                                    gvDetail.GetFocusedDataRow()["fSalePrice"] = lkpsGoodID.ReturnData.Rows[0]["fSalePrice"];
                                    gvDetail.GetFocusedDataRow()["fBasePrice"] = lkpsGoodID.ReturnData.Rows[0]["fBasePrice"];
                                    AutoSetDetail(true);
                                    AppendDetaiData();
                                }
                            }
                        }

                    }
                }
                //数量和折扣
                else if (e.Column.FieldName == "fQuantity" || e.Column.FieldName == "fDiscount")
                {
                    AutoSetDetail(true);
                }
                //通过折扣金额计算折扣
                else if (e.Column.FieldName == "fDiscountMoney")
                {
                    if (Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fSalePrice"]) * Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fQuantity"]) != 0)
                    {
                        gvDetail.GetFocusedDataRow()["fDiscount"] = Math.Round(100 - 100 * Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fDiscountMoney"]) /
                                (Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fSalePrice"]) * Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fQuantity"])), 2);
                    }
                    AutoSetDetail(false);
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 自动计算销售金额，折扣
        /// </summary>
        /// <param name="isfDiscount">是否计算折扣金额</param>
        private void AutoSetDetail(bool isfDiscount)
        {
            try
            {
                if (gvDetail.GetFocusedDataRow() != null)
                {
                    if (isfDiscount)
                    {
                        //折扣金额=单价*数量*(1-折扣)
                        gvDetail.GetFocusedDataRow()["fDiscountMoney"] = Math.Round(Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fSalePrice"]) *
                                                                  Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fQuantity"]) *
                                                                  (1 - Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fDiscount"]) / 100), 2);
                    }
                    gvDetail.GetFocusedDataRow()["fAmount"] = Math.Round(Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fSalePrice"]) *
                                                                  Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fQuantity"]) -
                                                                  Convert.ToDecimal(gvDetail.GetFocusedDataRow()["fDiscountMoney"]), 2);
                    gvDetail.GetFocusedDataRow().EndEdit();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 增加明细数据
        /// </summary>
        private void AppendDetaiData()
        {
            try
            {
                bool CanAdd = true;
                if (gvDetail.RowCount > 0)
                {
                    for (int i = 0; i < gvDetail.RowCount; i++)
                    {
                        if (gvDetail.FocusedRowHandle >= 0)
                        {
                            if (gvDetail.GetDataRow(i)["sGoodID"].ToString() == "")
                            {
                                CanAdd = false;
                            }
                        }
                        else if (gvDetail.GetFocusedDataRow() != null && gvDetail.GetFocusedDataRow()["sGoodID"].ToString() == "")
                        {
                            CanAdd = false;
                        }
                    }
                }
                if (CanAdd)
                {
                    gvDetail.AddNewRow();
                    gvDetail.GetFocusedDataRow().EndEdit();
                }
            }
            catch (Exception)
            {
            }
        }

        private void gvDetail_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (IsFirstLoad && gvDetail.GetFocusedDataRow() != null)
            {
                if (gvDetail.GetFocusedDataRow()["sGoodID"].ToString() == "")
                {
                    gvDetail.FocusedColumn = gvDetail.Columns[0];
                }
            }
        }

        public override void MasterAllScroll(object sender, EventArgs e)
        {
            base.MasterAllScroll(sender, e);
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("stkGoodOutStockDetailDAL")];
            lkpsGoodID.DataBindings.Clear();
            lkpsGoodID.DataBindings.Add("EditValue", LDetailDataSet[LDetailDALName.IndexOf("stkGoodOutStockDetailDAL")], "ds.sGoodID");
        }
        private void frmstkGoodSaleOutStock_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //按ESC退出
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                //销售员
                else if (e.KeyCode == Keys.F1)
                {
                    lkpsUserID.Focus();
                }
                //会员卡
                else if (e.KeyCode == Keys.F2)
                {
                    txtsVipCardNo.Focus();
                }
                //收款结账
                else if (e.KeyCode == Keys.ShiftKey)
                {
                    if (gvDetail.RowCount > 0)
                    {
                        //去除最后的空行
                        gvDetail.MoveLast();
                        if (gvDetail.GetFocusedDataRow()["sGoodID"].ToString() == "")
                        {
                            gvDetail.DeleteRow(gvDetail.FocusedRowHandle);
                        }
                        gvDetail.Columns["fAmount"].SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Sum, "{0:0.00}");
                        ((DataRowView)bdsMain.Current).Row["fSaleAmount"] = gvDetail.Columns["fAmount"].SummaryItem.SummaryValue;
                        if (gvDetail.RowCount > 0)
                        {
                            frmstkGoodSaleOutStockCheckOut frm = new frmstkGoodSaleOutStockCheckOut(gvDetail.Columns["fAmount"].SummaryItem.SummaryValue.ToString());
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                ((DataRowView)bdsMain.Current).Row["fPayMoney"] = frm.fPayMoney;
                                bdsMain.EndEdit();
                                //先打印收银条再保存单据
                                PrintBill();
                                //保存,不显示保存提示
                                ShowSaveInfo = false;
                                btnSave_Click(sender, null);
                                //保存以后再自动新增
                                btnAdd_Click(sender, null);
                            }
                        }
                    }
                }
                    //删除交易明细
                else if (e.KeyCode == Keys.Delete)
                {
                    if (gvDetail.FocusedRowHandle >= 0)
                    {
                        gvDetail.DeleteRow(gvDetail.FocusedRowHandle);
                    }
                }
                else if (e.KeyCode == Keys.F12)
                {
                    if (gvDetail.RowCount > 0)
                    {
                        LDetailDataSet[LDetailDALName.IndexOf("stkGoodOutStockDetailDAL")].Tables[0].Clear();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void gcDetail_Click(object sender, EventArgs e)
        {
            //从表也默认就新增
            AppendDetaiData();
            //为了解决第一次新增时 Grid焦点行为负数的问题
            txtsVipCardInfo.Focus();
            gcDetail.Focus();
        }
        /// <summary>
        /// 打印收银条
        /// </summary>
        private void PrintBill()
        {
            try
            {
                if (IsPrint)
                {
                    report.ShowPrintDialog = false;
                    report.AddReportData((DataRowView)bdsMain.Current, "dtMain");
                    report.AddReportData(LDetailDataSet[LDetailDALName.IndexOf("stkGoodOutStockDetailDAL")].Tables[0], "dtDetail");
                    if (BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["PrintOrPreview"].ToString().ToLower() == "print")
                    {
                        report.PrintReport();
                    }
                    else
                    {
                        report.PreviewReport();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            btnPrint_Click(sender, e);
        }

        public override void DoPrint()
        {
            base.DoPrint();
            report.AddReportData((DataRowView)bdsMain.Current, "dtMain");
            report.AddReportData(LDetailDataSet[LDetailDALName.IndexOf("stkGoodOutStockDetailDAL")].Tables[0], "dtDetail");
            report.ReportMenu.Show(btnPrintBill, new Point(0, btnPrintBill.Height));
        }
    }
}
