namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class DeficitStockManager
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.vwDeficitGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBenefist = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenefitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAmount = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDeficitGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDeficitGoodStockTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl10 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl11 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl12 = new DevExpress.XtraBars.BarDockControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDeficitGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlStock);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 64);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1327, 611);
            this.groupControl1.TabIndex = 4;
            // 
            // gridControlStock
            // 
            this.gridControlStock.DataSource = this.vwDeficitGoodStockBindingSource;
            this.gridControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStock.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gridControlStock.Location = new System.Drawing.Point(2, 20);
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gridControlStock.MenuManager = this.barManager;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoAmount});
            this.gridControlStock.Size = new System.Drawing.Size(1323, 589);
            this.gridControlStock.TabIndex = 0;
            this.gridControlStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStock});
            // 
            // vwDeficitGoodStockBindingSource
            // 
            this.vwDeficitGoodStockBindingSource.DataMember = "VwDeficitGoodStock";
            this.vwDeficitGoodStockBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewStock
            // 
            this.gridViewStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBenefist,
            this.colBenefitAmount,
            this.colFullGoodName,
            this.colQuantity,
            this.colSeries,
            this.colWarehouse,
            this.colGoodTypeName,
            this.colBarcode,
            this.colManufacturerCompanyName,
            this.colRegionName,
            this.colDescription,
            this.colTotal,
            this.colPriceBuy,
            this.colTotalWholeSale,
            this.colPriceWholeSale});
            this.gridViewStock.GridControl = this.gridControlStock;
            this.gridViewStock.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkib atın..";
            this.gridViewStock.Name = "gridViewStock";
            this.gridViewStock.OptionsBehavior.ReadOnly = true;
            this.gridViewStock.OptionsFind.AlwaysVisible = true;
            this.gridViewStock.OptionsFind.FindNullPrompt = "Axtarış sözünü daxl edin...";
            this.gridViewStock.OptionsFind.SearchInPreview = true;
            this.gridViewStock.OptionsSelection.MultiSelect = true;
            this.gridViewStock.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewStock.OptionsView.ShowAutoFilterRow = true;
            this.gridViewStock.OptionsView.ShowFooter = true;
            this.gridViewStock.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewStock_FocusedRowChanged);
            // 
            // colBenefist
            // 
            this.colBenefist.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefist.AppearanceCell.Options.UseFont = true;
            this.colBenefist.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefist.AppearanceHeader.Options.UseFont = true;
            this.colBenefist.Caption = "Qazanc";
            this.colBenefist.DisplayFormat.FormatString = "{0:0.##}";
            this.colBenefist.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefist.FieldName = "colBenefist";
            this.colBenefist.GroupFormat.FormatString = "{0:0.##}";
            this.colBenefist.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefist.Name = "colBenefist";
            this.colBenefist.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBenefist", "{0:0.##}")});
            this.colBenefist.UnboundExpression = "[PriceWholeSale] - [PriceBuy]";
            this.colBenefist.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBenefist.Visible = true;
            this.colBenefist.VisibleIndex = 9;
            // 
            // colBenefitAmount
            // 
            this.colBenefitAmount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefitAmount.AppearanceCell.Options.UseFont = true;
            this.colBenefitAmount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefitAmount.AppearanceHeader.Options.UseFont = true;
            this.colBenefitAmount.Caption = "Qazanc Məbləği";
            this.colBenefitAmount.DisplayFormat.FormatString = "{0:0.##}";
            this.colBenefitAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefitAmount.FieldName = "colBenefitAmount";
            this.colBenefitAmount.GroupFormat.FormatString = "{0:0.##}";
            this.colBenefitAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefitAmount.Name = "colBenefitAmount";
            this.colBenefitAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBenefitAmount", "{0:0.##}")});
            this.colBenefitAmount.UnboundExpression = "[colTotalWholeSale] - [colTotal]";
            this.colBenefitAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBenefitAmount.Visible = true;
            this.colBenefitAmount.VisibleIndex = 10;
            // 
            // colFullGoodName
            // 
            this.colFullGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName.Caption = "Məhsul";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FullGoodName", "{0:0.##}")});
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 2;
            this.colFullGoodName.Width = 80;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.Caption = "Say";
            this.colQuantity.DisplayFormat.FormatString = "0.##";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            this.colQuantity.Width = 78;
            // 
            // colSeries
            // 
            this.colSeries.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSeries.AppearanceCell.Options.UseFont = true;
            this.colSeries.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSeries.AppearanceHeader.Options.UseFont = true;
            this.colSeries.Caption = "Seriya";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            // 
            // colWarehouse
            // 
            this.colWarehouse.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWarehouse.AppearanceCell.Options.UseFont = true;
            this.colWarehouse.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWarehouse.AppearanceHeader.Options.UseFont = true;
            this.colWarehouse.Caption = "Anbar";
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 3;
            this.colWarehouse.Width = 78;
            // 
            // colGoodTypeName
            // 
            this.colGoodTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodTypeName.AppearanceCell.Options.UseFont = true;
            this.colGoodTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodTypeName.AppearanceHeader.Options.UseFont = true;
            this.colGoodTypeName.Caption = "Məhsul Növü";
            this.colGoodTypeName.FieldName = "GoodTypeName";
            this.colGoodTypeName.Name = "colGoodTypeName";
            this.colGoodTypeName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GoodTypeName", "Yekun")});
            this.colGoodTypeName.Visible = true;
            this.colGoodTypeName.VisibleIndex = 1;
            this.colGoodTypeName.Width = 93;
            // 
            // colBarcode
            // 
            this.colBarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarcode.AppearanceCell.Options.UseFont = true;
            this.colBarcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarcode.AppearanceHeader.Options.UseFont = true;
            this.colBarcode.Caption = "Barkod";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 11;
            this.colBarcode.Width = 78;
            // 
            // colManufacturerCompanyName
            // 
            this.colManufacturerCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colManufacturerCompanyName.AppearanceCell.Options.UseFont = true;
            this.colManufacturerCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colManufacturerCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colManufacturerCompanyName.Caption = "İstehsalçı";
            this.colManufacturerCompanyName.FieldName = "ManufacturerCompanyName";
            this.colManufacturerCompanyName.Name = "colManufacturerCompanyName";
            this.colManufacturerCompanyName.Visible = true;
            this.colManufacturerCompanyName.VisibleIndex = 12;
            this.colManufacturerCompanyName.Width = 78;
            // 
            // colRegionName
            // 
            this.colRegionName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceCell.Options.UseFont = true;
            this.colRegionName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceHeader.Options.UseFont = true;
            this.colRegionName.Caption = "Region";
            this.colRegionName.FieldName = "RegionName";
            this.colRegionName.Name = "colRegionName";
            this.colRegionName.Visible = true;
            this.colRegionName.VisibleIndex = 13;
            this.colRegionName.Width = 78;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Saxlanma yeri";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 14;
            this.colDescription.Width = 89;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTotal.AppearanceCell.Options.UseFont = true;
            this.colTotal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTotal.AppearanceHeader.Options.UseFont = true;
            this.colTotal.Caption = "Alış Məbləğ";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "colTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colTotal", "{0:0.##}")});
            this.colTotal.UnboundExpression = "[Quantity] * [PriceBuy]";
            this.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            // 
            // colPriceBuy
            // 
            this.colPriceBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceCell.Options.UseFont = true;
            this.colPriceBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceHeader.Options.UseFont = true;
            this.colPriceBuy.Caption = "Alış Qiyməti";
            this.colPriceBuy.DisplayFormat.FormatString = "0.##";
            this.colPriceBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceBuy.FieldName = "PriceBuy";
            this.colPriceBuy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPriceBuy.Name = "colPriceBuy";
            this.colPriceBuy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PriceBuy", "{0:0.##}")});
            this.colPriceBuy.Visible = true;
            this.colPriceBuy.VisibleIndex = 5;
            this.colPriceBuy.Width = 78;
            // 
            // colTotalWholeSale
            // 
            this.colTotalWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTotalWholeSale.AppearanceCell.Options.UseFont = true;
            this.colTotalWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTotalWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colTotalWholeSale.Caption = "Satış Məbləğ";
            this.colTotalWholeSale.FieldName = "colTotalWholeSale";
            this.colTotalWholeSale.Name = "colTotalWholeSale";
            this.colTotalWholeSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colTotalWholeSale", "{0:0.##}")});
            this.colTotalWholeSale.UnboundExpression = "[PriceWholeSale] * [Quantity]";
            this.colTotalWholeSale.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotalWholeSale.Visible = true;
            this.colTotalWholeSale.VisibleIndex = 7;
            // 
            // colPriceWholeSale
            // 
            this.colPriceWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceCell.Options.UseFont = true;
            this.colPriceWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colPriceWholeSale.Caption = "Satış Qiyməti";
            this.colPriceWholeSale.DisplayFormat.FormatString = "{0:0.##}";
            this.colPriceWholeSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceWholeSale.FieldName = "PriceWholeSale";
            this.colPriceWholeSale.GroupFormat.FormatString = "{0:0.##}";
            this.colPriceWholeSale.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceWholeSale.Name = "colPriceWholeSale";
            this.colPriceWholeSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PriceWholeSale", "{0:0.##}")});
            this.colPriceWholeSale.Visible = true;
            this.colPriceWholeSale.VisibleIndex = 8;
            // 
            // repoAmount
            // 
            this.repoAmount.AutoHeight = false;
            this.repoAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoAmount.Name = "repoAmount";
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // vwDeficitGoodStockTableAdapter
            // 
            this.vwDeficitGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 24);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl1.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 675);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl2.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl3.Size = new System.Drawing.Size(0, 651);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1327, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl4.Size = new System.Drawing.Size(0, 651);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5});
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.DockControls.Add(this.barDockControl6);
            this.barManager2.DockControls.Add(this.barDockControl7);
            this.barManager2.DockControls.Add(this.barDockControl8);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPrinter});
            this.barManager2.MainMenu = this.bar5;
            this.barManager2.MaxItemId = 1;
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrinter)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // btnPrinter
            // 
            this.btnPrinter.Caption = "Çap Et";
            this.btnPrinter.Hint = " Ctrl + P";
            this.btnPrinter.Id = 0;
            this.btnPrinter.ImageOptions.ImageUri.Uri = "Print;Size16x16;GrayScaled";
            this.btnPrinter.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrinter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrinter_ItemClick);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Size = new System.Drawing.Size(1327, 24);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 675);
            this.barDockControl6.Manager = this.barManager2;
            this.barDockControl6.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 24);
            this.barDockControl7.Manager = this.barManager2;
            this.barDockControl7.Size = new System.Drawing.Size(0, 651);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1327, 24);
            this.barDockControl8.Manager = this.barManager2;
            this.barDockControl8.Size = new System.Drawing.Size(0, 651);
            // 
            // barManager3
            // 
            this.barManager3.DockControls.Add(this.barDockControl9);
            this.barManager3.DockControls.Add(this.barDockControl10);
            this.barManager3.DockControls.Add(this.barDockControl11);
            this.barManager3.DockControls.Add(this.barDockControl12);
            this.barManager3.Form = this;
            this.barManager3.MaxItemId = 0;
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl9.Location = new System.Drawing.Point(0, 0);
            this.barDockControl9.Manager = this.barManager3;
            this.barDockControl9.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControl10
            // 
            this.barDockControl10.CausesValidation = false;
            this.barDockControl10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl10.Location = new System.Drawing.Point(0, 675);
            this.barDockControl10.Manager = this.barManager3;
            this.barDockControl10.Size = new System.Drawing.Size(1327, 0);
            // 
            // barDockControl11
            // 
            this.barDockControl11.CausesValidation = false;
            this.barDockControl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl11.Location = new System.Drawing.Point(0, 0);
            this.barDockControl11.Manager = this.barManager3;
            this.barDockControl11.Size = new System.Drawing.Size(0, 675);
            // 
            // barDockControl12
            // 
            this.barDockControl12.CausesValidation = false;
            this.barDockControl12.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl12.Location = new System.Drawing.Point(1327, 0);
            this.barDockControl12.Manager = this.barManager3;
            this.barDockControl12.Size = new System.Drawing.Size(0, 675);
            // 
            // DeficitStockManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl11);
            this.Controls.Add(this.barDockControl12);
            this.Controls.Add(this.barDockControl10);
            this.Controls.Add(this.barDockControl9);
            this.Margin = new System.Windows.Forms.Padding(32, 26, 32, 26);
            this.Name = "DeficitStockManager";
            this.Size = new System.Drawing.Size(1327, 675);
            this.Controls.SetChildIndex(this.barDockControl9, 0);
            this.Controls.SetChildIndex(this.barDockControl10, 0);
            this.Controls.SetChildIndex(this.barDockControl12, 0);
            this.Controls.SetChildIndex(this.barDockControl11, 0);
            this.Controls.SetChildIndex(this.barDockControl5, 0);
            this.Controls.SetChildIndex(this.barDockControl6, 0);
            this.Controls.SetChildIndex(this.barDockControl8, 0);
            this.Controls.SetChildIndex(this.barDockControl7, 0);
            this.Controls.SetChildIndex(this.barDockControl1, 0);
            this.Controls.SetChildIndex(this.barDockControl2, 0);
            this.Controls.SetChildIndex(this.barDockControl4, 0);
            this.Controls.SetChildIndex(this.barDockControl3, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDeficitGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStock;
        private System.Windows.Forms.BindingSource vwDeficitGoodStockBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwDeficitGoodStockTableAdapter vwDeficitGoodStockTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceBuy;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarDockControl barDockControl11;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
        private DevExpress.XtraBars.BarDockControl barDockControl10;
        private DevExpress.XtraBars.BarDockControl barDockControl12;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repoAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefist;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefitAmount;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
    }
}
