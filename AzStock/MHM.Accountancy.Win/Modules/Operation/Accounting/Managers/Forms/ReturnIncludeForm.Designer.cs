namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ReturnIncludeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnIncludeForm));
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwDocumentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoIncludedGood = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwGoodStockSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBarCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAmountBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwIncludeContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCustomerGoodReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.spGetGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullGoodName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditWareHouse = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.spWareHouseSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpDateEditDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.vwWareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwUnitTableAdapter();
            this.vwAccountTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountTableAdapter();
            this.vwContractTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwContractTableAdapter();
            this.colDoseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocSeriesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocCertId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            this.vwBarcodeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter();
            this.vwIncludeContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwIncludeContractChooseTableAdapter();
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            this.chckPinGoodCatalog = new DevExpress.XtraEditors.CheckButton();
            this.colGoodName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcodeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter();
            this.vwCustomerTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter();
            this.vwCustomerGoodReturnTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCustomerGoodReturnTableAdapter();
            this.vwSaleContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter();
            this.erpLookUpEditAccountId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditCustomerId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtContractId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditPaymentType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddGoods = new DevExpress.XtraEditors.SimpleButton();
            this.spWareHouseSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter();
            this.spGetGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spGetGoodStockTableAdapter();
            this.txtPartnerOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.erpDateEditPaymentDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtIncludeNo = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturn = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.vwGoodStockSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockSelectTableAdapter();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscountSaleNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwIncludeContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerGoodReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditAccountId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartnerOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditPaymentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncludeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountSaleNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(853, 507);
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(947, 507);
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 518);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(554, 509);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(666, 509);
            this.btnPrintDocument.Visible = false;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDocumentDetailBindingSource
            // 
            this.vwDocumentDetailBindingSource.DataMember = "VwDocumentDetail";
            this.vwDocumentDetailBindingSource.DataSource = this.dataSet;
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            this.vwGoodBindingSource.DataSource = this.dataSet;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 20);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Nömrə";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 20);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Müəssisə";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 20);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Anbar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(308, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 20);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Sənəd Tarixi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDetail);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(901, 347);
            this.groupControl1.TabIndex = 28;
            // 
            // gridControlDetail
            // 
            this.gridControlDetail.DataSource = this.vwDocumentDetailBindingSource;
            this.gridControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetail.Location = new System.Drawing.Point(2, 20);
            this.gridControlDetail.MainView = this.gridViewDetail;
            this.gridControlDetail.Name = "gridControlDetail";
            this.gridControlDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoIncludedGood,
            this.repoAccount,
            this.repoUnit,
            this.repoBarcode,
            this.repoCustomer});
            this.gridControlDetail.Size = new System.Drawing.Size(897, 325);
            this.gridControlDetail.TabIndex = 0;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoodName,
            this.colAccountName,
            this.colBarCode1,
            this.colQuantity,
            this.colPriceBuy,
            this.colUnitName1,
            this.colAmountBuy,
            this.colDiscountPrice});
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsFind.AlwaysVisible = true;
            this.gridViewDetail.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewDetail.OptionsFind.SearchInPreview = true;
            this.gridViewDetail.OptionsFind.ShowClearButton = false;
            this.gridViewDetail.OptionsFind.ShowFindButton = false;
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDetail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetail.OptionsView.ShowFooter = true;
            this.gridViewDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDetail_FocusedRowChanged);
            this.gridViewDetail.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gridViewDetail_FocusedColumnChanged);
            // 
            // colGoodName
            // 
            this.colGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodName.AppearanceCell.Options.UseFont = true;
            this.colGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodName.AppearanceHeader.Options.UseFont = true;
            this.colGoodName.Caption = "Məhsul adı";
            this.colGoodName.ColumnEdit = this.repoIncludedGood;
            this.colGoodName.FieldName = "GoodId";
            this.colGoodName.Image = ((System.Drawing.Image)(resources.GetObject("colGoodName.Image")));
            this.colGoodName.Name = "colGoodName";
            this.colGoodName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "GoodId", "Yekun")});
            this.colGoodName.Visible = true;
            this.colGoodName.VisibleIndex = 1;
            this.colGoodName.Width = 141;
            // 
            // repoIncludedGood
            // 
            this.repoIncludedGood.AutoHeight = false;
            this.repoIncludedGood.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoIncludedGood.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodName", "Ad", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodTypeName", "Nov", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Say", 52, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repoIncludedGood.DataSource = this.vwGoodStockSelectBindingSource;
            this.repoIncludedGood.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repoIncludedGood.DisplayMember = "GoodName";
            this.repoIncludedGood.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            this.repoIncludedGood.ImmediatePopup = true;
            this.repoIncludedGood.Name = "repoIncludedGood";
            this.repoIncludedGood.NullText = "[Seçim Edilməyib]";
            this.repoIncludedGood.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.repoIncludedGood.ValueMember = "Id";
            this.repoIncludedGood.EditValueChanged += new System.EventHandler(this.repoIncludedGood_EditValueChanged);
            // 
            // vwGoodStockSelectBindingSource
            // 
            this.vwGoodStockSelectBindingSource.DataMember = "VwGoodStockSelect";
            this.vwGoodStockSelectBindingSource.DataSource = this.dataSet;
            // 
            // colAccountName
            // 
            this.colAccountName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAccountName.AppearanceCell.Options.UseFont = true;
            this.colAccountName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAccountName.AppearanceHeader.Options.UseFont = true;
            this.colAccountName.Caption = "Hesab";
            this.colAccountName.ColumnEdit = this.repoAccount;
            this.colAccountName.FieldName = "AccountId";
            this.colAccountName.Image = ((System.Drawing.Image)(resources.GetObject("colAccountName.Image")));
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 2;
            this.colAccountName.Width = 141;
            // 
            // repoAccount
            // 
            this.repoAccount.AutoHeight = false;
            this.repoAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoAccount.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kod", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoAccount.DataSource = this.vwAccountBindingSource;
            this.repoAccount.DisplayMember = "Name";
            this.repoAccount.Name = "repoAccount";
            this.repoAccount.NullText = "[Seçim Edilməyib]";
            this.repoAccount.ValueMember = "Id";
            // 
            // vwAccountBindingSource
            // 
            this.vwAccountBindingSource.DataMember = "VwAccount";
            this.vwAccountBindingSource.DataSource = this.dataSet;
            // 
            // colBarCode1
            // 
            this.colBarCode1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarCode1.AppearanceCell.Options.UseFont = true;
            this.colBarCode1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarCode1.AppearanceHeader.Options.UseFont = true;
            this.colBarCode1.Caption = "Barkod";
            this.colBarCode1.ColumnEdit = this.repoBarcode;
            this.colBarCode1.FieldName = "BarCodeId";
            this.colBarCode1.Image = ((System.Drawing.Image)(resources.GetObject("colBarCode1.Image")));
            this.colBarCode1.Name = "colBarCode1";
            this.colBarCode1.Visible = true;
            this.colBarCode1.VisibleIndex = 3;
            this.colBarCode1.Width = 141;
            // 
            // repoBarcode
            // 
            this.repoBarcode.AutoHeight = false;
            this.repoBarcode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBarcode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barkod", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullGoodName", "Məhsul", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoBarcode.DataSource = this.vwBarcodeBindingSource;
            this.repoBarcode.DisplayMember = "Barcode";
            this.repoBarcode.Name = "repoBarcode";
            this.repoBarcode.NullText = "[Seçim Edilməyib]";
            this.repoBarcode.ValueMember = "Id";
            this.repoBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repoBarcode_KeyDown);
            // 
            // vwBarcodeBindingSource
            // 
            this.vwBarcodeBindingSource.DataMember = "VwBarcode";
            this.vwBarcodeBindingSource.DataSource = this.dataSet;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            this.colQuantity.Width = 111;
            // 
            // colPriceBuy
            // 
            this.colPriceBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceCell.Options.UseFont = true;
            this.colPriceBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceHeader.Options.UseFont = true;
            this.colPriceBuy.Caption = "Qiymət";
            this.colPriceBuy.DisplayFormat.FormatString = "{0:0.######}";
            this.colPriceBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceBuy.FieldName = "PriceBuy";
            this.colPriceBuy.GroupFormat.FormatString = "{0:0.######}";
            this.colPriceBuy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceBuy.Image = ((System.Drawing.Image)(resources.GetObject("colPriceBuy.Image")));
            this.colPriceBuy.Name = "colPriceBuy";
            this.colPriceBuy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PriceBuy", "{0:0.##}")});
            this.colPriceBuy.Visible = true;
            this.colPriceBuy.VisibleIndex = 7;
            this.colPriceBuy.Width = 150;
            // 
            // colUnitName1
            // 
            this.colUnitName1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitName1.AppearanceCell.Options.UseFont = true;
            this.colUnitName1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitName1.AppearanceHeader.Options.UseFont = true;
            this.colUnitName1.Caption = "Ölçü vahidi";
            this.colUnitName1.ColumnEdit = this.repoUnit;
            this.colUnitName1.FieldName = "UnitId";
            this.colUnitName1.Image = ((System.Drawing.Image)(resources.GetObject("colUnitName1.Image")));
            this.colUnitName1.Name = "colUnitName1";
            this.colUnitName1.Visible = true;
            this.colUnitName1.VisibleIndex = 5;
            this.colUnitName1.Width = 150;
            // 
            // repoUnit
            // 
            this.repoUnit.AutoHeight = false;
            this.repoUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Adı", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoUnit.DataSource = this.vwUnitBindingSource;
            this.repoUnit.DisplayMember = "Name";
            this.repoUnit.Name = "repoUnit";
            this.repoUnit.NullText = "[Seçim Edilməyib]";
            this.repoUnit.ValueMember = "Id";
            // 
            // vwUnitBindingSource
            // 
            this.vwUnitBindingSource.DataMember = "VwUnit";
            this.vwUnitBindingSource.DataSource = this.dataSet;
            // 
            // colAmountBuy
            // 
            this.colAmountBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceCell.Options.UseFont = true;
            this.colAmountBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceHeader.Options.UseFont = true;
            this.colAmountBuy.Caption = "Məbləğ";
            this.colAmountBuy.DisplayFormat.FormatString = "{0:0.######}";
            this.colAmountBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.FieldName = "AmountBuy";
            this.colAmountBuy.GroupFormat.FormatString = "{0:0.######}";
            this.colAmountBuy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.Image = ((System.Drawing.Image)(resources.GetObject("colAmountBuy.Image")));
            this.colAmountBuy.Name = "colAmountBuy";
            this.colAmountBuy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountBuy", "{0:0.##}")});
            this.colAmountBuy.Visible = true;
            this.colAmountBuy.VisibleIndex = 8;
            this.colAmountBuy.Width = 154;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDiscountPrice.AppearanceCell.Options.UseFont = true;
            this.colDiscountPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDiscountPrice.AppearanceHeader.Options.UseFont = true;
            this.colDiscountPrice.Caption = "Endirim";
            this.colDiscountPrice.FieldName = "DiscountPrice";
            this.colDiscountPrice.Image = ((System.Drawing.Image)(resources.GetObject("colDiscountPrice.Image")));
            this.colDiscountPrice.Name = "colDiscountPrice";
            this.colDiscountPrice.Visible = true;
            this.colDiscountPrice.VisibleIndex = 6;
            // 
            // repoCustomer
            // 
            this.repoCustomer.AutoHeight = false;
            this.repoCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCustomer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Müəssisə", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoCustomer.DataSource = this.vwIncludeContractChooseBindingSource;
            this.repoCustomer.DisplayMember = "CustomerName";
            this.repoCustomer.Name = "repoCustomer";
            this.repoCustomer.NullText = "[Seçim Edilməyib]";
            this.repoCustomer.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.repoCustomer.ValueMember = "Id";
            // 
            // vwIncludeContractChooseBindingSource
            // 
            this.vwIncludeContractChooseBindingSource.DataMember = "VwIncludeContractChoose";
            this.vwIncludeContractChooseBindingSource.DataSource = this.dataSet;
            // 
            // vwSaleContractChooseBindingSource
            // 
            this.vwSaleContractChooseBindingSource.DataMember = "VwSaleContractChoose";
            this.vwSaleContractChooseBindingSource.DataSource = this.dataSet;
            // 
            // vwCustomerGoodReturnBindingSource
            // 
            this.vwCustomerGoodReturnBindingSource.DataMember = "VwCustomerGoodReturn";
            this.vwCustomerGoodReturnBindingSource.DataSource = this.dataSet;
            // 
            // vwCustomerBindingSource
            // 
            this.vwCustomerBindingSource.DataMember = "VwCustomer";
            this.vwCustomerBindingSource.DataSource = this.dataSet;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(6, 156);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer.Panel1.Text = "Panel1";
            this.splitContainer.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer.Panel2.Text = "Panel2";
            this.splitContainer.Size = new System.Drawing.Size(1029, 347);
            this.splitContainer.SplitterPosition = 901;
            this.splitContainer.TabIndex = 37;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlStock);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(123, 347);
            this.groupControl2.TabIndex = 30;
            // 
            // gridControlStock
            // 
            this.gridControlStock.DataSource = this.spGetGoodStockBindingSource;
            this.gridControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStock.Location = new System.Drawing.Point(2, 20);
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.Size = new System.Drawing.Size(119, 325);
            this.gridControlStock.TabIndex = 0;
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
            this.colQuantity1,
            this.colFullGoodName1,
            this.colDescription1});
            this.gridViewStock.GridControl = this.gridControlStock;
            this.gridViewStock.Name = "gridViewStock";
            this.gridViewStock.OptionsBehavior.ReadOnly = true;
            this.gridViewStock.OptionsFind.AlwaysVisible = true;
            this.gridViewStock.OptionsFind.FindNullPrompt = "Axtarış sözünü yazın...";
            this.gridViewStock.OptionsFind.ShowClearButton = false;
            this.gridViewStock.OptionsFind.ShowFindButton = false;
            this.gridViewStock.OptionsView.ShowFooter = true;
            this.gridViewStock.OptionsView.ShowGroupPanel = false;
            this.gridViewStock.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridViewStock_MasterRowExpanded);
            // 
            // colQuantity1
            // 
            this.colQuantity1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity1.AppearanceCell.Options.UseFont = true;
            this.colQuantity1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity1.AppearanceHeader.Options.UseFont = true;
            this.colQuantity1.Caption = "Sayı";
            this.colQuantity1.DisplayFormat.FormatString = "{0:0.######}";
            this.colQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.GroupFormat.FormatString = "{0:0.######}";
            this.colQuantity1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity1.Image = ((System.Drawing.Image)(resources.GetObject("colQuantity1.Image")));
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "Yekun={0:0.######}")});
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 1;
            this.colQuantity1.Width = 91;
            // 
            // colFullGoodName1
            // 
            this.colFullGoodName1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName1.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName1.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName1.Caption = "Məhsul adı";
            this.colFullGoodName1.FieldName = "FullGoodName";
            this.colFullGoodName1.Image = ((System.Drawing.Image)(resources.GetObject("colFullGoodName1.Image")));
            this.colFullGoodName1.Name = "colFullGoodName1";
            this.colFullGoodName1.Visible = true;
            this.colFullGoodName1.VisibleIndex = 0;
            this.colFullGoodName1.Width = 131;
            // 
            // colDescription1
            // 
            this.colDescription1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription1.AppearanceCell.Options.UseFont = true;
            this.colDescription1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription1.AppearanceHeader.Options.UseFont = true;
            this.colDescription1.Caption = "Saxlanma Yeri";
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Image = ((System.Drawing.Image)(resources.GetObject("colDescription1.Image")));
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 2;
            this.colDescription1.Width = 171;
            // 
            // vwGoodStockBindingSource
            // 
            this.vwGoodStockBindingSource.DataMember = "VwGoodStock";
            this.vwGoodStockBindingSource.DataSource = this.dataSet;
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(83, 60);
            this.erpLookUpEditCompany.Name = "erpLookUpEditCompany";
            this.erpLookUpEditCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditCompany.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Müəssisə", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegionName", "Region", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCompany.Properties.DataSource = this.vwCompanyBindingSource;
            this.erpLookUpEditCompany.Properties.DisplayMember = "CompanyName";
            this.erpLookUpEditCompany.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCompany.Properties.ValueMember = "Id";
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(210, 26);
            this.erpLookUpEditCompany.TabIndex = 39;
            this.erpLookUpEditCompany.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCompany_ButtonClick);
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.dataSet;
            // 
            // erpLookUpEditWareHouse
            // 
            this.erpLookUpEditWareHouse.Location = new System.Drawing.Point(83, 91);
            this.erpLookUpEditWareHouse.Name = "erpLookUpEditWareHouse";
            this.erpLookUpEditWareHouse.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditWareHouse.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditWareHouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditWareHouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Anbar adı", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Qeyd", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditWareHouse.Properties.DataSource = this.spWareHouseSelectBindingSource;
            this.erpLookUpEditWareHouse.Properties.DisplayMember = "Name";
            this.erpLookUpEditWareHouse.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditWareHouse.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.erpLookUpEditWareHouse.Properties.ValueMember = "Id";
            this.erpLookUpEditWareHouse.Size = new System.Drawing.Size(210, 26);
            this.erpLookUpEditWareHouse.TabIndex = 40;
            this.erpLookUpEditWareHouse.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditWareHouse_ButtonClick);
            this.erpLookUpEditWareHouse.EditValueChanged += new System.EventHandler(this.erpLookUpEditWareHouse_EditValueChanged);
            // 
            // spWareHouseSelectBindingSource
            // 
            this.spWareHouseSelectBindingSource.DataMember = "spWareHouseSelect";
            this.spWareHouseSelectBindingSource.DataSource = this.dataSet;
            // 
            // vwWareHouseBindingSource
            // 
            this.vwWareHouseBindingSource.DataMember = "VwWareHouse";
            this.vwWareHouseBindingSource.DataSource = this.dataSet;
            // 
            // vwContractBindingSource
            // 
            this.vwContractBindingSource.DataMember = "VwContract";
            this.vwContractBindingSource.DataSource = this.dataSet;
            // 
            // erpDateEditDate
            // 
            this.erpDateEditDate.EditValue = null;
            this.erpDateEditDate.Location = new System.Drawing.Point(403, 123);
            this.erpDateEditDate.Name = "erpDateEditDate";
            this.erpDateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpDateEditDate.Properties.Appearance.Options.UseFont = true;
            this.erpDateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpDateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.erpDateEditDate.Properties.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.erpDateEditDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.erpDateEditDate.Properties.EditFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.erpDateEditDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.erpDateEditDate.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.erpDateEditDate.Properties.NullText = "[Seçim edilməyib]";
            this.erpDateEditDate.Size = new System.Drawing.Size(209, 26);
            this.erpDateEditDate.TabIndex = 42;
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = "";
            this.txtNumber.Location = new System.Drawing.Point(83, 30);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(210, 26);
            this.txtNumber.TabIndex = 43;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // vwWareHouseTableAdapter
            // 
            this.vwWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // vwUnitTableAdapter
            // 
            this.vwUnitTableAdapter.ClearBeforeFill = true;
            // 
            // vwAccountTableAdapter
            // 
            this.vwAccountTableAdapter.ClearBeforeFill = true;
            // 
            // vwContractTableAdapter
            // 
            this.vwContractTableAdapter.ClearBeforeFill = true;
            // 
            // colDoseName
            // 
            this.colDoseName.FieldName = "DoseName";
            this.colDoseName.Name = "colDoseName";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colPackingTypeName
            // 
            this.colPackingTypeName.Caption = "Paket Növü";
            this.colPackingTypeName.FieldName = "PackingTypeName";
            this.colPackingTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPackingTypeName.Image")));
            this.colPackingTypeName.Name = "colPackingTypeName";
            // 
            // colGoodName1
            // 
            this.colGoodName1.Caption = "Məhsul Adı";
            this.colGoodName1.FieldName = "GoodName";
            this.colGoodName1.Image = ((System.Drawing.Image)(resources.GetObject("colGoodName1.Image")));
            this.colGoodName1.Name = "colGoodName1";
            this.colGoodName1.OptionsColumn.AllowEdit = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colGoodTypeId
            // 
            this.colGoodTypeId.FieldName = "GoodTypeId";
            this.colGoodTypeId.Name = "colGoodTypeId";
            // 
            // colManufacturerCompanyId
            // 
            this.colManufacturerCompanyId.FieldName = "ManufacturerCompanyId";
            this.colManufacturerCompanyId.Name = "colManufacturerCompanyId";
            // 
            // colRegionId
            // 
            this.colRegionId.FieldName = "RegionId";
            this.colRegionId.Name = "colRegionId";
            // 
            // colDoseId
            // 
            this.colDoseId.FieldName = "DoseId";
            this.colDoseId.Name = "colDoseId";
            // 
            // colUnitId
            // 
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            // 
            // colPackingTypeId
            // 
            this.colPackingTypeId.FieldName = "PackingTypeId";
            this.colPackingTypeId.Name = "colPackingTypeId";
            // 
            // colDocSeriesId
            // 
            this.colDocSeriesId.FieldName = "DocSeriesId";
            this.colDocSeriesId.Name = "colDocSeriesId";
            // 
            // colDocCertId
            // 
            this.colDocCertId.FieldName = "DocCertId";
            this.colDocCertId.Name = "colDocCertId";
            // 
            // colDocTypeId
            // 
            this.colDocTypeId.FieldName = "DocTypeId";
            this.colDocTypeId.Name = "colDocTypeId";
            // 
            // colModifyDate
            // 
            this.colModifyDate.FieldName = "ModifyDate";
            this.colModifyDate.Name = "colModifyDate";
            // 
            // colModifyId
            // 
            this.colModifyId.FieldName = "ModifyId";
            this.colModifyId.Name = "colModifyId";
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            // 
            // colCreateId
            // 
            this.colCreateId.FieldName = "CreateId";
            this.colCreateId.Name = "colCreateId";
            // 
            // colPriceWholeSale
            // 
            this.colPriceWholeSale.Caption = "Qiymət -Topdan Satış";
            this.colPriceWholeSale.FieldName = "PriceWholeSale";
            this.colPriceWholeSale.Image = ((System.Drawing.Image)(resources.GetObject("colPriceWholeSale.Image")));
            this.colPriceWholeSale.Name = "colPriceWholeSale";
            this.colPriceWholeSale.Width = 43;
            // 
            // colAmountRetail
            // 
            this.colAmountRetail.Caption = "Məbləğ-Satış";
            this.colAmountRetail.DisplayFormat.FormatString = "{0:0.######}";
            this.colAmountRetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.FieldName = "AmountRetail";
            this.colAmountRetail.GroupFormat.FormatString = "{0:0.######}";
            this.colAmountRetail.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.Image = ((System.Drawing.Image)(resources.GetObject("colAmountRetail.Image")));
            this.colAmountRetail.Name = "colAmountRetail";
            this.colAmountRetail.OptionsColumn.ReadOnly = true;
            this.colAmountRetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountRetail", "Yekun={0:0.######}")});
            this.colAmountRetail.Width = 43;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // vwBarcodeTableAdapter
            // 
            this.vwBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // vwIncludeContractChooseTableAdapter
            // 
            this.vwIncludeContractChooseTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // chckPinGoodCatalog
            // 
            this.chckPinGoodCatalog.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckPinGoodCatalog.Appearance.Options.UseFont = true;
            this.chckPinGoodCatalog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chckPinGoodCatalog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chckPinGoodCatalog.ImageOptions.Image")));
            this.chckPinGoodCatalog.Location = new System.Drawing.Point(888, 90);
            this.chckPinGoodCatalog.Name = "chckPinGoodCatalog";
            this.chckPinGoodCatalog.Size = new System.Drawing.Size(41, 31);
            this.chckPinGoodCatalog.TabIndex = 38;
            this.chckPinGoodCatalog.CheckedChanged += new System.EventHandler(this.chckPinGoodCatalog_CheckedChanged);
            // 
            // colGoodName2
            // 
            this.colGoodName2.FieldName = "GoodName";
            this.colGoodName2.Name = "colGoodName2";
            // 
            // colBarcodeId
            // 
            this.colBarcodeId.FieldName = "BarcodeId";
            this.colBarcodeId.Name = "colBarcodeId";
            // 
            // vwGoodStockTableAdapter
            // 
            this.vwGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // vwCustomerTableAdapter
            // 
            this.vwCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // vwCustomerGoodReturnTableAdapter
            // 
            this.vwCustomerGoodReturnTableAdapter.ClearBeforeFill = true;
            // 
            // vwSaleContractChooseTableAdapter
            // 
            this.vwSaleContractChooseTableAdapter.ClearBeforeFill = true;
            // 
            // erpLookUpEditAccountId
            // 
            this.erpLookUpEditAccountId.Location = new System.Drawing.Point(1223, 12);
            this.erpLookUpEditAccountId.Name = "erpLookUpEditAccountId";
            this.erpLookUpEditAccountId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditAccountId.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditAccountId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditAccountId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Anbar adı", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Qeyd", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditAccountId.Properties.DataSource = this.vwAccountBindingSource;
            this.erpLookUpEditAccountId.Properties.DisplayMember = "Name";
            this.erpLookUpEditAccountId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditAccountId.Properties.ValueMember = "Id";
            this.erpLookUpEditAccountId.Size = new System.Drawing.Size(68, 26);
            this.erpLookUpEditAccountId.TabIndex = 53;
            this.erpLookUpEditAccountId.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1109, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 20);
            this.labelControl5.TabIndex = 54;
            this.labelControl5.Text = "Əməliyyat Növü";
            this.labelControl5.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(324, 33);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 20);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Təchizatçı";
            // 
            // erpLookUpEditCustomerId
            // 
            this.erpLookUpEditCustomerId.Location = new System.Drawing.Point(403, 30);
            this.erpLookUpEditCustomerId.Name = "erpLookUpEditCustomerId";
            this.erpLookUpEditCustomerId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditCustomerId.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditCustomerId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditCustomerId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContractId", "Müqavilə Adı", 150, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Təchizatçı Firma", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCustomerId.Properties.DataSource = this.vwIncludeContractChooseBindingSource;
            this.erpLookUpEditCustomerId.Properties.DisplayMember = "CustomerName";
            this.erpLookUpEditCustomerId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCustomerId.Properties.ValueMember = "ContractId";
            this.erpLookUpEditCustomerId.Size = new System.Drawing.Size(209, 26);
            this.erpLookUpEditCustomerId.TabIndex = 56;
            this.erpLookUpEditCustomerId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCustomerId_ButtonClick);
            this.erpLookUpEditCustomerId.EditValueChanged += new System.EventHandler(this.erpLookUpEditCustomerId_EditValueChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(333, 93);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(62, 20);
            this.labelControl10.TabIndex = 57;
            this.labelControl10.Text = "Müqavilə";
            // 
            // txtContractId
            // 
            this.txtContractId.EditValue = "";
            this.txtContractId.Location = new System.Drawing.Point(403, 91);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractId.Properties.Appearance.Options.UseFont = true;
            this.txtContractId.Properties.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(209, 26);
            this.txtContractId.TabIndex = 58;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(660, 33);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 20);
            this.labelControl11.TabIndex = 59;
            this.labelControl11.Text = "Ödəniş";
            // 
            // erpLookUpEditPaymentType
            // 
            this.erpLookUpEditPaymentType.Location = new System.Drawing.Point(715, 32);
            this.erpLookUpEditPaymentType.Name = "erpLookUpEditPaymentType";
            this.erpLookUpEditPaymentType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditPaymentType.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditPaymentType.Properties.DataSource = this.vwPaymentTypeBindingSource;
            this.erpLookUpEditPaymentType.Properties.DisplayMember = "Name";
            this.erpLookUpEditPaymentType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditPaymentType.Properties.ValueMember = "Id";
            this.erpLookUpEditPaymentType.Size = new System.Drawing.Size(211, 26);
            this.erpLookUpEditPaymentType.TabIndex = 60;
            // 
            // vwPaymentTypeBindingSource
            // 
            this.vwPaymentTypeBindingSource.DataMember = "VwPaymentType";
            this.vwPaymentTypeBindingSource.DataSource = this.dataSet;
            // 
            // vwPaymentTypeTableAdapter
            // 
            this.vwPaymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(35, 123);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 20);
            this.labelControl12.TabIndex = 62;
            this.labelControl12.Text = "Qeyd";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(83, 123);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtDescription.Size = new System.Drawing.Size(210, 26);
            this.txtDescription.TabIndex = 61;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDeleteGoods);
            this.groupControl4.Controls.Add(this.btnApplyGoods);
            this.groupControl4.Controls.Add(this.btnAddGoods);
            this.groupControl4.Location = new System.Drawing.Point(935, 31);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(95, 119);
            this.groupControl4.TabIndex = 115;
            this.groupControl4.Text = "Məhsullar";
            this.groupControl4.Visible = false;
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteGoods.ImageOptions.Image")));
            this.btnDeleteGoods.Location = new System.Drawing.Point(9, 80);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteGoods.TabIndex = 2;
            this.btnDeleteGoods.Text = "Sil";
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // btnApplyGoods
            // 
            this.btnApplyGoods.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyGoods.ImageOptions.Image")));
            this.btnApplyGoods.Location = new System.Drawing.Point(9, 50);
            this.btnApplyGoods.Name = "btnApplyGoods";
            this.btnApplyGoods.Size = new System.Drawing.Size(78, 29);
            this.btnApplyGoods.TabIndex = 1;
            this.btnApplyGoods.Text = "Təsdiqlə";
            this.btnApplyGoods.Click += new System.EventHandler(this.btnApplyGoods_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGoods.ImageOptions.Image")));
            this.btnAddGoods.Location = new System.Drawing.Point(8, 20);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(79, 29);
            this.btnAddGoods.TabIndex = 0;
            this.btnAddGoods.Text = "Yeni";
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // spWareHouseSelectTableAdapter
            // 
            this.spWareHouseSelectTableAdapter.ClearBeforeFill = true;
            // 
            // spGetGoodStockTableAdapter
            // 
            this.spGetGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // txtPartnerOrderNo
            // 
            this.txtPartnerOrderNo.EditValue = "";
            this.txtPartnerOrderNo.Location = new System.Drawing.Point(403, 59);
            this.txtPartnerOrderNo.Name = "txtPartnerOrderNo";
            this.txtPartnerOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPartnerOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtPartnerOrderNo.Size = new System.Drawing.Size(209, 30);
            this.txtPartnerOrderNo.TabIndex = 121;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(301, 63);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(94, 20);
            this.labelControl7.TabIndex = 122;
            this.labelControl7.Text = "T-çı Qaimə №";
            // 
            // erpDateEditPaymentDate
            // 
            this.erpDateEditPaymentDate.EditValue = null;
            this.erpDateEditPaymentDate.Location = new System.Drawing.Point(715, 60);
            this.erpDateEditPaymentDate.Name = "erpDateEditPaymentDate";
            this.erpDateEditPaymentDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpDateEditPaymentDate.Properties.Appearance.Options.UseFont = true;
            this.erpDateEditPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpDateEditPaymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.erpDateEditPaymentDate.Properties.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.erpDateEditPaymentDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.erpDateEditPaymentDate.Properties.EditFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.erpDateEditPaymentDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.erpDateEditPaymentDate.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.erpDateEditPaymentDate.Properties.NullText = "[Seçim edilməyib]";
            this.erpDateEditPaymentDate.Size = new System.Drawing.Size(211, 26);
            this.erpDateEditPaymentDate.TabIndex = 124;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(620, 66);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 20);
            this.labelControl8.TabIndex = 125;
            this.labelControl8.Text = "Ödəniş Tarixi";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(616, 92);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(94, 20);
            this.labelControl9.TabIndex = 127;
            this.labelControl9.Text = "Alış Qaimə №";
            // 
            // txtIncludeNo
            // 
            this.txtIncludeNo.EditValue = "";
            this.txtIncludeNo.Location = new System.Drawing.Point(715, 87);
            this.txtIncludeNo.Name = "txtIncludeNo";
            this.txtIncludeNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIncludeNo.Properties.Appearance.Options.UseFont = true;
            this.txtIncludeNo.Size = new System.Drawing.Size(160, 30);
            this.txtIncludeNo.TabIndex = 126;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnReturn,
            this.btnClose,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReturn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Məhsul Əlavə Et";
            this.barButtonItem1.Hint = "   ";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "Add;Size16x16;GrayScaled";
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Məhsul Əlavə Et";
            this.barButtonItem2.Hint = "   ";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Caption = "Təsdiqlə";
            this.btnReturn.Hint = "    ";
            this.btnReturn.Id = 2;
            this.btnReturn.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnReturn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter));
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReturn_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "İmtina Et";
            this.btnClose.Hint = "     ";
            this.btnClose.Id = 3;
            this.btnClose.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Endirim Hesabla";
            this.barButtonItem3.Hint = "   ";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.ImageUri.Uri = "Summary;Size16x16;GrayScaled";
            this.barButtonItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1043, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1043, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 526);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1043, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 526);
            // 
            // vwGoodStockSelectTableAdapter
            // 
            this.vwGoodStockSelectTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(647, 134);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(56, 16);
            this.labelControl13.TabIndex = 221;
            this.labelControl13.Text = "Rəqəmlə";
            // 
            // txtDiscountSaleNumber
            // 
            this.txtDiscountSaleNumber.EditValue = "";
            this.txtDiscountSaleNumber.Location = new System.Drawing.Point(716, 119);
            this.txtDiscountSaleNumber.Name = "txtDiscountSaleNumber";
            this.txtDiscountSaleNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscountSaleNumber.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountSaleNumber.Size = new System.Drawing.Size(159, 30);
            this.txtDiscountSaleNumber.TabIndex = 219;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(658, 120);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(45, 16);
            this.labelControl14.TabIndex = 220;
            this.labelControl14.Text = "Endirim";
            // 
            // ReturnIncludeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 550);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtDiscountSaleNumber);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtIncludeNo);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.erpDateEditPaymentDate);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtPartnerOrderNo);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.erpLookUpEditPaymentType);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtContractId);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.erpLookUpEditCustomerId);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.erpLookUpEditAccountId);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.erpLookUpEditCompany);
            this.Controls.Add(this.erpDateEditDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.erpLookUpEditWareHouse);
            this.Controls.Add(this.chckPinGoodCatalog);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1059, 589);
            this.Name = "ReturnIncludeForm";
            this.Text = "Mədaxildə Geri Qaytarmalar";
            this.Load += new System.EventHandler(this.ReturnIncludeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IncludeForm_KeyDown);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.chckPinGoodCatalog, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditWareHouse, 0);
            this.Controls.SetChildIndex(this.txtNumber, 0);
            this.Controls.SetChildIndex(this.erpDateEditDate, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCompany, 0);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditAccountId, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCustomerId, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.txtContractId, 0);
            this.Controls.SetChildIndex(this.labelControl10, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditPaymentType, 0);
            this.Controls.SetChildIndex(this.labelControl11, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.labelControl12, 0);
            this.Controls.SetChildIndex(this.groupControl4, 0);
            this.Controls.SetChildIndex(this.txtPartnerOrderNo, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.erpDateEditPaymentDate, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.txtIncludeNo, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.labelControl14, 0);
            this.Controls.SetChildIndex(this.txtDiscountSaleNumber, 0);
            this.Controls.SetChildIndex(this.labelControl13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwIncludeContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerGoodReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditAccountId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPartnerOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditPaymentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncludeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountSaleNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompany;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditWareHouse;
        private Business.Infrastructure.UI.erpDateEdit erpDateEditDate;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoIncludedGood;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoAccount;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private System.Windows.Forms.BindingSource vwWareHouseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter vwWareHouseTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoUnit;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private Data.AccountingDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
        private System.Windows.Forms.BindingSource vwAccountBindingSource;
        private Data.AccountingDataSetTableAdapters.VwAccountTableAdapter vwAccountTableAdapter;
        private System.Windows.Forms.BindingSource vwContractBindingSource;
        private Data.AccountingDataSetTableAdapters.VwContractTableAdapter vwContractTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDoseName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionId;
        private DevExpress.XtraGrid.Columns.GridColumn colDoseId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocSeriesId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCertId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateId;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountRetail;
        private System.Windows.Forms.BindingSource vwDocumentDetailBindingSource;
        private Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoBarcode;
        private System.Windows.Forms.BindingSource vwBarcodeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter vwBarcodeTableAdapter;
        private System.Windows.Forms.BindingSource vwIncludeContractChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwIncludeContractChooseTableAdapter vwIncludeContractChooseTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private DevExpress.XtraEditors.CheckButton chckPinGoodCatalog;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName2;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcodeId;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        //private Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter vwGoodStockTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStock;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private System.Windows.Forms.BindingSource vwGoodStockBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter vwGoodStockTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoCustomer;
        private System.Windows.Forms.BindingSource vwCustomerBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter vwCustomerTableAdapter;
        private System.Windows.Forms.BindingSource vwCustomerGoodReturnBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCustomerGoodReturnTableAdapter vwCustomerGoodReturnTableAdapter;
        private System.Windows.Forms.BindingSource vwSaleContractChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter vwSaleContractChooseTableAdapter;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditAccountId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountBuy;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtContractId;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPaymentType;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private Business.Infrastructure.UI.erpMemoExEdit txtDescription;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnDeleteGoods;
        private DevExpress.XtraEditors.SimpleButton btnApplyGoods;
        private DevExpress.XtraEditors.SimpleButton btnAddGoods;
        private System.Windows.Forms.BindingSource spWareHouseSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter spWareHouseSelectTableAdapter;
        private System.Windows.Forms.BindingSource spGetGoodStockBindingSource;
        private Data.AccountingDataSetTableAdapters.spGetGoodStockTableAdapter spGetGoodStockTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtPartnerOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Business.Infrastructure.UI.erpDateEdit erpDateEditPaymentDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtIncludeNo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource vwGoodStockSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodStockSelectTableAdapter vwGoodStockSelectTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnReturn;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtDiscountSaleNumber;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
    }
}