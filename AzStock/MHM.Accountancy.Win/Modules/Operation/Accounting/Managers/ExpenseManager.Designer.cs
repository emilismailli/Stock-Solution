namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class ExpenseManager
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
            this.vwExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwExpenseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwExpenseTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colExpenseName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vwExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // vwExpenseBindingSource
            // 
            this.vwExpenseBindingSource.DataMember = "VwExpense";
            this.vwExpenseBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwExpenseTableAdapter
            // 
            this.vwExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colExpenseName,
            this.colParentId,
            this.colCode,
            this.colDescription});
            this.treeList1.DataSource = this.vwExpenseBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 40);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(1510, 843);
            this.treeList1.TabIndex = 4;
            this.treeList1.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark;
            // 
            // colExpenseName
            // 
            this.colExpenseName.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colExpenseName.AppearanceCell.Options.UseFont = true;
            this.colExpenseName.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colExpenseName.AppearanceHeader.Options.UseFont = true;
            this.colExpenseName.Caption = "Təyinat";
            this.colExpenseName.FieldName = "ExpenseName";
            this.colExpenseName.Name = "colExpenseName";
            this.colExpenseName.Visible = true;
            this.colExpenseName.VisibleIndex = 0;
            this.colExpenseName.Width = 213;
            // 
            // colParentId
            // 
            this.colParentId.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colParentId.AppearanceCell.Options.UseFont = true;
            this.colParentId.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colParentId.AppearanceHeader.Options.UseFont = true;
            this.colParentId.Caption = " Əsas";
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 2;
            // 
            // colCode
            // 
            this.colCode.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCode.AppearanceCell.Options.UseFont = true;
            this.colCode.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCode.AppearanceHeader.Options.UseFont = true;
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            // 
            // ExpenseManager
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ExpenseManager";
            this.Size = new System.Drawing.Size(1510, 883);
            this.Controls.SetChildIndex(this.treeList1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.vwExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwExpenseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwExpenseTableAdapter vwExpenseTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colExpenseName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
    }
}
