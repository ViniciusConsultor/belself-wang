using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.Module.Stock
{
    public partial class frmstkGoodStkInfo : BWS.ERP.BaseForm.frmForm
    {
        public frmstkGoodStkInfo(int formid, string formtext)
            : base(formid, formtext)
        {
            InitializeComponent();
            if (formtext != "")
            {
                Text = formtext;
            }
        }

        private void frmstkGoodStkInfo_Load(object sender, EventArgs e)
        {
            InitData("1=2");
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sWhere">查询条件</param>
        private void InitData(string sWhere)
        {
            string sSql = "SELECT A.sGoodID, A.sSpec, A.sGoodCName, A.sGoodEName, A.sGoodTypeID, "
                        + "A.sUnitID, A.sShopID, A.sGoodTypeName, A.sShopCName, A.sUnitName, "
                        + "A.fQuantity, A.fStkInQty, A.fStkOutQty "
                        + "FROM vwstkGoodStkInfoView A WHERE " + sWhere;
            gcMain.DataSource = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sSearchSql = " 1=1 ";
            if (txtsGoodCName.Text != "")
            {
                sSearchSql += " AND A.sGoodCName LIKE '%" + txtsGoodCName.Text + "%'";
            }
            if (txtsShopCName.Text != "")
            {
                sSearchSql += " AND A.sShopCName LIKE '%" + txtsShopCName.Text + "%'";
            }
            if (txtsGoodID.Text != "")
            {
                sSearchSql += " AND A.sGoodID LIKE '%" + txtsGoodID.Text + "%'";
            }
            if (txtsSpec.Text != "")
            {
                sSearchSql += " AND A.sSpec LIKE '%" + txtsSpec.Text + "%'";
            }
            InitData(sSearchSql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsGoodCName.Text = "";
            txtsGoodID.Text = "";
            txtsShopCName.Text = "";
            txtsSpec.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
