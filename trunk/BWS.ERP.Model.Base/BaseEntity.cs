//***************************************************************************************//
//��Ŀ���ƣ�BWS ERP System Platform
//ģ�����ƣ�BaseEntity
//ģ�����ʵ���
//ģ��˵�������е�ʵ�嶼�̳д���
//�����ˣ�Belself.Wang
//����ʱ�䣺2010-7-14
//��ע��
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
        /// ����ID
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
        /// ����״̬
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
        /// ������
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
        /// ¼��ʱ��
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
