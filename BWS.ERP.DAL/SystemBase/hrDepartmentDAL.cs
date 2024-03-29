﻿//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.DAL
//Description:      hrDepartmentDAL
//Create by:        自动生成
//Create Date:      2010-11-14 15:00:09
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
    /// 数据访问类hrDepartmentDAL
    /// </summary>
    public class hrDepartmentDAL
    {
        public hrDepartmentDAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM hrDepartment");
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
            strSql.Append("INSERT INTO hrDepartment(");
            strSql.Append("iCompanyID,sDeptNo,sDeptName,sDeptEName,sRemark,sUserID)");
            strSql.Append(" VALUES (");
            strSql.Append("@iCompanyID,@sDeptNo,@sDeptName,@sDeptEName,@sRemark,@sUserID)");
            strSql.Append(";SELECT @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@iCompanyID", SqlDbType.Int,4),
					new SqlParameter("@sDeptNo", SqlDbType.VarChar,30),
					new SqlParameter("@sDeptName", SqlDbType.VarChar,50),
					new SqlParameter("@sDeptEName", SqlDbType.VarChar,50),
					new SqlParameter("@sRemark", SqlDbType.VarChar,500),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["iCompanyID"];
            parameters[1].Value = dr["sDeptNo"];
            parameters[2].Value = dr["sDeptName"];
            parameters[3].Value = dr["sDeptEName"];
            parameters[4].Value = dr["sRemark"];
            parameters[5].Value = dr["sUserID"];

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
            strSql.Append("UPDATE hrDepartment SET ");
            strSql.Append("iCompanyID=@iCompanyID,");
            strSql.Append("sDeptNo=@sDeptNo,");
            strSql.Append("sDeptName=@sDeptName,");
            strSql.Append("sDeptEName=@sDeptEName,");
            strSql.Append("sRemark=@sRemark,");
            strSql.Append("sUserID=@sUserID");
            strSql.Append(" WHERE ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@iCompanyID", SqlDbType.Int,4),
					new SqlParameter("@sDeptNo", SqlDbType.VarChar,30),
					new SqlParameter("@sDeptName", SqlDbType.VarChar,50),
					new SqlParameter("@sDeptEName", SqlDbType.VarChar,50),
					new SqlParameter("@sRemark", SqlDbType.VarChar,500),
					new SqlParameter("@sUserID", SqlDbType.VarChar,30)};
            parameters[0].Value = dr["ID"];
            parameters[1].Value = dr["iCompanyID"];
            parameters[2].Value = dr["sDeptNo"];
            parameters[3].Value = dr["sDeptName"];
            parameters[4].Value = dr["sDeptEName"];
            parameters[5].Value = dr["sRemark"];
            parameters[6].Value = dr["sUserID"];

            DbHelperSQL.ExecuteSql(strSql.ToString(), trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID, SqlTransaction trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM hrDepartment ");
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
            strSql.Append(" FROM hrDepartment ");
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
            strSql.Append(" * FROM hrDepartment ");
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

