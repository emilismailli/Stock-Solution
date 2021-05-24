namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class CashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtCash = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spWareHouseSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.spWareHouseSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAcceptCash = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.vwCashTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCashTableAdapter();
            this.vwCashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(85, 132);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(271, 132);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 139);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(-9, 132);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Enabled = false;
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(177, 132);
            this.btnPrintDocument.Visible = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(41, 102);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 18);
            this.labelControl9.TabIndex = 99;
            this.labelControl9.Text = "Qeyd";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(37, 51);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 18);
            this.labelControl5.TabIndex = 88;
            this.labelControl5.Text = "Kassa";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(82, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(276, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(82, 52);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(276, 20);
            this.txtCash.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 18);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Müəssisə";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(82, 26);
            this.erpLookUpEditCompany.Name = "erpLookUpEditCompany";
            this.erpLookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Ad", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCompany.Properties.DataSource = this.vwCompanyBindingSource;
            this.erpLookUpEditCompany.Properties.DisplayMember = "CompanyName";
            this.erpLookUpEditCompany.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCompany.Properties.ValueMember = "Id";
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(276, 20);
            this.erpLookUpEditCompany.TabIndex = 1;
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.dataSet;
            // 
            // spWareHouseSelectBindingSource
            // 
            this.spWareHouseSelectBindingSource.DataMember = "spWareHouseSelect";
            this.spWareHouseSelectBindingSource.DataSource = this.dataSet;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // spWareHouseSelectTableAdapter
            // 
            this.spWareHouseSelectTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAcceptCash,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAcceptCash),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAcceptCash
            // 
            this.btnAcceptCash.Caption = "Təsdiqlə";
            this.btnAcceptCash.Hint = "  ";
            this.btnAcceptCash.Id = 0;
            this.btnAcceptCash.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnAcceptCash.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter));
            this.btnAcceptCash.Name = "btnAcceptCash";
            this.btnAcceptCash.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAcceptCash.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAcceptCash_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "İmtina Et";
            this.btnClose.Hint = "   ";
            this.btnClose.Id = 1;
            this.btnClose.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(365, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 171);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(365, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 147);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(365, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 147);
            // 
            // vwCashTableAdapter
            // 
            this.vwCashTableAdapter.ClearBeforeFill = true;
            // 
            // vwCashBindingSource
            // 
            this.vwCashBindingSource.DataMember = "VwCash";
            this.vwCashBindingSource.DataSource = this.dataSet;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 18);
            this.labelControl1.TabIndex = 105;
            this.labelControl1.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(82, 77);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(276, 20);
            this.txtBalance.TabIndex = 104; 
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 171);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.erpLookUpEditCompany);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CashForm";
            this.Text = "Kassalar";
            this.Load += new System.EventHandler(this.CashForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtCash, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCompany, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.txtBalance, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtCash;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Data.AccountingDataSet dataSet;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompany;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private System.Windows.Forms.BindingSource spWareHouseSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter spWareHouseSelectTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAcceptCash;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private Data.AccountingDataSetTableAdapters.VwCashTableAdapter vwCashTableAdapter;
        private System.Windows.Forms.BindingSource vwCashBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBalance;
    }
}