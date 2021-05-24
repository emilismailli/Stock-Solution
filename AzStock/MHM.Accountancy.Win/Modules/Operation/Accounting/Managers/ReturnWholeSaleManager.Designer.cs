namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ReturnWholeSaleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnWholeSaleManager));
            this.gridControlWholeSaleReturn = new DevExpress.XtraGrid.GridControl();
            this.vwDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewWholeSaleReturn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWareHouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncludeCustomerContractId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwDocumentTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWholeSaleReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWholeSaleReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlWholeSaleReturn
            // 
            this.gridControlWholeSaleReturn.DataSource = this.vwDocumentBindingSource;
            this.gridControlWholeSaleReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWholeSaleReturn.Location = new System.Drawing.Point(0, 40);
            this.gridControlWholeSaleReturn.MainView = this.gridViewWholeSaleReturn;
            this.gridControlWholeSaleReturn.MenuManager = this.barManager;
            this.gridControlWholeSaleReturn.Name = "gridControlWholeSaleReturn";
            this.gridControlWholeSaleReturn.Size = new System.Drawing.Size(990, 489);
            this.gridControlWholeSaleReturn.TabIndex = 4;
            this.gridControlWholeSaleReturn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWholeSaleReturn});
            this.gridControlWholeSaleReturn.Click += new System.EventHandler(this.gridControlInclude_Click);
            // 
            // vwDocumentBindingSource
            // 
            this.vwDocumentBindingSource.DataMember = "VwDocument";
            this.vwDocumentBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewWholeSaleReturn
            // 
            this.gridViewWholeSaleReturn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colIncludeDate,
            this.colCompanyName,
            this.colWareHouseName,
            this.colIncludeCustomerContractId,
            this.colCustomerName});
            this.gridViewWholeSaleReturn.GridControl = this.gridControlWholeSaleReturn;
            this.gridViewWholeSaleReturn.Name = "gridViewWholeSaleReturn";
            this.gridViewWholeSaleReturn.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewWholeSaleReturn.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridViewWholeSaleReturn.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridViewWholeSaleReturn.OptionsFind.AlwaysVisible = true;
            this.gridViewWholeSaleReturn.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewWholeSaleReturn.OptionsFind.ShowClearButton = false;
            this.gridViewWholeSaleReturn.OptionsFind.ShowCloseButton = false;
            this.gridViewWholeSaleReturn.OptionsFind.ShowFindButton = false;
            this.gridViewWholeSaleReturn.OptionsSelection.MultiSelect = true;
            this.gridViewWholeSaleReturn.OptionsView.ShowAutoFilterRow = true;
            this.gridViewWholeSaleReturn.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
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
            this.colId.VisibleIndex = 0;
            this.colId.Width = 101;
            // 
            // colIncludeDate
            // 
            this.colIncludeDate.Caption = "Mədaxil Tarixi";
            this.colIncludeDate.FieldName = "IncludeDate";
            this.colIncludeDate.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeDate.Image")));
            this.colIncludeDate.MinWidth = 75;
            this.colIncludeDate.Name = "colIncludeDate";
            this.colIncludeDate.OptionsColumn.ReadOnly = true;
            this.colIncludeDate.Visible = true;
            this.colIncludeDate.VisibleIndex = 1;
            this.colIncludeDate.Width = 150;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Əməliyyatçı Müəssisə";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Image = ((System.Drawing.Image)(resources.GetObject("colCompanyName.Image")));
            this.colCompanyName.MinWidth = 150;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.ReadOnly = true;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            this.colCompanyName.Width = 300;
            // 
            // colWareHouseName
            // 
            this.colWareHouseName.Caption = "Anbar";
            this.colWareHouseName.FieldName = "WareHouseName";
            this.colWareHouseName.Image = ((System.Drawing.Image)(resources.GetObject("colWareHouseName.Image")));
            this.colWareHouseName.MinWidth = 250;
            this.colWareHouseName.Name = "colWareHouseName";
            this.colWareHouseName.OptionsColumn.ReadOnly = true;
            this.colWareHouseName.Visible = true;
            this.colWareHouseName.VisibleIndex = 5;
            this.colWareHouseName.Width = 300;
            // 
            // colIncludeCustomerContractId
            // 
            this.colIncludeCustomerContractId.Caption = " Müqavilə №";
            this.colIncludeCustomerContractId.FieldName = "ContractId";
            this.colIncludeCustomerContractId.Image = ((System.Drawing.Image)(resources.GetObject("colIncludeCustomerContractId.Image")));
            this.colIncludeCustomerContractId.MinWidth = 150;
            this.colIncludeCustomerContractId.Name = "colIncludeCustomerContractId";
            this.colIncludeCustomerContractId.OptionsColumn.ReadOnly = true;
            this.colIncludeCustomerContractId.Visible = true;
            this.colIncludeCustomerContractId.VisibleIndex = 4;
            this.colIncludeCustomerContractId.Width = 150;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Müştəri";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Image = ((System.Drawing.Image)(resources.GetObject("colCustomerName.Image")));
            this.colCustomerName.MinWidth = 100;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 3;
            this.colCustomerName.Width = 300;
            // 
            // vwDocumentTableAdapter
            // 
            this.vwDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnWholeSaleManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlWholeSaleReturn);
            this.Name = "ReturnWholeSaleManager";
            this.Size = new System.Drawing.Size(990, 529);
            this.Controls.SetChildIndex(this.gridControlWholeSaleReturn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWholeSaleReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWholeSaleReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlWholeSaleReturn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWholeSaleReturn;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colWareHouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colIncludeCustomerContractId;
        private System.Windows.Forms.BindingSource vwDocumentBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter vwDocumentTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
    }
}
