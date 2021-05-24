namespace MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers
{
    partial class WareHouseType
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
            this.gridControlWareHouseType = new DevExpress.XtraGrid.GridControl();
            this.wareHouseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSet();
            this.gridViewWareHouseType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wareHouseTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWareHouseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWareHouseType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlWareHouseType
            // 
            this.gridControlWareHouseType.DataSource = this.wareHouseTypeBindingSource;
            this.gridControlWareHouseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWareHouseType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlWareHouseType.Location = new System.Drawing.Point(0, 42);
            this.gridControlWareHouseType.MainView = this.gridViewWareHouseType;
            this.gridControlWareHouseType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlWareHouseType.MenuManager = this.barManager;
            this.gridControlWareHouseType.Name = "gridControlWareHouseType";
            this.gridControlWareHouseType.Size = new System.Drawing.Size(1440, 728);
            this.gridControlWareHouseType.TabIndex = 4;
            this.gridControlWareHouseType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWareHouseType});
            // 
            // wareHouseTypeBindingSource
            // 
            this.wareHouseTypeBindingSource.DataMember = "WareHouseType";
            this.wareHouseTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "WareHouseDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewWareHouseType
            // 
            this.gridViewWareHouseType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewWareHouseType.GridControl = this.gridControlWareHouseType;
            this.gridViewWareHouseType.Name = "gridViewWareHouseType";
            this.gridViewWareHouseType.OptionsBehavior.ReadOnly = true;
            this.gridViewWareHouseType.OptionsFind.AlwaysVisible = true;
            this.gridViewWareHouseType.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewWareHouseType.OptionsFind.ShowClearButton = false;
            this.gridViewWareHouseType.OptionsFind.ShowCloseButton = false;
            this.gridViewWareHouseType.OptionsFind.ShowFindButton = false;
            this.gridViewWareHouseType.OptionsSelection.MultiSelect = true;
            this.gridViewWareHouseType.OptionsView.ShowGroupPanel = false;
            this.gridViewWareHouseType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Ad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // wareHouseTypeTableAdapter
            // 
            this.wareHouseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // WareHouseType
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlWareHouseType);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WareHouseType";
            this.Size = new System.Drawing.Size(1440, 770);
            this.Controls.SetChildIndex(this.gridControlWareHouseType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWareHouseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWareHouseType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlWareHouseType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWareHouseType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.BindingSource wareHouseTypeBindingSource;
        private Data.WareHouseDataSet dataSet;
        private Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter wareHouseTypeTableAdapter;
    }
}
