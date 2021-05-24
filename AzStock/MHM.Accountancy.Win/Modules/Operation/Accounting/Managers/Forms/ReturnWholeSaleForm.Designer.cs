namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ReturnWholeSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnWholeSaleForm));
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
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBarCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPriceWholeSale1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeficit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwIncludeContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCustomerGoodReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.vwGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullGoodName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditWareHouse = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpDateEditDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtSaleRetail = new DevExpress.XtraEditors.TextEdit();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.vwWareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwUnitTableAdapter();
            this.vwAccountTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountTableAdapter();
            this.vwContractTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwContractTableAdapter();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscountWholeSale = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscountBuy = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountWholeSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountBuy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(1067, 509);
            this.btnAccept.Size = new System.Drawing.Size(88, 29);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1160, 509);
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 518);
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
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 14);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Nömrə";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 14);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Müəssisə adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(300, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 14);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Anbar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(300, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 14);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tarix";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDetail);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(920, 427);
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
            this.gridControlDetail.Size = new System.Drawing.Size(916, 405);
            this.gridControlDetail.TabIndex = 0;
            this.gridControlDetail.UseEmbeddedNavigator = true;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoodName,
            this.colAccountName,
            this.colBarCode1,
            this.colSeries,
            this.colQuantity,
            this.colUnitName1,
            this.colPriceWholeSale1,
            this.colAmountWholeSale,
            this.colPayment,
            this.colDeficit});
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsFind.AlwaysVisible = true;
            this.gridViewDetail.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewDetail.OptionsFind.SearchInPreview = true;
            this.gridViewDetail.OptionsFind.ShowClearButton = false;
            this.gridViewDetail.OptionsFind.ShowFindButton = false;
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetail.OptionsView.ShowFooter = true;
            this.gridViewDetail.OptionsView.ShowGroupPanel = false;
            this.gridViewDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDetail_FocusedRowChanged);
            this.gridViewDetail.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gridViewDetail_FocusedColumnChanged);
            // 
            // colGoodName
            // 
            this.colGoodName.Caption = "Məhsul adı";
            this.colGoodName.ColumnEdit = this.repoIncludedGood;
            this.colGoodName.FieldName = "GoodId";
            this.colGoodName.Name = "colGoodName";
            this.colGoodName.Visible = true;
            this.colGoodName.VisibleIndex = 0;
            // 
            // repoIncludedGood
            // 
            this.repoIncludedGood.AutoHeight = false;
            this.repoIncludedGood.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoIncludedGood.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullGoodName", "Full Good Name", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoIncludedGood.DataSource = this.vwGoodBindingSource;
            this.repoIncludedGood.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repoIncludedGood.DisplayMember = "GoodName";
            this.repoIncludedGood.Name = "repoIncludedGood";
            this.repoIncludedGood.NullText = "[Seçim Edilməyib]";
            this.repoIncludedGood.ValueMember = "Id";
            this.repoIncludedGood.EditValueChanged += new System.EventHandler(this.repoIncludedGood_EditValueChanged);
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "Hesab";
            this.colAccountName.ColumnEdit = this.repoAccount;
            this.colAccountName.FieldName = "AccountId";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 1;
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
            this.colBarCode1.Caption = "Barkod";
            this.colBarCode1.ColumnEdit = this.repoBarcode;
            this.colBarCode1.FieldName = "BarCodeId";
            this.colBarCode1.Name = "colBarCode1";
            this.colBarCode1.Visible = true;
            this.colBarCode1.VisibleIndex = 2;
            // 
            // repoBarcode
            // 
            this.repoBarcode.AutoHeight = false;
            this.repoBarcode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBarcode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barkod", 200, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repoBarcode.DataSource = this.vwBarcodeBindingSource;
            this.repoBarcode.DisplayMember = "Barcode";
            this.repoBarcode.Name = "repoBarcode";
            this.repoBarcode.NullText = "[Seçim Edilməyib]";
            this.repoBarcode.ValueMember = "Id";
            this.repoBarcode.EditValueChanged += new System.EventHandler(this.repoBarcode_EditValueChanged);
            // 
            // vwBarcodeBindingSource
            // 
            this.vwBarcodeBindingSource.DataMember = "VwBarcode";
            this.vwBarcodeBindingSource.DataSource = this.dataSet;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Seriya";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 5;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Say";
            this.colQuantity.DisplayFormat.FormatString = "{0:0.######}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "{0:0.######}";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            // 
            // colUnitName1
            // 
            this.colUnitName1.Caption = "Ölçü vahidi";
            this.colUnitName1.ColumnEdit = this.repoUnit;
            this.colUnitName1.FieldName = "UnitId";
            this.colUnitName1.Name = "colUnitName1";
            this.colUnitName1.Visible = true;
            this.colUnitName1.VisibleIndex = 4;
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
            // colPriceWholeSale1
            // 
            this.colPriceWholeSale1.Caption = "Qiymət";
            this.colPriceWholeSale1.FieldName = "PriceWholeSale";
            this.colPriceWholeSale1.Name = "colPriceWholeSale1";
            this.colPriceWholeSale1.Visible = true;
            this.colPriceWholeSale1.VisibleIndex = 6;
            // 
            // colAmountWholeSale
            // 
            this.colAmountWholeSale.Caption = "Məbləğ ";
            this.colAmountWholeSale.FieldName = "AmountWholeSale";
            this.colAmountWholeSale.Name = "colAmountWholeSale";
            this.colAmountWholeSale.Visible = true;
            this.colAmountWholeSale.VisibleIndex = 7;
            // 
            // colPayment
            // 
            this.colPayment.Caption = "Ödəniş";
            this.colPayment.DisplayFormat.FormatString = "{0:0.######}";
            this.colPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPayment.FieldName = "Payment";
            this.colPayment.GroupFormat.FormatString = "{0:0.######}";
            this.colPayment.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPayment.Name = "colPayment";
            this.colPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:0.######}", "Yekun={0:0.######}")});
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 8;
            // 
            // colDeficit
            // 
            this.colDeficit.Caption = "Qalıq";
            this.colDeficit.DisplayFormat.FormatString = "{0:0.######}";
            this.colDeficit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDeficit.FieldName = "Deficit";
            this.colDeficit.GroupFormat.FormatString = "{0:0.######}";
            this.colDeficit.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDeficit.Name = "colDeficit";
            this.colDeficit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "{0:0.######}", "Yekun={0:0.######}")});
            this.colDeficit.Visible = true;
            this.colDeficit.VisibleIndex = 9;
            // 
            // repoCustomer
            // 
            this.repoCustomer.AutoHeight = false;
            this.repoCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCustomer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoCustomer.DataSource = this.vwIncludeContractChooseBindingSource;
            this.repoCustomer.DisplayMember = "CustomerName";
            this.repoCustomer.Name = "repoCustomer";
            this.repoCustomer.NullText = "[Seçim Edilməyib]";
            this.repoCustomer.ValueMember = "Id";
            this.repoCustomer.EditValueChanged += new System.EventHandler(this.repoCustomer_EditValueChanged);
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
            this.splitContainer.Location = new System.Drawing.Point(6, 76);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer.Panel1.Text = "Panel1";
            this.splitContainer.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer.Panel2.Text = "Panel2";
            this.splitContainer.Size = new System.Drawing.Size(1242, 427);
            this.splitContainer.SplitterPosition = 920;
            this.splitContainer.TabIndex = 37;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlStock);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(317, 427);
            this.groupControl2.TabIndex = 30;
            // 
            // gridControlStock
            // 
            this.gridControlStock.DataSource = this.vwGoodStockBindingSource;
            this.gridControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStock.Location = new System.Drawing.Point(2, 20);
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.Size = new System.Drawing.Size(313, 405);
            this.gridControlStock.TabIndex = 0;
            this.gridControlStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStock});
            this.gridControlStock.DoubleClick += new System.EventHandler(this.gridControlStock_DoubleClick);
            // 
            // vwGoodStockBindingSource
            // 
            this.vwGoodStockBindingSource.DataMember = "VwGoodStock";
            this.vwGoodStockBindingSource.DataSource = this.dataSet;
            // 
            // gridViewStock
            // 
            this.gridViewStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity1,
            this.colFullGoodName1});
            this.gridViewStock.GridControl = this.gridControlStock;
            this.gridViewStock.Name = "gridViewStock";
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
            this.colQuantity1.Caption = "Sayı";
            this.colQuantity1.DisplayFormat.FormatString = "{0:0.######}";
            this.colQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.GroupFormat.FormatString = "{0:0.######}";
            this.colQuantity1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "Yekun={0:0.######}")});
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 1;
            // 
            // colFullGoodName1
            // 
            this.colFullGoodName1.Caption = "Məhsul adı";
            this.colFullGoodName1.FieldName = "FullGoodName";
            this.colFullGoodName1.Name = "colFullGoodName1";
            this.colFullGoodName1.Visible = true;
            this.colFullGoodName1.VisibleIndex = 0;
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(97, 34);
            this.erpLookUpEditCompany.Name = "erpLookUpEditCompany";
            this.erpLookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegionName", "Region Name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCompany.Properties.DataSource = this.vwCompanyBindingSource;
            this.erpLookUpEditCompany.Properties.DisplayMember = "CompanyName";
            this.erpLookUpEditCompany.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCompany.Properties.ValueMember = "Id";
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(195, 20);
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
            this.erpLookUpEditWareHouse.Location = new System.Drawing.Point(341, 7);
            this.erpLookUpEditWareHouse.Name = "erpLookUpEditWareHouse";
            this.erpLookUpEditWareHouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditWareHouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Anbar adı", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Qeyd", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditWareHouse.Properties.DataSource = this.vwWareHouseBindingSource;
            this.erpLookUpEditWareHouse.Properties.DisplayMember = "Name";
            this.erpLookUpEditWareHouse.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditWareHouse.Properties.ValueMember = "Id";
            this.erpLookUpEditWareHouse.Size = new System.Drawing.Size(195, 20);
            this.erpLookUpEditWareHouse.TabIndex = 40;
            this.erpLookUpEditWareHouse.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditWareHouse_ButtonClick);
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
            this.erpDateEditDate.Location = new System.Drawing.Point(341, 34);
            this.erpDateEditDate.Name = "erpDateEditDate";
            this.erpDateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpDateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.erpDateEditDate.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.erpDateEditDate.Properties.NullText = "[Seçim edilməyib]";
            this.erpDateEditDate.Size = new System.Drawing.Size(195, 20);
            this.erpDateEditDate.TabIndex = 42;
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = "";
            this.txtNumber.Location = new System.Drawing.Point(97, 7);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(195, 20);
            this.txtNumber.TabIndex = 43;
            // 
            // txtSaleRetail
            // 
            this.txtSaleRetail.EditValue = "";
            this.txtSaleRetail.Location = new System.Drawing.Point(855, 7);
            this.txtSaleRetail.Name = "txtSaleRetail";
            this.txtSaleRetail.Size = new System.Drawing.Size(51, 20);
            this.txtSaleRetail.TabIndex = 45;
            this.txtSaleRetail.Visible = false;
            this.txtSaleRetail.EditValueChanged += new System.EventHandler(this.txtSaleRetail_EditValueChanged);
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
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(741, 10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 14);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Endirim Satiş";
            this.labelControl7.Visible = false;
            // 
            // txtDiscountWholeSale
            // 
            this.txtDiscountWholeSale.EditValue = "";
            this.txtDiscountWholeSale.Location = new System.Drawing.Point(855, 33);
            this.txtDiscountWholeSale.Name = "txtDiscountWholeSale";
            this.txtDiscountWholeSale.Size = new System.Drawing.Size(51, 20);
            this.txtDiscountWholeSale.TabIndex = 49;
            this.txtDiscountWholeSale.Visible = false;
            this.txtDiscountWholeSale.EditValueChanged += new System.EventHandler(this.txtDiscountWholeSale_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(741, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(112, 14);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "Endirim T. Satiş";
            this.labelControl8.Visible = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(542, 10);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 14);
            this.labelControl9.TabIndex = 52;
            this.labelControl9.Text = "Endirim ";
            // 
            // txtDiscountBuy
            // 
            this.txtDiscountBuy.EditValue = "";
            this.txtDiscountBuy.Location = new System.Drawing.Point(602, 7);
            this.txtDiscountBuy.Name = "txtDiscountBuy";
            this.txtDiscountBuy.Size = new System.Drawing.Size(98, 20);
            this.txtDiscountBuy.TabIndex = 51;
            this.txtDiscountBuy.EditValueChanged += new System.EventHandler(this.txtDiscountBuy_EditValueChanged);
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
            this.colPackingTypeName.Name = "colPackingTypeName";
            // 
            // colGoodName1
            // 
            this.colGoodName1.Caption = "Məhsul Adı";
            this.colGoodName1.FieldName = "GoodName";
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
            this.chckPinGoodCatalog.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckPinGoodCatalog.Appearance.Options.UseFont = true;
            this.chckPinGoodCatalog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chckPinGoodCatalog.Location = new System.Drawing.Point(706, 1);
            this.chckPinGoodCatalog.Name = "chckPinGoodCatalog";
            this.chckPinGoodCatalog.Size = new System.Drawing.Size(31, 31);
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
            // ReturnWholeSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 550);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.erpLookUpEditCompany);
            this.Controls.Add(this.erpDateEditDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtSaleRetail);
            this.Controls.Add(this.erpLookUpEditWareHouse);
            this.Controls.Add(this.txtDiscountWholeSale);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.chckPinGoodCatalog);
            this.Controls.Add(this.txtDiscountBuy);
            this.Controls.Add(this.labelControl9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1272, 589);
            this.Name = "ReturnWholeSaleForm";
            this.Text = "Topdan Satış Geri Qaytarma";
            this.Load += new System.EventHandler(this.ReturnIncludeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IncludeForm_KeyDown);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.txtDiscountBuy, 0);
            this.Controls.SetChildIndex(this.chckPinGoodCatalog, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.txtDiscountWholeSale, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditWareHouse, 0);
            this.Controls.SetChildIndex(this.txtSaleRetail, 0);
            this.Controls.SetChildIndex(this.txtNumber, 0);
            this.Controls.SetChildIndex(this.erpDateEditDate, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCompany, 0);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountWholeSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountBuy.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtSaleRetail;
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
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtDiscountWholeSale;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtDiscountBuy;
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
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colDeficit;
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
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountWholeSale;
    }
}