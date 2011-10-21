//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      hrEmployeeEntity
//Create by:        自动生成
//Create Date:      2010-9-20 22:15:53
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类hrEmployeeEntity
    /// </summary>
    [Serializable]
    public class hrEmployeeEntity : Base.BaseEntity
    {
        public hrEmployeeEntity()
        { }
        #region Model
        private string _sempno;
        private string _sempcname;
        private string _sempename;
        private string _sisinservice;
        private string _sempcontractid;
        private string _sresidencetype;
        private string _sinsureid;
        private string _spaymentid;
        private string _ssex;
        private string _dbirthday;
        private string _dbabybirthday;
        private string _sidentitycard;
        private string _snation;
        private string _smarry;
        private int _sstature;
        private string _spolitystatus;
        private string _snativeplace;
        private string _sbrood;
        private string _sstudyexperience;
        private string _sgraduateinstitute;
        private string _sspeciality;
        private string _dincompanydate;
        private int _idepartmentid;
        private string _semptype;
        private string _scalltitle;
        private string _dcalltitledate;
        private string _sposition;
        private string _sforeignlangaugelevel;
        private string _scomputertechnolic;
        private string _semail;
        private string _spersoncontacttel;
        private string _sfamilycontacttel;
        private string _sothercontact;
        private string _sresidence;
        private string _sfamilyaddr;
        private string _sfamilymember;
        private string _sstudyexperienct;
        private string _sworkexperience;
        private string _dtryoutdate;
        private string _dformaldate;
        private byte[] _mpic;
        private string _denddate;
        private string _sremark;
        /// <summary>
        /// 
        /// </summary>
        public string sEmpNo
        {
            set { _sempno = value; }
            get { return _sempno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEmpCName
        {
            set { _sempcname = value; }
            get { return _sempcname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEmpEName
        {
            set { _sempename = value; }
            get { return _sempename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sIsInService
        {
            set { _sisinservice = value; }
            get { return _sisinservice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEmpContractID
        {
            set { _sempcontractid = value; }
            get { return _sempcontractid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sResidenceType
        {
            set { _sresidencetype = value; }
            get { return _sresidencetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sInsureID
        {
            set { _sinsureid = value; }
            get { return _sinsureid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sPayMentID
        {
            set { _spaymentid = value; }
            get { return _spaymentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sSex
        {
            set { _ssex = value; }
            get { return _ssex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dBirthday
        {
            set { _dbirthday = value; }
            get { return _dbirthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dBabyBirthday
        {
            set { _dbabybirthday = value; }
            get { return _dbabybirthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sIdentityCard
        {
            set { _sidentitycard = value; }
            get { return _sidentitycard; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sNation
        {
            set { _snation = value; }
            get { return _snation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sMarry
        {
            set { _smarry = value; }
            get { return _smarry; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sStature
        {
            set { _sstature = value; }
            get { return _sstature; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sPolityStatus
        {
            set { _spolitystatus = value; }
            get { return _spolitystatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sNativePlace
        {
            set { _snativeplace = value; }
            get { return _snativeplace; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sBrood
        {
            set { _sbrood = value; }
            get { return _sbrood; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sStudyExperience
        {
            set { _sstudyexperience = value; }
            get { return _sstudyexperience; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sGraduateInstitute
        {
            set { _sgraduateinstitute = value; }
            get { return _sgraduateinstitute; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sSpeciality
        {
            set { _sspeciality = value; }
            get { return _sspeciality; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dInCompanyDate
        {
            set { _dincompanydate = value; }
            get { return _dincompanydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int iDepartmentID
        {
            set { _idepartmentid = value; }
            get { return _idepartmentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sEmpType
        {
            set { _semptype = value; }
            get { return _semptype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sCallTitle
        {
            set { _scalltitle = value; }
            get { return _scalltitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dCallTitleDate
        {
            set { _dcalltitledate = value; }
            get { return _dcalltitledate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sPosition
        {
            set { _sposition = value; }
            get { return _sposition; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sForeignLangaugeLevel
        {
            set { _sforeignlangaugelevel = value; }
            get { return _sforeignlangaugelevel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sComputerTechnolic
        {
            set { _scomputertechnolic = value; }
            get { return _scomputertechnolic; }
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
        public string sPersonContactTel
        {
            set { _spersoncontacttel = value; }
            get { return _spersoncontacttel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sFamilyContactTel
        {
            set { _sfamilycontacttel = value; }
            get { return _sfamilycontacttel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sOtherContact
        {
            set { _sothercontact = value; }
            get { return _sothercontact; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sResidence
        {
            set { _sresidence = value; }
            get { return _sresidence; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sFamilyAddr
        {
            set { _sfamilyaddr = value; }
            get { return _sfamilyaddr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sFamilyMember
        {
            set { _sfamilymember = value; }
            get { return _sfamilymember; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sStudyExperienct
        {
            set { _sstudyexperienct = value; }
            get { return _sstudyexperienct; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sWorkExperience
        {
            set { _sworkexperience = value; }
            get { return _sworkexperience; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dTryoutDate
        {
            set { _dtryoutdate = value; }
            get { return _dtryoutdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dFormalDate
        {
            set { _dformaldate = value; }
            get { return _dformaldate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] mPic
        {
            set { _mpic = value; }
            get { return _mpic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dEndDate
        {
            set { _denddate = value; }
            get { return _denddate; }
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

