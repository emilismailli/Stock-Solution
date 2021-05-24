namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class MenuCodesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCodesManager));
            this.gridControlLogistic = new DevExpress.XtraGrid.GridControl();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewLogistic = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwLogisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwLogisticTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwLogisticTableAdapter();
            this.vwLogisticDetailTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwLogisticDetailTableAdapter();
            this.menuTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.MenuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLogisticBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLogistic
            // 
            this.gridControlLogistic.DataSource = this.menuBindingSource;
            this.gridControlLogistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLogistic.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlLogistic.Location = new System.Drawing.Point(0, 42);
            this.gridControlLogistic.MainView = this.gridViewLogistic;
            this.gridControlLogistic.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlLogistic.MenuManager = this.barManager;
            this.gridControlLogistic.Name = "gridControlLogistic";
            this.gridControlLogistic.Size = new System.Drawing.Size(1544, 1062);
            this.gridControlLogistic.TabIndex = 4;
            this.gridControlLogistic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLogistic});
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewLogistic
            // 
            this.gridViewLogistic.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colCaption});
            this.gridViewLogistic.GridControl = this.gridControlLogistic;
            this.gridViewLogistic.Name = "gridViewLogistic";
            this.gridViewLogistic.OptionsBehavior.ReadOnly = true;
            this.gridViewLogistic.OptionsFind.AlwaysVisible = true;
            this.gridViewLogistic.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewLogistic.OptionsFind.ShowCloseButton = false;
            this.gridViewLogistic.OptionsFind.ShowFindButton = false;
            this.gridViewLogistic.OptionsSelection.MultiSelect = true;
            this.gridViewLogistic.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewLogistic.OptionsView.ShowGroupPanel = false;
            this.gridViewLogistic.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewContract_FocusedRowChanged);
            // 
            // colCode
            // 
            this.colCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCode.AppearanceCell.Options.UseFont = true;
            this.colCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCode.AppearanceHeader.Options.UseFont = true;
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "Code";
            this.colCode.Image = ((System.Drawing.Image)(resources.GetObject("colCode.Image")));
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colCaption
            // 
            this.colCaption.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCaption.AppearanceCell.Options.UseFont = true;
            this.colCaption.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCaption.AppearanceHeader.Options.UseFont = true;
            this.colCaption.Caption = "Ad";
            this.colCaption.FieldName = "Caption";
            this.colCaption.Image = ((System.Drawing.Image)(resources.GetObject("colCaption.Image")));
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 2;
            // 
            // vwLogisticBindingSource
            // 
            this.vwLogisticBindingSource.DataMember = "VwLogistic";
            this.vwLogisticBindingSource.DataSource = this.dataSet;
            // 
            // vwLogisticTableAdapter
            // 
            this.vwLogisticTableAdapter.ClearBeforeFill = true;
            // 
            // vwLogisticDetailTableAdapter
            // 
            this.vwLogisticDetailTableAdapter.ClearBeforeFill = true;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // MenuCodesManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlLogistic);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuCodesManager";
            this.Size = new System.Drawing.Size(1544, 1104);
            this.Controls.SetChildIndex(this.gridControlLogistic, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwLogisticBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLogistic;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLogistic;
        private System.Windows.Forms.BindingSource vwLogisticBindingSource;
        private Data.AccountingDataSetTableAdapters.VwLogisticTableAdapter vwLogisticTableAdapter;
        private Data.AccountingDataSetTableAdapters.VwLogisticDetailTableAdapter vwLogisticDetailTableAdapter;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCaption;
        private Data.AccountingDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
    }
}
