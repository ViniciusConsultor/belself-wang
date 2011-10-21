//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      vwsysRolesUserEntity
//Create by:        自动生成
//Create Date:      2010-8-27 0:31:41
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类sysRolesUserEntity
    /// </summary>
    [Serializable]
    public class sysRolesUserEntity : Base.BaseEntity
    {
        public sysRolesUserEntity()
        { }
        #region Model
        private int _roleid;
        private int _userid;
        private string _sroleuserid;
        private string _sroleusercname;
        private string _sroleno;
        private string _srolecname;
        /// <summary>
        /// 
        /// </summary>
        public int RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sRoleUserID
        {
            set { _sroleuserid = value; }
            get { return _sroleuserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sRoleUserCName
        {
            set { _sroleusercname = value; }
            get { return _sroleusercname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sRoleNo
        {
            set { _sroleno = value; }
            get { return _sroleno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sRoleCName
        {
            set { _srolecname = value; }
            get { return _srolecname; }
        }
        #endregion Model

    }
}

