using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemManage
{
    public partial class frmsysEditUser : BWS.ERP.BaseForm.frmSingleForm
    {
        public frmsysEditUser()
            : base(0, "sysUserDAL", false)
        {
            InitializeComponent();
            txtsPassword.DataBindings.Add("EditValue", bdsMain, "sPassword");
            txtsRemark.DataBindings.Add("EditValue", bdsMain, "sRemark");
            txtsUserCName.DataBindings.Add("EditValue", bdsMain, "sUserCName");
            txtsUserEName.DataBindings.Add("EditValue", bdsMain, "sUserEName");
            lkpParantID.DataBindings.Add("EditValue", bdsMain, "ParentID");
            lkpsUserID.DataBindings.Add("EditValue", bdsMain, "sUserID");
            cbxUserType.DataBindings.Add("EditValue", bdsMain, "iUserType");
            chkbIsLock.DataBindings.Add("EditValue", bdsMain, "bIsLock");
            BWS.ERP.Common.SystemPublic.InitLookUpBase(lkpsUserID, "SELECT ID,sEmpNo,sEmpCName,sEmpEName,sDeptNo,sDeptName,sDeptEName FROM vwhrEmployee", "sEmpNo",
                                                       "sEmpNo", "sEmpNo,sEmpCName,sEmpEName,sDeptNo,sDeptName", "员工编号,员工名称,员工英文名,部门编号,部门名称", "员工信息");
            BWS.ERP.Common.SystemPublic.InitLkpSystemUser(lkpParantID);
        }
        public override bool DoAppend()
        {
            BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, false);
            bdsMain.AddNew();
            ((DataRowView)bdsMain.Current).Row["iFlag"] = 0;
            ((DataRowView)bdsMain.Current).Row["bIsLock"] = 0;
            ((DataRowView)bdsMain.Current).Row["iUserType"] = 0;
            bdsMain.EndEdit();
            IsDataChange = false;
            return true;
        }
        public override void initBase()
        {
            AddNotNullFields(new string[] { "lkpsUserID", "txtsUserCName", "txtsPassword" });
            base.initBase();
        }

        private void frmsysEditUser_Load(object sender, EventArgs e)
        {
            lkpsUserID.LookUpAfterPost += new BWS.ERP.Controls.BWSLookUp.BWSLookUpEvent(lkpsUserID_LookUpAfterPost);
        }

        bool lkpsUserID_LookUpAfterPost(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            bdsMain.EndEdit();
            ((DataRowView)bdsMain.Current).Row["EmpID"] = lkpsUserID.ReturnData.Rows[0]["ID"];
            ((DataRowView)bdsMain.Current).Row["sUserCName"]=lkpsUserID.ReturnData.Rows[0]["sEmpCName"].ToString();
            ((DataRowView)bdsMain.Current).Row["sUserEName"] = lkpsUserID.ReturnData.Rows[0]["sEmpEName"].ToString();            
            return txtsUserEName.Focus();
        }

        private void gvMain_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "bIsLock")
            //{
            //    if (e.CellValue != null && (bool)e.CellValue)
            //    {
            //        e.Appearance.BackColor = System.Drawing.Color.Gray;
            //        //gvMain.Appearance.Row.BackColor = System.Drawing.Color.Gray;

            //    }
            //}
        }
        public override bool DoBeforeSave()
        {
            ((DataRowView)bdsMain.Current).Row["sPassword"] = BWS.ERP.BaseControl.SysEncrypt.EncryptStr(((DataRowView)bdsMain.Current).Row["sPassword"].ToString());
            bdsMain.EndEdit();
            return base.DoBeforeSave();
        }
    }
}
