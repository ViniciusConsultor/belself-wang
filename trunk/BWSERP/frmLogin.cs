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
        /// <param name="isrelogin">�Ƿ����µ�¼�����µ�¼���ݿ����ð�ť������</param>
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
                    BWS.ERP.BaseControl.Public.SystemInfo("��¼�����ܹ�Ϊ�գ�");
                    txtUserID.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("���벻�ܹ�Ϊ�գ�");
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
                    //frm.CurrentDeptName = "ϵͳ����Ա";
                    frm.ShowDialog();
                    this.Close();
                }
                else if (iLoginResult == 0)
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("�û������ڣ�");
                    txtUserID.Focus();
                }
                else if (iLoginResult == 2)
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("�������");
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("��¼����" + ex.Message + "\r\n ���˳�ϵͳ���ԣ�");
            }            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserID.Text = BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("LastUserID", true);
                if (!string.IsNullOrEmpty(txtUserID.Text))
                {
                    //����Ϊ���뽹��
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
