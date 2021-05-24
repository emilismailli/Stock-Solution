namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.vwAccountChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.vwAccountChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwAccountChooseTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.textEditAccountName = new DevExpress.XtraEditors.TextEdit();
            this.memoEditAccountDescription = new DevExpress.XtraEditors.MemoEdit();
            this.treeListLookUpEditMain = new DevExpress.XtraEditors.TreeListLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAccountDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditMain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(364, 203);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(458, 203);
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 210);
            this.checkApplyNew.Visible = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(139, 195);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(600, 167);
            // 
            // vwAccountChooseBindingSource
            // 
            this.vwAccountChooseBindingSource.DataMember = "VwAccountChoose";
            this.vwAccountChooseBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAccountChooseTableAdapter
            // 
            this.vwAccountChooseTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 19);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Əsas:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 19);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Hesab No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 19);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Hesab Adı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 19);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Qeyd:";
            // 
            // textEditAccountNo
            // 
            this.textEditAccountNo.Location = new System.Drawing.Point(87, 38);
            this.textEditAccountNo.Name = "textEditAccountNo";
            this.textEditAccountNo.Size = new System.Drawing.Size(458, 20);
            this.textEditAccountNo.TabIndex = 2;
            // 
            // textEditAccountName
            // 
            this.textEditAccountName.Location = new System.Drawing.Point(87, 61);
            this.textEditAccountName.Name = "textEditAccountName";
            this.textEditAccountName.Size = new System.Drawing.Size(458, 20);
            this.textEditAccountName.TabIndex = 3;
            // 
            // memoEditAccountDescription
            // 
            this.memoEditAccountDescription.Location = new System.Drawing.Point(87, 86);
            this.memoEditAccountDescription.Name = "memoEditAccountDescription";
            this.memoEditAccountDescription.Size = new System.Drawing.Size(458, 111);
            this.memoEditAccountDescription.TabIndex = 4;
            // 
            // treeListLookUpEditMain
            // 
            this.treeListLookUpEditMain.EditValue = "Seçim Edilməyib";
            this.treeListLookUpEditMain.Location = new System.Drawing.Point(87, 12);
            this.treeListLookUpEditMain.Name = "treeListLookUpEditMain";
            this.treeListLookUpEditMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.treeListLookUpEditMain.Properties.DataSource = this.vwAccountChooseBindingSource;
            this.treeListLookUpEditMain.Properties.DisplayMember = "Name";
            this.treeListLookUpEditMain.Properties.ValueMember = "Id";
            this.treeListLookUpEditMain.Size = new System.Drawing.Size(458, 20);
            this.treeListLookUpEditMain.TabIndex = 1;
            this.treeListLookUpEditMain.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.treeListLookUpEditMain_ButtonClick);
            this.treeListLookUpEditMain.EditValueChanged += new System.EventHandler(this.treeListLookUpEditMain_EditValueChanged);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 242);
            this.Controls.Add(this.memoEditAccountDescription);
            this.Controls.Add(this.textEditAccountName);
            this.Controls.Add(this.textEditAccountNo);
            this.Controls.Add(this.treeListLookUpEditMain);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximumSize = new System.Drawing.Size(569, 281);
            this.MinimumSize = new System.Drawing.Size(569, 281);
            this.Name = "AccountForm";
            this.Text = "Hesablar";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.treeListLookUpEditMain, 0);
            this.Controls.SetChildIndex(this.textEditAccountNo, 0);
            this.Controls.SetChildIndex(this.textEditAccountName, 0);
            this.Controls.SetChildIndex(this.memoEditAccountDescription, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAccountChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAccountDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditMain.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Data.AccountingDataSet dataSet;
        private System.Windows.Forms.BindingSource vwAccountChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwAccountChooseTableAdapter vwAccountChooseTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditAccountNo;
        private DevExpress.XtraEditors.TextEdit textEditAccountName;
        private DevExpress.XtraEditors.MemoEdit memoEditAccountDescription;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEditMain;
    }
}