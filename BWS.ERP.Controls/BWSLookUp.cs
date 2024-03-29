﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BWS.ERP.Controls
{
    public partial class BWSLookUp : DevExpress.XtraEditors.XtraUserControl
    {
        private string _searchsql;
        private string _griddisplayname;
        private string _griddisplayfield;
        private string _displayfield;
        private string _valuefield;
        private string _searchformtext;
        private bool _ismulti=false;
        private DataTable _dt;
        private bool _isedit = false;
        private string _editformname;
        private string _editformfilter;
        private int _editformid = 0;
        private string _searchformfilter = "";


        private List<Control> LAutoSetControl = new List<Control>();
        private List<string> LAutoSetFields = new List<string>();
        private List<string> LAutoSetValueFields = new List<string>();

        private DevExpress.XtraGrid.Views.Grid.GridView gvTemp;

        public BWSLookUp()
        {
            InitializeComponent();
            
        }

        #region 属性

        [Category("LookUp设置"), Description("是否多选"), DefaultValue(false)]
        public bool IsMultiSelect
        {
            get
            {
                return _ismulti;
            }
            set
            {
                _ismulti = value;
            }
        }
        [Category("LookUp设置"), Description("设置绑定字段"), Bindable(true)]
        public string EditValue
        {
            get
            {
                return txtValueText.Text;
            }
            set
            {
                txtValueText.Text = value;
            }
        }

        [Category("LookUp设置"), Description("设置返回字段")]
        public string DataField
        {
            get
            {
                return _valuefield;
            }
            set
            {
                _valuefield = value;
            }
        }

        [Category("LookUp设置"), Description("设置LookUp显示字段")]
        public string DisplayField
        {
            get
            {
                return _displayfield;
            }
            set
            {
                _displayfield = value;
            }
        }

        [Category("LookUp设置"), Description("设置Grid显示字段,用\",\"间隔")]
        public string GridDisplayField
        {
            get
            {
                return _griddisplayfield;
            }
            set
            {
                _griddisplayfield = value;
            }
        }

        [Category("LookUp设置"), Description("设置查询SQL")]
        public string SQL
        {
            get
            {
                return _searchsql;
            }
            set
            {
                _searchsql = value;
            }
        }

        [Category("LookUp设置"), Description("设置GRID列显示名称,用\",\"间隔")]
        public string GridColumnText
        {
            get
            {
                return _griddisplayname;
            }
            set
            {
                _griddisplayname = value;
            }
        }
        [Category("LookUp设置"), Description("设置控件是否只读(可用)"),DefaultValue(true)]
        public bool IsReadOnly
        {
            get
            {
                return txtDisplayText.Properties.Buttons[0].Enabled;
            }
            set
            {
                txtDisplayText.Properties.Buttons[0].Enabled = value;
            }
        }

        [Category("LookUp设置"), Description("设置选择窗体Text")]
        public string SearchFormText
        {
            get
            {
                if (_searchformtext == null)
                {
                    _searchformtext = "";
                }
                return _searchformtext;
            }
            set
            {
                _searchformtext= value;
            }
        }
        /// <summary>
        /// 返回的查询数据结果
        /// </summary>
        [Category("LookUp设置"), Description("返回查询的结果")]
        public DataTable ReturnData
        {
            get
            {
                if (_dt != null && _dt.Rows.Count > 0)
                {
                    return _dt;
                }
                else
                {
                    return new DataTable();
                }
            }
        }
        /// <summary>
        /// 是否允许编辑查询结果
        /// </summary>
        [Category("LookUp设置"), Description("设置是否允许编辑查询结果"), DefaultValue(false)]
        public bool IsSearchFormEdit
        {
            get
            {
                return _isedit;
            }
            set
            {
                _isedit = value;
            }
        }

        /// <summary>
        /// 编辑弹出窗体名称
        /// </summary>
        [Category("LookUp设置"), Description("设置编辑弹出窗体名称(包括完整的命名空间)，例如：BWS.ERP.Module.SystemBase.frmbasDataDict")]
        public string EditFormName
        {
            get
            {
                return _editformname;
            }
            set
            {
                _editformname = value;
            }
        }
        /// <summary>
        /// 编辑弹出窗体数据条件
        /// </summary>
        [Category("LookUp设置"), Description("设置编辑弹出窗体数据条件，例如数据字典：sDictCategoryNo=1001")]
        public string EditFormFilter
        {
            get
            {
                return _editformfilter;
            }
            set
            {
                _editformfilter = value;
            }
        }

        /// <summary>
        /// 查询窗体数据条件
        /// </summary>
        [Category("LookUp设置"), Description("设置查询窗体数据条件，例如数据字典：sDictCategoryNo=1001")]
        public string SearchFormFilter
        {
            get
            {
                return _searchformfilter;
            }
            set
            {
                _searchformfilter = value;
            }
        }

        /// <summary>
        /// 编辑弹出窗体ID
        /// </summary>
        [Category("LookUp设置"), Description("设置编辑弹出窗体ID件，确保正确")]
        public int EditFormID
        {
            get
            {
                return _editformid;
            }
            set
            {
                _editformid = value;
            }
        }

        public Font TextFont
        {
            get
            {
                return txtDisplayText.Font;
            }
            set
            {
                txtDisplayText.Font = value;
            }
        }
        #endregion

        /// <summary>
        /// LookUp查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LookUpSelfClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string sql = "";
                //检测SQL设置
                if (SQL == null || SQL == "")
                {
                    BWS.ERP.BaseControl.Public.SystemInfo("LookUp尚未设置SQL属性！", true);
                    return;
                }
                if (IsSearchFormEdit)
                {
                    if (EditFormName == null || EditFormName == "")
                    {
                        BWS.ERP.BaseControl.Public.SystemInfo("LookUp尚未设置EditFormName属性！", true);
                        return;
                    }
                    if (EditFormID == 0)
                    {
                        BWS.ERP.BaseControl.Public.SystemInfo("LookUp尚未设置EditFormID属性！", true);
                        return;
                    }

                }
                if (LookUpBeforePost != null)
                {
                    if (!LookUpBeforePost(sender, e))
                    {
                        return;
                    }
                }
                if (SearchFormFilter != "" && SearchFormFilter != null)
                {
                    sql = "SELECT A.* FROM (" + SQL + ") A WHERE " + SearchFormFilter;
                }
                else
                {
                    sql = SQL;
                }
                frmLookUpSearch frm = new frmLookUpSearch(sql, GridColumnText, GridDisplayField, SearchFormText, IsMultiSelect, IsSearchFormEdit, EditFormName, EditFormFilter, EditFormID);
                if (IsMultiSelect)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (frm.ReturnData != null)
                        {
                            if (frm.ReturnData.Rows.Count > 0)
                            {
                                //选择的结果
                                _dt = frm.ReturnData;
                                if (LookUpAfterPost != null)
                                {
                                    if (!LookUpAfterPost(sender, e))
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (frm.ReturnData != null)
                        {
                            if (frm.ReturnData.Rows.Count == 1)
                            {
                                //选择的结果
                                _dt = frm.ReturnData;
                                txtDisplayText.Focus();
                                txtValueText.Text = _dt.Rows[0][DataField].ToString();
                                //for (int i = 0; i < LAutoSetControl.ToArray().Length; i++)
                                //{
                                //    LAutoSetControl[i].Focus();
                                //    LAutoSetControl[i].Text = _dt.Rows[0][LAutoSetValueFields[i]].ToString();
                                //}
                                //for (int i = 0; i < LAutoSetFields.ToArray().Length; i++)
                                //{
                                //    gvTemp.Focus();
                                //    if (this.DataBindings[0].DataSource is System.Windows.Forms.BindingSource)
                                //    {
                                //        //先要设置控件绑定的值,在设置自动赋值的字段
                                //        ((System.Data.DataTable)(((System.Windows.Forms.BindingSource)(this.DataBindings[0].DataSource)).DataSource)).Rows[gvTemp.GetFocusedDataSourceRowIndex()][this.DataBindings[0].BindingMemberInfo.BindingField] = EditValue;
                                //        ((System.Data.DataTable)(((System.Windows.Forms.BindingSource)(this.DataBindings[0].DataSource)).DataSource)).Rows[gvTemp.GetFocusedDataSourceRowIndex()][LAutoSetFields[i]] = _dt.Rows[0][LAutoSetValueFields[i]];
                                //        //((System.Windows.Forms.BindingSource)(this.DataBindings[0].DataSource)).EndEdit();
                                //    }
                                //    else
                                //    {
                                //        ((DataSet)(this.DataBindings[0].DataSource)).Tables[0].Rows[gvTemp.GetFocusedDataSourceRowIndex()][this.DataBindings[0].BindingMemberInfo.BindingField] = EditValue;
                                //        ((DataSet)(this.DataBindings[0].DataSource)).Tables[0].Rows[gvTemp.GetFocusedDataSourceRowIndex()][LAutoSetFields[i]] = _dt.Rows[0][LAutoSetValueFields[i]];
                                //    }
                                //}
                                if (LookUpAfterPost != null)
                                {
                                    if (!LookUpAfterPost(sender, e))
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void txtValueText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDisplayText.Text = "";
                string sSql = "";
                //if (EditValue != "" && EditValue!="0")
                if (EditValue != "")
                {
                    //sSql = "SELECT A." + DisplayField + " FROM (" + SQL + ") A WHERE " + DataField + "='" + EditValue + "'";
                    //sSql = "SELECT A.*" + " FROM (" + SQL + ") A WHERE " + DataField + "='" + EditValue + "'";
                    if (SearchFormFilter != "" && SearchFormFilter != null)
                    {
                        sSql = "SELECT A.* FROM (" + SQL + ") A WHERE " + SearchFormFilter;
                    }
                    else
                    {
                        sSql = SQL;
                    }
                    //DataTable dt = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0];
                    DataRow[] dr = BWS.ERP.DataAccess.DbHelperSQL.Query(sSql).Tables[0].Select(DataField + "='" + EditValue + "'");
                    //if (dt.Rows.Count > 0)
                    if (dr.Length > 0)
                    {
                        //txtDisplayText.Text = dt.Rows[0][DisplayField].ToString();
                        txtDisplayText.Text = dr[0][DisplayField].ToString();
                        for (int i = 0; i < LAutoSetControl.ToArray().Length; i++)
                        {
                            LAutoSetControl[i].Focus();
                            LAutoSetControl[i].Text = _dt.Rows[0][LAutoSetValueFields[i]].ToString();
                        }
                        for (int i = 0; i < LAutoSetFields.ToArray().Length; i++)
                        {
                            gvTemp.Focus();
                            if (this.DataBindings[0].DataSource is System.Windows.Forms.BindingSource)
                            {
                                //先要设置控件绑定的值,在设置自动赋值的字段
                                ((DataTable)(((System.Windows.Forms.BindingSource)(this.DataBindings[0].DataSource)).DataSource)).Rows[gvTemp.GetFocusedDataSourceRowIndex()][this.DataBindings[0].BindingMemberInfo.BindingField] = EditValue;
                                ((DataTable)(((System.Windows.Forms.BindingSource)(this.DataBindings[0].DataSource)).DataSource)).Rows[gvTemp.GetFocusedDataSourceRowIndex()][LAutoSetFields[i]] = dr[0][LAutoSetValueFields[i]];
                                //((System.Windows.Forms.BindingSource)(this.DataBindings[0].DataSource)).EndEdit();
                            }
                            else
                            {
                                ((DataSet)(this.DataBindings[0].DataSource)).Tables[0].Rows[gvTemp.GetFocusedDataSourceRowIndex()][this.DataBindings[0].BindingMemberInfo.BindingField] = EditValue;
                                ((DataSet)(this.DataBindings[0].DataSource)).Tables[0].Rows[gvTemp.GetFocusedDataSourceRowIndex()][LAutoSetFields[i]] = dr[0][LAutoSetValueFields[i]];
                                ((DataSet)(this.DataBindings[0].DataSource)).Tables[0].AcceptChanges();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 查询后自动设置相应数据值-用于主表自动赋值，目前只支持赋值控件的Text属性
        /// </summary>
        /// <param name="ctl">控件名</param>
        /// <param name="valuefield">返回结果中的字段名</param>
        public void AutoSetValue(Control ctl, string valuefield)
        {
            LAutoSetControl.Add(ctl);
            LAutoSetValueFields.Add(valuefield);
        }

        /// <summary>
        /// 查询后自动设置相应数据值-用于Grid中自动赋值
        /// </summary>
        /// <param name="gv">GridView控件</param>
        /// <param name="field">GridView中要赋值的字段</param>
        /// <param name="valuefield">返回结果中的字段名</param>
        public void AutoSetValue(ref DevExpress.XtraGrid.Views.Grid.GridView gv, string field, string valuefield)
        {
            gvTemp = gv;
            LAutoSetFields.Add(field);
            LAutoSetValueFields.Add(valuefield);
        }

        private void BWSLookUp_Load(object sender, EventArgs e)
        {
            txtValueText.Text = EditValue;
        }

        private void BWSLookUp_SizeChanged(object sender, EventArgs e)
        {
            //this.Height = txtDisplayText.Height;
        }

        public delegate bool BWSLookUpEvent(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e);

        /// <summary>
        /// 单击LookUp查询前执行事件
        /// </summary>
        [Category("事件"), Description("单击LookUp查询前执行事件")]
        public event BWSLookUpEvent LookUpBeforePost;

        /// <summary>
        /// 单击LookUp查询后执行事件
        /// </summary>
        [Category("事件"), Description("单击LookUp查询后执行事件")]
        public event BWSLookUpEvent LookUpAfterPost;

        private void txtDisplayText_Click(object sender, EventArgs e)
        {
            if (txtDisplayText.Properties.Buttons[0].Enabled)
            {
                LookUpSelfClick(sender, null);
            }
        }



    }
}
