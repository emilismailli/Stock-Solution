namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    partial class CityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityForm));
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.cityTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.CityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(284, 66);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(378, 66);
            this.btnCancel.TabIndex = 4;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 73);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(9, 41);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(26, 13);
            this.labelControl8.TabIndex = 105;
            this.labelControl8.Text = "Qeyd";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(367, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(98, 38);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(367, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(13, 13);
            this.labelControl4.TabIndex = 102;
            this.labelControl4.Text = "Ad";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 105);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl4);
            this.MinimumSize = new System.Drawing.Size(488, 144);
            this.Name = "CityForm";
            this.Text = "Şəhərlər";
            this.Load += new System.EventHandler(this.CityForm_Load);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private Data.CRMDataSet dataSet;
        private Data.CRMDataSetTableAdapters.CityTableAdapter cityTableAdapter;
    }
}