namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class TransportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyGoods = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddGoods = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.erpDateEditDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.chckPinGoodCatalog = new DevExpress.XtraEditors.CheckButton();
            this.erpLookUpEditFromWareHouse = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.spWareHouseSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditWareHouse = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.spWareHouseChangedPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.vwDocumentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoIncludedGood = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwGoodStockSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCodeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPriceBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlStock = new DevExpress.XtraGrid.GridControl();
            this.spGetGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwGoodSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.spWareHouseSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter();
            this.vwSaleContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter();
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            this.vwDocumentDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter();
            this.spGetGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spGetGoodStockTableAdapter();
            this.vwGoodSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodSelectTableAdapter();
            this.vwAccountTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountTableAdapter();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwUnitTableAdapter();
            this.vwBarcodeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter();
            this.vwGoodSelectTableAdapter1 = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodSelectTableAdapter();
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            this.vwContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwContractTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwContractTableAdapter();
            this.vwGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter();
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.WareHouseTableAdapter();
            this.vwWareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter();
            this.spWareHouseChangedPriceTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseChangedPriceTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAcceptTransport = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.vwGoodStockSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodStockSelectTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditFromWareHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseChangedPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(861, 623);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(957, 623);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(10, 642);
            this.checkApplyNew.Margin = new System.Windows.Forms.Padding(4);
            this.checkApplyNew.TabIndex = 10;
            this.checkApplyNew.Visible = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1425, 816);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(1517, 816);
            this.btnPrintDocument.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click_1);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.txtDescription);
            this.groupControl3.Controls.Add(this.txtNumber);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.erpLookUpEditCompany);
            this.groupControl3.Controls.Add(this.erpDateEditDate);
            this.groupControl3.Controls.Add(this.chckPinGoodCatalog);
            this.groupControl3.Controls.Add(this.erpLookUpEditFromWareHouse);
            this.groupControl3.Controls.Add(this.erpLookUpEditWareHouse);
            this.groupControl3.Location = new System.Drawing.Point(12, 32);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(1034, 116);
            this.groupControl3.TabIndex = 58;
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDeleteGoods);
            this.groupControl4.Controls.Add(this.btnApplyGoods);
            this.groupControl4.Controls.Add(this.btnAddGoods);
            this.groupControl4.Enabled = false;
            this.groupControl4.Location = new System.Drawing.Point(805, 22);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(95, 114);
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
            this.labelControl11.Location = new System.Drawing.Point(417, 7);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 24);
            this.labelControl11.TabIndex = 58;
            this.labelControl11.Text = "Qeyd";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(479, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtDescription.Size = new System.Drawing.Size(222, 30);
            this.txtDescription.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.EditValue = "";
            this.txtNumber.Location = new System.Drawing.Point(86, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(223, 30);
            this.txtNumber.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 24);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Nömrə";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 24);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Müəssisə";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(4, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 24);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Anbar";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(313, 79);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(150, 24);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Gonderilen Anbar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(421, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 24);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tarix";
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(86, 40);
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
            this.erpLookUpEditCompany.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCompany_ButtonClick);
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(223, 30);
            this.erpLookUpEditCompany.TabIndex = 1;
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // accountingDataSetBindingSource
            // 
            this.accountingDataSetBindingSource.DataSource = this.accountingDataSet;
            this.accountingDataSetBindingSource.Position = 0;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // erpDateEditDate
            // 
            this.erpDateEditDate.EditValue = null;
            this.erpDateEditDate.Location = new System.Drawing.Point(479, 41);
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
            this.erpDateEditDate.TabIndex = 4;
            // 
            // chckPinGoodCatalog
            // 
            this.chckPinGoodCatalog.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckPinGoodCatalog.Appearance.Options.UseFont = true;
            this.chckPinGoodCatalog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chckPinGoodCatalog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chckPinGoodCatalog.ImageOptions.Image")));
            this.chckPinGoodCatalog.Location = new System.Drawing.Point(707, 5);
            this.chckPinGoodCatalog.Name = "chckPinGoodCatalog";
            this.chckPinGoodCatalog.Size = new System.Drawing.Size(40, 35);
            this.chckPinGoodCatalog.TabIndex = 7;
            this.chckPinGoodCatalog.CheckedChanged += new System.EventHandler(this.chckPinGoodCatalog_CheckedChanged);
            // 
            // erpLookUpEditFromWareHouse
            // 
            this.erpLookUpEditFromWareHouse.Location = new System.Drawing.Point(86, 74);
            this.erpLookUpEditFromWareHouse.Name = "erpLookUpEditFromWareHouse";
            this.erpLookUpEditFromWareHouse.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditFromWareHouse.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditFromWareHouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditFromWareHouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Anbar adı", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Qeyd", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditFromWareHouse.Properties.DataSource = this.spWareHouseSelectBindingSource;
            this.erpLookUpEditFromWareHouse.Properties.DisplayMember = "Name";
            this.erpLookUpEditFromWareHouse.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditFromWareHouse.Properties.ValueMember = "Id";
            this.erpLookUpEditFromWareHouse.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditWareHouse_ButtonClick);
            this.erpLookUpEditFromWareHouse.Size = new System.Drawing.Size(223, 30);
            this.erpLookUpEditFromWareHouse.TabIndex = 2;
            this.erpLookUpEditFromWareHouse.EditValueChanged += new System.EventHandler(this.erpLookUpEditWareHouse_EditValueChanged);
            // 
            // spWareHouseSelectBindingSource
            // 
            this.spWareHouseSelectBindingSource.DataMember = "spWareHouseSelect";
            this.spWareHouseSelectBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // erpLookUpEditWareHouse
            // 
            this.erpLookUpEditWareHouse.Location = new System.Drawing.Point(479, 77);
            this.erpLookUpEditWareHouse.Name = "erpLookUpEditWareHouse";
            this.erpLookUpEditWareHouse.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditWareHouse.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditWareHouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditWareHouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditWareHouse.Properties.DataSource = this.spWareHouseChangedPriceBindingSource;
            this.erpLookUpEditWareHouse.Properties.DisplayMember = "Name";
            this.erpLookUpEditWareHouse.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditWareHouse.Properties.ValueMember = "Id";
            this.erpLookUpEditWareHouse.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCustomerId_Properties_ButtonClick);
            this.erpLookUpEditWareHouse.Size = new System.Drawing.Size(222, 30);
            this.erpLookUpEditWareHouse.TabIndex = 3;
            // 
            // spWareHouseChangedPriceBindingSource
            // 
            this.spWareHouseChangedPriceBindingSource.DataMember = "spWareHouseChangedPrice";
            this.spWareHouseChangedPriceBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwWareHouseBindingSource
            // 
            this.vwWareHouseBindingSource.DataMember = "VwWareHouse";
            this.vwWareHouseBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwSaleContractChooseBindingSource
            // 
            this.vwSaleContractChooseBindingSource.DataMember = "VwSaleContractChoose";
            this.vwSaleContractChooseBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwPaymentTypeBindingSource
            // 
            this.vwPaymentTypeBindingSource.DataMember = "VwPaymentType";
            this.vwPaymentTypeBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(11, 154);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer.Panel1.Text = "Panel1";
            this.splitContainer.Panel2.Controls.Add(this.gridControlStock);
            this.splitContainer.Panel2.Text = "Panel2";
            this.splitContainer.Size = new System.Drawing.Size(1033, 471);
            this.splitContainer.SplitterPosition = 702;
            this.splitContainer.TabIndex = 57;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDetail);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(702, 471);
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
            this.gridControlDetail.Size = new System.Drawing.Size(698, 467);
            this.gridControlDetail.TabIndex = 0;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // vwDocumentDetailBindingSource
            // 
            this.vwDocumentDetailBindingSource.DataMember = "VwDocumentDetail";
            this.vwDocumentDetailBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoodName,
            this.colQuantity,
            this.colBarCodeId,
            this.colPriceBuy,
            this.colAmountBuy});
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsFind.AllowFindPanel = false;
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
            this.colGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodName.AppearanceCell.Options.UseFont = true;
            this.colGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M))),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)))});
            this.repoIncludedGood.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodName", "Ad", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodTypeName", "Nov", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Quantity", "Say", 52, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repoIncludedGood.DataSource = this.vwGoodStockSelectBindingSource;
            this.repoIncludedGood.DisplayMember = "GoodName";
            this.repoIncludedGood.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            this.repoIncludedGood.ImmediatePopup = true;
            this.repoIncludedGood.Name = "repoIncludedGood";
            this.repoIncludedGood.NullText = "[Seçim Edilməyib]";
            this.repoIncludedGood.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.repoIncludedGood.ValueMember = "Id";
            this.repoIncludedGood.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoIncludedGood_ButtonClick);
            this.repoIncludedGood.EditValueChanged += new System.EventHandler(this.repoIncludedGood_EditValueChanged);
            // 
            // vwGoodStockSelectBindingSource
            // 
            this.vwGoodStockSelectBindingSource.DataMember = "VwGoodStockSelect";
            this.vwGoodStockSelectBindingSource.DataSource = this.accountingDataSet;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 58;
            // 
            // colBarCodeId
            // 
            this.colBarCodeId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarCodeId.AppearanceCell.Options.UseFont = true;
            this.colBarCodeId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBarCodeId.AppearanceHeader.Options.UseFont = true;
            this.colBarCodeId.Caption = "Barkod";
            this.colBarCodeId.ColumnEdit = this.repoBarcode;
            this.colBarCodeId.FieldName = "BarCodeId";
            this.colBarCodeId.Image = ((System.Drawing.Image)(resources.GetObject("colBarCodeId.Image")));
            this.colBarCodeId.Name = "colBarCodeId";
            this.colBarCodeId.Visible = true;
            this.colBarCodeId.VisibleIndex = 2;
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
            this.vwBarcodeBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // colPriceBuy
            // 
            this.colPriceBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceCell.Options.UseFont = true;
            this.colPriceBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceHeader.Options.UseFont = true;
            this.colPriceBuy.Caption = "Qiymət";
            this.colPriceBuy.FieldName = "PriceBuy";
            this.colPriceBuy.Image = ((System.Drawing.Image)(resources.GetObject("colPriceBuy.Image")));
            this.colPriceBuy.Name = "colPriceBuy";
            this.colPriceBuy.Visible = true;
            this.colPriceBuy.VisibleIndex = 4;
            // 
            // colAmountBuy
            // 
            this.colAmountBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceCell.Options.UseFont = true;
            this.colAmountBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceHeader.Options.UseFont = true;
            this.colAmountBuy.Caption = "Məbləğ";
            this.colAmountBuy.FieldName = "AmountBuy";
            this.colAmountBuy.Image = ((System.Drawing.Image)(resources.GetObject("colAmountBuy.Image")));
            this.colAmountBuy.Name = "colAmountBuy";
            this.colAmountBuy.Visible = true;
            this.colAmountBuy.VisibleIndex = 5;
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
            this.vwAccountBindingSource.DataSource = this.accountingDataSetBindingSource;
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
            this.vwUnitBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // gridControlStock
            // 
            this.gridControlStock.DataSource = this.spGetGoodStockBindingSource;
            this.gridControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStock.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControlStock.Location = new System.Drawing.Point(0, 0);
            this.gridControlStock.MainView = this.gridViewStock;
            this.gridControlStock.Name = "gridControlStock";
            this.gridControlStock.Size = new System.Drawing.Size(326, 471);
            this.gridControlStock.TabIndex = 0;
            this.gridControlStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStock});
            // 
            // spGetGoodStockBindingSource
            // 
            this.spGetGoodStockBindingSource.DataMember = "spGetGoodStock";
            this.spGetGoodStockBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // gridViewStock
            // 
            this.gridViewStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullGoodName,
            this.colWarehouse,
            this.colQuantity1});
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
            // colFullGoodName
            // 
            this.colFullGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName.Caption = "Məhsul";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Image = ((System.Drawing.Image)(resources.GetObject("colFullGoodName.Image")));
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 0;
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
            // vwGoodSelectBindingSource
            // 
            this.vwGoodSelectBindingSource.DataMember = "VwGoodSelect";
            this.vwGoodSelectBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // spWareHouseSelectTableAdapter
            // 
            this.spWareHouseSelectTableAdapter.ClearBeforeFill = true;
            // 
            // vwSaleContractChooseTableAdapter
            // 
            this.vwSaleContractChooseTableAdapter.ClearBeforeFill = true;
            // 
            // vwPaymentTypeTableAdapter
            // 
            this.vwPaymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwDocumentDetailTableAdapter
            // 
            this.vwDocumentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // spGetGoodStockTableAdapter
            // 
            this.spGetGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodSelectTableAdapter
            // 
            this.vwGoodSelectTableAdapter.ClearBeforeFill = true;
            // 
            // vwAccountTableAdapter
            // 
            this.vwAccountTableAdapter.ClearBeforeFill = true;
            // 
            // vwUnitTableAdapter
            // 
            this.vwUnitTableAdapter.ClearBeforeFill = true;
            // 
            // vwBarcodeTableAdapter
            // 
            this.vwBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodSelectTableAdapter1
            // 
            this.vwGoodSelectTableAdapter1.ClearBeforeFill = true;
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            this.vwGoodBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // vwContractBindingSource
            // 
            this.vwContractBindingSource.DataMember = "VwContract";
            this.vwContractBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwContractTableAdapter
            // 
            this.vwContractTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodStockBindingSource
            // 
            this.vwGoodStockBindingSource.DataMember = "VwGoodStock";
            this.vwGoodStockBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwGoodStockTableAdapter
            // 
            this.vwGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataMember = "WareHouse";
            this.wareHouseBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // wareHouseTableAdapter
            // 
            this.wareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // vwWareHouseTableAdapter
            // 
            this.vwWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // spWareHouseChangedPriceTableAdapter
            // 
            this.spWareHouseChangedPriceTableAdapter.ClearBeforeFill = true;
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
            this.btnAcceptTransport,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAcceptTransport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose),
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
            this.barButtonItem2.Hint = "     ";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnAcceptTransport
            // 
            this.btnAcceptTransport.Caption = "Təsdiqlə";
            this.btnAcceptTransport.Hint = "  ";
            this.btnAcceptTransport.Id = 2;
            this.btnAcceptTransport.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnAcceptTransport.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return));
            this.btnAcceptTransport.Name = "btnAcceptTransport";
            this.btnAcceptTransport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAcceptTransport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAcceptTransport_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "İmtina Et";
            this.btnClose.Hint = "   ";
            this.btnClose.Id = 3;
            this.btnClose.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1044, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 625);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1044, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 601);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1044, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 601);
            // 
            // vwGoodStockSelectTableAdapter
            // 
            this.vwGoodStockSelectTableAdapter.ClearBeforeFill = true;
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 625);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = true;
            this.MaximumSize = new System.Drawing.Size(1060, 664);
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1060, 664);
            this.Name = "TransportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yerdəyişmə";
            this.Load += new System.EventHandler(this.TransportForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditFromWareHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseChangedPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnDeleteGoods;
        private DevExpress.XtraEditors.SimpleButton btnApplyGoods;
        private DevExpress.XtraEditors.SimpleButton btnAddGoods;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Business.Infrastructure.UI.erpMemoExEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompany;
        private Business.Infrastructure.UI.erpDateEdit erpDateEditDate;
        private DevExpress.XtraEditors.CheckButton chckPinGoodCatalog;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditFromWareHouse;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditWareHouse;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoIncludedGood;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCodeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoBarcode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoUnit;
        private DevExpress.XtraGrid.GridControl gridControlStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStock;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private System.Windows.Forms.BindingSource accountingDataSetBindingSource;
        private Data.AccountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private System.Windows.Forms.BindingSource spWareHouseSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter spWareHouseSelectTableAdapter;
        private System.Windows.Forms.BindingSource vwSaleContractChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter vwSaleContractChooseTableAdapter;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwDocumentDetailBindingSource;
        private Data.AccountingDataSetTableAdapters.VwDocumentDetailTableAdapter vwDocumentDetailTableAdapter;
        private System.Windows.Forms.BindingSource spGetGoodStockBindingSource;
        private Data.AccountingDataSetTableAdapters.spGetGoodStockTableAdapter spGetGoodStockTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodSelectTableAdapter vwGoodSelectTableAdapter;
        private System.Windows.Forms.BindingSource vwAccountBindingSource;
        private Data.AccountingDataSetTableAdapters.VwAccountTableAdapter vwAccountTableAdapter;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private Data.AccountingDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
        private System.Windows.Forms.BindingSource vwBarcodeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter vwBarcodeTableAdapter;
        private Data.AccountingDataSetTableAdapters.VwGoodSelectTableAdapter vwGoodSelectTableAdapter1;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private System.Windows.Forms.BindingSource vwContractBindingSource;
        private Data.AccountingDataSetTableAdapters.VwContractTableAdapter vwContractTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodStockBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodStockTableAdapter vwGoodStockTableAdapter;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private Data.AccountingDataSetTableAdapters.WareHouseTableAdapter wareHouseTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountBuy;
        private System.Windows.Forms.BindingSource vwWareHouseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter vwWareHouseTableAdapter;
        private System.Windows.Forms.BindingSource spWareHouseChangedPriceBindingSource;
        private Data.AccountingDataSetTableAdapters.spWareHouseChangedPriceTableAdapter spWareHouseChangedPriceTableAdapter;
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
        private DevExpress.XtraBars.BarButtonItem btnAcceptTransport;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}