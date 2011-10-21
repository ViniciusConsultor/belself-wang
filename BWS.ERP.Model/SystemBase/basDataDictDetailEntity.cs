//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      basDataDictDetailEntity
//Create by:        自动生成
//Create Date:      2010-8-21 14:58:38
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类basDataDictDetailEntity
    /// </summary>
    [Serializable]
    public class basDataDictDetailEntity : Base.BaseEntity
    {
        public basDataDictDetailEntity()
        { }
        #region Model
        private int _mainid;
        private string _sdictdatano;
        private string _sdictdatacname;
        private string _sdictdataename;
        private bool _bisstop;
        private string _sremark;
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
        public string sDictDataNo
        {
            set { _sdictdatano = value; }
            get { return _sdictdatano; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sDictDataCName
        {
            set { _sdictdatacname = value; }
            get { return _sdictdatacname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sDictDataEName
        {
            set { _sdictdataename = value; }
            get { return _sdictdataename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool bIsStop
        {
            set { _bisstop = value; }
            get { return _bisstop; }
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

