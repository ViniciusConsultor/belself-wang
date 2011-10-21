//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.BLL
//Description:      sysUserBLL
//Create by:        自动生成
//Create Date:      2010-9-25 22:30:20
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
    /// 业务逻辑类sysUserBLL
    /// </summary>
    public class sysUserBLL
    {
        private readonly BWS.ERP.DAL.sysUserDAL dal = new BWS.ERP.DAL.sysUserDAL();
        public sysUserBLL()
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
        public int Add(BWS.ERP.Model.sysUserEntity model, SqlTransaction trans)
        {
            return dal.Add(model, trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BWS.ERP.Model.sysUserEntity model, SqlTransaction trans)
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
        public BWS.ERP.Model.sysUserEntity GetModel(int ID)
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
        public List<BWS.ERP.Model.sysUserEntity> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.sysUserEntity> GetModelList(int top, string strWhere, string sortfield)
        {
            DataSet ds = dal.GetList(top, strWhere, sortfield);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.sysUserEntity> DataTableToList(DataTable dt)
        {
            List<BWS.ERP.Model.sysUserEntity> modelList = new List<BWS.ERP.Model.sysUserEntity>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                BWS.ERP.Model.sysUserEntity model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BWS.ERP.Model.sysUserEntity();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.sUserID = dt.Rows[n]["sUserID"].ToString();
                    model.sUserCName = dt.Rows[n]["sUserCName"].ToString();
                    model.sUserEName = dt.Rows[n]["sUserEName"].ToString();
                    string s = BWS.ERP.BaseControl.SysEncrypt.DecryptStr(dt.Rows[n]["sPassword"].ToString());
                    if (s != "KeyError")
                    {
                        model.sPassword = s;
                    }
                    else
                    {
                        model.sPassword = dt.Rows[n]["sPassword"].ToString();
                    }
                    if (dt.Rows[n]["ParentID"].ToString() != "")
                    {
                        model.ParentID = int.Parse(dt.Rows[n]["ParentID"].ToString());
                    }
                    if (dt.Rows[n]["EmpID"].ToString() != "")
                    {
                        model.EmpID = int.Parse(dt.Rows[n]["EmpID"].ToString());
                    }
                    if (dt.Rows[n]["iUserType"].ToString() != "")
                    {
                        model.iUserType = int.Parse(dt.Rows[n]["iUserType"].ToString());
                    }
                    if (dt.Rows[n]["bIsLock"].ToString() != "")
                    {
                        if ((dt.Rows[n]["bIsLock"].ToString() == "1") || (dt.Rows[n]["bIsLock"].ToString().ToLower() == "true"))
                        {
                            model.bIsLock = true;
                        }
                        else
                        {
                            model.bIsLock = false;
                        }
                    }
                    model.sRemark = dt.Rows[n]["sRemark"].ToString();
                    if (dt.Rows[n]["iFlag"].ToString() != "")
                    {
                        model.iFlag = int.Parse(dt.Rows[n]["iFlag"].ToString());
                    }
                    model.sUserTypeName = dt.Rows[n]["sUserTypeName"].ToString();
                    model.sDeptNo = dt.Rows[n]["sDeptNo"].ToString();
                    model.sDeptName = dt.Rows[n]["sDeptName"].ToString();
                    model.sDeptEName = dt.Rows[n]["sDeptEName"].ToString();
                    model.sParentUserID = dt.Rows[n]["sParentUserID"].ToString();
                    model.sParentCName = dt.Rows[n]["sParentCName"].ToString();
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
            List<BWS.ERP.Model.sysUserEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.sysUserEntity model in List.ToArray())
            {
                Add(model, trans);
            }
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchUpdate(DataTable dt, SqlTransaction trans)
        {
            List<BWS.ERP.Model.sysUserEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.sysUserEntity model in List.ToArray())
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

