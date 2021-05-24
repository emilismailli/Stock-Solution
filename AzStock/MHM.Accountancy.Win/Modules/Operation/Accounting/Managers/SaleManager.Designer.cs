namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class SaleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleManager));
            this.gridControlSale = new DevExpress.XtraGrid.GridControl();
            this.spDocumentSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewSale = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeCustomerContractId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter();
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            this.spDocumentSaleTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spDocumentSaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSale
            // 
            this.gridControlSale.DataSource = this.spDocumentSaleBindingSource;
            this.gridControlSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSale.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlSale.Location = new System.Drawing.Point(0, 42);
            this.gridControlSale.MainView = this.gridViewSale;
            this.gridControlSale.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlSale.MenuManager = this.barManager;
            this.gridControlSale.Name = "gridControlSale";
            this.gridControlSale.Size = new System.Drawing.Size(1177, 657);
            this.gridControlSale.TabIndex = 4;
            this.gridControlSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSale});
            // 
            // spDocumentSaleBindingSource
            // 
            this.spDocumentSaleBindingSource.DataMember = "spDocumentSale";
            this.spDocumentSaleBindingSource.DataSource = this.dataSet;
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
            this.colCustomerName,
            this.colPaymentDate,
            this.colPaymentTypeName,
            this.colAmountWholeSale,
            this.colCashierName,
            this.colDiscountPrice,
            this.colDescription});
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
            this.gridViewSale.OptionsView.ShowFooter = true;
            this.gridViewSale.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSale_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "Nömrəsi";
            this.colId.DisplayFormat.FormatString = "{0:000000}";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.FieldName = "Id";
            this.colId.GroupFormat.FormatString = "{0:000000}";
            this.colId.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.Image = ((System.Drawing.Image)(resources.GetObject("colId.Image")));
            this.colId.MinWidth = 30;
            this.colId.Name = "colId";
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Id", "Yekun")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 66;
            // 
            // colIncludeDate
            // 
            this.colIncludeDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceCell.Options.UseFont = true;
            this.colIncludeDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceHeader.Options.UseFont = true;
            this.colIncludeDate.Caption = "Satış Tarixi";
            this.colIncludeDate.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm:ss";
            this.colIncludeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.FieldName = "IncludeDate";
            this.colIncludeDate.GroupFormat.FormatString = "dd:MM:yyyy  hh:mm:ss";
            this.colIncludeDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeDate.Image")));
            this.colIncludeDate.MinWidth = 30;
            this.colIncludeDate.Name = "colIncludeDate";
            this.colIncludeDate.Visible = true;
            this.colIncludeDate.VisibleIndex = 2;
            this.colIncludeDate.Width = 137;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Əməliyyatçı Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.MinWidth = 30;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 4;
            this.colCompanyName.Width = 120;
            // 
            // colWareHouseName
            // 
            this.colWareHouseName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWareHouseName.AppearanceCell.Options.UseFont = true;
            this.colWareHouseName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWareHouseName.AppearanceHeader.Options.UseFont = true;
            this.colWareHouseName.Caption = "Anbar";
            this.colWareHouseName.FieldName = "WareHouseName";
            this.colWareHouseName.Image = ((System.Drawing.Image)(resources.GetObject("colWareHouseName.Image")));
            this.colWareHouseName.MinWidth = 30;
            this.colWareHouseName.Name = "colWareHouseName";
            this.colWareHouseName.Visible = true;
            this.colWareHouseName.VisibleIndex = 5;
            this.colWareHouseName.Width = 102;
            // 
            // colIncludeCustomerContractId
            // 
            this.colIncludeCustomerContractId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeCustomerContractId.AppearanceCell.Options.UseFont = true;
            this.colIncludeCustomerContractId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeCustomerContractId.AppearanceHeader.Options.UseFont = true;
            this.colIncludeCustomerContractId.Caption = " Müqavilə №";
            this.colIncludeCustomerContractId.FieldName = "ContractId";
            this.colIncludeCustomerContractId.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeCustomerContractId.Image")));
            this.colIncludeCustomerContractId.MinWidth = 30;
            this.colIncludeCustomerContractId.Name = "colIncludeCustomerContractId";
            this.colIncludeCustomerContractId.Visible = true;
            this.colIncludeCustomerContractId.VisibleIndex = 7;
            this.colIncludeCustomerContractId.Width = 61;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceHeader.Options.UseFont = true;
            this.colCustomerName.Caption = "Müştəri";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerName.Image")));
            this.colCustomerName.MinWidth = 30;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 6;
            this.colCustomerName.Width = 88;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentDate.AppearanceCell.Options.UseFont = true;
            this.colPaymentDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentDate.AppearanceHeader.Options.UseFont = true;
            this.colPaymentDate.Caption = "Ödəniş Tarixi";
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentDate.Image")));
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 3;
            this.colPaymentDate.Width = 124;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceCell.Options.UseFont = true;
            this.colPaymentTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPaymentTypeName.Caption = "Ödəniş Növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentTypeName.Image")));
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 8;
            this.colPaymentTypeName.Width = 47;
            // 
            // colAmountWholeSale
            // 
            this.colAmountWholeSale.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceCell.Options.UseFont = true;
            this.colAmountWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colAmountWholeSale.Caption = "Məbləğ";
            this.colAmountWholeSale.DisplayFormat.FormatString = "{0:0.##}";
            this.colAmountWholeSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountWholeSale.FieldName = "AmountWholeSale";
            this.colAmountWholeSale.GroupFormat.FormatString = "{0:0.##}";
            this.colAmountWholeSale.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountWholeSale.Image = ((System.Drawing.Image)(resources.GetObject("colAmountWholeSale.Image")));
            this.colAmountWholeSale.Name = "colAmountWholeSale";
            this.colAmountWholeSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountWholeSale", "{0:0.##}")});
            this.colAmountWholeSale.Visible = true;
            this.colAmountWholeSale.VisibleIndex = 10;
            this.colAmountWholeSale.Width = 84;
            // 
            // colCashierName
            // 
            this.colCashierName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashierName.AppearanceCell.Options.UseFont = true;
            this.colCashierName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashierName.AppearanceHeader.Options.UseFont = true;
            this.colCashierName.Caption = "Satıcı";
            this.colCashierName.FieldName = "CashierName";
            this.colCashierName.Image = ((System.Drawing.Image)(resources.GetObject("colCashierName.Image")));
            this.colCashierName.Name = "colCashierName";
            this.colCashierName.Visible = true;
            this.colCashierName.VisibleIndex = 9;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDiscountPrice.AppearanceCell.Options.UseFont = true;
            this.colDiscountPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDiscountPrice.AppearanceHeader.Options.UseFont = true;
            this.colDiscountPrice.Caption = "Endirim";
            this.colDiscountPrice.DisplayFormat.FormatString = "{0:0.##}";
            this.colDiscountPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.GroupFormat.FormatString = "{0:0.##}";
            this.colDiscountPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDiscountPrice.Image = ((System.Drawing.Image)(resources.GetObject("colDiscountPrice.Image")));
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiscountPrice", "{0:0.##}")});
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 11;
            this.colDiscountPrice.Width = 106;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Image = ((System.Drawing.Image)(resources.GetObject("colDescription.Image")));
            this.colDescription.MinWidth = 70;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 12;
            this.colDescription.Width = 149;
            // 
            // vwDocumentBindingSource
            // 
            this.vwDocumentBindingSource.DataMember = "VwDocument";
            this.vwDocumentBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentTableAdapter
            // 
            this.vwDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // spDocumentSaleTableAdapter
            // 
            this.spDocumentSaleTableAdapter.ClearBeforeFill = true;
            // 
            // SaleManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlSale);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SaleManager";
            this.Size = new System.Drawing.Size(1177, 699);
            this.Controls.SetChildIndex(this.gridControlSale, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource vwDocumentBindingSource;
        private Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter vwDocumentTableAdapter;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private System.Windows.Forms.BindingSource spDocumentSaleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountWholeSale;
        private Data.AccountingDataSetTableAdapters.spDocumentSaleTableAdapter spDocumentSaleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCashierName;
    }
}
