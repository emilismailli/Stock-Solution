namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ContractTypeManager
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
            this.gridControlContractType = new DevExpress.XtraGrid.GridControl();
            this.vwContractTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewContractType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwContractTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwContractTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContractType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContractType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlContractType
            // 
            this.gridControlContractType.DataSource = this.vwContractTypeBindingSource;
            this.gridControlContractType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlContractType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlContractType.Location = new System.Drawing.Point(0, 42);
            this.gridControlContractType.MainView = this.gridViewContractType;
            this.gridControlContractType.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlContractType.MenuManager = this.barManager;
            this.gridControlContractType.Name = "gridControlContractType";
            this.gridControlContractType.Size = new System.Drawing.Size(1654, 998);
            this.gridControlContractType.TabIndex = 4;
            this.gridControlContractType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContractType});
            // 
            // vwContractTypeBindingSource
            // 
            this.vwContractTypeBindingSource.DataMember = "VwContractType";
            this.vwContractTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewContractType
            // 
            this.gridViewContractType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewContractType.GridControl = this.gridControlContractType;
            this.gridViewContractType.Name = "gridViewContractType";
            this.gridViewContractType.OptionsBehavior.ReadOnly = true;
            this.gridViewContractType.OptionsFind.AlwaysVisible = true;
            this.gridViewContractType.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewContractType.OptionsFind.SearchInPreview = true;
            this.gridViewContractType.OptionsFind.ShowClearButton = false;
            this.gridViewContractType.OptionsFind.ShowCloseButton = false;
            this.gridViewContractType.OptionsFind.ShowFindButton = false;
            this.gridViewContractType.OptionsSelection.MultiSelect = true;
            this.gridViewContractType.OptionsView.ShowGroupPanel = false;
            this.gridViewContractType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewContractType_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Müqavilə növü";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // vwContractTypeTableAdapter
            // 
            this.vwContractTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ContractTypeManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlContractType);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ContractTypeManager";
            this.Size = new System.Drawing.Size(1654, 1040);
            this.Controls.SetChildIndex(this.gridControlContractType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContractType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContractType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlContractType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContractType;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.BindingSource vwContractTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwContractTypeTableAdapter vwContractTypeTableAdapter;
    }
}
