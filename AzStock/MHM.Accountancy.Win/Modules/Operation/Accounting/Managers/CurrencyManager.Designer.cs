namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class CurrencyManager
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
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridControlCurrency = new DevExpress.XtraGrid.GridControl();
            this.vwCurrencyBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefreshDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwCurrencyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControlCurrency
            // 
            this.gridControlCurrency.DataSource = this.vwCurrencyBindingSource;
            this.gridControlCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCurrency.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlCurrency.Location = new System.Drawing.Point(0, 40);
            this.gridControlCurrency.MainView = this.gridViewCurrency;
            this.gridControlCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlCurrency.MenuManager = this.barManager;
            this.gridControlCurrency.Name = "gridControlCurrency";
            this.gridControlCurrency.Size = new System.Drawing.Size(1701, 841);
            this.gridControlCurrency.TabIndex = 4;
            this.gridControlCurrency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCurrency});
            // 
            // vwCurrencyBindingSource
            // 
            this.vwCurrencyBindingSource.DataMember = "VwCurrency";
            this.vwCurrencyBindingSource.DataSource = this.dataSet;
            // 
            // gridViewCurrency
            // 
            this.gridViewCurrency.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colRefreshDate,
            this.colBuy,
            this.colSell,
            this.colDescription});
            this.gridViewCurrency.GridControl = this.gridControlCurrency;
            this.gridViewCurrency.Name = "gridViewCurrency";
            this.gridViewCurrency.OptionsBehavior.ReadOnly = true;
            this.gridViewCurrency.OptionsFind.AlwaysVisible = true;
            this.gridViewCurrency.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewCurrency.OptionsFind.ShowClearButton = false;
            this.gridViewCurrency.OptionsFind.ShowCloseButton = false;
            this.gridViewCurrency.OptionsFind.ShowFindButton = false;
            this.gridViewCurrency.OptionsSelection.MultiSelect = true;
            this.gridViewCurrency.OptionsView.ShowGroupPanel = false;
            this.gridViewCurrency.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCurrency_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Adı";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 50;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 110;
            // 
            // colRefreshDate
            // 
            this.colRefreshDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRefreshDate.AppearanceCell.Options.UseFont = true;
            this.colRefreshDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRefreshDate.AppearanceHeader.Options.UseFont = true;
            this.colRefreshDate.Caption = "Yenilənmə Tarixi";
            this.colRefreshDate.FieldName = "RefreshDate";
            this.colRefreshDate.MinWidth = 60;
            this.colRefreshDate.Name = "colRefreshDate";
            this.colRefreshDate.Visible = true;
            this.colRefreshDate.VisibleIndex = 1;
            this.colRefreshDate.Width = 120;
            // 
            // colBuy
            // 
            this.colBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBuy.AppearanceCell.Options.UseFont = true;
            this.colBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colBuy.AppearanceHeader.Options.UseFont = true;
            this.colBuy.Caption = "Alış";
            this.colBuy.FieldName = "Buy";
            this.colBuy.MinWidth = 60;
            this.colBuy.Name = "colBuy";
            this.colBuy.Visible = true;
            this.colBuy.VisibleIndex = 2;
            this.colBuy.Width = 217;
            // 
            // colSell
            // 
            this.colSell.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSell.AppearanceCell.Options.UseFont = true;
            this.colSell.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colSell.AppearanceHeader.Options.UseFont = true;
            this.colSell.Caption = "Satış";
            this.colSell.FieldName = "Sell";
            this.colSell.MinWidth = 60;
            this.colSell.Name = "colSell";
            this.colSell.Visible = true;
            this.colSell.VisibleIndex = 3;
            this.colSell.Width = 217;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 150;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 452;
            // 
            // vwCurrencyTableAdapter
            // 
            this.vwCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // CurrencyManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCurrency);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CurrencyManager";
            this.Size = new System.Drawing.Size(1701, 881);
            this.Controls.SetChildIndex(this.gridControlCurrency, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.GridControl gridControlCurrency;
        private System.Windows.Forms.BindingSource vwCurrencyBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRefreshDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colSell;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter vwCurrencyTableAdapter;
    }
}
