namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ReturnIncludeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnIncludeManager));
            this.gridControlIncludReturn = new DevExpress.XtraGrid.GridControl();
            this.spDocumentReturnIncludeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewIncludeReturn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentReturnIncludeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentReturnIncludeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentReturnIncludeTableAdapter();
            this.spDocumentReturnIncludeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spDocumentReturnIncludeTableAdapter();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIncludReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentReturnIncludeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncludeReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentReturnIncludeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlIncludReturn
            // 
            this.gridControlIncludReturn.DataSource = this.spDocumentReturnIncludeBindingSource;
            this.gridControlIncludReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIncludReturn.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlIncludReturn.Location = new System.Drawing.Point(0, 40);
            this.gridControlIncludReturn.MainView = this.gridViewIncludeReturn;
            this.gridControlIncludReturn.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlIncludReturn.MenuManager = this.barManager;
            this.gridControlIncludReturn.Name = "gridControlIncludReturn";
            this.gridControlIncludReturn.Size = new System.Drawing.Size(1194, 596);
            this.gridControlIncludReturn.TabIndex = 4;
            this.gridControlIncludReturn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIncludeReturn});
            this.gridControlIncludReturn.Click += new System.EventHandler(this.gridControlInclude_Click);
            // 
            // spDocumentReturnIncludeBindingSource
            // 
            this.spDocumentReturnIncludeBindingSource.DataMember = "spDocumentReturnInclude";
            this.spDocumentReturnIncludeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewIncludeReturn
            // 
            this.gridViewIncludeReturn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIncludeDate,
            this.colCompanyName,
            this.colWareHouseName,
            this.colPaymentTypeName,
            this.colCustomerName,
            this.colAmountBuy,
            this.colDescription});
            this.gridViewIncludeReturn.GridControl = this.gridControlIncludReturn;
            this.gridViewIncludeReturn.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewIncludeReturn.Name = "gridViewIncludeReturn";
            this.gridViewIncludeReturn.OptionsBehavior.ReadOnly = true;
            this.gridViewIncludeReturn.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewIncludeReturn.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridViewIncludeReturn.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridViewIncludeReturn.OptionsFind.AlwaysVisible = true;
            this.gridViewIncludeReturn.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewIncludeReturn.OptionsFind.ShowClearButton = false;
            this.gridViewIncludeReturn.OptionsFind.ShowCloseButton = false;
            this.gridViewIncludeReturn.OptionsFind.ShowFindButton = false;
            this.gridViewIncludeReturn.OptionsSelection.MultiSelect = true;
            this.gridViewIncludeReturn.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewIncludeReturn.OptionsView.ShowAutoFilterRow = true;
            this.gridViewIncludeReturn.OptionsView.ShowFooter = true;
            this.gridViewIncludeReturn.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewIncludeReturn_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "№";
            this.colId.DisplayFormat.FormatString = "{0:000000}";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.FieldName = "Id";
            this.colId.GroupFormat.FormatString = "{0:000000}";
            this.colId.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.Image = ((System.Drawing.Image)(resources.GetObject("colId.Image")));
            this.colId.MinWidth = 50;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 86;
            // 
            // colIncludeDate
            // 
            this.colIncludeDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colIncludeDate.AppearanceCell.Options.UseFont = true;
            this.colIncludeDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.colIncludeDate.AppearanceHeader.Options.UseFont = true;
            this.colIncludeDate.Caption = "Tarix";
            this.colIncludeDate.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colIncludeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.FieldName = "IncludeDate";
            this.colIncludeDate.GroupFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colIncludeDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeDate.Image")));
            this.colIncludeDate.MinWidth = 75;
            this.colIncludeDate.Name = "colIncludeDate";
            this.colIncludeDate.OptionsColumn.ReadOnly = true;
            this.colIncludeDate.Visible = true;
            this.colIncludeDate.VisibleIndex = 2;
            this.colIncludeDate.Width = 129;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Əməliyyatçı Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.ReadOnly = true;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            this.colCompanyName.Width = 204;
            // 
            // colWareHouseName
            // 
            this.colWareHouseName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colWareHouseName.AppearanceCell.Options.UseFont = true;
            this.colWareHouseName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.colWareHouseName.AppearanceHeader.Options.UseFont = true;
            this.colWareHouseName.Caption = "Anbar";
            this.colWareHouseName.FieldName = "WareHouseName";
            this.colWareHouseName.Image = ((System.Drawing.Image)(resources.GetObject("colWareHouseName.Image")));
            this.colWareHouseName.Name = "colWareHouseName";
            this.colWareHouseName.OptionsColumn.ReadOnly = true;
            this.colWareHouseName.Visible = true;
            this.colWareHouseName.VisibleIndex = 4;
            this.colWareHouseName.Width = 121;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colPaymentTypeName.AppearanceCell.Options.UseFont = true;
            this.colPaymentTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colPaymentTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPaymentTypeName.Caption = "Ödəniş Növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentTypeName.Image")));
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 6;
            this.colPaymentTypeName.Width = 103;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCustomerName.AppearanceHeader.Options.UseFont = true;
            this.colCustomerName.Caption = "Təchizatçı";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerName.Image")));
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
            this.colCustomerName.Width = 107;
            // 
            // colAmountBuy
            // 
            this.colAmountBuy.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.colAmountBuy.AppearanceCell.Options.UseFont = true;
            this.colAmountBuy.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.colAmountBuy.AppearanceHeader.Options.UseFont = true;
            this.colAmountBuy.Caption = "Məbləğ";
            this.colAmountBuy.DisplayFormat.FormatString = "{0:0.##}";
            this.colAmountBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.FieldName = "AmountBuy";
            this.colAmountBuy.GroupFormat.FormatString = "{0:0.##}";
            this.colAmountBuy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.Image = ((System.Drawing.Image)(resources.GetObject("colAmountBuy.Image")));
            this.colAmountBuy.Name = "colAmountBuy";
            this.colAmountBuy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountBuy", "Yekun={0:0.##}")});
            this.colAmountBuy.Visible = true;
            this.colAmountBuy.VisibleIndex = 7;
            this.colAmountBuy.Width = 89;
            // 
            // vwDocumentReturnIncludeBindingSource
            // 
            this.vwDocumentReturnIncludeBindingSource.DataMember = "VwDocumentReturnInclude";
            this.vwDocumentReturnIncludeBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentReturnIncludeTableAdapter
            // 
            this.vwDocumentReturnIncludeTableAdapter.ClearBeforeFill = true;
            // 
            // spDocumentReturnIncludeTableAdapter
            // 
            this.spDocumentReturnIncludeTableAdapter.ClearBeforeFill = true;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Image = ((System.Drawing.Image)(resources.GetObject("colDescription.Image")));
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            this.colDescription.Width = 153;
            // 
            // ReturnIncludeManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlIncludReturn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReturnIncludeManager";
            this.Size = new System.Drawing.Size(1194, 636);
            this.Controls.SetChildIndex(this.gridControlIncludReturn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIncludReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentReturnIncludeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncludeReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentReturnIncludeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlIncludReturn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIncludeReturn;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouseName;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwDocumentReturnIncludeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwDocumentReturnIncludeTableAdapter vwDocumentReturnIncludeTableAdapter;
        private System.Windows.Forms.BindingSource spDocumentReturnIncludeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private Data.AccountingDataSetTableAdapters.spDocumentReturnIncludeTableAdapter spDocumentReturnIncludeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
