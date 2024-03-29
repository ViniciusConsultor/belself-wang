﻿//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.DAL
//Description:      sysRolesRightsDAL
//Create by:        自动生成
//Create Date:      2010-11-14 14:53:10
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
    /// 数据访问类sysRolesRightsDAL
    /// </summary>
    public class sysRolesRightsDAL
    {
        public sysRolesRightsDAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM sysRolesRights");
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
            strSql.Append("INSERT INTO sysRolesRights(");
            strSql.Append("RoleID,MenuID,iAdd,iView,iEdit,iDelete,iPrint,iNum,iPrice)");
            strSql.Append(" VALUES (");
            strSql.Append("@RoleID,@MenuID,@iAdd,@iView,@iEdit,@iDelete,@iPrint,@iNum,@iPrice)");
            strSql.Append(";SELECT @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@iAdd", SqlDbType.Bit,1),
					new SqlParameter("@iView", SqlDbType.Int,4),
					new SqlParameter("@iEdit", SqlDbType.Int,4),
					new SqlParameter("@iDelete", SqlDbType.Int,4),
					new SqlParameter("@iPrint", SqlDbType.Int,4),
					new SqlParameter("@iNum", SqlDbType.Int,4),
					new SqlParameter("@iPrice", SqlDbType.Int,4)};
            parameters[0].Value = dr["RoleID"];
            parameters[1].Value = dr["MenuID"];
            parameters[2].Value = dr["iAdd"];
            parameters[3].Value = dr["iView"];
            parameters[4].Value = dr["iEdit"];
            parameters[5].Value = dr["iDelete"];
            parameters[6].Value = dr["iPrint"];
            parameters[7].Value = dr["iNum"];
            parameters[8].Value = dr["iPrice"];

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
            strSql.Append("UPDATE sysRolesRights SET ");
            strSql.Append("RoleID=@RoleID,");
            strSql.Append("MenuID=@MenuID,");
            strSql.Append("iAdd=@iAdd,");
            strSql.Append("iView=@iView,");
            strSql.Append("iEdit=@iEdit,");
            strSql.Append("iDelete=@iDelete,");
            strSql.Append("iPrint=@iPrint,");
            strSql.Append("iNum=@iNum,");
            strSql.Append("iPrice=@iPrice");
            strSql.Append(" WHERE ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@iAdd", SqlDbType.Bit,1),
					new SqlParameter("@iView", SqlDbType.Int,4),
					new SqlParameter("@iEdit", SqlDbType.Int,4),
					new SqlParameter("@iDelete", SqlDbType.Int,4),
					new SqlParameter("@iPrint", SqlDbType.Int,4),
					new SqlParameter("@iNum", SqlDbType.Int,4),
					new SqlParameter("@iPrice", SqlDbType.Int,4)};
            parameters[0].Value = dr["ID"];
            parameters[1].Value = dr["RoleID"];
            parameters[2].Value = dr["MenuID"];
            parameters[3].Value = dr["iAdd"];
            parameters[4].Value = dr["iView"];
            parameters[5].Value = dr["iEdit"];
            parameters[6].Value = dr["iDelete"];
            parameters[7].Value = dr["iPrint"];
            parameters[8].Value = dr["iNum"];
            parameters[9].Value = dr["iPrice"];

            DbHelperSQL.ExecuteSql(strSql.ToString(), trans, parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID, SqlTransaction trans)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM sysRolesRights ");
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
            strSql.Append(" FROM vwsysRolesRights ");
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
            strSql.Append(" * FROM vwsysRolesRights ");
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

