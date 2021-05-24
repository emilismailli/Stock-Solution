namespace MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms
{
    partial class WareHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseForm));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtWareHouseName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditWareHouseTypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpParentCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSet();
            this.wareHouseTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.wareHouseTypeAdapter = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter();
            this.VwWareHouseBindingSource = new System.Windows.Forms.BindingSource();
            this.wareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.WareHouseTableAdapter();
            this.vwWareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.VwWareHouseTableAdapter();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.VwCompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWareHouseTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpParentCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VwWareHouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(383, 136);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(477, 136);
            this.btnCancel.TabIndex = 5;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 142);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(382, 216);
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(474, 216);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "Anbarın növü";
            // 
            // txtWareHouseName
            // 
            this.txtWareHouseName.Location = new System.Drawing.Point(96, 36);
            this.txtWareHouseName.Name = "txtWareHouseName";
            this.txtWareHouseName.Size = new System.Drawing.Size(468, 20);
            this.txtWareHouseName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 65;
            this.labelControl2.Text = "Anbarın adı";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 86);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(468, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 69;
            this.labelControl1.Text = "Qeyd";
            // 
            // lookUpEditWareHouseTypeId
            // 
            this.lookUpEditWareHouseTypeId.Location = new System.Drawing.Point(96, 61);
            this.lookUpEditWareHouseTypeId.Name = "lookUpEditWareHouseTypeId";
            this.lookUpEditWareHouseTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.lookUpEditWareHouseTypeId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Qeyd", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditWareHouseTypeId.Properties.DataSource = this.wareHouseTypeBindingSource;
            this.lookUpEditWareHouseTypeId.Properties.DisplayMember = "Name";
            this.lookUpEditWareHouseTypeId.Properties.NullText = "[Seçim Edilməyib]";
            this.lookUpEditWareHouseTypeId.Properties.ValueMember = "Id";
            this.lookUpEditWareHouseTypeId.Size = new System.Drawing.Size(468, 20);
            this.lookUpEditWareHouseTypeId.TabIndex = 2;
            this.lookUpEditWareHouseTypeId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lookUpEditWareHouseTypeId_ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 71;
            this.labelControl3.Text = "Müəssisə";
            // 
            // lookUpParentCompany
            // 
            this.lookUpParentCompany.Location = new System.Drawing.Point(96, 8);
            this.lookUpParentCompany.Name = "lookUpParentCompany";
            this.lookUpParentCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.lookUpParentCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Ad", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpParentCompany.Properties.DataSource = this.vwCompanyBindingSource;
            this.lookUpParentCompany.Properties.DisplayMember = "CompanyName";
            this.lookUpParentCompany.Properties.NullText = "[Seçim Edilməyib]";
            this.lookUpParentCompany.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.lookUpParentCompany.Properties.ValueMember = "Id";
            this.lookUpParentCompany.Size = new System.Drawing.Size(468, 20);
            this.lookUpParentCompany.TabIndex = 88;
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "WareHouseDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wareHouseTypeBindingSource
            // 
            this.wareHouseTypeBindingSource.DataMember = "WareHouseType";
            this.wareHouseTypeBindingSource.DataSource = this.dataSet;
            // 
            // wareHouseTypeAdapter
            // 
            this.wareHouseTypeAdapter.ClearBeforeFill = true;
            // 
            // VwWareHouseBindingSource
            // 
            this.VwWareHouseBindingSource.DataMember = "VwWareHouse";
            this.VwWareHouseBindingSource.DataSource = this.dataSet;
            // 
            // wareHouseTableAdapter
            // 
            this.wareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // vwWareHouseTableAdapter
            // 
            this.vwWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // WareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 175);
            this.Controls.Add(this.lookUpParentCompany);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lookUpEditWareHouseTypeId);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtWareHouseName);
            this.Controls.Add(this.labelControl2);
            this.MinimumSize = new System.Drawing.Size(587, 162);
            this.Name = "WareHouseForm";
            this.Text = "Anbar";
            this.Load += new System.EventHandler(this.WareHouse_Load);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtWareHouseName, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.lookUpEditWareHouseTypeId, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.lookUpParentCompany, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWareHouseTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpParentCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VwWareHouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtWareHouseName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditWareHouseTypeId;
        private Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter wareHouseTypeAdapter;
        private System.Windows.Forms.BindingSource wareHouseTypeBindingSource;
        private System.Windows.Forms.BindingSource VwWareHouseBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpParentCompany;
        private Data.WareHouseDataSetTableAdapters.WareHouseTableAdapter wareHouseTableAdapter;
        private Data.WareHouseDataSetTableAdapters.VwWareHouseTableAdapter vwWareHouseTableAdapter;
        private Data.WareHouseDataSet dataSet;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.WareHouseDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
    }
}