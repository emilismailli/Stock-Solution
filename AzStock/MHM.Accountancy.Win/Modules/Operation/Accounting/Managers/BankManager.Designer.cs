namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class BankManager
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControlBank = new DevExpress.XtraGrid.GridControl();
            this.vwBankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBankGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSwift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwBankTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwBankTableAdapter();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBank
            // 
            this.gridControlBank.DataSource = this.vwBankBindingSource;
            this.gridControlBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBank.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gridControlBank.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlBank.Location = new System.Drawing.Point(0, 42);
            this.gridControlBank.MainView = this.gridViewBank;
            this.gridControlBank.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBank.MenuManager = this.barManager;
            this.gridControlBank.Name = "gridControlBank";
            this.gridControlBank.Size = new System.Drawing.Size(1830, 1012);
            this.gridControlBank.TabIndex = 5;
            this.gridControlBank.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBank});
            // 
            // vwBankBindingSource
            // 
            this.vwBankBindingSource.DataMember = "VwBank";
            this.vwBankBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBank
            // 
            this.gridViewBank.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankGroupName,
            this.colName,
            this.colSwift,
            this.colVoen,
            this.colCurrencyName,
            this.colRegionName});
            this.gridViewBank.GridControl = this.gridControlBank;
            this.gridViewBank.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewBank.Name = "gridViewBank";
            this.gridViewBank.OptionsBehavior.ReadOnly = true;
            this.gridViewBank.OptionsFind.AlwaysVisible = true;
            this.gridViewBank.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewBank.OptionsSelection.MultiSelect = true;
            this.gridViewBank.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewBank.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBank_FocusedRowChanged);
            // 
            // colBankGroupName
            // 
            this.colBankGroupName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBankGroupName.AppearanceCell.Options.UseFont = true;
            this.colBankGroupName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBankGroupName.AppearanceHeader.Options.UseFont = true;
            this.colBankGroupName.Caption = "Bank Qrup";
            this.colBankGroupName.FieldName = "BankGroupName";
            this.colBankGroupName.MinWidth = 75;
            this.colBankGroupName.Name = "colBankGroupName";
            this.colBankGroupName.Visible = true;
            this.colBankGroupName.VisibleIndex = 1;
            this.colBankGroupName.Width = 150;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Ad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 209;
            // 
            // colSwift
            // 
            this.colSwift.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSwift.AppearanceCell.Options.UseFont = true;
            this.colSwift.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSwift.AppearanceHeader.Options.UseFont = true;
            this.colSwift.Caption = "Swift";
            this.colSwift.FieldName = "Swift";
            this.colSwift.Name = "colSwift";
            this.colSwift.Visible = true;
            this.colSwift.VisibleIndex = 3;
            this.colSwift.Width = 209;
            // 
            // colVoen
            // 
            this.colVoen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colVoen.AppearanceCell.Options.UseFont = true;
            this.colVoen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colVoen.AppearanceHeader.Options.UseFont = true;
            this.colVoen.Caption = "Voen";
            this.colVoen.FieldName = "Voen";
            this.colVoen.Name = "colVoen";
            this.colVoen.Visible = true;
            this.colVoen.VisibleIndex = 4;
            this.colVoen.Width = 209;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCurrencyName.AppearanceCell.Options.UseFont = true;
            this.colCurrencyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCurrencyName.AppearanceHeader.Options.UseFont = true;
            this.colCurrencyName.Caption = "Valyuta";
            this.colCurrencyName.FieldName = "CurrencyName";
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 5;
            this.colCurrencyName.Width = 209;
            // 
            // colRegionName
            // 
            this.colRegionName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceCell.Options.UseFont = true;
            this.colRegionName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceHeader.Options.UseFont = true;
            this.colRegionName.Caption = "Region";
            this.colRegionName.FieldName = "RegionName";
            this.colRegionName.Name = "colRegionName";
            this.colRegionName.Visible = true;
            this.colRegionName.VisibleIndex = 6;
            this.colRegionName.Width = 219;
            // 
            // vwBankTableAdapter
            // 
            this.vwBankTableAdapter.ClearBeforeFill = true;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "İcra Et";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // BankManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlBank);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BankManager";
            this.Size = new System.Drawing.Size(1830, 1054);
            this.Controls.SetChildIndex(this.gridControlBank, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBank;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBank;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSwift;
        private DevExpress.XtraGrid.Columns.GridColumn colVoen;
        private System.Windows.Forms.BindingSource vwBankBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionName;
        private Data.AccountingDataSetTableAdapters.VwBankTableAdapter vwBankTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBankGroupName;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
