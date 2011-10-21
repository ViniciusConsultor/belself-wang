//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      hrCompanyMasterEntity
//Create by:        自动生成
//Create Date:      2010-9-14 22:57:42
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类hrCompanyMasterEntity
    /// </summary>
    [Serializable]
    public class hrCompanyMasterEntity : Base.BaseEntity
    {
        public hrCompanyMasterEntity()
        { }
        #region Model
        private string _scompanyid;
        private string _scompanysname;
        private string _scompanycname;
        private string _scompanyename;
        private string _scorporation;
        private string _stel;
        private string _sfax;
        private string _semail;
        private string _shomepage;
        private string _schnaddr;
        private string _sengaddr;
        private string _spostcode;
        private string _stax;
        private string _schntitle;
        private string _sengtitle;
        private string _schntitle2;
        private string _sengtitle2;
        private byte[] _mlogo;
        private string _sremark;
        private string _dbilldate;
        /// <summary>
        /// 
        /// </summary>
        public string sCompanyID
        {
            set { _scompanyid = value; }
            get { return _scompanyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sCompanySName
        {
            set { _scompanysname = value; }
            get { return _scompanysname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sCompanyCName
        {
            set { _scompanycname = value; }
            get { return _scompanycname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sCompanyEName
        {
            set { _scompanyename = value; }
            get { return _scompanyename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sCorporation
        {
            set { _scorporation = value; }
            get { return _scorporation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sTel
        {
            set { _stel = value; }
            get { return _stel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sFax
        {
            set { _sfax = value; }
            get { return _sfax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEmail
        {
            set { _semail = value; }
            get { return _semail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sHomepage
        {
            set { _shomepage = value; }
            get { return _shomepage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sChnAddr
        {
            set { _schnaddr = value; }
            get { return _schnaddr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEngAddr
        {
            set { _sengaddr = value; }
            get { return _sengaddr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sPostCode
        {
            set { _spostcode = value; }
            get { return _spostcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sTax
        {
            set { _stax = value; }
            get { return _stax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sChnTitle
        {
            set { _schntitle = value; }
            get { return _schntitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEngTitle
        {
            set { _sengtitle = value; }
            get { return _sengtitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sChnTitle2
        {
            set { _schntitle2 = value; }
            get { return _schntitle2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEngTitle2
        {
            set { _sengtitle2 = value; }
            get { return _sengtitle2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] mlogo
        {
            set { _mlogo = value; }
            get { return _mlogo; }
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
        public string dBillDate
        {
            set { _dbilldate = value; }
            get { return _dbilldate; }
        }
        #endregion Model

    }
}

