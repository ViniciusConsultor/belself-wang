namespace BWS.ERP.Module.Stock
{
    partial class frmstkGoodStkInfo
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
            this.txtsGoodCName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.txtsShopCName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsSpec = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtsGoodID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcMain = new BWS.ERP.Controls.BWSGridControl();
            this.gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsGoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsGoodCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsGoodEName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsGoodTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsUnitCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsShopCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfStkInQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfStkOutQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsGoodCName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsShopCName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsGoodID.Properties)).BeginInit();
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
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(753, 133);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtsGoodCName);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.btnClose);
            this.xtraTabPage1.Controls.Add(this.btnClear);
            this.xtraTabPage1.Controls.Add(this.btnQuery);
            this.xtraTabPage1.Controls.Add(this.txtsShopCName);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtsSpec);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtsGoodID);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(746, 104);
            this.xtraTabPage1.Text = "查询条件";
            // 
            // txtsGoodCName
            // 
            this.txtsGoodCName.Location = new System.Drawing.Point(86, 41);
            this.txtsGoodCName.Name = "txtsGoodCName";
            this.txtsGoodCName.Size = new System.Drawing.Size(118, 21);
            this.txtsGoodCName.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "商品名称";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::BWS.ERP.Module.Stock.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(643, 73);
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
            this.btnClear.Location = new System.Drawing.Point(643, 44);
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
            this.btnQuery.Location = new System.Drawing.Point(643, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&S)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtsShopCName
            // 
            this.txtsShopCName.Location = new System.Drawing.Point(445, 12);
            this.txtsShopCName.Name = "txtsShopCName";
            this.txtsShopCName.Size = new System.Drawing.Size(118, 21);
            this.txtsShopCName.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(394, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "所属门店";
            // 
            // txtsSpec
            // 
            this.txtsSpec.Location = new System.Drawing.Point(258, 12);
            this.txtsSpec.Name = "txtsSpec";
            this.txtsSpec.Size = new System.Drawing.Size(118, 21);
            this.txtsSpec.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(219, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "规格";
            // 
            // txtsGoodID
            // 
            this.txtsGoodID.Location = new System.Drawing.Point(86, 12);
            this.txtsGoodID.Name = "txtsGoodID";
            this.txtsGoodID.Size = new System.Drawing.Size(118, 21);
            this.txtsGoodID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "商品编号";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(2, 135);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(753, 6);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcMain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 141);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(753, 355);
            this.panelControl2.TabIndex = 5;
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(2, 2);
            this.gcMain.MainView = this.gvMain;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(749, 351);
            this.gcMain.TabIndex = 0;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMain});
            // 
            // gvMain
            // 
            this.gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsGoodID,
            this.colsSpec,
            this.colsGoodCName,
            this.colsGoodEName,
            this.colsGoodTypeName,
            this.colsUnitCName,
            this.colsShopCName,
            this.colfStkInQty,
            this.colfStkOutQty,
            this.colfQuantity});
            this.gvMain.GridControl = this.gcMain;
            this.gvMain.Name = "gvMain";
            this.gvMain.OptionsBehavior.Editable = false;
            this.gvMain.OptionsView.ColumnAutoWidth = false;
            this.gvMain.OptionsView.ShowFooter = true;
            // 
            // colsGoodID
            // 
            this.colsGoodID.Caption = "商品编号";
            this.colsGoodID.FieldName = "sGoodID";
            this.colsGoodID.Name = "colsGoodID";
            this.colsGoodID.Visible = true;
            this.colsGoodID.VisibleIndex = 0;
            this.colsGoodID.Width = 100;
            // 
            // colsSpec
            // 
            this.colsSpec.Caption = "规格";
            this.colsSpec.FieldName = "sSpec";
            this.colsSpec.Name = "colsSpec";
            this.colsSpec.Visible = true;
            this.colsSpec.VisibleIndex = 1;
            this.colsSpec.Width = 100;
            // 
            // colsGoodCName
            // 
            this.colsGoodCName.Caption = "商品名称";
            this.colsGoodCName.FieldName = "sGoodCName";
            this.colsGoodCName.Name = "colsGoodCName";
            this.colsGoodCName.Visible = true;
            this.colsGoodCName.VisibleIndex = 2;
            this.colsGoodCName.Width = 122;
            // 
            // colsGoodEName
            // 
            this.colsGoodEName.Caption = "商品英文名";
            this.colsGoodEName.FieldName = "sGoodEName";
            this.colsGoodEName.Name = "colsGoodEName";
            this.colsGoodEName.Visible = true;
            this.colsGoodEName.VisibleIndex = 3;
            this.colsGoodEName.Width = 100;
            // 
            // colsGoodTypeName
            // 
            this.colsGoodTypeName.Caption = "商品类型";
            this.colsGoodTypeName.FieldName = "sGoodTypeName";
            this.colsGoodTypeName.Name = "colsGoodTypeName";
            this.colsGoodTypeName.Visible = true;
            this.colsGoodTypeName.VisibleIndex = 4;
            this.colsGoodTypeName.Width = 100;
            // 
            // colsUnitCName
            // 
            this.colsUnitCName.Caption = "单位";
            this.colsUnitCName.FieldName = "sUnitName";
            this.colsUnitCName.Name = "colsUnitCName";
            this.colsUnitCName.Visible = true;
            this.colsUnitCName.VisibleIndex = 5;
            this.colsUnitCName.Width = 100;
            // 
            // colsShopCName
            // 
            this.colsShopCName.Caption = "所属门店";
            this.colsShopCName.FieldName = "sShopCName";
            this.colsShopCName.Name = "colsShopCName";
            this.colsShopCName.Visible = true;
            this.colsShopCName.VisibleIndex = 6;
            this.colsShopCName.Width = 100;
            // 
            // colfStkInQty
            // 
            this.colfStkInQty.Caption = "入库数量";
            this.colfStkInQty.FieldName = "fStkInQty";
            this.colfStkInQty.Name = "colfStkInQty";
            this.colfStkInQty.SummaryItem.DisplayFormat = "{0:n2}";
            this.colfStkInQty.SummaryItem.FieldName = "fQuantity";
            this.colfStkInQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfStkInQty.Visible = true;
            this.colfStkInQty.VisibleIndex = 7;
            this.colfStkInQty.Width = 100;
            // 
            // colfStkOutQty
            // 
            this.colfStkOutQty.Caption = "出库数量";
            this.colfStkOutQty.FieldName = "fStkOutQty";
            this.colfStkOutQty.Name = "colfStkOutQty";
            this.colfStkOutQty.SummaryItem.DisplayFormat = "{0:n2}";
            this.colfStkOutQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfStkOutQty.Visible = true;
            this.colfStkOutQty.VisibleIndex = 8;
            this.colfStkOutQty.Width = 100;
            // 
            // colfQuantity
            // 
            this.colfQuantity.Caption = "库存量";
            this.colfQuantity.FieldName = "fQuantity";
            this.colfQuantity.Name = "colfQuantity";
            this.colfQuantity.SummaryItem.DisplayFormat = "{0:n2}";
            this.colfQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfQuantity.Visible = true;
            this.colfQuantity.VisibleIndex = 9;
            this.colfQuantity.Width = 100;
            // 
            // frmstkGoodStkInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(757, 498);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmstkGoodStkInfo";
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.frmstkGoodStkInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsGoodCName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsShopCName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsGoodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.TextEdit txtsShopCName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtsSpec;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtsGoodID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BWS.ERP.Controls.BWSGridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodID;
        private DevExpress.XtraGrid.Columns.GridColumn colsSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodCName;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodEName;
        private DevExpress.XtraGrid.Columns.GridColumn colsUnitCName;
        private DevExpress.XtraGrid.Columns.GridColumn colfStkInQty;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colsShopCName;
        private DevExpress.XtraGrid.Columns.GridColumn colfStkOutQty;
        private DevExpress.XtraGrid.Columns.GridColumn colfQuantity;
        private DevExpress.XtraEditors.TextEdit txtsGoodCName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
