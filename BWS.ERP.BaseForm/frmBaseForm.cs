//***************************************************************************************//
//��Ŀ���ƣ�BWSERP
//ģ�����ƣ�frmBaseForm
//ģ�����ϵͳ��������
//ģ��˵���������ุ����
//�����ˣ�Belself.Wang
//����ʱ�䣺2010-7-14
//��ע��
//***************************************************************************************//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BWS.ERP.BaseForm
{
    /// <summary>
    /// �����ุ����
    /// </summary>
    public partial class frmBaseForm : frmForm
    {
        /// <summary>
        /// ��Ϊ���ֶ��б�
        /// </summary>
        protected List<string> NotNullFields = new List<string>();

        /// <summary>
        /// ����Ҫ�����ֶ��б�
        /// </summary>
        protected List<string> NotCopyFields = new List<string>();

        /// <summary>
        /// ���캯��
        /// </summary>
        public frmBaseForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        public frmBaseForm(int formid, string formtext)
            : base(formid, formtext)
        {
            InitializeComponent();
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        public frmBaseForm(int formid)
            : base(formid)
        {
            InitializeComponent();
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        public virtual void initBase()
        {
            //DoView();
            //initButtonsState(BWS.ERP.BasePublic.OperateFlag.None);
            DoBaseView();
        }

        #region ������ť״̬����

        /// <summary>
        /// ���ÿ��ư�ť��ʼ״̬
        /// </summary>
        /// <param name="BWS.ERP.BasePublic.OperateFlag">����״̬</param>
        public virtual void initButtonsState(ERP.BasePublic.OperateFlag operateflag)
        {
            switch (operateflag)
            {
                case BWS.ERP.BasePublic.OperateFlag.View:
                    {
                        btnView.Enabled = true;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnPrint.Enabled = true;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = true;
                        break;
                    }
                case BWS.ERP.BasePublic.OperateFlag.Insert:
                    {
                        btnView.Enabled = false;
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = true;
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnPrint.Enabled = false;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = false;
                        break;
                    }
                case BWS.ERP.BasePublic.OperateFlag.Edit:
                    {
                        btnView.Enabled = false;
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = true;
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnPrint.Enabled = false;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = false;
                        break;
                    }
                case BWS.ERP.BasePublic.OperateFlag.Cancel:
                    {
                        btnView.Enabled = true;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnPrint.Enabled = true;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = true;
                        break;
                    }
                case BWS.ERP.BasePublic.OperateFlag.Save:
                    {
                        btnView.Enabled = true;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnPrint.Enabled = true;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = true;
                        break;
                    }
                case BWS.ERP.BasePublic.OperateFlag.Copy:
                    {
                        btnView.Enabled = false;
                        btnAdd.Enabled = false;
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = true;
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnPrint.Enabled = false;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = false;
                        break;
                    }
                case BWS.ERP.BasePublic.OperateFlag.Delete:
                    {
                        btnView.Enabled = true;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnPrint.Enabled = true;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = true;
                        break;
                    }
                case BWS.ERP.BasePublic.OperateFlag.None:
                    {
                        btnView.Enabled = true;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        btnPrint.Enabled = false;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = false;
                        break;
                    }
                default:
                    {
                        btnView.Enabled = true;
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnPrint.Enabled = true;
                        btnClose.Enabled = true;
                        btnCopy.Enabled = true;
                        break;
                    }
            }
        }
        /// <summary>
        /// ����֮ǰִ�еķ���
        /// </summary>
        public virtual bool DoAppend() { return true; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual void DoAdd()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Insert);
        }

        /// <summary>
        /// ��ѯ
        /// </summary>
        public virtual void DoView()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.View);
        }

        /// <summary>
        /// ��ѯ
        /// </summary>
        public virtual void DoBaseView()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.View);
        }

        /// <summary>
        /// �༭֮ǰִ�еķ���
        /// </summary>
        /// <returns></returns>
        public virtual bool DoBeforeEdit() { return true; }
        /// <summary>
        /// �༭
        /// </summary>
        public virtual void DoEdit()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Edit);
        }

        /// <summary>
        /// ɾ��֮ǰִ�еķ���
        /// </summary>
        public virtual bool DoBeforeDelete() { return true; }

        /// <summary>
        /// ɾ��
        /// </summary>
        public virtual bool DoDelete()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Delete);
            return true;
        }

        /// <summary>
        /// ɾ��֮��ִ�еķ���
        /// </summary>
        public virtual void DoAfterDelete() { }

        /// <summary>
        /// ����
        /// </summary>
        public virtual void DoCopy()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Copy);
        }

        /// <summary>
        /// ȡ��֮ǰִ�еķ���
        /// </summary>
        /// <returns></returns>
        public virtual bool DoBeforeCancel() { return true; }

        /// <summary>
        /// ȡ��
        /// </summary>
        public virtual void DoCancel()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Cancel);
        }

        /// <summary>
        /// ����֮ǰִ�еķ���
        /// </summary>
        public virtual bool DoBeforeSave() { return true; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual bool DoSave()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Save);
            return true;
        }

        /// <summary>
        /// ��ӡ
        /// </summary>
        public virtual void DoPrint() { }
        /// <summary>
        /// ����֮��ִ�еķ���
        /// </summary>
        public virtual bool DoAfterSave() { return true; }

        /// <summary>
        /// ����ر�֮ǰִ�еķ���
        /// </summary>
        public virtual bool DoBeforeClose() { return true; }

        /// <summary>
        /// ����ر�
        /// </summary>
        public virtual void DoClose()
        {
            this.Close();
        }

        #endregion

        public virtual void frmBaseForm_Load(object sender, EventArgs e)
        {
            initBase();
            IsFirstLoad = true;
            this.txtDataFlag.TextChanged += new EventHandler(DataStateChange);
        }

        /// <summary>
        /// ����״̬�ı��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void DataStateChange(object sender, EventArgs e) { }

        /// <summary>
        /// ���ý����ϲ�Ϊ�յ��ֶ��б�
        /// </summary>
        /// <param name="notNullFields">��Ϊ�յ��ַ�������(�ؼ�����)</param>
        protected void AddNotNullFields(string[] notNullFields)
        {
            foreach (string s in notNullFields)
            {
                if (s.Length > 0)
                {
                    NotNullFields.Add(s);
                }
            }
        }
        /// <summary>
        /// ���ý����ϲ�Ϊ�յ��ֶ��б�
        /// </summary>
        /// <param name="notNullField">��Ϊ�յ��ַ���(�ؼ�����)</param>
        protected void AddNotNullFields(string notNullField)
        {
            NotNullFields.Add(notNullField);
        }

        /// <summary>
        /// ���ý����ϲ���Ҫ�����ֶ��б�
        /// </summary>
        /// <param name="notCopyFields">����Ҫ���Ƶ��ַ�������</param>
        protected void AddNotCopyFields(string[] notCopyFields)
        {
            foreach (string s in notCopyFields)
            {
                if (s.Length > 0)
                {
                    NotCopyFields.Add(s);
                }
            }
        }

        /// <summary>
        /// ���ý����ϲ���Ҫ�����ֶ��б�
        /// </summary>
        /// <param name="notCopyField">����Ҫ���Ƶ��ַ���</param>
        protected void AddNotCopyFields(string notCopyField)
        {
            NotCopyFields.Add(notCopyField);
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
            base.OnFormClosing(e);
        }

        public virtual void btnView_Click(object sender, EventArgs e)
        {
            DoView();
            FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {
            if (DoAppend())
            {
                DoAdd();
                FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsInsert;
                txtDataFlag.Text = FormDataFlag.ToString();
            }
        }

        public virtual void btnEdit_Click(object sender, EventArgs e)
        {
            if (DoBeforeEdit())
            {
                DoEdit();
                FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsEdit;
                txtDataFlag.Text = FormDataFlag.ToString();
            }
        }

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {
            if (DoBeforeDelete())
            {
                if (DoDelete())
                {
                    DoAfterDelete();
                    FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
                }
            }
        }

        public virtual void btnCopy_Click(object sender, EventArgs e)
        {
            DoCopy();
            FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsInsert;
            txtDataFlag.Text = FormDataFlag.ToString();
        }

        public virtual void btnCancel_Click(object sender, EventArgs e)
        {
            if (DoBeforeCancel())
            {
                DoCancel();
                FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
                txtDataFlag.Text = FormDataFlag.ToString();
            }
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {
            if (DoBeforeSave())
            {
                if (DoSave())
                {
                    FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
                    txtDataFlag.Text = FormDataFlag.ToString();
                    if (DoAfterSave())
                    {
                        if (ShowSaveInfo)
                        {
                            BWS.ERP.BaseControl.Public.SystemInfo("����ɹ���");
                        }
                    }
                    else
                    {
                        if (ShowSaveInfo)
                        {
                            BWS.ERP.BaseControl.Public.SystemInfo("����ʧ�ܣ�");
                        }
                        return;
                    }
                }
                else
                {
                    if (ShowSaveInfo)
                    {
                        BWS.ERP.BaseControl.Public.SystemInfo("����ʧ�ܣ�");
                    }
                    return;
                }
            }
        }

        public virtual void btnPrint_Click(object sender, EventArgs e)
        {
            DoPrint();
            FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
        }

        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            if (DoBeforeClose())
            {
                FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
                DoClose();
            }
        }

        public virtual void btnRefesh_Click(object sender, EventArgs e)
        {
            FormDataFlag = BWS.ERP.BasePublic.DataFlag.dsBrowse;
        }

        private bool _ShowSaveInfo = true;
        /// <summary>
        /// �Ƿ���ʾ������ʾ��Ϣ
        /// </summary>
        public bool ShowSaveInfo
        {
            get
            {
                return _ShowSaveInfo;
            }
            set
            {
                _ShowSaveInfo = value;
            }
        }
    }
}
