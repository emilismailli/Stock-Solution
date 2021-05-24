namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class CostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostForm));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.erpDateEditDate = new MHM.Accountancy.Business.Infrastructure.UI.erpDateEdit();
            this.colDoseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocSeriesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocCertId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceWholeSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcodeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPlace = new DevExpress.XtraEditors.TextEdit();
            this.txtPerson = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new MHM.Accountancy.Business.Infrastructure.UI.erpMemoExEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.erpLookUpEditPaymentType = new MHM.Accountancy.Business.Infrastructure.UI.erpLookUpEdit();
            this.vwPaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.vwCostTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCostTableAdapter();
            this.vwCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPaymentTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(607, 117);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(699, 117);
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 129);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(421, 117);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(515, 117);
            this.btnPrintDocument.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(480, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 24);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tarix";
            // 
            // erpDateEditDate
            // 
            this.erpDateEditDate.EditValue = null;
            this.erpDateEditDate.Location = new System.Drawing.Point(530, 48);
            this.erpDateEditDate.Name = "erpDateEditDate";
            this.erpDateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpDateEditDate.Properties.Appearance.Options.UseFont = true;
            this.erpDateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.erpDateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.erpDateEditDate.Properties.DisplayFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.erpDateEditDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.erpDateEditDate.Properties.EditFormat.FormatString = "dd:MM:yyyy  hh:mm";
            this.erpDateEditDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.erpDateEditDate.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.erpDateEditDate.Properties.NullText = "[Seçim edilməyib]";
            this.erpDateEditDate.Size = new System.Drawing.Size(254, 30);
            this.erpDateEditDate.TabIndex = 5;
            // 
            // colDoseName
            // 
            this.colDoseName.FieldName = "DoseName";
            this.colDoseName.Name = "colDoseName";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colPackingTypeName
            // 
            this.colPackingTypeName.Caption = "Paket Növü";
            this.colPackingTypeName.FieldName = "PackingTypeName";
            this.colPackingTypeName.Image = ((System.Drawing.Image)(resources.GetObject("colPackingTypeName.Image")));
            this.colPackingTypeName.Name = "colPackingTypeName";
            // 
            // colGoodName1
            // 
            this.colGoodName1.Caption = "Məhsul Adı";
            this.colGoodName1.FieldName = "GoodName";
            this.colGoodName1.Image = ((System.Drawing.Image)(resources.GetObject("colGoodName1.Image")));
            this.colGoodName1.Name = "colGoodName1";
            this.colGoodName1.OptionsColumn.AllowEdit = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colGoodTypeId
            // 
            this.colGoodTypeId.FieldName = "GoodTypeId";
            this.colGoodTypeId.Name = "colGoodTypeId";
            // 
            // colManufacturerCompanyId
            // 
            this.colManufacturerCompanyId.FieldName = "ManufacturerCompanyId";
            this.colManufacturerCompanyId.Name = "colManufacturerCompanyId";
            // 
            // colRegionId
            // 
            this.colRegionId.FieldName = "RegionId";
            this.colRegionId.Name = "colRegionId";
            // 
            // colDoseId
            // 
            this.colDoseId.FieldName = "DoseId";
            this.colDoseId.Name = "colDoseId";
            // 
            // colUnitId
            // 
            this.colUnitId.FieldName = "UnitId";
            this.colUnitId.Name = "colUnitId";
            // 
            // colPackingTypeId
            // 
            this.colPackingTypeId.FieldName = "PackingTypeId";
            this.colPackingTypeId.Name = "colPackingTypeId";
            // 
            // colDocSeriesId
            // 
            this.colDocSeriesId.FieldName = "DocSeriesId";
            this.colDocSeriesId.Name = "colDocSeriesId";
            // 
            // colDocCertId
            // 
            this.colDocCertId.FieldName = "DocCertId";
            this.colDocCertId.Name = "colDocCertId";
            // 
            // colDocTypeId
            // 
            this.colDocTypeId.FieldName = "DocTypeId";
            this.colDocTypeId.Name = "colDocTypeId";
            // 
            // colModifyDate
            // 
            this.colModifyDate.FieldName = "ModifyDate";
            this.colModifyDate.Name = "colModifyDate";
            // 
            // colModifyId
            // 
            this.colModifyId.FieldName = "ModifyId";
            this.colModifyId.Name = "colModifyId";
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            // 
            // colCreateId
            // 
            this.colCreateId.FieldName = "CreateId";
            this.colCreateId.Name = "colCreateId";
            // 
            // colPriceWholeSale
            // 
            this.colPriceWholeSale.Caption = "Qiymət -Topdan Satış";
            this.colPriceWholeSale.FieldName = "PriceWholeSale";
            this.colPriceWholeSale.Image = ((System.Drawing.Image)(resources.GetObject("colPriceWholeSale.Image")));
            this.colPriceWholeSale.Name = "colPriceWholeSale";
            this.colPriceWholeSale.Width = 43;
            // 
            // colAmountRetail
            // 
            this.colAmountRetail.Caption = "Məbləğ-Satış";
            this.colAmountRetail.DisplayFormat.FormatString = "{0:0.######}";
            this.colAmountRetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.FieldName = "AmountRetail";
            this.colAmountRetail.GroupFormat.FormatString = "{0:0.######}";
            this.colAmountRetail.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountRetail.Image = ((System.Drawing.Image)(resources.GetObject("colAmountRetail.Image")));
            this.colAmountRetail.Name = "colAmountRetail";
            this.colAmountRetail.OptionsColumn.ReadOnly = true;
            this.colAmountRetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountRetail", "Yekun={0:0.######}")});
            this.colAmountRetail.Width = 43;
            // 
            // colGoodName2
            // 
            this.colGoodName2.FieldName = "GoodName";
            this.colGoodName2.Name = "colGoodName2";
            // 
            // colBarcodeId
            // 
            this.colBarcodeId.FieldName = "BarcodeId";
            this.colBarcodeId.Name = "colBarcodeId";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(60, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 24);
            this.labelControl3.TabIndex = 118;
            this.labelControl3.Text = "Ödənilən";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 24);
            this.labelControl2.TabIndex = 117;
            this.labelControl2.Text = "Ödəniş Edən";
            // 
            // txtPlace
            // 
            this.txtPlace.EditValue = "";
            this.txtPlace.Location = new System.Drawing.Point(149, 48);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlace.Properties.Appearance.Options.UseFont = true;
            this.txtPlace.Size = new System.Drawing.Size(260, 30);
            this.txtPlace.TabIndex = 2;
            // 
            // txtPerson
            // 
            this.txtPerson.EditValue = "";
            this.txtPerson.Location = new System.Drawing.Point(149, 12);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPerson.Properties.Appearance.Options.UseFont = true;
            this.txtPerson.Size = new System.Drawing.Size(260, 30);
            this.txtPerson.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(478, 83);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 24);
            this.labelControl11.TabIndex = 56;
            this.labelControl11.Text = "Qeyd";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(530, 84);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtDescription.Size = new System.Drawing.Size(254, 30);
            this.txtDescription.TabIndex = 6;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(413, 15);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(111, 24);
            this.labelControl10.TabIndex = 54;
            this.labelControl10.Text = "Ödəniş Növü";
            // 
            // erpLookUpEditPaymentType
            // 
            this.erpLookUpEditPaymentType.Location = new System.Drawing.Point(530, 12);
            this.erpLookUpEditPaymentType.Name = "erpLookUpEditPaymentType";
            this.erpLookUpEditPaymentType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erpLookUpEditPaymentType.Properties.Appearance.Options.UseFont = true;
            this.erpLookUpEditPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.erpLookUpEditPaymentType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.erpLookUpEditPaymentType.Properties.DataSource = this.vwPaymentTypeBindingSource;
            this.erpLookUpEditPaymentType.Properties.DisplayMember = "Name";
            this.erpLookUpEditPaymentType.Properties.NullText = "[Seçim edilməyib]";
            this.erpLookUpEditPaymentType.Properties.ValueMember = "Id";
            this.erpLookUpEditPaymentType.Size = new System.Drawing.Size(254, 30);
            this.erpLookUpEditPaymentType.TabIndex = 4;
            this.erpLookUpEditPaymentType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.erpLookUpEditPaymentType_ButtonClick);
            // 
            // vwPaymentTypeBindingSource
            // 
            this.vwPaymentTypeBindingSource.DataMember = "VwPaymentType";
            this.vwPaymentTypeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 87);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 24);
            this.labelControl1.TabIndex = 120;
            this.labelControl1.Text = "Ödəniş Miqdarı";
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "";
            this.txtAmount.Location = new System.Drawing.Point(149, 84);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAmount.Size = new System.Drawing.Size(260, 30);
            this.txtAmount.TabIndex = 3;
            // 
            // vwCostTableAdapter
            // 
            this.vwCostTableAdapter.ClearBeforeFill = true;
            // 
            // vwCostBindingSource
            // 
            this.vwCostBindingSource.DataMember = "VwCost";
            this.vwCostBindingSource.DataSource = this.dataSet;
            // 
            // vwPaymentTypeTableAdapter
            // 
            this.vwPaymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // CostForm
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 161);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.erpDateEditDate);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.erpLookUpEditPaymentType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MaximumSize = new System.Drawing.Size(811, 200);
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(811, 200);
            this.Name = "CostForm";
            this.Text = "Xərclər";
            this.Load += new System.EventHandler(this.CostForm_Load);
            this.Controls.SetChildIndex(this.erpLookUpEditPaymentType, 0);
            this.Controls.SetChildIndex(this.labelControl10, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.txtPerson, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.txtPlace, 0);
            this.Controls.SetChildIndex(this.erpDateEditDate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.labelControl11, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtAmount, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpLookUpEditPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Business.Infrastructure.UI.erpDateEdit erpDateEditDate;
        private Data.AccountingDataSet dataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colDoseName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionId;
        private DevExpress.XtraGrid.Columns.GridColumn colDoseId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitId;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocSeriesId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCertId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateId;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceWholeSale;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodName2;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcodeId;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private Business.Infrastructure.UI.erpMemoExEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private Business.Infrastructure.UI.erpLookUpEdit erpLookUpEditPaymentType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPlace;
        private DevExpress.XtraEditors.TextEdit txtPerson;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private Data.AccountingDataSetTableAdapters.VwCostTableAdapter vwCostTableAdapter;
        private System.Windows.Forms.BindingSource vwCostBindingSource;
        private System.Windows.Forms.BindingSource vwPaymentTypeBindingSource;
        private Data.AccountingDataSetTableAdapters.VwPaymentTypeTableAdapter vwPaymentTypeTableAdapter;
    }
}