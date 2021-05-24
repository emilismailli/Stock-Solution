namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class CostReportManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCost = new DevExpress.XtraGrid.GridControl();
            this.vwCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewCost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDeficitGoodStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDeficitGoodStockTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDeficitGoodStockTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintCost = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.vwCostTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDeficitGoodStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCost);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 68);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(903, 393);
            this.groupControl1.TabIndex = 4;
            // 
            // gridControlCost
            // 
            this.gridControlCost.DataSource = this.vwCostBindingSource;
            this.gridControlCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCost.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gridControlCost.Location = new System.Drawing.Point(2, 21);
            this.gridControlCost.MainView = this.gridViewCost;
            this.gridControlCost.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gridControlCost.MenuManager = this.barManager;
            this.gridControlCost.Name = "gridControlCost";
            this.gridControlCost.Size = new System.Drawing.Size(899, 370);
            this.gridControlCost.TabIndex = 0;
            this.gridControlCost.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCost});
            // 
            // vwCostBindingSource
            // 
            this.vwCostBindingSource.DataMember = "VwCost";
            this.vwCostBindingSource.DataSource = this.dataSetBindingSource;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewCost
            // 
            this.gridViewCost.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPerson,
            this.colPlace,
            this.colAmount,
            this.colCostDate,
            this.colPaymentTypeName,
            this.colDescription});
            this.gridViewCost.GridControl = this.gridControlCost;
            this.gridViewCost.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkib atın..";
            this.gridViewCost.Name = "gridViewCost";
            this.gridViewCost.OptionsBehavior.ReadOnly = true;
            this.gridViewCost.OptionsSelection.MultiSelect = true;
            this.gridViewCost.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewCost.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCost.OptionsView.ShowFooter = true;
            this.gridViewCost.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewStock_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colPerson
            // 
            this.colPerson.Caption = "Ödəyən Şəxs";
            this.colPerson.FieldName = "Person";
            this.colPerson.Name = "colPerson";
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 2;
            // 
            // colPlace
            // 
            this.colPlace.Caption = "Ödənilən";
            this.colPlace.FieldName = "Place";
            this.colPlace.Name = "colPlace";
            this.colPlace.Visible = true;
            this.colPlace.VisibleIndex = 3;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Məbləğ";
            this.colAmount.DisplayFormat.FormatString = "{0:0.##}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.FieldName = "Amount";
            this.colAmount.GroupFormat.FormatString = "{0:0.##}";
            this.colAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Yekun={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            // 
            // colCostDate
            // 
            this.colCostDate.Caption = "Tarix";
            this.colCostDate.FieldName = "CostDate";
            this.colCostDate.Name = "colCostDate";
            this.colCostDate.Visible = true;
            this.colCostDate.VisibleIndex = 5;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.Caption = "Ödəniş Növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 6;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            // 
            // vwDeficitGoodStockBindingSource
            // 
            this.vwDeficitGoodStockBindingSource.DataMember = "VwDeficitGoodStock";
            this.vwDeficitGoodStockBindingSource.DataSource = this.dataSet;
            // 
            // vwDeficitGoodStockTableAdapter
            // 
            this.vwDeficitGoodStockTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnPrintCost});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintCost)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnPrintCost
            // 
            this.btnPrintCost.Caption = "Çap Et";
            this.btnPrintCost.Hint = "   ";
            this.btnPrintCost.Id = 1;
            this.btnPrintCost.ImageOptions.ImageUri.Uri = "Print;Size16x16;GrayScaled";
            this.btnPrintCost.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnPrintCost.Name = "btnPrintCost";
            this.btnPrintCost.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrintCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintCost_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl1.Size = new System.Drawing.Size(903, 26);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 461);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl2.Size = new System.Drawing.Size(903, 21);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 26);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl3.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(903, 26);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.barDockControl4.Size = new System.Drawing.Size(0, 435);
            // 
            // vwCostTableAdapter
            // 
            this.vwCostTableAdapter.ClearBeforeFill = true;
            // 
            // CostReportManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(32, 26, 32, 26);
            this.Name = "CostReportManager";
            this.Size = new System.Drawing.Size(903, 482);
            this.Controls.SetChildIndex(this.barDockControl1, 0);
            this.Controls.SetChildIndex(this.barDockControl2, 0);
            this.Controls.SetChildIndex(this.barDockControl4, 0);
            this.Controls.SetChildIndex(this.barDockControl3, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDeficitGoodStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlCost;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCost;
        private System.Windows.Forms.BindingSource vwDeficitGoodStockBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwDeficitGoodStockTableAdapter vwDeficitGoodStockTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.BindingSource vwCostBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCostDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.VwCostTableAdapter vwCostTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnPrintCost;
    }
}
