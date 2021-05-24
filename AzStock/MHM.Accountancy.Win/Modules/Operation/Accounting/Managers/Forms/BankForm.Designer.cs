namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class BankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtVoen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankSwift = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.vwBankGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwBankGroupTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBankGroupTableAdapter();
            this.vwBankTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBankTableAdapter();
            this.vwCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMDataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.vwCurrencyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter();
            this.cityTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.CityTableAdapter();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.vwRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwRegionTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwRegionTableAdapter();
            this.erpLookUpEditBankGroupId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.erpLookUpEditCurrency = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.erpTreeListLookUpEditRegion = new MHM.Accountancy.Business.Infrastructure.UI.erpTreeListLookUpEdit();
            this.erpTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankSwift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBankGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditBankGroupId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(287, 166);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(473, 166);
            this.btnCancel.TabIndex = 8;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 173);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(193, 166);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(379, 166);
            this.btnPrintDocument.Visible = false;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click_1);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(6, 66);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 18);
            this.labelControl9.TabIndex = 99;
            this.labelControl9.Text = "Bankın Swifti";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(37, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 18);
            this.labelControl5.TabIndex = 88;
            this.labelControl5.Text = "Valyuta";
            // 
            // txtVoen
            // 
            this.txtVoen.Location = new System.Drawing.Point(95, 89);
            this.txtVoen.Name = "txtVoen";
            this.txtVoen.Size = new System.Drawing.Size(465, 20);
            this.txtVoen.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(52, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 18);
            this.labelControl7.TabIndex = 85;
            this.labelControl7.Text = "Vöen";
            // 
            // txtBankSwift
            // 
            this.txtBankSwift.Location = new System.Drawing.Point(95, 63);
            this.txtBankSwift.Name = "txtBankSwift";
            this.txtBankSwift.Size = new System.Drawing.Size(465, 20);
            this.txtBankSwift.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(465, 20);
            this.txtName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(66, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 18);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 18);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Bank Qrup";
            // 
            // vwBankGroupBindingSource
            // 
            this.vwBankGroupBindingSource.DataMember = "VwBankGroup";
            this.vwBankGroupBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwBankGroupTableAdapter
            // 
            this.vwBankGroupTableAdapter.ClearBeforeFill = true;
            // 
            // vwBankTableAdapter
            // 
            this.vwBankTableAdapter.ClearBeforeFill = true;
            // 
            // vwCurrencyBindingSource
            // 
            this.vwCurrencyBindingSource.DataMember = "VwCurrency";
            this.vwCurrencyBindingSource.DataSource = this.dataSet;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.cRMDataSet;
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCurrencyTableAdapter
            // 
            this.vwCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(42, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 18);
            this.labelControl3.TabIndex = 108;
            this.labelControl3.Text = "Region";
            // 
            // vwRegionBindingSource
            // 
            this.vwRegionBindingSource.DataMember = "VwRegion";
            this.vwRegionBindingSource.DataSource = this.cRMDataSet;
            // 
            // vwRegionTableAdapter
            // 
            this.vwRegionTableAdapter.ClearBeforeFill = true;
            // 
            // erpLookUpEditBankGroupId
            // 
            this.erpLookUpEditBankGroupId.Location = new System.Drawing.Point(95, 12);
            this.erpLookUpEditBankGroupId.Name = "erpLookUpEditBankGroupId";
            this.erpLookUpEditBankGroupId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditBankGroupId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditBankGroupId.Properties.DataSource = this.vwBankGroupBindingSource;
            this.erpLookUpEditBankGroupId.Properties.DisplayMember = "Name";
            this.erpLookUpEditBankGroupId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditBankGroupId.Properties.ValueMember = "Id";
            this.erpLookUpEditBankGroupId.Size = new System.Drawing.Size(465, 20);
            this.erpLookUpEditBankGroupId.TabIndex = 1;
            this.erpLookUpEditBankGroupId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditBankGroupId_ButtonClick);
            // 
            // erpLookUpEditCurrency
            // 
            this.erpLookUpEditCurrency.Location = new System.Drawing.Point(95, 114);
            this.erpLookUpEditCurrency.Name = "erpLookUpEditCurrency";
            this.erpLookUpEditCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Buy", "Buy", 28, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sell", "Sell", 26, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefreshDate", "Refresh Date", 74, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCurrency.Properties.DataSource = this.vwCurrencyBindingSource;
            this.erpLookUpEditCurrency.Properties.DisplayMember = "Name";
            this.erpLookUpEditCurrency.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCurrency.Properties.ValueMember = "Id";
            this.erpLookUpEditCurrency.Size = new System.Drawing.Size(465, 20);
            this.erpLookUpEditCurrency.TabIndex = 5;
            this.erpLookUpEditCurrency.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCurrency_ButtonClick);
            // 
            // erpTreeListLookUpEditRegion
            // 
            this.erpTreeListLookUpEditRegion.Location = new System.Drawing.Point(95, 139);
            this.erpTreeListLookUpEditRegion.Name = "erpTreeListLookUpEditRegion";
            this.erpTreeListLookUpEditRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpTreeListLookUpEditRegion.Properties.DataSource = this.vwRegionBindingSource;
            this.erpTreeListLookUpEditRegion.Properties.DisplayMember = "Name";
            this.erpTreeListLookUpEditRegion.Properties.NullText = "[Seçim edilməyib]";
            this.erpTreeListLookUpEditRegion.Properties.TreeList = this.erpTreeListLookUpEdit1TreeList;
            this.erpTreeListLookUpEditRegion.Properties.ValueMember = "Id";
            this.erpTreeListLookUpEditRegion.Size = new System.Drawing.Size(465, 20);
            this.erpTreeListLookUpEditRegion.TabIndex = 6;
            this.erpTreeListLookUpEditRegion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpTreeListLookUpEditRegionId_ButtonClick);
            // 
            // erpTreeListLookUpEdit1TreeList
            // 
            this.erpTreeListLookUpEdit1TreeList.DataSource = this.vwRegionBindingSource;
            this.erpTreeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.erpTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(-59, 5);
            this.erpTreeListLookUpEdit1TreeList.Name = "erpTreeListLookUpEdit1TreeList";
            this.erpTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.erpTreeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.erpTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(264, 200);
            this.erpTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 205);
            this.Controls.Add(this.erpTreeListLookUpEditRegion);
            this.Controls.Add(this.erpLookUpEditCurrency);
            this.Controls.Add(this.erpLookUpEditBankGroupId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtVoen);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtBankSwift);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.MaximumSize = new System.Drawing.Size(583, 244);
            this.MinimumSize = new System.Drawing.Size(583, 244);
            this.Name = "BankForm";
            this.Text = "Banklar";
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtBankSwift, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.txtVoen, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditBankGroupId, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCurrency, 0);
            this.Controls.SetChildIndex(this.erpTreeListLookUpEditRegion, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankSwift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBankGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditBankGroupId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtVoen;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtBankSwift;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwBankGroupBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBankGroupTableAdapter vwBankGroupTableAdapter;
        private Data.AccountingDataSetTableAdapters.VwBankTableAdapter vwBankTableAdapter;
        private System.Windows.Forms.BindingSource vwCurrencyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter vwCurrencyTableAdapter;
        private CRM.Data.CRMDataSet cRMDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private CRM.Data.CRMDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource vwRegionBindingSource;
        private CRM.Data.CRMDataSetTableAdapters.VwRegionTableAdapter vwRegionTableAdapter;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditBankGroupId;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCurrency;
        private Business.Infrastructure.UI.erpTreeListLookUpEdit erpTreeListLookUpEditRegion;
        private DevExpress.XtraTreeList.TreeList erpTreeListLookUpEdit1TreeList;
        private Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
    }
}