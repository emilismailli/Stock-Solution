namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class TransferMoneyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferMoneyForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.vwCashBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet1 = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwCashMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDebtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPayment = new DevExpress.XtraEditors.TextEdit();
            this.erpLookUpEditCompany = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.vwAccountDebtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditPaymentType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.vwPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAccountTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountTableAdapter();
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            this.vwCustomerTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.erpDateEdit1 = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAcceptOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpense = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.erpLookUpEditFromCash = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.spCashFromMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.erpTreeListLookUpEditExpense = new MHM.Accountancy.Business.Infrastructure.UI.erpTreeListLookUpEdit();
            this.vwExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colExpenseName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.erpLookUpEditToCash = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.spCashToMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.vwCashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAccountDebtTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountDebtTableAdapter();
            this.vwCashTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCashTableAdapter();
            this.vwExpenseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwExpenseTableAdapter();
            this.vwCashMoneyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCashMoneyTableAdapter();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            this.spCashFromMoneyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spCashFromMoneyTableAdapter();
            this.spCashToMoneyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spCashToMoneyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDebtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountDebtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditFromCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCashFromMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditExpense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditToCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCashToMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(568, 526);
            this.btnAccept.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(662, 526);
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 479);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(380, 526);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(293, 526);
            this.btnPrintDocument.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl2);
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 267);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.vwCashBindingSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 17);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(750, 247);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // vwCashBindingSource1
            // 
            this.vwCashBindingSource1.DataMember = "VwCash";
            this.vwCashBindingSource1.DataSource = this.accountingDataSet1;
            // 
            // accountingDataSet1
            // 
            this.accountingDataSet1.DataSetName = "AccountingDataSet";
            this.accountingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.colCashName,
            this.colBalance});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridView2.OptionsFind.ShowCloseButton = false;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 0;
            // 
            // colCashName
            // 
            this.colCashName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashName.AppearanceCell.Options.UseFont = true;
            this.colCashName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashName.AppearanceHeader.Options.UseFont = true;
            this.colCashName.Caption = "Kassa";
            this.colCashName.FieldName = "CashName";
            this.colCashName.Name = "colCashName";
            this.colCashName.Visible = true;
            this.colCashName.VisibleIndex = 1;
            // 
            // colBalance
            // 
            this.colBalance.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBalance.AppearanceCell.Options.UseFont = true;
            this.colBalance.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBalance.AppearanceHeader.Options.UseFont = true;
            this.colBalance.Caption = "Qalıq Məbləğ";
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 2;
            // 
            // vwCashMoneyBindingSource
            // 
            this.vwCashMoneyBindingSource.DataMember = "VwCashMoney";
            this.vwCashMoneyBindingSource.DataSource = this.accountingDataSet;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCustomerBindingSource
            // 
            this.vwCustomerBindingSource.DataMember = "VwCustomer";
            this.vwCustomerBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // accountingDataSetBindingSource
            // 
            this.accountingDataSetBindingSource.DataSource = this.accountingDataSet;
            this.accountingDataSetBindingSource.Position = 0;
            // 
            // spDebtBindingSource
            // 
            this.spDebtBindingSource.DataMember = "spDebt";
            this.spDebtBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(515, 87);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPayment.Properties.Appearance.Options.UseFont = true;
            this.txtPayment.Properties.Mask.EditMask = "f";
            this.txtPayment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPayment.Size = new System.Drawing.Size(235, 30);
            this.txtPayment.TabIndex = 6;
            // 
            // erpLookUpEditCompany
            // 
            this.erpLookUpEditCompany.Location = new System.Drawing.Point(140, 20);
            this.erpLookUpEditCompany.Name = "erpLookUpEditCompany";
            this.erpLookUpEditCompany.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditCompany.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Ad", 143, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditCompany.Properties.DataSource = this.vwCompanyBindingSource;
            this.erpLookUpEditCompany.Properties.DisplayMember = "CompanyName";
            this.erpLookUpEditCompany.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditCompany.Properties.ValueMember = "Id";
            this.erpLookUpEditCompany.Size = new System.Drawing.Size(238, 30);
            this.erpLookUpEditCompany.TabIndex = 1;
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.accountingDataSet;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(384, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 24);
            this.labelControl2.TabIndex = 89;
            this.labelControl2.Text = "Ödəniş Miqdari";
            // 
            // vwAccountDebtBindingSource
            // 
            this.vwAccountDebtBindingSource.DataMember = "VwAccountDebt";
            this.vwAccountDebtBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwAccountBindingSource
            // 
            this.vwAccountBindingSource.DataMember = "VwAccount";
            this.vwAccountBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(401, 57);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(111, 24);
            this.labelControl10.TabIndex = 86;
            this.labelControl10.Text = "Ödəniş Növü";
            // 
            // erpLookUpEditPaymentType
            // 
            this.erpLookUpEditPaymentType.Location = new System.Drawing.Point(515, 54);
            this.erpLookUpEditPaymentType.Name = "erpLookUpEditPaymentType";
            this.erpLookUpEditPaymentType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditPaymentType.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditPaymentType.Properties.DataSource = this.vwPaymentTypeBindingSource;
            this.erpLookUpEditPaymentType.Properties.DisplayMember = "Name";
            this.erpLookUpEditPaymentType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditPaymentType.Properties.ValueMember = "Id";
            this.erpLookUpEditPaymentType.Size = new System.Drawing.Size(235, 30);
            this.erpLookUpEditPaymentType.TabIndex = 5;
            // 
            // vwPaymentTypeBindingSource
            // 
            this.vwPaymentTypeBindingSource.DataMember = "VwPaymentType";
            this.vwPaymentTypeBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(55, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 22);
            this.labelControl3.TabIndex = 84;
            this.labelControl3.Text = "Müəssisə";
            // 
            // vwPaymentBindingSource
            // 
            this.vwPaymentBindingSource.DataMember = "VwPayment";
            this.vwPaymentBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // vwAccountTableAdapter
            // 
            this.vwAccountTableAdapter.ClearBeforeFill = true;
            // 
            // vwPaymentTypeTableAdapter
            // 
            this.vwPaymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // vwCustomerTableAdapter
            // 
            this.vwCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.erpDateEdit1);
            this.groupBox2.Controls.Add(this.erpLookUpEditFromCash);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.erpTreeListLookUpEditExpense);
            this.groupBox2.Controls.Add(this.erpLookUpEditToCash);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl11);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtPayment);
            this.groupBox2.Controls.Add(this.erpLookUpEditPaymentType);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl10);
            this.groupBox2.Controls.Add(this.erpLookUpEditCompany);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 179);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(85, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 22);
            this.labelControl4.TabIndex = 103;
            this.labelControl4.Text = "Tarix";
            // 
            // erpDateEdit1
            // 
            this.erpDateEdit1.EditValue = null;
            this.erpDateEdit1.Location = new System.Drawing.Point(140, 123);
            this.erpDateEdit1.MenuManager = this.barManager1;
            this.erpDateEdit1.Name = "erpDateEdit1";
            this.erpDateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpDateEdit1.Properties.Appearance.Options.UseFont = true;
            this.erpDateEdit1.Properties.AutoHeight = false;
            this.erpDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.erpDateEdit1.Properties.NullText = "[Seçim edilməyib]";
            this.erpDateEdit1.Size = new System.Drawing.Size(238, 32);
            this.erpDateEdit1.TabIndex = 102;
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
            this.btnAcceptOrder,
            this.btnClose,
            this.BtnSearch,
            this.btnExpense,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(172, 151);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAcceptOrder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExpense),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAcceptOrder
            // 
            this.btnAcceptOrder.Caption = "Təsqidlə";
            this.btnAcceptOrder.Hint = "   ";
            this.btnAcceptOrder.Id = 0;
            this.btnAcceptOrder.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnAcceptOrder.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter));
            this.btnAcceptOrder.Name = "btnAcceptOrder";
            this.btnAcceptOrder.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAcceptOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAcceptOrder_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "İmtina Et";
            this.btnClose.Hint = "   ";
            this.btnClose.Id = 1;
            this.btnClose.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // btnExpense
            // 
            this.btnExpense.Caption = "Təyinat";
            this.btnExpense.Hint = "  ";
            this.btnExpense.Id = 3;
            this.btnExpense.ImageOptions.ImageUri.Uri = "Zoom2;Size16x16;GrayScaled";
            this.btnExpense.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T));
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExpense.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpense_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xəzinələr";
            this.barButtonItem1.Hint = "  ";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "AlignVerticalLeft;Size16x16;GrayScaled";
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(766, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 511);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(766, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 487);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(766, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 487);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Caption = "Axtar";
            this.BtnSearch.Hint = "    ";
            this.BtnSearch.Id = 2;
            this.BtnSearch.ImageOptions.ImageUri.Uri = "Zoom;Size16x16;GrayScaled";
            this.BtnSearch.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H));
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // erpLookUpEditFromCash
            // 
            this.erpLookUpEditFromCash.Location = new System.Drawing.Point(140, 54);
            this.erpLookUpEditFromCash.Name = "erpLookUpEditFromCash";
            this.erpLookUpEditFromCash.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditFromCash.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditFromCash.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditFromCash.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CashName", "Kassa", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditFromCash.Properties.DataSource = this.spCashFromMoneyBindingSource;
            this.erpLookUpEditFromCash.Properties.DisplayMember = "CashName";
            this.erpLookUpEditFromCash.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditFromCash.Properties.ValueMember = "Id";
            this.erpLookUpEditFromCash.Size = new System.Drawing.Size(238, 30);
            this.erpLookUpEditFromCash.TabIndex = 2;
            this.erpLookUpEditFromCash.EditValueChanged += new System.EventHandler(this.erpLookUpEditFromCash_EditValueChanged);
            // 
            // spCashFromMoneyBindingSource
            // 
            this.spCashFromMoneyBindingSource.DataMember = "spCashFromMoney";
            this.spCashFromMoneyBindingSource.DataSource = this.accountingDataSet;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 16);
            this.labelControl1.TabIndex = 101;
            this.labelControl1.Text = "Göndərən Xəzinə";
            // 
            // erpTreeListLookUpEditExpense
            // 
            this.erpTreeListLookUpEditExpense.Location = new System.Drawing.Point(517, 20);
            this.erpTreeListLookUpEditExpense.MenuManager = this.barManager1;
            this.erpTreeListLookUpEditExpense.Name = "erpTreeListLookUpEditExpense";
            this.erpTreeListLookUpEditExpense.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpTreeListLookUpEditExpense.Properties.Appearance.Options.UseFont = true;
            this.erpTreeListLookUpEditExpense.Properties.AutoHeight = false;
            this.erpTreeListLookUpEditExpense.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpTreeListLookUpEditExpense.Properties.DataSource = this.vwExpenseBindingSource;
            this.erpTreeListLookUpEditExpense.Properties.DisplayMember = "ExpenseName";
            this.erpTreeListLookUpEditExpense.Properties.NullText = "[Seçim edilməyib]";
            this.erpTreeListLookUpEditExpense.Properties.TreeList = this.erpTreeListLookUpEdit1TreeList;
            this.erpTreeListLookUpEditExpense.Properties.ValueMember = "Id";
            this.erpTreeListLookUpEditExpense.Size = new System.Drawing.Size(233, 30);
            this.erpTreeListLookUpEditExpense.TabIndex = 4;
            // 
            // vwExpenseBindingSource
            // 
            this.vwExpenseBindingSource.DataMember = "VwExpense";
            this.vwExpenseBindingSource.DataSource = this.accountingDataSet;
            // 
            // erpTreeListLookUpEdit1TreeList
            // 
            this.erpTreeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colExpenseName,
            this.colCode,
            this.colDescription});
            this.erpTreeListLookUpEdit1TreeList.DataSource = this.vwExpenseBindingSource;
            this.erpTreeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.erpTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.erpTreeListLookUpEdit1TreeList.Name = "erpTreeListLookUpEdit1TreeList";
            this.erpTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.erpTreeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.erpTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.erpTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colExpenseName
            // 
            this.colExpenseName.Caption = "Ad";
            this.colExpenseName.FieldName = "ExpenseName";
            this.colExpenseName.MinWidth = 60;
            this.colExpenseName.Name = "colExpenseName";
            this.colExpenseName.Visible = true;
            this.colExpenseName.VisibleIndex = 0;
            this.colExpenseName.Width = 100;
            // 
            // colCode
            // 
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 40;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 77;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 50;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 100;
            // 
            // erpLookUpEditToCash
            // 
            this.erpLookUpEditToCash.Location = new System.Drawing.Point(140, 87);
            this.erpLookUpEditToCash.Name = "erpLookUpEditToCash";
            this.erpLookUpEditToCash.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditToCash.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditToCash.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditToCash.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CashName", "Kassa", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditToCash.Properties.DataSource = this.spCashToMoneyBindingSource;
            this.erpLookUpEditToCash.Properties.DisplayMember = "CashName";
            this.erpLookUpEditToCash.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditToCash.Properties.ValueMember = "Id";
            this.erpLookUpEditToCash.Size = new System.Drawing.Size(238, 30);
            this.erpLookUpEditToCash.TabIndex = 3;
            this.erpLookUpEditToCash.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditCash_ButtonClick);
            // 
            // spCashToMoneyBindingSource
            // 
            this.spCashToMoneyBindingSource.DataMember = "spCashToMoney";
            this.spCashToMoneyBindingSource.DataSource = this.accountingDataSet;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(4, 96);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(131, 16);
            this.labelControl6.TabIndex = 98;
            this.labelControl6.Text = "Qəbul Edən Xəzinə";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(450, 23);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 24);
            this.labelControl5.TabIndex = 96;
            this.labelControl5.Text = "Təyinat";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(469, 128);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(40, 22);
            this.labelControl11.TabIndex = 94;
            this.labelControl11.Text = "Qeyd";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(515, 123);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.AutoHeight = false;
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtDescription.Size = new System.Drawing.Size(235, 32);
            this.txtDescription.TabIndex = 7;
            // 
            // vwCashBindingSource
            // 
            this.vwCashBindingSource.DataMember = "VwCash";
            this.vwCashBindingSource.DataSource = this.accountingDataSet;
            // 
            // vwAccountDebtTableAdapter
            // 
            this.vwAccountDebtTableAdapter.ClearBeforeFill = true;
            // 
            // vwCashTableAdapter
            // 
            this.vwCashTableAdapter.ClearBeforeFill = true;
            // 
            // vwExpenseTableAdapter
            // 
            this.vwExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // vwCashMoneyTableAdapter
            // 
            this.vwCashMoneyTableAdapter.ClearBeforeFill = true;
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // spCashFromMoneyTableAdapter
            // 
            this.spCashFromMoneyTableAdapter.ClearBeforeFill = true;
            // 
            // spCashToMoneyTableAdapter
            // 
            this.spCashToMoneyTableAdapter.ClearBeforeFill = true;
            // 
            // TransferMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximumSize = new System.Drawing.Size(782, 550);
            this.MinimumSize = new System.Drawing.Size(782, 550);
            this.Name = "TransferMoneyForm";
            this.Text = "Kassa Köçürmələri";
            this.Load += new System.EventHandler(this.TransferMoneyForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDebtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountDebtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditFromCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCashFromMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditExpense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditToCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCashToMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource accountingDataSetBindingSource;
        private Data.AccountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource vwAccountBindingSource;
        private Data.AccountingDataSetTableAdapters.VwAccountTableAdapter vwAccountTableAdapter;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
        private System.Windows.Forms.BindingSource vwCustomerBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCustomerTableAdapter vwCustomerTableAdapter;
        private System.Windows.Forms.BindingSource vwPaymentBindingSource;
        private System.Windows.Forms.BindingSource spDebtBindingSource;
        //private Data.AccountingDataSetTableAdapters.spDebtTableAdapter spDebtTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtPayment;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditCompany;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPaymentType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource vwAccountDebtBindingSource;
        private Data.AccountingDataSetTableAdapters.VwAccountDebtTableAdapter vwAccountDebtTableAdapter;
        private Business.Infrastructure.UI.erpMemoExEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAcceptOrder;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem BtnSearch;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditToCash;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource vwCashBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCashTableAdapter vwCashTableAdapter;
        private System.Windows.Forms.BindingSource vwExpenseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwExpenseTableAdapter vwExpenseTableAdapter;
        private Business.Infrastructure.UI.erpTreeListLookUpEdit erpTreeListLookUpEditExpense;
        private DevExpress.XtraTreeList.TreeList erpTreeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colExpenseName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DevExpress.XtraBars.BarButtonItem btnExpense;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditFromCash;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource vwCashMoneyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCashMoneyTableAdapter vwCashMoneyTableAdapter;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private System.Windows.Forms.BindingSource spCashFromMoneyBindingSource;
        private Data.AccountingDataSetTableAdapters.spCashFromMoneyTableAdapter spCashFromMoneyTableAdapter;
        private System.Windows.Forms.BindingSource spCashToMoneyBindingSource;
        private Data.AccountingDataSetTableAdapters.spCashToMoneyTableAdapter spCashToMoneyTableAdapter;
        private Data.AccountingDataSet accountingDataSet1;
        private System.Windows.Forms.BindingSource vwCashBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCashName;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Business.Infrastructure.UI.erpDateEdit erpDateEdit1;
        //private Data.AccountingDataSetTableAdapters.VwAccountDebtTableAdapter vwAccountDebtTableAdapter;
    }
}