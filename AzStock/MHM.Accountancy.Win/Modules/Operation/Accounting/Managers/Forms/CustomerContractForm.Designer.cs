namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class CustomerContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerContractForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlContract = new DevExpress.XtraGrid.GridControl();
            this.vwContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewContract = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoContractType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwContractTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colOperationTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoOperationType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.operationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCompany = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtLegalAddress = new DevExpress.XtraEditors.TextEdit();
            this.dateEditDesc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtBankSwift = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerLeader = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtActualAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtVoen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRegionType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.vwRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeListLookUpEditRegion = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.erpLookUpEditWorkType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwWorkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpLookUpEditCurrency = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.erpLookUpEditBank = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwBankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.vwContractTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwContractTableAdapter();
            this.erpMemoExEditDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.vwWorkTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwWorkTypeTableAdapter();
            this.vwCurrencyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter();
            this.vwBankTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBankTableAdapter();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.operationTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.OperationTypeTableAdapter();
            this.vwContractTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwContractTypeTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteContracts = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyContracts = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddContracts = new DevExpress.XtraEditors.SimpleButton();
            this.erpLookUpEditCompanyType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.companyTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.companyTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.CompanyTypeTableAdapter();
            this.lookUpParentCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.vwCustomerTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter();
            this.vwRegionTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwRegionTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAceptCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoContractType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoOperationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLegalAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankSwift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerLeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWorkType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWorkTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMemoExEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompanyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpParentCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(651, 559);
            this.btnAccept.Size = new System.Drawing.Size(88, 35);
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(743, 559);
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 574);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(267, 558);
            this.btnDelete.Size = new System.Drawing.Size(88, 35);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(361, 559);
            this.btnPrintDocument.Size = new System.Drawing.Size(88, 35);
            this.btnPrintDocument.Visible = false;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click_1);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControlContract);
            this.groupControl1.Location = new System.Drawing.Point(11, 277);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(820, 291);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "Müqavilələr";
            // 
            // gridControlContract
            // 
            this.gridControlContract.DataSource = this.vwContractBindingSource;
            this.gridControlContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlContract.Location = new System.Drawing.Point(2, 20);
            this.gridControlContract.MainView = this.gridViewContract;
            this.gridControlContract.Name = "gridControlContract";
            this.gridControlContract.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCurrency,
            this.repoCompany,
            this.repoContractType,
            this.repoOperationType});
            this.gridControlContract.Size = new System.Drawing.Size(816, 269);
            this.gridControlContract.TabIndex = 0;
            this.gridControlContract.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContract});
            // 
            // vwContractBindingSource
            // 
            this.vwContractBindingSource.DataMember = "VwContract";
            this.vwContractBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewContract
            // 
            this.gridViewContract.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colContractDate,
            this.colContractTypeName,
            this.colCurrencyName,
            this.colOperationTypeName,
            this.colCompanyName,
            this.colDescription});
            this.gridViewContract.GridControl = this.gridControlContract;
            this.gridViewContract.Name = "gridViewContract";
            this.gridViewContract.OptionsFind.AlwaysVisible = true;
            this.gridViewContract.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewContract.OptionsSelection.MultiSelect = true;
            this.gridViewContract.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewContract.OptionsView.ShowAutoFilterRow = true;
            this.gridViewContract.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "Müqavilə №";
            this.colId.DisplayFormat.FormatString = "{0:000000}";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.FieldName = "Id";
            this.colId.GroupFormat.FormatString = "{0:000000}";
            this.colId.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.Image = ((System.Drawing.Image)(resources.GetObject("colId.Image")));
            this.colId.MinWidth = 85;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 108;
            // 
            // colContractDate
            // 
            this.colContractDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colContractDate.AppearanceCell.Options.UseFont = true;
            this.colContractDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colContractDate.AppearanceHeader.Options.UseFont = true;
            this.colContractDate.Caption = "Müqavilə Tarixi";
            this.colContractDate.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colContractDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colContractDate.FieldName = "ContractDate";
            this.colContractDate.GroupFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colContractDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colContractDate.Image = ((System.Drawing.Image)(resources.GetObject("colContractDate.Image")));
            this.colContractDate.Name = "colContractDate";
            this.colContractDate.Visible = true;
            this.colContractDate.VisibleIndex = 2;
            this.colContractDate.Width = 191;
            // 
            // colContractTypeName
            // 
            this.colContractTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colContractTypeName.AppearanceCell.Options.UseFont = true;
            this.colContractTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colContractTypeName.AppearanceHeader.Options.UseFont = true;
            this.colContractTypeName.Caption = "Müqavilə növü";
            this.colContractTypeName.ColumnEdit = this.repoContractType;
            this.colContractTypeName.FieldName = "ContractTypeId";
            this.colContractTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colContractTypeName.Image")));
            this.colContractTypeName.Name = "colContractTypeName";
            this.colContractTypeName.Visible = true;
            this.colContractTypeName.VisibleIndex = 3;
            this.colContractTypeName.Width = 186;
            // 
            // repoContractType
            // 
            this.repoContractType.AutoHeight = false;
            this.repoContractType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoContractType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Müqavilə növü", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoContractType.DataSource = this.vwContractTypeBindingSource;
            this.repoContractType.DisplayMember = "Name";
            this.repoContractType.Name = "repoContractType";
            this.repoContractType.NullText = "[Seçim Edilməyib]";
            this.repoContractType.ValueMember = "Id";
            // 
            // vwContractTypeBindingSource
            // 
            this.vwContractTypeBindingSource.DataMember = "VwContractType";
            this.vwContractTypeBindingSource.DataSource = this.dataSet;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCurrencyName.AppearanceCell.Options.UseFont = true;
            this.colCurrencyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCurrencyName.AppearanceHeader.Options.UseFont = true;
            this.colCurrencyName.Caption = "Valyuta";
            this.colCurrencyName.ColumnEdit = this.repoCurrency;
            this.colCurrencyName.FieldName = "CurrencyId";
            this.colCurrencyName.Image = ((System.Drawing.Image)(resources.GetObject("colCurrencyName.Image")));
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 4;
            this.colCurrencyName.Width = 186;
            // 
            // repoCurrency
            // 
            this.repoCurrency.AutoHeight = false;
            this.repoCurrency.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCurrency.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Valyuta adı", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoCurrency.DataSource = this.vwCurrencyBindingSource;
            this.repoCurrency.DisplayMember = "Name";
            this.repoCurrency.Name = "repoCurrency";
            this.repoCurrency.NullText = "[Seçim Edilməyib]";
            this.repoCurrency.ValueMember = "Id";
            // 
            // vwCurrencyBindingSource
            // 
            this.vwCurrencyBindingSource.DataMember = "VwCurrency";
            this.vwCurrencyBindingSource.DataSource = this.dataSet;
            // 
            // colOperationTypeName
            // 
            this.colOperationTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colOperationTypeName.AppearanceCell.Options.UseFont = true;
            this.colOperationTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colOperationTypeName.AppearanceHeader.Options.UseFont = true;
            this.colOperationTypeName.Caption = "Əməliyyat növü";
            this.colOperationTypeName.ColumnEdit = this.repoOperationType;
            this.colOperationTypeName.FieldName = "OperationTypeId";
            this.colOperationTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colOperationTypeName.Image")));
            this.colOperationTypeName.Name = "colOperationTypeName";
            this.colOperationTypeName.Visible = true;
            this.colOperationTypeName.VisibleIndex = 5;
            this.colOperationTypeName.Width = 186;
            // 
            // repoOperationType
            // 
            this.repoOperationType.AutoHeight = false;
            this.repoOperationType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoOperationType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Əməliyyat növü", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoOperationType.DataSource = this.operationTypeBindingSource;
            this.repoOperationType.DisplayMember = "Name";
            this.repoOperationType.Name = "repoOperationType";
            this.repoOperationType.NullText = "[Seçim Edilməyib]";
            this.repoOperationType.ValueMember = "Id";
            // 
            // operationTypeBindingSource
            // 
            this.operationTypeBindingSource.DataMember = "OperationType";
            this.operationTypeBindingSource.DataSource = this.dataSet;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Müəssisə adı";
            this.colCompanyName.ColumnEdit = this.repoCompany;
            this.colCompanyName.FieldName = "CompanyId";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 6;
            this.colCompanyName.Width = 186;
            // 
            // repoCompany
            // 
            this.repoCompany.AutoHeight = false;
            this.repoCompany.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCompany.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Müəssisə adı", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoCompany.DataSource = this.vwCompanyBindingSource;
            this.repoCompany.DisplayMember = "CompanyName";
            this.repoCompany.Name = "repoCompany";
            this.repoCompany.NullText = "[Seçim Edilməyib]";
            this.repoCompany.ValueMember = "Id";
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.dataSet;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Image = ((System.Drawing.Image)(resources.GetObject("colDescription.Image")));
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 217;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(485, 84);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(49, 19);
            this.labelControl14.TabIndex = 171;
            this.labelControl14.Text = "Region";
            // 
            // txtLegalAddress
            // 
            this.txtLegalAddress.Location = new System.Drawing.Point(540, 110);
            this.txtLegalAddress.Name = "txtLegalAddress";
            this.txtLegalAddress.Size = new System.Drawing.Size(281, 20);
            this.txtLegalAddress.TabIndex = 151;
            // 
            // dateEditDesc
            // 
            this.dateEditDesc.EditValue = null;
            this.dateEditDesc.Location = new System.Drawing.Point(540, 213);
            this.dateEditDesc.Name = "dateEditDesc";
            this.dateEditDesc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDesc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDesc.Size = new System.Drawing.Size(281, 20);
            this.dateEditDesc.TabIndex = 155;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(419, 216);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(115, 19);
            this.labelControl16.TabIndex = 170;
            this.labelControl16.Text = "Qeydiyyat Tarixi";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(127, 32);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(283, 20);
            this.txtNumber.TabIndex = 143;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 19);
            this.labelControl2.TabIndex = 157;
            this.labelControl2.Text = "Şəxsi Hesab №";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 158;
            this.labelControl1.Text = "Müştəri Firma";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(84, 245);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 19);
            this.labelControl8.TabIndex = 169;
            this.labelControl8.Text = "Qeyd";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(127, 81);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(283, 20);
            this.txtCustomerName.TabIndex = 144;
            // 
            // txtBankSwift
            // 
            this.txtBankSwift.Location = new System.Drawing.Point(540, 58);
            this.txtBankSwift.Name = "txtBankSwift";
            this.txtBankSwift.Properties.ReadOnly = true;
            this.txtBankSwift.Size = new System.Drawing.Size(281, 20);
            this.txtBankSwift.TabIndex = 150;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 19);
            this.labelControl3.TabIndex = 159;
            this.labelControl3.Text = "Fəaliyyət Növü";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(443, 56);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(91, 19);
            this.labelControl9.TabIndex = 168;
            this.labelControl9.Text = "Bankın Swifti";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 19);
            this.labelControl4.TabIndex = 160;
            this.labelControl4.Text = "Firma Rəhbəri";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(540, 186);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(281, 20);
            this.txtTel.TabIndex = 154;
            // 
            // txtCustomerLeader
            // 
            this.txtCustomerLeader.Location = new System.Drawing.Point(127, 107);
            this.txtCustomerLeader.Name = "txtCustomerLeader";
            this.txtCustomerLeader.Size = new System.Drawing.Size(283, 20);
            this.txtCustomerLeader.TabIndex = 145;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(512, 187);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(22, 19);
            this.labelControl10.TabIndex = 167;
            this.labelControl10.Text = "Tel";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(85, 191);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 19);
            this.labelControl7.TabIndex = 161;
            this.labelControl7.Text = "Vöen";
            // 
            // txtActualAddress
            // 
            this.txtActualAddress.Location = new System.Drawing.Point(540, 136);
            this.txtActualAddress.Name = "txtActualAddress";
            this.txtActualAddress.Size = new System.Drawing.Size(281, 20);
            this.txtActualAddress.TabIndex = 152;
            // 
            // txtVoen
            // 
            this.txtVoen.Location = new System.Drawing.Point(127, 189);
            this.txtVoen.Name = "txtVoen";
            this.txtVoen.Size = new System.Drawing.Size(283, 20);
            this.txtVoen.TabIndex = 147;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(439, 133);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(95, 19);
            this.labelControl11.TabIndex = 166;
            this.labelControl11.Text = "Faktiki Ünvan";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(413, 31);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(121, 19);
            this.labelControl6.TabIndex = 162;
            this.labelControl6.Text = "Əməliyyatçı Bank";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(540, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 20);
            this.txtEmail.TabIndex = 153;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(69, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 19);
            this.labelControl5.TabIndex = 163;
            this.labelControl5.Text = "Valyuta";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(433, 108);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(101, 19);
            this.labelControl13.TabIndex = 164;
            this.labelControl13.Text = "Hüquqi Ünvan";
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colRegionType});
            this.treeListLookUpEdit1TreeList.DataSource = this.vwRegionBindingSource;
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(71, 224);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 77;
            // 
            // colRegionType
            // 
            this.colRegionType.FieldName = "RegionType";
            this.colRegionType.Name = "colRegionType";
            this.colRegionType.Visible = true;
            this.colRegionType.VisibleIndex = 1;
            this.colRegionType.Width = 77;
            // 
            // vwRegionBindingSource
            // 
            this.vwRegionBindingSource.DataMember = "VwRegion";
            this.vwRegionBindingSource.DataSource = this.dataSet;
            // 
            // treeListLookUpEditRegion
            // 
            this.treeListLookUpEditRegion.EditValue = "[Seçim Edilməyib]";
            this.treeListLookUpEditRegion.Location = new System.Drawing.Point(540, 84);
            this.treeListLookUpEditRegion.Name = "treeListLookUpEditRegion";
            this.treeListLookUpEditRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.treeListLookUpEditRegion.Properties.DataSource = this.vwRegionBindingSource;
            this.treeListLookUpEditRegion.Properties.DisplayMember = "Name";
            this.treeListLookUpEditRegion.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.treeListLookUpEditRegion.Properties.ValueMember = "Id";
            this.treeListLookUpEditRegion.Size = new System.Drawing.Size(281, 20);
            this.treeListLookUpEditRegion.TabIndex = 172;
            this.treeListLookUpEditRegion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.treeListLookUpEditRegion_ButtonClick);
            // 
            // erpLookUpEditWorkType
            // 
            this.erpLookUpEditWorkType.Location = new System.Drawing.Point(127, 163);
            this.erpLookUpEditWorkType.Name = "erpLookUpEditWorkType";
            this.erpLookUpEditWorkType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditWorkType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Fəaliyyət Növü", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditWorkType.Properties.DataSource = this.vwWorkTypeBindingSource;
            this.erpLookUpEditWorkType.Properties.DisplayMember = "Name";
            this.erpLookUpEditWorkType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditWorkType.Properties.ValueMember = "Id";
            this.erpLookUpEditWorkType.Size = new System.Drawing.Size(283, 20);
            this.erpLookUpEditWorkType.TabIndex = 173;
            this.erpLookUpEditWorkType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditWorkType_ButtonClick);
            // 
            // vwWorkTypeBindingSource
            // 
            this.vwWorkTypeBindingSource.DataMember = "VwWorkType";
            this.vwWorkTypeBindingSource.DataSource = this.dataSet;
            // 
            // erpLookUpEditCurrency
            // 
            this.erpLookUpEditCurrency.Location = new System.Drawing.Point(127, 216);
            this.erpLookUpEditCurrency.Name = "erpLookUpEditCurrency";
            this.erpLookUpEditCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Buy", "Alış", 150, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sell", "Satış", 150, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefreshDate", "Yenilənmə Tarixi", 200, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCurrency.Properties.DataSource = this.vwCurrencyBindingSource;
            this.erpLookUpEditCurrency.Properties.DisplayMember = "Name";
            this.erpLookUpEditCurrency.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCurrency.Properties.ValueMember = "Id";
            this.erpLookUpEditCurrency.Size = new System.Drawing.Size(283, 20);
            this.erpLookUpEditCurrency.TabIndex = 174;
            this.erpLookUpEditCurrency.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCurrency_ButtonClick);
            // 
            // erpLookUpEditBank
            // 
            this.erpLookUpEditBank.Location = new System.Drawing.Point(540, 32);
            this.erpLookUpEditBank.Name = "erpLookUpEditBank";
            this.erpLookUpEditBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditBank.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Swift", "Swift", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditBank.Properties.DataSource = this.vwBankBindingSource;
            this.erpLookUpEditBank.Properties.DisplayMember = "Name";
            this.erpLookUpEditBank.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditBank.Properties.ValueMember = "Id";
            this.erpLookUpEditBank.Size = new System.Drawing.Size(281, 20);
            this.erpLookUpEditBank.TabIndex = 175;
            this.erpLookUpEditBank.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditBank_ButtonClick);
            this.erpLookUpEditBank.EditValueChanged += new System.EventHandler(this.erpLookUpEditBank_EditValueChanged);
            // 
            // vwBankBindingSource
            // 
            this.vwBankBindingSource.DataMember = "VwBank";
            this.vwBankBindingSource.DataSource = this.dataSet;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(495, 162);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(39, 19);
            this.labelControl15.TabIndex = 176;
            this.labelControl15.Text = "Email";
            // 
            // vwContractTableAdapter
            // 
            this.vwContractTableAdapter.ClearBeforeFill = true;
            // 
            // erpMemoExEditDescription
            // 
            this.erpMemoExEditDescription.EditValue = "";
            this.erpMemoExEditDescription.Location = new System.Drawing.Point(127, 241);
            this.erpMemoExEditDescription.Name = "erpMemoExEditDescription";
            this.erpMemoExEditDescription.Properties.AutoHeight = false;
            this.erpMemoExEditDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpMemoExEditDescription.Size = new System.Drawing.Size(281, 30);
            this.erpMemoExEditDescription.TabIndex = 177;
            // 
            // vwWorkTypeTableAdapter
            // 
            this.vwWorkTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwCurrencyTableAdapter
            // 
            this.vwCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // vwBankTableAdapter
            // 
            this.vwBankTableAdapter.ClearBeforeFill = true;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // operationTypeTableAdapter
            // 
            this.operationTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwContractTypeTableAdapter
            // 
            this.vwContractTypeTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDeleteContracts);
            this.groupControl2.Controls.Add(this.btnApplyContracts);
            this.groupControl2.Controls.Add(this.btnAddContracts);
            this.groupControl2.Location = new System.Drawing.Point(844, 107);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(262, 58);
            this.groupControl2.TabIndex = 178;
            this.groupControl2.Text = "Müqavilələr";
            this.groupControl2.Visible = false;
            // 
            // btnDeleteContracts
            // 
            this.btnDeleteContracts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteContracts.ImageOptions.Image")));
            this.btnDeleteContracts.Location = new System.Drawing.Point(177, 20);
            this.btnDeleteContracts.Name = "btnDeleteContracts";
            this.btnDeleteContracts.Size = new System.Drawing.Size(78, 29);
            this.btnDeleteContracts.TabIndex = 2;
            this.btnDeleteContracts.Text = "Sil";
            this.btnDeleteContracts.Click += new System.EventHandler(this.btnDeleteContracts_Click);
            // 
            // btnApplyContracts
            // 
            this.btnApplyContracts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyContracts.ImageOptions.Image")));
            this.btnApplyContracts.Location = new System.Drawing.Point(93, 20);
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
            // erpLookUpEditCompanyType
            // 
            this.erpLookUpEditCompanyType.Location = new System.Drawing.Point(127, 137);
            this.erpLookUpEditCompanyType.Name = "erpLookUpEditCompanyType";
            this.erpLookUpEditCompanyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpLookUpEditCompanyType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCompanyType.Properties.DataSource = this.companyTypeBindingSource;
            this.erpLookUpEditCompanyType.Properties.DisplayMember = "Name";
            this.erpLookUpEditCompanyType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCompanyType.Properties.ValueMember = "Id";
            this.erpLookUpEditCompanyType.Size = new System.Drawing.Size(283, 20);
            this.erpLookUpEditCompanyType.TabIndex = 175;
            // 
            // companyTypeBindingSource
            // 
            this.companyTypeBindingSource.DataMember = "CompanyType";
            this.companyTypeBindingSource.DataSource = this.dataSet;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(18, 135);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(104, 19);
            this.labelControl12.TabIndex = 174;
            this.labelControl12.Text = "Muessise Növü";
            // 
            // companyTypeTableAdapter
            // 
            this.companyTypeTableAdapter.ClearBeforeFill = true;
            // 
            // lookUpParentCustomer
            // 
            this.lookUpParentCustomer.Location = new System.Drawing.Point(127, 58);
            this.lookUpParentCustomer.Name = "lookUpParentCustomer";
            this.lookUpParentCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lookUpParentCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Type Name", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpParentCustomer.Properties.DataSource = this.vwCustomerBindingSource;
            this.lookUpParentCustomer.Properties.DisplayMember = "CustomerName";
            this.lookUpParentCustomer.Properties.NullText = "[Seçim Edilməyib]";
            this.lookUpParentCustomer.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.lookUpParentCustomer.Properties.ValueMember = "Id";
            this.lookUpParentCustomer.Size = new System.Drawing.Size(283, 20);
            this.lookUpParentCustomer.TabIndex = 180;
            // 
            // vwCustomerBindingSource
            // 
            this.vwCustomerBindingSource.DataMember = "VwCustomer";
            this.vwCustomerBindingSource.DataSource = this.dataSet;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(22, 56);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(100, 19);
            this.labelControl17.TabIndex = 179;
            this.labelControl17.Text = "Əsas Müəssisə";
            // 
            // vwCustomerTableAdapter
            // 
            this.vwCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // vwRegionTableAdapter
            // 
            this.vwRegionTableAdapter.ClearBeforeFill = true;
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
            this.btnAceptCustomer,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAceptCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Müqavilə Əlavə Et";
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
            this.barButtonItem2.Caption = "Müqavilə Sil";
            this.barButtonItem2.Hint = "    ";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnAceptCustomer
            // 
            this.btnAceptCustomer.Caption = "Təsdiqlə";
            this.btnAceptCustomer.Hint = "   ";
            this.btnAceptCustomer.Id = 2;
            this.btnAceptCustomer.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnAceptCustomer.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter));
            this.btnAceptCustomer.Name = "btnAceptCustomer";
            this.btnAceptCustomer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAceptCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAceptCustomer_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "İmtina Et";
            this.btnClose.Hint = "   ";
            this.btnClose.Id = 3;
            this.btnClose.ImageOptions.ImageUri.Uri = "Delete;Size16x16;GrayScaled";
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
            this.barDockControlTop.Size = new System.Drawing.Size(840, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(840, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 582);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(840, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 582);
            // 
            // CustomerContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 606);
            this.Controls.Add(this.lookUpParentCustomer);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.erpLookUpEditCompanyType);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.erpMemoExEditDescription);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.erpLookUpEditBank);
            this.Controls.Add(this.erpLookUpEditCurrency);
            this.Controls.Add(this.erpLookUpEditWorkType);
            this.Controls.Add(this.treeListLookUpEditRegion);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.txtLegalAddress);
            this.Controls.Add(this.dateEditDesc);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtBankSwift);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCustomerLeader);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtActualAddress);
            this.Controls.Add(this.txtVoen);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(856, 645);
            this.Name = "CustomerContractForm";
            this.Text = "Digər müəssisəSlər və Müqavilələr";
            this.Load += new System.EventHandler(this.CustomerContractForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.labelControl13, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl11, 0);
            this.Controls.SetChildIndex(this.txtVoen, 0);
            this.Controls.SetChildIndex(this.txtActualAddress, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.labelControl10, 0);
            this.Controls.SetChildIndex(this.txtCustomerLeader, 0);
            this.Controls.SetChildIndex(this.txtTel, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtBankSwift, 0);
            this.Controls.SetChildIndex(this.txtCustomerName, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtNumber, 0);
            this.Controls.SetChildIndex(this.labelControl16, 0);
            this.Controls.SetChildIndex(this.dateEditDesc, 0);
            this.Controls.SetChildIndex(this.txtLegalAddress, 0);
            this.Controls.SetChildIndex(this.labelControl14, 0);
            this.Controls.SetChildIndex(this.treeListLookUpEditRegion, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditWorkType, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCurrency, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditBank, 0);
            this.Controls.SetChildIndex(this.labelControl15, 0);
            this.Controls.SetChildIndex(this.erpMemoExEditDescription, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.labelControl12, 0);
            this.Controls.SetChildIndex(this.erpLookUpEditCompanyType, 0);
            this.Controls.SetChildIndex(this.labelControl17, 0);
            this.Controls.SetChildIndex(this.lookUpParentCustomer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoContractType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwContractTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoOperationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLegalAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankSwift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerLeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActualAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditWorkType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwWorkTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMemoExEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompanyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpParentCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlContract;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContract;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtLegalAddress;
        private DevExpress.XtraEditors.DateEdit dateEditDesc;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtBankSwift;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.TextEdit txtCustomerLeader;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtActualAddress;
        private DevExpress.XtraEditors.TextEdit txtVoen;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEditRegion;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditWorkType;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCurrency;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditBank;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwContractBindingSource;
        private Data.AccountingDataSetTableAdapters.VwContractTableAdapter vwContractTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colContractDate;
        private DevExpress.XtraGrid.Columns.GridColumn colContractTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colOperationTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Business.Infrastructure.UI.erpMemoExEdit erpMemoExEditDescription;
        private System.Windows.Forms.BindingSource vwWorkTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwWorkTypeTableAdapter vwWorkTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwCurrencyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter vwCurrencyTableAdapter;
        private System.Windows.Forms.BindingSource vwBankBindingSource;
        private Data.AccountingDataSetTableAdapters.VwBankTableAdapter vwBankTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoCompany;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoContractType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoOperationType;
        private System.Windows.Forms.BindingSource operationTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.OperationTypeTableAdapter operationTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwContractTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwContractTypeTableAdapter vwContractTypeTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRegionType;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnDeleteContracts;
        private DevExpress.XtraEditors.SimpleButton btnApplyContracts;
        private DevExpress.XtraEditors.SimpleButton btnAddContracts;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompanyType;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.BindingSource companyTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.CompanyTypeTableAdapter companyTypeTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lookUpParentCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.BindingSource vwCustomerBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter vwCustomerTableAdapter;
        private System.Windows.Forms.BindingSource vwRegionBindingSource;
        private Data.AccountingDataSetTableAdapters.VwRegionTableAdapter vwRegionTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAceptCustomer;
        private DevExpress.XtraBars.BarButtonItem btnClose;
    }
}