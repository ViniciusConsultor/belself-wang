using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemBase
{
    public partial class frmhrCompany : BWS.ERP.BaseForm.frmMasterDetail
    {
        bool IsShowShopInfo = true;
        public frmhrCompany(int formid, string formtext)
            : base(formid, "hrCompanyMasterDAL","AND 1=1","sCompanyID")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtsCompanyID.DataBindings.Add("EditValue", bdsMain, "sCompanyID");
            txtsCompanySName.DataBindings.Add("EditValue", bdsMain, "sCompanySName");
            txtsCompanyCName.DataBindings.Add("EditValue", bdsMain, "sCompanyCName");
            txtsCompanyEName.DataBindings.Add("EditValue", bdsMain, "sCompanyEName");
            txtsCorporation.DataBindings.Add("EditValue", bdsMain, "sCorporation");
            txtsTel.DataBindings.Add("EditValue", bdsMain, "sTel");
            txtsChnAddr.DataBindings.Add("EditValue", bdsMain, "sChnAddr");
            txtsChnTitle.DataBindings.Add("EditValue", bdsMain, "sChnTitle");
            txtsEmail.DataBindings.Add("EditValue", bdsMain, "sEmail");
            txtsEngAddr.DataBindings.Add("EditValue", bdsMain, "sEngAddr");
            txtsEngTitle.DataBindings.Add("EditValue", bdsMain, "sEngTitle");
            txtsFax.DataBindings.Add("EditValue", bdsMain, "sFax");
            txtsHomepage.DataBindings.Add("EditValue", bdsMain, "sHomePage");
            txtsPostCode.DataBindings.Add("EditValue", bdsMain, "sPostCode");
            txtsRemark.DataBindings.Add("EditValue", bdsMain, "sRemark");
            txtsTax.DataBindings.Add("EditValue", bdsMain, "sTax");
            picmlogo.DataBindings.Add("EditValue", bdsMain, "mlogo");
            BWS.ERP.Common.SystemPublic.InitLkpCurrency(lkpsCurrency);
            lkpsCurrency.AutoSetValue(ref gvDetail, "sCurrencyCName", "sCurrencyCName");

            IsShowShopInfo = bool.Parse(BWS.ERP.BasePublic.BasePublic.FormParaList(FormID)["IsShowShop"].ToString().ToLower());
            //通过参数来控制是否显示门店信息
            if (!IsShowShopInfo)
            {
                tcDetail.TabPages.Remove(tpShopInfo);
            }
        }

        private void frmhrCompany_Load(object sender, EventArgs e)
        {
            AddDetailData("hrCompanyDetailDAL", "MainID", "ID");
            AddDetailData("hrDepartmentDAL", "iCompanyID", "ID");
            AddDetailData("hrCompanyShopInfoDAL", "MainID", "ID");
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("hrCompanyDetailDAL")];
            gcDetail.DataMember = "ds";
            gcDept.DataSource = LDetailDataSet[LDetailDALName.IndexOf("hrDepartmentDAL")];
            gcDept.DataMember = "ds";
            gcShopInfo.DataSource = LDetailDataSet[LDetailDALName.IndexOf("hrCompanyShopInfoDAL")];
            gcShopInfo.DataMember = "ds";
            lkpsCurrency.DataBindings.Add("EditValue", LDetailDataSet[LDetailDALName.IndexOf("hrCompanyDetailDAL")], "ds.sCurrency");
            colbtnsCurrency.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(colbtnsCurrency_ButtonClick);
            
            DataStateChange(sender, e);
        }

        void colbtnsCurrency_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            lkpsCurrency.LookUpSelfClick(sender, e);
        }

        public override void initBase()
        {
            AddNotNullFields(new string[] { "txtsCompanyID", "txtsCompanySName", "txtsCompanyCName" });
            base.initBase();
        }
        public override void MasterAllScroll(object sender, EventArgs e)
        {
            base.MasterAllScroll(sender, e);
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("hrCompanyDetailDAL")];
            gcDept.DataSource = LDetailDataSet[LDetailDALName.IndexOf("hrDepartmentDAL")];
            gcShopInfo.DataSource = LDetailDataSet[LDetailDALName.IndexOf("hrCompanyShopInfoDAL")];
            lkpsCurrency.DataBindings.Clear();
            lkpsCurrency.DataBindings.Add("EditValue", LDetailDataSet[LDetailDALName.IndexOf("hrCompanyDetailDAL")], "ds.sCurrency");
        }

        public override void DataStateChange(object sender, EventArgs e)
        {
            base.DataStateChange(sender, e);
            if (FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsEdit || FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsInsert)
            {
                gvDetail.OptionsBehavior.Editable = true;
                gvDept.OptionsBehavior.Editable = true;
                gvShopInfo.OptionsBehavior.Editable = true;
                pnlDetailMenu.Enabled = true;
            }
            else
            {
                gvDetail.OptionsBehavior.Editable = false;
                gvDept.OptionsBehavior.Editable = false;
                gvShopInfo.OptionsBehavior.Editable = false;
                pnlDetailMenu.Enabled = false;
            }

        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            switch (tcDetail.SelectedTabPageIndex)
            {
                case 0:
                    {
                        gvDept.AddNewRow();
                        break;
                    }
                case 1:
                    {
                        gvDetail.AddNewRow();
                        break;
                    }
                case 2:
                    {
                        gvShopInfo.AddNewRow();
                        break;
                    }
            }            
        }

        private void btnDetailDelete_Click(object sender, EventArgs e)
        {
            switch (tcDetail.SelectedTabPageIndex)
            {
                case 0:
                    {
                        if (gvDept.FocusedRowHandle >= 0)
                        {
                            gvDept.DeleteRow(gvDept.FocusedRowHandle);
                        }
                        break;
                    }
                case 1:
                    {
                        if (gvDetail.FocusedRowHandle >= 0)
                        {
                            gvDetail.DeleteRow(gvDetail.FocusedRowHandle);
                        }
                        break;
                    }
                case 2:
                    {
                        if (gvShopInfo.FocusedRowHandle >= 0)
                        {
                            gvShopInfo.DeleteRow(gvShopInfo.FocusedRowHandle);
                        }
                        break;
                    }
            }     
        }

        private void picmlogo_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (picmlogo.Image == null)
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
                ((DataRowView)bdsMain.Current).Row["mlogo"] = null;
            }
        }

        private void gvDept_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvDept.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
        }

        private void gvDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvDetail.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
        }

        private void gvShopInfo_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvShopInfo.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
        }
    }
}
