namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class IncludeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncludeManager));
            this.gridControlInclude = new DevExpress.XtraGrid.GridControl();
            this.spDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewInclude = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeCustomerContractId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter();
            this.spDocumentTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spDocumentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInclude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlInclude
            // 
            this.gridControlInclude.DataSource = this.spDocumentBindingSource;
            this.gridControlInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInclude.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControlInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControlInclude.Location = new System.Drawing.Point(0, 40);
            this.gridControlInclude.MainView = this.gridViewInclude;
            this.gridControlInclude.Margin = new System.Windows.Forms.Padding(8);
            this.gridControlInclude.MenuManager = this.barManager;
            this.gridControlInclude.Name = "gridControlInclude";
            this.gridControlInclude.Size = new System.Drawing.Size(991, 511);
            this.gridControlInclude.TabIndex = 4;
            this.gridControlInclude.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInclude});
            this.gridControlInclude.Click += new System.EventHandler(this.gridControlInclude_Click);
            // 
            // spDocumentBindingSource
            // 
            this.spDocumentBindingSource.DataMember = "spDocument";
            this.spDocumentBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewInclude
            // 
            this.gridViewInclude.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIncludeDate,
            this.colCompanyName,
            this.colWareHouseName,
            this.colIncludeCustomerContractId,
            this.colCustomerName,
            this.colPaymentDate,
            this.colAmountBuy,
            this.colPaymentTypeName,
            this.colDescription});
            this.gridViewInclude.GridControl = this.gridControlInclude;
            this.gridViewInclude.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewInclude.Name = "gridViewInclude";
            this.gridViewInclude.OptionsBehavior.ReadOnly = true;
            this.gridViewInclude.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewInclude.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridViewInclude.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridViewInclude.OptionsFind.AlwaysVisible = true;
            this.gridViewInclude.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewInclude.OptionsFind.ShowClearButton = false;
            this.gridViewInclude.OptionsFind.ShowCloseButton = false;
            this.gridViewInclude.OptionsFind.ShowFindButton = false;
            this.gridViewInclude.OptionsSelection.MultiSelect = true;
            this.gridViewInclude.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewInclude.OptionsView.ShowAutoFilterRow = true;
            this.gridViewInclude.OptionsView.ShowFooter = true;
            this.gridViewInclude.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewInclude_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "Nömrəsi";
            this.colId.DisplayFormat.FormatString = "{0:000000}";
            this.colId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.FieldName = "Id";
            this.colId.GroupFormat.FormatString = "{0:000000}";
            this.colId.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colId.Image = ((System.Drawing.Image)(resources.GetObject("colId.Image")));
            this.colId.MinWidth = 50;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Id", "Yekun")});
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 94;
            // 
            // colIncludeDate
            // 
            this.colIncludeDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceCell.Options.UseFont = true;
            this.colIncludeDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceHeader.Options.UseFont = true;
            this.colIncludeDate.Caption = "Alış Tarix";
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
            this.colIncludeDate.Width = 135;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Əməliyyatçı Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.MinWidth = 150;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.ReadOnly = true;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 4;
            this.colCompanyName.Width = 150;
            // 
            // colWareHouseName
            // 
            this.colWareHouseName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWareHouseName.AppearanceCell.Options.UseFont = true;
            this.colWareHouseName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWareHouseName.AppearanceHeader.Options.UseFont = true;
            this.colWareHouseName.Caption = "Anbar";
            this.colWareHouseName.FieldName = "WareHouseName";
            this.colWareHouseName.Image = ((System.Drawing.Image)(resources.GetObject("colWareHouseName.Image")));
            this.colWareHouseName.MinWidth = 10;
            this.colWareHouseName.Name = "colWareHouseName";
            this.colWareHouseName.OptionsColumn.ReadOnly = true;
            this.colWareHouseName.Visible = true;
            this.colWareHouseName.VisibleIndex = 5;
            this.colWareHouseName.Width = 60;
            // 
            // colIncludeCustomerContractId
            // 
            this.colIncludeCustomerContractId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeCustomerContractId.AppearanceCell.Options.UseFont = true;
            this.colIncludeCustomerContractId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeCustomerContractId.AppearanceHeader.Options.UseFont = true;
            this.colIncludeCustomerContractId.Caption = " Müqavilə №";
            this.colIncludeCustomerContractId.FieldName = "ContractId";
            this.colIncludeCustomerContractId.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeCustomerContractId.Image")));
            this.colIncludeCustomerContractId.MinWidth = 50;
            this.colIncludeCustomerContractId.Name = "colIncludeCustomerContractId";
            this.colIncludeCustomerContractId.OptionsColumn.ReadOnly = true;
            this.colIncludeCustomerContractId.Visible = true;
            this.colIncludeCustomerContractId.VisibleIndex = 7;
            this.colIncludeCustomerContractId.Width = 90;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceHeader.Options.UseFont = true;
            this.colCustomerName.Caption = "Təchizatçı Müəssisə";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerName.Image")));
            this.colCustomerName.MinWidth = 100;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 6;
            this.colCustomerName.Width = 100;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentDate.AppearanceCell.Options.UseFont = true;
            this.colPaymentDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentDate.AppearanceHeader.Options.UseFont = true;
            this.colPaymentDate.Caption = "Ödəniş Tarixi";
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentDate.Image")));
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 3;
            this.colPaymentDate.Width = 109;
            // 
            // colAmountBuy
            // 
            this.colAmountBuy.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceCell.Options.UseFont = true;
            this.colAmountBuy.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountBuy.AppearanceHeader.Options.UseFont = true;
            this.colAmountBuy.Caption = "Məbləğ";
            this.colAmountBuy.DisplayFormat.FormatString = "{0:0.##}";
            this.colAmountBuy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.FieldName = "AmountBuy";
            this.colAmountBuy.GroupFormat.FormatString = "{0:0.##}";
            this.colAmountBuy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountBuy.Image = ((System.Drawing.Image)(resources.GetObject("colAmountBuy.Image")));
            this.colAmountBuy.MinWidth = 70;
            this.colAmountBuy.Name = "colAmountBuy";
            this.colAmountBuy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountBuy", "{0:0.##}")});
            this.colAmountBuy.Visible = true;
            this.colAmountBuy.VisibleIndex = 9;
            this.colAmountBuy.Width = 127;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceCell.Options.UseFont = true;
            this.colPaymentTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPaymentTypeName.Caption = "Ödəniş Növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentTypeName.Image")));
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 8;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Image = ((System.Drawing.Image)(resources.GetObject("colDescription.Image")));
            this.colDescription.MinWidth = 70;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 10;
            this.colDescription.Width = 223;
            // 
            // vwDocumentBindingSource
            // 
            this.vwDocumentBindingSource.DataMember = "VwDocument";
            this.vwDocumentBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentTableAdapter
            // 
            this.vwDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // spDocumentTableAdapter
            // 
            this.spDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // IncludeManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlInclude);
            this.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.Name = "IncludeManager";
            this.Size = new System.Drawing.Size(991, 551);
            this.Controls.SetChildIndex(this.gridControlInclude, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInclude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInclude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlInclude;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInclude;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeCustomerContractId;
        private System.Windows.Forms.BindingSource vwDocumentBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter vwDocumentTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private System.Windows.Forms.BindingSource spDocumentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountBuy;
        private Data.AccountingDataSetTableAdapters.spDocumentTableAdapter spDocumentTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
