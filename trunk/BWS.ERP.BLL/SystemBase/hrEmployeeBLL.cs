//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.BLL
//Description:      hrEmployeeBLL
//Create by:        自动生成
//Create Date:      2010-9-20 22:21:06
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
    /// 业务逻辑类hrEmployeeBLL
    /// </summary>
    public class hrEmployeeBLL
    {
        private readonly BWS.ERP.DAL.hrEmployeeDAL dal = new BWS.ERP.DAL.hrEmployeeDAL();
        public hrEmployeeBLL()
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
        public int Add(BWS.ERP.Model.hrEmployeeEntity model, SqlTransaction trans)
        {
            return dal.Add(model, trans);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BWS.ERP.Model.hrEmployeeEntity model, SqlTransaction trans)
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
        public BWS.ERP.Model.hrEmployeeEntity GetModel(int ID)
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
        public List<BWS.ERP.Model.hrEmployeeEntity> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.hrEmployeeEntity> GetModelList(int top, string strWhere, string sortfield)
        {
            DataSet ds = dal.GetList(top, strWhere, sortfield);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BWS.ERP.Model.hrEmployeeEntity> DataTableToList(DataTable dt)
        {
            List<BWS.ERP.Model.hrEmployeeEntity> modelList = new List<BWS.ERP.Model.hrEmployeeEntity>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                BWS.ERP.Model.hrEmployeeEntity model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BWS.ERP.Model.hrEmployeeEntity();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.sEmpNo = dt.Rows[n]["sEmpNo"].ToString();
                    model.sEmpCName = dt.Rows[n]["sEmpCName"].ToString();
                    model.sEmpEName = dt.Rows[n]["sEmpEName"].ToString();
                    model.sIsInService = dt.Rows[n]["sIsInService"].ToString();
                    model.sEmpContractID = dt.Rows[n]["sEmpContractID"].ToString();
                    model.sResidenceType = dt.Rows[n]["sResidenceType"].ToString();
                    model.sInsureID = dt.Rows[n]["sInsureID"].ToString();
                    model.sPayMentID = dt.Rows[n]["sPayMentID"].ToString();
                    model.sSex = dt.Rows[n]["sSex"].ToString();
                    model.dBirthday = dt.Rows[n]["dBirthday"].ToString();
                    model.dBabyBirthday = dt.Rows[n]["dBabyBirthday"].ToString();
                    model.sIdentityCard = dt.Rows[n]["sIdentityCard"].ToString();
                    model.sNation = dt.Rows[n]["sNation"].ToString();
                    model.sMarry = dt.Rows[n]["sMarry"].ToString();
                    if (dt.Rows[n]["sStature"].ToString() != "")
                    {
                        model.sStature = int.Parse(dt.Rows[n]["sStature"].ToString());
                    }
                    model.sPolityStatus = dt.Rows[n]["sPolityStatus"].ToString();
                    model.sNativePlace = dt.Rows[n]["sNativePlace"].ToString();
                    model.sBrood = dt.Rows[n]["sBrood"].ToString();
                    model.sStudyExperience = dt.Rows[n]["sStudyExperience"].ToString();
                    model.sGraduateInstitute = dt.Rows[n]["sGraduateInstitute"].ToString();
                    model.sSpeciality = dt.Rows[n]["sSpeciality"].ToString();
                    model.dInCompanyDate = dt.Rows[n]["dInCompanyDate"].ToString();
                    if (dt.Rows[n]["iDepartmentID"].ToString() != "")
                    {
                        model.iDepartmentID = int.Parse(dt.Rows[n]["iDepartmentID"].ToString());
                    }
                    model.sEmpType = dt.Rows[n]["sEmpType"].ToString();
                    model.sCallTitle = dt.Rows[n]["sCallTitle"].ToString();
                    model.dCallTitleDate = dt.Rows[n]["dCallTitleDate"].ToString();
                    model.sPosition = dt.Rows[n]["sPosition"].ToString();
                    model.sForeignLangaugeLevel = dt.Rows[n]["sForeignLangaugeLevel"].ToString();
                    model.sComputerTechnolic = dt.Rows[n]["sComputerTechnolic"].ToString();
                    model.sEmail = dt.Rows[n]["sEmail"].ToString();
                    model.sPersonContactTel = dt.Rows[n]["sPersonContactTel"].ToString();
                    model.sFamilyContactTel = dt.Rows[n]["sFamilyContactTel"].ToString();
                    model.sOtherContact = dt.Rows[n]["sOtherContact"].ToString();
                    model.sResidence = dt.Rows[n]["sResidence"].ToString();
                    model.sFamilyAddr = dt.Rows[n]["sFamilyAddr"].ToString();
                    model.sFamilyMember = dt.Rows[n]["sFamilyMember"].ToString();
                    model.sStudyExperienct = dt.Rows[n]["sStudyExperienct"].ToString();
                    model.sWorkExperience = dt.Rows[n]["sWorkExperience"].ToString();
                    model.dTryoutDate = dt.Rows[n]["dTryoutDate"].ToString();
                    model.dFormalDate = dt.Rows[n]["dFormalDate"].ToString();
                    if (dt.Rows[n]["mPic"].ToString() != "")
                    {
                        model.mPic = (byte[])dt.Rows[n]["mPic"];
                    }
                    model.dEndDate = dt.Rows[n]["dEndDate"].ToString();
                    model.sRemark = dt.Rows[n]["sRemark"].ToString();
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
            List<BWS.ERP.Model.hrEmployeeEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.hrEmployeeEntity model in List.ToArray())
            {
                Add(model, trans);
            }
        }

        /// <summary>
        /// 批量增加数据
        /// </summary>
        public void BatchUpdate(DataTable dt, SqlTransaction trans)
        {
            List<BWS.ERP.Model.hrEmployeeEntity> List = DataTableToList(dt);
            foreach (BWS.ERP.Model.hrEmployeeEntity model in List.ToArray())
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

