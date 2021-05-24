namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class DoseManager
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
            this.gridControlDose = new DevExpress.XtraGrid.GridControl();
            this.vwDoseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewDose = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDoseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwDoseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDose)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDose
            // 
            this.gridControlDose.DataSource = this.vwDoseBindingSource;
            this.gridControlDose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDose.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlDose.Location = new System.Drawing.Point(0, 42);
            this.gridControlDose.MainView = this.gridViewDose;
            this.gridControlDose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlDose.MenuManager = this.barManager;
            this.gridControlDose.Name = "gridControlDose";
            this.gridControlDose.Size = new System.Drawing.Size(1848, 1001);
            this.gridControlDose.TabIndex = 4;
            this.gridControlDose.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDose});
            // 
            // vwDoseBindingSource
            // 
            this.vwDoseBindingSource.DataMember = "VwDose";
            this.vwDoseBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewDose
            // 
            this.gridViewDose.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewDose.GridControl = this.gridControlDose;
            this.gridViewDose.Name = "gridViewDose";
            this.gridViewDose.OptionsBehavior.ReadOnly = true;
            this.gridViewDose.OptionsFind.AlwaysVisible = true;
            this.gridViewDose.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewDose.OptionsFind.SearchInPreview = true;
            this.gridViewDose.OptionsSelection.MultiSelect = true;
            // 
            // colName
            // 
            this.colName.Caption = "Doza adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.CustomizationCaption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // vwDoseTableAdapter
            // 
            this.vwDoseTableAdapter.ClearBeforeFill = true;
            // 
            // DoseManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlDose);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DoseManager";
            this.Size = new System.Drawing.Size(1848, 1043);
            this.Controls.SetChildIndex(this.gridControlDose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDose;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDose;
        private System.Windows.Forms.BindingSource vwDoseBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.CRMDataSetTableAdapters.VwDoseTableAdapter vwDoseTableAdapter;
    }
}
