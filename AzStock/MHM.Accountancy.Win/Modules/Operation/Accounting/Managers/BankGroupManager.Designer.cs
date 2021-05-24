namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class BankGroupManager
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
            this.bankGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewBankGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bankGroupTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.BankGroupTableAdapter();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBankGroup
            // 
            this.gridControlBankGroup.DataSource = this.bankGroupBindingSource;
            this.gridControlBankGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBankGroup.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBankGroup.Location = new System.Drawing.Point(0, 42);
            this.gridControlBankGroup.MainView = this.gridViewBankGroup;
            this.gridControlBankGroup.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBankGroup.MenuManager = this.barManager;
            this.gridControlBankGroup.Name = "gridControlBankGroup";
            this.gridControlBankGroup.Size = new System.Drawing.Size(1966, 931);
            this.gridControlBankGroup.TabIndex = 4;
            this.gridControlBankGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBankGroup});
            // 
            // bankGroupBindingSource
            // 
            this.bankGroupBindingSource.DataMember = "BankGroup";
            this.bankGroupBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBankGroup
            // 
            this.gridViewBankGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
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
            this.colName.VisibleIndex = 0;
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
            // bankGroupTableAdapter
            // 
            this.bankGroupTableAdapter.ClearBeforeFill = true;
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
            // BankGroupManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlBankGroup);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BankGroupManager";
            this.Size = new System.Drawing.Size(1966, 973);
            this.Controls.SetChildIndex(this.gridControlBankGroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBankGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBankGroup;
        private System.Windows.Forms.BindingSource bankGroupBindingSource;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.BankGroupTableAdapter bankGroupTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
