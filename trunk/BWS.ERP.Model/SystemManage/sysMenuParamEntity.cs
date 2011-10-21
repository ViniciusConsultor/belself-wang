//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      sysMenuParamEntity
//Create by:        自动生成
//Create Date:      2010-9-14 22:26:39
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类sysMenuParamEntity
    /// </summary>
    [Serializable]
    public class sysMenuParamEntity : Base.BaseEntity
    {
        public sysMenuParamEntity()
        { }
        #region Model
        private int _menuid;
        private string _sparamname;
        private string _sparamvalue;
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
        public string sParamName
        {
            set { _sparamname = value; }
            get { return _sparamname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sParamValue
        {
            set { _sparamvalue = value; }
            get { return _sparamvalue; }
        }
        #endregion Model

    }
}

