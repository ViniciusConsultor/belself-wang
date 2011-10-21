//-------------------------------------------------------------------------------------------
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
    public class sysMenuNodeBLL
    {
        private readonly BWS.ERP.DAL.sysMenuNodeDAL dal = new BWS.ERP.DAL.sysMenuNodeDAL();
        public sysMenuNodeBLL()
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
        public int Add(BWS.ERP.Model.sysMenuNodeEntity model, SqlTransaction trans)
        {
            return dal.Add(model, trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BWS.ERP.Model.sysMenuNodeEntity model, SqlTransaction trans)
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
        public BWS.ERP.Model.sysMenuNodeEntity GetModel(int ID)
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
        public List<BWS.ERP.Model.sysMenuNodeEntity> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.sysMenuNodeEntity> GetModelList(int top, string strWhere, string sortfield)
        {
            DataSet ds = dal.GetList(top, strWhere, sortfield);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.sysMenuNodeEntity> DataTableToList(DataTable dt)
        {
            List<BWS.ERP.Model.sysMenuNodeEntity> modelList = new List<BWS.ERP.Model.sysMenuNodeEntity>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                BWS.ERP.Model.sysMenuNodeEntity model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BWS.ERP.Model.sysMenuNodeEntity();
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
                    if (dt.Rows[n]["mCurrentDLL"].ToString() != "")
                    {
                        model.mCurrentDLL = (byte[])dt.Rows[n]["mCurrentDLL"];
                    }
                    if (dt.Rows[n]["mLastDLL"].ToString() != "")
                    {
                        model.mLastDLL = (byte[])dt.Rows[n]["mLastDLL"];
                    }
                    model.dDLLGetTime = dt.Rows[n]["dDLLGetTime"].ToString();
                    model.dDLLLastTime = dt.Rows[n]["dDLLLastTime"].ToString();
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
            List<BWS.ERP.Model.sysMenuNodeEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.sysMenuNodeEntity model in List.ToArray())
            {
                Add(model, trans);
            }
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchUpdate(DataTable dt, SqlTransaction trans)
        {
            List<BWS.ERP.Model.sysMenuNodeEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.sysMenuNodeEntity model in List.ToArray())
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

