using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.Stock
{
    public partial class frmstkGoodSaleOutStockQuery : BWS.ERP.BaseForm.frmForm
    {
        public frmstkGoodSaleOutStockQuery(int formid, string formtext)
            : base(formid, formtext)
        {
            InitializeComponent();
            if (formtext != "")
            {
                Text = formtext;
            }
        }

        private void frmstkGoodSaleOutStockQuery_Load(object sender, EventArgs e)
        {
            InitData("1=2");
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sWhere">查询条件</param>
        private void InitData(string sWhere)
        {
            string sSql = "SELECT B.sStockOutNo, B.dStockOutDate, B.sShopID, B.sRemark,B.sVipCardNo, "
                        + "B.sShopCName, B.sEmpCName,A.sGoodID, A.sSpec, A.fSalePrice, A.fDiscount, "
                        + "A.fQuantity, A.sGoodCName, A.fAmount, A.fDiscountMoney, A.sGoodEName "
                        + "FROM vwstkGoodOutStockDetail A "
                        + "LEFT JOIN vwstkGoodOutStockMaster B ON A.MainID=B.ID WHERE " + sWhere;
            gcMain.DataSource = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sSearchSql = " 1=1 ";
            if (txtsEmpCName.Text != "")
            {
                sSearchSql += " AND B.sEmpCName LIKE '%" + txtsEmpCName.Text + "%'";
            }
            if (txtsShopCName.Text != "")
            {
                sSearchSql += " AND B.sShopCName LIKE '%" + txtsShopCName.Text + "%'";
            }
            if (txtsStockOutNo.Text != "")
            {
                sSearchSql += " AND B.sStockOutNo LIKE '%" + txtsStockOutNo.Text + "%'";
            }
            if (txtsVipCardNo.Text != "")
            {
                sSearchSql += " AND B.sVipCardNo LIKE '%" + txtsVipCardNo.Text + "%'";
            }
            if (detOutDateS.Text != "")
            {
                sSearchSql += " AND B.dStockOutDate >='" + detOutDateS.Text + "'";
            }
            if (detOutDateE.Text != "")
            {
                sSearchSql += " AND B.dStockOutDate <='" + detOutDateE.Text + "'";
            }
            InitData(sSearchSql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsEmpCName.Text = "";
            txtsShopCName.Text = "";
            txtsStockOutNo.Text = "";
            txtsVipCardNo.Text = "";
            detOutDateE.Text = "";
            detOutDateS.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
