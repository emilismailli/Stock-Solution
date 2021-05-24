namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class GoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodForm));
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMDataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGoodName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGoodCode = new DevExpress.XtraEditors.TextEdit();
            this.vwDoseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.vwPackingTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPackingTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwPackingTypeTableAdapter();
            this.vwDoseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwDoseTableAdapter();
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwUnitTableAdapter();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            this.vwRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwRegionTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwRegionTableAdapter();
            this.gridControlBarcode = new DevExpress.XtraGrid.GridControl();
            this.vwBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewBarcode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoIncludedGood = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repoAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repoUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repoBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwBarcodeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter();
            this.erpLookUpEditGoodTypeId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwGoodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditManufacturerCompanyId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpTreeListLookUpEditRegionId = new MHM.Accountancy.Business.Infrastructure.UI.erpTreeListLookUpEdit();
            this.erpTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.erpLookUpEditPackingTypeId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.erpLookUpEditDoseId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.erpLookUpEditUnitId = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.btnBarcodeGeneration = new DevExpress.XtraEditors.SimpleButton();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeGenerateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeGenerateTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.BarcodeGenerateTableAdapter();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabBarcode = new DevExpress.XtraTab.XtraTabPage();
            this.tabImages = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlImages = new DevExpress.XtraGrid.GridControl();
            this.imagesGoodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Images = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.imagesGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagesGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.ImagesGoodTableAdapter();
            this.vwGoodTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTypeTableAdapter();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBarcodeAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarcodeDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarcodeGen = new DevExpress.XtraBars.BarButtonItem();
            this.btnAcceptGood = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPackingTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditGoodTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditManufacturerCompanyId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditRegionId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPackingTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditDoseId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditUnitId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGenerateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabBarcode.SuspendLayout();
            this.tabImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesGoodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(739, 555);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(833, 555);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(15, 562);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(474, 548);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(380, 553);
            this.btnPrintDocument.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(0, 93);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 19);
            this.labelControl8.TabIndex = 100;
            this.labelControl8.Text = "İstehsalçı Firma";
            // 
            // vwUnitBindingSource
            // 
            this.vwUnitBindingSource.DataMember = "VwUnit";
            this.vwUnitBindingSource.DataSource = this.cRMDataSet;
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(599, 117);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(209, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(481, 115);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(101, 19);
            this.labelControl16.TabIndex = 84;
            this.labelControl16.Text = "Saxlanma Yeri";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(501, 90);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 19);
            this.labelControl6.TabIndex = 73;
            this.labelControl6.Text = "Ölçü Vahidi";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(83, 170);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 19);
            this.labelControl4.TabIndex = 71;
            this.labelControl4.Text = "ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 19);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Növ";
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(123, 41);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(351, 20);
            this.txtGoodName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(90, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 19);
            this.labelControl2.TabIndex = 66;
            this.labelControl2.Text = "Ad";
            // 
            // txtGoodCode
            // 
            this.txtGoodCode.Location = new System.Drawing.Point(123, 172);
            this.txtGoodCode.Name = "txtGoodCode";
            this.txtGoodCode.Properties.ReadOnly = true;
            this.txtGoodCode.Size = new System.Drawing.Size(351, 20);
            this.txtGoodCode.TabIndex = 5;
            // 
            // vwDoseBindingSource
            // 
            this.vwDoseBindingSource.DataMember = "VwDose";
            this.vwDoseBindingSource.DataSource = this.cRMDataSet;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(547, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 19);
            this.labelControl3.TabIndex = 104;
            this.labelControl3.Text = "Doza";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(546, 42);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 19);
            this.labelControl9.TabIndex = 108;
            this.labelControl9.Text = "Rəng";
            // 
            // vwPackingTypeBindingSource
            // 
            this.vwPackingTypeBindingSource.DataMember = "VwPackingType";
            this.vwPackingTypeBindingSource.DataSource = this.cRMDataSet;
            // 
            // vwPackingTypeTableAdapter
            // 
            this.vwPackingTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwDoseTableAdapter
            // 
            this.vwDoseTableAdapter.ClearBeforeFill = true;
            // 
            // vwUnitTableAdapter
            // 
            this.vwUnitTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(78, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 19);
            this.labelControl5.TabIndex = 110;
            this.labelControl5.Text = "Ölkə";
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            // 
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // vwRegionBindingSource
            // 
            this.vwRegionBindingSource.DataMember = "VwRegion";
            this.vwRegionBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwRegionTableAdapter
            // 
            this.vwRegionTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlBarcode
            // 
            this.gridControlBarcode.DataSource = this.vwBarcodeBindingSource;
            this.gridControlBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBarcode.Location = new System.Drawing.Point(0, 0);
            this.gridControlBarcode.MainView = this.gridViewBarcode;
            this.gridControlBarcode.Name = "gridControlBarcode";
            this.gridControlBarcode.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoIncludedGood,
            this.repoAccount,
            this.repoUnit,
            this.repoBarcode});
            this.gridControlBarcode.Size = new System.Drawing.Size(582, 320);
            this.gridControlBarcode.TabIndex = 10;
            this.gridControlBarcode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBarcode});
            // 
            // vwBarcodeBindingSource
            // 
            this.vwBarcodeBindingSource.DataMember = "VwBarcode";
            this.vwBarcodeBindingSource.DataSource = this.accountingDataSet;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBarcode
            // 
            this.gridViewBarcode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarcode});
            this.gridViewBarcode.GridControl = this.gridControlBarcode;
            this.gridViewBarcode.Name = "gridViewBarcode";
            this.gridViewBarcode.OptionsFind.AlwaysVisible = true;
            this.gridViewBarcode.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewBarcode.OptionsFind.SearchInPreview = true;
            this.gridViewBarcode.OptionsFind.ShowClearButton = false;
            this.gridViewBarcode.OptionsFind.ShowFindButton = false;
            this.gridViewBarcode.OptionsSelection.MultiSelect = true;
            this.gridViewBarcode.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewBarcode.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBarcode.OptionsView.ShowFooter = true;
            this.gridViewBarcode.OptionsView.ShowGroupPanel = false;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "Barkod";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.Image = ((System.Drawing.Image)(resources.GetObject("colBarcode.Image")));
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 1;
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
            // 
            // repoAccount
            // 
            this.repoAccount.AutoHeight = false;
            this.repoAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoAccount.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kod", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoAccount.DisplayMember = "Name";
            this.repoAccount.Name = "repoAccount";
            this.repoAccount.NullText = "[Seçim Edilməyib]";
            this.repoAccount.ValueMember = "Id";
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
            // 
            // vwBarcodeTableAdapter
            // 
            this.vwBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // erpLookUpEditGoodTypeId
            // 
            this.erpLookUpEditGoodTypeId.Location = new System.Drawing.Point(123, 67);
            this.erpLookUpEditGoodTypeId.Name = "erpLookUpEditGoodTypeId";
            this.erpLookUpEditGoodTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditGoodTypeId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Məhsul Növü", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Müəssisə", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditGoodTypeId.Properties.DataSource = this.vwGoodTypeBindingSource;
            this.erpLookUpEditGoodTypeId.Properties.DisplayMember = "Name";
            this.erpLookUpEditGoodTypeId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditGoodTypeId.Properties.ValueMember = "Id";
            this.erpLookUpEditGoodTypeId.Size = new System.Drawing.Size(351, 20);
            this.erpLookUpEditGoodTypeId.TabIndex = 2;
            this.erpLookUpEditGoodTypeId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditGoodTypeId_ButtonClick);
            // 
            // vwGoodTypeBindingSource
            // 
            this.vwGoodTypeBindingSource.DataMember = "VwGoodType";
            this.vwGoodTypeBindingSource.DataSource = this.accountingDataSet;
            // 
            // erpLookUpEditManufacturerCompanyId
            // 
            this.erpLookUpEditManufacturerCompanyId.Location = new System.Drawing.Point(123, 95);
            this.erpLookUpEditManufacturerCompanyId.Name = "erpLookUpEditManufacturerCompanyId";
            this.erpLookUpEditManufacturerCompanyId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditManufacturerCompanyId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegionName", "Region Name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WorkTypeName", "Work Type Name", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voen", "Voen", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "Bank Name", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditManufacturerCompanyId.Properties.DataSource = this.vwCompanyBindingSource;
            this.erpLookUpEditManufacturerCompanyId.Properties.DisplayMember = "CompanyName";
            this.erpLookUpEditManufacturerCompanyId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditManufacturerCompanyId.Properties.ValueMember = "Id";
            this.erpLookUpEditManufacturerCompanyId.Size = new System.Drawing.Size(351, 20);
            this.erpLookUpEditManufacturerCompanyId.TabIndex = 3;
            this.erpLookUpEditManufacturerCompanyId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCustomerId_ButtonClick);
            this.erpLookUpEditManufacturerCompanyId.EditValueChanged += new System.EventHandler(this.erpLookUpEditManufacturerCompanyId_EditValueChanged);
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.accountingDataSet;
            // 
            // erpTreeListLookUpEditRegionId
            // 
            this.erpTreeListLookUpEditRegionId.Location = new System.Drawing.Point(123, 120);
            this.erpTreeListLookUpEditRegionId.Name = "erpTreeListLookUpEditRegionId";
            this.erpTreeListLookUpEditRegionId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpTreeListLookUpEditRegionId.Properties.DataSource = this.vwRegionBindingSource;
            this.erpTreeListLookUpEditRegionId.Properties.DisplayMember = "Name";
            this.erpTreeListLookUpEditRegionId.Properties.NullText = "[Seçim edilməyib]";
            this.erpTreeListLookUpEditRegionId.Properties.ReadOnly = true;
            this.erpTreeListLookUpEditRegionId.Properties.TreeList = this.erpTreeListLookUpEdit1TreeList;
            this.erpTreeListLookUpEditRegionId.Properties.ValueMember = "Id";
            this.erpTreeListLookUpEditRegionId.Size = new System.Drawing.Size(351, 20);
            this.erpTreeListLookUpEditRegionId.TabIndex = 4;
            this.erpTreeListLookUpEditRegionId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpTreeListLookUpEditRegionId_ButtonClick);
            // 
            // erpTreeListLookUpEdit1TreeList
            // 
            this.erpTreeListLookUpEdit1TreeList.DataSource = this.vwRegionBindingSource;
            this.erpTreeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.erpTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.erpTreeListLookUpEdit1TreeList.Name = "erpTreeListLookUpEdit1TreeList";
            this.erpTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.erpTreeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.erpTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.erpTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // erpLookUpEditPackingTypeId
            // 
            this.erpLookUpEditPackingTypeId.Location = new System.Drawing.Point(599, 41);
            this.erpLookUpEditPackingTypeId.Name = "erpLookUpEditPackingTypeId";
            this.erpLookUpEditPackingTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditPackingTypeId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditPackingTypeId.Properties.DataSource = this.vwPackingTypeBindingSource;
            this.erpLookUpEditPackingTypeId.Properties.DisplayMember = "Name";
            this.erpLookUpEditPackingTypeId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditPackingTypeId.Properties.ValueMember = "Id";
            this.erpLookUpEditPackingTypeId.Size = new System.Drawing.Size(209, 20);
            this.erpLookUpEditPackingTypeId.TabIndex = 6;
            this.erpLookUpEditPackingTypeId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditPackingTypeId_ButtonClick);
            // 
            // erpLookUpEditDoseId
            // 
            this.erpLookUpEditDoseId.Location = new System.Drawing.Point(599, 67);
            this.erpLookUpEditDoseId.Name = "erpLookUpEditDoseId";
            this.erpLookUpEditDoseId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditDoseId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditDoseId.Properties.DataSource = this.vwDoseBindingSource;
            this.erpLookUpEditDoseId.Properties.DisplayMember = "Name";
            this.erpLookUpEditDoseId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditDoseId.Properties.ValueMember = "Id";
            this.erpLookUpEditDoseId.Size = new System.Drawing.Size(209, 20);
            this.erpLookUpEditDoseId.TabIndex = 7;
            this.erpLookUpEditDoseId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCustomerId_ButtonClick);
            // 
            // erpLookUpEditUnitId
            // 
            this.erpLookUpEditUnitId.Location = new System.Drawing.Point(599, 92);
            this.erpLookUpEditUnitId.Name = "erpLookUpEditUnitId";
            this.erpLookUpEditUnitId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditUnitId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditUnitId.Properties.DataSource = this.vwUnitBindingSource;
            this.erpLookUpEditUnitId.Properties.DisplayMember = "Name";
            this.erpLookUpEditUnitId.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditUnitId.Properties.ValueMember = "Id";
            this.erpLookUpEditUnitId.Size = new System.Drawing.Size(209, 20);
            this.erpLookUpEditUnitId.TabIndex = 8;
            this.erpLookUpEditUnitId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditUnitId_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDeleteBarcode);
            this.groupControl2.Controls.Add(this.btnApplyBarcode);
            this.groupControl2.Controls.Add(this.btnAddBarcode);
            this.groupControl2.Location = new System.Drawing.Point(823, 40);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(91, 118);
            this.groupControl2.TabIndex = 113;
            this.groupControl2.Text = "Barkod";
            this.groupControl2.Visible = false;
            // 
            // btnDeleteBarcode
            // 
            this.btnDeleteBarcode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBarcode.ImageOptions.Image")));
            this.btnDeleteBarcode.Location = new System.Drawing.Point(7, 82);
            this.btnDeleteBarcode.Name = "btnDeleteBarcode";
            this.btnDeleteBarcode.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteBarcode.TabIndex = 2;
            this.btnDeleteBarcode.Text = "Sil";
            this.btnDeleteBarcode.Click += new System.EventHandler(this.btnDeleteBarcode_Click);
            // 
            // btnApplyBarcode
            // 
            this.btnApplyBarcode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyBarcode.ImageOptions.Image")));
            this.btnApplyBarcode.Location = new System.Drawing.Point(7, 52);
            this.btnApplyBarcode.Name = "btnApplyBarcode";
            this.btnApplyBarcode.Size = new System.Drawing.Size(78, 29);
            this.btnApplyBarcode.TabIndex = 1;
            this.btnApplyBarcode.Text = "Təsdiqlə";
            this.btnApplyBarcode.Click += new System.EventHandler(this.btnApplyBarcode_Click);
            // 
            // btnAddBarcode
            // 
            this.btnAddBarcode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBarcode.ImageOptions.Image")));
            this.btnAddBarcode.Location = new System.Drawing.Point(6, 22);
            this.btnAddBarcode.Name = "btnAddBarcode";
            this.btnAddBarcode.Size = new System.Drawing.Size(79, 29);
            this.btnAddBarcode.TabIndex = 11;
            this.btnAddBarcode.Text = "Yeni";
            this.btnAddBarcode.Click += new System.EventHandler(this.btnAddBarcode_Click);
            // 
            // btnBarcodeGeneration
            // 
            this.btnBarcodeGeneration.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarcodeGeneration.ImageOptions.Image")));
            this.btnBarcodeGeneration.Location = new System.Drawing.Point(599, 143);
            this.btnBarcodeGeneration.Name = "btnBarcodeGeneration";
            this.btnBarcodeGeneration.Size = new System.Drawing.Size(209, 35);
            this.btnBarcodeGeneration.TabIndex = 10;
            this.btnBarcodeGeneration.Text = "Barkod Generasiya";
            this.btnBarcodeGeneration.Visible = false;
            this.btnBarcodeGeneration.Click += new System.EventHandler(this.btnBarcodeGeneration_Click);
            // 
            // barcodeGenerateBindingSource
            // 
            this.barcodeGenerateBindingSource.DataSource = this.dataSetBindingSource;
            // 
            // barcodeGenerateTableAdapter
            // 
            this.barcodeGenerateTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 199);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabBarcode;
            this.xtraTabControl1.Size = new System.Drawing.Size(588, 348);
            this.xtraTabControl1.TabIndex = 116;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabBarcode,
            this.tabImages});
            // 
            // tabBarcode
            // 
            this.tabBarcode.Controls.Add(this.gridControlBarcode);
            this.tabBarcode.Name = "tabBarcode";
            this.tabBarcode.Size = new System.Drawing.Size(582, 320);
            this.tabBarcode.Text = "Barkod";
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.gridControlImages);
            this.tabImages.Controls.Add(this.btnRemove);
            this.tabImages.Controls.Add(this.btnAdd);
            this.tabImages.Name = "tabImages";
            this.tabImages.Size = new System.Drawing.Size(582, 320);
            // 
            // gridControlImages
            // 
            this.gridControlImages.DataSource = this.imagesGoodBindingSource1;
            this.gridControlImages.Location = new System.Drawing.Point(1, 3);
            this.gridControlImages.MainView = this.Images;
            this.gridControlImages.Name = "gridControlImages";
            this.gridControlImages.Size = new System.Drawing.Size(636, 185);
            this.gridControlImages.TabIndex = 3;
            this.gridControlImages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Images});
            this.gridControlImages.Visible = false;
            // 
            // imagesGoodBindingSource1
            // 
            this.imagesGoodBindingSource1.DataMember = "ImagesGood";
            this.imagesGoodBindingSource1.DataSource = this.accountingDataSet;
            // 
            // Images
            // 
            this.Images.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colIsMain});
            this.Images.GridControl = this.gridControlImages;
            this.Images.Name = "Images";
            this.Images.OptionsView.ShowGroupPanel = false;
            // 
            // colImage
            // 
            this.colImage.Caption = "Şəkillər";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            // 
            // colIsMain
            // 
            this.colIsMain.Caption = "Əsas";
            this.colIsMain.FieldName = "IsMain";
            this.colIsMain.Name = "colIsMain";
            this.colIsMain.Visible = true;
            this.colIsMain.VisibleIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.Location = new System.Drawing.Point(104, 243);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 35);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Sil";
            this.btnRemove.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(10, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Əlavə Et";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imagesGoodBindingSource
            // 
            this.imagesGoodBindingSource.DataMember = "ImagesGood";
            this.imagesGoodBindingSource.DataSource = this.accountingDataSet;
            // 
            // imagesGoodTableAdapter
            // 
            this.imagesGoodTableAdapter.ClearBeforeFill = true;
            // 
            // vwGoodTypeTableAdapter
            // 
            this.vwGoodTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(123, 146);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(351, 20);
            this.txtCode.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(63, 144);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 19);
            this.labelControl7.TabIndex = 118;
            this.labelControl7.Text = "Artikul";
            // 
            // pictureEdit
            // 
            this.pictureEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit.Location = new System.Drawing.Point(598, 222);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.NullText = "Şəkil seçmək üçün sağ düyməni klikləyin";
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit.Size = new System.Drawing.Size(320, 320);
            this.pictureEdit.TabIndex = 119;
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
            this.btnBarcodeAdd,
            this.btnBarcodeDel,
            this.btnBarcodeGen,
            this.btnAcceptGood,
            this.btnClose});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBarcodeAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBarcodeDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBarcodeGen),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAcceptGood),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBarcodeAdd
            // 
            this.btnBarcodeAdd.Caption = "Barkod Əlavə Et";
            this.btnBarcodeAdd.Hint = "  ";
            this.btnBarcodeAdd.Id = 0;
            this.btnBarcodeAdd.ImageOptions.ImageUri.Uri = "Add;Size16x16;GrayScaled";
            this.btnBarcodeAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.btnBarcodeAdd.Name = "btnBarcodeAdd";
            this.btnBarcodeAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBarcodeAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarcodeAdd_ItemClick);
            // 
            // btnBarcodeDel
            // 
            this.btnBarcodeDel.Caption = "Barkod Sil";
            this.btnBarcodeDel.Hint = "  ";
            this.btnBarcodeDel.Id = 1;
            this.btnBarcodeDel.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnBarcodeDel.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnBarcodeDel.Name = "btnBarcodeDel";
            this.btnBarcodeDel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBarcodeDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarcodeDel_ItemClick);
            // 
            // btnBarcodeGen
            // 
            this.btnBarcodeGen.Caption = "Yeni Barkod Generasiya Et";
            this.btnBarcodeGen.Hint = "  ";
            this.btnBarcodeGen.Id = 2;
            this.btnBarcodeGen.ImageOptions.ImageUri.Uri = "AlignCenter;Size16x16;GrayScaled";
            this.btnBarcodeGen.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert));
            this.btnBarcodeGen.Name = "btnBarcodeGen";
            this.btnBarcodeGen.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBarcodeGen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarcodeGen_ItemClick);
            // 
            // btnAcceptGood
            // 
            this.btnAcceptGood.Caption = "Təsdiqlə";
            this.btnAcceptGood.Hint = "   ";
            this.btnAcceptGood.Id = 3;
            this.btnAcceptGood.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnAcceptGood.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return));
            this.btnAcceptGood.Name = "btnAcceptGood";
            this.btnAcceptGood.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAcceptGood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAcceptGood_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(926, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 594);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(926, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 570);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(926, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 570);
            // 
            // GoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 594);
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnBarcodeGeneration);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.erpLookUpEditUnitId);
            this.Controls.Add(this.erpLookUpEditDoseId);
            this.Controls.Add(this.erpLookUpEditPackingTypeId);
            this.Controls.Add(this.erpTreeListLookUpEditRegionId);
            this.Controls.Add(this.erpLookUpEditManufacturerCompanyId);
            this.Controls.Add(this.erpLookUpEditGoodTypeId);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtGoodCode);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGoodName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(942, 561);
            this.Name = "GoodForm";
            this.Text = "Məhsullar";
            this.Load += new System.EventHandler(this.GoodForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtGoodName, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl16, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.txtGoodCode, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditGoodTypeId, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditManufacturerCompanyId, 0);
            this.Controls.SetChildIndex(this.erpTreeListLookUpEditRegionId, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditPackingTypeId, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditDoseId, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditUnitId, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.btnBarcodeGeneration, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.pictureEdit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPackingTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoIncludedGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditGoodTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditManufacturerCompanyId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditRegionId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPackingTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditDoseId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditUnitId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGenerateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabBarcode.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesGoodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtGoodName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGoodCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private CRM.Data.CRMDataSet cRMDataSet;
        private System.Windows.Forms.BindingSource vwPackingTypeBindingSource;
        private CRM.Data.CRMDataSetTableAdapters.VwPackingTypeTableAdapter vwPackingTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwDoseBindingSource;
        private CRM.Data.CRMDataSetTableAdapters.VwDoseTableAdapter vwDoseTableAdapter;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private CRM.Data.CRMDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private System.Windows.Forms.BindingSource vwRegionBindingSource;
        private Data.AccountingDataSetTableAdapters.VwRegionTableAdapter vwRegionTableAdapter;
        private System.Windows.Forms.BindingSource vwBarcodeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBarcodeTableAdapter vwBarcodeTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlBarcode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoIncludedGood;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoAccount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoBarcode;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditGoodTypeId;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditManufacturerCompanyId;
        private Business.Infrastructure.UI.erpTreeListLookUpEdit erpTreeListLookUpEditRegionId;
        private DevExpress.XtraTreeList.TreeList erpTreeListLookUpEdit1TreeList;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPackingTypeId;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditDoseId;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditUnitId;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnDeleteBarcode;
        private DevExpress.XtraEditors.SimpleButton btnApplyBarcode;
        private DevExpress.XtraEditors.SimpleButton btnAddBarcode;
        private DevExpress.XtraEditors.SimpleButton btnBarcodeGeneration;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.BindingSource barcodeGenerateBindingSource;
        private Data.AccountingDataSetTableAdapters.BarcodeGenerateTableAdapter barcodeGenerateTableAdapter;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabBarcode;
        private DevExpress.XtraTab.XtraTabPage tabImages;
        private Data.AccountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource imagesGoodBindingSource;
        private Data.AccountingDataSetTableAdapters.ImagesGoodTableAdapter imagesGoodTableAdapter;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridControlImages;
        private DevExpress.XtraGrid.Views.Grid.GridView Images;
        private System.Windows.Forms.BindingSource imagesGoodBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMain;
        private System.Windows.Forms.BindingSource vwGoodTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodTypeTableAdapter vwGoodTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBarcodeAdd;
        private DevExpress.XtraBars.BarButtonItem btnBarcodeDel;
        private DevExpress.XtraBars.BarButtonItem btnBarcodeGen;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAcceptGood;
        private DevExpress.XtraBars.BarButtonItem btnClose;
    }
}