namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class CompanyManager
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
            this.gridControlCompany = new DevExpress.XtraGrid.GridControl();
            this.vwCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkTypeName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankSwift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwCompanyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCompany
            // 
            this.gridControlCompany.DataSource = this.vwCompanyBindingSource;
            this.gridControlCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompany.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlCompany.Location = new System.Drawing.Point(0, 42);
            this.gridControlCompany.MainView = this.gridViewCompany;
            this.gridControlCompany.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlCompany.MenuManager = this.barManager;
            this.gridControlCompany.Name = "gridControlCompany";
            this.gridControlCompany.Size = new System.Drawing.Size(1928, 949);
            this.gridControlCompany.TabIndex = 4;
            this.gridControlCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompany});
            // 
            // vwCompanyBindingSource
            // 
            this.vwCompanyBindingSource.DataMember = "VwCompany";
            this.vwCompanyBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewCompany
            // 
            this.gridViewCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.colCompanyLeader,
            this.colWorkTypeName1,
            this.colVoen,
            this.colCurrencyName,
            this.colBankName,
            this.colBankSwift,
            this.colDate,
            this.colRegionName,
            this.colLegalAddress,
            this.colActualAddress,
            this.colEmail,
            this.colTel,
            this.colDescription,
            this.colTypeName,
            this.colParentId});
            this.gridViewCompany.GridControl = this.gridControlCompany;
            this.gridViewCompany.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewCompany.Name = "gridViewCompany";
            this.gridViewCompany.OptionsBehavior.ReadOnly = true;
            this.gridViewCompany.OptionsFind.AlwaysVisible = true;
            this.gridViewCompany.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewCompany.OptionsFind.ShowClearButton = false;
            this.gridViewCompany.OptionsFind.ShowCloseButton = false;
            this.gridViewCompany.OptionsFind.ShowFindButton = false;
            this.gridViewCompany.OptionsSelection.MultiSelect = true;
            this.gridViewCompany.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewCompany.OptionsView.ShowGroupPanel = false;
            this.gridViewCompany.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCompany_FocusedRowChanged);
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceCell.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.Caption = "Müəssisə adı";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            // 
            // colCompanyLeader
            // 
            this.colCompanyLeader.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyLeader.AppearanceCell.Options.UseFont = true;
            this.colCompanyLeader.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCompanyLeader.AppearanceHeader.Options.UseFont = true;
            this.colCompanyLeader.Caption = "Müəssisə Rəhbəri";
            this.colCompanyLeader.FieldName = "CompanyLeader";
            this.colCompanyLeader.Name = "colCompanyLeader";
            this.colCompanyLeader.Visible = true;
            this.colCompanyLeader.VisibleIndex = 4;
            // 
            // colWorkTypeName1
            // 
            this.colWorkTypeName1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWorkTypeName1.AppearanceCell.Options.UseFont = true;
            this.colWorkTypeName1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colWorkTypeName1.AppearanceHeader.Options.UseFont = true;
            this.colWorkTypeName1.Caption = "Fəaliyyət növü";
            this.colWorkTypeName1.FieldName = "WorkTypeName";
            this.colWorkTypeName1.Name = "colWorkTypeName1";
            this.colWorkTypeName1.Visible = true;
            this.colWorkTypeName1.VisibleIndex = 5;
            // 
            // colVoen
            // 
            this.colVoen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colVoen.AppearanceCell.Options.UseFont = true;
            this.colVoen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colVoen.AppearanceHeader.Options.UseFont = true;
            this.colVoen.Caption = "Vöen";
            this.colVoen.FieldName = "Voen";
            this.colVoen.Name = "colVoen";
            this.colVoen.Visible = true;
            this.colVoen.VisibleIndex = 6;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCurrencyName.AppearanceCell.Options.UseFont = true;
            this.colCurrencyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCurrencyName.AppearanceHeader.Options.UseFont = true;
            this.colCurrencyName.Caption = "Valyuta";
            this.colCurrencyName.FieldName = "CurrencyName";
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 7;
            // 
            // colBankName
            // 
            this.colBankName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBankName.AppearanceCell.Options.UseFont = true;
            this.colBankName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBankName.AppearanceHeader.Options.UseFont = true;
            this.colBankName.Caption = "Bank";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 8;
            // 
            // colBankSwift
            // 
            this.colBankSwift.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBankSwift.AppearanceCell.Options.UseFont = true;
            this.colBankSwift.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBankSwift.AppearanceHeader.Options.UseFont = true;
            this.colBankSwift.Caption = "Swift";
            this.colBankSwift.FieldName = "BankSwift";
            this.colBankSwift.Name = "colBankSwift";
            this.colBankSwift.Visible = true;
            this.colBankSwift.VisibleIndex = 9;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDate.AppearanceCell.Options.UseFont = true;
            this.colDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDate.AppearanceHeader.Options.UseFont = true;
            this.colDate.Caption = "Tarix";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 10;
            // 
            // colRegionName
            // 
            this.colRegionName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceCell.Options.UseFont = true;
            this.colRegionName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceHeader.Options.UseFont = true;
            this.colRegionName.Caption = "Region";
            this.colRegionName.FieldName = "RegionName";
            this.colRegionName.Name = "colRegionName";
            this.colRegionName.Visible = true;
            this.colRegionName.VisibleIndex = 11;
            // 
            // colLegalAddress
            // 
            this.colLegalAddress.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLegalAddress.AppearanceCell.Options.UseFont = true;
            this.colLegalAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLegalAddress.AppearanceHeader.Options.UseFont = true;
            this.colLegalAddress.Caption = "Qanuni Ünvan";
            this.colLegalAddress.FieldName = "LegalAddress";
            this.colLegalAddress.Name = "colLegalAddress";
            this.colLegalAddress.Visible = true;
            this.colLegalAddress.VisibleIndex = 12;
            // 
            // colActualAddress
            // 
            this.colActualAddress.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colActualAddress.AppearanceCell.Options.UseFont = true;
            this.colActualAddress.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colActualAddress.AppearanceHeader.Options.UseFont = true;
            this.colActualAddress.Caption = "Faktiki Ünvan";
            this.colActualAddress.FieldName = "ActualAddress";
            this.colActualAddress.Name = "colActualAddress";
            this.colActualAddress.Visible = true;
            this.colActualAddress.VisibleIndex = 13;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 14;
            // 
            // colTel
            // 
            this.colTel.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTel.AppearanceCell.Options.UseFont = true;
            this.colTel.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colTel.AppearanceHeader.Options.UseFont = true;
            this.colTel.Caption = "Tel";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 15;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 16;
            // 
            // colTypeName
            // 
            this.colTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTypeName.AppearanceCell.Options.UseFont = true;
            this.colTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTypeName.AppearanceHeader.Options.UseFont = true;
            this.colTypeName.Caption = "Növü";
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 2;
            // 
            // colParentId
            // 
            this.colParentId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colParentId.AppearanceCell.Options.UseFont = true;
            this.colParentId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colParentId.AppearanceHeader.Options.UseFont = true;
            this.colParentId.Caption = "Əsas";
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 1;
            // 
            // colWorkTypeName
            // 
            this.colWorkTypeName.FieldName = "WorkTypeName";
            this.colWorkTypeName.Name = "colWorkTypeName";
            // 
            // vwCompanyTableAdapter
            // 
            this.vwCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCompany);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CompanyManager";
            this.Size = new System.Drawing.Size(1928, 991);
            this.Controls.SetChildIndex(this.gridControlCompany, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colVoen;
        private DevExpress.XtraGrid.Columns.GridColumn colBankSwift;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colActualAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkTypeName1;
        private System.Windows.Forms.BindingSource vwCompanyBindingSource;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionName;
        private Data.AccountingDataSetTableAdapters.VwCompanyTableAdapter vwCompanyTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colParentId;
    }
}
