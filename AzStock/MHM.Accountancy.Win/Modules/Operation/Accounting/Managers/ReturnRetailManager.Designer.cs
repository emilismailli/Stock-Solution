namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ReturnRetailManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnRetailManager));
            this.gridControlDetail = new DevExpress.XtraGrid.GridControl();
            this.spDocumentRetailReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentReturnRetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDocumentReturnRetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentReturnRetailTableAdapter();
            this.spDocumentRetailReturnTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spDocumentRetailReturnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentRetailReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentReturnRetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDetail
            // 
            this.gridControlDetail.DataSource = this.spDocumentRetailReturnBindingSource;
            this.gridControlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlDetail.Location = new System.Drawing.Point(0, 40);
            this.gridControlDetail.MainView = this.gridViewDetail;
            this.gridControlDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlDetail.MenuManager = this.barManager;
            this.gridControlDetail.Name = "gridControlDetail";
            this.gridControlDetail.Size = new System.Drawing.Size(1794, 967);
            this.gridControlDetail.TabIndex = 4;
            this.gridControlDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetail});
            // 
            // spDocumentRetailReturnBindingSource
            // 
            this.spDocumentRetailReturnBindingSource.DataMember = "spDocumentRetailReturn";
            this.spDocumentRetailReturnBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIncludeDate,
            this.colCompanyName,
            this.colWareHouseName,
            this.colCustomerName,
            this.colAmountRetail,
            this.colPaymentTypeName});
            this.gridViewDetail.GridControl = this.gridControlDetail;
            this.gridViewDetail.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsBehavior.ReadOnly = true;
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDetail.OptionsView.ShowFooter = true;
            this.gridViewDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDetail_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "Nömrə";
            this.colId.FieldName = "Id";
            this.colId.Image = ((System.Drawing.Image)(resources.GetObject("colId.Image")));
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colIncludeDate
            // 
            this.colIncludeDate.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceCell.Options.UseFont = true;
            this.colIncludeDate.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIncludeDate.AppearanceHeader.Options.UseFont = true;
            this.colIncludeDate.Caption = "Tarix";
            this.colIncludeDate.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colIncludeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.FieldName = "IncludeDate";
            this.colIncludeDate.GroupFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.colIncludeDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIncludeDate.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeDate.Image")));
            this.colIncludeDate.Name = "colIncludeDate";
            this.colIncludeDate.Visible = true;
            this.colIncludeDate.VisibleIndex = 2;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
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
            this.colWareHouseName.Name = "colWareHouseName";
            this.colWareHouseName.Visible = true;
            this.colWareHouseName.VisibleIndex = 4;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCustomerName.AppearanceHeader.Options.UseFont = true;
            this.colCustomerName.Caption = "Müştəri";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerName.Image")));
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 5;
            // 
            // colAmountRetail
            // 
            this.colAmountRetail.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountRetail.AppearanceCell.Options.UseFont = true;
            this.colAmountRetail.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmountRetail.AppearanceHeader.Options.UseFont = true;
            this.colAmountRetail.Caption = "Məbləğ Pərakəndə";
            this.colAmountRetail.DisplayFormat.FormatString = "{0:0.##}";
            this.colAmountRetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.FieldName = "AmountRetail";
            this.colAmountRetail.GroupFormat.FormatString = "{0:0.##}";
            this.colAmountRetail.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.Image = ((System.Drawing.Image)(resources.GetObject("colAmountRetail.Image")));
            this.colAmountRetail.Name = "colAmountRetail";
            this.colAmountRetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountRetail", "Yekun={0:0.##}")});
            this.colAmountRetail.Visible = true;
            this.colAmountRetail.VisibleIndex = 7;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceCell.Options.UseFont = true;
            this.colPaymentTypeName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPaymentTypeName.Caption = "Ödəniş Növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPaymentTypeName.Image")));
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 6;
            // 
            // vwDocumentReturnRetailBindingSource
            // 
            this.vwDocumentReturnRetailBindingSource.DataMember = "VwDocumentReturnRetail";
            this.vwDocumentReturnRetailBindingSource.DataSource = this.dataSet;
            // 
            // vwDocumentReturnRetailTableAdapter
            // 
            this.vwDocumentReturnRetailTableAdapter.ClearBeforeFill = true;
            // 
            // spDocumentRetailReturnTableAdapter
            // 
            this.spDocumentRetailReturnTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnRetailManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlDetail);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReturnRetailManager";
            this.Controls.SetChildIndex(this.gridControlDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentRetailReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentReturnRetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private System.Windows.Forms.BindingSource vwDocumentReturnRetailBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwDocumentReturnRetailTableAdapter vwDocumentReturnRetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private System.Windows.Forms.BindingSource spDocumentRetailReturnBindingSource;
        private Data.AccountingDataSetTableAdapters.spDocumentRetailReturnTableAdapter spDocumentRetailReturnTableAdapter;
    }
}
