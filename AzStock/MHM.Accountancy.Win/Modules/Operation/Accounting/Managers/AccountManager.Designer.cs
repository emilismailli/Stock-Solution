namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class AccountManager
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
            this.treeListAccount = new DevExpress.XtraTreeList.TreeList();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.vwAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwAccountTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeListAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListAccount
            // 
            this.treeListAccount.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCode,
            this.colName,
            this.colDescription});
            this.treeListAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListAccount.DataSource = this.vwAccountBindingSource;
            this.treeListAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListAccount.Location = new System.Drawing.Point(0, 42);
            this.treeListAccount.Margin = new System.Windows.Forms.Padding(4);
            this.treeListAccount.Name = "treeListAccount";
            this.treeListAccount.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListAccount.Size = new System.Drawing.Size(1510, 841);
            this.treeListAccount.TabIndex = 4;
            this.treeListAccount.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListAccount_FocusedNodeChanged);
            // 
            // colCode
            // 
            this.colCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCode.AppearanceCell.Options.UseFont = true;
            this.colCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCode.AppearanceHeader.Options.UseFont = true;
            this.colCode.Caption = "Hesab kodu";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 141;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Hesab adı";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 141;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 141;
            // 
            // vwAccountBindingSource
            // 
            this.vwAccountBindingSource.DataMember = "VwAccount";
            this.vwAccountBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAccountTableAdapter
            // 
            this.vwAccountTableAdapter.ClearBeforeFill = true;
            // 
            // AccountManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListAccount);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AccountManager";
            this.Size = new System.Drawing.Size(1510, 883);
            this.Controls.SetChildIndex(this.treeListAccount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.treeListAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListAccount;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private System.Windows.Forms.BindingSource vwAccountBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwAccountTableAdapter vwAccountTableAdapter;
    }
}
