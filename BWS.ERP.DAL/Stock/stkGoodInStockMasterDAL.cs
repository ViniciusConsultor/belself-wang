//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.DAL
//Description:      stkGoodInStockMasterDAL
//Create by:        自动生成
//Create Date:      2010-12-16 22:44:14
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
    /// 数据访问类stkGoodInStockMasterDAL
    /// </summary>
    public class stkGoodInStockMasterDAL
    {
        public stkGoodInStockMasterDAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM stkGoodInStockMaster");
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
            strSql.Append("INSERT INTO stkGoodInStockMaster(");
            strSql.Append("sStockInNo,dStockInDate,sSupplierID,sStockInType,sBussinessManID,sTradeBillNo,fTotalQuantity,fTotalAmount,sRemark,iFlag,sUserID)");
            strSql.Append(" VALUES (");
            strSql.Append("@sStockInNo,@dStockInDate,@sSupplierID,@sStockInType,@sBussinessManID,@sTradeBillNo,@fTotalQuantity,@fTotalAmount,@sRemark,@iFlag,@sUserID)");
            strSql.Append(";SELECT @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@sStockInNo", SqlDbType.VarChar,30),
					new SqlParameter("@dStockInDate", SqlDbType.DateTime),
					new SqlParameter("@sSupplierID", SqlDbType.VarChar,30),
					new SqlParameter("@sStockInType", SqlDbType.VarChar,30),
					new SqlParameter("@sBussinessManID", SqlDbType.VarChar,30),
					new SqlParameter("@sTradeBillNo", SqlDbType.VarChar,50),
					new SqlParameter("@fTotalQuantity", SqlDbType.Decimal,9),
					new SqlParameter("@fTotalAmount", SqlDbType.Decimal,9),
					new SqlParameter("@sRemark", SqlDbType.VarChar,500),
					new SqlParameter("@iFlag", SqlDbType.Int,4),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["sStockInNo"];
            parameters[1].Value = dr["dStockInDate"];
            parameters[2].Value = dr["sSupplierID"];
            parameters[3].Value = dr["sStockInType"];
            parameters[4].Value = dr["sBussinessManID"];
            parameters[5].Value = dr["sTradeBillNo"];
            parameters[6].Value = dr["fTotalQuantity"];
            parameters[7].Value = dr["fTotalAmount"];
            parameters[8].Value = dr["sRemark"];
            parameters[9].Value = dr["iFlag"];
            parameters[10].Value = dr["sUserID"];

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
            strSql.Append("UPDATE stkGoodInStockMaster SET ");
            strSql.Append("sStockInNo=@sStockInNo,");
            strSql.Append("dStockInDate=@dStockInDate,");
            strSql.Append("sSupplierID=@sSupplierID,");
            strSql.Append("sStockInType=@sStockInType,");
            strSql.Append("sBussinessManID=@sBussinessManID,");
            strSql.Append("sTradeBillNo=@sTradeBillNo,");
            strSql.Append("fTotalQuantity=@fTotalQuantity,");
            strSql.Append("fTotalAmount=@fTotalAmount,");
            strSql.Append("sRemark=@sRemark,");
            strSql.Append("iFlag=@iFlag,");
            strSql.Append("sUserID=@sUserID");
            strSql.Append(" WHERE ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@sStockInNo", SqlDbType.VarChar,30),
					new SqlParameter("@dStockInDate", SqlDbType.DateTime),
					new SqlParameter("@sSupplierID", SqlDbType.VarChar,30),
					new SqlParameter("@sStockInType", SqlDbType.VarChar,30),
					new SqlParameter("@sBussinessManID", SqlDbType.VarChar,30),
					new SqlParameter("@sTradeBillNo", SqlDbType.VarChar,50),
					new SqlParameter("@fTotalQuantity", SqlDbType.Decimal,9),
					new SqlParameter("@fTotalAmount", SqlDbType.Decimal,9),
					new SqlParameter("@sRemark", SqlDbType.VarChar,500),
					new SqlParameter("@iFlag", SqlDbType.Int,4),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["ID"];
            parameters[1].Value = dr["sStockInNo"];
            parameters[2].Value = dr["dStockInDate"];
            parameters[3].Value = dr["sSupplierID"];
            parameters[4].Value = dr["sStockInType"];
            parameters[5].Value = dr["sBussinessManID"];
            parameters[6].Value = dr["sTradeBillNo"];
            parameters[7].Value = dr["fTotalQuantity"];
            parameters[8].Value = dr["fTotalAmount"];
            parameters[9].Value = dr["sRemark"];
            parameters[10].Value = dr["iFlag"];
            parameters[11].Value = dr["sUserID"];

            DbHelperSQL.ExecuteSql(strSql.ToString(), trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID, SqlTransaction trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM stkGoodInStockMaster ");
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
            strSql.Append(" FROM vwstkGoodInStockMaster ");
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
            strSql.Append(" * FROM vwstkGoodInStockMaster ");
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

