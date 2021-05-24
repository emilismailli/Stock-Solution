
namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class GoodActionManager
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlAction = new DevExpress.XtraGrid.GridControl();
            this.vwGoodActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewGoodAction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumNow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeficit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostDeficit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenefis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenefisAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwGoodActionTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodActionTableAdapter();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnDocPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodActionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGoodAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.gridControlAction);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 64);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1354, 675);
            this.groupControl1.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(498, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 21);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridControlAction
            // 
            this.gridControlAction.DataSource = this.vwGoodActionBindingSource;
            this.gridControlAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAction.Location = new System.Drawing.Point(2, 20);
            this.gridControlAction.MainView = this.gridViewGoodAction;
            this.gridControlAction.MenuManager = this.barManager;
            this.gridControlAction.Name = "gridControlAction";
            this.gridControlAction.Size = new System.Drawing.Size(1350, 653);
            this.gridControlAction.TabIndex = 0;
            this.gridControlAction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGoodAction});
            // 
            // vwGoodActionBindingSource
            // 
            this.vwGoodActionBindingSource.DataMember = "VwGoodAction";
            this.vwGoodActionBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewGoodAction
            // 
            this.gridViewGoodAction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFullGoodName,
            this.colAccountName,
            this.colDocumentId,
            this.colQuantity,
            this.colSumNow,
            this.colStockQuantity,
            this.colPriceBuy,
            this.colAmountBuy,
            this.colPayment,
            this.colDeficit,
            this.colCostDeficit,
            this.colDiscountPrice,
            this.colCreateDate,
            this.colUserName,
            this.colAmountRetail,
            this.colAmountWholeSale,
            this.colPriceRetail,
            this.colPriceWholeSale,
            this.colBenefis,
            this.colBenefisAmount});
            this.gridViewGoodAction.GridControl = this.gridControlAction;
            this.gridViewGoodAction.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkib atın";
            this.gridViewGoodAction.Name = "gridViewGoodAction";
            this.gridViewGoodAction.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gridViewGoodAction.OptionsFind.AlwaysVisible = true;
            this.gridViewGoodAction.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewGoodAction.OptionsSelection.InvertSelection = true;
            this.gridViewGoodAction.OptionsSelection.MultiSelect = true;
            this.gridViewGoodAction.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewGoodAction.OptionsView.ShowFooter = true;
            this.gridViewGoodAction.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGoodAction_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "Yekun = {0:0.##}")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 51;
            // 
            // colFullGoodName
            // 
            this.colFullGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colFullGoodName.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colFullGoodName.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName.Caption = "Məhsul";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FullGoodName", " {0:0.##}")});
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 2;
            this.colFullGoodName.Width = 51;
            // 
            // colAccountName
            // 
            this.colAccountName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colAccountName.AppearanceCell.Options.UseFont = true;
            this.colAccountName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colAccountName.AppearanceHeader.Options.UseFont = true;
            this.colAccountName.Caption = "Əməlliyat";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 3;
            this.colAccountName.Width = 51;
            // 
            // colDocumentId
            // 
            this.colDocumentId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colDocumentId.AppearanceCell.Options.UseFont = true;
            this.colDocumentId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDocumentId.AppearanceHeader.Options.UseFont = true;
            this.colDocumentId.Caption = "Qaimə №";
            this.colDocumentId.FieldName = "DocumentId";
            this.colDocumentId.Name = "colDocumentId";
            this.colDocumentId.Visible = true;
            this.colDocumentId.VisibleIndex = 4;
            this.colDocumentId.Width = 51;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.Caption = "Say";
            this.colQuantity.DisplayFormat.FormatString = "{0:0.##}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "{0:0.##}";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            this.colQuantity.Width = 51;
            // 
            // colSumNow
            // 
            this.colSumNow.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colSumNow.AppearanceCell.Options.UseFont = true;
            this.colSumNow.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSumNow.AppearanceHeader.Options.UseFont = true;
            this.colSumNow.Caption = "Sonrakı Say";
            this.colSumNow.FieldName = "SumNow";
            this.colSumNow.Name = "colSumNow";
            this.colSumNow.Visible = true;
            this.colSumNow.VisibleIndex = 6;
            this.colSumNow.Width = 51;
            // 
            // colStockQuantity
            // 
            this.colStockQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colStockQuantity.AppearanceCell.Options.UseFont = true;
            this.colStockQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colStockQuantity.AppearanceHeader.Options.UseFont = true;
            this.colStockQuantity.Caption = "Stok Sayı";
            this.colStockQuantity.DisplayFormat.FormatString = "{0:0.##}";
            this.colStockQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colStockQuantity.FieldName = "StockQuantity";
            this.colStockQuantity.GroupFormat.FormatString = "{0:0.##}";
            this.colStockQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colStockQuantity.Name = "colStockQuantity";
            this.colStockQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "StockQuantity", "{0:0.##}")});
            this.colStockQuantity.Visible = true;
            this.colStockQuantity.VisibleIndex = 7;
            this.colStockQuantity.Width = 51;
            // 
            // colPriceBuy
            // 
            this.colPriceBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colPriceBuy.AppearanceCell.Options.UseFont = true;
            this.colPriceBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPriceBuy.AppearanceHeader.Options.UseFont = true;
            this.colPriceBuy.Caption = "Alış Qiymət";
            this.colPriceBuy.FieldName = "PriceBuy";
            this.colPriceBuy.Name = "colPriceBuy";
            this.colPriceBuy.Visible = true;
            this.colPriceBuy.VisibleIndex = 8;
            this.colPriceBuy.Width = 51;
            // 
            // colAmountBuy
            // 
            this.colAmountBuy.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceCell.Options.UseFont = true;
            this.colAmountBuy.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceHeader.Options.UseFont = true;
            this.colAmountBuy.Caption = "Məbləğ Alış";
            this.colAmountBuy.DisplayFormat.FormatString = "{0:0.##}";
            this.colAmountBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.FieldName = "AmountBuy";
            this.colAmountBuy.GroupFormat.FormatString = "{0:0.##}";
            this.colAmountBuy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.Name = "colAmountBuy";
            this.colAmountBuy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountBuy", "{0:0.##}")});
            this.colAmountBuy.Visible = true;
            this.colAmountBuy.VisibleIndex = 11;
            this.colAmountBuy.Width = 51;
            // 
            // colPayment
            // 
            this.colPayment.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colPayment.AppearanceCell.Options.UseFont = true;
            this.colPayment.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colPayment.AppearanceHeader.Options.UseFont = true;
            this.colPayment.Caption = "Ödəniş";
            this.colPayment.DisplayFormat.FormatString = "{0:0.##}";
            this.colPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPayment.FieldName = "Payment";
            this.colPayment.GroupFormat.FormatString = "{0:0.##}";
            this.colPayment.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPayment.Name = "colPayment";
            this.colPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Payment", "{0:0.##}")});
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 16;
            this.colPayment.Width = 51;
            // 
            // colDeficit
            // 
            this.colDeficit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colDeficit.AppearanceCell.Options.UseFont = true;
            this.colDeficit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDeficit.AppearanceHeader.Options.UseFont = true;
            this.colDeficit.Caption = "Qalıq";
            this.colDeficit.DisplayFormat.FormatString = "{0:0.##}";
            this.colDeficit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDeficit.FieldName = "Deficit";
            this.colDeficit.GroupFormat.FormatString = "{0:0.##}";
            this.colDeficit.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDeficit.Name = "colDeficit";
            this.colDeficit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Deficit", "{0:0.##}")});
            this.colDeficit.Visible = true;
            this.colDeficit.VisibleIndex = 17;
            this.colDeficit.Width = 51;
            // 
            // colCostDeficit
            // 
            this.colCostDeficit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colCostDeficit.AppearanceCell.Options.UseFont = true;
            this.colCostDeficit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCostDeficit.AppearanceHeader.Options.UseFont = true;
            this.colCostDeficit.Caption = "Alış Xərci";
            this.colCostDeficit.FieldName = "CostDeficit";
            this.colCostDeficit.Name = "colCostDeficit";
            this.colCostDeficit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostDeficit", "{0:0.##}")});
            this.colCostDeficit.Visible = true;
            this.colCostDeficit.VisibleIndex = 18;
            this.colCostDeficit.Width = 94;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colDiscountPrice.AppearanceCell.Options.UseFont = true;
            this.colDiscountPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDiscountPrice.AppearanceHeader.Options.UseFont = true;
            this.colDiscountPrice.Caption = "Endirim";
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiscountPrice", "{0:0.##}")});
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 19;
            this.colDiscountPrice.Width = 37;
            // 
            // colCreateDate
            // 
            this.colCreateDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colCreateDate.AppearanceCell.Options.UseFont = true;
            this.colCreateDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colCreateDate.AppearanceHeader.Options.UseFont = true;
            this.colCreateDate.Caption = "Tarix";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 20;
            this.colCreateDate.Width = 37;
            // 
            // colUserName
            // 
            this.colUserName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colUserName.AppearanceCell.Options.UseFont = true;
            this.colUserName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colUserName.AppearanceHeader.Options.UseFont = true;
            this.colUserName.Caption = "İstifadəçi";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 21;
            this.colUserName.Width = 47;
            // 
            // colAmountRetail
            // 
            this.colAmountRetail.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountRetail.AppearanceCell.Options.UseFont = true;
            this.colAmountRetail.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountRetail.AppearanceHeader.Options.UseFont = true;
            this.colAmountRetail.Caption = "Məbləğ Pərakəndə";
            this.colAmountRetail.FieldName = "AmountRetail";
            this.colAmountRetail.Name = "colAmountRetail";
            this.colAmountRetail.Visible = true;
            this.colAmountRetail.VisibleIndex = 12;
            // 
            // colAmountWholeSale
            // 
            this.colAmountWholeSale.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceCell.Options.UseFont = true;
            this.colAmountWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colAmountWholeSale.Caption = "Məbləğ Topdan S.";
            this.colAmountWholeSale.FieldName = "AmountWholeSale";
            this.colAmountWholeSale.Name = "colAmountWholeSale";
            this.colAmountWholeSale.Visible = true;
            this.colAmountWholeSale.VisibleIndex = 13;
            // 
            // colPriceRetail
            // 
            this.colPriceRetail.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceRetail.AppearanceCell.Options.UseFont = true;
            this.colPriceRetail.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceRetail.AppearanceHeader.Options.UseFont = true;
            this.colPriceRetail.Caption = "Pərakəndə Qiymət";
            this.colPriceRetail.FieldName = "PriceRetail";
            this.colPriceRetail.Name = "colPriceRetail";
            this.colPriceRetail.Visible = true;
            this.colPriceRetail.VisibleIndex = 9;
            // 
            // colPriceWholeSale
            // 
            this.colPriceWholeSale.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceCell.Options.UseFont = true;
            this.colPriceWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colPriceWholeSale.Caption = "Topdan Satış Qiymət";
            this.colPriceWholeSale.FieldName = "PriceWholeSale";
            this.colPriceWholeSale.Name = "colPriceWholeSale";
            this.colPriceWholeSale.Visible = true;
            this.colPriceWholeSale.VisibleIndex = 10;
            // 
            // colBenefis
            // 
            this.colBenefis.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefis.AppearanceCell.Options.UseFont = true;
            this.colBenefis.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefis.AppearanceHeader.Options.UseFont = true;
            this.colBenefis.Caption = "QazancPərakəndə";
            this.colBenefis.DisplayFormat.FormatString = "{0:0.##}";
            this.colBenefis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefis.FieldName = "colBenefis";
            this.colBenefis.GroupFormat.FormatString = "{0:0.##}";
            this.colBenefis.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefis.Name = "colBenefis";
            this.colBenefis.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBenefis", "{0:0.##}")});
            this.colBenefis.UnboundExpression = "[AmountRetail] - [AmountBuy]";
            this.colBenefis.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBenefis.Visible = true;
            this.colBenefis.VisibleIndex = 15;
            // 
            // colBenefisAmount
            // 
            this.colBenefisAmount.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefisAmount.AppearanceCell.Options.UseFont = true;
            this.colBenefisAmount.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBenefisAmount.AppearanceHeader.Options.UseFont = true;
            this.colBenefisAmount.Caption = "Qazanc Topdan -S";
            this.colBenefisAmount.DisplayFormat.FormatString = "{0:0.##}";
            this.colBenefisAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefisAmount.FieldName = "colBenefisAmount";
            this.colBenefisAmount.GroupFormat.FormatString = "{0:0.##}";
            this.colBenefisAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBenefisAmount.Name = "colBenefisAmount";
            this.colBenefisAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colBenefisAmount", "{0:0.##}")});
            this.colBenefisAmount.UnboundExpression = "[AmountWholeSale] - [AmountBuy]";
            this.colBenefisAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBenefisAmount.Visible = true;
            this.colBenefisAmount.VisibleIndex = 14;
            // 
            // vwGoodActionTableAdapter
            // 
            this.vwGoodActionTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrinter
            // 
            this.btnPrinter.Caption = "Çap Et";
            this.btnPrinter.Hint = "   ";
            this.btnPrinter.Id = 0;
            this.btnPrinter.ImageOptions.ImageUri.Uri = "Print;Size16x16;GrayScaled";
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Çap Et";
            this.barButtonItem1.Hint = "   ";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "Print;Size16x16;GrayScaled";
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Çap Et";
            this.barButtonItem2.Hint = "   ";
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Print;Size16x16;GrayScaled";
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 24);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1354, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 739);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1354, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 715);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1354, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 715);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.DockControls.Add(this.barDockControl6);
            this.barManager2.DockControls.Add(this.barDockControl7);
            this.barManager2.DockControls.Add(this.barDockControl8);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDocPrint});
            this.barManager2.MainMenu = this.bar6;
            this.barManager2.MaxItemId = 1;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDocPrint, true)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnDocPrint
            // 
            this.btnDocPrint.Caption = "Çap Et";
            this.btnDocPrint.Hint = "Ctrl + P";
            this.btnDocPrint.Id = 0;
            this.btnDocPrint.ImageOptions.ImageUri.Uri = "Print";
            this.btnDocPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnDocPrint.Name = "btnDocPrint";
            this.btnDocPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDocPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDocPrint_ItemClick);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Size = new System.Drawing.Size(1354, 24);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 739);
            this.barDockControl6.Manager = this.barManager2;
            this.barDockControl6.Size = new System.Drawing.Size(1354, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 24);
            this.barDockControl7.Manager = this.barManager2;
            this.barDockControl7.Size = new System.Drawing.Size(0, 715);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1354, 24);
            this.barDockControl8.Manager = this.barManager2;
            this.barDockControl8.Size = new System.Drawing.Size(0, 715);
            // 
            // GoodActionManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
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
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GoodActionManager";
            this.Size = new System.Drawing.Size(1354, 739);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodActionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGoodAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlAction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGoodAction;
        private System.Windows.Forms.BindingSource vwGoodActionBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwGoodActionTableAdapter vwGoodActionTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSumNow;
        private DevExpress.XtraGrid.Columns.GridColumn colStockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colDeficit;
        private DevExpress.XtraGrid.Columns.GridColumn colCostDeficit;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarButtonItem btnDocPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefis;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefisAmount;
    }
}
