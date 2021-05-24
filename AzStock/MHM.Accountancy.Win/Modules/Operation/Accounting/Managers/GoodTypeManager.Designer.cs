namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class GoodTypeManager
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
            this.gridControlGoodType = new DevExpress.XtraGrid.GridControl();
            this.vwGoodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewGoodType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwGoodTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwGoodTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGoodType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGoodType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlGoodType
            // 
            this.gridControlGoodType.DataSource = this.vwGoodTypeBindingSource;
            this.gridControlGoodType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGoodType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlGoodType.Location = new System.Drawing.Point(0, 42);
            this.gridControlGoodType.MainView = this.gridViewGoodType;
            this.gridControlGoodType.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlGoodType.MenuManager = this.barManager;
            this.gridControlGoodType.Name = "gridControlGoodType";
            this.gridControlGoodType.Size = new System.Drawing.Size(1774, 895);
            this.gridControlGoodType.TabIndex = 4;
            this.gridControlGoodType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGoodType});
            // 
            // vwGoodTypeBindingSource
            // 
            this.vwGoodTypeBindingSource.DataMember = "VwGoodType";
            this.vwGoodTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewGoodType
            // 
            this.gridViewGoodType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewGoodType.GridControl = this.gridControlGoodType;
            this.gridViewGoodType.Name = "gridViewGoodType";
            this.gridViewGoodType.OptionsBehavior.ReadOnly = true;
            this.gridViewGoodType.OptionsFind.AlwaysVisible = true;
            this.gridViewGoodType.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewGoodType.OptionsFind.SearchInPreview = true;
            this.gridViewGoodType.OptionsFind.ShowClearButton = false;
            this.gridViewGoodType.OptionsFind.ShowCloseButton = false;
            this.gridViewGoodType.OptionsFind.ShowFindButton = false;
            this.gridViewGoodType.OptionsSelection.MultiSelect = true;
            this.gridViewGoodType.OptionsView.ShowGroupPanel = false;
            this.gridViewGoodType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGoodType_FocusedRowChanged_1);
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Ad";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
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
            this.colDescription.VisibleIndex = 1;
            // 
            // vwGoodTypeTableAdapter
            // 
            this.vwGoodTypeTableAdapter.ClearBeforeFill = true;
            // 
            // GoodTypeManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlGoodType);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GoodTypeManager";
            this.Size = new System.Drawing.Size(1774, 937);
            this.Controls.SetChildIndex(this.gridControlGoodType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGoodType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGoodTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGoodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlGoodType;
        private System.Windows.Forms.BindingSource vwGoodTypeBindingSource;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGoodType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.VwGoodTypeTableAdapter vwGoodTypeTableAdapter;
    }
}
