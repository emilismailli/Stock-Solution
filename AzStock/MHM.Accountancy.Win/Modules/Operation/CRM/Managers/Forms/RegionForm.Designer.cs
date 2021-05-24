namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    partial class RegionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionForm));
            this.lookUpEditRegionType = new DevExpress.XtraEditors.LookUpEdit();
            this.vwRegionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRegionName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.vwRegionTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwRegionTableAdapter();
            this.vwRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwRegionTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwRegionTypeTableAdapter();
            this.treeListLookUpEditParent = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRegionType1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditRegionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(351, 117);
            this.btnAccept.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(445, 117);
            this.btnCancel.TabIndex = 6;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 124);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(165, 117);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(257, 117);
            this.btnPrintDocument.Visible = false;
            // 
            // lookUpEditRegionType
            // 
            this.lookUpEditRegionType.Location = new System.Drawing.Point(101, 37);
            this.lookUpEditRegionType.Name = "lookUpEditRegionType";
            this.lookUpEditRegionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditRegionType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Region Tipi", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditRegionType.Properties.DataSource = this.vwRegionTypeBindingSource;
            this.lookUpEditRegionType.Properties.DisplayMember = "Name";
            this.lookUpEditRegionType.Properties.NullText = "[Seçim Edilməyib]";
            this.lookUpEditRegionType.Properties.ValueMember = "Id";
            this.lookUpEditRegionType.Size = new System.Drawing.Size(431, 20);
            this.lookUpEditRegionType.TabIndex = 2;
            // 
            // vwRegionTypeBindingSource
            // 
            this.vwRegionTypeBindingSource.DataMember = "VwRegionType";
            this.vwRegionTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Üst Qrup";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(101, 88);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(431, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Qeyd";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Tipi";
            // 
            // txtRegionName
            // 
            this.txtRegionName.Location = new System.Drawing.Point(101, 12);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(431, 20);
            this.txtRegionName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Region adı";
            // 
            // vwRegionTableAdapter
            // 
            this.vwRegionTableAdapter.ClearBeforeFill = true;
            // 
            // vwRegionBindingSource
            // 
            this.vwRegionBindingSource.DataMember = "VwRegion";
            this.vwRegionBindingSource.DataSource = this.dataSet;
            // 
            // vwRegionTypeTableAdapter
            // 
            this.vwRegionTypeTableAdapter.ClearBeforeFill = true;
            // 
            // treeListLookUpEditParent
            // 
            this.treeListLookUpEditParent.Location = new System.Drawing.Point(101, 63);
            this.treeListLookUpEditParent.Name = "treeListLookUpEditParent";
            this.treeListLookUpEditParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEditParent.Properties.DataSource = this.vwRegionBindingSource;
            this.treeListLookUpEditParent.Properties.DisplayMember = "Name";
            this.treeListLookUpEditParent.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.treeListLookUpEditParent.Properties.ValueMember = "Id";
            this.treeListLookUpEditParent.Size = new System.Drawing.Size(431, 20);
            this.treeListLookUpEditParent.TabIndex = 3;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName1,
            this.colRegionType1,
            this.colDescription1});
            this.treeListLookUpEdit1TreeList.DataSource = this.vwRegionBindingSource;
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 77;
            // 
            // colRegionType1
            // 
            this.colRegionType1.FieldName = "RegionType";
            this.colRegionType1.Name = "colRegionType1";
            this.colRegionType1.Visible = true;
            this.colRegionType1.VisibleIndex = 1;
            this.colRegionType1.Width = 77;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 2;
            this.colDescription1.Width = 77;
            // 
            // RegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 156);
            this.Controls.Add(this.treeListLookUpEditParent);
            this.Controls.Add(this.lookUpEditRegionType);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.labelControl2);
            this.Name = "RegionForm";
            this.Text = "Regionlar";
            this.Load += new System.EventHandler(this.RegionForm_Load);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtRegionName, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.lookUpEditRegionType, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.treeListLookUpEditParent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditRegionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditRegionType;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRegionName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Data.CRMDataSetTableAdapters.VwRegionTableAdapter vwRegionTableAdapter;
        private System.Windows.Forms.BindingSource vwRegionBindingSource;
        private Data.CRMDataSet dataSet;
        private System.Windows.Forms.BindingSource vwRegionTypeBindingSource;
        private Data.CRMDataSetTableAdapters.VwRegionTypeTableAdapter vwRegionTypeTableAdapter;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEditParent;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRegionType1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription1;
    }
}