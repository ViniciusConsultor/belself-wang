using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.Stock
{
    public partial class frmstkGoodInStockQuery : BWS.ERP.BaseForm.frmForm
    {
        public frmstkGoodInStockQuery(int formid, string formtext)
            : base(formid, formtext)
        {
            InitializeComponent();
            if (formtext != "")
            {
                Text = formtext;
            }
        }

        private void frmstkGoodInStockQuery_Load(object sender, EventArgs e)
        {
            InitData("1=2");
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sWhere">查询条件</param>
        private void InitData(string sWhere)
        {
            string sSql = "SELECT B.sStockInNo,B.dStockInDate,B.sSupplierID,B.sTradeBillNo,B.sRemark,B.sStockInTypeName, "
                        + "B.sSupplierSName,B.sSupplierCName,B.sSupplierEName,B.sBussinessManName,A.sGoodID, "
                        + "A.sSpec,A.fBasePrice,A.fSalePrice,A.fQuantity,A.sGoodCName,A.sGoodEName,A.sUnitCName, "
                        + "A.sUnitEName,A.fAmount,B.sFlagName  "
                        + "FROM   vwstkGoodInStockDetail A "
                        + "LEFT JOIN vwstkGoodInStockMaster B ON A.MainID = B.ID WHERE " + sWhere;
            gcMain.DataSource = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sSearchSql = " 1=1 ";
            if (txtsStockInNo.Text != "")
            {
                sSearchSql += " AND B.sStockInNo LIKE '%" + txtsStockInNo.Text + "%'";
            }
            if (txtsSupplier.Text != "")
            {
                sSearchSql += " AND B.sSupplierCName LIKE '%" + txtsSupplier.Text + "%'";
            }
            if (txtsTradeBillNo.Text != "")
            {
                sSearchSql += " AND B.sTradeBillNo LIKE '%" + txtsTradeBillNo.Text + "%'";
            }
            if (detInDateS.Text != "")
            {
                sSearchSql += " AND B.dStockInDate >='" + detInDateS.Text + "'";
            }
            if (detInDateE.Text != "")
            {
                sSearchSql += " AND B.dStockInDate <='" + detInDateE.Text + "'";
            }
            InitData(sSearchSql);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsStockInNo.Text = "";
            txtsSupplier.Text = "";
            txtsTradeBillNo.Text = "";
            detInDateE.Text = "";
            detInDateS.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
