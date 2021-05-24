namespace MHM.Accountancy.Win
{
    partial class RetailSaleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailSaleForm));
            this.gridControlRetail = new DevExpress.XtraGrid.GridControl();
            this.spGetGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewRetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.spGetGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullGoodName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.txtCalcDisplay = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThree = new DevExpress.XtraEditors.SimpleButton();
            this.btnTwo = new DevExpress.XtraEditors.SimpleButton();
            this.btnOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnNine = new DevExpress.XtraEditors.SimpleButton();
            this.btnFour = new DevExpress.XtraEditors.SimpleButton();
            this.btnFive = new DevExpress.XtraEditors.SimpleButton();
            this.btnSix = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeven = new DevExpress.XtraEditors.SimpleButton();
            this.btnEight = new DevExpress.XtraEditors.SimpleButton();
            this.gcRetailReceipts = new DevExpress.XtraGrid.GridControl();
            this.vwRetailReceiptHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvRetailReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRowNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewSaleaa = new DevExpress.XtraBars.BarButtonItem();
            this.btnRejectOfSaleaa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaid = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturnSale = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barListItemUser = new DevExpress.XtraBars.BarListItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.spWareHouseSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spRetailAddTmpsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDocumentRetailTmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentDetailTmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.btnDiscountPercent = new DevExpress.XtraEditors.SimpleButton();
            this.btnDiscountByNumber = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiscountNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtSaleRetail = new DevExpress.XtraEditors.TextEdit();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.btnReceipts = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplySale = new DevExpress.XtraEditors.SimpleButton();
            this.btnRejectOfSale = new DevExpress.XtraEditors.SimpleButton();
            this.btnOneByOne = new DevExpress.XtraEditors.CheckButton();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.erpLookUpEditPaymentType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGaugeAmount = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtDeficit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtPayment = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.erpLookUpEditBarcode = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.spBarcodeSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwBarcodeSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.imageIndicatorComponent1 = new DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.spGetGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spGetGoodTableAdapter();
            this.vwBarcodeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter();
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vwDocumentDetailTmpTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTmpTableAdapter();
            this.spDocumentRetailTmpTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spDocumentRetailTmpTableAdapter();
            this.documentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.DocumentDetailTableAdapter();
            this.spRetailAddTmpsTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spRetailAddTmpsTableAdapter();
            this.vwSaleContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter();
            this.vwDeficitGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDeficitGoodStockTableAdapter();
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            this.vwBarcodeSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeSelectTableAdapter();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.spWareHouseSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter();
            this.spBarcodeSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spBarcodeSelectTableAdapter();
            this.vwGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter();
            this.vwGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGetGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spGetGoodStockTableAdapter();
            this.vwRetailReceiptHistoryTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwRetailReceiptHistoryTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnC = new DevExpress.XtraEditors.SimpleButton();
            this.btnZero = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoubleZero = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalcDisplay.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRetailReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetailReceiptHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRetailReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetailAddTmpsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentRetailTmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailTmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).BeginInit();
            this.gaugeControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGaugeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeficit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBarcodeSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRetail
            // 
            this.gridControlRetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlRetail.DataSource = this.spGetGoodBindingSource;
            this.gridControlRetail.Location = new System.Drawing.Point(325, 3);
            this.gridControlRetail.MainView = this.gridViewRetail;
            this.gridControlRetail.Name = "gridControlRetail";
            this.gridControlRetail.Size = new System.Drawing.Size(587, 445);
            this.gridControlRetail.TabIndex = 1;
            this.gridControlRetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRetail});
            // 
            // spGetGoodBindingSource
            // 
            this.spGetGoodBindingSource.DataMember = "spGetGood";
            this.spGetGoodBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewRetail
            // 
            this.gridViewRetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullGoodName,
            this.colQuantity,
            this.colBarcode,
            this.colPrice});
            this.gridViewRetail.GridControl = this.gridControlRetail;
            this.gridViewRetail.Name = "gridViewRetail";
            this.gridViewRetail.OptionsBehavior.ReadOnly = true;
            this.gridViewRetail.OptionsFind.AllowFindPanel = false;
            this.gridViewRetail.OptionsFind.ClearFindOnClose = false;
            this.gridViewRetail.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewRetail.OptionsFind.HighlightFindResults = false;
            this.gridViewRetail.OptionsFind.ShowClearButton = false;
            this.gridViewRetail.OptionsFind.ShowCloseButton = false;
            this.gridViewRetail.OptionsFind.ShowFindButton = false;
            this.gridViewRetail.OptionsSelection.MultiSelect = true;
            this.gridViewRetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewRetail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRetail.OptionsView.ShowFooter = true;
            this.gridViewRetail.OptionsView.ShowGroupPanel = false;
            // 
            // colFullGoodName
            // 
            this.colFullGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName.Caption = "Məhsul";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Image = ((System.Drawing.Image)(resources.GetObject("colFullGoodName.Image")));
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.Caption = "Say";
            this.colQuantity.DisplayFormat.FormatString = "{0:0.######}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "{0:0.######}";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Image = ((System.Drawing.Image)(resources.GetObject("colQuantity.Image")));
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "Yekun={0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            // 
            // colBarcode
            // 
            this.colBarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarcode.AppearanceCell.Options.UseFont = true;
            this.colBarcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarcode.AppearanceHeader.Options.UseFont = true;
            this.colBarcode.Caption = "Barkod";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Image = ((System.Drawing.Image)(resources.GetObject("colBarcode.Image")));
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPrice.AppearanceCell.Options.UseFont = true;
            this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPrice.AppearanceHeader.Options.UseFont = true;
            this.colPrice.Caption = "Qiymət";
            this.colPrice.DisplayFormat.FormatString = "{0:0.######}";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrice.FieldName = "Price";
            this.colPrice.GroupFormat.FormatString = "{0:0.######}";
            this.colPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrice.Image = ((System.Drawing.Image)(resources.GetObject("colPrice.Image")));
            this.colPrice.Name = "colPrice";
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "Yekun={0:0.##}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            this.vwGoodBindingSource.DataSource = this.dataSet;
            // 
            // vwBarcodeBindingSource
            // 
            this.vwBarcodeBindingSource.DataMember = "VwBarcode";
            this.vwBarcodeBindingSource.DataSource = this.dataSet;
            // 
            // gridControlStock
            // 
            this.gridControlStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlStock.DataSource = this.spGetGoodStockBindingSource;
            this.gridControlStock.Location = new System.Drawing.Point(325, 449);
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.Size = new System.Drawing.Size(587, 267);
            this.gridControlStock.TabIndex = 1;
            this.gridControlStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStock});
            this.gridControlStock.DoubleClick += new System.EventHandler(this.gridControlStock_DoubleClick);
            // 
            // spGetGoodStockBindingSource
            // 
            this.spGetGoodStockBindingSource.DataMember = "spGetGoodStock";
            this.spGetGoodStockBindingSource.DataSource = this.dataSet;
            // 
            // gridViewStock
            // 
            this.gridViewStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullGoodName1,
            this.colWarehouse,
            this.colUnitName,
            this.colQuantity1});
            this.gridViewStock.GridControl = this.gridControlStock;
            this.gridViewStock.Name = "gridViewStock";
            this.gridViewStock.OptionsBehavior.ReadOnly = true;
            this.gridViewStock.OptionsFind.AllowFindPanel = false;
            this.gridViewStock.OptionsFind.ClearFindOnClose = false;
            this.gridViewStock.OptionsFind.FindNullPrompt = "Axtarış sözünü yazın...";
            this.gridViewStock.OptionsFind.HighlightFindResults = false;
            this.gridViewStock.OptionsFind.ShowClearButton = false;
            this.gridViewStock.OptionsFind.ShowFindButton = false;
            this.gridViewStock.OptionsView.ShowFooter = true;
            this.gridViewStock.OptionsView.ShowGroupPanel = false;
            // 
            // colFullGoodName1
            // 
            this.colFullGoodName1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName1.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName1.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName1.Caption = "Məhsul";
            this.colFullGoodName1.FieldName = "FullGoodName";
            this.colFullGoodName1.Image = ((System.Drawing.Image)(resources.GetObject("colFullGoodName1.Image")));
            this.colFullGoodName1.Name = "colFullGoodName1";
            this.colFullGoodName1.Visible = true;
            this.colFullGoodName1.VisibleIndex = 0;
            // 
            // colWarehouse
            // 
            this.colWarehouse.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWarehouse.AppearanceCell.Options.UseFont = true;
            this.colWarehouse.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWarehouse.AppearanceHeader.Options.UseFont = true;
            this.colWarehouse.Caption = "Anbar";
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("colWarehouse.Image")));
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 1;
            // 
            // colUnitName
            // 
            this.colUnitName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitName.AppearanceCell.Options.UseFont = true;
            this.colUnitName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitName.AppearanceHeader.Options.UseFont = true;
            this.colUnitName.Caption = "Ölçü Vahidi";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Image = ((System.Drawing.Image)(resources.GetObject("colUnitName.Image")));
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 3;
            // 
            // colQuantity1
            // 
            this.colQuantity1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity1.AppearanceCell.Options.UseFont = true;
            this.colQuantity1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity1.AppearanceHeader.Options.UseFont = true;
            this.colQuantity1.Caption = "Say";
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Image = ((System.Drawing.Image)(resources.GetObject("colQuantity1.Image")));
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 2;
            // 
            // groupControl8
            // 
            this.groupControl8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl8.Appearance.Options.UseBackColor = true;
            this.groupControl8.AutoSize = true;
            this.groupControl8.Controls.Add(this.txtCalcDisplay);
            this.groupControl8.Controls.Add(this.tableLayoutPanel1);
            this.groupControl8.Location = new System.Drawing.Point(918, 3);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(451, 716);
            this.groupControl8.TabIndex = 1;
            // 
            // txtCalcDisplay
            // 
            this.txtCalcDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCalcDisplay.Location = new System.Drawing.Point(32, 35);
            this.txtCalcDisplay.Name = "txtCalcDisplay";
            this.txtCalcDisplay.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCalcDisplay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCalcDisplay.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCalcDisplay.Properties.Appearance.Options.UseBackColor = true;
            this.txtCalcDisplay.Properties.Appearance.Options.UseFont = true;
            this.txtCalcDisplay.Properties.Appearance.Options.UseForeColor = true;
            this.txtCalcDisplay.Properties.AutoHeight = false;
            this.txtCalcDisplay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCalcDisplay.Size = new System.Drawing.Size(0, 19);
            this.txtCalcDisplay.TabIndex = 60;
            this.txtCalcDisplay.Visible = false;
            this.txtCalcDisplay.TextChanged += new System.EventHandler(this.txtCalcDisplay_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDoubleZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 403);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(441, 361);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 310);
            this.tableLayoutPanel1.TabIndex = 66;
            // 
            // btnThree
            // 
            this.btnThree.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThree.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnThree.Appearance.Options.UseFont = true;
            this.btnThree.Appearance.Options.UseForeColor = true;
            this.btnThree.Location = new System.Drawing.Point(295, 157);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(143, 71);
            this.btnThree.TabIndex = 54;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "3";
            this.btnThree.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTwo.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTwo.Appearance.Options.UseFont = true;
            this.btnTwo.Appearance.Options.UseForeColor = true;
            this.btnTwo.Location = new System.Drawing.Point(149, 157);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(140, 71);
            this.btnTwo.TabIndex = 53;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "2";
            this.btnTwo.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnOne
            // 
            this.btnOne.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOne.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOne.Appearance.Options.UseFont = true;
            this.btnOne.Appearance.Options.UseForeColor = true;
            this.btnOne.Location = new System.Drawing.Point(3, 157);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(140, 71);
            this.btnOne.TabIndex = 52;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "1";
            this.btnOne.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnNine
            // 
            this.btnNine.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNine.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNine.Appearance.Options.UseFont = true;
            this.btnNine.Appearance.Options.UseForeColor = true;
            this.btnNine.Location = new System.Drawing.Point(295, 3);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(143, 71);
            this.btnNine.TabIndex = 46;
            this.btnNine.Tag = "9";
            this.btnNine.Text = "9";
            this.btnNine.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnFour
            // 
            this.btnFour.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFour.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnFour.Appearance.Options.UseFont = true;
            this.btnFour.Appearance.Options.UseForeColor = true;
            this.btnFour.Location = new System.Drawing.Point(3, 80);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(140, 71);
            this.btnFour.TabIndex = 48;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "4";
            this.btnFour.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnFive
            // 
            this.btnFive.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFive.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnFive.Appearance.Options.UseFont = true;
            this.btnFive.Appearance.Options.UseForeColor = true;
            this.btnFive.Location = new System.Drawing.Point(149, 80);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(140, 71);
            this.btnFive.TabIndex = 49;
            this.btnFive.Tag = "5";
            this.btnFive.Text = "5";
            this.btnFive.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnSix
            // 
            this.btnSix.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSix.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSix.Appearance.Options.UseFont = true;
            this.btnSix.Appearance.Options.UseForeColor = true;
            this.btnSix.Location = new System.Drawing.Point(295, 80);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(143, 71);
            this.btnSix.TabIndex = 50;
            this.btnSix.Tag = "6";
            this.btnSix.Text = "6";
            this.btnSix.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeven.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSeven.Appearance.Options.UseFont = true;
            this.btnSeven.Appearance.Options.UseForeColor = true;
            this.btnSeven.Location = new System.Drawing.Point(149, 3);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(140, 71);
            this.btnSeven.TabIndex = 44;
            this.btnSeven.Tag = "7";
            this.btnSeven.Text = "7";
            this.btnSeven.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnEight
            // 
            this.btnEight.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEight.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEight.Appearance.Options.UseFont = true;
            this.btnEight.Appearance.Options.UseForeColor = true;
            this.btnEight.Location = new System.Drawing.Point(3, 3);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(140, 71);
            this.btnEight.TabIndex = 45;
            this.btnEight.Tag = "8";
            this.btnEight.Text = "8";
            this.btnEight.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // gcRetailReceipts
            // 
            this.gcRetailReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRetailReceipts.DataSource = this.vwRetailReceiptHistoryBindingSource;
            this.gcRetailReceipts.Location = new System.Drawing.Point(918, 3);
            this.gcRetailReceipts.MainView = this.gvRetailReceipts;
            this.gcRetailReceipts.MenuManager = this.barManager1;
            this.gcRetailReceipts.Name = "gcRetailReceipts";
            this.gcRetailReceipts.Size = new System.Drawing.Size(441, 400);
            this.gcRetailReceipts.TabIndex = 67;
            this.gcRetailReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRetailReceipts});
            this.gcRetailReceipts.DoubleClick += new System.EventHandler(this.gcRetailReceipts_DoubleClick);
            // 
            // vwRetailReceiptHistoryBindingSource
            // 
            this.vwRetailReceiptHistoryBindingSource.DataMember = "VwRetailReceiptHistory";
            this.vwRetailReceiptHistoryBindingSource.DataSource = this.dataSet;
            // 
            // gvRetailReceipts
            // 
            this.gvRetailReceipts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRowNo,
            this.colCreateDate,
            this.colStatusName,
            this.colCashierName});
            this.gvRetailReceipts.GridControl = this.gcRetailReceipts;
            this.gvRetailReceipts.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkib atın";
            this.gvRetailReceipts.Name = "gvRetailReceipts";
            this.gvRetailReceipts.OptionsView.ShowFooter = true;
            this.gvRetailReceipts.OptionsView.ShowGroupPanel = false;
            // 
            // colRowNo
            // 
            this.colRowNo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRowNo.AppearanceCell.Options.UseFont = true;
            this.colRowNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRowNo.AppearanceHeader.Options.UseFont = true;
            this.colRowNo.Caption = "№";
            this.colRowNo.FieldName = "RowNo";
            this.colRowNo.Name = "colRowNo";
            this.colRowNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RowNo", "Yekun={0:0.##}")});
            this.colRowNo.Visible = true;
            this.colRowNo.VisibleIndex = 0;
            this.colRowNo.Width = 65;
            // 
            // colCreateDate
            // 
            this.colCreateDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateDate.AppearanceCell.Options.UseFont = true;
            this.colCreateDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateDate.AppearanceHeader.Options.UseFont = true;
            this.colCreateDate.Caption = "Tarix";
            this.colCreateDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:MM:ss";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.GroupFormat.FormatString = "dd/MM/yyyy hh:MM:ss";
            this.colCreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.Image = ((System.Drawing.Image)(resources.GetObject("colCreateDate.Image")));
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 2;
            this.colCreateDate.Width = 171;
            // 
            // colStatusName
            // 
            this.colStatusName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colStatusName.AppearanceCell.Options.UseFont = true;
            this.colStatusName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colStatusName.AppearanceHeader.Options.UseFont = true;
            this.colStatusName.Caption = "Status";
            this.colStatusName.FieldName = "StatusName";
            this.colStatusName.Image = ((System.Drawing.Image)(resources.GetObject("colStatusName.Image")));
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.Visible = true;
            this.colStatusName.VisibleIndex = 3;
            this.colStatusName.Width = 103;
            // 
            // colCashierName
            // 
            this.colCashierName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashierName.AppearanceCell.Options.UseFont = true;
            this.colCashierName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashierName.AppearanceHeader.Options.UseFont = true;
            this.colCashierName.Caption = "Kassir";
            this.colCashierName.FieldName = "CashierName";
            this.colCashierName.Image = ((System.Drawing.Image)(resources.GetObject("colCashierName.Image")));
            this.colCashierName.Name = "colCashierName";
            this.colCashierName.Visible = true;
            this.colCashierName.VisibleIndex = 1;
            this.colCashierName.Width = 84;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnNewSaleaa,
            this.btnRejectOfSaleaa,
            this.btnPaid,
            this.btnReturnSale,
            this.barStaticItem1,
            this.barListItemUser,
            this.barEditItem1,
            this.barStaticItem2});
            this.barManager1.MaxItemId = 10;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1361, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 716);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1361, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 716);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1361, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 716);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yeni Satış";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnNewSaleaa
            // 
            this.btnNewSaleaa.Caption = "Yeni Satış";
            this.btnNewSaleaa.Id = 2;
            this.btnNewSaleaa.Name = "btnNewSaleaa";
            this.btnNewSaleaa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnRejectOfSaleaa
            // 
            this.btnRejectOfSaleaa.Caption = "Satışın Ləğvi";
            this.btnRejectOfSaleaa.Id = 3;
            this.btnRejectOfSaleaa.Name = "btnRejectOfSaleaa";
            this.btnRejectOfSaleaa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnPaid
            // 
            this.btnPaid.Caption = "Ödəniş";
            this.btnPaid.Id = 4;
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPaid.ShortcutKeyDisplayString = "+";
            this.btnPaid.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // btnReturnSale
            // 
            this.btnReturnSale.Caption = "Geri Qaytarma";
            this.btnReturnSale.Id = 5;
            this.btnReturnSale.Name = "btnReturnSale";
            this.btnReturnSale.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barListItemUser
            // 
            this.barListItemUser.Caption = " ";
            this.barListItemUser.Id = 7;
            this.barListItemUser.Name = "barListItemUser";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 8;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "barStaticItem2";
            this.barStaticItem2.Id = 9;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // spWareHouseSelectBindingSource
            // 
            this.spWareHouseSelectBindingSource.DataMember = "spWareHouseSelect";
            this.spWareHouseSelectBindingSource.DataSource = this.dataSet;
            // 
            // spRetailAddTmpsBindingSource
            // 
            this.spRetailAddTmpsBindingSource.DataMember = "spRetailAddTmps";
            this.spRetailAddTmpsBindingSource.DataSource = this.dataSet;
            // 
            // documentDetailBindingSource
            // 
            this.documentDetailBindingSource.DataMember = "DocumentDetail";
            this.documentDetailBindingSource.DataSource = this.dataSet;
            // 
            // spDocumentRetailTmpBindingSource
            // 
            this.spDocumentRetailTmpBindingSource.DataMember = "spDocumentRetailTmp";
            this.spDocumentRetailTmpBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentDetailTmpBindingSource
            // 
            this.vwDocumentDetailTmpBindingSource.DataMember = "VwDocumentDetailTmp";
            this.vwDocumentDetailTmpBindingSource.DataSource = this.dataSet;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.groupControl9);
            this.groupControl1.Controls.Add(this.groupControl7);
            this.groupControl1.Controls.Add(this.groupControl6);
            this.groupControl1.Controls.Add(this.gaugeControl1);
            this.groupControl1.Controls.Add(this.groupControl5);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.groupControl1.Location = new System.Drawing.Point(1, 3);
            this.groupControl1.MinimumSize = new System.Drawing.Size(322, 605);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(322, 713);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Satış";
            this.groupControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.presentationImage_MouseDown);
            this.groupControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.presentationImage_MouseMove);
            this.groupControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.presentationImage_MouseUp);
            // 
            // groupControl9
            // 
            this.groupControl9.Controls.Add(this.btnDiscountPercent);
            this.groupControl9.Controls.Add(this.btnDiscountByNumber);
            this.groupControl9.Controls.Add(this.txtDiscountNumber);
            this.groupControl9.Controls.Add(this.txtSaleRetail);
            this.groupControl9.Location = new System.Drawing.Point(8, 315);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(306, 66);
            this.groupControl9.TabIndex = 48;
            this.groupControl9.Text = "Endirimlər";
            // 
            // btnDiscountPercent
            // 
            this.btnDiscountPercent.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscountPercent.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDiscountPercent.Appearance.Options.UseFont = true;
            this.btnDiscountPercent.Appearance.Options.UseForeColor = true;
            this.btnDiscountPercent.Location = new System.Drawing.Point(58, 22);
            this.btnDiscountPercent.Name = "btnDiscountPercent";
            this.btnDiscountPercent.Size = new System.Drawing.Size(95, 41);
            this.btnDiscountPercent.TabIndex = 8;
            this.btnDiscountPercent.Text = "Endirim %";
            this.btnDiscountPercent.Click += new System.EventHandler(this.btnDiscountPercent_Click);
            // 
            // btnDiscountByNumber
            // 
            this.btnDiscountByNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscountByNumber.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDiscountByNumber.Appearance.Options.UseFont = true;
            this.btnDiscountByNumber.Appearance.Options.UseForeColor = true;
            this.btnDiscountByNumber.Location = new System.Drawing.Point(207, 23);
            this.btnDiscountByNumber.Name = "btnDiscountByNumber";
            this.btnDiscountByNumber.Size = new System.Drawing.Size(95, 41);
            this.btnDiscountByNumber.TabIndex = 7;
            this.btnDiscountByNumber.Text = "Endirim Rəqəm";
            this.btnDiscountByNumber.Click += new System.EventHandler(this.btnDiscountByNumber_Click);
            // 
            // txtDiscountNumber
            // 
            this.txtDiscountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscountNumber.Location = new System.Drawing.Point(155, 23);
            this.txtDiscountNumber.Name = "txtDiscountNumber";
            this.txtDiscountNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscountNumber.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDiscountNumber.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtDiscountNumber.Properties.AutoHeight = false;
            this.txtDiscountNumber.Size = new System.Drawing.Size(50, 41);
            this.txtDiscountNumber.TabIndex = 5;
            this.txtDiscountNumber.EditValueChanged += new System.EventHandler(this.txtDiscountNumber_EditValueChanged);
            // 
            // txtSaleRetail
            // 
            this.txtSaleRetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaleRetail.Location = new System.Drawing.Point(6, 22);
            this.txtSaleRetail.Name = "txtSaleRetail";
            this.txtSaleRetail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSaleRetail.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSaleRetail.Properties.Appearance.Options.UseFont = true;
            this.txtSaleRetail.Properties.Appearance.Options.UseForeColor = true;
            this.txtSaleRetail.Properties.AutoHeight = false;
            this.txtSaleRetail.Size = new System.Drawing.Size(50, 41);
            this.txtSaleRetail.TabIndex = 4;
            this.txtSaleRetail.EditValueChanged += new System.EventHandler(this.txtSaleRetail_EditValueChanged);
            // 
            // groupControl7
            // 
            this.groupControl7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl7.Appearance.Options.UseBackColor = true;
            this.groupControl7.Controls.Add(this.btnReceipts);
            this.groupControl7.Controls.Add(this.btnClear);
            this.groupControl7.Controls.Add(this.btnApplySale);
            this.groupControl7.Controls.Add(this.btnRejectOfSale);
            this.groupControl7.Controls.Add(this.btnOneByOne);
            this.groupControl7.Location = new System.Drawing.Point(8, 511);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(306, 173);
            this.groupControl7.TabIndex = 46;
            this.groupControl7.Text = "Əməliyyatlar";
            // 
            // btnReceipts
            // 
            this.btnReceipts.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReceipts.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnReceipts.Appearance.Options.UseFont = true;
            this.btnReceipts.Appearance.Options.UseForeColor = true;
            this.btnReceipts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReceipts.ImageOptions.Image")));
            this.btnReceipts.Location = new System.Drawing.Point(154, 70);
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.Size = new System.Drawing.Size(148, 49);
            this.btnReceipts.TabIndex = 49;
            this.btnReceipts.Text = "Gözləmə";
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseForeColor = true;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(4, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 49);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Sil";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnApplySale
            // 
            this.btnApplySale.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplySale.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnApplySale.Appearance.Options.UseFont = true;
            this.btnApplySale.Appearance.Options.UseForeColor = true;
            this.btnApplySale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApplySale.ImageOptions.Image")));
            this.btnApplySale.Location = new System.Drawing.Point(4, 121);
            this.btnApplySale.Name = "btnApplySale";
            this.btnApplySale.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnApplySale.Size = new System.Drawing.Size(298, 49);
            this.btnApplySale.TabIndex = 6;
            this.btnApplySale.Text = "Satış Et";
            this.btnApplySale.Click += new System.EventHandler(this.btnApplySale_Click);
            this.btnApplySale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnApplySale_KeyPress);
            // 
            // btnRejectOfSale
            // 
            this.btnRejectOfSale.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRejectOfSale.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRejectOfSale.Appearance.Options.UseFont = true;
            this.btnRejectOfSale.Appearance.Options.UseForeColor = true;
            this.btnRejectOfSale.ImageOptions.Image = global::MHM.Accountancy.Win.Properties.Resources.satisin_legvi;
            this.btnRejectOfSale.Location = new System.Drawing.Point(4, 18);
            this.btnRejectOfSale.Name = "btnRejectOfSale";
            this.btnRejectOfSale.Size = new System.Drawing.Size(148, 49);
            this.btnRejectOfSale.TabIndex = 8;
            this.btnRejectOfSale.Text = "Ləğv Et";
            this.btnRejectOfSale.Click += new System.EventHandler(this.btnRejectOfSale_Click);
            // 
            // btnOneByOne
            // 
            this.btnOneByOne.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOneByOne.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOneByOne.Appearance.Options.UseFont = true;
            this.btnOneByOne.Appearance.Options.UseForeColor = true;
            this.btnOneByOne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOneByOne.ImageOptions.Image")));
            this.btnOneByOne.Location = new System.Drawing.Point(154, 18);
            this.btnOneByOne.Name = "btnOneByOne";
            this.btnOneByOne.Size = new System.Drawing.Size(148, 49);
            this.btnOneByOne.TabIndex = 44;
            this.btnOneByOne.Text = "Bölgü";
            this.btnOneByOne.CheckedChanged += new System.EventHandler(this.btnOneByOne_CheckedChanged);
            // 
            // groupControl6
            // 
            this.groupControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl6.Controls.Add(this.erpLookUpEditPaymentType);
            this.groupControl6.Location = new System.Drawing.Point(8, 185);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(306, 66);
            this.groupControl6.TabIndex = 2;
            this.groupControl6.Text = "Ödənişin Növü";
            // 
            // erpLookUpEditPaymentType
            // 
            this.erpLookUpEditPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.erpLookUpEditPaymentType.Location = new System.Drawing.Point(6, 20);
            this.erpLookUpEditPaymentType.Name = "erpLookUpEditPaymentType";
            this.erpLookUpEditPaymentType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditPaymentType.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.erpLookUpEditPaymentType.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditPaymentType.Properties.Appearance.Options.UseForeColor = true;
            this.erpLookUpEditPaymentType.Properties.AutoHeight = false;
            this.erpLookUpEditPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ödəniş Növü", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditPaymentType.Properties.DataSource = this.vwPaymentTypeBindingSource;
            this.erpLookUpEditPaymentType.Properties.DisplayMember = "Name";
            this.erpLookUpEditPaymentType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditPaymentType.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.erpLookUpEditPaymentType.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.erpLookUpEditPaymentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.erpLookUpEditPaymentType.Properties.ValueMember = "Id";
            this.erpLookUpEditPaymentType.Size = new System.Drawing.Size(294, 44);
            this.erpLookUpEditPaymentType.TabIndex = 2;
            this.erpLookUpEditPaymentType.EditValueChanged += new System.EventHandler(this.erpLookUpEditPaymentType_EditValueChanged);
            // 
            // vwPaymentTypeBindingSource
            // 
            this.vwPaymentTypeBindingSource.DataMember = "VwPaymentType";
            this.vwPaymentTypeBindingSource.DataSource = this.dataSet;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.gaugeControl1.Controls.Add(this.gaugeControl2);
            this.gaugeControl1.Location = new System.Drawing.Point(8, 24);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(306, 92);
            this.gaugeControl1.TabIndex = 21;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGaugeAmount});
            this.gaugeControl2.Location = new System.Drawing.Point(5, 3);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(298, 86);
            this.gaugeControl2.TabIndex = 0;
            // 
            // digitalGaugeAmount
            // 
            this.digitalGaugeAmount.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E9EFF3");
            this.digitalGaugeAmount.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0F89B8");
            this.digitalGaugeAmount.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent3});
            this.digitalGaugeAmount.Bounds = new System.Drawing.Rectangle(6, 6, 286, 74);
            this.digitalGaugeAmount.DigitCount = 8;
            this.digitalGaugeAmount.Name = "digitalGaugeAmount";
            this.digitalGaugeAmount.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGaugeAmount.Text = "00.000";
            // 
            // digitalBackgroundLayerComponent3
            // 
            this.digitalBackgroundLayerComponent3.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(409.7F, 99.9625F);
            this.digitalBackgroundLayerComponent3.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style22;
            this.digitalBackgroundLayerComponent3.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl5.Controls.Add(this.txtDeficit);
            this.groupControl5.Location = new System.Drawing.Point(8, 446);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(306, 66);
            this.groupControl5.TabIndex = 20;
            this.groupControl5.Text = "Qalıq Məbləğ";
            // 
            // txtDeficit
            // 
            this.txtDeficit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeficit.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDeficit.Location = new System.Drawing.Point(6, 17);
            this.txtDeficit.Name = "txtDeficit";
            this.txtDeficit.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtDeficit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeficit.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDeficit.Properties.Appearance.Options.UseBackColor = true;
            this.txtDeficit.Properties.Appearance.Options.UseFont = true;
            this.txtDeficit.Properties.Appearance.Options.UseForeColor = true;
            this.txtDeficit.Properties.AutoHeight = false;
            this.txtDeficit.Properties.ReadOnly = true;
            this.txtDeficit.Size = new System.Drawing.Size(294, 44);
            this.txtDeficit.TabIndex = 0;
            this.txtDeficit.EditValueChanged += new System.EventHandler(this.txtDeficit_EditValueChanged);
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.txtPayment);
            this.groupControl4.Location = new System.Drawing.Point(8, 379);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(306, 66);
            this.groupControl4.TabIndex = 19;
            this.groupControl4.Text = "Ödənilən Məbləğ";
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayment.Location = new System.Drawing.Point(6, 17);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPayment.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPayment.Properties.Appearance.Options.UseFont = true;
            this.txtPayment.Properties.Appearance.Options.UseForeColor = true;
            this.txtPayment.Properties.AutoHeight = false;
            this.txtPayment.Size = new System.Drawing.Size(294, 44);
            this.txtPayment.TabIndex = 6;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            this.txtPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayment_KeyDown);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.txtQuantity);
            this.groupControl3.Location = new System.Drawing.Point(8, 249);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(306, 66);
            this.groupControl3.TabIndex = 18;
            this.groupControl3.Text = "Miqdar Təyini";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(6, 17);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuantity.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Properties.Appearance.Options.UseForeColor = true;
            this.txtQuantity.Properties.AutoHeight = false;
            this.txtQuantity.Size = new System.Drawing.Size(294, 44);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.erpLookUpEditBarcode);
            this.groupControl2.Location = new System.Drawing.Point(8, 119);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(306, 66);
            this.groupControl2.TabIndex = 17;
            this.groupControl2.Text = "Məhsul və Barkod";
            // 
            // erpLookUpEditBarcode
            // 
            this.erpLookUpEditBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.erpLookUpEditBarcode.Location = new System.Drawing.Point(6, 20);
            this.erpLookUpEditBarcode.Name = "erpLookUpEditBarcode";
            this.erpLookUpEditBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditBarcode.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.erpLookUpEditBarcode.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditBarcode.Properties.Appearance.Options.UseForeColor = true;
            this.erpLookUpEditBarcode.Properties.AutoHeight = false;
            this.erpLookUpEditBarcode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditBarcode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullGoodName", "Məhsul", 159, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barkod", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditBarcode.Properties.DataSource = this.spBarcodeSelectBindingSource;
            this.erpLookUpEditBarcode.Properties.DisplayMember = "Barcode";
            this.erpLookUpEditBarcode.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditBarcode.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.erpLookUpEditBarcode.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.erpLookUpEditBarcode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.erpLookUpEditBarcode.Properties.ValueMember = "Id";
            this.erpLookUpEditBarcode.Size = new System.Drawing.Size(294, 44);
            this.erpLookUpEditBarcode.TabIndex = 1;
            this.erpLookUpEditBarcode.EditValueChanged += new System.EventHandler(this.erpLookUpEditBarcode_EditValueChanged);
            this.erpLookUpEditBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.erpLookUpEditBarcode_KeyUp);
            // 
            // spBarcodeSelectBindingSource
            // 
            this.spBarcodeSelectBindingSource.DataMember = "spBarcodeSelect";
            this.spBarcodeSelectBindingSource.DataSource = this.dataSet;
            // 
            // vwBarcodeSelectBindingSource
            // 
            this.vwBarcodeSelectBindingSource.DataMember = "VwBarcodeSelect";
            this.vwBarcodeSelectBindingSource.DataSource = this.dataSet;
            // 
            // vwSaleContractChooseBindingSource
            // 
            this.vwSaleContractChooseBindingSource.DataMember = "VwSaleContractChoose";
            this.vwSaleContractChooseBindingSource.DataSource = this.dataSet;
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(409.7F, 99.9625F);
            this.digitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style22;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // imageIndicatorComponent1
            // 
            this.imageIndicatorComponent1.Name = "digitalGauge1_ImageIndicator1";
            this.imageIndicatorComponent1.ZOrder = -1001;
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(403.7F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent11";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style9;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // spGetGoodTableAdapter
            // 
            this.spGetGoodTableAdapter.ClearBeforeFill = true;
            // 
            // vwBarcodeTableAdapter
            // 
            this.vwBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // vwPaymentTypeTableAdapter
            // 
            this.vwPaymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "[Seçim Edilməyib]";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // vwDocumentDetailTmpTableAdapter
            // 
            this.vwDocumentDetailTmpTableAdapter.ClearBeforeFill = true;
            // 
            // spDocumentRetailTmpTableAdapter
            // 
            this.spDocumentRetailTmpTableAdapter.ClearBeforeFill = true;
            // 
            // documentDetailTableAdapter
            // 
            this.documentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // spRetailAddTmpsTableAdapter
            // 
            this.spRetailAddTmpsTableAdapter.ClearBeforeFill = true;
            // 
            // vwSaleContractChooseTableAdapter
            // 
            this.vwSaleContractChooseTableAdapter.ClearBeforeFill = true;
            // 
            // vwDeficitGoodStockTableAdapter
            // 
            this.vwDeficitGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // vwBarcodeSelectTableAdapter
            // 
            this.vwBarcodeSelectTableAdapter.ClearBeforeFill = true;
            // 
            // spWareHouseSelectTableAdapter
            // 
            this.spWareHouseSelectTableAdapter.ClearBeforeFill = true;
            // 
            // spBarcodeSelectTableAdapter
            // 
            this.spBarcodeSelectTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodStockTableAdapter
            // 
            this.vwGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodStockBindingSource
            // 
            this.vwGoodStockBindingSource.DataMember = "VwGoodStock";
            this.vwGoodStockBindingSource.DataSource = this.dataSet;
            // 
            // spGetGoodStockTableAdapter
            // 
            this.spGetGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // vwRetailReceiptHistoryTableAdapter
            // 
            this.vwRetailReceiptHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnC
            // 
            this.btnC.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnC.Appearance.Options.UseFont = true;
            this.btnC.Appearance.Options.UseForeColor = true;
            this.btnC.Location = new System.Drawing.Point(295, 234);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(143, 71);
            this.btnC.TabIndex = 41;
            this.btnC.Text = "C";
            this.btnC.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnZero
            // 
            this.btnZero.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZero.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnZero.Appearance.Options.UseFont = true;
            this.btnZero.Appearance.Options.UseForeColor = true;
            this.btnZero.Location = new System.Drawing.Point(3, 234);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(140, 71);
            this.btnZero.TabIndex = 56;
            this.btnZero.Tag = "0";
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // btnDoubleZero
            // 
            this.btnDoubleZero.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoubleZero.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDoubleZero.Appearance.Options.UseFont = true;
            this.btnDoubleZero.Appearance.Options.UseForeColor = true;
            this.btnDoubleZero.Location = new System.Drawing.Point(149, 234);
            this.btnDoubleZero.Name = "btnDoubleZero";
            this.btnDoubleZero.Size = new System.Drawing.Size(140, 71);
            this.btnDoubleZero.TabIndex = 57;
            this.btnDoubleZero.Tag = "00";
            this.btnDoubleZero.Text = "00";
            this.btnDoubleZero.Click += new System.EventHandler(this.btn_CalcItem_Click);
            // 
            // RetailSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1361, 716);
            this.Controls.Add(this.gcRetailReceipts);
            this.Controls.Add(this.gridControlStock);
            this.Controls.Add(this.gridControlRetail);
            this.Controls.Add(this.groupControl8);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1377, 755);
            this.Name = "RetailSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RetailSaleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RetailSaleForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCalcDisplay.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRetailReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetailReceiptHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRetailReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spRetailAddTmpsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentRetailTmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailTmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).EndInit();
            this.gaugeControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalGaugeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDeficit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBarcodeSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Modules.Operation.Accounting.Data.AccountingDataSet dataSet;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent imageIndicatorComponent1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.TextEdit txtDeficit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit txtPayment;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditBarcode;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnNewSaleaa;
        private DevExpress.XtraBars.BarButtonItem btnRejectOfSaleaa;
        private DevExpress.XtraBars.BarButtonItem btnPaid;
        private DevExpress.XtraBars.BarButtonItem btnReturnSale;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource spGetGoodBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spGetGoodTableAdapter spGetGoodTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPaymentType;
        private DevExpress.XtraEditors.SimpleButton btnApplySale;
        private DevExpress.XtraEditors.SimpleButton btnRejectOfSale;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGaugeAmount;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent3;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private System.Windows.Forms.BindingSource vwBarcodeBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter vwBarcodeTableAdapter;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControlRetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.CheckButton btnOneByOne;
        private System.Windows.Forms.BindingSource vwDocumentDetailTmpBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTmpTableAdapter vwDocumentDetailTmpTableAdapter;
        private System.Windows.Forms.BindingSource spDocumentRetailTmpBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spDocumentRetailTmpTableAdapter spDocumentRetailTmpTableAdapter;
        private System.Windows.Forms.BindingSource documentDetailBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.DocumentDetailTableAdapter documentDetailTableAdapter;
        private System.Windows.Forms.BindingSource spRetailAddTmpsBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spRetailAddTmpsTableAdapter spRetailAddTmpsTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private System.Windows.Forms.BindingSource vwSaleContractChooseBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter vwSaleContractChooseTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDeficitGoodStockTableAdapter vwDeficitGoodStockTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraEditors.TextEdit txtSaleRetail;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
        private System.Windows.Forms.BindingSource vwBarcodeSelectBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeSelectTableAdapter vwBarcodeSelectTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCalcDisplay;
        private DevExpress.XtraEditors.SimpleButton btnThree;
        private DevExpress.XtraEditors.SimpleButton btnTwo;
        private DevExpress.XtraEditors.SimpleButton btnOne;
        private DevExpress.XtraEditors.SimpleButton btnSix;
        private DevExpress.XtraEditors.SimpleButton btnFive;
        private DevExpress.XtraEditors.SimpleButton btnFour;
        private DevExpress.XtraEditors.SimpleButton btnNine;
        private DevExpress.XtraEditors.SimpleButton btnEight;
        private DevExpress.XtraEditors.SimpleButton btnSeven;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private System.Windows.Forms.BindingSource spWareHouseSelectBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter spWareHouseSelectTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName1;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private System.Windows.Forms.BindingSource spBarcodeSelectBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spBarcodeSelectTableAdapter spBarcodeSelectTableAdapter;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter vwGoodStockTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodStockBindingSource;
        private System.Windows.Forms.BindingSource spGetGoodStockBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spGetGoodStockTableAdapter spGetGoodStockTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnReceipts;
        private DevExpress.XtraGrid.GridControl gcRetailReceipts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRetailReceipts;
        private System.Windows.Forms.BindingSource vwRetailReceiptHistoryBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwRetailReceiptHistoryTableAdapter vwRetailReceiptHistoryTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusName;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarListItem barListItemUser;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colRowNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCashierName;
        private DevExpress.XtraEditors.TextEdit txtDiscountNumber;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnDiscountByNumber;
        private DevExpress.XtraEditors.SimpleButton btnDiscountPercent;
        private DevExpress.XtraEditors.SimpleButton btnDoubleZero;
        private DevExpress.XtraEditors.SimpleButton btnZero;
        private DevExpress.XtraEditors.SimpleButton btnC;
    }
}