using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Report
{
    public partial class frmReportPreview : BWS.ERP.BaseForm.frmForm
    {
        private FastReport.Report PreRepot;
        public frmReportPreview()
        {
            InitializeComponent();
            //设置报表控件新增数据源连接字符串
            FastReport.Utils.Config.DesignerSettings.ApplicationConnection = BWS.ERP.BaseControl.ConnectSetting.SysSqlConnection;
        }
        public frmReportPreview(FastReport.Report rp)
        {
            InitializeComponent();
            PreRepot = rp;
            //设置报表控件新增数据源连接字符串
            FastReport.Utils.Config.DesignerSettings.ApplicationConnection = BWS.ERP.BaseControl.ConnectSetting.SysSqlConnection;
        }

        private void frmReportPreview_Load(object sender, EventArgs e)
        {
            PreRepot.Preview = previewControl1;
            PreRepot.Prepare();
            PreRepot.ShowPrepared();
        }
    }
}
