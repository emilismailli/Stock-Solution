namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    partial class CurrencyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyForm));
            this.spinEditSell = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditBuy = new DevExpress.XtraEditors.SpinEdit();
            this.dateEditRefreshDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSet();
            this.VwCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VwCurrencyTableAdapter = new MHM.Accountancy.Win.Modules.Operation.Accounting.Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRefreshDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRefreshDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VwCurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(417, 140);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(511, 140);
            this.btnCancel.TabIndex = 7;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 147);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(229, 140);
            this.btnDelete.Visible = false;
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(323, 140);
            this.btnPrintDocument.Visible = false;
            // 
            // spinEditSell
            // 
            this.spinEditSell.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditSell.Location = new System.Drawing.Point(138, 90);
            this.spinEditSell.Name = "spinEditSell";
            this.spinEditSell.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSell.Size = new System.Drawing.Size(460, 20);
            this.spinEditSell.TabIndex = 4;
            // 
            // spinEditBuy
            // 
            this.spinEditBuy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditBuy.Location = new System.Drawing.Point(138, 65);
            this.spinEditBuy.Name = "spinEditBuy";
            this.spinEditBuy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditBuy.Size = new System.Drawing.Size(460, 20);
            this.spinEditBuy.TabIndex = 3;
            // 
            // dateEditRefreshDate
            // 
            this.dateEditRefreshDate.EditValue = null;
            this.dateEditRefreshDate.Location = new System.Drawing.Point(138, 40);
            this.dateEditRefreshDate.Name = "dateEditRefreshDate";
            this.dateEditRefreshDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRefreshDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRefreshDate.Size = new System.Drawing.Size(460, 20);
            this.dateEditRefreshDate.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(138, 116);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(460, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(89, 113);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 19);
            this.labelControl6.TabIndex = 39;
            this.labelControl6.Text = "Qeyd";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(100, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 19);
            this.labelControl4.TabIndex = 37;
            this.labelControl4.Text = "Alış";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(93, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 19);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Satış";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Yenilənmə tarixi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 19);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Valyuta adı";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "AccountingDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VwCurrencyBindingSource
            // 
            this.VwCurrencyBindingSource.DataMember = "VwCurrency";
            this.VwCurrencyBindingSource.DataSource = this.dataSet;
            // 
            // VwCurrencyTableAdapter
            // 
            this.VwCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 179);
            this.Controls.Add(this.spinEditSell);
            this.Controls.Add(this.spinEditBuy);
            this.Controls.Add(this.dateEditRefreshDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl2);
            this.MaximumSize = new System.Drawing.Size(627, 218);
            this.MinimumSize = new System.Drawing.Size(627, 218);
            this.Name = "CurrencyForm";
            this.Text = "Valyutalar";
            this.Load += new System.EventHandler(this.CurrencyForm_Load);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPrintDocument, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.dateEditRefreshDate, 0);
            this.Controls.SetChildIndex(this.spinEditBuy, 0);
            this.Controls.SetChildIndex(this.spinEditSell, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRefreshDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRefreshDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VwCurrencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SpinEdit spinEditSell;
        private DevExpress.XtraEditors.SpinEdit spinEditBuy;
        private DevExpress.XtraEditors.DateEdit dateEditRefreshDate;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource VwCurrencyBindingSource;
        private Data.AccountingDataSet dataSet;
        private Data.AccountingDataSetTableAdapters.VwCurrencyTableAdapter VwCurrencyTableAdapter;
    }
}