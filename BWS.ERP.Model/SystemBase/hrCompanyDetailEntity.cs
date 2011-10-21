//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      hrCompanyDetailEntity
//Create by:        自动生成
//Create Date:      2010-9-1 22:42:15
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类hrCompanyDetailEntity
    /// </summary>
    [Serializable]
    public class hrCompanyDetailEntity : Base.BaseEntity
    {
        public hrCompanyDetailEntity()
        { }
        #region Model
        private int _mainid;
        private string _scurrency;
        private string _sbankname;
        private string _sbankaccount;
        private string _sbankaddr;
        private string _sremark;
        private string _scurrencycname;
        private string _scurrencyename;
        /// <summary>
        /// 
        /// </summary>
        public int MainID
        {
            set { _mainid = value; }
            get { return _mainid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sCurrency
        {
            set { _scurrency = value; }
            get { return _scurrency; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sBankName
        {
            set { _sbankname = value; }
            get { return _sbankname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sBankAccount
        {
            set { _sbankaccount = value; }
            get { return _sbankaccount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sBankAddr
        {
            set { _sbankaddr = value; }
            get { return _sbankaddr; }
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
        public string sCurrencyCName
        {
            set { _scurrencycname = value; }
            get { return _scurrencycname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sCurrencyEName
        {
            set { _scurrencyename = value; }
            get { return _scurrencyename; }
        }
        #endregion Model

    }
}

