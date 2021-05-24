namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class OperationTypeManager
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
            this.gridControlOperationType = new DevExpress.XtraGrid.GridControl();
            this.operationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewOperationType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operationTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.OperationTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperationType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOperationType
            // 
            this.gridControlOperationType.DataSource = this.operationTypeBindingSource;
            this.gridControlOperationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOperationType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlOperationType.Location = new System.Drawing.Point(0, 42);
            this.gridControlOperationType.MainView = this.gridViewOperationType;
            this.gridControlOperationType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlOperationType.MenuManager = this.barManager;
            this.gridControlOperationType.Name = "gridControlOperationType";
            this.gridControlOperationType.Size = new System.Drawing.Size(1300, 779);
            this.gridControlOperationType.TabIndex = 4;
            this.gridControlOperationType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOperationType});
            // 
            // operationTypeBindingSource
            // 
            this.operationTypeBindingSource.DataMember = "OperationType";
            this.operationTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewOperationType
            // 
            this.gridViewOperationType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewOperationType.GridControl = this.gridControlOperationType;
            this.gridViewOperationType.Name = "gridViewOperationType";
            this.gridViewOperationType.OptionsBehavior.ReadOnly = true;
            this.gridViewOperationType.OptionsFind.AlwaysVisible = true;
            this.gridViewOperationType.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewOperationType.OptionsFind.SearchInPreview = true;
            this.gridViewOperationType.OptionsSelection.MultiSelect = true;
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
            // operationTypeTableAdapter
            // 
            this.operationTypeTableAdapter.ClearBeforeFill = true;
            // 
            // OperationTypeManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlOperationType);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "OperationTypeManager";
            this.Size = new System.Drawing.Size(1300, 821);
            this.Controls.SetChildIndex(this.gridControlOperationType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperationType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOperationType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOperationType;
        private System.Windows.Forms.BindingSource operationTypeBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.CRMDataSetTableAdapters.OperationTypeTableAdapter operationTypeTableAdapter;
    }
}
