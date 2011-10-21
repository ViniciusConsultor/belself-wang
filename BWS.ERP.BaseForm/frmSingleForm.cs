//***************************************************************************************//
//项目名称：BWS ERP System Platform
//模块名称：frmSingleForm
//模块类别：系统基础窗体
//模块说明：基础单表窗体，适用于只操作一张数据表的窗体
//创建人：Belself.Wang
//创建时间：2010-7-14
//备注：
//***************************************************************************************//
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;
using BWS.ERP.Security;

namespace BWS.ERP.BaseForm
{
    /// <summary>
    /// 基础单表窗体
    /// </summary>
    public partial class frmSingleForm : frmBaseForm
    {
        #region 定义
        /// <summary>
        /// 数据层操作对象
        /// </summary>
        private object objDAL;
        private MethodInfo mGetDataSet;
        private MethodInfo mGetTopDataSet;
        private MethodInfo mAddInTrans;
        private MethodInfo mUpdateInTrans;
        private MethodInfo mDeleteInTrans;

        /// <summary>
        /// 主表数据
        /// </summary>
        protected DataTable dtMain;


        /// <summary>
        /// 窗体参数列表
        /// </summary>
        protected Hashtable FormParaList = new Hashtable();

        /// <summary>
        /// 权限处理定义
        /// </summary>
        protected BWS.ERP.Security.SecurityCenter SC = new BWS.ERP.Security.SecurityCenter();

        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmSingleForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        /// <param name="pwhere">数据过滤条件,设置条件一定要注意SQL语句的拼接,条件前面需要加上AND关键字,e.g:AND 1=1</param>
        /// <param name="top">前多少行数据</param>
        /// <param name="sortfield">排序字段</param>
        public frmSingleForm(int formid, string dalname, int top, string pwhere, string sortfield)
            : base(formid)
        {
            InitializeComponent();
            pWhere = pwhere;
            TopCount = top;
            SortField = sortfield;
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(top, SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere, sortfield).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet(top, "1=1 " + pWhere, sortfield).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(TopCount, MasterSQL, SortField).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        /// <param name="pwhere">数据过滤条件,设置条件一定要注意SQL语句的拼接,条件前面需要加上AND关键字,e.g:AND 1=1</param>
        /// <param name="top">前多少行数据</param>
        /// <param name="sortfield">排序字段</param>
        /// <param name="ischeckauth">是否加载权限控制</param>
        public frmSingleForm(int formid, string dalname, int top, string pwhere, string sortfield, bool ischeckauth)
            : base(formid)
        {
            InitializeComponent();
            pWhere = pwhere;
            TopCount = top;
            SortField = sortfield;
            IsCheckAuth = ischeckauth;
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(top, SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere, sortfield).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet(top, "1=1 " + pWhere, sortfield).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(TopCount, MasterSQL, SortField).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        /// <param name="pwhere">数据过滤条件,设置条件一定要注意SQL语句的拼接,条件前面需要加上AND关键字,e.g:AND 1=1</param>
        /// <param name="sortfield">排序字段</param>
        public frmSingleForm(int formid, string dalname, string pwhere, string sortfield)
            : base(formid)
        {
            InitializeComponent();
            SortField = sortfield;
            //pWhere = sortfield != "" ? pwhere + " ORDER BY " + sortfield : pwhere;
            pWhere = pwhere;
            SortField = sortfield;
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(100000, SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere, SortField).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(100000, MasterSQL, SortField).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        /// <param name="pwhere">数据过滤条件,设置条件一定要注意SQL语句的拼接,条件前面需要加上AND关键字,e.g:AND 1=1</param>
        /// <param name="sortfield">排序字段</param>
        /// <param name="ischeckauth">是否加载权限控制</param>
        public frmSingleForm(int formid, string dalname, string pwhere, string sortfield, bool ischeckauth)
            : base(formid)
        {
            InitializeComponent();
            SortField = sortfield;
            //pWhere = sortfield != "" ? pwhere + " ORDER BY " + sortfield : pwhere;
            pWhere = pwhere;
            SortField = sortfield;
            IsCheckAuth = ischeckauth;
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(100000,SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere,SortField).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(10000, MasterSQL, SortField).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);

        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        /// <param name="pwhere">数据过滤条件,设置条件一定要注意SQL语句的拼接,条件前面需要加上AND关键字,e.g:AND 1=1</param>
        public frmSingleForm(int formid, string dalname, string pwhere)
            : base(formid)
        {
            InitializeComponent();
            pWhere = pwhere;
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(MasterSQL).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        /// <param name="pwhere">数据过滤条件,设置条件一定要注意SQL语句的拼接,条件前面需要加上AND关键字,e.g:AND 1=1</param>
        /// <param name="ischeckauth">是否加载权限控制</param>
        public frmSingleForm(int formid, string dalname, string pwhere, bool ischeckauth)
            : base(formid)
        {
            InitializeComponent();
            pWhere = pwhere;
            IsCheckAuth = ischeckauth;
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(MasterSQL).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        public frmSingleForm(int formid, string dalname)
            : base(formid)
        {
            InitializeComponent();
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(MasterSQL).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="formid">窗体ID</param>
        /// <param name="dalname">数据层对象名称</param>
        /// <param name="ischeckauth">是否加载权限控制</param>
        public frmSingleForm(int formid, string dalname, bool ischeckauth)
            : base(formid)
        {
            InitializeComponent();
            IsCheckAuth = ischeckauth;
            MasterDALName = dalname;
            RegisterMethod(dalname, true);
            if (IsCheckAuth)
            {
                dtMain = GetDataSet(SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere).Tables[0];
                //MasterSQL = SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere;
            }
            else
            {
                dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                //MasterSQL = "1=1 " + pWhere;
            }
            //dtMain = GetDataSet(MasterSQL).Tables[0];
            bdsMain.DataSource = dtMain;
            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
        }

        /// <summary>
        /// 列改变-用于同步绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void dtMain_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            e.Row.EndEdit();
        }
        #endregion

        #region 重写基本按钮状态控制
        /// <summary>
        /// 查询
        /// </summary>
        public override void DoView()
        {
            if (MasterFilerSQL != "")
            {
                RegisterMethod(MasterDALName, true);
                if (TopCount != 499 && SortField != "dInputDate DESC")
                {
                    if (IsCheckAuth)
                    {
                        dtMain = GetDataSet(TopCount, SC.GetAuthSQL(ShowType.FormQuery, FormID) + pWhere + MasterFilerSQL, SortField).Tables[0];
                    }
                    else
                    {
                        dtMain = GetDataSet(TopCount, "1=1 " + pWhere + MasterFilerSQL, SortField).Tables[0];
                    }
                    bdsMain.DataSource = dtMain;
                    dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                }
                else
                {
                    if (IsCheckAuth)
                    {
                        dtMain = GetDataSet(SC.GetAuthSQL(ShowType.FormQuery, FormID) + pWhere + MasterFilerSQL).Tables[0];
                    }
                    else
                    {
                        dtMain = GetDataSet("1=1 " + pWhere + MasterFilerSQL).Tables[0];
                    }
                    bdsMain.DataSource = dtMain;
                    dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                }
            }
            if (bdsMain.Current != null)
            {
                base.DoView();
                BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                IsDataChange = false;
            }
            else
            {
                initButtonsState(BWS.ERP.BasePublic.OperateFlag.None);
                BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                IsDataChange = false;
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        public override void DoBaseView()
        {
            if (bdsMain.Current != null)
            {
                base.DoBaseView();
                BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                IsDataChange = false;
            }
            else
            {
                initButtonsState(BWS.ERP.BasePublic.OperateFlag.None);
                BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                IsDataChange = false;
            }
        }

        /// <summary>
        /// 新增之前执行的方法
        /// </summary>
        public override bool DoAppend()
        {
            BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, false);
            bdsMain.AddNew();
            bdsMain.EndEdit();
            ((DataRowView)bdsMain.Current).Row["iFlag"] = 0;
            ((DataRowView)bdsMain.Current).Row["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            IsDataChange = false;
            return base.DoAppend();

        }
        /// <summary>
        /// 取消之前执行的方法
        /// </summary>
        /// <returns></returns>
        public override bool DoBeforeCancel()
        {
            if (bdsMain.Current != null)
            {
                RegisterMethod(MasterDALName, true);
                if (IsDataChange)
                {
                    if (BWS.ERP.BaseControl.Public.SystemInfo("数据尚未保存，是否取消？", 4) == DialogResult.Yes)
                    {
                        if (TopCount != 499 & SortField != "dInputDate DESC")
                        {
                            if (IsCheckAuth)
                            {
                                dtMain = GetDataSet(TopCount, SC.GetAuthSQL(MasterFilerSQL == "" ? ShowType.FormShow : ShowType.FormQuery, FormID) + pWhere, SortField).Tables[0];
                            }
                            else
                            {
                                dtMain = GetDataSet(TopCount, "1=1 " + pWhere, SortField).Tables[0];
                            }
                            bdsMain.DataSource = dtMain;
                            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);

                        }
                        else
                        {
                            if (IsCheckAuth)
                            {
                                dtMain = GetDataSet(SC.GetAuthSQL(MasterFilerSQL == "" ? ShowType.FormShow : ShowType.FormQuery, FormID) + pWhere).Tables[0];
                            }
                            else
                            {
                                dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                            }
                            bdsMain.DataSource = dtMain;
                            dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                        }
                        bdsMain.CancelEdit();
                        BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                        IsDataChange = false;
                        return base.DoBeforeCancel();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (TopCount != 499 & SortField != "dInputDate DESC")
                    {
                        if (IsCheckAuth)
                        {
                            dtMain = GetDataSet(TopCount, SC.GetAuthSQL(MasterFilerSQL == "" ? ShowType.FormShow : ShowType.FormQuery, FormID) + pWhere, SortField).Tables[0];
                        }
                        else
                        {
                            dtMain = GetDataSet(TopCount, "1=1 " + pWhere, SortField).Tables[0];
                        }
                        bdsMain.DataSource = dtMain;
                        dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                    }
                    else
                    {
                        if (IsCheckAuth)
                        {
                            dtMain = GetDataSet(SC.GetAuthSQL(MasterFilerSQL == "" ? ShowType.FormShow : ShowType.FormQuery, FormID) + pWhere).Tables[0];
                        }
                        else
                        {
                            dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                        }
                        bdsMain.DataSource = dtMain;
                        dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                    }
                    bdsMain.CancelEdit();
                    BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                    IsDataChange = false;
                    return base.DoBeforeCancel();
                }
            }
            else
            {
                BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                IsDataChange = false;
                return base.DoBeforeCancel();
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        public override void DoCancel()
        {
            if (bdsMain.Current != null)
            {
                base.DoCancel();
            }
            else
            {
                initButtonsState(BWS.ERP.BasePublic.OperateFlag.None);
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        public override void DoEdit()
        {
            base.DoEdit();
            BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, false);
            IsDataChange = false;
        }
        /// <summary>
        /// 复制
        /// </summary>
        public override void DoCopy()
        {
            base.DoCopy();
            DataRow drTemp = ((DataRowView)bdsMain.Current).Row;
            DoAppend();
            //控制不需要复制的字段
            for (int i = 0; i < drTemp.ItemArray.Length; i++)
            {
                if (!NotCopyFields.Contains(drTemp.Table.Columns[i].ColumnName))
                {
                    ((DataRowView)bdsMain.Current).Row[i] = drTemp[i];
                }
            }
            //((DataRowView)bdsMain.Current).Row["iFlag"] = 0;
            //((DataRowView)bdsMain.Current).Row["sUserID"] = BWS.ERP.Security.SecurityCenter.CurrentUserID;
            bdsMain.EndEdit();
            //BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, false);
            //IsDataChange = false;

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        public override bool DoSave()
        {
            SqlTransaction trans = BWS.ERP.BaseControl.ConnectSetting.SysSqlConnection.BeginTransaction();
            RegisterMethod(MasterDALName, true);
            if (FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsInsert)
            {
                try
                {
                    Add(((DataRowView)bdsMain.Current).Row, trans);
                    trans.Commit();
                    if (TopCount != 499 & SortField != "dInputDate DESC")
                    {
                        if (IsCheckAuth)
                        {
                            dtMain = GetDataSet(TopCount, SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere, SortField).Tables[0];
                        }
                        else
                        {
                            dtMain = GetDataSet(TopCount, "1=1 " + pWhere, SortField).Tables[0];
                        }
                        bdsMain.DataSource = dtMain;
                        dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                    }
                    else
                    {
                        if (IsCheckAuth)
                        {
                            dtMain = GetDataSet(SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere).Tables[0];
                        }
                        else
                        {
                            dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                        }
                        bdsMain.DataSource = dtMain;
                        dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                    }
                    BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                    IsDataChange = false;
                    return base.DoSave();

                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
            else
            {
                try
                {
                    Update(((DataRowView)bdsMain.Current).Row, trans);
                    trans.Commit();
                    if (TopCount != 499 & SortField != "dInputDate DESC")
                    {
                        if (IsCheckAuth)
                        {
                            dtMain = GetDataSet(TopCount, SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere, SortField).Tables[0];
                        }
                        else
                        {
                            dtMain = GetDataSet(TopCount, "1=1 " + pWhere, SortField).Tables[0];
                        }
                        bdsMain.DataSource = dtMain;
                        dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                    }
                    else
                    {
                        if (IsCheckAuth)
                        {
                            dtMain = GetDataSet(SC.GetAuthSQL(ShowType.FormShow, FormID) + pWhere).Tables[0];
                        }
                        else
                        {
                            dtMain = GetDataSet("1=1 " + pWhere).Tables[0];
                        }
                        bdsMain.DataSource = dtMain;
                        dtMain.ColumnChanged += new DataColumnChangeEventHandler(dtMain_ColumnChanged);
                    }
                    BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                    IsDataChange = false;
                    return base.DoSave();
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }
        /// <summary>
        /// 保存前执行的方法
        /// </summary>
        /// <returns></returns>
        public override bool DoBeforeSave()
        {
            //非空验证
            if (NotNullFields.Count > 0)
            {
                if (BWS.ERP.BasePublic.BasePublic.CheckNotNullFields(this.pnlInfo, NotNullFields))
                {
                    BWS.ERP.BasePublic.BasePublic.IsNull = true;
                    return true;
                }
                else
                {
                    BWS.ERP.BasePublic.BasePublic.IsNull = true;
                    return false;
                }
            }
            return true;

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public override bool DoDelete()
        {
            if (BillID > 0)
            {
                if (BWS.ERP.BaseControl.Public.SystemInfo("是否删除该数据？", 1) == DialogResult.OK)
                {
                    SqlTransaction trans = BWS.ERP.BaseControl.ConnectSetting.SysSqlConnection.BeginTransaction();
                    try
                    {
                        RegisterMethod(MasterDALName, true);
                        Delete(BillID, trans);
                        trans.Commit();
                        bdsMain.RemoveCurrent();
                        IsDataChange = false;
                        base.DoDelete();
                        if (bdsMain.Current == null)
                        {
                            initButtonsState(BWS.ERP.BasePublic.OperateFlag.None);
                        }
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 关闭之前执行的方法
        /// </summary>
        /// <returns></returns>
        public override bool DoBeforeClose()
        {
            return base.DoBeforeCancel();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (IsDataChange)
            {
                if (BWS.ERP.BaseControl.Public.SystemInfo("数据尚未保存，是否关闭？", 4) == DialogResult.Yes)
                {
                    BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                    IsDataChange = false;
                    base.OnFormClosing(e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, true);
                IsDataChange = false;
                base.OnFormClosing(e);
            }

        }


        #endregion

        #region 窗体设置
        /// <summary>
        /// 窗体初始化
        /// </summary>
        public override void initBase()
        {
            base.initBase();
            //设置非空字段颜色
            BWS.ERP.BasePublic.BasePublic.SetNotNullFiledsColor(this.pnlInfo, NotNullFields);
            IsDataChange = false;

        }

        private int pnlInfoHeight = 300;
        private void splitterControl1_DoubleClick(object sender, EventArgs e)
        {
            if (pnlInfo.Height != 0)
            {
                pnlInfoHeight = pnlInfo.Height;
                pnlInfo.Height = 0;
                toolTipController1.SetToolTip(splitterControl1, "双击展开窗口");
            }
            else
            {
                pnlInfo.Height = pnlInfoHeight;
                toolTipController1.SetToolTip(splitterControl1, "双击折叠窗口");
            }
        }

        /// <summary>
        /// 设置在按下回车键后控件焦点自动下移
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if ((((DevExpress.XtraEditors.TextBoxMaskBox)(BWS.ERP.BasePublic.BasePublic.GetFocusedControl()))).OwnerEdit.Tag == null || (((DevExpress.XtraEditors.TextBoxMaskBox)(BWS.ERP.BasePublic.BasePublic.GetFocusedControl()))).OwnerEdit.Tag.ToString().ToLower() != "notab")
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
                base.OnKeyDown(e);
            }
            catch (Exception)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{TAB}");
                }
                base.OnKeyDown(e);
            }
            
        }

        #endregion

        #region 注册业务逻辑层数据操作方法
        /// <summary>
        /// 注册数据层数据操作方法
        /// 无ismaster参数表示注册从表
        /// </summary>
        /// <param name="dalname">数据层对象名</param>
        /// <param name="pwhere">条件</param>
        /// <param name="ismaster">是否为主表或单表</param>
        public void RegisterMethod(string dalname, string pwhere, bool ismaster)
        {
            pWhere = pwhere;
            if (ismaster)
            {
                MasterDALName = dalname;
            }
            Type tDAL = Assembly.Load("BWS.ERP.DAL").GetType("BWS.ERP.DAL." + dalname);
            objDAL = Assembly.Load("BWS.ERP.DAL").CreateInstance("BWS.ERP.DAL." + dalname);
            mGetDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(string) });
            mGetTopDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(int), typeof(string), typeof(string) });
            mAddInTrans = tDAL.GetMethod("Add", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mUpdateInTrans = tDAL.GetMethod("Update", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mDeleteInTrans = tDAL.GetMethod("Delete", new Type[] { typeof(int), typeof(SqlTransaction) });
        }

        /// <summary>
        /// 注册数据层数据操作方法
        /// 无ismaster参数表示注册从表
        /// </summary>
        /// <param name="dalname">数据层对象名</param>
        /// <param name="ismaster">是否为主表或单表</param>
        public void RegisterMethod(string dalname, bool ismaster)
        {
            if (ismaster)
            {
                MasterDALName = dalname;
            }
            Type tDAL = Assembly.Load("BWS.ERP.DAL").GetType("BWS.ERP.DAL." + dalname);
            objDAL = Assembly.Load("BWS.ERP.DAL").CreateInstance("BWS.ERP.DAL." + dalname);
            mGetDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(string) });
            mGetTopDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(int), typeof(string), typeof(string) });
            mAddInTrans = tDAL.GetMethod("Add", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mUpdateInTrans = tDAL.GetMethod("Update", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mDeleteInTrans = tDAL.GetMethod("Delete", new Type[] { typeof(int), typeof(SqlTransaction) });
        }

        /// <summary>
        /// 注册数据层数据操作方法
        /// 无ismaster参数表示注册从表
        /// </summary>
        /// <param name="dalname">数据层对象名</param>
        public void RegisterMethod(string dalname)
        {
            Type tDAL = Assembly.Load("BWS.ERP.DAL").GetType("BWS.ERP.DAL." + dalname);
            objDAL = Assembly.Load("BWS.ERP.DAL").CreateInstance("BWS.ERP.DAL." + dalname);
            mGetDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(string) });
            mGetTopDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(int), typeof(string), typeof(string) });
            mAddInTrans = tDAL.GetMethod("Add", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mUpdateInTrans = tDAL.GetMethod("Update", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mDeleteInTrans = tDAL.GetMethod("Delete", new Type[] { typeof(int), typeof(SqlTransaction) });
        }

        /// <summary>
        /// 注册数据层数据操作方法
        /// 无ismaster参数表示注册从表
        /// </summary>
        /// <param name="dalname">数据层对象名</param>
        /// <param name="pwhere">条件</param>
        public void RegisterMethod(string dalname, string pwhere)
        {
            pWhere = pwhere;
            Type tDAL = Assembly.Load("BWS.ERP.DAL").GetType("BWS.ERP.DAL." + dalname);
            objDAL = Assembly.Load("BWS.ERP.DAL").CreateInstance("BWS.ERP.DAL." + dalname);
            mGetDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(string) });
            mGetTopDataSet = tDAL.GetMethod("GetList", new Type[] { typeof(int), typeof(string), typeof(string) });
            mAddInTrans = tDAL.GetMethod("Add", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mUpdateInTrans = tDAL.GetMethod("Update", new Type[] { typeof(DataRow), typeof(SqlTransaction) });
            mDeleteInTrans = tDAL.GetMethod("Delete", new Type[] { typeof(int), typeof(SqlTransaction) });
        }
        #endregion

        #region 数据操作
        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="dr">数据行对象</param>
        /// <param name="trans">SQL事务</param>
        /// <returns></returns>
        public int Add(DataRow dr, SqlTransaction trans)
        {
            try
            {
                object[] obj = { dr, trans };
                return (int)mAddInTrans.Invoke(objDAL, obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="dr">数据行对象</param>
        /// <param name="trans">SQL事务</param>
        /// <returns></returns>
        public int Update(DataRow dr, SqlTransaction trans)
        {
            try
            {
                object[] obj = { dr, trans };
                return Convert.ToInt32(mUpdateInTrans.Invoke(objDAL, obj));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id">单据ID</param>
        /// <param name="trans">SQL事务</param>
        /// <returns></returns>
        public void Delete(int id, SqlTransaction trans)
        {
            try
            {
                object[] obj = { id, trans };
                mDeleteInTrans.Invoke(objDAL, obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="pwhere">条件</param>
        /// <returns></returns>
        public DataSet GetDataSet(string pwhere)
        {
            try
            {
                object[] obj = { pwhere };
                return (DataSet)mGetDataSet.Invoke(objDAL, obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="top">前数据行</param>
        /// <param name="pwhere">条件</param>
        /// <param name="order">排序字段</param>
        /// <returns></returns>
        public DataSet GetDataSet(int top, string pwhere, string order)
        {
            try
            {
                object[] obj = { top, pwhere, order };
                return (DataSet)mGetTopDataSet.Invoke(objDAL, obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 数据状态控制
        /// <summary>
        /// 数据状态控制
        /// 在主从表窗体中一定要重写此方法来控制明细Grid及按钮状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void DataStateChange(object sender, EventArgs e)
        {
            BWS.ERP.BasePublic.BasePublic.SetControlsGridEnable(this.pnlGrid, FormDataFlag == BWS.ERP.BasePublic.DataFlag.dsBrowse);
        }
        private void bdsMain_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bdsMain.Current != null)
            {
                BillID = ((DataRowView)(bdsMain.Current))["ID"].ToString() == "" ? 0 : Convert.ToInt32(((DataRowView)(bdsMain.Current))["ID"]);
                if (IsFirstLoad)
                {
                    if (FormDataFlag != BWS.ERP.BasePublic.DataFlag.dsBrowse)
                    {
                        IsDataChange = true;
                    }
                }
            }
        }

        private void bdsMain_CurrentChanged(object sender, EventArgs e)
        {
            if (bdsMain.Current == null)
            {
                initButtonsState(BWS.ERP.BasePublic.OperateFlag.None);
            }
        }

        #endregion

        #region 属性设置

        /// <summary>
        /// 窗体数据ID(单据ID)
        /// </summary>
        private int _BillID = 0;

        /// <summary>
        /// 窗体数据ID(单据ID)
        /// </summary>
        protected int BillID
        {
            get
            {
                return _BillID;
            }
            set
            {
                _BillID = value;
            }
        }

        private bool _datachange = false;

        /// <summary>
        /// 数据是否变更
        /// </summary>
        protected bool IsDataChange
        {
            get
            {
                return _datachange;
            }
            set
            {
                _datachange = value;
            }
        }

        private string _pwhere = " AND 1=1";

        /// <summary>
        /// 设置数据条件
        /// </summary>
        protected string pWhere
        {
            get
            {
                return _pwhere;
            }
            set
            {
                _pwhere = value;
            }
        }

        private int _top = 499;

        /// <summary>
        /// 设置数据默认显示条数
        /// </summary>
        protected int TopCount
        {
            get
            {
                return _top;
            }
            set
            {
                _top = value;
            }
        }

        private string _sortfield = "dInputDate DESC";

        /// <summary>
        /// 排序字段
        /// </summary>
        protected string SortField
        {
            get
            {
                return _sortfield;
            }
            set
            {
                _sortfield = value;
            }
        }

        private string _dalname;
        /// <summary>
        /// 主表数据层对象名称
        /// </summary>
        protected string MasterDALName
        {
            get
            {
                return _dalname;
            }
            set
            {
                _dalname = value;
            }
        }
        private bool _ischeckauth = true;

        /// <summary>
        /// 设置窗体是否需要进行权限验证
        /// </summary>
        protected bool IsCheckAuth
        {
            get
            {
                return _ischeckauth;
            }
            set
            {
                _ischeckauth = value;
            }
        }

        private string _MasterSql = "";
        /// <summary>
        /// 窗体主表数据SQL
        /// </summary>
        protected string MasterSQL
        {
            get
            {
                return _MasterSql;
            }
            set
            {
                _MasterSql = value;
            }
        }

        private string _MasterFilterSql = "";
        /// <summary>
        /// 窗体主表数据查询过滤SQL
        /// </summary>
        protected string MasterFilerSQL
        {
            get
            {
                return _MasterFilterSql;
            }
            set
            {
                _MasterFilterSql = value;
            }
        }
        #endregion             

        #region 按钮操作权限检测

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Add, FormID))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("您没有新增权限!");
                return;
            }
            base.btnAdd_Click(sender, e);
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            string sUserID = bdsMain.Current == null ? "" : ((DataRowView)bdsMain.Current)["sUserID"].ToString();
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.View, FormID, sUserID))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("您没有查询权限!");
                return;
            }
            base.btnView_Click(sender, e);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Edit, FormID, ((DataRowView)bdsMain.Current)["sUserID"].ToString()))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("您没有修改权限!");
                return;
            }
            if (((DataRowView)bdsMain.Current)["iFlag"].ToString()=="4")
            {
                BWS.ERP.BaseControl.Public.SystemInfo("审核完成的单据不能够修改!");
                return;
            }
            base.btnEdit_Click(sender, e);
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Delete, FormID, ((DataRowView)bdsMain.Current)["sUserID"].ToString()))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("您没有删除权限!");
                return;
            }
            if (((DataRowView)bdsMain.Current)["iFlag"].ToString() == "4")
            {
                BWS.ERP.BaseControl.Public.SystemInfo("审核完成的单据不能够删除!");
                return;
            }
            base.btnDelete_Click(sender, e);
        }

        public override void btnPrint_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Print, FormID, ((DataRowView)bdsMain.Current)["sUserID"].ToString()))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("您没有打印权限!");
                return;
            }
            base.btnPrint_Click(sender, e);
        }
        #endregion

    }
}
