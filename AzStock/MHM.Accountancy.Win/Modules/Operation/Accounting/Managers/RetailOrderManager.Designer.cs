namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class RetailOrderManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailOrderManager));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwPaymentRetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeficit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwPaymentRetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentRetailTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl10 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl11 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl12 = new DevExpress.XtraBars.BarDockControl();
            this.barManager4 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl13 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl14 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl15 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl16 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentRetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwPaymentRetailBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1355, 562);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwPaymentRetailBindingSource
            // 
            this.vwPaymentRetailBindingSource.DataMember = "VwPaymentRetail";
            this.vwPaymentRetailBindingSource.DataSource = this.accountingDataSetBindingSource;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocumentId,
            this.colCreateId,
            this.colCreateDate,
            this.colCustomerName,
            this.colDeficit,
            this.colPayment,
            this.colTotalSum,
            this.colPaymentTypeName,
            this.colPercent});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkib atın..";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colDocumentId
            // 
            this.colDocumentId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDocumentId.AppearanceCell.Options.UseFont = true;
            this.colDocumentId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDocumentId.AppearanceHeader.Options.UseFont = true;
            this.colDocumentId.Caption = "Satış Nömrəsi";
            this.colDocumentId.FieldName = "DocumentId";
            this.colDocumentId.Image = ((System.Drawing.Image)(resources.GetObject("colDocumentId.Image")));
            this.colDocumentId.Name = "colDocumentId";
            this.colDocumentId.Visible = true;
            this.colDocumentId.VisibleIndex = 1;
            // 
            // colCreateId
            // 
            this.colCreateId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateId.AppearanceCell.Options.UseFont = true;
            this.colCreateId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateId.AppearanceHeader.Options.UseFont = true;
            this.colCreateId.Caption = "Kassir Nömrəsi";
            this.colCreateId.FieldName = "CreateId";
            this.colCreateId.Image = ((System.Drawing.Image)(resources.GetObject("colCreateId.Image")));
            this.colCreateId.Name = "colCreateId";
            this.colCreateId.Visible = true;
            this.colCreateId.VisibleIndex = 2;
            // 
            // colCreateDate
            // 
            this.colCreateDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateDate.AppearanceCell.Options.UseFont = true;
            this.colCreateDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateDate.AppearanceHeader.Options.UseFont = true;
            this.colCreateDate.Caption = "Tarix";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Image = ((System.Drawing.Image)(resources.GetObject("colCreateDate.Image")));
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 3;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceHeader.Options.UseFont = true;
            this.colCustomerName.Caption = "Müştəri";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerName.Image")));
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 4;
            // 
            // colDeficit
            // 
            this.colDeficit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDeficit.AppearanceCell.Options.UseFont = true;
            this.colDeficit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDeficit.AppearanceHeader.Options.UseFont = true;
            this.colDeficit.Caption = "Qalıq";
            this.colDeficit.FieldName = "Deficit";
            this.colDeficit.Image = ((System.Drawing.Image)(resources.GetObject("colDeficit.Image")));
            this.colDeficit.Name = "colDeficit";
            this.colDeficit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Deficit", "Yekun={0:0.##}")});
            this.colDeficit.Visible = true;
            this.colDeficit.VisibleIndex = 5;
            // 
            // colPayment
            // 
            this.colPayment.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPayment.AppearanceCell.Options.UseFont = true;
            this.colPayment.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPayment.AppearanceHeader.Options.UseFont = true;
            this.colPayment.Caption = "Ödəniş";
            this.colPayment.FieldName = "Payment";
            this.colPayment.Image = ((System.Drawing.Image)(resources.GetObject("colPayment.Image")));
            this.colPayment.Name = "colPayment";
            this.colPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Payment", "Yekun={0:0.##}")});
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 6;
            // 
            // colTotalSum
            // 
            this.colTotalSum.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTotalSum.AppearanceCell.Options.UseFont = true;
            this.colTotalSum.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTotalSum.AppearanceHeader.Options.UseFont = true;
            this.colTotalSum.Caption = "Məbləğ";
            this.colTotalSum.FieldName = "TotalSum";
            this.colTotalSum.Image = ((System.Drawing.Image)(resources.GetObject("colTotalSum.Image")));
            this.colTotalSum.Name = "colTotalSum";
            this.colTotalSum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSum", "Yekun={0:0.##}")});
            this.colTotalSum.Visible = true;
            this.colTotalSum.VisibleIndex = 7;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceCell.Options.UseFont = true;
            this.colPaymentTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPaymentTypeName.Caption = "Ödəniş Növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentTypeName.Image")));
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 9;
            // 
            // colPercent
            // 
            this.colPercent.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPercent.AppearanceCell.Options.UseFont = true;
            this.colPercent.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPercent.AppearanceHeader.Options.UseFont = true;
            this.colPercent.Caption = "Endirim";
            this.colPercent.FieldName = "Percent";
            this.colPercent.Image = ((System.Drawing.Image)(resources.GetObject("colPercent.Image")));
            this.colPercent.Name = "colPercent";
            this.colPercent.Visible = true;
            this.colPercent.VisibleIndex = 8;
            // 
            // vwPaymentRetailTableAdapter
            // 
            this.vwPaymentRetailTableAdapter.ClearBeforeFill = true;
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
            this.barDockControl1.Size = new System.Drawing.Size(1355, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 626);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1355, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 602);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1355, 24);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 602);
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.DockControls.Add(this.barDockControl6);
            this.barManager2.DockControls.Add(this.barDockControl7);
            this.barManager2.DockControls.Add(this.barDockControl8);
            this.barManager2.Form = this;
            this.barManager2.MaxItemId = 0;
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 24);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Size = new System.Drawing.Size(1355, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 626);
            this.barDockControl6.Manager = this.barManager2;
            this.barDockControl6.Size = new System.Drawing.Size(1355, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 24);
            this.barDockControl7.Manager = this.barManager2;
            this.barDockControl7.Size = new System.Drawing.Size(0, 602);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1355, 24);
            this.barDockControl8.Manager = this.barManager2;
            this.barDockControl8.Size = new System.Drawing.Size(0, 602);
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager3.DockControls.Add(this.barDockControl9);
            this.barManager3.DockControls.Add(this.barDockControl10);
            this.barManager3.DockControls.Add(this.barDockControl11);
            this.barManager3.DockControls.Add(this.barDockControl12);
            this.barManager3.Form = this;
            this.barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPrinter});
            this.barManager3.MainMenu = this.bar6;
            this.barManager3.MaxItemId = 1;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrinter)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnPrinter
            // 
            this.btnPrinter.Caption = "Çap Et";
            this.btnPrinter.Hint = "      ";
            this.btnPrinter.Id = 0;
            this.btnPrinter.ImageOptions.ImageUri.Uri = "Print;Size16x16;GrayScaled";
            this.btnPrinter.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrinter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrinter_ItemClick);
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl9.Location = new System.Drawing.Point(0, 0);
            this.barDockControl9.Manager = this.barManager3;
            this.barDockControl9.Size = new System.Drawing.Size(1355, 24);
            // 
            // barDockControl10
            // 
            this.barDockControl10.CausesValidation = false;
            this.barDockControl10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl10.Location = new System.Drawing.Point(0, 626);
            this.barDockControl10.Manager = this.barManager3;
            this.barDockControl10.Size = new System.Drawing.Size(1355, 0);
            // 
            // barDockControl11
            // 
            this.barDockControl11.CausesValidation = false;
            this.barDockControl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl11.Location = new System.Drawing.Point(0, 24);
            this.barDockControl11.Manager = this.barManager3;
            this.barDockControl11.Size = new System.Drawing.Size(0, 602);
            // 
            // barDockControl12
            // 
            this.barDockControl12.CausesValidation = false;
            this.barDockControl12.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl12.Location = new System.Drawing.Point(1355, 24);
            this.barDockControl12.Manager = this.barManager3;
            this.barDockControl12.Size = new System.Drawing.Size(0, 602);
            // 
            // barManager4
            // 
            this.barManager4.DockControls.Add(this.barDockControl13);
            this.barManager4.DockControls.Add(this.barDockControl14);
            this.barManager4.DockControls.Add(this.barDockControl15);
            this.barManager4.DockControls.Add(this.barDockControl16);
            this.barManager4.Form = this;
            this.barManager4.MaxItemId = 0;
            // 
            // barDockControl13
            // 
            this.barDockControl13.CausesValidation = false;
            this.barDockControl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl13.Location = new System.Drawing.Point(0, 0);
            this.barDockControl13.Manager = this.barManager4;
            this.barDockControl13.Size = new System.Drawing.Size(1355, 0);
            // 
            // barDockControl14
            // 
            this.barDockControl14.CausesValidation = false;
            this.barDockControl14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl14.Location = new System.Drawing.Point(0, 626);
            this.barDockControl14.Manager = this.barManager4;
            this.barDockControl14.Size = new System.Drawing.Size(1355, 0);
            // 
            // barDockControl15
            // 
            this.barDockControl15.CausesValidation = false;
            this.barDockControl15.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl15.Location = new System.Drawing.Point(0, 0);
            this.barDockControl15.Manager = this.barManager4;
            this.barDockControl15.Size = new System.Drawing.Size(0, 626);
            // 
            // barDockControl16
            // 
            this.barDockControl16.CausesValidation = false;
            this.barDockControl16.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl16.Location = new System.Drawing.Point(1355, 0);
            this.barDockControl16.Manager = this.barManager4;
            this.barDockControl16.Size = new System.Drawing.Size(0, 626);
            // 
            // RetailOrderManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControl11);
            this.Controls.Add(this.barDockControl12);
            this.Controls.Add(this.barDockControl10);
            this.Controls.Add(this.barDockControl9);
            this.Controls.Add(this.barDockControl15);
            this.Controls.Add(this.barDockControl16);
            this.Controls.Add(this.barDockControl14);
            this.Controls.Add(this.barDockControl13);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RetailOrderManager";
            this.Size = new System.Drawing.Size(1355, 626);
            this.Controls.SetChildIndex(this.barDockControl13, 0);
            this.Controls.SetChildIndex(this.barDockControl14, 0);
            this.Controls.SetChildIndex(this.barDockControl16, 0);
            this.Controls.SetChildIndex(this.barDockControl15, 0);
            this.Controls.SetChildIndex(this.barDockControl9, 0);
            this.Controls.SetChildIndex(this.barDockControl10, 0);
            this.Controls.SetChildIndex(this.barDockControl12, 0);
            this.Controls.SetChildIndex(this.barDockControl11, 0);
            this.Controls.SetChildIndex(this.barDockControl5, 0);
            this.Controls.SetChildIndex(this.barDockControl6, 0);
            this.Controls.SetChildIndex(this.barDockControl8, 0);
            this.Controls.SetChildIndex(this.barDockControl7, 0);
            this.Controls.SetChildIndex(this.barDockControl1, 0);
            this.Controls.SetChildIndex(this.barDockControl2, 0);
            this.Controls.SetChildIndex(this.barDockControl4, 0);
            this.Controls.SetChildIndex(this.barDockControl3, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentRetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource vwPaymentRetailBindingSource;
        private System.Windows.Forms.BindingSource accountingDataSetBindingSource;
        private Data.AccountingDataSet accountingDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colDeficit;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSum;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private Data.AccountingDataSetTableAdapters.VwPaymentRetailTableAdapter vwPaymentRetailTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colPercent;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarDockControl barDockControl11;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
        private DevExpress.XtraBars.BarDockControl barDockControl10;
        private DevExpress.XtraBars.BarDockControl barDockControl12;
        private DevExpress.XtraBars.BarDockControl barDockControl15;
        private DevExpress.XtraBars.BarManager barManager4;
        private DevExpress.XtraBars.BarDockControl barDockControl13;
        private DevExpress.XtraBars.BarDockControl barDockControl14;
        private DevExpress.XtraBars.BarDockControl barDockControl16;
    }
}