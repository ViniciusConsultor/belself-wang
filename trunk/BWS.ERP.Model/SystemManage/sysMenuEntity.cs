//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      sysMenuEntity
//Create by:        自动生成
//Create Date:      2010-9-14 22:23:40
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类sysMenuEntity
    /// </summary>
    [Serializable]
    public class sysMenuEntity : Base.BaseEntity
    {
        public sysMenuEntity()
        { }
        #region Model
        private int _iformid;
        private string _smenuname;
        private string _smenuengname;
        private int _iparentid;
        private string _smodulename;
        private string _sformclassname;
        private int _isort;
        /// <summary>
        /// 
        /// </summary>
        public int iFormID
        {
            set { _iformid = value; }
            get { return _iformid; }
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
        public string sMenuEngName
        {
            set { _smenuengname = value; }
            get { return _smenuengname; }
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
        public string sModuleName
        {
            set { _smodulename = value; }
            get { return _smodulename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sFormClassName
        {
            set { _sformclassname = value; }
            get { return _sformclassname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iSort
        {
            set { _isort = value; }
            get { return _isort; }
        }
        #endregion Model

    }
}

