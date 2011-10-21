using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemBase
{
    public partial class frmbasSupplier : BWS.ERP.BaseForm.frmMasterDetail
    {
        public frmbasSupplier(int formid,string formtext):base(formid,"basSupplierMasterDAL"," AND 1=1","sSupplierID")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtCEOMobile.DataBindings.Add("EditValue", bdsMain, "sSupplierCEOMobile");
            txtCEOName.DataBindings.Add("EditValue", bdsMain, "sSupplierCEOName");
            txtsBankAccount.DataBindings.Add("EditValue", bdsMain, "sBankAccount");
            txtsBankAdrr.DataBindings.Add("EditValue", bdsMain, "sBankAdrr");
            txtsBankName.DataBindings.Add("EditValue", bdsMain, "sBankName");
            txtsChnAddr.DataBindings.Add("EditValue", bdsMain, "sChnAddr");
            txtsContactMan.DataBindings.Add("EditValue", bdsMain, "sContactMan");
            txtsContactMobile.DataBindings.Add("EditValue", bdsMain, "sContactMobile");
            txtsEmail.DataBindings.Add("EditValue", bdsMain, "sEmail");
            txtsEngAddr.DataBindings.Add("EditValue", bdsMain, "sEngAddr");
            txtsFax.DataBindings.Add("EditValue", bdsMain, "sFax");
            txtsHomepage.DataBindings.Add("EditValue", bdsMain, "sHomePage");
            txtsPostCode.DataBindings.Add("EditValue", bdsMain, "sPostCode");
            txtsRemark.DataBindings.Add("EditValue", bdsMain, "sRemark");
            txtsSupplierCName.DataBindings.Add("EditValue", bdsMain, "sSupplierCName");
            txtsSupplierEName.DataBindings.Add("EditValue", bdsMain, "sSupplierEName");
            txtsSupplierID.DataBindings.Add("EditValue", bdsMain, "sSupplierID");
            txtsSupplierSName.DataBindings.Add("EditValue", bdsMain, "sSupplierSName");
            txtsTax.DataBindings.Add("EditValue", bdsMain, "sTax");
            txtsTel.DataBindings.Add("EditValue", bdsMain, "sTel");
            lkpsSupplierTypeID.DataBindings.Add("EditValue", bdsMain, "sSupplierTypeID");
            BWS.ERP.Common.SystemPublic.InitLkpDataDict(lkpsSupplierTypeID, "1013");

        }

        private void frmbasSupplier_Load(object sender, EventArgs e)
        {
            AddDetailData("basSupplierDetailDAL", "MainID", "ID");
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("basSupplierDetailDAL")];
            gcDetail.DataMember = "ds";
            DataStateChange(sender, e);
        }
        public override bool DoAppend()
        {
            base.DoAppend();
            BWS.ERP.Common.SystemPublic.GetBillNo(FormID, (DataRowView)bdsMain.Current);
            bdsMain.EndEdit();
            return true;
        }
        public override void initBase()
        {
            AddNotNullFields(new string[] { "txtsSupplierID", "txtsSupplierCName", "txtsSupplierSName", "lkpsSupplierTypeID" });
            base.initBase();
        }
        public override void MasterAllScroll(object sender, EventArgs e)
        {
            base.MasterAllScroll(sender, e);
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("basSupplierDetailDAL")];
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
            gvDetail.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
        }
    }
}
