//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.DAL
//Description:      stkGoodOutStockMasterDAL
//Create by:        自动生成
//Create Date:      2011-1-3 2:43:09
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BWS.ERP.DataAccess;
namespace BWS.ERP.DAL
{
    /// <summary>
    /// 数据访问类stkGoodOutStockMasterDAL
    /// </summary>
    public class stkGoodOutStockMasterDAL
    {
        public stkGoodOutStockMasterDAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM stkGoodOutStockMaster");
            strSql.Append(" WHERE ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DataRow dr, SqlTransaction trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO stkGoodOutStockMaster(");
            strSql.Append("sStockOutNo,dStockOutDate,sShopID,sRemark,fSaleAmount,fPayMoney,sVipCardNo,iFlag,sUserID)");
            strSql.Append(" VALUES (");
            strSql.Append("@sStockOutNo,@dStockOutDate,@sShopID,@sRemark,@fSaleAmount,@fPayMoney,@sVipCardNo,@iFlag,@sUserID)");
            strSql.Append(";SELECT @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@sStockOutNo", SqlDbType.VarChar,30),
					new SqlParameter("@dStockOutDate", SqlDbType.DateTime),
					new SqlParameter("@sShopID", SqlDbType.VarChar,30),
					new SqlParameter("@sRemark", SqlDbType.VarChar,200),
					new SqlParameter("@fSaleAmount", SqlDbType.Decimal,9),
					new SqlParameter("@fPayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@sVipCardNo", SqlDbType.VarChar,50),
					new SqlParameter("@iFlag", SqlDbType.Int,4),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["sStockOutNo"];
            parameters[1].Value = dr["dStockOutDate"];
            parameters[2].Value = dr["sShopID"];
            parameters[3].Value = dr["sRemark"];
            parameters[4].Value = dr["fSaleAmount"];
            parameters[5].Value = dr["fPayMoney"];
            parameters[6].Value = dr["sVipCardNo"];
            parameters[7].Value = dr["iFlag"];
            parameters[8].Value = dr["sUserID"];

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), trans, parameters);
            if (obj == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(DataRow dr, SqlTransaction trans)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE stkGoodOutStockMaster SET ");
            strSql.Append("sStockOutNo=@sStockOutNo,");
            strSql.Append("dStockOutDate=@dStockOutDate,");
            strSql.Append("sShopID=@sShopID,");
            strSql.Append("sRemark=@sRemark,");
            strSql.Append("fSaleAmount=@fSaleAmount,");
            strSql.Append("fPayMoney=@fPayMoney,");
            strSql.Append("sVipCardNo=@sVipCardNo,");
            strSql.Append("iFlag=@iFlag,");
            strSql.Append("sUserID=@sUserID");
            strSql.Append(" WHERE ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@sStockOutNo", SqlDbType.VarChar,30),
					new SqlParameter("@dStockOutDate", SqlDbType.DateTime),
					new SqlParameter("@sShopID", SqlDbType.VarChar,30),
					new SqlParameter("@sRemark", SqlDbType.VarChar,200),
					new SqlParameter("@fSaleAmount", SqlDbType.Decimal,9),
					new SqlParameter("@fPayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@sVipCardNo", SqlDbType.VarChar,50),
					new SqlParameter("@iFlag", SqlDbType.Int,4),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["ID"];
            parameters[1].Value = dr["sStockOutNo"];
            parameters[2].Value = dr["dStockOutDate"];
            parameters[3].Value = dr["sShopID"];
            parameters[4].Value = dr["sRemark"];
            parameters[5].Value = dr["fSaleAmount"];
            parameters[6].Value = dr["fPayMoney"];
            parameters[7].Value = dr["sVipCardNo"];
            parameters[8].Value = dr["iFlag"];
            parameters[9].Value = dr["sUserID"];

            DbHelperSQL.ExecuteSql(strSql.ToString(), trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID, SqlTransaction trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM stkGoodOutStockMaster ");
            strSql.Append(" WHERE ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), trans, parameters);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * ");
            strSql.Append(" FROM vwstkGoodOutStockMaster ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ");
            if (Top > 0)
            {
                strSql.Append(" TOP " + Top.ToString());
            }
            strSql.Append(" * FROM vwstkGoodOutStockMaster ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ORDER BY  " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion  成员方法
    }
}

