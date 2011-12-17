using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BWSERP
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Chinese();
            AutoUpdate.AppUpdater au = new AutoUpdate.AppUpdater();
            if (au.CheckForUpdate() > 0)
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\AutoUpdate.exe","FromERP");
            }
            else
            {
                Application.Run(new frmSysInit());
            }
            //BWS.ERP.Module.SystemManage.frmsysQueryReport frm = new BWS.ERP.Module.SystemManage.frmsysQueryReport(5004, "Test");
            ////frm.ReportNo = "R001";
            //Application.Run(frm);
        }
    }
}
