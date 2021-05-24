namespace MHM.Accountancy.Win.Modules.Operation.HR.Managers.Forms
{
    partial class EducationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEditDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.hrDataSet = new MHM.Accountancy.Win.Modules.Operation.HR.Data.HrDataSet();
            this.educationTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationTypesTableAdapter = new MHM.Accountancy.Win.Modules.Operation.HR.Data.HrDataSetTableAdapters.EducationTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEditDescription);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.textEditName);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(480, 101);
            this.panelControl1.TabIndex = 3;
            // 
            // textEditDescription
            // 
            this.textEditDescription.Location = new System.Drawing.Point(106, 32);
            this.textEditDescription.Name = "textEditDescription";
            this.textEditDescription.Size = new System.Drawing.Size(367, 20);
            this.textEditDescription.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Qeyd";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(106, 6);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(367, 20);
            this.textEditName.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Təhsil növünün adı";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(379, 62);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 34);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Imtina Et";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(285, 62);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 34);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Tesdiqle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "HrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationTypesBindingSource
            // 
            this.educationTypesBindingSource.DataMember = "EducationTypes";
            this.educationTypesBindingSource.DataSource = this.hrDataSet;
            // 
            // educationTypesTableAdapter
            // 
            this.educationTypesTableAdapter.ClearBeforeFill = true;
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 101);
            this.Controls.Add(this.panelControl1);
            this.Name = "EducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EducationForm";
            this.Load += new System.EventHandler(this.EducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEditDescription;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private HR.Data.HrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource educationTypesBindingSource;
        private HR.Data.HrDataSetTableAdapters.EducationTypesTableAdapter educationTypesTableAdapter;
    }
}