namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class InventorManager
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwInventarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentInventarId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDifferenceQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.vwInventarTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwInventarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwInventarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(986, 435);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwInventarBindingSource
            // 
            this.vwInventarBindingSource.DataMember = "VwInventar";
            this.vwInventarBindingSource.DataSource = this.accountingDataSet;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullGoodName,
            this.colDocumentInventarId,
            this.colQuantity,
            this.colDifferenceQuantity,
            this.colStockQuantity,
            this.colWarehouseName,
            this.colUserName,
            this.colCreateDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = ".";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFullGoodName
            // 
            this.colFullGoodName.Caption = "Məhsul";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 1;
            // 
            // colDocumentInventarId
            // 
            this.colDocumentInventarId.Caption = "№";
            this.colDocumentInventarId.FieldName = "DocumentInventarId";
            this.colDocumentInventarId.Name = "colDocumentInventarId";
            this.colDocumentInventarId.Visible = true;
            this.colDocumentInventarId.VisibleIndex = 2;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Say";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            // 
            // colDifferenceQuantity
            // 
            this.colDifferenceQuantity.Caption = "Fərq";
            this.colDifferenceQuantity.FieldName = "DifferenceQuantity";
            this.colDifferenceQuantity.Name = "colDifferenceQuantity";
            this.colDifferenceQuantity.Visible = true;
            this.colDifferenceQuantity.VisibleIndex = 4;
            // 
            // colStockQuantity
            // 
            this.colStockQuantity.Caption = "Sayilan";
            this.colStockQuantity.FieldName = "StockQuantity";
            this.colStockQuantity.Name = "colStockQuantity";
            this.colStockQuantity.Visible = true;
            this.colStockQuantity.VisibleIndex = 5;
            // 
            // colWarehouseName
            // 
            this.colWarehouseName.Caption = "Anbar";
            this.colWarehouseName.FieldName = "WarehouseName";
            this.colWarehouseName.Name = "colWarehouseName";
            this.colWarehouseName.Visible = true;
            this.colWarehouseName.VisibleIndex = 6;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "İstifadəçi";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 7;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Tarix";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 8;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(986, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 477);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(986, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 477);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(986, 0);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 477);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager2;
            this.barDockControl5.Size = new System.Drawing.Size(986, 0);
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl5);
            this.barManager2.DockControls.Add(this.barDockControl6);
            this.barManager2.DockControls.Add(this.barDockControl7);
            this.barManager2.DockControls.Add(this.barDockControl8);
            this.barManager2.Form = this;
            this.barManager2.MaxItemId = 0;
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 477);
            this.barDockControl6.Manager = this.barManager2;
            this.barDockControl6.Size = new System.Drawing.Size(986, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.barManager2;
            this.barDockControl7.Size = new System.Drawing.Size(0, 477);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(986, 0);
            this.barDockControl8.Manager = this.barManager2;
            this.barDockControl8.Size = new System.Drawing.Size(0, 477);
            // 
            // vwInventarTableAdapter
            // 
            this.vwInventarTableAdapter.ClearBeforeFill = true;
            // 
            // InventorManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "InventorManager";
            this.Size = new System.Drawing.Size(986, 477);
            this.Controls.SetChildIndex(this.barDockControl5, 0);
            this.Controls.SetChildIndex(this.barDockControl6, 0);
            this.Controls.SetChildIndex(this.barDockControl8, 0);
            this.Controls.SetChildIndex(this.barDockControl7, 0);
            this.Controls.SetChildIndex(this.barDockControl1, 0);
            this.Controls.SetChildIndex(this.barDockControl2, 0);
            this.Controls.SetChildIndex(this.barDockControl4, 0);
            this.Controls.SetChildIndex(this.barDockControl3, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private System.Windows.Forms.BindingSource vwInventarBindingSource;
        private Data.AccountingDataSet accountingDataSet;
        private Data.AccountingDataSetTableAdapters.VwInventarTableAdapter vwInventarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentInventarId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDifferenceQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colStockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
    }
}
