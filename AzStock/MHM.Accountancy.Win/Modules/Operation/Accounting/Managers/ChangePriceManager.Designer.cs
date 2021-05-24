namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ChangePriceManager
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
            this.accountingDataSetBindingSource = new System.Windows.Forms.BindingSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastPriceBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastPriceRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountingDataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwLastPriceBindingSource = new System.Windows.Forms.BindingSource();
            this.vwLastPriceTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwLastPriceTableAdapter();
            this.vwDocumentTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter();
            this.vwDocumentBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLastPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwLastPriceBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1002, 457);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullGoodName,
            this.colCreateId,
            this.colCreateDate,
            this.colPriceBuy,
            this.colPriceRetail,
            this.colPriceWholeSale,
            this.colLastPriceBuy,
            this.colLastPriceRetail,
            this.colLastPriceWholeSale,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu bura çəkin";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colFullGoodName
            // 
            this.colFullGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName.Caption = "Məhsul Adı";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 1;
            this.colFullGoodName.Width = 90;
            // 
            // colCreateId
            // 
            this.colCreateId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateId.AppearanceCell.Options.UseFont = true;
            this.colCreateId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateId.AppearanceHeader.Options.UseFont = true;
            this.colCreateId.Caption = "Əməliyyatçı";
            this.colCreateId.FieldName = "CreateId";
            this.colCreateId.Name = "colCreateId";
            this.colCreateId.Visible = true;
            this.colCreateId.VisibleIndex = 2;
            this.colCreateId.Width = 48;
            // 
            // colCreateDate
            // 
            this.colCreateDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateDate.AppearanceCell.Options.UseFont = true;
            this.colCreateDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCreateDate.AppearanceHeader.Options.UseFont = true;
            this.colCreateDate.Caption = "Tarix";
            this.colCreateDate.DisplayFormat.FormatString = "dd:MM:yyy hh:mm:ss";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.GroupFormat.FormatString = "dd:MM:yyy hh:mm:ss";
            this.colCreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 3;
            this.colCreateDate.Width = 99;
            // 
            // colPriceBuy
            // 
            this.colPriceBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceCell.Options.UseFont = true;
            this.colPriceBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceBuy.AppearanceHeader.Options.UseFont = true;
            this.colPriceBuy.Caption = "Yeni Alış Qiyməti";
            this.colPriceBuy.FieldName = "PriceBuy";
            this.colPriceBuy.Name = "colPriceBuy";
            this.colPriceBuy.Visible = true;
            this.colPriceBuy.VisibleIndex = 4;
            this.colPriceBuy.Width = 93;
            // 
            // colPriceRetail
            // 
            this.colPriceRetail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceRetail.AppearanceCell.Options.UseFont = true;
            this.colPriceRetail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceRetail.AppearanceHeader.Options.UseFont = true;
            this.colPriceRetail.Caption = "Yeni Pərakəndə Qiyməti";
            this.colPriceRetail.FieldName = "PriceRetail";
            this.colPriceRetail.Name = "colPriceRetail";
            this.colPriceRetail.Visible = true;
            this.colPriceRetail.VisibleIndex = 5;
            this.colPriceRetail.Width = 93;
            // 
            // colPriceWholeSale
            // 
            this.colPriceWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceCell.Options.UseFont = true;
            this.colPriceWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPriceWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colPriceWholeSale.Caption = "Yeni Topdan Qiyməti";
            this.colPriceWholeSale.FieldName = "PriceWholeSale";
            this.colPriceWholeSale.Name = "colPriceWholeSale";
            this.colPriceWholeSale.Visible = true;
            this.colPriceWholeSale.VisibleIndex = 6;
            this.colPriceWholeSale.Width = 93;
            // 
            // colLastPriceBuy
            // 
            this.colLastPriceBuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLastPriceBuy.AppearanceCell.Options.UseFont = true;
            this.colLastPriceBuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLastPriceBuy.AppearanceHeader.Options.UseFont = true;
            this.colLastPriceBuy.Caption = "Keçmiş Alış Qiymət";
            this.colLastPriceBuy.FieldName = "LastPriceBuy";
            this.colLastPriceBuy.Name = "colLastPriceBuy";
            this.colLastPriceBuy.Visible = true;
            this.colLastPriceBuy.VisibleIndex = 7;
            this.colLastPriceBuy.Width = 93;
            // 
            // colLastPriceRetail
            // 
            this.colLastPriceRetail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLastPriceRetail.AppearanceCell.Options.UseFont = true;
            this.colLastPriceRetail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLastPriceRetail.AppearanceHeader.Options.UseFont = true;
            this.colLastPriceRetail.Caption = "Keçmiş Pərakəndə Qiyməti";
            this.colLastPriceRetail.FieldName = "LastPriceRetail";
            this.colLastPriceRetail.Name = "colLastPriceRetail";
            this.colLastPriceRetail.Visible = true;
            this.colLastPriceRetail.VisibleIndex = 8;
            this.colLastPriceRetail.Width = 93;
            // 
            // colLastPriceWholeSale
            // 
            this.colLastPriceWholeSale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLastPriceWholeSale.AppearanceCell.Options.UseFont = true;
            this.colLastPriceWholeSale.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colLastPriceWholeSale.AppearanceHeader.Options.UseFont = true;
            this.colLastPriceWholeSale.Caption = "Keçmiş Topdan Qiyməti";
            this.colLastPriceWholeSale.FieldName = "LastPriceWholeSale";
            this.colLastPriceWholeSale.Name = "colLastPriceWholeSale";
            this.colLastPriceWholeSale.Visible = true;
            this.colLastPriceWholeSale.VisibleIndex = 9;
            this.colLastPriceWholeSale.Width = 93;
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
            this.colDescription.VisibleIndex = 10;
            this.colDescription.Width = 111;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "LastPriceBuy";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "LastPriceBuy";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwLastPriceBindingSource
            // 
            this.vwLastPriceBindingSource.DataMember = "VwLastPrice";
            this.vwLastPriceBindingSource.DataSource = this.accountingDataSet;
            // 
            // vwLastPriceTableAdapter
            // 
            this.vwLastPriceTableAdapter.ClearBeforeFill = true;
            // 
            // vwDocumentTableAdapter
            // 
            this.vwDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // ChangePriceManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ChangePriceManager";
            this.Size = new System.Drawing.Size(1002, 499);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLastPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource accountingDataSetBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPriceRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPriceBuy;
        private System.Windows.Forms.BindingSource vwLastPriceBindingSource;
        private Data.AccountingDataSet accountingDataSet;
        private Data.AccountingDataSetTableAdapters.VwLastPriceTableAdapter vwLastPriceTableAdapter;
        private Data.AccountingDataSetTableAdapters.VwDocumentTableAdapter vwDocumentTableAdapter;
        private System.Windows.Forms.BindingSource vwDocumentBindingSource;
    }
}