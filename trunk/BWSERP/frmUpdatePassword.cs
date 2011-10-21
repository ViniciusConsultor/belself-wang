using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWSERP
{
    public partial class frmUpdatePassword : BWS.ERP.BaseForm.frmForm
    {
        public frmUpdatePassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtOldPwd.Text=="")
            {
                BWS.ERP.BaseControl.Public.SystemInfo("请输入原密码！");
                txtOldPwd.Focus();
                return;
            }
            if (txtNewPwd.Text == "")
            {
                BWS.ERP.BaseControl.Public.SystemInfo("请输入新密码！");
                txtNewPwd.Focus();
                return;
            }
            if (txtNewPwd2.Text == "")
            {
                BWS.ERP.BaseControl.Public.SystemInfo("请再次输入新密码！");
                txtNewPwd2.Focus();
                return;
            }
            if (txtNewPwd.Text.Trim() != txtNewPwd2.Text.Trim())
            {
                BWS.ERP.BaseControl.Public.SystemInfo("两次输入的新密码不一致，请重新输入！");
                txtNewPwd.Text = "";
                txtNewPwd2.Text = "";
                txtNewPwd.Focus();
                return;
            }
            try
            {
                if (BWS.ERP.Security.SecurityCenter.CheckSystemLogin(BWS.ERP.Security.SecurityCenter.CurrentUserID, txtOldPwd.Text.Trim()) == 1)
                {
                    string sSql = "UPDATE sysUser SET sPassword='" + BWS.ERP.BaseControl.SysEncrypt.EncryptStr(txtNewPwd.Text.Trim()) + "' WHERE sUserID='" + BWS.ERP.Security.SecurityCenter.CurrentUserID + "'";
                    BWS.ERP.DataAccess.DbHelperSQL.ExecuteSql(sSql);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("原密码错误，请重新输入！");
                }
            }
            catch (Exception ex)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("修改失败，请重试！" + ex.Message, true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {
            lblsUserID.Text = BWS.ERP.Security.SecurityCenter.CurrentUserID;
        }
    }
}
