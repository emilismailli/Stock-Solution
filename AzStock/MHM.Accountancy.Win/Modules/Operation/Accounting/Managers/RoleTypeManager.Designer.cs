namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class RoleTypeManager
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
            this.gridControlRoleType = new DevExpress.XtraGrid.GridControl();
            this.vwRoleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridViewRoleType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwRoleTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwRoleTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRoleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoleType)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRoleType
            // 
            this.gridControlRoleType.DataSource = this.vwRoleTypeBindingSource;
            this.gridControlRoleType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRoleType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRoleType.Location = new System.Drawing.Point(0, 40);
            this.gridControlRoleType.MainView = this.gridViewRoleType;
            this.gridControlRoleType.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlRoleType.MenuManager = this.barManager;
            this.gridControlRoleType.Name = "gridControlRoleType";
            this.gridControlRoleType.Size = new System.Drawing.Size(974, 478);
            this.gridControlRoleType.TabIndex = 5;
            this.gridControlRoleType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRoleType});
            // 
            // vwRoleTypeBindingSource
            // 
            this.vwRoleTypeBindingSource.DataMember = "VwRoleType";
            this.vwRoleTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewRoleType
            // 
            this.gridViewRoleType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.Ad,
            this.colDescription,
            this.colIsActive});
            this.gridViewRoleType.GridControl = this.gridControlRoleType;
            this.gridViewRoleType.Name = "gridViewRoleType";
            this.gridViewRoleType.OptionsBehavior.ReadOnly = true;
            this.gridViewRoleType.OptionsView.ShowGroupPanel = false;
            this.gridViewRoleType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRoleType_FocusedRowChanged_1);
            // 
            // colId
            // 
            this.colId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // Ad
            // 
            this.Ad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ad.AppearanceCell.Options.UseFont = true;
            this.Ad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ad.AppearanceHeader.Options.UseFont = true;
            this.Ad.FieldName = "Name";
            this.Ad.Name = "Ad";
            this.Ad.Visible = true;
            this.Ad.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.FieldName = "Qeyd";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colIsActive
            // 
            this.colIsActive.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIsActive.AppearanceCell.Options.UseFont = true;
            this.colIsActive.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colIsActive.AppearanceHeader.Options.UseFont = true;
            this.colIsActive.Caption = "Status";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 3;
            // 
            // vwRoleTypeTableAdapter
            // 
            this.vwRoleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // RoleTypeManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlRoleType);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RoleTypeManager";
            this.Size = new System.Drawing.Size(974, 518);
            this.Controls.SetChildIndex(this.gridControlRoleType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRoleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoleType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRoleType;
        private System.Windows.Forms.BindingSource vwRoleTypeBindingSource;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRoleType;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn Ad;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private Data.AccountingDataSetTableAdapters.VwRoleTypeTableAdapter vwRoleTypeTableAdapter;
    }
}
