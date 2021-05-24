namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class RetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailsForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.vwDocumentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoIncludedGood = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCodeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPriceRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chckPinGoodCatalog = new DevExpress.XtraEditors.CheckButton();
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.vwGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditWareHouse = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditCustomerId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwRetailSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpDateEditDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtContractId = new DevExpress.XtraEditors.TextEdit();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.vwWareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter();
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwUnitTableAdapter();
            this.vwAccountTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountTableAdapter();
            this.vwContractTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwContractTableAdapter();
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            this.txtDiscountRetailSale = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.vwSaleContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter();
            this.vwBarcodeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter();
            this.vwGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddGoods = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditPaymentType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            this.wareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.WareHouseTableAdapter();
            this.vwRetailSaleContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwRetailSaleContractChooseTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetailSaleContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountRetailSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(1035, 508);
            this.btnAccept.Size = new System.Drawing.Size(103, 33);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1144, 508);
            this.btnCancel.Size = new System.Drawing.Size(103, 33);
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(14, 516);
            this.checkApplyNew.Size = new System.Drawing.Size(150, 19);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(731, 511);
            this.btnDelete.Size = new System.Drawing.Size(88, 30);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(941, 508);
            this.btnPrintDocument.Size = new System.Drawing.Size(88, 33);
            this.btnPrintDocument.Visible = false;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 24);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Nömrə";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 24);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Müəssisə";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(4, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 24);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Anbar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(314, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 24);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tarix";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(314, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 24);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Müqavilə";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(314, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 24);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Müştəri ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDetail);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(837, 324);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "Mədaxil";
            // 
            // gridControlDetail
            // 
            this.gridControlDetail.DataSource = this.vwDocumentDetailBindingSource;
            this.gridControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetail.Location = new System.Drawing.Point(2, 2);
            this.gridControlDetail.MainView = this.gridViewDetail;
            this.gridControlDetail.Name = "gridControlDetail";
            this.gridControlDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoIncludedGood,
            this.repoAccount,
            this.repoUnit,
            this.repoBarcode});
            this.gridControlDetail.Size = new System.Drawing.Size(833, 320);
            this.gridControlDetail.TabIndex = 0;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // vwDocumentDetailBindingSource
            // 
            this.vwDocumentDetailBindingSource.DataMember = "VwDocumentDetail";
            this.vwDocumentDetailBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoodName,
            this.colAccountName,
            this.colQuantity,
            this.colBarCodeId,
            this.colPriceRetail,
            this.colAmountRetail,
            this.colPercent});
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsFind.AlwaysVisible = true;
            this.gridViewDetail.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewDetail.OptionsFind.ShowClearButton = false;
            this.gridViewDetail.OptionsFind.ShowCloseButton = false;
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
            this.colGoodName.Caption = "Məhsul";
            this.colGoodName.ColumnEdit = this.repoIncludedGood;
            this.colGoodName.FieldName = "GoodId";
            this.colGoodName.Image = ((System.Drawing.Image)(resources.GetObject("colGoodName.Image")));
            this.colGoodName.MinWidth = 50;
            this.colGoodName.Name = "colGoodName";
            this.colGoodName.Visible = true;
            this.colGoodName.VisibleIndex = 1;
            this.colGoodName.Width = 89;
            // 
            // repoIncludedGood
            // 
            this.repoIncludedGood.AutoHeight = false;
            this.repoIncludedGood.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoIncludedGood.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullGoodName", "Məhsul adı", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoIncludedGood.DataSource = this.vwGoodBindingSource;
            this.repoIncludedGood.DisplayMember = "FullGoodName";
            this.repoIncludedGood.Name = "repoIncludedGood";
            this.repoIncludedGood.NullText = "[Seçim Edilməyib]";
            this.repoIncludedGood.ValueMember = "Id";
            this.repoIncludedGood.EditValueChanged += new System.EventHandler(this.repoIncludedGood_EditValueChanged);
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            this.vwGoodBindingSource.DataSource = this.dataSet;
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
            this.colAccountName.Width = 58;
            // 
            // repoAccount
            // 
            this.repoAccount.AutoHeight = false;
            this.repoAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoAccount.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ParentId", "Parent Id", 55, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
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
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.Caption = "Miqdar";
            this.colQuantity.DisplayFormat.FormatString = "{0:0.######}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "{0:0.######}";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Image = ((System.Drawing.Image)(resources.GetObject("colQuantity.Image")));
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "Yekun={0:0.######}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            this.colQuantity.Width = 58;
            // 
            // colBarCodeId
            // 
            this.colBarCodeId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarCodeId.AppearanceCell.Options.UseFont = true;
            this.colBarCodeId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarCodeId.AppearanceHeader.Options.UseFont = true;
            this.colBarCodeId.Caption = "Barkod";
            this.colBarCodeId.ColumnEdit = this.repoBarcode;
            this.colBarCodeId.FieldName = "BarCodeId";
            this.colBarCodeId.Image = ((System.Drawing.Image)(resources.GetObject("colBarCodeId.Image")));
            this.colBarCodeId.Name = "colBarCodeId";
            this.colBarCodeId.Visible = true;
            this.colBarCodeId.VisibleIndex = 3;
            // 
            // repoBarcode
            // 
            this.repoBarcode.AutoHeight = false;
            this.repoBarcode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBarcode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullGoodName", "Məhsul", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barkod", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Say", 150, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
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
            // colPriceRetail
            // 
            this.colPriceRetail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceRetail.AppearanceCell.Options.UseFont = true;
            this.colPriceRetail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceRetail.AppearanceHeader.Options.UseFont = true;
            this.colPriceRetail.Caption = "Qiymət";
            this.colPriceRetail.FieldName = "PriceRetail";
            this.colPriceRetail.Image = ((System.Drawing.Image)(resources.GetObject("colPriceRetail.Image")));
            this.colPriceRetail.Name = "colPriceRetail";
            this.colPriceRetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PriceRetail", "Yekun={0:0.######}")});
            this.colPriceRetail.Visible = true;
            this.colPriceRetail.VisibleIndex = 5;
            this.colPriceRetail.Width = 58;
            // 
            // colAmountRetail
            // 
            this.colAmountRetail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountRetail.AppearanceCell.Options.UseFont = true;
            this.colAmountRetail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountRetail.AppearanceHeader.Options.UseFont = true;
            this.colAmountRetail.Caption = "Məbləğ";
            this.colAmountRetail.DisplayFormat.FormatString = "{0:0.######}";
            this.colAmountRetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.FieldName = "AmountRetail";
            this.colAmountRetail.GroupFormat.FormatString = "{0:0.######}";
            this.colAmountRetail.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.Image = ((System.Drawing.Image)(resources.GetObject("colAmountRetail.Image")));
            this.colAmountRetail.MinWidth = 40;
            this.colAmountRetail.Name = "colAmountRetail";
            this.colAmountRetail.OptionsColumn.ReadOnly = true;
            this.colAmountRetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountRetail", "Yekun={0:0.######}")});
            this.colAmountRetail.Visible = true;
            this.colAmountRetail.VisibleIndex = 6;
            this.colAmountRetail.Width = 65;
            // 
            // colPercent
            // 
            this.colPercent.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPercent.AppearanceCell.Options.UseFont = true;
            this.colPercent.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPercent.AppearanceHeader.Options.UseFont = true;
            this.colPercent.Caption = "Endirim";
            this.colPercent.FieldName = "Percent";
            this.colPercent.Image = ((System.Drawing.Image)(resources.GetObject("colPercent.Image")));
            this.colPercent.Name = "colPercent";
            this.colPercent.Visible = true;
            this.colPercent.VisibleIndex = 7;
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
            // chckPinGoodCatalog
            // 
            this.chckPinGoodCatalog.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckPinGoodCatalog.Appearance.Options.UseFont = true;
            this.chckPinGoodCatalog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chckPinGoodCatalog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chckPinGoodCatalog.ImageOptions.Image")));
            this.chckPinGoodCatalog.Location = new System.Drawing.Point(933, 94);
            this.chckPinGoodCatalog.Name = "chckPinGoodCatalog";
            this.chckPinGoodCatalog.Size = new System.Drawing.Size(40, 35);
            this.chckPinGoodCatalog.TabIndex = 38;
            this.chckPinGoodCatalog.CheckedChanged += new System.EventHandler(this.chckPinGoodCatalog_CheckedChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(7, 176);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer.Panel1.Text = "Panel1";
            this.splitContainer.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer.Panel2.Text = "Panel2";
            this.splitContainer.Size = new System.Drawing.Size(1240, 324);
            this.splitContainer.SplitterPosition = 837;
            this.splitContainer.TabIndex = 37;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlStock);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(398, 324);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "Anbar";
            // 
            // gridControlStock
            // 
            this.gridControlStock.DataSource = this.vwGoodStockBindingSource;
            this.gridControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStock.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControlStock.Location = new System.Drawing.Point(2, 2);
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.Size = new System.Drawing.Size(394, 320);
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
            this.colFullGoodName,
            this.colDescription});
            this.gridViewStock.GridControl = this.gridControlStock;
            this.gridViewStock.Name = "gridViewStock";
            this.gridViewStock.OptionsBehavior.ReadOnly = true;
            this.gridViewStock.OptionsFind.AlwaysVisible = true;
            this.gridViewStock.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewStock.OptionsFind.SearchInPreview = true;
            this.gridViewStock.OptionsFind.ShowClearButton = false;
            this.gridViewStock.OptionsFind.ShowCloseButton = false;
            this.gridViewStock.OptionsFind.ShowFindButton = false;
            this.gridViewStock.OptionsSelection.MultiSelect = true;
            this.gridViewStock.OptionsView.ShowAutoFilterRow = true;
            this.gridViewStock.OptionsView.ShowFooter = true;
            this.gridViewStock.OptionsView.ShowGroupPanel = false;
            // 
            // colQuantity1
            // 
            this.colQuantity1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity1.AppearanceCell.Options.UseFont = true;
            this.colQuantity1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity1.AppearanceHeader.Options.UseFont = true;
            this.colQuantity1.Caption = "Say";
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
            // colFullGoodName
            // 
            this.colFullGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName.Caption = "Məhsul";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Image = ((System.Drawing.Image)(resources.GetObject("colFullGoodName.Image")));
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "S/Y";
            this.colDescription.FieldName = "Description";
            this.colDescription.Image = ((System.Drawing.Image)(resources.GetObject("colDescription.Image")));
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(85, 58);
            this.erpLookUpEditCompany.Name = "erpLookUpEditCompany";
            this.erpLookUpEditCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditCompany.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Müəssisə Adı", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegionName", "Region Name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCompany.Properties.DataSource = this.vwCompanyBindingSource;
            this.erpLookUpEditCompany.Properties.DisplayMember = "CompanyName";
            this.erpLookUpEditCompany.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCompany.Properties.ValueMember = "Id";
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(223, 30);
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
            this.erpLookUpEditWareHouse.Location = new System.Drawing.Point(85, 92);
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
            this.erpLookUpEditWareHouse.Properties.DataSource = this.wareHouseBindingSource;
            this.erpLookUpEditWareHouse.Properties.DisplayMember = "Name";
            this.erpLookUpEditWareHouse.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditWareHouse.Properties.ValueMember = "Id";
            this.erpLookUpEditWareHouse.Size = new System.Drawing.Size(223, 30);
            this.erpLookUpEditWareHouse.TabIndex = 40;
            this.erpLookUpEditWareHouse.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditWareHouse_ButtonClick);
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataMember = "WareHouse";
            this.wareHouseBindingSource.DataSource = this.dataSet;
            // 
            // vwWareHouseBindingSource
            // 
            this.vwWareHouseBindingSource.DataMember = "VwWareHouse";
            this.vwWareHouseBindingSource.DataSource = this.dataSet;
            // 
            // erpLookUpEditCustomerId
            // 
            this.erpLookUpEditCustomerId.Location = new System.Drawing.Point(394, 23);
            this.erpLookUpEditCustomerId.Name = "erpLookUpEditCustomerId";
            this.erpLookUpEditCustomerId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditCustomerId.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditCustomerId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditCustomerId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Müştəri", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContractId", "Müqavilə №", 200, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.erpLookUpEditCustomerId.Properties.DataSource = this.vwRetailSaleContractChooseBindingSource;
            this.erpLookUpEditCustomerId.Properties.DisplayMember = "CustomerName";
            this.erpLookUpEditCustomerId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCustomerId.Properties.ValueMember = "CustomerId";
            this.erpLookUpEditCustomerId.Size = new System.Drawing.Size(222, 30);
            this.erpLookUpEditCustomerId.TabIndex = 41;
            this.erpLookUpEditCustomerId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCustomerId_ButtonClick);
            this.erpLookUpEditCustomerId.EditValueChanged += new System.EventHandler(this.erpLookUpEditCustomerId_EditValueChanged);
            // 
            // vwRetailSaleContractChooseBindingSource
            // 
            this.vwRetailSaleContractChooseBindingSource.DataMember = "VwRetailSaleContractChoose";
            this.vwRetailSaleContractChooseBindingSource.DataSource = this.dataSet;
            // 
            // vwSaleContractChooseBindingSource
            // 
            this.vwSaleContractChooseBindingSource.DataMember = "VwSaleContractChoose";
            this.vwSaleContractChooseBindingSource.DataSource = this.dataSet;
            // 
            // vwContractBindingSource
            // 
            this.vwContractBindingSource.DataMember = "VwContract";
            this.vwContractBindingSource.DataSource = this.dataSet;
            // 
            // erpDateEditDate
            // 
            this.erpDateEditDate.EditValue = null;
            this.erpDateEditDate.Location = new System.Drawing.Point(394, 92);
            this.erpDateEditDate.Name = "erpDateEditDate";
            this.erpDateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpDateEditDate.Properties.Appearance.Options.UseFont = true;
            this.erpDateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpDateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.erpDateEditDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.erpDateEditDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.erpDateEditDate.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.erpDateEditDate.Properties.NullText = "[Seçim edilməyib]";
            this.erpDateEditDate.Size = new System.Drawing.Size(222, 30);
            this.erpDateEditDate.TabIndex = 42;
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = "";
            this.txtNumber.Location = new System.Drawing.Point(85, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(223, 30);
            this.txtNumber.TabIndex = 43;
            // 
            // txtContractId
            // 
            this.txtContractId.EditValue = "";
            this.txtContractId.Location = new System.Drawing.Point(394, 58);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractId.Properties.Appearance.Options.UseFont = true;
            this.txtContractId.Properties.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(222, 30);
            this.txtContractId.TabIndex = 44;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // vwWareHouseTableAdapter
            // 
            this.vwWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
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
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // txtDiscountRetailSale
            // 
            this.txtDiscountRetailSale.EditValue = "";
            this.txtDiscountRetailSale.Location = new System.Drawing.Point(708, 92);
            this.txtDiscountRetailSale.Name = "txtDiscountRetailSale";
            this.txtDiscountRetailSale.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscountRetailSale.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountRetailSale.Size = new System.Drawing.Size(219, 30);
            this.txtDiscountRetailSale.TabIndex = 49;
            this.txtDiscountRetailSale.EditValueChanged += new System.EventHandler(this.txtDiscountRetailSale_EditValueChanged_1);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(632, 95);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 24);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "Endirim ";
            // 
            // vwSaleContractChooseTableAdapter
            // 
            this.vwSaleContractChooseTableAdapter.ClearBeforeFill = true;
            // 
            // vwBarcodeTableAdapter
            // 
            this.vwBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodStockTableAdapter
            // 
            this.vwGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.txtDescription);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.erpLookUpEditPaymentType);
            this.groupControl3.Controls.Add(this.txtNumber);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.erpLookUpEditCompany);
            this.groupControl3.Controls.Add(this.erpDateEditDate);
            this.groupControl3.Controls.Add(this.chckPinGoodCatalog);
            this.groupControl3.Controls.Add(this.txtContractId);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.erpLookUpEditWareHouse);
            this.groupControl3.Controls.Add(this.txtDiscountRetailSale);
            this.groupControl3.Controls.Add(this.erpLookUpEditCustomerId);
            this.groupControl3.Location = new System.Drawing.Point(12, 32);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1084, 141);
            this.groupControl3.TabIndex = 56;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDeleteGoods);
            this.groupControl4.Controls.Add(this.btnApplyGoods);
            this.groupControl4.Controls.Add(this.btnAddGoods);
            this.groupControl4.Location = new System.Drawing.Point(979, 19);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(95, 119);
            this.groupControl4.TabIndex = 116;
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
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(647, 61);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 24);
            this.labelControl11.TabIndex = 58;
            this.labelControl11.Text = "Qeyd";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(708, 58);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtDescription.Size = new System.Drawing.Size(265, 30);
            this.txtDescription.TabIndex = 57;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(632, 25);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(61, 24);
            this.labelControl10.TabIndex = 55;
            this.labelControl10.Text = "Ödəniş";
            // 
            // erpLookUpEditPaymentType
            // 
            this.erpLookUpEditPaymentType.Location = new System.Drawing.Point(708, 22);
            this.erpLookUpEditPaymentType.Name = "erpLookUpEditPaymentType";
            this.erpLookUpEditPaymentType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditPaymentType.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditPaymentType.Properties.DataSource = this.vwPaymentTypeBindingSource;
            this.erpLookUpEditPaymentType.Properties.DisplayMember = "Name";
            this.erpLookUpEditPaymentType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditPaymentType.Properties.ValueMember = "Id";
            this.erpLookUpEditPaymentType.Size = new System.Drawing.Size(265, 30);
            this.erpLookUpEditPaymentType.TabIndex = 56;
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
            // vwRetailSaleContractChooseTableAdapter
            // 
            this.vwRetailSaleContractChooseTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barButtonItem2.Hint = " ";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1256, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 527);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1256, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 503);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1256, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 503);
            // 
            // RetailsForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 550);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1272, 589);
            this.Name = "RetailsForm";
            this.Text = "Pərakəndə Satış";
            this.Load += new System.EventHandler(this.RetailsForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRetailSaleContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountRetailSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraEditors.CheckButton chckPinGoodCatalog;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStock;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompany;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditWareHouse;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCustomerId;
        private Business.Infrastructure.UI.erpDateEdit erpDateEditDate;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.TextEdit txtContractId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoIncludedGood;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountRetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoAccount;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private System.Windows.Forms.BindingSource vwWareHouseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter vwWareHouseTableAdapter;
        private System.Windows.Forms.BindingSource vwDocumentDetailBindingSource;
        private Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoUnit;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private Data.AccountingDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
        private System.Windows.Forms.BindingSource vwAccountBindingSource;
        private Data.AccountingDataSetTableAdapters.VwAccountTableAdapter vwAccountTableAdapter;
        private System.Windows.Forms.BindingSource vwContractBindingSource;
        private Data.AccountingDataSetTableAdapters.VwContractTableAdapter vwContractTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtDiscountRetailSale;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private System.Windows.Forms.BindingSource vwSaleContractChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter vwSaleContractChooseTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoBarcode;
        private System.Windows.Forms.BindingSource vwBarcodeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter vwBarcodeTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodStockBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter vwGoodStockTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCodeId;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPaymentType;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private Data.AccountingDataSetTableAdapters.WareHouseTableAdapter wareHouseTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Business.Infrastructure.UI.erpMemoExEdit txtDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPercent;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnDeleteGoods;
        private DevExpress.XtraEditors.SimpleButton btnApplyGoods;
        private DevExpress.XtraEditors.SimpleButton btnAddGoods;
        private System.Windows.Forms.BindingSource vwRetailSaleContractChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwRetailSaleContractChooseTableAdapter vwRetailSaleContractChooseTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}