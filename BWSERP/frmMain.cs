using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTabbedMdi;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

using BWS.ERP.BaseForm;
using BWS.ERP.SysBase;

namespace BWSERP
{
    public partial class frmMain : BWS.ERP.BaseForm.frmForm
    {
        Cursor currentCursor;
        DataSet dsMeunData;
        public frmMain()
        {
            InitializeComponent();
            //������ʽ
            barManager1.GetController().LookAndFeel.UseDefaultLookAndFeel = false;
            barManager1.GetController().LookAndFeel.SkinName = "Blue";

            pnlWait.Location = new Point(pnlMenu.Width + 200, this.Height / 2);

        }
        public frmMain(DataSet ds)
        {
            InitializeComponent();
            //������ʽ
            barManager1.GetController().LookAndFeel.UseDefaultLookAndFeel = false;
            barManager1.GetController().LookAndFeel.SkinName = "Blue";

            pnlWait.Location = new Point(pnlMenu.Width + 200, this.Height / 2);
            dsMeunData = ds;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            //��ǰ�û�
            //BWS.ERP.Security.SecurityCenter.CurrentUserID = "admin";

            #region �˵����
            //��ʼ���˵�
            initMenu(dsMeunData);
            #endregion

            #region �ײ�״̬����ʾ

            //�ײ�״̬����ʾ
            barServerName.Caption = "������:" + BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("ServerName",true);
            barDataBase.Caption = "���ݿ�:" + BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("DataBase", true);
            barDate.Caption = "����:" + DateTime.Now.Date.ToString("yyyy��MM��dd") + " " + BWS.ERP.BasePublic.SysPublic.ChsWeek(DateTime.Now.Date) + " ũ��:" + BWS.ERP.BasePublic.SysPublic.CNDate();
            barUserName.Caption = "�û�:" + BWS.ERP.Security.SecurityCenter.CurrentUserName;
            barDeptName.Caption = "��������:" + BWS.ERP.Security.SecurityCenter.CurrentDeptName;

            //���汳��
            if (System.IO.File.Exists(BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("BackImg", false)))
            {
                picBack.Image = Image.FromFile(BWS.ERP.BaseControl.ConnectSetting.GetAppConfig("BackImg", false));
            }


            #endregion

            
        }

        private void initMenu(DataSet ds)
        {
            //string MenuSql = "SELECT A.ID,A.iFormID,A.sMenuName,A.iParentID,A.sModuleName,A.sFormClassName FROM sysMenu A ORDER BY A.iSort";
            DataSet dsMenu = ds;
            dsMenu.Tables[0].TableName = "ds";
            tvMenu.DataSource = dsMenu;
            tvMenu.DataMember = "ds";
            tvMenu.KeyFieldName = "ID";
            tvMenu.ParentFieldName = "iParentID";
            tvMenu.Columns["iFormID"].Visible = false;
            tvMenu.Columns["sModuleName"].Visible = false;
            tvMenu.Columns["sFormClassName"].Visible = false;
            tvMenu.Columns["iSort"].Visible = false;
        }

        private void RefreshForm(bool b)
        {
            if (b)
            {
                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                Refresh();
            }
            else
                Cursor.Current = currentCursor;
        }

        private void barSubWindow_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            //RefreshForm(true);
            ////Form2 frm = new Form2();
            ////frm.Text = "��������";
            //BWS.ERP.Module.SystemBase.frmhrEmployee frm = new BWS.ERP.Module.SystemBase.frmhrEmployee();
            //frm.MdiParent = this;
            //frm.Show();
            //RefreshForm(false);
        }

        /// <summary>
        /// ���ݿ���������
        /// </summary>
        private void barDataBaseLinkSet_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSysConnSet frm = new frmSysConnSet();
            frm.ShowDialog();
        }

        private void barCalc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\WINDOWS\system32\calc.exe";
            Process.Start(startInfo);
        }

        private void barPrintSet_ItemClick(object sender, ItemClickEventArgs e)
        {
            printDialog1.ShowDialog();
        }

        //#region ��ӡ���öԻ��� protected virtual PrinterSettings ShowPrintSetupDialog(PrintDocument printDocument)

        //protected virtual PrinterSettings ShowPrintSetupDialog(PrintDocument printDocument)
        //{
        //    //��������ֵ��PrinterSettings
        //    PrinterSettings ps = new PrinterSettings();
        //    if (printDocument == null)
        //    {
        //        //throw new Exception("�����Ĵ�ӡ�ĵ�����Ϊ�գ�");
        //    }

        //    try
        //    {
        //        //������ʵ����PrintDialog
        //        PrintDialog pDlg = new PrintDialog();

        //        //����ѡ��ҳ
        //        pDlg.AllowSomePages = true;

        //        //ָ����ӡ�ĵ�
        //        pDlg.Document = printDocument;

        //        //��ʾ�Ի���
        //        DialogResult result = pDlg.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            //�����ӡ����
        //            ps = pDlg.PrinterSettings;
        //            //��ӡ
        //            //printDocument.Print();
        //        }

        //    }
        //    catch (System.Drawing.Printing.InvalidPrinterException e)
        //    {
        //        MessageBox.Show("δ��װ��ӡ���������ϵͳ���������Ӵ�ӡ����", "��ӡ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    return ps;
        //}
        //#endregion

        private void barRelogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("���ȹر����д򿪵Ĵ��壡");
            }
            else
            {
                this.Hide();
                frmLogin frm = new frmLogin(true);
                frm.ShowDialog();
                this.Close();
            }
        }

        #region ��������

        //private string _userid;

        ///// <summary>
        ///// ���û��ȡ��ǰ��¼�û�
        ///// </summary>
        //public string CurrentUser
        //{
        //    get
        //    {
        //        return _userid;
        //    }
        //    set
        //    {
        //        _userid = value;
        //    }
        //}

        //private string _deptname;

        ///// <summary>
        ///// ���û��ȡ��ǰ��¼�û�����
        ///// </summary>
        //public string CurrentDeptName
        //{
        //    get
        //    {
        //        return _deptname;
        //    }
        //    set
        //    {
        //        _deptname = value;
        //    }
        //}

        #endregion

        private void barModifyPassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUpdatePassword frm = new frmUpdatePassword();
            frm.ShowDialog();
        }

        private void barExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void toolCloseCurrent_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void toolCloseAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
            }
        }


        private void pnlMenu_SizeChanged(object sender, EventArgs e)
        {
            if (pnlMenu.Width != 0)
            {
                barTreeMenu.Checked = true;
                tooTreeMenu.Checked = true;
            }
            else 
            {
                barTreeMenu.Checked = false;
                tooTreeMenu.Checked = false;
            }
        }

        private void tooTreeMenu_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (!tooTreeMenu.Checked)
            {
                pnlMenu.Width = 0;
            }
            else
            {
                pnlMenu.Width = 200;
            }
        }

        private void barTreeMenu_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (!barTreeMenu.Checked)
            {
                pnlMenu.Width = 0;
            }
            else
            {
                pnlMenu.Width = 200;
            }
        }

        private void tvMenu_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            if (e.Node.HasChildren)
                e.NodeImageIndex = e.Node.Expanded ? 1 : 0;
            else e.NodeImageIndex = 2;
        }

        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (tvMenu.FocusedNode != null && !tvMenu.FocusedNode.HasChildren)
            {
                if (HaveOpened(tvMenu.FocusedNode.GetValue("sMenuName").ToString()))
                {
                    string sModuleName = tvMenu.FocusedNode.GetValue("sModuleName").ToString();
                    string sPath = Application.StartupPath + @"\Modules\" + sModuleName;
                    string sClassName = "";
                    if (System.IO.File.Exists(sPath))
                    {
                        sClassName = tvMenu.FocusedNode.GetValue("sModuleName").ToString().Replace("dll", tvMenu.FocusedNode.GetValue("sFormClassName").ToString());
                    }
                    else
                    {
                        return;
                    }
                    pnlWait.Visible = true;
                    RefreshForm(true);
                    Cursor = Cursors.Default;
                    try
                    {
                        Form frmobject = (Form)Assembly.LoadFile(sPath).CreateInstance(sClassName, false, BindingFlags.CreateInstance, null, new object[] { GetFormID(Convert.ToInt32(tvMenu.FocusedNode.GetValue("ID"))), tvMenu.FocusedNode.GetValue("sMenuName") }, null, null);
                        //Form formobj = (Form)Assembly.LoadFile(Application.StartupPath + @"\DECOERP.exe").CreateInstance("DECOERP.frmSysGridColumnSet", false, BindingFlags.CreateInstance, null, new object[] { GetFormID(Convert.ToInt32(tvMemu.FocusedNode.GetValue("ID"))), tvMemu.FocusedNode.GetValue("grname") }, null, null);
                        frmobject.MdiParent = this;
                        frmobject.Show();
                        picBack.Visible = false;

                    }
                    catch (Exception)
                    {
                        BWS.ERP.BaseControl.Public.SystemInfo("ϵͳ�ļ������ڻ����ļ����𻵣�", true);
                    }
                    pnlWait.Visible = false;
                    RefreshForm(true);
                }                
            }
        }
        private bool HaveOpened(string childname)
        {
            //�鿴�����Ƿ��Ѿ�����
            bool bReturn = true;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].Text == childname)
                {
                    this.MdiChildren[i].BringToFront();
                    bReturn = false;
                    break;
                }
            }
            return bReturn;
        }
        private void barAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void barReLink_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = BWS.ERP.BaseControl.ConnectSetting.SysSqlConnection;
            if (conn.State == ConnectionState.Open)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("�������ӳɹ���\r\n���ȹر��������д��������ԣ�");
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (BWS.ERP.BaseControl.Public.SystemInfo("�Ƿ��˳�ϵͳ��", 4) == DialogResult.Yes)
            {
                if (e.CloseReason == CloseReason.MdiFormClosing)
                {
                    base.OnFormClosing(e);
                    //�ͷ�����UI�߳�
                    Application.Exit();
                    return;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                picBack.Visible = true;
            }
            else
            {
                picBack.Visible = false;
            }

        }

        private void barPicBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFileDialog1.Filter = "ͼƬ�ļ�(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picBack.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("��ͼƬʧ�ܣ������ԣ�", true);
                }
            }

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //���汳��ͼƬ
            if (openFileDialog1.FileName != "")
            {
                BWS.ERP.BaseControl.ConnectSetting.SaveAppConfig("BackImg", openFileDialog1.FileName, false);
            }

        }

        private void barClearPicBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (openFileDialog1.FileName != "")
            {
                openFileDialog1.FileName = "";
            }
            else
            {
                BWS.ERP.BaseControl.ConnectSetting.SaveAppConfig("BackImg", "", false);
            }
            if (picBack.EditValue != global::BWSERP.Properties.Resources.main)
            {
                picBack.EditValue = global::BWSERP.Properties.Resources.main;
            }
        }

        /// <summary>
        /// ��ȡFormID
        /// </summary>
        /// <param name="moudleid">ģ��id</param>
        /// <returns></returns>
        private int GetFormID(int moudleid)
        {
            int iResult = 0;
            try
            {
                //����FormID�����FormID�����ڻ����0����ϵͳ�Զ�����FormID
                if (Convert.ToInt32(tvMenu.FocusedNode.GetValue("iFormID").ToString() == "" ? "0" : tvMenu.FocusedNode.GetValue("iFormID").ToString()) > 0)
                {
                    return Convert.ToInt32(tvMenu.FocusedNode.GetValue("iFormID"));
                }
                else
                {
                    iResult = BWS.ERP.DataAccess.DbHelperSQL.GetMaxID("iFormID", "sysMenu");
                    string sSql = "UPDATE sysMenu SET iFormID =" + iResult.ToString()
                                + " WHERE ID=" + Convert.ToInt32(tvMenu.FocusedNode.GetValue("ID")) + " AND ISNULL(iFormID,0)<=0";
                    if (BWS.ERP.DataAccess.DbHelperSQL.ExecuteSql(sSql) > 0)
                    {
                        //�Զ�������FormID��ˢ�²˵�
                        initMenu(BWS.ERP.DataAccess.DbHelperSQL.Query(BWS.ERP.Security.SecurityCenter.GetMenuAuthSQL()));
                        return iResult;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                BWS.ERP.BaseControl.Public.SystemInfo("��ȡFormIDʧ�ܣ�������" + ex.Message, true);
                return 0;
            }
        }


    }
}
