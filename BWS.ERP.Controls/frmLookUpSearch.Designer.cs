namespace BWS.ERP.Controls
{
    partial class frmLookUpSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookUpSearch));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.gcSearch = new BWS.ERP.Controls.BWSGridControl();
            this.gvSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmsSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPdf = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).BeginInit();
            this.cmsSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.btnView);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.SkinName = "Blue";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(603, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::BWS.ERP.Controls.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(105, 5);
            this.btnEdit.LookAndFeel.SkinName = "Blue";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 24);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.ToolTip = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BWS.ERP.Controls.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(80, 5);
            this.btnClose.LookAndFeel.SkinName = "Blue";
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 4;
            this.btnClose.ToolTip = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BWS.ERP.Controls.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(192, 3);
            this.btnSave.LookAndFeel.SkinName = "Blue";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.ToolTip = "将结果保存为";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BWS.ERP.Controls.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(55, 5);
            this.btnCancel.LookAndFeel.SkinName = "Blue";
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.ToolTip = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::BWS.ERP.Controls.Properties.Resources.ok;
            this.btnSelect.Location = new System.Drawing.Point(30, 5);
            this.btnSelect.LookAndFeel.SkinName = "Blue";
            this.btnSelect.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(24, 24);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.ToolTip = "选择";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnView
            // 
            this.btnView.Image = global::BWS.ERP.Controls.Properties.Resources.view;
            this.btnView.Location = new System.Drawing.Point(5, 5);
            this.btnView.LookAndFeel.SkinName = "Blue";
            this.btnView.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(24, 24);
            this.btnView.TabIndex = 0;
            this.btnView.ToolTip = "查询";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // gcSearch
            // 
            this.gcSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSearch.Location = new System.Drawing.Point(0, 32);
            this.gcSearch.MainView = this.gvSearch;
            this.gcSearch.Name = "gcSearch";
            this.gcSearch.Size = new System.Drawing.Size(603, 284);
            this.gcSearch.TabIndex = 1;
            this.gcSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSearch});
            // 
            // gvSearch
            // 
            this.gvSearch.GridControl = this.gcSearch;
            this.gvSearch.Name = "gvSearch";
            this.gvSearch.OptionsBehavior.Editable = false;
            this.gvSearch.OptionsView.ColumnAutoWidth = false;
            this.gvSearch.OptionsView.ShowAutoFilterRow = true;
            this.gvSearch.OptionsView.ShowFooter = true;
            this.gvSearch.DoubleClick += new System.EventHandler(this.gcSearch_DoubleClick);
            // 
            // cmsSave
            // 
            this.cmsSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHtml,
            this.tsmExcel,
            this.tsmWord,
            this.tsmPdf});
            this.cmsSave.Name = "contextMenuStrip1";
            this.cmsSave.Size = new System.Drawing.Size(152, 92);
            // 
            // tsmHtml
            // 
            this.tsmHtml.Name = "tsmHtml";
            this.tsmHtml.Size = new System.Drawing.Size(151, 22);
            this.tsmHtml.Text = "保存为HTML";
            this.tsmHtml.Click += new System.EventHandler(this.tsmHtml_Click);
            // 
            // tsmExcel
            // 
            this.tsmExcel.Name = "tsmExcel";
            this.tsmExcel.Size = new System.Drawing.Size(151, 22);
            this.tsmExcel.Text = "保存为EXCEL";
            this.tsmExcel.Click += new System.EventHandler(this.tsmExcel_Click);
            // 
            // tsmWord
            // 
            this.tsmWord.Name = "tsmWord";
            this.tsmWord.Size = new System.Drawing.Size(151, 22);
            this.tsmWord.Text = "保存为WORD";
            this.tsmWord.Click += new System.EventHandler(this.tsmWord_Click);
            // 
            // tsmPdf
            // 
            this.tsmPdf.Name = "tsmPdf";
            this.tsmPdf.Size = new System.Drawing.Size(151, 22);
            this.tsmPdf.Text = "保存为PDF";
            this.tsmPdf.Click += new System.EventHandler(this.tsmPdf_Click);
            // 
            // frmLookUpSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 316);
            this.Controls.Add(this.gcSearch);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmLookUpSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择";
            this.Load += new System.EventHandler(this.frmLookUpSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).EndInit();
            this.cmsSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BWS.ERP.Controls.BWSGridControl gcSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSearch;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.ContextMenuStrip cmsSave;
        private System.Windows.Forms.ToolStripMenuItem tsmHtml;
        private System.Windows.Forms.ToolStripMenuItem tsmExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmWord;
        private System.Windows.Forms.ToolStripMenuItem tsmPdf;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
    }
}