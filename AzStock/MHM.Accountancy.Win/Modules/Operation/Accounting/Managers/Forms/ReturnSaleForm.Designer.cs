namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class ReturnSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnSaleForm));
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditAccountId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpDateEditDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.erpLookUpEditWareHouse = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.spWareHouseSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wareHouseDataSet = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSet();
            this.chckPinGoodCatalog = new DevExpress.XtraEditors.CheckButton();
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.vwDocumentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoIncludedGood = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwGoodStockSelectReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBarCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.spGetGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullGoodName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwGoodStockSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            this.vwGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.vwAccountTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountTableAdapter();
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwUnitTableAdapter();
            this.vwBarcodeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter();
            this.vwSaleContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter();
            this.vwCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCustomerTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtContractId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditCustomerId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditPaymentType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            this.wareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.WareHouseTableAdapter();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddGoods = new DevExpress.XtraEditors.SimpleButton();
            this.spWareHouseSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter();
            this.spGetGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spGetGoodStockTableAdapter();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartnerOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.erpDateEditPaymentDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtIncludeNo = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAcceptReturn = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscountSaleNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.bttnCalculator = new DevExpress.XtraEditors.SimpleButton();
            this.vwGoodStockSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockSelectTableAdapter();
            this.vwGoodStockSelectReturnTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockSelectReturnTableAdapter();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditCashier = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.CashierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditAccountId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountSaleNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCashier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(1145, 590);
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1239, 590);
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 597);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(839, 590);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(957, 588);
            this.btnPrintDocument.Visible = false;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1151, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(132, 24);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Əməliyyat Növü";
            this.labelControl5.Visible = false;
            // 
            // erpLookUpEditAccountId
            // 
            this.erpLookUpEditAccountId.Location = new System.Drawing.Point(1288, 38);
            this.erpLookUpEditAccountId.Name = "erpLookUpEditAccountId";
            this.erpLookUpEditAccountId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.erpLookUpEditAccountId.Size = new System.Drawing.Size(43, 30);
            this.erpLookUpEditAccountId.TabIndex = 70;
            this.erpLookUpEditAccountId.Visible = false;
            this.erpLookUpEditAccountId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditAccountId_ButtonClick);
            // 
            // vwAccountBindingSource
            // 
            this.vwAccountBindingSource.DataMember = "VwAccount";
            this.vwAccountBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 24);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Nömrə";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 24);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Müəssisə";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(35, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 24);
            this.labelControl3.TabIndex = 57;
            this.labelControl3.Text = "Anbar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(326, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 24);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "Sənəd Tarixi";
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(92, 68);
            this.erpLookUpEditCompany.Name = "erpLookUpEditCompany";
            this.erpLookUpEditCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(221, 30);
            this.erpLookUpEditCompany.TabIndex = 61;
            this.erpLookUpEditCompany.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCompany_ButtonClick);
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.dataSet;
            // 
            // erpDateEditDate
            // 
            this.erpDateEditDate.EditValue = null;
            this.erpDateEditDate.Location = new System.Drawing.Point(437, 137);
            this.erpDateEditDate.Name = "erpDateEditDate";
            this.erpDateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.erpDateEditDate.Size = new System.Drawing.Size(219, 30);
            this.erpDateEditDate.TabIndex = 63;
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = "";
            this.txtNumber.Location = new System.Drawing.Point(92, 34);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(221, 30);
            this.txtNumber.TabIndex = 64;
            // 
            // erpLookUpEditWareHouse
            // 
            this.erpLookUpEditWareHouse.Location = new System.Drawing.Point(92, 103);
            this.erpLookUpEditWareHouse.Name = "erpLookUpEditWareHouse";
            this.erpLookUpEditWareHouse.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.erpLookUpEditWareHouse.Properties.ValueMember = "Id";
            this.erpLookUpEditWareHouse.Size = new System.Drawing.Size(221, 30);
            this.erpLookUpEditWareHouse.TabIndex = 62;
            this.erpLookUpEditWareHouse.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditWareHouse_ButtonClick);
            this.erpLookUpEditWareHouse.EditValueChanged += new System.EventHandler(this.erpLookUpEditWareHouse_EditValueChanged);
            // 
            // spWareHouseSelectBindingSource
            // 
            this.spWareHouseSelectBindingSource.DataMember = "spWareHouseSelect";
            this.spWareHouseSelectBindingSource.DataSource = this.dataSet;
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataMember = "WareHouse";
            this.wareHouseBindingSource.DataSource = this.dataSet;
            // 
            // wareHouseDataSet
            // 
            this.wareHouseDataSet.DataSetName = "WareHouseDataSet";
            this.wareHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chckPinGoodCatalog
            // 
            this.chckPinGoodCatalog.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckPinGoodCatalog.Appearance.Options.UseFont = true;
            this.chckPinGoodCatalog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chckPinGoodCatalog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chckPinGoodCatalog.ImageOptions.Image")));
            this.chckPinGoodCatalog.Location = new System.Drawing.Point(1032, 98);
            this.chckPinGoodCatalog.Name = "chckPinGoodCatalog";
            this.chckPinGoodCatalog.Size = new System.Drawing.Size(41, 32);
            this.chckPinGoodCatalog.TabIndex = 60;
            this.chckPinGoodCatalog.CheckedChanged += new System.EventHandler(this.chckPinGoodCatalog_CheckedChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(7, 200);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer.Panel1.Text = "Panel1";
            this.splitContainer.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer.Panel2.Text = "Panel2";
            this.splitContainer.Size = new System.Drawing.Size(1318, 384);
            this.splitContainer.SplitterPosition = 810;
            this.splitContainer.TabIndex = 72;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDetail);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(810, 384);
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
            this.gridControlDetail.Size = new System.Drawing.Size(806, 362);
            this.gridControlDetail.TabIndex = 0;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // vwDocumentDetailBindingSource
            // 
            this.vwDocumentDetailBindingSource.DataMember = "VwDocumentDetail";
            this.vwDocumentDetailBindingSource.DataSource = this.dataSet;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoodName,
            this.colAccountName,
            this.colBarCode1,
            this.colQuantity,
            this.colUnitName1,
            this.colPriceWholeSale,
            this.colDiscountPrice,
            this.colAmountWholeSale});
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
            this.gridViewDetail.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDetail_RowCellClick);
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
            // 
            // repoIncludedGood
            // 
            this.repoIncludedGood.AutoHeight = false;
            this.repoIncludedGood.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoIncludedGood.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodName", "Ad", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodTypeName", "Nov", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Say", 50, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repoIncludedGood.DataSource = this.vwGoodStockSelectReturnBindingSource;
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
            // vwGoodStockSelectReturnBindingSource
            // 
            this.vwGoodStockSelectReturnBindingSource.DataMember = "VwGoodStockSelectReturn";
            this.vwGoodStockSelectReturnBindingSource.DataSource = this.dataSet;
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
            // 
            // repoBarcode
            // 
            this.repoBarcode.AutoHeight = false;
            this.repoBarcode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBarcode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barkod", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullGoodName", "Məhsul", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
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
            this.colQuantity.VisibleIndex = 5;
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
            // colPriceWholeSale
            // 
            this.colPriceWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceCell.Options.UseFont = true;
            this.colPriceWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colPriceWholeSale.Caption = "Qiymət";
            this.colPriceWholeSale.DisplayFormat.FormatString = "{0:0.######}";
            this.colPriceWholeSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceWholeSale.FieldName = "PriceWholeSale";
            this.colPriceWholeSale.GroupFormat.FormatString = "{0:0.######}";
            this.colPriceWholeSale.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceWholeSale.Image = ((System.Drawing.Image)(resources.GetObject("colPriceWholeSale.Image")));
            this.colPriceWholeSale.Name = "colPriceWholeSale";
            this.colPriceWholeSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PriceWholeSale", "{0:0.##}")});
            this.colPriceWholeSale.ToolTip = "z";
            this.colPriceWholeSale.Visible = true;
            this.colPriceWholeSale.VisibleIndex = 7;
            // 
            // colDiscountPrice
            // 
            this.colDiscountPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // colAmountWholeSale
            // 
            this.colAmountWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceCell.Options.UseFont = true;
            this.colAmountWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colAmountWholeSale.Caption = "Məbləğ";
            this.colAmountWholeSale.DisplayFormat.FormatString = "{0:0.######}";
            this.colAmountWholeSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountWholeSale.FieldName = "AmountWholeSale";
            this.colAmountWholeSale.GroupFormat.FormatString = "{0:0.######}";
            this.colAmountWholeSale.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountWholeSale.Image = ((System.Drawing.Image)(resources.GetObject("colAmountWholeSale.Image")));
            this.colAmountWholeSale.Name = "colAmountWholeSale";
            this.colAmountWholeSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountWholeSale", "{0:0.##}")});
            this.colAmountWholeSale.Visible = true;
            this.colAmountWholeSale.VisibleIndex = 8;
            // 
            // repoCustomer
            // 
            this.repoCustomer.AutoHeight = false;
            this.repoCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCustomer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Müəssisə", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoCustomer.DataSource = this.vwSaleContractChooseBindingSource;
            this.repoCustomer.DisplayMember = "CustomerName";
            this.repoCustomer.Name = "repoCustomer";
            this.repoCustomer.NullText = "[Seçim Edilməyib]";
            this.repoCustomer.ValueMember = "Id";
            // 
            // vwSaleContractChooseBindingSource
            // 
            this.vwSaleContractChooseBindingSource.DataMember = "VwSaleContractChoose";
            this.vwSaleContractChooseBindingSource.DataSource = this.dataSet;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlStock);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(503, 384);
            this.groupControl2.TabIndex = 30;
            // 
            // gridControlStock
            // 
            this.gridControlStock.DataSource = this.spGetGoodStockBindingSource;
            this.gridControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStock.Location = new System.Drawing.Point(2, 20);
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.Size = new System.Drawing.Size(499, 362);
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
            this.colDescription});
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
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Saxlanma Yeri";
            this.colDescription.FieldName = "Description";
            this.colDescription.Image = ((System.Drawing.Image)(resources.GetObject("colDescription.Image")));
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // vwGoodStockSelectBindingSource
            // 
            this.vwGoodStockSelectBindingSource.DataMember = "VwGoodStockSelect";
            this.vwGoodStockSelectBindingSource.DataSource = this.dataSet;
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            this.vwGoodBindingSource.DataSource = this.dataSet;
            // 
            // vwGoodStockBindingSource
            // 
            this.vwGoodStockBindingSource.DataMember = "VwGoodStock";
            this.vwGoodStockBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodStockTableAdapter
            // 
            this.vwGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // vwAccountTableAdapter
            // 
            this.vwAccountTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // vwUnitTableAdapter
            // 
            this.vwUnitTableAdapter.ClearBeforeFill = true;
            // 
            // vwBarcodeTableAdapter
            // 
            this.vwBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // vwSaleContractChooseTableAdapter
            // 
            this.vwSaleContractChooseTableAdapter.ClearBeforeFill = true;
            // 
            // vwCustomerBindingSource
            // 
            this.vwCustomerBindingSource.DataMember = "VwCustomer";
            this.vwCustomerBindingSource.DataSource = this.dataSet;
            // 
            // vwCustomerTableAdapter
            // 
            this.vwCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(357, 104);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(76, 24);
            this.labelControl10.TabIndex = 75;
            this.labelControl10.Text = "Müqavilə";
            // 
            // txtContractId
            // 
            this.txtContractId.EditValue = "";
            this.txtContractId.Location = new System.Drawing.Point(437, 102);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractId.Properties.Appearance.Options.UseFont = true;
            this.txtContractId.Properties.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(219, 30);
            this.txtContractId.TabIndex = 76;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(372, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 24);
            this.labelControl6.TabIndex = 73;
            this.labelControl6.Text = "Müştəri";
            // 
            // erpLookUpEditCustomerId
            // 
            this.erpLookUpEditCustomerId.Location = new System.Drawing.Point(437, 32);
            this.erpLookUpEditCustomerId.Name = "erpLookUpEditCustomerId";
            this.erpLookUpEditCustomerId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditCustomerId.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditCustomerId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditCustomerId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Müştəri Firma", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContractId", "Müştəri №", 150, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.erpLookUpEditCustomerId.Properties.DataSource = this.vwSaleContractChooseBindingSource;
            this.erpLookUpEditCustomerId.Properties.DisplayMember = "CustomerName";
            this.erpLookUpEditCustomerId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCustomerId.Properties.ValueMember = "ContractId";
            this.erpLookUpEditCustomerId.Size = new System.Drawing.Size(219, 30);
            this.erpLookUpEditCustomerId.TabIndex = 74;
            this.erpLookUpEditCustomerId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCustomerId_ButtonClick);
            this.erpLookUpEditCustomerId.EditValueChanged += new System.EventHandler(this.erpLookUpEditCustomerId_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(679, 36);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(111, 24);
            this.labelControl11.TabIndex = 78;
            this.labelControl11.Text = "Ödəniş Növü";
            // 
            // erpLookUpEditPaymentType
            // 
            this.erpLookUpEditPaymentType.Location = new System.Drawing.Point(796, 33);
            this.erpLookUpEditPaymentType.Name = "erpLookUpEditPaymentType";
            this.erpLookUpEditPaymentType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditPaymentType.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditPaymentType.Properties.DataSource = this.vwPaymentTypeBindingSource;
            this.erpLookUpEditPaymentType.Properties.DisplayMember = "Name";
            this.erpLookUpEditPaymentType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditPaymentType.Properties.ValueMember = "Id";
            this.erpLookUpEditPaymentType.Size = new System.Drawing.Size(224, 30);
            this.erpLookUpEditPaymentType.TabIndex = 77;
            this.erpLookUpEditPaymentType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditPaymentType_ButtonClick);
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
            // wareHouseTableAdapter
            // 
            this.wareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(28, 139);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(46, 24);
            this.labelControl12.TabIndex = 80;
            this.labelControl12.Text = "Qeyd";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(92, 139);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtDescription.Size = new System.Drawing.Size(221, 30);
            this.txtDescription.TabIndex = 79;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDeleteGoods);
            this.groupControl4.Controls.Add(this.btnApplyGoods);
            this.groupControl4.Controls.Add(this.btnAddGoods);
            this.groupControl4.Location = new System.Drawing.Point(1197, 14);
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
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(315, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(118, 24);
            this.labelControl7.TabIndex = 124;
            this.labelControl7.Text = "T-çı Qaimə №";
            // 
            // txtPartnerOrderNo
            // 
            this.txtPartnerOrderNo.EditValue = "";
            this.txtPartnerOrderNo.Location = new System.Drawing.Point(437, 66);
            this.txtPartnerOrderNo.Name = "txtPartnerOrderNo";
            this.txtPartnerOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPartnerOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtPartnerOrderNo.Size = new System.Drawing.Size(219, 30);
            this.txtPartnerOrderNo.TabIndex = 123;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(678, 66);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(112, 24);
            this.labelControl8.TabIndex = 127;
            this.labelControl8.Text = "Ödəniş Tarixi";
            // 
            // erpDateEditPaymentDate
            // 
            this.erpDateEditPaymentDate.EditValue = null;
            this.erpDateEditPaymentDate.Location = new System.Drawing.Point(796, 66);
            this.erpDateEditPaymentDate.Name = "erpDateEditPaymentDate";
            this.erpDateEditPaymentDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.erpDateEditPaymentDate.Size = new System.Drawing.Size(224, 30);
            this.erpDateEditPaymentDate.TabIndex = 126;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(665, 139);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(125, 24);
            this.labelControl9.TabIndex = 129;
            this.labelControl9.Text = "Satış Qaimə №";
            // 
            // txtIncludeNo
            // 
            this.txtIncludeNo.EditValue = "";
            this.txtIncludeNo.Location = new System.Drawing.Point(796, 137);
            this.txtIncludeNo.Name = "txtIncludeNo";
            this.txtIncludeNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIncludeNo.Properties.Appearance.Options.UseFont = true;
            this.txtIncludeNo.Size = new System.Drawing.Size(85, 30);
            this.txtIncludeNo.TabIndex = 128;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 24);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1331, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 629);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1331, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 605);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1331, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 605);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnAcceptReturn,
            this.btnClose,
            this.barEditItem1,
            this.barEditItem2,
            this.barCheckItem1,
            this.barEditItem3,
            this.barToggleSwitchItem1,
            this.barButtonItem4});
            this.barManager2.MainMenu = this.bar5;
            this.barManager2.MaxItemId = 11;
            this.barManager2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit2});
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAcceptReturn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Məhsul Əlavə Et";
            this.barButtonItem1.Hint = "    ";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "Add;Size16x16;GrayScaled";
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Məhsul Sil";
            this.barButtonItem2.Hint = "     ";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Endirim Hesabla";
            this.barButtonItem3.Hint = "   ";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.ImageUri.Uri = "Summary;Size16x16;GrayScaled";
            this.barButtonItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnAcceptReturn
            // 
            this.btnAcceptReturn.Caption = "Təsdqilə";
            this.btnAcceptReturn.Hint = "   ";
            this.btnAcceptReturn.Id = 3;
            this.btnAcceptReturn.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnAcceptReturn.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return));
            this.btnAcceptReturn.Name = "btnAcceptReturn";
            this.btnAcceptReturn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAcceptReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAcceptReturn_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "İmtina Et";
            this.btnClose.Hint = "   ";
            this.btnClose.Id = 4;
            this.btnClose.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1331, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 629);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1331, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 605);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1331, 24);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 605);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem2.Id = 6;
            this.barEditItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Anbar";
            this.barCheckItem1.Hint = "  ";
            this.barCheckItem1.Id = 7;
            this.barCheckItem1.ImageOptions.ImageUri.Uri = "Chart;Size16x16;GrayScaled";
            this.barCheckItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit2;
            this.barEditItem3.Id = 8;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 9;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(887, 151);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(63, 16);
            this.labelControl13.TabIndex = 218;
            this.labelControl13.Text = "Rəqəmlə";
            // 
            // txtDiscountSaleNumber
            // 
            this.txtDiscountSaleNumber.EditValue = "";
            this.txtDiscountSaleNumber.Location = new System.Drawing.Point(956, 136);
            this.txtDiscountSaleNumber.Name = "txtDiscountSaleNumber";
            this.txtDiscountSaleNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscountSaleNumber.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountSaleNumber.Size = new System.Drawing.Size(64, 30);
            this.txtDiscountSaleNumber.TabIndex = 216;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(898, 137);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(52, 16);
            this.labelControl14.TabIndex = 217;
            this.labelControl14.Text = "Endirim";
            // 
            // bttnCalculator
            // 
            this.bttnCalculator.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttnCalculator.ImageOptions.Image")));
            this.bttnCalculator.Location = new System.Drawing.Point(1251, 134);
            this.bttnCalculator.Name = "bttnCalculator";
            this.bttnCalculator.Size = new System.Drawing.Size(41, 33);
            this.bttnCalculator.TabIndex = 219;
            this.bttnCalculator.Text = " ";
            this.bttnCalculator.Visible = false;
            this.bttnCalculator.Click += new System.EventHandler(this.bttnCalculator_Click);
            // 
            // vwGoodStockSelectTableAdapter
            // 
            this.vwGoodStockSelectTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodStockSelectReturnTableAdapter
            // 
            this.vwGoodStockSelectReturnTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(746, 107);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(44, 24);
            this.labelControl15.TabIndex = 229;
            this.labelControl15.Text = "Satıcı";
            // 
            // erpLookUpEditCashier
            // 
            this.erpLookUpEditCashier.Location = new System.Drawing.Point(796, 104);
            this.erpLookUpEditCashier.Name = "erpLookUpEditCashier";
            this.erpLookUpEditCashier.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditCashier.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditCashier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditCashier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCashier.Properties.DataSource = this.cashierBindingSource;
            this.erpLookUpEditCashier.Properties.DisplayMember = "CashierName";
            this.erpLookUpEditCashier.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCashier.Properties.ValueMember = "Id";
            this.erpLookUpEditCashier.Size = new System.Drawing.Size(224, 30);
            this.erpLookUpEditCashier.TabIndex = 228;
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "Cashier";
            this.cashierBindingSource.DataSource = this.dataSet;
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 629);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.erpLookUpEditCashier);
            this.Controls.Add(this.bttnCalculator);
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
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.erpLookUpEditAccountId);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.erpLookUpEditCompany);
            this.Controls.Add(this.erpDateEditDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.erpLookUpEditWareHouse);
            this.Controls.Add(this.chckPinGoodCatalog);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1131, 668);
            this.Name = "ReturnSaleForm";
            this.Text = "Topdan Satış Geri Qaytarılma";
            this.Load += new System.EventHandler(this.ReturnSaleForm_Load);
            this.Controls.SetChildIndex(this.barDockControl1, 0);
            this.Controls.SetChildIndex(this.barDockControl2, 0);
            this.Controls.SetChildIndex(this.barDockControl4, 0);
            this.Controls.SetChildIndex(this.barDockControl3, 0);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.chckPinGoodCatalog, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditWareHouse, 0);
            this.Controls.SetChildIndex(this.txtNumber, 0);
            this.Controls.SetChildIndex(this.erpDateEditDate, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCompany, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditAccountId, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCustomerId, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.txtContractId, 0);
            this.Controls.SetChildIndex(this.labelControl10, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditPaymentType, 0);
            this.Controls.SetChildIndex(this.labelControl11, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.labelControl12, 0);
            this.Controls.SetChildIndex(this.groupControl4, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.txtPartnerOrderNo, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.erpDateEditPaymentDate, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.txtIncludeNo, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.labelControl14, 0);
            this.Controls.SetChildIndex(this.txtDiscountSaleNumber, 0);
            this.Controls.SetChildIndex(this.labelControl13, 0);
            this.Controls.SetChildIndex(this.bttnCalculator, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCashier, 0);
            this.Controls.SetChildIndex(this.labelControl15, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditAccountId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountSaleNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCashier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditAccountId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompany;
        private Business.Infrastructure.UI.erpDateEdit erpDateEditDate;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditWareHouse;
        private DevExpress.XtraEditors.CheckButton chckPinGoodCatalog;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoCustomer;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStock;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName1;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwDocumentDetailBindingSource;
        private Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodStockBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter vwGoodStockTableAdapter;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private System.Windows.Forms.BindingSource vwAccountBindingSource;
        private Data.AccountingDataSetTableAdapters.VwAccountTableAdapter vwAccountTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private Data.AccountingDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
        private System.Windows.Forms.BindingSource vwBarcodeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter vwBarcodeTableAdapter;
        private System.Windows.Forms.BindingSource vwSaleContractChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter vwSaleContractChooseTableAdapter;
        private System.Windows.Forms.BindingSource vwCustomerBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter vwCustomerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountWholeSale;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtContractId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPaymentType;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
        private WareHouse.Data.WareHouseDataSet wareHouseDataSet;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private Data.AccountingDataSetTableAdapters.WareHouseTableAdapter wareHouseTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
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
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPartnerOrderNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Business.Infrastructure.UI.erpDateEdit erpDateEditPaymentDate;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtIncludeNo;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoIncludedGood;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtDiscountSaleNumber;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton bttnCalculator;
        private System.Windows.Forms.BindingSource vwGoodStockSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodStockSelectTableAdapter vwGoodStockSelectTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPrice;
        private System.Windows.Forms.BindingSource vwGoodStockSelectReturnBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodStockSelectReturnTableAdapter vwGoodStockSelectReturnTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnAcceptReturn;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCashier;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private Data.AccountingDataSetTableAdapters.CashierTableAdapter cashierTableAdapter;
    }
}