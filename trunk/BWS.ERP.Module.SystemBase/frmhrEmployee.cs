using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemBase
{
    public partial class frmhrEmployee : BWS.ERP.BaseForm.frmSingleForm
    {
        public frmhrEmployee(int formid, string formtext)
            : base(formid,"hrEmployeeDAL")
        {
            InitializeComponent();
            if (formtext != "")
            {
                this.Text = formtext;
            }
            txtsEmpNo.DataBindings.Add("EditValue", bdsMain, "sEmpNo");
            txtsEmpCName.DataBindings.Add("EditValue", bdsMain, "sEmpCName");
            txtsEmpEName.DataBindings.Add("EditValue", bdsMain, "sEmpEName");
            cbxsSex.DataBindings.Add("EditValue", bdsMain, "sSex");
            txtsInsureID.DataBindings.Add("EditValue", bdsMain, "sInsureID");
            txtsPayMentID.DataBindings.Add("EditValue", bdsMain, "sPayMentID");
            txtsCallTitle.DataBindings.Add("EditValue", bdsMain, "sCallTitle");
            txtsComputerTechnolic.DataBindings.Add("EditValue", bdsMain, "sComputerTechnolic");
            txtsEmail.DataBindings.Add("EditValue", bdsMain, "sEmail");
            txtsEmpContractID.DataBindings.Add("EditValue", bdsMain, "sEmpContractID");
            txtsFamilyAddr.DataBindings.Add("EditValue", bdsMain, "sFamilyAddr");
            txtsFamilyContactTel.DataBindings.Add("EditValue", bdsMain, "sFamilyContactTel");
            txtsFamilyMember.DataBindings.Add("EditValue", bdsMain, "sFamilyMember");
            txtsGraduateInstitute.DataBindings.Add("EditValue", bdsMain, "sGraduateInstitute");
            txtsIdentityCard.DataBindings.Add("EditValue", bdsMain, "sIdentityCard");
            txtsNativePlace.DataBindings.Add("EditValue", bdsMain, "sNativePlace");
            txtsOtherContact.DataBindings.Add("EditValue", bdsMain, "sOtherContact");
            txtsPersonContactTel.DataBindings.Add("EditValue", bdsMain, "sPersonContactTel");
            txtsPosition.DataBindings.Add("EditValue", bdsMain, "sPosition");
            txtsRemark.DataBindings.Add("EditValue", bdsMain, "sRemark");
            txtsResidence.DataBindings.Add("EditValue", bdsMain, "sResidence");
            txtsSpeciality.DataBindings.Add("EditValue", bdsMain, "sSpeciality");
            txtsStature.DataBindings.Add("EditValue", bdsMain, "sStature");
            txtsStudyExperienct.DataBindings.Add("EditValue", bdsMain, "sStudyExperienct");
            txtsWorkExperience.DataBindings.Add("EditValue", bdsMain, "sWorkExperience");
            cbxsBrood.DataBindings.Add("EditValue", bdsMain, "sBrood");
            cbxsForeignLangaugeLevel.DataBindings.Add("EditValue", bdsMain, "sForeignLangaugeLevel");
            cbxsIsInService.DataBindings.Add("EditValue", bdsMain, "sIsInService");
            cbxsMarry.DataBindings.Add("EditValue", bdsMain, "sMarry");
            cbxsNation.DataBindings.Add("EditValue", bdsMain, "sNation");
            cbxsPolityStatus.DataBindings.Add("EditValue", bdsMain, "sPolityStatus");
            cbxsStudyExperience.DataBindings.Add("EditValue", bdsMain, "sStudyExperience");
            detdBirthday.DataBindings.Add("EditValue", bdsMain, "dBirthday");
            detdCallTitleDate.DataBindings.Add("EditValue", bdsMain, "dCallTitleDate");
            detdEndDate.DataBindings.Add("EditValue", bdsMain, "dEndDate");
            detdFormalDate.DataBindings.Add("EditValue", bdsMain, "dFormalDate");
            detdInCompanyDate.DataBindings.Add("EditValue", bdsMain, "dInCompanyDate");
            detdTryoutDate.DataBindings.Add("EditValue", bdsMain, "dTryoutDate");
            lkpsDeptID.DataBindings.Add("EditValue", bdsMain, "iDepartmentID");
            lkpsEmpType.DataBindings.Add("EditValue", bdsMain, "sEmpType");
            lkpsResidenceType.DataBindings.Add("EditValue", bdsMain, "sResidenceType");
            picmPic.DataBindings.Add("EditValue", bdsMain, "mPic");

            //初始化Lkp控件
            BWS.ERP.Common.SystemPublic.InitLkpDept(lkpsDeptID);
            BWS.ERP.Common.SystemPublic.InitLkpDataDict(lkpsEmpType, "1011");
            BWS.ERP.Common.SystemPublic.InitLkpDataDict(lkpsResidenceType, "1002");
        }
        public override void initBase()
        {
            AddNotNullFields(new string[] { "txtsEmpNo", "txtsEmpCName", "lkpsDeptID" });
            //FormID = 1001;
            base.initBase();
        }
        public override bool DoAppend()
        {
            base.DoAppend();
            BWS.ERP.Common.SystemPublic.GetBillNo(FormID, (DataRowView)bdsMain.Current);
            bdsMain.EndEdit();
            return true;
        }

        private void picmPic_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if (picmPic.Image == null)
            {
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
                ((DataRowView)bdsMain.Current).Row["mPic"] = null;
            }
        }
    }
}
