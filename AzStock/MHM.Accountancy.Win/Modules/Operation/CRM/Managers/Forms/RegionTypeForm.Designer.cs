namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    partial class RegionTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionTypeForm));
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtRegionType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.vwRegionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwRegionTypeTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwRegionTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(324, 67);
            this.btnAccept.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(418, 67);
            this.btnCancel.TabIndex = 4;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 74);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 38);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(399, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // txtRegionType
            // 
            this.txtRegionType.Location = new System.Drawing.Point(107, 12);
            this.txtRegionType.Name = "txtRegionType";
            this.txtRegionType.Size = new System.Drawing.Size(399, 20);
            this.txtRegionType.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(26, 13);
            this.labelControl7.TabIndex = 99;
            this.labelControl7.Text = "Qeyd";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 98;
            this.labelControl3.Text = "Region Növü";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwRegionTypeBindingSource
            // 
            this.vwRegionTypeBindingSource.DataMember = "VwRegionType";
            this.vwRegionTypeBindingSource.DataSource = this.dataSet;
            // 
            // vwRegionTypeTableAdapter
            // 
            this.vwRegionTypeTableAdapter.ClearBeforeFill = true;
            // 
            // RegionTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 106);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRegionType);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Name = "RegionTypeForm";
            this.Text = "Region Növləri";
            this.Load += new System.EventHandler(this.RegionTypeForm_Load);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.txtRegionType, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRegionTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtRegionType;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Data.CRMDataSet dataSet;
        private System.Windows.Forms.BindingSource vwRegionTypeBindingSource;
        private Data.CRMDataSetTableAdapters.VwRegionTypeTableAdapter vwRegionTypeTableAdapter;
    }
}