using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWSERP
{
    public partial class frmLogin : BWS.ERP.BaseForm.frmForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isrelogin">是否重新登录，重新登录数据库设置按钮不可用</param>
        public frmLogin(bool isrelogin)
        {
            InitializeComponent();
            if (isrelogin)
            {
                btnSet.Enabled = false;
                this.ShowInTaskbar = false;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            frmSysConnSet frm = new frmSysConnSet();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == "")
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("登录名不能够为空！");
                    txtUserID.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("密码不能够为空！");
                    txtPassword.Focus();
                    return;
                }
                int iLoginResult = BWS.ERP.Security.SecurityCenter.CheckSystemLogin(txtUserID.Text, txtPassword.Text.Trim());
                if (iLoginResult == 1)
                {
                    BWS.ERP.BaseControl.ConnectSetting.SaveAppConfig("LastUserID", txtUserID.Text, true);
                    lblProgress.Visible = true;
                    this.Refresh();
                    DataSet ds = BWS.ERP.DataAccess.DbHelperSQL.Query(BWS.ERP.Security.SecurityCenter.GetMenuAuthSQL());
                    frmMain frm = new frmMain(ds);
                    this.Hide();
                    //frm.CurrentUser = txtUserID.Text;
                    //frm.CurrentDeptName = "系统管理员";
                    frm.ShowDialog();
                    this.Close();
                }
                else if (iLoginResult == 0)
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("用户不存在！");
                    txtUserID.Focus();
                }
                else if (iLoginResult == 2)
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("密码错误！");
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("登录错误！" + ex.Message + "\r\n 请退出系统重试！");
            }            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserID.Text = BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("LastUserID", true);
                if (!string.IsNullOrEmpty(txtUserID.Text))
                {
                    //设置为输入焦点
                    txtPassword.TabIndex = 0;
                }
            }
            catch
            {
                txtUserID.Text = "";
            }
        }
    }
}
