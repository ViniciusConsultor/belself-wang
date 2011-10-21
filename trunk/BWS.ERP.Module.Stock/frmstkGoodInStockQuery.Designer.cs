﻿namespace BWS.ERP.Module.Stock
{
    partial class frmstkGoodInStockQuery
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.detInDateE = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.detInDateS = new DevExpress.XtraEditors.DateEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.txtsTradeBillNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsSupplier = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtsStockInNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcMain = new BWS.ERP.Controls.BWSGridControl();
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsFlagName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsStockInNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldStockInDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsStockInTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsSupplierCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsBussinessManName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsGoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsGoodCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsGoodEName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsUnitCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.colsRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateE.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateS.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsTradeBillNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsStockInNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.splitterControl1);
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Size = new System.Drawing.Size(694, 498);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(690, 133);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.detInDateE);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.detInDateS);
            this.xtraTabPage1.Controls.Add(this.btnClose);
            this.xtraTabPage1.Controls.Add(this.btnClear);
            this.xtraTabPage1.Controls.Add(this.btnQuery);
            this.xtraTabPage1.Controls.Add(this.txtsTradeBillNo);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtsSupplier);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtsStockInNo);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(683, 104);
            this.xtraTabPage1.Text = "查询条件";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(231, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(12, 14);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "到";
            // 
            // detInDateE
            // 
            this.detInDateE.EditValue = null;
            this.detInDateE.Location = new System.Drawing.Point(258, 46);
            this.detInDateE.Name = "detInDateE";
            this.detInDateE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detInDateE.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detInDateE.Size = new System.Drawing.Size(118, 21);
            this.detInDateE.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "入库日期从";
            // 
            // detInDateS
            // 
            this.detInDateS.EditValue = null;
            this.detInDateS.Location = new System.Drawing.Point(86, 46);
            this.detInDateS.Name = "detInDateS";
            this.detInDateS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detInDateS.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detInDateS.Size = new System.Drawing.Size(118, 21);
            this.detInDateS.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::BWS.ERP.Module.Stock.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(580, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = global::BWS.ERP.Module.Stock.Properties.Resources.delete;
            this.btnClear.Location = new System.Drawing.Point(580, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除(&C)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Image = global::BWS.ERP.Module.Stock.Properties.Resources.view;
            this.btnQuery.Location = new System.Drawing.Point(580, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&S)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtsTradeBillNo
            // 
            this.txtsTradeBillNo.Location = new System.Drawing.Point(445, 12);
            this.txtsTradeBillNo.Name = "txtsTradeBillNo";
            this.txtsTradeBillNo.Size = new System.Drawing.Size(118, 21);
            this.txtsTradeBillNo.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(394, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "送货单号";
            // 
            // txtsSupplier
            // 
            this.txtsSupplier.Location = new System.Drawing.Point(258, 12);
            this.txtsSupplier.Name = "txtsSupplier";
            this.txtsSupplier.Size = new System.Drawing.Size(118, 21);
            this.txtsSupplier.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(219, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "供应商";
            // 
            // txtsStockInNo
            // 
            this.txtsStockInNo.Location = new System.Drawing.Point(86, 12);
            this.txtsStockInNo.Name = "txtsStockInNo";
            this.txtsStockInNo.Size = new System.Drawing.Size(118, 21);
            this.txtsStockInNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "入库单号";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcMain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 141);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(690, 355);
            this.panelControl2.TabIndex = 2;
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(2, 2);
            this.gcMain.MainView = this.gvMain;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(686, 351);
            this.gcMain.TabIndex = 0;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsFlagName,
            this.colsStockInNo,
            this.coldStockInDate,
            this.colsStockInTypeName,
            this.colsSupplierCName,
            this.colsBussinessManName,
            this.colsGoodID,
            this.colsSpec,
            this.colsGoodCName,
            this.colsGoodEName,
            this.colsUnitCName,
            this.colfSalePrice,
            this.colfQuantity,
            this.colfAmount,
            this.colsRemark});
            this.gvMain.GridControl = this.gcMain;
            this.gvMain.Name = "gvMain";
            this.gvMain.OptionsBehavior.Editable = false;
            this.gvMain.OptionsView.ColumnAutoWidth = false;
            this.gvMain.OptionsView.ShowFooter = true;
            // 
            // colsFlagName
            // 
            this.colsFlagName.Caption = "审核状态";
            this.colsFlagName.FieldName = "sFlagName";
            this.colsFlagName.Name = "colsFlagName";
            this.colsFlagName.Visible = true;
            this.colsFlagName.VisibleIndex = 0;
            this.colsFlagName.Width = 100;
            // 
            // colsStockInNo
            // 
            this.colsStockInNo.Caption = "入库单号";
            this.colsStockInNo.FieldName = "sStockInNo";
            this.colsStockInNo.Name = "colsStockInNo";
            this.colsStockInNo.Visible = true;
            this.colsStockInNo.VisibleIndex = 1;
            this.colsStockInNo.Width = 100;
            // 
            // coldStockInDate
            // 
            this.coldStockInDate.Caption = "入库日期";
            this.coldStockInDate.FieldName = "dStockInDate";
            this.coldStockInDate.Name = "coldStockInDate";
            this.coldStockInDate.Visible = true;
            this.coldStockInDate.VisibleIndex = 2;
            this.coldStockInDate.Width = 100;
            // 
            // colsStockInTypeName
            // 
            this.colsStockInTypeName.Caption = "入库类型";
            this.colsStockInTypeName.FieldName = "sStockInTypeName";
            this.colsStockInTypeName.Name = "colsStockInTypeName";
            this.colsStockInTypeName.Visible = true;
            this.colsStockInTypeName.VisibleIndex = 3;
            this.colsStockInTypeName.Width = 100;
            // 
            // colsSupplierCName
            // 
            this.colsSupplierCName.Caption = "供应商名称";
            this.colsSupplierCName.FieldName = "sSupplierCName";
            this.colsSupplierCName.Name = "colsSupplierCName";
            this.colsSupplierCName.Visible = true;
            this.colsSupplierCName.VisibleIndex = 4;
            this.colsSupplierCName.Width = 109;
            // 
            // colsBussinessManName
            // 
            this.colsBussinessManName.Caption = "入库员";
            this.colsBussinessManName.FieldName = "sBussinessManName";
            this.colsBussinessManName.Name = "colsBussinessManName";
            this.colsBussinessManName.Visible = true;
            this.colsBussinessManName.VisibleIndex = 5;
            this.colsBussinessManName.Width = 100;
            // 
            // colsGoodID
            // 
            this.colsGoodID.Caption = "商品编号";
            this.colsGoodID.FieldName = "sGoodID";
            this.colsGoodID.Name = "colsGoodID";
            this.colsGoodID.Visible = true;
            this.colsGoodID.VisibleIndex = 6;
            this.colsGoodID.Width = 100;
            // 
            // colsSpec
            // 
            this.colsSpec.Caption = "规格";
            this.colsSpec.FieldName = "sSpec";
            this.colsSpec.Name = "colsSpec";
            this.colsSpec.Visible = true;
            this.colsSpec.VisibleIndex = 7;
            this.colsSpec.Width = 100;
            // 
            // colsGoodCName
            // 
            this.colsGoodCName.Caption = "商品名称";
            this.colsGoodCName.FieldName = "sGoodCName";
            this.colsGoodCName.Name = "colsGoodCName";
            this.colsGoodCName.Visible = true;
            this.colsGoodCName.VisibleIndex = 8;
            this.colsGoodCName.Width = 100;
            // 
            // colsGoodEName
            // 
            this.colsGoodEName.Caption = "商品英文名";
            this.colsGoodEName.FieldName = "sGoodEName";
            this.colsGoodEName.Name = "colsGoodEName";
            this.colsGoodEName.Visible = true;
            this.colsGoodEName.VisibleIndex = 9;
            this.colsGoodEName.Width = 100;
            // 
            // colsUnitCName
            // 
            this.colsUnitCName.Caption = "单位";
            this.colsUnitCName.FieldName = "sUnitCName";
            this.colsUnitCName.Name = "colsUnitCName";
            this.colsUnitCName.Visible = true;
            this.colsUnitCName.VisibleIndex = 10;
            this.colsUnitCName.Width = 100;
            // 
            // colfSalePrice
            // 
            this.colfSalePrice.Caption = "销售价";
            this.colfSalePrice.FieldName = "fSalePrice";
            this.colfSalePrice.Name = "colfSalePrice";
            this.colfSalePrice.Visible = true;
            this.colfSalePrice.VisibleIndex = 11;
            this.colfSalePrice.Width = 100;
            // 
            // colfQuantity
            // 
            this.colfQuantity.Caption = "入库数量";
            this.colfQuantity.FieldName = "fQuantity";
            this.colfQuantity.Name = "colfQuantity";
            this.colfQuantity.SummaryItem.DisplayFormat = "{0:n2}";
            this.colfQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfQuantity.Visible = true;
            this.colfQuantity.VisibleIndex = 12;
            this.colfQuantity.Width = 100;
            // 
            // colfAmount
            // 
            this.colfAmount.Caption = "金额";
            this.colfAmount.DisplayFormat.FormatString = "{0:n2}";
            this.colfAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colfAmount.FieldName = "fAmount";
            this.colfAmount.Name = "colfAmount";
            this.colfAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colfAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfAmount.Visible = true;
            this.colfAmount.VisibleIndex = 13;
            this.colfAmount.Width = 100;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(2, 135);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(690, 6);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // colsRemark
            // 
            this.colsRemark.Caption = "备注";
            this.colsRemark.FieldName = "sRemark";
            this.colsRemark.Name = "colsRemark";
            this.colsRemark.Visible = true;
            this.colsRemark.VisibleIndex = 14;
            this.colsRemark.Width = 120;
            // 
            // frmstkGoodInStockQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(694, 498);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmstkGoodInStockQuery";
            this.Text = "商品入库查询";
            this.Load += new System.EventHandler(this.frmstkGoodInStockQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateE.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateS.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detInDateS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsTradeBillNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsStockInNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BWS.ERP.Controls.BWSGridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.TextEdit txtsSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtsStockInNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit detInDateE;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit detInDateS;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit txtsTradeBillNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colsStockInNo;
        private DevExpress.XtraGrid.Columns.GridColumn coldStockInDate;
        private DevExpress.XtraGrid.Columns.GridColumn colsStockInTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colsSupplierCName;
        private DevExpress.XtraGrid.Columns.GridColumn colsBussinessManName;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodID;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodCName;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodEName;
        private DevExpress.XtraGrid.Columns.GridColumn colsUnitCName;
        private DevExpress.XtraGrid.Columns.GridColumn colfSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colfQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colfAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colsFlagName;
        private DevExpress.XtraGrid.Columns.GridColumn colsSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colsRemark;

    }
}
