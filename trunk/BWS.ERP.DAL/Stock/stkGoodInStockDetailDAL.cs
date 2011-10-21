//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.DAL
//Description:      stkGoodInStockDetailDAL
//Create by:        自动生成
//Create Date:      2010-12-16 23:44:46
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
    /// 数据访问类stkGoodInStockDetailDAL
    /// </summary>
    public class stkGoodInStockDetailDAL
    {
        public stkGoodInStockDetailDAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM stkGoodInStockDetail");
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
            strSql.Append("INSERT INTO stkGoodInStockDetail(");
            strSql.Append("MainID,iSort,sGoodID,sSpec,fBasePrice,fSalePrice,fQuantity,sRemark,sUserID)");
            strSql.Append(" VALUES (");
            strSql.Append("@MainID,@iSort,@sGoodID,@sSpec,@fBasePrice,@fSalePrice,@fQuantity,@sRemark,@sUserID)");
            strSql.Append(";SELECT @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@iSort", SqlDbType.Int,4),
					new SqlParameter("@sGoodID", SqlDbType.VarChar,30),
					new SqlParameter("@sSpec", SqlDbType.VarChar,100),
					new SqlParameter("@fBasePrice", SqlDbType.Decimal,9),
					new SqlParameter("@fSalePrice", SqlDbType.Decimal,9),
					new SqlParameter("@fQuantity", SqlDbType.Decimal,9),
					new SqlParameter("@sRemark", SqlDbType.VarChar,500),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["MainID"];
            parameters[1].Value = dr["iSort"];
            parameters[2].Value = dr["sGoodID"];
            parameters[3].Value = dr["sSpec"];
            parameters[4].Value = dr["fBasePrice"];
            parameters[5].Value = dr["fSalePrice"];
            parameters[6].Value = dr["fQuantity"];
            parameters[7].Value = dr["sRemark"];
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
            strSql.Append("UPDATE stkGoodInStockDetail SET ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("iSort=@iSort,");
            strSql.Append("sGoodID=@sGoodID,");
            strSql.Append("sSpec=@sSpec,");
            strSql.Append("fBasePrice=@fBasePrice,");
            strSql.Append("fSalePrice=@fSalePrice,");
            strSql.Append("fQuantity=@fQuantity,");
            strSql.Append("sRemark=@sRemark,");
            strSql.Append("sUserID=@sUserID");
            strSql.Append(" WHERE ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@iSort", SqlDbType.Int,4),
					new SqlParameter("@sGoodID", SqlDbType.VarChar,30),
					new SqlParameter("@sSpec", SqlDbType.VarChar,100),
					new SqlParameter("@fBasePrice", SqlDbType.Decimal,9),
					new SqlParameter("@fSalePrice", SqlDbType.Decimal,9),
					new SqlParameter("@fQuantity", SqlDbType.Decimal,9),
					new SqlParameter("@sRemark", SqlDbType.VarChar,500),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["ID"];
            parameters[1].Value = dr["MainID"];
            parameters[2].Value = dr["iSort"];
            parameters[3].Value = dr["sGoodID"];
            parameters[4].Value = dr["sSpec"];
            parameters[5].Value = dr["fBasePrice"];
            parameters[6].Value = dr["fSalePrice"];
            parameters[7].Value = dr["fQuantity"];
            parameters[8].Value = dr["sRemark"];
            parameters[9].Value = dr["sUserID"];

            DbHelperSQL.ExecuteSql(strSql.ToString(), trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID, SqlTransaction trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM stkGoodInStockDetail ");
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
            strSql.Append(" FROM vwstkGoodInStockDetail ");
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
            strSql.Append(" * FROM vwstkGoodInStockDetail ");
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

