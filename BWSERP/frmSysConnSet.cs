using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using BWS.ERP.BaseForm;

namespace BWSERP
{
    public partial class frmSysConnSet : BWS.ERP.BaseForm.frmForm
    {
        public frmSysConnSet()
        {
            InitializeComponent();
        }

        private void frmSysConnSet_Load(object sender, EventArgs e)
        {
            //��ȡ�����ļ��е����ݿ���������
            txtServer.Text = BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("ServerName", true);
            txtDataBase.Text = BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("DataBase", true);
            txtUser.Text = BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("UserName", true);
            txtPassword.Text = BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("Password", true);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //�ǿ���֤
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtServer, "���������ƻ�IP��ַ")) { return; }
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtDataBase, "���ݿ�����")) { return; }
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtUser, "�û���")) { return; }
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtPassword, "����")) { return; }

            //Data Source=BELSELFWANG\SERVER2008;Initial Catalog=BWSERP2010;User ID=sa;Password=wzt833
            string sConn = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDataBase.Text + ";User ID=" + txtUser.Text + ";Password=" + txtPassword.Text;
            SqlConnection conn = new SqlConnection(sConn);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("���ӳɹ�!");
                }
            }
            catch (Exception ex)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("����ʧ��!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //�ǿ���֤
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtServer, "���������ƻ�IP��ַ")) { return; }
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtDataBase, "���ݿ�����")) { return; }
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtUser, "�û���")) { return; }
            if (BWS.ERP.BasePublic.SysPublic.CheckNotNull(txtPassword, "����")) { return; }

            //���������ַ���
            try
            {
                BWS.ERP.BaseControl.ConnectSetting.SaveSqlConnString(txtServer.Text, txtDataBase.Text, txtUser.Text, txtPassword.Text);
                this.Close();

            }
            catch (Exception ex)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("����ʧ��!" + ex.Message);
            }
            

        }
    }
}
