//***************************************************************************************//
//项目名称：BWSERP
//模块名称：frmBaseForm
//模块类别：系统基础窗体
//模块说明：基础类父窗体
//创建人：Belself.Wang
//创建时间：2010-7-14
//备注：
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
    /// 基础类父窗体
    /// </summary>
    public partial class frmBaseForm : frmForm
    {
        /// <summary>
        /// 不为空字段列表
        /// </summary>
        protected List<string> NotNullFields = new List<string>();

        /// <summary>
        /// 不需要复制字段列表
        /// </summary>
        protected List<string> NotCopyFields = new List<string>();

        /// <summary>
        /// 构造函数
        /// </summary>
        public frmBaseForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmBaseForm(int formid, string formtext)
            : base(formid, formtext)
        {
            InitializeComponent();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmBaseForm(int formid)
            : base(formid)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化基础
        /// </summary>
        public virtual void initBase()
        {
            //DoView();
            //initButtonsState(BWS.ERP.BasePublic.OperateFlag.None);
            DoBaseView();
        }

        #region 基本按钮状态控制

        /// <summary>
        /// 设置控制按钮初始状态
        /// </summary>
        /// <param name="BWS.ERP.BasePublic.OperateFlag">操作状态</param>
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
        /// 新增之前执行的方法
        /// </summary>
        public virtual bool DoAppend() { return true; }

        /// <summary>
        /// 新增
        /// </summary>
        public virtual void DoAdd()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Insert);
        }

        /// <summary>
        /// 查询
        /// </summary>
        public virtual void DoView()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.View);
        }

        /// <summary>
        /// 查询
        /// </summary>
        public virtual void DoBaseView()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.View);
        }

        /// <summary>
        /// 编辑之前执行的方法
        /// </summary>
        /// <returns></returns>
        public virtual bool DoBeforeEdit() { return true; }
        /// <summary>
        /// 编辑
        /// </summary>
        public virtual void DoEdit()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Edit);
        }

        /// <summary>
        /// 删除之前执行的方法
        /// </summary>
        public virtual bool DoBeforeDelete() { return true; }

        /// <summary>
        /// 删除
        /// </summary>
        public virtual bool DoDelete()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Delete);
            return true;
        }

        /// <summary>
        /// 删除之后执行的方法
        /// </summary>
        public virtual void DoAfterDelete() { }

        /// <summary>
        /// 复制
        /// </summary>
        public virtual void DoCopy()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Copy);
        }

        /// <summary>
        /// 取消之前执行的方法
        /// </summary>
        /// <returns></returns>
        public virtual bool DoBeforeCancel() { return true; }

        /// <summary>
        /// 取消
        /// </summary>
        public virtual void DoCancel()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Cancel);
        }

        /// <summary>
        /// 保存之前执行的方法
        /// </summary>
        public virtual bool DoBeforeSave() { return true; }

        /// <summary>
        /// 保存
        /// </summary>
        public virtual bool DoSave()
        {
            initButtonsState(BWS.ERP.BasePublic.OperateFlag.Save);
            return true;
        }

        /// <summary>
        /// 打印
        /// </summary>
        public virtual void DoPrint() { }
        /// <summary>
        /// 保存之后执行的方法
        /// </summary>
        public virtual bool DoAfterSave() { return true; }

        /// <summary>
        /// 窗体关闭之前执行的方法
        /// </summary>
        public virtual bool DoBeforeClose() { return true; }

        /// <summary>
        /// 窗体关闭
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
        /// 数据状态改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void DataStateChange(object sender, EventArgs e) { }

        /// <summary>
        /// 设置界面上不为空的字段列表
        /// </summary>
        /// <param name="notNullFields">不为空的字符串数组(控件名称)</param>
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
        /// 设置界面上不为空的字段列表
        /// </summary>
        /// <param name="notNullField">不为空的字符串(控件名称)</param>
        protected void AddNotNullFields(string notNullField)
        {
            NotNullFields.Add(notNullField);
        }

        /// <summary>
        /// 设置界面上不需要复制字段列表
        /// </summary>
        /// <param name="notCopyFields">不需要复制的字符串数组</param>
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
        /// 设置界面上不需要复制字段列表
        /// </summary>
        /// <param name="notCopyField">不需要复制的字符串</param>
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
                            BWS.ERP.BaseControl.Public.SystemInfo("保存成功！");
                        }
                    }
                    else
                    {
                        if (ShowSaveInfo)
                        {
                            BWS.ERP.BaseControl.Public.SystemInfo("保存失败！");
                        }
                        return;
                    }
                }
                else
                {
                    if (ShowSaveInfo)
                    {
                        BWS.ERP.BaseControl.Public.SystemInfo("保存失败！");
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
        /// 是否显示保存提示信息
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
