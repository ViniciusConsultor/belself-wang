//***************************************************************************************//
//项目名称：BWS ERP System Platform
//模块名称：BaseEntity
//模块类别：实体层
//模块说明：所有的实体都继承此类
//创建人：Belself.Wang
//创建时间：2010-7-14
//备注：
//***************************************************************************************//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BWS.ERP.Model.Base
{
    public class BaseEntity
    {
        private int _id;
        /// <summary>
        /// 单据ID
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private int _iflag;
        /// <summary>
        /// 单据状态
        /// </summary>
        public int iFlag
        {
            get
            {
                return _iflag;
            }
            set
            {
                _iflag = value;
            }
        }

        private string _suserid;
        /// <summary>
        /// 创建者
        /// </summary>
        public string sUserID
        {
            get
            {
                return _suserid;
            }
            set
            {
                _suserid = value;
            }
        }

        private DateTime _inputdate;
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime dInputDate
        {
            get
            {
                return _inputdate;
            }
            set
            {
                _inputdate = value;
            }
        }
        
            
    }
}
