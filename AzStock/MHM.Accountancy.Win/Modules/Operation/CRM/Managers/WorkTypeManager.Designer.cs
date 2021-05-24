namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    partial class WorkTypeManager
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
            this.gridControlWorkType = new DevExpress.XtraGrid.GridControl();
            this.workTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.gridViewWorkType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.workTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.WorkTypeTableAdapter();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEdit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlWorkType
            // 
            this.gridControlWorkType.DataSource = this.workTypeBindingSource;
            this.gridControlWorkType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWorkType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlWorkType.Location = new System.Drawing.Point(0, 42);
            this.gridControlWorkType.MainView = this.gridViewWorkType;
            this.gridControlWorkType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlWorkType.MenuManager = this.barManager;
            this.gridControlWorkType.Name = "gridControlWorkType";
            this.gridControlWorkType.Size = new System.Drawing.Size(1250, 693);
            this.gridControlWorkType.TabIndex = 5;
            this.gridControlWorkType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWorkType});
            // 
            // workTypeBindingSource
            // 
            this.workTypeBindingSource.DataMember = "WorkType";
            this.workTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewWorkType
            // 
            this.gridViewWorkType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewWorkType.GridControl = this.gridControlWorkType;
            this.gridViewWorkType.Name = "gridViewWorkType";
            this.gridViewWorkType.OptionsBehavior.ReadOnly = true;
            this.gridViewWorkType.OptionsFind.AlwaysVisible = true;
            this.gridViewWorkType.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewWorkType.OptionsFind.SearchInPreview = true;
            this.gridViewWorkType.OptionsSelection.MultiSelect = true;
            this.gridViewWorkType.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewWorkType_PopupMenuShowing);
            // 
            // colName
            // 
            this.colName.Caption = "Ad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // workTypeTableAdapter
            // 
            this.workTypeTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barBtnEdit
            // 
            //this.barBtnEdit.Caption = "Redakte Et";
            //this.barBtnEdit.Id = 8;
            //this.barBtnEdit.Name = "barBtnEdit";
            //this.barBtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEdit_ItemClick);
            // 
            // WorkTypeManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlWorkType);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WorkTypeManager";
            this.Size = new System.Drawing.Size(1250, 735);
            this.Controls.SetChildIndex(this.gridControlWorkType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlWorkType;
        private System.Windows.Forms.BindingSource workTypeBindingSource;
        private Data.CRMDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWorkType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.CRMDataSetTableAdapters.WorkTypeTableAdapter workTypeTableAdapter;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem barBtnEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
