namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ReasonManager
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
            this.gridControlReason = new DevExpress.XtraGrid.GridControl();
            this.vwReasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewReason = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwReasonTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwReasonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReason)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlReason
            // 
            this.gridControlReason.DataSource = this.vwReasonBindingSource;
            this.gridControlReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlReason.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlReason.Location = new System.Drawing.Point(0, 42);
            this.gridControlReason.MainView = this.gridViewReason;
            this.gridControlReason.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlReason.MenuManager = this.barManager;
            this.gridControlReason.Name = "gridControlReason";
            this.gridControlReason.Size = new System.Drawing.Size(1794, 965);
            this.gridControlReason.TabIndex = 4;
            this.gridControlReason.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReason});
            // 
            // vwReasonBindingSource
            // 
            this.vwReasonBindingSource.DataMember = "VwReason";
            this.vwReasonBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewReason
            // 
            this.gridViewReason.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.gridViewReason.GridControl = this.gridControlReason;
            this.gridViewReason.Name = "gridViewReason";
            this.gridViewReason.OptionsBehavior.ReadOnly = true;
            this.gridViewReason.OptionsView.ShowGroupPanel = false;
            this.gridViewReason.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewReason_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Səbəb";
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
            // vwReasonTableAdapter
            // 
            this.vwReasonTableAdapter.ClearBeforeFill = true;
            // 
            // ReasonManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlReason);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReasonManager";
            this.Controls.SetChildIndex(this.gridControlReason, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlReason;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReason;
        private System.Windows.Forms.BindingSource vwReasonBindingSource;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private Data.AccountingDataSetTableAdapters.VwReasonTableAdapter vwReasonTableAdapter;
    }
}
