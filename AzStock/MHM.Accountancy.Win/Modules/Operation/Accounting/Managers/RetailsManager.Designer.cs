namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class RetailsManager
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailsManager));
            this.gridControlSale = new DevExpress.XtraGrid.GridControl();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewSale = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeCustomerContractId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            this.vwDocumentRetailsSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentRetailsSaleTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentRetailsSaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentRetailsSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSale
            // 
            this.gridControlSale.DataSource = this.vwDocumentRetailsSaleBindingSource;
            this.gridControlSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSale.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode2.RelationName = "Level1";
            this.gridControlSale.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControlSale.Location = new System.Drawing.Point(0, 40);
            this.gridControlSale.MainView = this.gridViewSale;
            this.gridControlSale.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlSale.MenuManager = this.barManager;
            this.gridControlSale.Name = "gridControlSale";
            this.gridControlSale.Size = new System.Drawing.Size(1740, 854);
            this.gridControlSale.TabIndex = 4;
            this.gridControlSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSale});
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewSale
            // 
            this.gridViewSale.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIncludeDate,
            this.colCompanyName,
            this.colWareHouseName,
            this.colIncludeCustomerContractId,
            this.colCustomerName});
            this.gridViewSale.GridControl = this.gridControlSale;
            this.gridViewSale.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewSale.Name = "gridViewSale";
            this.gridViewSale.OptionsBehavior.ReadOnly = true;
            this.gridViewSale.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSale.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridViewSale.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridViewSale.OptionsFind.AlwaysVisible = true;
            this.gridViewSale.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewSale.OptionsFind.ShowClearButton = false;
            this.gridViewSale.OptionsFind.ShowCloseButton = false;
            this.gridViewSale.OptionsFind.ShowFindButton = false;
            this.gridViewSale.OptionsSelection.MultiSelect = true;
            this.gridViewSale.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewSale.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSale.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSale_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "Nömrəsi";
            this.colId.DisplayFormat.FormatString = "{0:000000}";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.FieldName = "Id";
            this.colId.GroupFormat.FormatString = "{0:000000}";
            this.colId.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.Image = ((System.Drawing.Image)(resources.GetObject("colId.Image")));
            this.colId.MinWidth = 50;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 100;
            // 
            // colIncludeDate
            // 
            this.colIncludeDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceCell.Options.UseFont = true;
            this.colIncludeDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceHeader.Options.UseFont = true;
            this.colIncludeDate.Caption = "Tarix";
            this.colIncludeDate.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm:ss";
            this.colIncludeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.FieldName = "IncludeDate";
            this.colIncludeDate.GroupFormat.FormatString = "dd:MM:yyyy  hh:mm:ss";
            this.colIncludeDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeDate.Image")));
            this.colIncludeDate.Name = "colIncludeDate";
            this.colIncludeDate.Visible = true;
            this.colIncludeDate.VisibleIndex = 2;
            this.colIncludeDate.Width = 207;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Əməliyyatçı Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            this.colCompanyName.Width = 207;
            // 
            // colWareHouseName
            // 
            this.colWareHouseName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWareHouseName.AppearanceCell.Options.UseFont = true;
            this.colWareHouseName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWareHouseName.AppearanceHeader.Options.UseFont = true;
            this.colWareHouseName.Caption = "Anbar";
            this.colWareHouseName.FieldName = "WareHouseName";
            this.colWareHouseName.Image = ((System.Drawing.Image)(resources.GetObject("colWareHouseName.Image")));
            this.colWareHouseName.Name = "colWareHouseName";
            this.colWareHouseName.Visible = true;
            this.colWareHouseName.VisibleIndex = 6;
            this.colWareHouseName.Width = 217;
            // 
            // colIncludeCustomerContractId
            // 
            this.colIncludeCustomerContractId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeCustomerContractId.AppearanceCell.Options.UseFont = true;
            this.colIncludeCustomerContractId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeCustomerContractId.AppearanceHeader.Options.UseFont = true;
            this.colIncludeCustomerContractId.Caption = " Müqavilə №";
            this.colIncludeCustomerContractId.FieldName = "ContractId";
            this.colIncludeCustomerContractId.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeCustomerContractId.Image")));
            this.colIncludeCustomerContractId.Name = "colIncludeCustomerContractId";
            this.colIncludeCustomerContractId.Visible = true;
            this.colIncludeCustomerContractId.VisibleIndex = 5;
            this.colIncludeCustomerContractId.Width = 207;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceHeader.Options.UseFont = true;
            this.colCustomerName.Caption = "Müştəri";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerName.Image")));
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 4;
            this.colCustomerName.Width = 207;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // vwDocumentRetailsSaleBindingSource
            // 
            this.vwDocumentRetailsSaleBindingSource.DataMember = "VwDocumentRetailsSale";
            this.vwDocumentRetailsSaleBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentRetailsSaleTableAdapter
            // 
            this.vwDocumentRetailsSaleTableAdapter.ClearBeforeFill = true;
            // 
            // RetailsManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlSale);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RetailsManager";
            this.Size = new System.Drawing.Size(1740, 894);
            this.Controls.SetChildIndex(this.gridControlSale, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentRetailsSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSale;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeCustomerContractId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
        private System.Windows.Forms.BindingSource vwDocumentRetailsSaleBindingSource;
        private Data.AccountingDataSetTableAdapters.VwDocumentRetailsSaleTableAdapter vwDocumentRetailsSaleTableAdapter;
    }
}
