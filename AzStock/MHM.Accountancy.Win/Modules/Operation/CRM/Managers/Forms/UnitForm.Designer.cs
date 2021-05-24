namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    partial class UnitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitForm));
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSet();
            this.vwUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwUnitTableAdapter = new MHM.Accountancy.Win.Modules.Operation.CRM.Data.CRMDataSetTableAdapters.VwUnitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(311, 64);
            this.btnAccept.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(405, 64);
            this.btnCancel.TabIndex = 4;
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Location = new System.Drawing.Point(12, 71);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(109, 38);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(384, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Qeyd";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(109, 12);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(384, 20);
            this.txtUnitName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Ölçü  Vahidinin Adı";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CRMDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwUnitBindingSource
            // 
            this.vwUnitBindingSource.DataMember = "VwUnit";
            this.vwUnitBindingSource.DataSource = this.dataSet;
            // 
            // vwUnitTableAdapter
            // 
            this.vwUnitTableAdapter.ClearBeforeFill = true;
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 103);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.labelControl2);
            this.MinimumSize = new System.Drawing.Size(515, 142);
            this.Name = "UnitForm";
            this.Text = "Ölçü Vahidləri";
            this.Load += new System.EventHandler(this.UnitForm_Load);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtUnitName, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUnitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Data.CRMDataSet dataSet;
        private System.Windows.Forms.BindingSource vwUnitBindingSource;
        private Data.CRMDataSetTableAdapters.VwUnitTableAdapter vwUnitTableAdapter;
    }
}