namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    partial class DoseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoseForm));
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.vwDoseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.vwDoseTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwDoseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(308, 68);
            this.btnAccept.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(402, 68);
            this.btnCancel.TabIndex = 4;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 75);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 38);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(384, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Qeyd";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Doza Adı";
            // 
            // vwDoseBindingSource
            // 
            this.vwDoseBindingSource.DataMember = "VwDose";
            this.vwDoseBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDoseTableAdapter
            // 
            this.vwDoseTableAdapter.ClearBeforeFill = true;
            // 
            // DoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 107);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl2);
            this.Name = "DoseForm";
            this.Text = "Dozalar";
            this.Load += new System.EventHandler(this.DoseForm_Load);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDoseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource vwDoseBindingSource;
        private Data.CRMDataSet dataSet;
        private Data.CRMDataSetTableAdapters.VwDoseTableAdapter vwDoseTableAdapter;
    }
}