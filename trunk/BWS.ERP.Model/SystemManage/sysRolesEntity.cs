//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      sysRolesEntity
//Create by:        自动生成
//Create Date:      2010-8-27 0:04:05
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类sysRolesEntity
    /// </summary>
    [Serializable]
    public class sysRolesEntity : Base.BaseEntity
    {
        public sysRolesEntity()
        { }
        #region Model
        private string _sroleno;
        private string _srolecname;
        private string _sroleename;
        private string _sremark;
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
        /// <summary>
        /// 
        /// </summary>
        public string sRoleEName
        {
            set { _sroleename = value; }
            get { return _sroleename; }
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

