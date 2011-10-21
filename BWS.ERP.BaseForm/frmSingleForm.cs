//***************************************************************************************//
//��Ŀ���ƣ�BWS ERP System Platform
//ģ�����ƣ�frmSingleForm
//ģ�����ϵͳ��������
//ģ��˵�������������壬������ֻ����һ�����ݱ�Ĵ���
//�����ˣ�Belself.Wang
//����ʱ�䣺2010-7-14
//��ע��
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
    /// ����������
    /// </summary>
    public partial class frmSingleForm : frmBaseForm
    {
        #region ����
        /// <summary>
        /// ���ݲ��������
        /// </summary>
        private object objDAL;
        private MethodInfo mGetDataSet;
        private MethodInfo mGetTopDataSet;
        private MethodInfo mAddInTrans;
        private MethodInfo mUpdateInTrans;
        private MethodInfo mDeleteInTrans;

        /// <summary>
        /// ��������
        /// </summary>
        protected DataTable dtMain;


        /// <summary>
        /// ��������б�
        /// </summary>
        protected Hashtable FormParaList = new Hashtable();

        /// <summary>
        /// Ȩ�޴�����
        /// </summary>
        protected BWS.ERP.Security.SecurityCenter SC = new BWS.ERP.Security.SecurityCenter();

        #endregion

        #region ���캯��
        /// <summary>
        /// ���캯��
        /// </summary>
        public frmSingleForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
        /// <param name="pwhere">���ݹ�������,��������һ��Ҫע��SQL����ƴ��,����ǰ����Ҫ����AND�ؼ���,e.g:AND 1=1</param>
        /// <param name="top">ǰ����������</param>
        /// <param name="sortfield">�����ֶ�</param>
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
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
        /// <param name="pwhere">���ݹ�������,��������һ��Ҫע��SQL����ƴ��,����ǰ����Ҫ����AND�ؼ���,e.g:AND 1=1</param>
        /// <param name="top">ǰ����������</param>
        /// <param name="sortfield">�����ֶ�</param>
        /// <param name="ischeckauth">�Ƿ����Ȩ�޿���</param>
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
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
        /// <param name="pwhere">���ݹ�������,��������һ��Ҫע��SQL����ƴ��,����ǰ����Ҫ����AND�ؼ���,e.g:AND 1=1</param>
        /// <param name="sortfield">�����ֶ�</param>
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
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
        /// <param name="pwhere">���ݹ�������,��������һ��Ҫע��SQL����ƴ��,����ǰ����Ҫ����AND�ؼ���,e.g:AND 1=1</param>
        /// <param name="sortfield">�����ֶ�</param>
        /// <param name="ischeckauth">�Ƿ����Ȩ�޿���</param>
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
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
        /// <param name="pwhere">���ݹ�������,��������һ��Ҫע��SQL����ƴ��,����ǰ����Ҫ����AND�ؼ���,e.g:AND 1=1</param>
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
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
        /// <param name="pwhere">���ݹ�������,��������һ��Ҫע��SQL����ƴ��,����ǰ����Ҫ����AND�ؼ���,e.g:AND 1=1</param>
        /// <param name="ischeckauth">�Ƿ����Ȩ�޿���</param>
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
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
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
        /// ���캯��
        /// </summary>
        /// <param name="formid">����ID</param>
        /// <param name="dalname">���ݲ��������</param>
        /// <param name="ischeckauth">�Ƿ����Ȩ�޿���</param>
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
        /// �иı�-����ͬ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void dtMain_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            e.Row.EndEdit();
        }
        #endregion

        #region ��д������ť״̬����
        /// <summary>
        /// ��ѯ
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
        /// ��ѯ
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
        /// ����֮ǰִ�еķ���
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
        /// ȡ��֮ǰִ�еķ���
        /// </summary>
        /// <returns></returns>
        public override bool DoBeforeCancel()
        {
            if (bdsMain.Current != null)
            {
                RegisterMethod(MasterDALName, true);
                if (IsDataChange)
                {
                    if (BWS.ERP.BaseControl.Public.SystemInfo("������δ���棬�Ƿ�ȡ����", 4) == DialogResult.Yes)
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
        /// ȡ��
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
        /// �༭
        /// </summary>
        public override void DoEdit()
        {
            base.DoEdit();
            BWS.ERP.BasePublic.BasePublic.SetAllControlsReadOnly(this.pnlInfo, false);
            IsDataChange = false;
        }
        /// <summary>
        /// ����
        /// </summary>
        public override void DoCopy()
        {
            base.DoCopy();
            DataRow drTemp = ((DataRowView)bdsMain.Current).Row;
            DoAppend();
            //���Ʋ���Ҫ���Ƶ��ֶ�
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
        /// ����
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
        /// ����ǰִ�еķ���
        /// </summary>
        /// <returns></returns>
        public override bool DoBeforeSave()
        {
            //�ǿ���֤
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
        /// ɾ��
        /// </summary>
        /// <returns></returns>
        public override bool DoDelete()
        {
            if (BillID > 0)
            {
                if (BWS.ERP.BaseControl.Public.SystemInfo("�Ƿ�ɾ�������ݣ�", 1) == DialogResult.OK)
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
        /// �ر�֮ǰִ�еķ���
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
                if (BWS.ERP.BaseControl.Public.SystemInfo("������δ���棬�Ƿ�رգ�", 4) == DialogResult.Yes)
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

        #region ��������
        /// <summary>
        /// �����ʼ��
        /// </summary>
        public override void initBase()
        {
            base.initBase();
            //���÷ǿ��ֶ���ɫ
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
                toolTipController1.SetToolTip(splitterControl1, "˫��չ������");
            }
            else
            {
                pnlInfo.Height = pnlInfoHeight;
                toolTipController1.SetToolTip(splitterControl1, "˫���۵�����");
            }
        }

        /// <summary>
        /// �����ڰ��»س�����ؼ������Զ�����
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

        #region ע��ҵ���߼������ݲ�������
        /// <summary>
        /// ע�����ݲ����ݲ�������
        /// ��ismaster������ʾע��ӱ�
        /// </summary>
        /// <param name="dalname">���ݲ������</param>
        /// <param name="pwhere">����</param>
        /// <param name="ismaster">�Ƿ�Ϊ����򵥱�</param>
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
        /// ע�����ݲ����ݲ�������
        /// ��ismaster������ʾע��ӱ�
        /// </summary>
        /// <param name="dalname">���ݲ������</param>
        /// <param name="ismaster">�Ƿ�Ϊ����򵥱�</param>
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
        /// ע�����ݲ����ݲ�������
        /// ��ismaster������ʾע��ӱ�
        /// </summary>
        /// <param name="dalname">���ݲ������</param>
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
        /// ע�����ݲ����ݲ�������
        /// ��ismaster������ʾע��ӱ�
        /// </summary>
        /// <param name="dalname">���ݲ������</param>
        /// <param name="pwhere">����</param>
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

        #region ���ݲ���
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="dr">�����ж���</param>
        /// <param name="trans">SQL����</param>
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
        /// ��������
        /// </summary>
        /// <param name="dr">�����ж���</param>
        /// <param name="trans">SQL����</param>
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
        /// ɾ������
        /// </summary>
        /// <param name="id">����ID</param>
        /// <param name="trans">SQL����</param>
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
        /// ��ȡ���ݼ�
        /// </summary>
        /// <param name="pwhere">����</param>
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
        /// ��ȡ���ݼ�
        /// </summary>
        /// <param name="top">ǰ������</param>
        /// <param name="pwhere">����</param>
        /// <param name="order">�����ֶ�</param>
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

        #region ����״̬����
        /// <summary>
        /// ����״̬����
        /// �����ӱ�����һ��Ҫ��д�˷�����������ϸGrid����ť״̬
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

        #region ��������

        /// <summary>
        /// ��������ID(����ID)
        /// </summary>
        private int _BillID = 0;

        /// <summary>
        /// ��������ID(����ID)
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
        /// �����Ƿ���
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
        /// ������������
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
        /// ��������Ĭ����ʾ����
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
        /// �����ֶ�
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
        /// �������ݲ��������
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
        /// ���ô����Ƿ���Ҫ����Ȩ����֤
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
        /// ������������SQL
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
        /// �����������ݲ�ѯ����SQL
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

        #region ��ť����Ȩ�޼��

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Add, FormID))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("��û������Ȩ��!");
                return;
            }
            base.btnAdd_Click(sender, e);
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            string sUserID = bdsMain.Current == null ? "" : ((DataRowView)bdsMain.Current)["sUserID"].ToString();
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.View, FormID, sUserID))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("��û�в�ѯȨ��!");
                return;
            }
            base.btnView_Click(sender, e);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Edit, FormID, ((DataRowView)bdsMain.Current)["sUserID"].ToString()))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("��û���޸�Ȩ��!");
                return;
            }
            if (((DataRowView)bdsMain.Current)["iFlag"].ToString()=="4")
            {
                BWS.ERP.BaseControl.Public.SystemInfo("�����ɵĵ��ݲ��ܹ��޸�!");
                return;
            }
            base.btnEdit_Click(sender, e);
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Delete, FormID, ((DataRowView)bdsMain.Current)["sUserID"].ToString()))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("��û��ɾ��Ȩ��!");
                return;
            }
            if (((DataRowView)bdsMain.Current)["iFlag"].ToString() == "4")
            {
                BWS.ERP.BaseControl.Public.SystemInfo("�����ɵĵ��ݲ��ܹ�ɾ��!");
                return;
            }
            base.btnDelete_Click(sender, e);
        }

        public override void btnPrint_Click(object sender, EventArgs e)
        {
            if (IsCheckAuth && !SC.CheckAuth(SecurityOperation.Print, FormID, ((DataRowView)bdsMain.Current)["sUserID"].ToString()))
            {
                BWS.ERP.BaseControl.Public.SystemInfo("��û�д�ӡȨ��!");
                return;
            }
            base.btnPrint_Click(sender, e);
        }
        #endregion

    }
}
