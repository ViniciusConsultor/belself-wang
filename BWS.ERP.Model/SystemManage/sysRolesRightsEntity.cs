//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      sysRolesRightsEntity
//Create by:        自动生成
//Create Date:      2010-8-27 0:11:18
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类sysRolesRightsEntity
    /// </summary>
    [Serializable]
    public class sysRolesRightsEntity : Base.BaseEntity
    {
        public sysRolesRightsEntity()
        { }
        #region Model
        private int _roleid;
        private int _menuid;
        private bool _iadd;
        private int _iview;
        private int _iedit;
        private int _idelete;
        private int _iprint;
        private int _inum;
        private int _iprice;
        private string _sroleno;
        private string _srolecname;
        private string _smenuname;
        private int _iparentid;
        private int _isort;
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
        public int MenuID
        {
            set { _menuid = value; }
            get { return _menuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool iAdd
        {
            set { _iadd = value; }
            get { return _iadd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iView
        {
            set { _iview = value; }
            get { return _iview; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iEdit
        {
            set { _iedit = value; }
            get { return _iedit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iDelete
        {
            set { _idelete = value; }
            get { return _idelete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iPrint
        {
            set { _iprint = value; }
            get { return _iprint; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iNum
        {
            set { _inum = value; }
            get { return _inum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iPrice
        {
            set { _iprice = value; }
            get { return _iprice; }
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
        /// <summary>
        /// 
        /// </summary>
        public string sMenuName
        {
            set { _smenuname = value; }
            get { return _smenuname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iParentID
        {
            set { _iparentid = value; }
            get { return _iparentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iSort
        {
            set { _isort = value; }
            get { return _isort; }
        }
        #endregion

    }
}

