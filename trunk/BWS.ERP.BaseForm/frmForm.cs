//***************************************************************************************//
//项目名称：BWS ERP System Platform
//模块名称：frmForm
//模块类别：系统基础窗体
//模块说明：所有的窗体都继承此窗体
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
using DevExpress.XtraEditors;

namespace BWS.ERP.BaseForm
{
    public partial class frmForm : DevExpress.XtraEditors.XtraForm
    {
        public frmForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="formtext">窗体名称</param>
        public frmForm(int formid,string formtext)
        {
            InitializeComponent();
            FormID = formid;
            FormText = formtext;
            if (FormText != "")
            {
                this.Text = FormText;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        public frmForm(int formid)
        {
            InitializeComponent();
            FormID = formid;
            if (FormText != "")
            {
                this.Text = FormText;
            }
        }
        /// <summary>
        /// 窗体ID
        /// </summary>
        private int _FormID = 0;

        /// <summary>
        /// 窗体ID
        /// </summary>
        protected int FormID
        {
            get
            {
                return _FormID;
            }
            set
            {
                _FormID = value;
            }
        }
        /// <summary>
        /// 窗体是否是第一次加载
        /// </summary>
        private bool _IsFirtLoad = false;
        /// <summary>
        /// 窗体是否是第一次加载
        /// </summary>
        protected bool IsFirstLoad
        {
            get
            {
                return _IsFirtLoad;
            }
            set
            {
                _IsFirtLoad = value;
            }
        }
        /// <summary>
        /// 数据操作状态
        /// </summary>
        private BWS.ERP.BasePublic.DataFlag _DataFlag = 0;
        /// <summary>
        /// 数据操作状态
        /// </summary>
        protected BWS.ERP.BasePublic.DataFlag FormDataFlag
        {
            get
            {
                return _DataFlag;
            }
            set
            {
                _DataFlag = value;
            }
        }
        private string _formtext = "";
        /// <summary>
        /// 窗体Text
        /// </summary>
        protected string FormText
        {
            get
            {
                return _formtext;
            }
            set
            {
                _formtext = value;
            }
        }

    }
}