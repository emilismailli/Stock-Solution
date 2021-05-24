namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class GoodManager
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
            this.gridControlGood = new DevExpress.XtraGrid.GridControl();
            this.vwGoodBindingSource = new System.Windows.Forms.BindingSource();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewGood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullGoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu();
            this.barBtnShow = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.vwGoodTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlGood
            // 
            this.gridControlGood.DataSource = this.vwGoodBindingSource;
            this.gridControlGood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGood.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlGood.Location = new System.Drawing.Point(0, 40);
            this.gridControlGood.MainView = this.gridViewGood;
            this.gridControlGood.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlGood.MenuManager = this.barManager;
            this.gridControlGood.Name = "gridControlGood";
            this.gridControlGood.Size = new System.Drawing.Size(1990, 1073);
            this.gridControlGood.TabIndex = 4;
            this.gridControlGood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGood});
            // 
            // vwGoodBindingSource
            // 
            this.vwGoodBindingSource.DataMember = "VwGood";
            this.vwGoodBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewGood
            // 
            this.gridViewGood.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFullGoodName,
            this.colGoodTypeName,
            this.colManufacturerCompanyName,
            this.colRegionName,
            this.colUnitName,
            this.colDoseName,
            this.colPackingTypeName,
            this.colDescription});
            this.gridViewGood.GridControl = this.gridControlGood;
            this.gridViewGood.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewGood.Name = "gridViewGood";
            this.gridViewGood.OptionsBehavior.ReadOnly = true;
            this.gridViewGood.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewGood.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewGood.OptionsFind.SearchInPreview = true;
            this.gridViewGood.OptionsSelection.MultiSelect = true;
            this.gridViewGood.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewGood.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewGood_PopupMenuShowing);
            this.gridViewGood.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGood_FocusedRowChanged_1);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colFullGoodName
            // 
            this.colFullGoodName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceCell.Options.UseFont = true;
            this.colFullGoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colFullGoodName.AppearanceHeader.Options.UseFont = true;
            this.colFullGoodName.Caption = "Məhsul";
            this.colFullGoodName.FieldName = "FullGoodName";
            this.colFullGoodName.Name = "colFullGoodName";
            this.colFullGoodName.Visible = true;
            this.colFullGoodName.VisibleIndex = 2;
            // 
            // colGoodTypeName
            // 
            this.colGoodTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodTypeName.AppearanceCell.Options.UseFont = true;
            this.colGoodTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colGoodTypeName.AppearanceHeader.Options.UseFont = true;
            this.colGoodTypeName.Caption = "Məhsul Növü";
            this.colGoodTypeName.FieldName = "GoodTypeName";
            this.colGoodTypeName.Name = "colGoodTypeName";
            this.colGoodTypeName.Visible = true;
            this.colGoodTypeName.VisibleIndex = 3;
            // 
            // colManufacturerCompanyName
            // 
            this.colManufacturerCompanyName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colManufacturerCompanyName.AppearanceCell.Options.UseFont = true;
            this.colManufacturerCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colManufacturerCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colManufacturerCompanyName.Caption = "İstehsalçı Firma";
            this.colManufacturerCompanyName.FieldName = "ManufacturerCompanyName";
            this.colManufacturerCompanyName.Name = "colManufacturerCompanyName";
            this.colManufacturerCompanyName.Visible = true;
            this.colManufacturerCompanyName.VisibleIndex = 4;
            // 
            // colRegionName
            // 
            this.colRegionName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceCell.Options.UseFont = true;
            this.colRegionName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colRegionName.AppearanceHeader.Options.UseFont = true;
            this.colRegionName.Caption = "Region";
            this.colRegionName.FieldName = "RegionName";
            this.colRegionName.Name = "colRegionName";
            this.colRegionName.Visible = true;
            this.colRegionName.VisibleIndex = 5;
            // 
            // colUnitName
            // 
            this.colUnitName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitName.AppearanceCell.Options.UseFont = true;
            this.colUnitName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colUnitName.AppearanceHeader.Options.UseFont = true;
            this.colUnitName.Caption = "Ölçü Vahidi";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 6;
            // 
            // colDoseName
            // 
            this.colDoseName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDoseName.AppearanceCell.Options.UseFont = true;
            this.colDoseName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDoseName.AppearanceHeader.Options.UseFont = true;
            this.colDoseName.Caption = "Doza";
            this.colDoseName.FieldName = "DoseName";
            this.colDoseName.Name = "colDoseName";
            this.colDoseName.Visible = true;
            this.colDoseName.VisibleIndex = 7;
            // 
            // colPackingTypeName
            // 
            this.colPackingTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPackingTypeName.AppearanceCell.Options.UseFont = true;
            this.colPackingTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPackingTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPackingTypeName.Caption = "Paket Növü";
            this.colPackingTypeName.FieldName = "PackingTypeName";
            this.colPackingTypeName.Name = "colPackingTypeName";
            this.colPackingTypeName.Visible = true;
            this.colPackingTypeName.VisibleIndex = 8;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 9;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnShow),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDelete)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // barBtnShow
            // 
            this.barBtnShow.Caption = "Bax";
            this.barBtnShow.Id = 8;
            this.barBtnShow.Name = "barBtnShow";
            this.barBtnShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnShow_ItemClick);
            // 
            // barBtnEdit
            // 
            this.barBtnEdit.Id = 10;
            this.barBtnEdit.Name = "barBtnEdit";
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "Çap Et";
            this.barBtnPrint.Id = 10;
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrint_ItemClick);
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "Sil";
            this.barBtnDelete.Id = 8;
            this.barBtnDelete.Name = "barBtnDelete";
            this.barBtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDelete_ItemClick);
            // 
            // vwGoodTableAdapter
            // 
            this.vwGoodTableAdapter.ClearBeforeFill = true;
            // 
            // GoodManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlGood);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GoodManager";
            this.Size = new System.Drawing.Size(1990, 1113);
            this.Controls.SetChildIndex(this.gridControlGood, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlGood;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGood;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem barBtnShow;
        private DevExpress.XtraBars.BarButtonItem barBtnEdit;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
        private DevExpress.XtraBars.BarButtonItem barBtnDelete;
        private System.Windows.Forms.BindingSource vwGoodBindingSource;
        private Data.AccountingDataSetTableAdapters.VwGoodTableAdapter vwGoodTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFullGoodName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colDoseName;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
