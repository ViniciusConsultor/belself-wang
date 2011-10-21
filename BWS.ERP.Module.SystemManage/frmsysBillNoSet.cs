using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.SystemManage
{
    public partial class frmsysBillNoSet : BWS.ERP.BaseForm.frmSingleForm
    {
        public frmsysBillNoSet(int formid, string formtext)
            : base(formid, "sysBillNoSetDAL")
        {
            InitializeComponent();
            lkpDateFormatStr.DataBindings.Add("EditValue", bdsMain, "sDateType");
            txtsFieldName.DataBindings.Add("EditValue", bdsMain, "sFieldName");
            lkpFormID.DataBindings.Add("EditValue", bdsMain, "iFormID");
            lkpTableName.DataBindings.Add("EditValue", bdsMain, "sTableName");
            txtFormID.DataBindings.Add("EditValue", bdsMain, "iFormID");
            txtNoFormatStr.DataBindings.Add("EditValue", bdsMain, "sSerialType");
            txtPreFormatStr.DataBindings.Add("EditValue", bdsMain, "sPrefix");

            BWS.ERP.Common.SystemPublic.InitLkpDataDict(lkpDateFormatStr, "1012");
            BWS.ERP.Common.SystemPublic.InitLkpFormID(lkpFormID);
            BWS.ERP.Common.SystemPublic.InitLookUpBase(lkpTableName, "SELECT TOP 100 PERCENT name,id FROM sysobjects WHERE xtype = 'U' ORDER BY name", "name", "name", "name", "数据表名", "数据表");
            //BWS.ERP.Common.SystemPublic.InitLookUpBase(txtsFieldName, "SELECT name, length FROM syscolumns Order BY colid", "name", "name", "name", "字段名称", "字段名称");
        }

        public override void initBase()
        {
            AddNotNullFields(new string[] { "lkpFormID", "lkpTableName", "txtsFieldName", "txtNoFormatStr" });
            base.initBase();
        }

        private bool lkpFormID_LookUpAfterPost(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (lkpFormID.ReturnData.Rows.Count > 0)
            {
                bdsMain.EndEdit();
                ((DataRowView)bdsMain.Current).Row["sMenuName"] = lkpFormID.ReturnData.Rows[0]["sMenuName"];
            }
            return default(bool);
        }

        private void frmsysBillNoSet_Load(object sender, EventArgs e)
        {
            string aa = BWS.ERP.Common.SystemPublic.GetBillNo("hrEmployee", "sEmpNo", "EA", "yyMMdd", "000");
        }
    }
}
