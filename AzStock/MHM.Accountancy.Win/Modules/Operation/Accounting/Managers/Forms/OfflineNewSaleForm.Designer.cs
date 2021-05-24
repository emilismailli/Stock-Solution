namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class OfflineNewSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineNewSaleForm));
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.dateEditDate = new ERP.Infrastructure.Interfaces.erpDateEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.s = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.vwOfflineSaleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoodId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoGood = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBarcodeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwGoodSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwLogisticDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpDateEditDeliveryDate = new ERP.Infrastructure.Interfaces.erpDateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteContracts = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyContracts = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddContracts = new DevExpress.XtraEditors.SimpleButton();
            this.vwLogisticDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwLogisticDetailTableAdapter();
            this.vwGoodSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodSelectTableAdapter();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwUnitTableAdapter();
            this.vwBarcodeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter();
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            this.vwOfflineSaleDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwOfflineSaleDetailTableAdapter();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtContractId = new DevExpress.XtraEditors.TextEdit();
            this.erpLookUpEditCustomerId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwSaleContractChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditWareHouse = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwWareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spWareHouseSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditPaymentType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDiscountWholeSale = new DevExpress.XtraEditors.TextEdit();
            this.spWareHouseSelectTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter();
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.vwWareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter();
            this.vwSaleContractChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.btnAddGoods = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteGoods = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chckPinGoodCatalog = new DevExpress.XtraEditors.CheckButton();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwOfflineSaleDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLogisticDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountWholeSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(1056, 541);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_2);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(1150, 541);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 557);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(695, 541);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(787, 541);
            this.btnPrintDocument.Visible = false;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(488, 136);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(46, 23);
            this.labelControl19.TabIndex = 92;
            this.labelControl19.Text = "Əsas:";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(92, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(293, 26);
            this.txtNumber.TabIndex = 56;
            // 
            // dateEditDate
            // 
            this.dateEditDate.EditValue = null;
            this.dateEditDate.Location = new System.Drawing.Point(540, 76);
            this.dateEditDate.Name = "dateEditDate";
            this.dateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.dateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.NullText = "[Seçim edilməyib]";
            this.dateEditDate.Size = new System.Drawing.Size(293, 26);
            this.dateEditDate.TabIndex = 11;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(423, 76);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(111, 23);
            this.labelControl14.TabIndex = 88;
            this.labelControl14.Text = "Sənəd Tarixi:";
            // 
            // s
            // 
            this.s.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s.Controls.Add(this.gridControlDetail);
            this.s.Location = new System.Drawing.Point(12, 209);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(1228, 342);
            this.s.TabIndex = 87;
            this.s.Text = "Sənəd Detalı";
            // 
            // gridControlDetail
            // 
            this.gridControlDetail.DataSource = this.vwOfflineSaleDetailBindingSource;
            this.gridControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetail.Location = new System.Drawing.Point(2, 20);
            this.gridControlDetail.MainView = this.gridViewDetail;
            this.gridControlDetail.Name = "gridControlDetail";
            this.gridControlDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoGood,
            this.repoUnit,
            this.repoBarcode});
            this.gridControlDetail.Size = new System.Drawing.Size(1224, 320);
            this.gridControlDetail.TabIndex = 14;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // vwOfflineSaleDetailBindingSource
            // 
            this.vwOfflineSaleDetailBindingSource.DataMember = "VwOfflineSaleDetail";
            this.vwOfflineSaleDetailBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoodId,
            this.colQuantity,
            this.colUnitId,
            this.colBarcodeId,
            this.colPriceWholeSale,
            this.colAmountWholeSale});
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.GroupPanelText = "Qruplamaq istədiyiniz sütunu buraya çəkin";
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDetail.OptionsView.ShowFooter = true;
            this.gridViewDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDetail_FocusedRowChanged);
            this.gridViewDetail.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gridViewDetail_FocusedColumnChanged);
            // 
            // colGoodId
            // 
            this.colGoodId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodId.AppearanceCell.Options.UseFont = true;
            this.colGoodId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodId.AppearanceHeader.Options.UseFont = true;
            this.colGoodId.Caption = "Məhsul";
            this.colGoodId.ColumnEdit = this.repoGood;
            this.colGoodId.FieldName = "GoodId";
            this.colGoodId.Image = ((System.Drawing.Image)(resources.GetObject("colGoodId.Image")));
            this.colGoodId.MinWidth = 100;
            this.colGoodId.Name = "colGoodId";
            this.colGoodId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "GoodId", "Yekun")});
            this.colGoodId.Visible = true;
            this.colGoodId.VisibleIndex = 1;
            this.colGoodId.Width = 100;
            // 
            // repoGood
            // 
            this.repoGood.AutoHeight = false;
            this.repoGood.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.repoGood.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodName", "Ad", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodTypeName", "Nov", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoGood.DataSource = this.vwGoodBindingSource;
            this.repoGood.DisplayMember = "GoodName";
            this.repoGood.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            this.repoGood.ImmediatePopup = true;
            this.repoGood.Name = "repoGood";
            this.repoGood.NullText = "[Seçim Edilməyib]";
            this.repoGood.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.repoGood.ValueMember = "Id";
            this.repoGood.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoGood_ButtonClick);
            this.repoGood.EditValueChanged += new System.EventHandler(this.repoGood_EditValueChanged);
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            this.vwGoodBindingSource.DataSource = this.dataSet;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.Caption = "Miqdarı";
            this.colQuantity.DisplayFormat.FormatString = "{0:0.##}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "{0:0.##}";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Image = ((System.Drawing.Image)(resources.GetObject("colQuantity.Image")));
            this.colQuantity.MinWidth = 60;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 72;
            // 
            // colUnitId
            // 
            this.colUnitId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitId.AppearanceCell.Options.UseFont = true;
            this.colUnitId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitId.AppearanceHeader.Options.UseFont = true;
            this.colUnitId.Caption = "Ölçü Vahidi";
            this.colUnitId.ColumnEdit = this.repoUnit;
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Image = ((System.Drawing.Image)(resources.GetObject("colUnitId.Image")));
            this.colUnitId.MinWidth = 60;
            this.colUnitId.Name = "colUnitId";
            this.colUnitId.Visible = true;
            this.colUnitId.VisibleIndex = 2;
            this.colUnitId.Width = 60;
            // 
            // repoUnit
            // 
            this.repoUnit.AutoHeight = false;
            this.repoUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoUnit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ölçü Vahidi", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
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
            // colBarcodeId
            // 
            this.colBarcodeId.FieldName = "BarcodeId";
            this.colBarcodeId.Name = "colBarcodeId";
            // 
            // colPriceWholeSale
            // 
            this.colPriceWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceCell.Options.UseFont = true;
            this.colPriceWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colPriceWholeSale.Caption = "Qiymət";
            this.colPriceWholeSale.DisplayFormat.FormatString = "{0:0.##}";
            this.colPriceWholeSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceWholeSale.FieldName = "PriceWholeSale";
            this.colPriceWholeSale.GroupFormat.FormatString = "{0:0.##}";
            this.colPriceWholeSale.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPriceWholeSale.Name = "colPriceWholeSale";
            this.colPriceWholeSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PriceWholeSale", "{0:0.##}")});
            this.colPriceWholeSale.Visible = true;
            this.colPriceWholeSale.VisibleIndex = 4;
            // 
            // colAmountWholeSale
            // 
            this.colAmountWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceCell.Options.UseFont = true;
            this.colAmountWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colAmountWholeSale.Caption = "Məbləğ";
            this.colAmountWholeSale.DisplayFormat.FormatString = "{0:0.##}";
            this.colAmountWholeSale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountWholeSale.FieldName = "AmountWholeSale";
            this.colAmountWholeSale.GroupFormat.FormatString = "{0:0.##}";
            this.colAmountWholeSale.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountWholeSale.Name = "colAmountWholeSale";
            this.colAmountWholeSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountWholeSale", "{0:0.##}")});
            this.colAmountWholeSale.Visible = true;
            this.colAmountWholeSale.VisibleIndex = 5;
            // 
            // repoBarcode
            // 
            this.repoBarcode.AutoHeight = false;
            this.repoBarcode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoBarcode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barcode", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoBarcode.DataSource = this.vwBarcodeBindingSource;
            this.repoBarcode.DisplayMember = "Barcode";
            this.repoBarcode.Name = "repoBarcode";
            this.repoBarcode.NullText = "[Seçim Edilməyib]";
            this.repoBarcode.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.repoBarcode.ValueMember = "Id";
            this.repoBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repoBarcode_KeyDown);
            // 
            // vwBarcodeBindingSource
            // 
            this.vwBarcodeBindingSource.DataMember = "VwBarcode";
            this.vwBarcodeBindingSource.DataSource = this.dataSet;
            // 
            // vwGoodSelectBindingSource
            // 
            this.vwGoodSelectBindingSource.DataMember = "VwGoodSelect";
            this.vwGoodSelectBindingSource.DataSource = this.dataSet;
            // 
            // vwLogisticDetailBindingSource
            // 
            this.vwLogisticDetailBindingSource.DataMember = "VwLogisticDetail";
            this.vwLogisticDetailBindingSource.DataSource = this.dataSet;
            // 
            // erpDateEditDeliveryDate
            // 
            this.erpDateEditDeliveryDate.EditValue = null;
            this.erpDateEditDeliveryDate.Location = new System.Drawing.Point(540, 106);
            this.erpDateEditDeliveryDate.Name = "erpDateEditDeliveryDate";
            this.erpDateEditDeliveryDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpDateEditDeliveryDate.Properties.Appearance.Options.UseFont = true;
            this.erpDateEditDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpDateEditDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.erpDateEditDeliveryDate.Properties.NullText = "[Seçim edilməyib]";
            this.erpDateEditDeliveryDate.Size = new System.Drawing.Size(293, 26);
            this.erpDateEditDeliveryDate.TabIndex = 12;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(393, 106);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(141, 23);
            this.labelControl13.TabIndex = 86;
            this.labelControl13.Text = "Çatdırılma Tarixi:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(57, 7);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(29, 23);
            this.labelControl15.TabIndex = 94;
            this.labelControl15.Text = "№:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(541, 138);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(293, 30);
            this.txtDescription.TabIndex = 13;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDeleteContracts);
            this.groupControl2.Controls.Add(this.btnApplyContracts);
            this.groupControl2.Controls.Add(this.btnAddContracts);
            this.groupControl2.Location = new System.Drawing.Point(1070, 32);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(98, 110);
            this.groupControl2.TabIndex = 179;
            this.groupControl2.Text = "Müqavilələr";
            this.groupControl2.Visible = false;
            // 
            // btnDeleteContracts
            // 
            this.btnDeleteContracts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteContracts.ImageOptions.Image")));
            this.btnDeleteContracts.Location = new System.Drawing.Point(9, 80);
            this.btnDeleteContracts.Name = "btnDeleteContracts";
            this.btnDeleteContracts.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteContracts.TabIndex = 2;
            this.btnDeleteContracts.Text = "Sil";
            this.btnDeleteContracts.Click += new System.EventHandler(this.btnDeleteContracts_Click);
            // 
            // btnApplyContracts
            // 
            this.btnApplyContracts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyContracts.ImageOptions.Image")));
            this.btnApplyContracts.Location = new System.Drawing.Point(9, 50);
            this.btnApplyContracts.Name = "btnApplyContracts";
            this.btnApplyContracts.Size = new System.Drawing.Size(78, 29);
            this.btnApplyContracts.TabIndex = 1;
            this.btnApplyContracts.Text = "Təsdiqlə";
            this.btnApplyContracts.Click += new System.EventHandler(this.btnApplyContracts_Click);
            // 
            // btnAddContracts
            // 
            this.btnAddContracts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContracts.ImageOptions.Image")));
            this.btnAddContracts.Location = new System.Drawing.Point(8, 20);
            this.btnAddContracts.Name = "btnAddContracts";
            this.btnAddContracts.Size = new System.Drawing.Size(79, 29);
            this.btnAddContracts.TabIndex = 0;
            this.btnAddContracts.Text = "Yeni";
            this.btnAddContracts.Click += new System.EventHandler(this.btnAddContracts_Click);
            // 
            // vwLogisticDetailTableAdapter
            // 
            this.vwLogisticDetailTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodSelectTableAdapter
            // 
            this.vwGoodSelectTableAdapter.ClearBeforeFill = true;
            // 
            // vwUnitTableAdapter
            // 
            this.vwUnitTableAdapter.ClearBeforeFill = true;
            // 
            // vwBarcodeTableAdapter
            // 
            this.vwBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // vwOfflineSaleDetailTableAdapter
            // 
            this.vwOfflineSaleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(21, 109);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 24);
            this.labelControl6.TabIndex = 195;
            this.labelControl6.Text = "Müştəri";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 144);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 24);
            this.labelControl5.TabIndex = 196;
            this.labelControl5.Text = "Müqavilə";
            // 
            // txtContractId
            // 
            this.txtContractId.EditValue = "";
            this.txtContractId.Location = new System.Drawing.Point(93, 141);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContractId.Properties.Appearance.Options.UseFont = true;
            this.txtContractId.Properties.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(293, 30);
            this.txtContractId.TabIndex = 197;
            // 
            // erpLookUpEditCustomerId
            // 
            this.erpLookUpEditCustomerId.Location = new System.Drawing.Point(93, 106);
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
            this.erpLookUpEditCustomerId.Properties.DataSource = this.vwSaleContractChooseBindingSource;
            this.erpLookUpEditCustomerId.Properties.DisplayMember = "CustomerName";
            this.erpLookUpEditCustomerId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCustomerId.Properties.ValueMember = "CustomerId";
            this.erpLookUpEditCustomerId.Size = new System.Drawing.Size(293, 30);
            this.erpLookUpEditCustomerId.TabIndex = 194;
            this.erpLookUpEditCustomerId.EditValueChanged += new System.EventHandler(this.erpLookUpEditCustomerId_EditValueChanged);
            // 
            // vwSaleContractChooseBindingSource
            // 
            this.vwSaleContractChooseBindingSource.DataMember = "VwSaleContractChoose";
            this.vwSaleContractChooseBindingSource.DataSource = this.dataSet;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(2, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 24);
            this.labelControl2.TabIndex = 192;
            this.labelControl2.Text = "Müəssisə";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(31, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 24);
            this.labelControl3.TabIndex = 193;
            this.labelControl3.Text = "Anbar";
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(92, 36);
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
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(294, 30);
            this.erpLookUpEditCompany.TabIndex = 190;
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.dataSet;
            // 
            // erpLookUpEditWareHouse
            // 
            this.erpLookUpEditWareHouse.Location = new System.Drawing.Point(92, 70);
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
            this.erpLookUpEditWareHouse.Properties.DataSource = this.vwWareHouseBindingSource;
            this.erpLookUpEditWareHouse.Properties.DisplayMember = "Name";
            this.erpLookUpEditWareHouse.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditWareHouse.Properties.ValueMember = "Id";
            this.erpLookUpEditWareHouse.Size = new System.Drawing.Size(294, 30);
            this.erpLookUpEditWareHouse.TabIndex = 191;
            // 
            // vwWareHouseBindingSource
            // 
            this.vwWareHouseBindingSource.DataMember = "VwWareHouse";
            this.vwWareHouseBindingSource.DataSource = this.dataSet;
            // 
            // spWareHouseSelectBindingSource
            // 
            this.spWareHouseSelectBindingSource.DataMember = "spWareHouseSelect";
            this.spWareHouseSelectBindingSource.DataSource = this.dataSet;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(473, 7);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(61, 24);
            this.labelControl10.TabIndex = 201;
            this.labelControl10.Text = "Ödəniş";
            // 
            // erpLookUpEditPaymentType
            // 
            this.erpLookUpEditPaymentType.Location = new System.Drawing.Point(540, 4);
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
            this.erpLookUpEditPaymentType.Size = new System.Drawing.Size(293, 30);
            this.erpLookUpEditPaymentType.TabIndex = 198;
            // 
            // vwPaymentTypeBindingSource
            // 
            this.vwPaymentTypeBindingSource.DataMember = "VwPaymentType";
            this.vwPaymentTypeBindingSource.DataSource = this.dataSet;
            // 
            // txtDiscountWholeSale
            // 
            this.txtDiscountWholeSale.EditValue = "";
            this.txtDiscountWholeSale.Location = new System.Drawing.Point(540, 36);
            this.txtDiscountWholeSale.Name = "txtDiscountWholeSale";
            this.txtDiscountWholeSale.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscountWholeSale.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountWholeSale.Size = new System.Drawing.Size(292, 30);
            this.txtDiscountWholeSale.TabIndex = 202;
            this.txtDiscountWholeSale.EditValueChanged += new System.EventHandler(this.txtDiscountWholeSale_EditValueChanged);
            // 
            // spWareHouseSelectTableAdapter
            // 
            this.spWareHouseSelectTableAdapter.ClearBeforeFill = true;
            // 
            // vwPaymentTypeTableAdapter
            // 
            this.vwPaymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(464, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 24);
            this.labelControl1.TabIndex = 203;
            this.labelControl1.Text = "Endirim ";
            // 
            // vwWareHouseTableAdapter
            // 
            this.vwWareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // vwSaleContractChooseTableAdapter
            // 
            this.vwSaleContractChooseTableAdapter.ClearBeforeFill = true;
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
            this.btnAddGoods,
            this.btnDeleteGoods});
            this.barManager1.MaxItemId = 3;
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Caption = "Məhsul Əlavə Et";
            this.btnAddGoods.Hint = "   ";
            this.btnAddGoods.Id = 1;
            this.btnAddGoods.ImageOptions.ImageUri.Uri = "Add;Size16x16;GrayScaled";
            this.btnAddGoods.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddGoods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddGoods_ItemClick);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.Caption = "Məhsul Sil";
            this.btnDeleteGoods.Hint = " ";
            this.btnDeleteGoods.Id = 2;
            this.btnDeleteGoods.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnDeleteGoods.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDeleteGoods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteGoods_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barDockControlTop.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.barDockControlTop.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 24);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1250, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 580);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1250, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 556);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1250, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 556);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.erpDateEditDeliveryDate);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.dateEditDate);
            this.groupControl1.Controls.Add(this.labelControl19);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.erpLookUpEditPaymentType);
            this.groupControl1.Controls.Add(this.erpLookUpEditWareHouse);
            this.groupControl1.Controls.Add(this.txtDiscountWholeSale);
            this.groupControl1.Controls.Add(this.erpLookUpEditCompany);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtContractId);
            this.groupControl1.Controls.Add(this.erpLookUpEditCustomerId);
            this.groupControl1.Location = new System.Drawing.Point(12, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(857, 180);
            this.groupControl1.TabIndex = 208;
            this.groupControl1.Text = "Müqavilələr";
            // 
            // chckPinGoodCatalog
            // 
            this.chckPinGoodCatalog.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckPinGoodCatalog.Appearance.Options.UseFont = true;
            this.chckPinGoodCatalog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chckPinGoodCatalog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chckPinGoodCatalog.ImageOptions.Image")));
            this.chckPinGoodCatalog.Location = new System.Drawing.Point(875, 32);
            this.chckPinGoodCatalog.Name = "chckPinGoodCatalog";
            this.chckPinGoodCatalog.Size = new System.Drawing.Size(38, 42);
            this.chckPinGoodCatalog.TabIndex = 213;
            this.chckPinGoodCatalog.Visible = false;
            this.chckPinGoodCatalog.CheckedChanged += new System.EventHandler(this.chckPinGoodCatalog_CheckedChanged);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager2.MainMenu = this.bar3;
            this.barManager2.MaxItemId = 4;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1250, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 580);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1250, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 556);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1250, 24);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 556);
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Təsdiqlə";
            this.barButtonItem2.Hint = "   ";
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Enter));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "İmtina Et";
            this.barButtonItem3.Hint = "  ";
            this.barButtonItem3.Id = 1;
            this.barButtonItem3.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.barButtonItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Məhsul Əlavə Et";
            this.barButtonItem4.Hint = "   ";
            this.barButtonItem4.Id = 2;
            this.barButtonItem4.ImageOptions.ImageUri.Uri = "AddNewDataSource;Size16x16;GrayScaled";
            this.barButtonItem4.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Məhsul Sil";
            this.barButtonItem5.Hint = " ";
            this.barButtonItem5.Id = 3;
            this.barButtonItem5.ImageOptions.ImageUri.Uri = "DeleteDataSource;Size16x16;GrayScaled";
            this.barButtonItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // OfflineNewSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 580);
            this.Controls.Add(this.chckPinGoodCatalog);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.s);
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
            this.MinimumSize = new System.Drawing.Size(1041, 619);
            this.Name = "OfflineNewSaleForm";
            this.Text = "Daşınma Sənədi";
            this.Load += new System.EventHandler(this.OfflineNewSaleForm_Load);
            this.Controls.SetChildIndex(this.barDockControl1, 0);
            this.Controls.SetChildIndex(this.barDockControl2, 0);
            this.Controls.SetChildIndex(this.barDockControl4, 0);
            this.Controls.SetChildIndex(this.barDockControl3, 0);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.s, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.chckPinGoodCatalog, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            this.s.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwOfflineSaleDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLogisticDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContractId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCustomerId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSaleContractChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWareHouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHouseSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountWholeSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private ERP.Infrastructure.Interfaces.erpDateEdit dateEditDate;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.GroupControl s;
        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoGood;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoUnit;
        private ERP.Infrastructure.Interfaces.erpDateEdit erpDateEditDeliveryDate;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnDeleteContracts;
        private DevExpress.XtraEditors.SimpleButton btnApplyContracts;
        private DevExpress.XtraEditors.SimpleButton btnAddContracts;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwLogisticDetailBindingSource;
        private Data.AccountingDataSetTableAdapters.VwLogisticDetailTableAdapter vwLogisticDetailTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodSelectTableAdapter vwGoodSelectTableAdapter;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private Data.AccountingDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoBarcode;
        private System.Windows.Forms.BindingSource vwBarcodeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter vwBarcodeTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcodeId;
        private System.Windows.Forms.BindingSource vwOfflineSaleDetailBindingSource;
        private Data.AccountingDataSetTableAdapters.VwOfflineSaleDetailTableAdapter vwOfflineSaleDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountWholeSale;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtContractId;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCustomerId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompany;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditWareHouse;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPaymentType;
        private DevExpress.XtraEditors.TextEdit txtDiscountWholeSale;
        private System.Windows.Forms.BindingSource spWareHouseSelectBindingSource;
        private Data.AccountingDataSetTableAdapters.spWareHouseSelectTableAdapter spWareHouseSelectTableAdapter;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource vwWareHouseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwWareHouseTableAdapter vwWareHouseTableAdapter;
        private System.Windows.Forms.BindingSource vwSaleContractChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwSaleContractChooseTableAdapter vwSaleContractChooseTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnAddGoods;
        private DevExpress.XtraBars.BarButtonItem btnDeleteGoods;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckButton chckPinGoodCatalog;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
    }
}