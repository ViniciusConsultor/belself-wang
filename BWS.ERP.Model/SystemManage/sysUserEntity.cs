//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      sysUserEntity
//Create by:        自动生成
//Create Date:      2010-9-25 22:53:40
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类sysUserEntity
    /// </summary>
    [Serializable]
    public class sysUserEntity : Base.BaseEntity
    {
        public sysUserEntity()
        { }
        #region Model
        private string _susercname;
        private string _suserename;
        private string _spassword;
        private int _parentid;
        private int _empid;
        private int _iusertype;
        private bool _bislock;
        private string _sremark;
        private string _susertypename;
        private string _sdeptno;
        private string _sdeptname;
        private string _sdeptename;
        private string _sparentuserid;
        private string _sparentcname;
        /// <summary>
        /// 
        /// </summary>
        public string sUserCName
        {
            set { _susercname = value; }
            get { return _susercname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sUserEName
        {
            set { _suserename = value; }
            get { return _suserename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sPassword
        {
            set { _spassword = value; }
            get { return _spassword; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ParentID
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EmpID
        {
            set { _empid = value; }
            get { return _empid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iUserType
        {
            set { _iusertype = value; }
            get { return _iusertype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool bIsLock
        {
            set { _bislock = value; }
            get { return _bislock; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sRemark
        {
            set { _sremark = value; }
            get { return _sremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sUserTypeName
        {
            set { _susertypename = value; }
            get { return _susertypename; }
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
        public string sParentUserID
        {
            set { _sparentuserid = value; }
            get { return _sparentuserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sParentCName
        {
            set { _sparentcname = value; }
            get { return _sparentcname; }
        }
        #endregion Model

    }
}

