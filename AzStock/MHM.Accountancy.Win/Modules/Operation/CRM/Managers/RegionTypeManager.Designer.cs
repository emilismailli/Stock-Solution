namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class RegionTypeManager
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
            this.gridControlRegionType = new DevExpress.XtraGrid.GridControl();
            this.vwRegionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewRegionType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwRegionTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwRegionTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegionType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRegionType
            // 
            this.gridControlRegionType.DataSource = this.vwRegionTypeBindingSource;
            this.gridControlRegionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRegionType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRegionType.Location = new System.Drawing.Point(0, 42);
            this.gridControlRegionType.MainView = this.gridViewRegionType;
            this.gridControlRegionType.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRegionType.MenuManager = this.barManager;
            this.gridControlRegionType.Name = "gridControlRegionType";
            this.gridControlRegionType.Size = new System.Drawing.Size(1494, 944);
            this.gridControlRegionType.TabIndex = 4;
            this.gridControlRegionType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRegionType});
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
            // gridViewRegionType
            // 
            this.gridViewRegionType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewRegionType.GridControl = this.gridControlRegionType;
            this.gridViewRegionType.Name = "gridViewRegionType";
            this.gridViewRegionType.OptionsBehavior.ReadOnly = true;
            this.gridViewRegionType.OptionsFind.AlwaysVisible = true;
            this.gridViewRegionType.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewRegionType.OptionsFind.SearchInPreview = true;
            this.gridViewRegionType.OptionsSelection.MultiSelect = true;
            // 
            // colName
            // 
            this.colName.Caption = "Ad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // vwRegionTypeTableAdapter
            // 
            this.vwRegionTypeTableAdapter.ClearBeforeFill = true;
            // 
            // RegionTypeManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlRegionType);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegionTypeManager";
            this.Size = new System.Drawing.Size(1494, 986);
            this.Controls.SetChildIndex(this.gridControlRegionType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegionType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRegionType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRegionType;
        private System.Windows.Forms.BindingSource vwRegionTypeBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.CRMDataSetTableAdapters.VwRegionTypeTableAdapter vwRegionTypeTableAdapter;
    }
}
