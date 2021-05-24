namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class UnitManager
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
            this.gridControlUnit = new DevExpress.XtraGrid.GridControl();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwUnitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUnit
            // 
            this.gridControlUnit.DataSource = this.vwUnitBindingSource;
            this.gridControlUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUnit.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlUnit.Location = new System.Drawing.Point(0, 42);
            this.gridControlUnit.MainView = this.gridViewUnit;
            this.gridControlUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlUnit.MenuManager = this.barManager;
            this.gridControlUnit.Name = "gridControlUnit";
            this.gridControlUnit.Size = new System.Drawing.Size(1874, 851);
            this.gridControlUnit.TabIndex = 4;
            this.gridControlUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUnit});
            // 
            // vwUnitBindingSource
            // 
            this.vwUnitBindingSource.DataMember = "VwUnit";
            this.vwUnitBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewUnit
            // 
            this.gridViewUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription,
            this.colIsActive});
            this.gridViewUnit.GridControl = this.gridControlUnit;
            this.gridViewUnit.Name = "gridViewUnit";
            this.gridViewUnit.OptionsBehavior.ReadOnly = true;
            this.gridViewUnit.OptionsFind.AlwaysVisible = true;
            this.gridViewUnit.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewUnit.OptionsFind.SearchInPreview = true;
            this.gridViewUnit.OptionsSelection.MultiSelect = true;
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
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
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktivlik";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            // 
            // vwUnitTableAdapter
            // 
            this.vwUnitTableAdapter.ClearBeforeFill = true;
            // 
            // UnitManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlUnit);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UnitManager";
            this.Size = new System.Drawing.Size(1874, 893);
            this.Controls.SetChildIndex(this.gridControlUnit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUnit;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private Data.CRMDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
    }
}
