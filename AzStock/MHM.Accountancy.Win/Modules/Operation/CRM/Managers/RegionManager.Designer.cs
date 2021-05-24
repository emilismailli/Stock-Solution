namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class RegionManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeListRegion = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.vwRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.vwRegionTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwRegionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeListRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListRegion
            // 
            this.treeListRegion.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treeListRegion.DataSource = this.vwRegionBindingSource;
            this.treeListRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListRegion.KeyFieldName = "Id";
            this.treeListRegion.Location = new System.Drawing.Point(0, 40);
            this.treeListRegion.Margin = new System.Windows.Forms.Padding(4);
            this.treeListRegion.Name = "treeListRegion";
            this.treeListRegion.ParentFieldName = "ParentId";
            this.treeListRegion.Size = new System.Drawing.Size(1373, 977);
            this.treeListRegion.TabIndex = 4;
            // 
            // colName
            // 
            this.colName.Caption = "Ad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 54;
            // 
            // vwRegionBindingSource
            // 
            this.vwRegionBindingSource.DataMember = "VwRegion";
            this.vwRegionBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwRegionTableAdapter
            // 
            this.vwRegionTableAdapter.ClearBeforeFill = true;
            // 
            // RegionManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListRegion);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RegionManager";
            this.Size = new System.Drawing.Size(1373, 1017);
            this.Controls.SetChildIndex(this.treeListRegion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.treeListRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListRegion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private System.Windows.Forms.BindingSource vwRegionBindingSource;
        private Data.CRMDataSet dataSet;
        private Data.CRMDataSetTableAdapters.VwRegionTableAdapter vwRegionTableAdapter;
    }
}
