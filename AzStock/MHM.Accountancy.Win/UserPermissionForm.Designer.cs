namespace MHM.Accountancy.Win
{
    partial class UserPermissionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.treeUserPermission = new DevExpress.XtraTreeList.TreeList();
            this.userActive = new DevExpress.XtraEditors.CheckEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spWareHousePermittedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wareHouseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.WareHouseTableAdapter();
            this.spWareHousePermittedTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHousePermittedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeUserPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHousePermittedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(941, 644);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1022, 644);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // treeUserPermission
            // 
            this.treeUserPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeUserPermission.KeyFieldName = "Id";
            this.treeUserPermission.Location = new System.Drawing.Point(0, 0);
            this.treeUserPermission.Name = "treeUserPermission";
            this.treeUserPermission.ParentFieldName = "ParentId";
            this.treeUserPermission.Size = new System.Drawing.Size(1094, 274);
            this.treeUserPermission.TabIndex = 2;
            this.treeUserPermission.Click += new System.EventHandler(this.treeUserPermission_Click);
            // 
            // userActive
            // 
            this.userActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userActive.Location = new System.Drawing.Point(3, 646);
            this.userActive.Name = "userActive";
            this.userActive.Properties.Caption = "Aktiv";
            this.userActive.Size = new System.Drawing.Size(137, 19);
            this.userActive.TabIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 1);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeUserPermission);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1094, 637);
            this.splitContainerControl1.SplitterPosition = 274;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spWareHousePermittedBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1094, 357);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spWareHousePermittedBindingSource
            // 
            this.spWareHousePermittedBindingSource.DataMember = "spWareHousePermitted";
            this.spWareHousePermittedBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // accountingDataSetBindingSource
            // 
            this.accountingDataSetBindingSource.DataSource = this.accountingDataSet;
            this.accountingDataSetBindingSource.Position = 0;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAllow});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Anbar";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colAllow
            // 
            this.colAllow.Caption = "İcazə";
            this.colAllow.FieldName = "Allow";
            this.colAllow.Name = "colAllow";
            this.colAllow.Visible = true;
            this.colAllow.VisibleIndex = 0;
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataMember = "WareHouse";
            this.wareHouseBindingSource.DataSource = this.accountingDataSetBindingSource;
            // 
            // wareHouseTableAdapter
            // 
            this.wareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // spWareHousePermittedTableAdapter
            // 
            this.spWareHousePermittedTableAdapter.ClearBeforeFill = true;
            // 
            // UserPermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 673);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.userActive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserPermissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İcazələr";
            this.Load += new System.EventHandler(this.UserPermissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeUserPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spWareHousePermittedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraTreeList.TreeList treeUserPermission;
        private DevExpress.XtraEditors.CheckEdit userActive;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource accountingDataSetBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSet accountingDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.WareHouseTableAdapter wareHouseTableAdapter;
        private System.Windows.Forms.BindingSource spWareHousePermittedBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAllow;
        private Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.spWareHousePermittedTableAdapter spWareHousePermittedTableAdapter;
    }
}