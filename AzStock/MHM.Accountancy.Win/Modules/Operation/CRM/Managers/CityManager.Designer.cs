namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class CityManager
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
            this.gridControlCity = new DevExpress.XtraGrid.GridControl();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewCity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.CityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCity)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCity
            // 
            this.gridControlCity.DataSource = this.cityBindingSource;
            this.gridControlCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCity.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlCity.Location = new System.Drawing.Point(0, 42);
            this.gridControlCity.MainView = this.gridViewCity;
            this.gridControlCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlCity.MenuManager = this.barManager;
            this.gridControlCity.Name = "gridControlCity";
            this.gridControlCity.Size = new System.Drawing.Size(1676, 840);
            this.gridControlCity.TabIndex = 4;
            this.gridControlCity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCity});
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewCity
            // 
            this.gridViewCity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewCity.GridControl = this.gridControlCity;
            this.gridViewCity.Name = "gridViewCity";
            this.gridViewCity.OptionsBehavior.ReadOnly = true;
            this.gridViewCity.OptionsFind.AlwaysVisible = true;
            this.gridViewCity.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewCity.OptionsFind.SearchInPreview = true;
            this.gridViewCity.OptionsSelection.MultiSelect = true;
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
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // CityManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCity);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CityManager";
            this.Size = new System.Drawing.Size(1676, 882);
            this.Controls.SetChildIndex(this.gridControlCity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCity;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCity;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.CRMDataSetTableAdapters.CityTableAdapter cityTableAdapter;
    }
}
