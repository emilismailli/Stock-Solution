namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class ExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.erpTreeListLookUpEditMain = new MHM.Accountancy.Business.Infrastructure.UI.erpTreeListLookUpEdit();
            this.vwExpenseChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colExpenseName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAcceptCost = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.vwExpenseChooseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwExpenseChooseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExpenseChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(218, 153);
            this.btnAccept.Size = new System.Drawing.Size(41, 34);
            this.btnAccept.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(265, 153);
            this.btnCancel.Size = new System.Drawing.Size(37, 34);
            this.btnCancel.Visible = false;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 160);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(308, 153);
            this.btnDelete.Size = new System.Drawing.Size(37, 34);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Enabled = false;
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(351, 153);
            this.btnPrintDocument.Size = new System.Drawing.Size(39, 34);
            this.btnPrintDocument.Visible = false;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // erpTreeListLookUpEditMain
            // 
            this.erpTreeListLookUpEditMain.Location = new System.Drawing.Point(56, 40);
            this.erpTreeListLookUpEditMain.Name = "erpTreeListLookUpEditMain";
            this.erpTreeListLookUpEditMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpTreeListLookUpEditMain.Properties.DataSource = this.vwExpenseChooseBindingSource;
            this.erpTreeListLookUpEditMain.Properties.DisplayMember = "ExpenseName";
            this.erpTreeListLookUpEditMain.Properties.NullText = "[Seçim edilməyib]";
            this.erpTreeListLookUpEditMain.Properties.TreeList = this.erpTreeListLookUpEdit1TreeList;
            this.erpTreeListLookUpEditMain.Properties.ValueMember = "Id";
            this.erpTreeListLookUpEditMain.Size = new System.Drawing.Size(332, 20);
            this.erpTreeListLookUpEditMain.TabIndex = 18;
            this.erpTreeListLookUpEditMain.EditValueChanged += new System.EventHandler(this.erpTreeListLookUpEditMain_EditValueChanged);
            // 
            // vwExpenseChooseBindingSource
            // 
            this.vwExpenseChooseBindingSource.DataMember = "VwExpenseChoose";
            this.vwExpenseChooseBindingSource.DataSource = this.dataSet;
            // 
            // erpTreeListLookUpEdit1TreeList
            // 
            this.erpTreeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colExpenseName,
            this.colCode});
            this.erpTreeListLookUpEdit1TreeList.DataSource = this.vwExpenseChooseBindingSource;
            this.erpTreeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.erpTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.erpTreeListLookUpEdit1TreeList.Name = "erpTreeListLookUpEdit1TreeList";
            this.erpTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.erpTreeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.erpTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.erpTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colExpenseName
            // 
            this.colExpenseName.Caption = "Ad";
            this.colExpenseName.FieldName = "ExpenseName";
            this.colExpenseName.Name = "colExpenseName";
            this.colExpenseName.Visible = true;
            this.colExpenseName.VisibleIndex = 0;
            this.colExpenseName.Width = 77;
            // 
            // colCode
            // 
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 77;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(56, 66);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(332, 20);
            this.txtCode.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(332, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(56, 118);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtDescription.Size = new System.Drawing.Size(332, 20);
            this.txtDescription.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Əsas";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 69);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Kod";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 95);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(13, 13);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Ad";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 125);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(26, 13);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Qeyd";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1,
            this.btnAcceptCost,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAcceptCost),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAcceptCost
            // 
            this.btnAcceptCost.Caption = "Təsdiqlə";
            this.btnAcceptCost.Hint = "  ";
            this.btnAcceptCost.Id = 1;
            this.btnAcceptCost.ImageOptions.ImageUri.Uri = "Apply;Size16x16;GrayScaled";
            this.btnAcceptCost.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter));
            this.btnAcceptCost.Name = "btnAcceptCost";
            this.btnAcceptCost.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAcceptCost.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAcceptCost_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "İmtina Et";
            this.btnClose.Hint = "  ";
            this.btnClose.Id = 2;
            this.btnClose.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;GrayScaled";
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(395, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 192);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(395, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 168);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(395, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 168);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 0;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // vwExpenseChooseTableAdapter
            // 
            this.vwExpenseChooseTableAdapter.ClearBeforeFill = true;
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(395, 192);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.erpTreeListLookUpEditMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximumSize = new System.Drawing.Size(411, 231);
            this.MinimumSize = new System.Drawing.Size(411, 231);
            this.Name = "ExpenseForm";
            this.Text = "Xərclərin Təsnifatı";
            this.Load += new System.EventHandler(this.ExpenseForm_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.erpTreeListLookUpEditMain, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEditMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExpenseChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEditMain;
        private DevExpress.XtraEditors.TextEdit textEditAccountNo;
        private DevExpress.XtraEditors.TextEdit textEditAccountName;
        private DevExpress.XtraEditors.MemoEdit memoEditAccountDescription;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwAccountChooseTableAdapter vwAccountChooseTableAdapter;
        private Business.Infrastructure.UI.erpTreeListLookUpEdit erpTreeListLookUpEditMain;
        private DevExpress.XtraTreeList.TreeList erpTreeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.TextEdit txtName;
        private Business.Infrastructure.UI.erpMemoExEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAcceptCost;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colExpenseName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private System.Windows.Forms.BindingSource vwExpenseChooseBindingSource;
        private Data.AccountingDataSetTableAdapters.VwExpenseChooseTableAdapter vwExpenseChooseTableAdapter;
    }
}