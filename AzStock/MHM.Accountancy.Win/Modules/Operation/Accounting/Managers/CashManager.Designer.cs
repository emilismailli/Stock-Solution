namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class CashManager
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
            this.vwCashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.vwCashTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCashTableAdapter();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBank
            // 
            this.gridControlBank.DataSource = this.vwCashBindingSource;
            this.gridControlBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBank.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gridControlBank.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlBank.Location = new System.Drawing.Point(0, 40);
            this.gridControlBank.MainView = this.gridViewBank;
            this.gridControlBank.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBank.MenuManager = this.barManager;
            this.gridControlBank.Name = "gridControlBank";
            this.gridControlBank.Size = new System.Drawing.Size(1830, 1014);
            this.gridControlBank.TabIndex = 5;
            this.gridControlBank.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBank});
            // 
            // vwCashBindingSource
            // 
            this.vwCashBindingSource.DataMember = "VwCash";
            this.vwCashBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBank
            // 
            this.gridViewBank.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.colCashName,
            this.colBalance,
            this.colDescription});
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
            this.colCompanyName.VisibleIndex = 1;
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
            this.colCashName.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "İcra Et";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // vwCashTableAdapter
            // 
            this.vwCashTableAdapter.ClearBeforeFill = true;
            // 
            // colBalance
            // 
            this.colBalance.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBalance.AppearanceCell.Options.UseFont = true;
            this.colBalance.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBalance.AppearanceHeader.Options.UseFont = true;
            this.colBalance.Caption = "Balans";
            this.colBalance.DisplayFormat.FormatString = "{0:0.##}";
            this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance.FieldName = "Balance";
            this.colBalance.GroupFormat.FormatString = "{0:0.##}";
            this.colBalance.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBalance.Name = "colBalance";
            this.colBalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance", "Yekun={0:0.##}")});
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 3;
            // 
            // CashManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlBank);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CashManager";
            this.Size = new System.Drawing.Size(1830, 1054);
            this.Controls.SetChildIndex(this.gridControlBank, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCashBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBank;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBank;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource vwCashBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCashName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.VwCashTableAdapter vwCashTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
    }
}
