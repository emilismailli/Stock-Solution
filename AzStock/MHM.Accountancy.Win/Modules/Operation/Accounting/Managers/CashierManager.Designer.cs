namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class CashierManager
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
            this.gridControlBankGroup = new DevExpress.XtraGrid.GridControl();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewBankGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCashierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.CashierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBankGroup
            // 
            this.gridControlBankGroup.DataSource = this.cashierBindingSource;
            this.gridControlBankGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBankGroup.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBankGroup.Location = new System.Drawing.Point(0, 40);
            this.gridControlBankGroup.MainView = this.gridViewBankGroup;
            this.gridControlBankGroup.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBankGroup.MenuManager = this.barManager;
            this.gridControlBankGroup.Name = "gridControlBankGroup";
            this.gridControlBankGroup.Size = new System.Drawing.Size(1966, 933);
            this.gridControlBankGroup.TabIndex = 4;
            this.gridControlBankGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBankGroup});
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBankGroup
            // 
            this.gridViewBankGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCashierName,
            this.colDescription});
            this.gridViewBankGroup.GridControl = this.gridControlBankGroup;
            this.gridViewBankGroup.Name = "gridViewBankGroup";
            this.gridViewBankGroup.OptionsBehavior.ReadOnly = true;
            this.gridViewBankGroup.OptionsFind.AlwaysVisible = true;
            this.gridViewBankGroup.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin ...";
            this.gridViewBankGroup.OptionsFind.ShowClearButton = false;
            this.gridViewBankGroup.OptionsFind.ShowCloseButton = false;
            this.gridViewBankGroup.OptionsFind.ShowFindButton = false;
            this.gridViewBankGroup.OptionsSelection.MultiSelect = true;
            this.gridViewBankGroup.OptionsView.ShowGroupPanel = false;
            this.gridViewBankGroup.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBankGroup_FocusedRowChanged);
            // 
            // colCashierName
            // 
            this.colCashierName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashierName.AppearanceCell.Options.UseFont = true;
            this.colCashierName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCashierName.AppearanceHeader.Options.UseFont = true;
            this.colCashierName.Caption = "Ad";
            this.colCashierName.FieldName = "CashierName";
            this.colCashierName.Name = "colCashierName";
            this.colCashierName.Visible = true;
            this.colCashierName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "İcra Et";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "İcraEt";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "Cashier";
            this.cashierBindingSource.DataSource = this.dataSet;
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // CashierManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlBankGroup);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CashierManager";
            this.Size = new System.Drawing.Size(1966, 973);
            this.Controls.SetChildIndex(this.gridControlBankGroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBankGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBankGroup;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colCashierName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private Data.AccountingDataSetTableAdapters.CashierTableAdapter cashierTableAdapter;
    }
}
