using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BWSERP
{
    static class Program
    {
        /// <summary>
        /// Ӧ�ó��������ڵ㡣
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutoUpdate.AppUpdater au = new AutoUpdate.AppUpdater();
            if (au.CheckForUpdate() > 0)
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\AutoUpdate.exe", "FromERP");
            }
            else
            {
                Application.Run(new frmSysInit());
            }
            //BWS.ERP.Module.SystemManage.frmsysPlatformManage frm = new BWS.ERP.Module.SystemManage.frmsysPlatformManage(5004, "Test");
            //frm.ReportNo = "R001";
            //Application.Run(frm);
        }
    }
}
