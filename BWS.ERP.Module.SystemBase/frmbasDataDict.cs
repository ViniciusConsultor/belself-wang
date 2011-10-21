using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemBase
{
    public partial class frmbasDataDict : BWS.ERP.BaseForm.frmMasterDetail
    {
        public frmbasDataDict(int formid, string formtext)
            : base(formid, "basDataDictMasterDAL")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtsDictCategoryNo.DataBindings.Add("EditValue", bdsMain, "sDictCategoryNo");
            txtsDictCategoryCName.DataBindings.Add("EditValue", bdsMain, "sDictCategoryCName");
            txtsDictCategoryEName.DataBindings.Add("EditValue", bdsMain, "sDictCategoryEName");
        }

        public override void initBase()
        {
            AddNotNullFields(new string[] { "txtsDictCategoryNo", "txtsDictCategoryCName" });
            base.initBase();
        }

        private void frmbasDictData_Load(object sender, EventArgs e)
        {
            AddDetailData("basDataDictDetailDAL", "MainID", "ID", "sDictDataNo");
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("basDataDictDetailDAL")];
            gcDetail.DataMember = "ds";
            DataStateChange(sender, e);
        }

        public override void MasterAllScroll(object sender, EventArgs e)
        {
            base.MasterAllScroll(sender, e);
            gcDetail.DataSource = LDetailDataSet[LDetailDALName.IndexOf("basDataDictDetailDAL")];
        }

        public override void DataStateChange(object sender, EventArgs e)
        {
            base.DataStateChange(sender, e);
            if (FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsEdit || FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsInsert)
            {
                this.gvDetail.OptionsBehavior.Editable = true;
                pnlDetailMenu.Enabled = true;
            }
            else
            {
                this.gvDetail.OptionsBehavior.Editable = false;
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

        public override void btnView_Click(object sender, EventArgs e)
        {
            base.btnView_Click(sender, e);
            //RegisterMethod("basDataDictMasterDAL", true);
            //bdsMain.DataSource = GetModelList(pWhere);
        }

        private void gvDetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvDetail.GetFocusedDataRow()["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            gvDetail.GetFocusedDataRow()["bIsStop"] = 0;
        }
    }
}
