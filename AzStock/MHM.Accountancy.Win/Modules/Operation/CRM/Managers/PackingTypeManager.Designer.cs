namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class PackingTypeManager
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
            this.gridControlPackingType = new DevExpress.XtraGrid.GridControl();
            this.vwPackingTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewPackingType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwPackingTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwPackingTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPackingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPackingTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackingType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlPackingType
            // 
            this.gridControlPackingType.DataSource = this.vwPackingTypeBindingSource;
            this.gridControlPackingType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPackingType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlPackingType.Location = new System.Drawing.Point(0, 42);
            this.gridControlPackingType.MainView = this.gridViewPackingType;
            this.gridControlPackingType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlPackingType.MenuManager = this.barManager;
            this.gridControlPackingType.Name = "gridControlPackingType";
            this.gridControlPackingType.Size = new System.Drawing.Size(1612, 846);
            this.gridControlPackingType.TabIndex = 4;
            this.gridControlPackingType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPackingType});
            // 
            // vwPackingTypeBindingSource
            // 
            this.vwPackingTypeBindingSource.DataMember = "VwPackingType";
            this.vwPackingTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewPackingType
            // 
            this.gridViewPackingType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewPackingType.GridControl = this.gridControlPackingType;
            this.gridViewPackingType.Name = "gridViewPackingType";
            this.gridViewPackingType.OptionsBehavior.ReadOnly = true;
            this.gridViewPackingType.OptionsFind.AlwaysVisible = true;
            this.gridViewPackingType.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewPackingType.OptionsFind.SearchInPreview = true;
            this.gridViewPackingType.OptionsSelection.MultiSelect = true;
            // 
            // colName
            // 
            this.colName.Caption = "Paket Növü";
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
            // vwPackingTypeTableAdapter
            // 
            this.vwPackingTypeTableAdapter.ClearBeforeFill = true;
            // 
            // PackingTypeManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlPackingType);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PackingTypeManager";
            this.Size = new System.Drawing.Size(1612, 888);
            this.Controls.SetChildIndex(this.gridControlPackingType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPackingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPackingTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPackingType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPackingType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPackingType;
        private System.Windows.Forms.BindingSource vwPackingTypeBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.CRMDataSetTableAdapters.VwPackingTypeTableAdapter vwPackingTypeTableAdapter;
    }
}
