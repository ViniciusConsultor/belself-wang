using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemBase
{
    public partial class frmsalGoodInfo : BWS.ERP.BaseForm.frmMasterDetail
    {
        string sDefaultShop = "";
        string sDefaultUnit = "";
        string sDefaultType = "";
        public frmsalGoodInfo(int formid,string formtext):base(formid,"salGoodInfoMasterDAL","AND 1=1","sGoodID")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtsGoodCName.DataBindings.Add("EditValue", bdsMain, "sGoodCName");
            txtsGoodEName.DataBindings.Add("EditValue", bdsMain, "sGoodEName");
            txtsGoodID.DataBindings.Add("EditValue", bdsMain, "sGoodID");
            txtsRemark.DataBindings.Add("EditValue", bdsMain, "sRemark");
            lkpsGoodTypeID.DataBindings.Add("EditValue", bdsMain, "sGoodTypeID");
            lkpsUnitID.DataBindings.Add("EditValue", bdsMain, "sUnitID");
            chkbIsStop.DataBindings.Add("EditValue", bdsMain, "bIsStop");
            lkpsShopID.DataBindings.Add("EditValue", bdsMain, "sShopID");
            BWS.ERP.Common.SystemPublic.InitLkpDataDict(lkpsUnitID, "1015");
            BWS.ERP.Common.SystemPublic.InitLkpDataDict(lkpsGoodTypeID, "1014");
            BWS.ERP.Common.SystemPublic.InitLkpShopID(lkpsShopID);

            //获取参数值
            sDefaultShop = BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["DefaultShop"] == null ? "" : BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["DefaultShop"].ToString();
            sDefaultType = BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["DefaultType"] == null ? "" : BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["DefaultType"].ToString();
            sDefaultUnit = BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["DefaultUnit"] == null ? "" : BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["DefaultUnit"].ToString();

        }

        private void frmsalGoodInfo_Load(object sender, EventArgs e)
        {
            AddDetailData("salGoodInfoDetailDAL", "MainID", "ID");
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("salGoodInfoDetailDAL")];
            gcDetail.DataMember = "ds";
            DataStateChange(sender, e);
        }

        public override void initBase()
        {
            AddNotNullFields(new string[] { "txtsGoodCName", "txtsGoodID", "lkpsGoodTypeID", "lkpsUnitID", "lkpsShopID" });
            base.initBase();
        }

        public override bool DoAppend()
        {
            base.DoAppend();
            ((DataRowView)bdsMain.Current).Row["bIsStop"] = 0;
            if (sDefaultUnit != "")
            {
                ((DataRowView)bdsMain.Current).Row["sUnitID"] = sDefaultUnit;
            }
            if (sDefaultType != "")
            {
                ((DataRowView)bdsMain.Current).Row["sGoodTypeID"] = sDefaultType;
            }
            if (sDefaultShop != "")
            {
                ((DataRowView)bdsMain.Current).Row["sShopID"] = sDefaultShop;
            }
            bdsMain.EndEdit();
            return true;
        }
        public override void MasterAllScroll(object sender, EventArgs e)
        {
            base.MasterAllScroll(sender, e);
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("salGoodInfoDetailDAL")];
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

        private void gvDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvDetail.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            gvDetail.GetFocusedDataRow()["bIsStop"] = 0;
            gvDetail.GetFocusedDataRow()["fDiscount"] = 100;
            gvDetail.GetFocusedDataRow()["fBasePrice"] = 0;
            gvDetail.GetFocusedDataRow()["fSalePrice"] = 0;
            gvDetail.GetFocusedDataRow()["fSupplierSalePrice"] = 0;
            gvDetail.GetFocusedDataRow()["dPriceDate"] = DateTime.Now.Date;
            gvDetail.GetFocusedDataRow()["iSort"] = gvDetail.RowCount;
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

        public override bool DoBeforeSave()
        {
            base.DoBeforeSave();
            if (LDetailDataSet[LDetailDALName.IndexOf("salGoodInfoDetailDAL")].Tables[0].Select("bIsStop=0").Length > 1)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("明细数据中不允许存在多条可用价格，请确认！", true);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
