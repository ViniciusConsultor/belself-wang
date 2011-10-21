//***************************************************************************************//
//��Ŀ���ƣ�BWS ERP System Platform
//ģ�����ƣ�BaseEnum
//ģ�����ϵͳ��������
//ģ��˵��������ö����
//�����ˣ�Belself.Wang
//����ʱ�䣺2010-7-14
//��ע��
//***************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BWS.ERP.BasePublic
{
    /// <summary>
    /// ����״̬
    /// </summary>
    public enum OperateFlag
    {
        /// <summary>
        /// ����
        /// </summary>
        Insert = 0,
        /// <summary>
        /// �༭
        /// </summary>
        Edit,
        /// <summary>
        /// ȡ��
        /// </summary>
        Cancel,
        /// <summary>
        /// ����
        /// </summary>
        Save,
        /// <summary>
        /// ����
        /// </summary>
        Copy,
        /// <summary>
        /// ��ѯ
        /// </summary>
        View,
        /// <summary>
        /// ɾ��
        /// </summary>
        Delete,
        /// <summary>
        /// ������
        /// </summary>
        None
    }
    /// <summary>
    /// ����״̬
    /// </summary>
    public enum DataFlag
    {
        /// <summary>
        /// ���
        /// </summary>
        dsBrowse = 0,
        /// <summary>
        /// ����
        /// </summary>
        dsInsert,
        /// <summary>
        /// �༭
        /// </summary>
        dsEdit
    }

    /// <summary>
    /// �ֶ���������
    /// </summary>
    public enum FiledType
    {
        /// <summary>
        /// �ַ���
        /// </summary>
        S=0,
        /// <summary>
        /// ��������
        /// </summary>
        D,
        /// <summary>
        /// �ַ����ͣ�ʹ��ComboBox
        /// </summary>
        C,
        /// <summary>
        /// ʱ������
        /// </summary>
        T,
        /// <summary>
        /// ��������
        /// </summary>
        N
    }

}
