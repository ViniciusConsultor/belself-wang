//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.BLL
//Description:      hrCompanyMasterBLL
//Create by:        自动生成
//Create Date:      2010-9-14 22:58:16
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
    /// 业务逻辑类hrCompanyMasterBLL
    /// </summary>
    public class hrCompanyMasterBLL
    {
        private readonly BWS.ERP.DAL.hrCompanyMasterDAL dal = new BWS.ERP.DAL.hrCompanyMasterDAL();
        public hrCompanyMasterBLL()
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
        public int Add(BWS.ERP.Model.hrCompanyMasterEntity model, SqlTransaction trans)
        {
            return dal.Add(model, trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BWS.ERP.Model.hrCompanyMasterEntity model, SqlTransaction trans)
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
        public BWS.ERP.Model.hrCompanyMasterEntity GetModel(int ID)
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
        public List<BWS.ERP.Model.hrCompanyMasterEntity> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.hrCompanyMasterEntity> GetModelList(int top, string strWhere, string sortfield)
        {
            DataSet ds = dal.GetList(top, strWhere, sortfield);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.hrCompanyMasterEntity> DataTableToList(DataTable dt)
        {
            List<BWS.ERP.Model.hrCompanyMasterEntity> modelList = new List<BWS.ERP.Model.hrCompanyMasterEntity>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                BWS.ERP.Model.hrCompanyMasterEntity model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BWS.ERP.Model.hrCompanyMasterEntity();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.sCompanyID = dt.Rows[n]["sCompanyID"].ToString();
                    model.sCompanySName = dt.Rows[n]["sCompanySName"].ToString();
                    model.sCompanyCName = dt.Rows[n]["sCompanyCName"].ToString();
                    model.sCompanyEName = dt.Rows[n]["sCompanyEName"].ToString();
                    model.sCorporation = dt.Rows[n]["sCorporation"].ToString();
                    model.sTel = dt.Rows[n]["sTel"].ToString();
                    model.sFax = dt.Rows[n]["sFax"].ToString();
                    model.sEmail = dt.Rows[n]["sEmail"].ToString();
                    model.sHomepage = dt.Rows[n]["sHomepage"].ToString();
                    model.sChnAddr = dt.Rows[n]["sChnAddr"].ToString();
                    model.sEngAddr = dt.Rows[n]["sEngAddr"].ToString();
                    model.sPostCode = dt.Rows[n]["sPostCode"].ToString();
                    model.sTax = dt.Rows[n]["sTax"].ToString();
                    model.sChnTitle = dt.Rows[n]["sChnTitle"].ToString();
                    model.sEngTitle = dt.Rows[n]["sEngTitle"].ToString();
                    model.sChnTitle2 = dt.Rows[n]["sChnTitle2"].ToString();
                    model.sEngTitle2 = dt.Rows[n]["sEngTitle2"].ToString();
                    if (dt.Rows[n]["mlogo"].ToString() != "")
                    {
                        model.mlogo = (byte[])dt.Rows[n]["mlogo"];
                    }
                    model.sRemark = dt.Rows[n]["sRemark"].ToString();
                    model.dBillDate = dt.Rows[n]["dBillDate"].ToString();
                    if (dt.Rows[n]["iFlag"].ToString() != "")
                    {
                        model.iFlag = int.Parse(dt.Rows[n]["iFlag"].ToString());
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
            List<BWS.ERP.Model.hrCompanyMasterEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.hrCompanyMasterEntity model in List.ToArray())
            {
                Add(model, trans);
            }
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchUpdate(DataTable dt, SqlTransaction trans)
        {
            List<BWS.ERP.Model.hrCompanyMasterEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.hrCompanyMasterEntity model in List.ToArray())
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

