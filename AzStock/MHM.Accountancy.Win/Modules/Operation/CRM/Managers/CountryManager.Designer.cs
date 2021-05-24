namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class CountryManager
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
            this.gridControlCountry = new DevExpress.XtraGrid.GridControl();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewCountry = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countryTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCountry
            // 
            this.gridControlCountry.DataSource = this.countryBindingSource;
            this.gridControlCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCountry.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlCountry.Location = new System.Drawing.Point(0, 42);
            this.gridControlCountry.MainView = this.gridViewCountry;
            this.gridControlCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlCountry.MenuManager = this.barManager;
            this.gridControlCountry.Name = "gridControlCountry";
            this.gridControlCountry.Size = new System.Drawing.Size(1809, 724);
            this.gridControlCountry.TabIndex = 4;
            this.gridControlCountry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCountry});
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewCountry
            // 
            this.gridViewCountry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCode,
            this.colDescription});
            this.gridViewCountry.GridControl = this.gridControlCountry;
            this.gridViewCountry.Name = "gridViewCountry";
            this.gridViewCountry.OptionsBehavior.ReadOnly = true;
            this.gridViewCountry.OptionsFind.AlwaysVisible = true;
            this.gridViewCountry.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewCountry.OptionsFind.SearchInPreview = true;
            this.gridViewCountry.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            // 
            // colName
            // 
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 100;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 300;
            // 
            // colCode
            // 
            this.colCode.Caption = "Kodu";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 100;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 300;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 588;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // CountryManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCountry);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CountryManager";
            this.Size = new System.Drawing.Size(1809, 766);
            this.Controls.SetChildIndex(this.gridControlCountry, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCountry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCountry;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.CRMDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
    }
}
