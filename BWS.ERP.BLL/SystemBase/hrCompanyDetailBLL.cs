//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.BLL
//Description:      hrCompanyDetailBLL
//Create by:        自动生成
//Create Date:      2010-9-14 23:01:19
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
    /// 业务逻辑类hrCompanyDetailBLL
    /// </summary>
    public class hrCompanyDetailBLL
    {
        private readonly BWS.ERP.DAL.hrCompanyDetailDAL dal = new BWS.ERP.DAL.hrCompanyDetailDAL();
        public hrCompanyDetailBLL()
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
        public int Add(BWS.ERP.Model.hrCompanyDetailEntity model, SqlTransaction trans)
        {
            return dal.Add(model, trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BWS.ERP.Model.hrCompanyDetailEntity model, SqlTransaction trans)
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
        public BWS.ERP.Model.hrCompanyDetailEntity GetModel(int ID)
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
        public List<BWS.ERP.Model.hrCompanyDetailEntity> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.hrCompanyDetailEntity> GetModelList(int top, string strWhere, string sortfield)
        {
            DataSet ds = dal.GetList(top, strWhere, sortfield);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.hrCompanyDetailEntity> DataTableToList(DataTable dt)
        {
            List<BWS.ERP.Model.hrCompanyDetailEntity> modelList = new List<BWS.ERP.Model.hrCompanyDetailEntity>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                BWS.ERP.Model.hrCompanyDetailEntity model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BWS.ERP.Model.hrCompanyDetailEntity();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    model.sCurrency = dt.Rows[n]["sCurrency"].ToString();
                    model.sBankName = dt.Rows[n]["sBankName"].ToString();
                    model.sBankAccount = dt.Rows[n]["sBankAccount"].ToString();
                    model.sBankAddr = dt.Rows[n]["sBankAddr"].ToString();
                    model.sRemark = dt.Rows[n]["sRemark"].ToString();
                    if (dt.Rows[n]["iFlag"].ToString() != "")
                    {
                        model.iFlag = int.Parse(dt.Rows[n]["iFlag"].ToString());
                    }
                    model.sUserID = dt.Rows[n]["sUserID"].ToString();
                    model.sCurrencyCName = dt.Rows[n]["sCurrencyCName"].ToString();
                    model.sCurrencyEName = dt.Rows[n]["sCurrencyEName"].ToString();
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
            List<BWS.ERP.Model.hrCompanyDetailEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.hrCompanyDetailEntity model in List.ToArray())
            {
                Add(model, trans);
            }
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchUpdate(DataTable dt, SqlTransaction trans)
        {
            List<BWS.ERP.Model.hrCompanyDetailEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.hrCompanyDetailEntity model in List.ToArray())
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

