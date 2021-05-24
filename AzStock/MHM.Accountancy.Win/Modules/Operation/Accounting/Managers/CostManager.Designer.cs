namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class CostManager
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
            this.gridControlCost = new DevExpress.XtraGrid.GridControl();
            this.vwCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewCost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwCostTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCost)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCost
            // 
            this.gridControlCost.DataSource = this.vwCostBindingSource;
            this.gridControlCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCost.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControlCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControlCost.Location = new System.Drawing.Point(0, 40);
            this.gridControlCost.MainView = this.gridViewCost;
            this.gridControlCost.Margin = new System.Windows.Forms.Padding(8);
            this.gridControlCost.MenuManager = this.barManager;
            this.gridControlCost.Name = "gridControlCost";
            this.gridControlCost.Size = new System.Drawing.Size(1085, 549);
            this.gridControlCost.TabIndex = 4;
            this.gridControlCost.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCost});
            // 
            // vwCostBindingSource
            // 
            this.vwCostBindingSource.DataMember = "VwCost";
            this.vwCostBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewCost
            // 
            this.gridViewCost.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPerson,
            this.colPlace,
            this.colCostDate,
            this.colPaymentTypeName,
            this.colDescription,
            this.colAmount});
            this.gridViewCost.GridControl = this.gridControlCost;
            this.gridViewCost.GroupPanelText = "Qruplaşdırmaq istədiyiniz sütunu çəkin";
            this.gridViewCost.Name = "gridViewCost";
            this.gridViewCost.OptionsBehavior.ReadOnly = true;
            this.gridViewCost.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewCost.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridViewCost.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridViewCost.OptionsFind.AlwaysVisible = true;
            this.gridViewCost.OptionsFind.FindNullPrompt = "Axtarış sözünü daxil edin...";
            this.gridViewCost.OptionsFind.ShowClearButton = false;
            this.gridViewCost.OptionsFind.ShowCloseButton = false;
            this.gridViewCost.OptionsFind.ShowFindButton = false;
            this.gridViewCost.OptionsSelection.MultiSelect = true;
            this.gridViewCost.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewCost.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCost.OptionsView.ShowFooter = true;
            this.gridViewCost.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewInclude_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colPerson
            // 
            this.colPerson.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPerson.AppearanceCell.Options.UseFont = true;
            this.colPerson.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPerson.AppearanceHeader.Options.UseFont = true;
            this.colPerson.Caption = "Ödəyən";
            this.colPerson.FieldName = "Person";
            this.colPerson.Name = "colPerson";
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 2;
            // 
            // colPlace
            // 
            this.colPlace.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPlace.AppearanceCell.Options.UseFont = true;
            this.colPlace.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPlace.AppearanceHeader.Options.UseFont = true;
            this.colPlace.Caption = "Ödənilən";
            this.colPlace.FieldName = "Place";
            this.colPlace.Name = "colPlace";
            this.colPlace.Visible = true;
            this.colPlace.VisibleIndex = 3;
            // 
            // colCostDate
            // 
            this.colCostDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCostDate.AppearanceCell.Options.UseFont = true;
            this.colCostDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCostDate.AppearanceHeader.Options.UseFont = true;
            this.colCostDate.Caption = "Tarix";
            this.colCostDate.FieldName = "CostDate";
            this.colCostDate.Name = "colCostDate";
            this.colCostDate.Visible = true;
            this.colCostDate.VisibleIndex = 4;
            // 
            // colPaymentTypeName
            // 
            this.colPaymentTypeName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceCell.Options.UseFont = true;
            this.colPaymentTypeName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colPaymentTypeName.AppearanceHeader.Options.UseFont = true;
            this.colPaymentTypeName.Caption = "Ödəniş Növü";
            this.colPaymentTypeName.FieldName = "PaymentTypeName";
            this.colPaymentTypeName.Name = "colPaymentTypeName";
            this.colPaymentTypeName.Visible = true;
            this.colPaymentTypeName.VisibleIndex = 5;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmount.AppearanceCell.Options.UseFont = true;
            this.colAmount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colAmount.AppearanceHeader.Options.UseFont = true;
            this.colAmount.Caption = "Məbləğ";
            this.colAmount.DisplayFormat.FormatString = "{0:0.######}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.FieldName = "Amount";
            this.colAmount.GroupFormat.FormatString = "{0:0.######}";
            this.colAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Yekun={0:0.######}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            // 
            // vwCostTableAdapter
            // 
            this.vwCostTableAdapter.ClearBeforeFill = true;
            // 
            // CostManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCost);
            this.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.Name = "CostManager";
            this.Size = new System.Drawing.Size(1085, 589);
            this.Controls.SetChildIndex(this.gridControlCost, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCost;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCost;
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwCostBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colCostDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.VwCostTableAdapter vwCostTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
    }
}
