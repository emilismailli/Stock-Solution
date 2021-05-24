namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ReturnSaleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnSaleManager));
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.spDocumentSaleReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIncludeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentReturnSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentReturnSaleTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentReturnSaleTableAdapter();
            this.spDocumentSaleReturnTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spDocumentSaleReturnTableAdapter();
            this.colCashierName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentSaleReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentReturnSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDetail
            // 
            this.gridControlDetail.DataSource = this.spDocumentSaleReturnBindingSource;
            this.gridControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlDetail.Location = new System.Drawing.Point(0, 40);
            this.gridControlDetail.MainView = this.gridViewDetail;
            this.gridControlDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlDetail.MenuManager = this.barManager;
            this.gridControlDetail.Name = "gridControlDetail";
            this.gridControlDetail.Size = new System.Drawing.Size(1035, 485);
            this.gridControlDetail.TabIndex = 4;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // spDocumentSaleReturnBindingSource
            // 
            this.spDocumentSaleReturnBindingSource.DataMember = "spDocumentSaleReturn";
            this.spDocumentSaleReturnBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIncludeDate,
            this.colWareHouseName,
            this.colId,
            this.colCompanyName,
            this.colPaymentTypeName,
            this.colAmountWholeSale,
            this.colCustomerName,
            this.colDescription,
            this.colCashierName});
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsBehavior.ReadOnly = true;
            this.gridViewDetail.OptionsFind.AlwaysVisible = true;
            this.gridViewDetail.OptionsFind.ShowClearButton = false;
            this.gridViewDetail.OptionsFind.ShowCloseButton = false;
            this.gridViewDetail.OptionsFind.ShowFindButton = false;
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDetail.OptionsView.ShowFooter = true;
            this.gridViewDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDetail_FocusedRowChanged);
            // 
            // colIncludeDate
            // 
            this.colIncludeDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceCell.Options.UseFont = true;
            this.colIncludeDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceHeader.Options.UseFont = true;
            this.colIncludeDate.Caption = "Tarix";
            this.colIncludeDate.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colIncludeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.FieldName = "IncludeDate";
            this.colIncludeDate.GroupFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colIncludeDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeDate.Image")));
            this.colIncludeDate.Name = "colIncludeDate";
            this.colIncludeDate.Visible = true;
            this.colIncludeDate.VisibleIndex = 2;
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
            this.colWareHouseName.Name = "colWareHouseName";
            this.colWareHouseName.Visible = true;
            this.colWareHouseName.VisibleIndex = 4;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Image = ((System.Drawing.Image)(resources.GetObject("colId.Image")));
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceCell.Options.UseFont = true;
            this.colPaymentTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPaymentTypeName.Caption = "Ödəniş növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentTypeName.Image")));
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 6;
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountWholeSale", "Yekun={0:0.##}")});
            this.colAmountWholeSale.Visible = true;
            this.colAmountWholeSale.VisibleIndex = 7;
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
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
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
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 9;
            // 
            // vwDocumentReturnSaleBindingSource
            // 
            this.vwDocumentReturnSaleBindingSource.DataMember = "VwDocumentReturnSale";
            this.vwDocumentReturnSaleBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentReturnSaleTableAdapter
            // 
            this.vwDocumentReturnSaleTableAdapter.ClearBeforeFill = true;
            // 
            // spDocumentSaleReturnTableAdapter
            // 
            this.spDocumentSaleReturnTableAdapter.ClearBeforeFill = true;
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
            this.colCashierName.VisibleIndex = 8;
            // 
            // ReturnSaleManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlDetail);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReturnSaleManager";
            this.Size = new System.Drawing.Size(1035, 525);
            this.Controls.SetChildIndex(this.gridControlDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentSaleReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentReturnSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouseName;
        private System.Windows.Forms.BindingSource vwDocumentReturnSaleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private Data.AccountingDataSetTableAdapters.VwDocumentReturnSaleTableAdapter vwDocumentReturnSaleTableAdapter;
        private System.Windows.Forms.BindingSource spDocumentSaleReturnBindingSource;
        private Data.AccountingDataSetTableAdapters.spDocumentSaleReturnTableAdapter spDocumentSaleReturnTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCashierName;
    }
}
