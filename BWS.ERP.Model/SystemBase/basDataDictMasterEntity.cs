//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.Model
//Description:      basDataDictMasterEntity
//Create by:        自动生成
//Create Date:      2010-8-21 14:01:23
//Modify by：              Modify Date：               Description：
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.Model
{
    /// <summary>
    /// 实体类basDataDictMasterEntity
    /// </summary>
    [Serializable]
    public class basDataDictMasterEntity : Base.BaseEntity
    {
        public basDataDictMasterEntity()
        { }
        #region Model
        private string _sdictcategoryno;
        private string _sdictcategorycname;
        private string _sdictcategoryename;
        private string _sremark;
        /// <summary>
        /// 
        /// </summary>
        public string sDictCategoryNo
        {
            set { _sdictcategoryno = value; }
            get { return _sdictcategoryno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sDictCategoryCName
        {
            set { _sdictcategorycname = value; }
            get { return _sdictcategorycname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sDictCategoryEName
        {
            set { _sdictcategoryename = value; }
            get { return _sdictcategoryename; }
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

