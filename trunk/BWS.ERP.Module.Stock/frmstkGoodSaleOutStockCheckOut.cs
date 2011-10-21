using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.Stock
{
    public partial class frmstkGoodSaleOutStockCheckOut : BWS.ERP.BaseForm.frmForm
    {
        public frmstkGoodSaleOutStockCheckOut(string fsaleamount)
        {
            InitializeComponent();
            txtfSaleAmount.Text = fsaleamount;            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtfPayMoney.Text != "")
                //{
                //    if (Convert.ToDecimal(txtfPayMoney.Text) - Convert.ToDecimal(txtfSaleAmount.Text) < 0)
                //    {
                //        BWS.ERP.BaseControl.Public.SystemInfo("收款金额不能够小于销售金额");
                //        txtfPayMoney.Focus();
                //        return;
                //    }
                //}
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                //打印单据异常后正常保存，在出库模块选择补打收银条
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmstkGoodSaleOutStockCheckOut_Load(object sender, EventArgs e)
        {
            txtfPayMoney.Text = txtfSaleAmount.Text;
            txtfPayBackMoney.Text = "0.00";
        }

        /// <summary>
        /// 付款金额
        /// </summary>
        public decimal fPayMoney
        {
            get
            {
                return Convert.ToDecimal(txtfPayMoney.Text);
            }
        }

        private void txtfPayMoney_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtfPayMoney.Text) - Convert.ToDecimal(txtfSaleAmount.Text) < 0)
                {
                    btnOk.Enabled = false;
                    BWS.ERP.BaseControl.Public.SystemInfo("收款金额不能够小于销售金额");
                    txtfPayMoney.Focus();
                    return;
                }
                btnOk.Enabled = true;
                txtfPayBackMoney.Text = (Convert.ToDecimal(txtfPayMoney.Text) - Convert.ToDecimal(txtfSaleAmount.Text)).ToString();
            }
            catch (Exception)
            {
                btnOk.Enabled = false;
                BWS.ERP.BaseControl.Public.SystemInfo("请输入正确的收款金额");
                txtfPayMoney.Focus();
            }
        }
    }
}
