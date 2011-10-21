﻿//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.BLL
//Description:      sysMenuBLL
//Create by:        自动生成
//Create Date:      2010-9-14 22:31:18
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using BWS.ERP.Model;
namespace BWS.ERP.BLL
{
    /// <summary>
    /// 业务逻辑类sysMenuBLL
    /// </summary>
    public class sysMenuBLL
    {
        private readonly BWS.ERP.DAL.sysMenuDAL dal = new BWS.ERP.DAL.sysMenuDAL();
        public sysMenuBLL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BWS.ERP.Model.sysMenuEntity model, SqlTransaction trans)
        {
            return dal.Add(model, trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BWS.ERP.Model.sysMenuEntity model, SqlTransaction trans)
        {
            dal.Update(model, trans);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID, SqlTransaction trans)
        {
            dal.Delete(ID, trans);
        }

        /// <summary>
        /// 根据条件删除数据
        /// </summary>
        public void Delete(string where, SqlTransaction trans)
        {
            dal.Delete(where, trans);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BWS.ERP.Model.sysMenuEntity GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.sysMenuEntity> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.sysMenuEntity> GetModelList(int top, string strWhere, string sortfield)
        {
            DataSet ds = dal.GetList(top, strWhere, sortfield);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.sysMenuEntity> DataTableToList(DataTable dt)
        {
            List<BWS.ERP.Model.sysMenuEntity> modelList = new List<BWS.ERP.Model.sysMenuEntity>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                BWS.ERP.Model.sysMenuEntity model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BWS.ERP.Model.sysMenuEntity();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["iFormID"].ToString() != "")
                    {
                        model.iFormID = int.Parse(dt.Rows[n]["iFormID"].ToString());
                    }
                    model.sMenuName = dt.Rows[n]["sMenuName"].ToString();
                    model.sMenuEngName = dt.Rows[n]["sMenuEngName"].ToString();
                    if (dt.Rows[n]["iParentID"].ToString() != "")
                    {
                        model.iParentID = int.Parse(dt.Rows[n]["iParentID"].ToString());
                    }
                    model.sModuleName = dt.Rows[n]["sModuleName"].ToString();
                    model.sFormClassName = dt.Rows[n]["sFormClassName"].ToString();
                    if (dt.Rows[n]["iSort"].ToString() != "")
                    {
                        model.iSort = int.Parse(dt.Rows[n]["iSort"].ToString());
                    }
                    model.sUserID = dt.Rows[n]["sUserID"].ToString();
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }


        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchAdd(DataTable dt, SqlTransaction trans)
        {
            List<BWS.ERP.Model.sysMenuEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.sysMenuEntity model in List.ToArray())
            {
                Add(model, trans);
            }
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchUpdate(DataTable dt, SqlTransaction trans)
        {
            List<BWS.ERP.Model.sysMenuEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.sysMenuEntity model in List.ToArray())
            {
                Update(model, trans);
            }
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchDelete(List<int> list, SqlTransaction trans)
        {
            foreach (int i in list.ToArray())
            {
                Delete(i, trans);
            }
        }

        #endregion  成员方法
    }
}

