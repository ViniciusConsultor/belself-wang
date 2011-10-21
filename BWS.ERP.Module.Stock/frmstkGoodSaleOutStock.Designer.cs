namespace BWS.ERP.Module.Stock
{
    partial class frmstkGoodSaleOutStock
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lkpsShopID = new BWS.ERP.Controls.BWSLookUp();
            this.txtfSaleAmount = new DevExpress.XtraEditors.TextEdit();
            this.lkpsUserID = new BWS.ERP.Controls.BWSLookUp();
            this.detdStockOutDate = new DevExpress.XtraEditors.DateEdit();
            this.txtsVipCardInfo = new DevExpress.XtraEditors.MemoEdit();
            this.txtsStockOutNo = new DevExpress.XtraEditors.TextEdit();
            this.txtsVipCardNo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gcDetail = new BWS.ERP.Controls.BWSGridControl();
            this.gvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsGoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsGoodCName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfDiscountMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpsGoodID = new BWS.ERP.Controls.BWSLookUp();
            this.btnPrintBill = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfo)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFlag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfSaleAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detdStockOutDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detdStockOutDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsVipCardInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsStockOutNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsVipCardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.gcDetail);
            this.pnlDetail.Controls.Add(this.lkpsGoodID);
            this.pnlDetail.Location = new System.Drawing.Point(8, 307);
            this.pnlDetail.Size = new System.Drawing.Size(816, 189);
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(2, 35);
            this.splitterControl2.Visible = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.layoutControl1);
            this.pnlInfo.Controls.Add(this.panelControl3);
            this.pnlInfo.Location = new System.Drawing.Point(8, 35);
            this.pnlInfo.Size = new System.Drawing.Size(816, 266);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlGrid.Size = new System.Drawing.Size(29, 461);
            this.pnlGrid.Visible = false;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(8, 301);
            this.splitterControl1.Size = new System.Drawing.Size(816, 6);
            // 
            // panelControl2
            // 
            this.panelControl2.LookAndFeel.SkinName = "Blue";
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Size = new System.Drawing.Size(822, 33);
            this.panelControl2.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.LookAndFeel.SkinName = "Blue";
            this.btnInsert.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnCopy
            // 
            this.btnCopy.LookAndFeel.SkinName = "Blue";
            this.btnCopy.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(235, 5);
            this.btnPrint.LookAndFeel.SkinName = "Blue";
            this.btnPrint.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnClose
            // 
            this.btnClose.LookAndFeel.SkinName = "Blue";
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnDelete
            // 
            this.btnDelete.LookAndFeel.SkinName = "Blue";
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnCancel
            // 
            this.btnCancel.LookAndFeel.SkinName = "Blue";
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnSave
            // 
            this.btnSave.LookAndFeel.SkinName = "Blue";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnEdit
            // 
            this.btnEdit.LookAndFeel.SkinName = "Blue";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnAdd
            // 
            this.btnAdd.LookAndFeel.SkinName = "Blue";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnView
            // 
            this.btnView.LookAndFeel.SkinName = "Blue";
            this.btnView.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnRefesh
            // 
            this.btnRefesh.LookAndFeel.SkinName = "Blue";
            this.btnRefesh.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // txtDataFlag
            // 
            // 
            // panelControl1
            // 
            this.panelControl1.LookAndFeel.SkinName = "Blue";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Size = new System.Drawing.Size(826, 498);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnPrintBill);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(812, 34);
            this.panelControl3.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "操作说明：";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(96, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(570, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Shift-收款结账 Del-作废明细 F12-作废交易 F1-销售员 F2-会员卡 ESC-退出";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lkpsShopID);
            this.layoutControl1.Controls.Add(this.txtfSaleAmount);
            this.layoutControl1.Controls.Add(this.lkpsUserID);
            this.layoutControl1.Controls.Add(this.detdStockOutDate);
            this.layoutControl1.Controls.Add(this.txtsVipCardInfo);
            this.layoutControl1.Controls.Add(this.txtsStockOutNo);
            this.layoutControl1.Controls.Add(this.txtsVipCardNo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 36);
            this.layoutControl1.LookAndFeel.SkinName = "Blue";
            this.layoutControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(812, 228);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lkpsShopID
            // 
            this.lkpsShopID.DataField = null;
            this.lkpsShopID.DisplayField = null;
            this.lkpsShopID.EditFormFilter = null;
            this.lkpsShopID.EditFormID = 0;
            this.lkpsShopID.EditFormName = null;
            this.lkpsShopID.EditValue = "";
            this.lkpsShopID.GridColumnText = null;
            this.lkpsShopID.GridDisplayField = null;
            this.lkpsShopID.IsReadOnly = false;
            this.lkpsShopID.Location = new System.Drawing.Point(499, 96);
            this.lkpsShopID.Name = "lkpsShopID";
            this.lkpsShopID.SearchFormFilter = "";
            this.lkpsShopID.SearchFormText = "";
            this.lkpsShopID.Size = new System.Drawing.Size(228, 42);
            this.lkpsShopID.SQL = null;
            this.lkpsShopID.TabIndex = 13;
            this.lkpsShopID.Tag = "99";
            this.lkpsShopID.TextFont = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtfSaleAmount
            // 
            this.txtfSaleAmount.Location = new System.Drawing.Point(499, 50);
            this.txtfSaleAmount.Name = "txtfSaleAmount";
            this.txtfSaleAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfSaleAmount.Properties.Appearance.Options.UseFont = true;
            this.txtfSaleAmount.Properties.DisplayFormat.FormatString = "{0:0.00}";
            this.txtfSaleAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtfSaleAmount.Properties.ReadOnly = true;
            this.txtfSaleAmount.Size = new System.Drawing.Size(228, 42);
            this.txtfSaleAmount.StyleController = this.layoutControl1;
            this.txtfSaleAmount.TabIndex = 12;
            this.txtfSaleAmount.Tag = "99";
            // 
            // lkpsUserID
            // 
            this.lkpsUserID.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkpsUserID.Appearance.Options.UseFont = true;
            this.lkpsUserID.DataField = null;
            this.lkpsUserID.DisplayField = null;
            this.lkpsUserID.EditFormFilter = null;
            this.lkpsUserID.EditFormID = 0;
            this.lkpsUserID.EditFormName = null;
            this.lkpsUserID.EditValue = "";
            this.lkpsUserID.GridColumnText = null;
            this.lkpsUserID.GridDisplayField = null;
            this.lkpsUserID.Location = new System.Drawing.Point(133, 50);
            this.lkpsUserID.Name = "lkpsUserID";
            this.lkpsUserID.SearchFormFilter = "";
            this.lkpsUserID.SearchFormText = "";
            this.lkpsUserID.Size = new System.Drawing.Size(233, 42);
            this.lkpsUserID.SQL = null;
            this.lkpsUserID.TabIndex = 11;
            this.lkpsUserID.TextFont = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // detdStockOutDate
            // 
            this.detdStockOutDate.EditValue = null;
            this.detdStockOutDate.Location = new System.Drawing.Point(499, 4);
            this.detdStockOutDate.Name = "detdStockOutDate";
            this.detdStockOutDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detdStockOutDate.Properties.Appearance.Options.UseFont = true;
            this.detdStockOutDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detdStockOutDate.Properties.ReadOnly = true;
            this.detdStockOutDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detdStockOutDate.Size = new System.Drawing.Size(228, 42);
            this.detdStockOutDate.StyleController = this.layoutControl1;
            this.detdStockOutDate.TabIndex = 8;
            this.detdStockOutDate.Tag = "99";
            // 
            // txtsVipCardInfo
            // 
            this.txtsVipCardInfo.EditValue = "";
            this.txtsVipCardInfo.Location = new System.Drawing.Point(133, 142);
            this.txtsVipCardInfo.Name = "txtsVipCardInfo";
            this.txtsVipCardInfo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsVipCardInfo.Properties.Appearance.Options.UseFont = true;
            this.txtsVipCardInfo.Properties.ReadOnly = true;
            this.txtsVipCardInfo.Size = new System.Drawing.Size(594, 67);
            this.txtsVipCardInfo.StyleController = this.layoutControl1;
            this.txtsVipCardInfo.TabIndex = 7;
            this.txtsVipCardInfo.Tag = "99";
            // 
            // txtsStockOutNo
            // 
            this.txtsStockOutNo.Location = new System.Drawing.Point(133, 4);
            this.txtsStockOutNo.Name = "txtsStockOutNo";
            this.txtsStockOutNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsStockOutNo.Properties.Appearance.Options.UseFont = true;
            this.txtsStockOutNo.Properties.ReadOnly = true;
            this.txtsStockOutNo.Size = new System.Drawing.Size(233, 42);
            this.txtsStockOutNo.StyleController = this.layoutControl1;
            this.txtsStockOutNo.TabIndex = 6;
            this.txtsStockOutNo.Tag = "99";
            // 
            // txtsVipCardNo
            // 
            this.txtsVipCardNo.Location = new System.Drawing.Point(133, 96);
            this.txtsVipCardNo.Name = "txtsVipCardNo";
            this.txtsVipCardNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsVipCardNo.Properties.Appearance.Options.UseFont = true;
            this.txtsVipCardNo.Properties.DisplayFormat.FormatString = "{0:0.00}";
            this.txtsVipCardNo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsVipCardNo.Size = new System.Drawing.Size(233, 42);
            this.txtsVipCardNo.StyleController = this.layoutControl1;
            this.txtsVipCardNo.TabIndex = 4;
            this.txtsVipCardNo.Tag = "";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.emptySpaceItem3,
            this.emptySpaceItem5,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(812, 228);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtsStockOutNo;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(366, 46);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(366, 46);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(366, 46);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "销售流水号";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(125, 29);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtsVipCardInfo;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(727, 71);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(727, 71);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(727, 71);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "积分信息";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(125, 29);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.detdStockOutDate;
            this.layoutControlItem5.CustomizationFormText = "入库日期";
            this.layoutControlItem5.Location = new System.Drawing.Point(366, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(361, 46);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(361, 46);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(361, 46);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "销售日期";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(125, 29);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtfSaleAmount;
            this.layoutControlItem9.CustomizationFormText = "总金额";
            this.layoutControlItem9.Location = new System.Drawing.Point(366, 46);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(361, 46);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(361, 46);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(361, 46);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "销售金额";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(125, 29);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.lkpsUserID;
            this.layoutControlItem8.CustomizationFormText = "入库员";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(366, 46);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(366, 46);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(366, 46);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "销售员";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(125, 29);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(727, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(81, 46);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtsVipCardNo;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(366, 46);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(366, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(366, 46);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "会员卡";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(125, 29);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(727, 46);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(81, 46);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.lkpsShopID;
            this.layoutControlItem6.CustomizationFormText = "所属门店";
            this.layoutControlItem6.Location = new System.Drawing.Point(366, 92);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(361, 46);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(361, 46);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(361, 46);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "所属门店";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(125, 29);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(727, 92);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(81, 46);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 209);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(808, 15);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(727, 138);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(81, 71);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gcDetail
            // 
            this.gcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcDetail.Location = new System.Drawing.Point(2, 2);
            this.gcDetail.MainView = this.gvDetail;
            this.gcDetail.Name = "gcDetail";
            this.gcDetail.Size = new System.Drawing.Size(812, 185);
            this.gcDetail.TabIndex = 5;
            this.gcDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetail});
            this.gcDetail.Click += new System.EventHandler(this.gcDetail_Click);
            // 
            // gvDetail
            // 
            this.gvDetail.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.gvDetail.Appearance.Row.Options.UseFont = true;
            this.gvDetail.ColumnPanelRowHeight = 25;
            this.gvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsGoodID,
            this.colsGoodCName,
            this.colsSpec,
            this.colfSalePrice,
            this.colfQuantity,
            this.colfDiscount,
            this.colfDiscountMoney,
            this.colfAmount,
            this.colsRemark});
            this.gvDetail.GridControl = this.gcDetail;
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDetail.OptionsView.ColumnAutoWidth = false;
            this.gvDetail.OptionsView.RowAutoHeight = true;
            this.gvDetail.OptionsView.ShowFooter = true;
            this.gvDetail.OptionsView.ShowGroupPanel = false;
            this.gvDetail.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gvDetail_FocusedColumnChanged);
            this.gvDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDetail_CellValueChanged);
            this.gvDetail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDetail_InitNewRow);
            // 
            // colsGoodID
            // 
            this.colsGoodID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colsGoodID.AppearanceHeader.Options.UseFont = true;
            this.colsGoodID.Caption = "商品编号(条码)";
            this.colsGoodID.FieldName = "sGoodID";
            this.colsGoodID.Name = "colsGoodID";
            this.colsGoodID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colsGoodID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsGoodID.OptionsFilter.AllowAutoFilter = false;
            this.colsGoodID.OptionsFilter.AllowFilter = false;
            this.colsGoodID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colsGoodID.Visible = true;
            this.colsGoodID.VisibleIndex = 0;
            this.colsGoodID.Width = 132;
            // 
            // colsGoodCName
            // 
            this.colsGoodCName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colsGoodCName.AppearanceHeader.Options.UseFont = true;
            this.colsGoodCName.Caption = "商品名称";
            this.colsGoodCName.FieldName = "sGoodCName";
            this.colsGoodCName.Name = "colsGoodCName";
            this.colsGoodCName.OptionsColumn.AllowEdit = false;
            this.colsGoodCName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colsGoodCName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsGoodCName.OptionsFilter.AllowAutoFilter = false;
            this.colsGoodCName.OptionsFilter.AllowFilter = false;
            this.colsGoodCName.Visible = true;
            this.colsGoodCName.VisibleIndex = 1;
            this.colsGoodCName.Width = 158;
            // 
            // colsSpec
            // 
            this.colsSpec.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colsSpec.AppearanceHeader.Options.UseFont = true;
            this.colsSpec.Caption = "规格";
            this.colsSpec.FieldName = "sSpec";
            this.colsSpec.Name = "colsSpec";
            this.colsSpec.OptionsColumn.AllowEdit = false;
            this.colsSpec.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colsSpec.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsSpec.OptionsFilter.AllowAutoFilter = false;
            this.colsSpec.OptionsFilter.AllowFilter = false;
            this.colsSpec.Visible = true;
            this.colsSpec.VisibleIndex = 2;
            this.colsSpec.Width = 97;
            // 
            // colfSalePrice
            // 
            this.colfSalePrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colfSalePrice.AppearanceHeader.Options.UseFont = true;
            this.colfSalePrice.Caption = "零售价";
            this.colfSalePrice.FieldName = "fSalePrice";
            this.colfSalePrice.Name = "colfSalePrice";
            this.colfSalePrice.OptionsColumn.AllowEdit = false;
            this.colfSalePrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colfSalePrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfSalePrice.OptionsFilter.AllowAutoFilter = false;
            this.colfSalePrice.OptionsFilter.AllowFilter = false;
            this.colfSalePrice.Visible = true;
            this.colfSalePrice.VisibleIndex = 3;
            this.colfSalePrice.Width = 90;
            // 
            // colfQuantity
            // 
            this.colfQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colfQuantity.AppearanceHeader.Options.UseFont = true;
            this.colfQuantity.Caption = "数量";
            this.colfQuantity.FieldName = "fQuantity";
            this.colfQuantity.Name = "colfQuantity";
            this.colfQuantity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colfQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfQuantity.OptionsFilter.AllowAutoFilter = false;
            this.colfQuantity.OptionsFilter.AllowFilter = false;
            this.colfQuantity.SummaryItem.DisplayFormat = "{0:n}";
            this.colfQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfQuantity.Visible = true;
            this.colfQuantity.VisibleIndex = 4;
            this.colfQuantity.Width = 80;
            // 
            // colfDiscount
            // 
            this.colfDiscount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colfDiscount.AppearanceHeader.Options.UseFont = true;
            this.colfDiscount.Caption = "折扣(%)";
            this.colfDiscount.FieldName = "fDiscount";
            this.colfDiscount.Name = "colfDiscount";
            this.colfDiscount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colfDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfDiscount.OptionsFilter.AllowAutoFilter = false;
            this.colfDiscount.OptionsFilter.AllowFilter = false;
            this.colfDiscount.Visible = true;
            this.colfDiscount.VisibleIndex = 5;
            this.colfDiscount.Width = 89;
            // 
            // colfDiscountMoney
            // 
            this.colfDiscountMoney.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colfDiscountMoney.AppearanceHeader.Options.UseFont = true;
            this.colfDiscountMoney.Caption = "优惠金额";
            this.colfDiscountMoney.FieldName = "fDiscountMoney";
            this.colfDiscountMoney.Name = "colfDiscountMoney";
            this.colfDiscountMoney.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colfDiscountMoney.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfDiscountMoney.OptionsFilter.AllowAutoFilter = false;
            this.colfDiscountMoney.OptionsFilter.AllowFilter = false;
            this.colfDiscountMoney.SummaryItem.DisplayFormat = "{0:n2}";
            this.colfDiscountMoney.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfDiscountMoney.Visible = true;
            this.colfDiscountMoney.VisibleIndex = 6;
            this.colfDiscountMoney.Width = 94;
            // 
            // colfAmount
            // 
            this.colfAmount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colfAmount.AppearanceHeader.Options.UseFont = true;
            this.colfAmount.Caption = "销售金额";
            this.colfAmount.FieldName = "fAmount";
            this.colfAmount.Name = "colfAmount";
            this.colfAmount.OptionsColumn.AllowEdit = false;
            this.colfAmount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colfAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colfAmount.OptionsFilter.AllowAutoFilter = false;
            this.colfAmount.OptionsFilter.AllowFilter = false;
            this.colfAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colfAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colfAmount.Visible = true;
            this.colfAmount.VisibleIndex = 7;
            this.colfAmount.Width = 92;
            // 
            // colsRemark
            // 
            this.colsRemark.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.colsRemark.AppearanceHeader.Options.UseFont = true;
            this.colsRemark.Caption = "备注";
            this.colsRemark.FieldName = "sRemark";
            this.colsRemark.Name = "colsRemark";
            this.colsRemark.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colsRemark.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsRemark.OptionsFilter.AllowAutoFilter = false;
            this.colsRemark.OptionsFilter.AllowFilter = false;
            this.colsRemark.Visible = true;
            this.colsRemark.VisibleIndex = 8;
            this.colsRemark.Width = 88;
            // 
            // lkpsGoodID
            // 
            this.lkpsGoodID.AutoSize = true;
            this.lkpsGoodID.DataField = null;
            this.lkpsGoodID.DisplayField = null;
            this.lkpsGoodID.EditFormFilter = null;
            this.lkpsGoodID.EditFormID = 0;
            this.lkpsGoodID.EditFormName = null;
            this.lkpsGoodID.EditValue = "";
            this.lkpsGoodID.GridColumnText = null;
            this.lkpsGoodID.GridDisplayField = null;
            this.lkpsGoodID.Location = new System.Drawing.Point(135, 87);
            this.lkpsGoodID.Name = "lkpsGoodID";
            this.lkpsGoodID.SearchFormFilter = "";
            this.lkpsGoodID.SearchFormText = "";
            this.lkpsGoodID.Size = new System.Drawing.Size(132, 21);
            this.lkpsGoodID.SQL = null;
            this.lkpsGoodID.TabIndex = 6;
            this.lkpsGoodID.TextFont = new System.Drawing.Font("Tahoma", 9F);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(672, 6);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(75, 23);
            this.btnPrintBill.TabIndex = 2;
            this.btnPrintBill.Text = "打印报表";
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // frmstkGoodSaleOutStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(826, 498);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmstkGoodSaleOutStock";
            this.Text = "销售出库";
            this.Load += new System.EventHandler(this.frmstkGoodSaleOutStock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmstkGoodSaleOutStock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFlag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtfSaleAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detdStockOutDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detdStockOutDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsVipCardInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsStockOutNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsVipCardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private BWS.ERP.Controls.BWSLookUp lkpsShopID;
        private DevExpress.XtraEditors.TextEdit txtfSaleAmount;
        private BWS.ERP.Controls.BWSLookUp lkpsUserID;
        private DevExpress.XtraEditors.DateEdit detdStockOutDate;
        private DevExpress.XtraEditors.MemoEdit txtsVipCardInfo;
        private DevExpress.XtraEditors.TextEdit txtsStockOutNo;
        private DevExpress.XtraEditors.TextEdit txtsVipCardNo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private BWS.ERP.Controls.BWSGridControl gcDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodID;
        private DevExpress.XtraGrid.Columns.GridColumn colsGoodCName;
        private DevExpress.XtraGrid.Columns.GridColumn colsSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colfSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colfQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colfDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colfDiscountMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colfAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colsRemark;
        private BWS.ERP.Controls.BWSLookUp lkpsGoodID;
        private DevExpress.XtraEditors.SimpleButton btnPrintBill;
    }
}
