//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      hrDepartmentEntity
//Create by:        自动生成
//Create Date:      2010-9-22 17:02:29
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类hrDepartmentEntity
    /// </summary>
    [Serializable]
    public class hrDepartmentEntity : Base.BaseEntity
    {
        public hrDepartmentEntity()
        { }
        #region Model
        private int _icompanyid;
        private string _sdeptno;
        private string _sdeptname;
        private string _sdeptename;
        private string _sremark;
        /// <summary>
        /// 
        /// </summary>
        public int iCompanyID
        {
            set { _icompanyid = value; }
            get { return _icompanyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sDeptNo
        {
            set { _sdeptno = value; }
            get { return _sdeptno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sDeptName
        {
            set { _sdeptname = value; }
            get { return _sdeptname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sDeptEName
        {
            set { _sdeptename = value; }
            get { return _sdeptename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sRemark
        {
            set { _sremark = value; }
            get { return _sremark; }
        }
        #endregion Model

    }
}

