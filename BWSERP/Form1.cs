using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWSERP
{
    public partial class Form1 : BWS.ERP.BaseForm.frmBaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bwsLookUp1.AutoSetValue(textEdit1, "sEmpNo");
            bwsLookUp1.AutoSetValue(textEdit2, "sEmpEngName");
            bwsGridControl1.DataSource = BWS.ERP.DataAccess.DbHelperSQL.Query("SELECT * FROM sysMenu");
            bwsGridControl1.DataMember = "ds";
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    //BWS.ERP.BaseControl.Public.SystemInfo(bwsLookUp1.EditValue);
        //    contextMenuStrip1.Show((DevExpress.XtraEditors.SimpleButton)sender, new Point(0, btnPrint.Height));
        //    //popupMenu1.ShowPopup(barManager1, new Point(0, btnPrint.Height));
        //    //popupMenu1.ShowPopup(barManager1, new Point(this.Location.X + btnPrint.Location.X, this.Location.Y + panelControl2.Height + btnPrint.Height + 1));
        //}
    }
}
