namespace BWS.ERP.Module.Stock
{
    partial class frmstkGoodSaleOutStockCheckOut
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtfSaleAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtfPayMoney = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtfPayBackMoney = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfSaleAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfPayMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfPayBackMoney.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnOk);
            this.panelControl1.Controls.Add(this.txtfPayBackMoney);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtfPayMoney);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtfSaleAmount);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Size = new System.Drawing.Size(419, 292);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "销售金额";
            // 
            // txtfSaleAmount
            // 
            this.txtfSaleAmount.Location = new System.Drawing.Point(146, 23);
            this.txtfSaleAmount.Name = "txtfSaleAmount";
            this.txtfSaleAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfSaleAmount.Properties.Appearance.Options.UseFont = true;
            this.txtfSaleAmount.Properties.ReadOnly = true;
            this.txtfSaleAmount.Size = new System.Drawing.Size(244, 42);
            this.txtfSaleAmount.TabIndex = 1;
            // 
            // txtfPayMoney
            // 
            this.txtfPayMoney.Location = new System.Drawing.Point(146, 81);
            this.txtfPayMoney.Name = "txtfPayMoney";
            this.txtfPayMoney.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfPayMoney.Properties.Appearance.Options.UseFont = true;
            this.txtfPayMoney.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtfPayMoney.Size = new System.Drawing.Size(244, 42);
            this.txtfPayMoney.TabIndex = 3;
            this.txtfPayMoney.Leave += new System.EventHandler(this.txtfPayMoney_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 35);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "收       款";
            // 
            // txtfPayBackMoney
            // 
            this.txtfPayBackMoney.Location = new System.Drawing.Point(146, 141);
            this.txtfPayBackMoney.Name = "txtfPayBackMoney";
            this.txtfPayBackMoney.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfPayBackMoney.Properties.Appearance.Options.UseFont = true;
            this.txtfPayBackMoney.Properties.ReadOnly = true;
            this.txtfPayBackMoney.Size = new System.Drawing.Size(244, 42);
            this.txtfPayBackMoney.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 35);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "找       零";
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(39, 221);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 47);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "完 成";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(218, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 47);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取 消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmstkGoodSaleOutStockCheckOut
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(419, 292);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmstkGoodSaleOutStockCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收款";
            this.Load += new System.EventHandler(this.frmstkGoodSaleOutStockCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfSaleAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfPayMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfPayBackMoney.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtfPayBackMoney;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtfPayMoney;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtfSaleAmount;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
    }
}
