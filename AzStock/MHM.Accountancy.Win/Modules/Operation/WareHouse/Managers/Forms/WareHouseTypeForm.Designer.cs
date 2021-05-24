namespace MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms
{
    partial class WareHouseTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseTypeForm));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.adapter = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MHM.Accountancy.Win.Modules.Operation.WareHouse.Data.WareHouseDataSet();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(383, 145);
            this.btnAccept.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(477, 145);
            this.btnCancel.TabIndex = 4;
            // 
            // checkApplyNew
            // 
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 63;
            this.labelControl4.Text = "Qeyd";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(468, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Anbar növü adı";
            // 
            // adapter
            // 
            this.adapter.ClearBeforeFill = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "WareHouseType";
            this.bindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "WareHouseDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(101, 39);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(468, 98);
            this.txtDescription.TabIndex = 2;
            // 
            // WareHouseTypeForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 185);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl2);
            this.MinimumSize = new System.Drawing.Size(590, 139);
            this.Name = "WareHouseTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anbar Növləri";
            this.Load += new System.EventHandler(this.WareHouseTypeForm_Load);
            this.Controls.SetChildIndex(this.checkApplyNew, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Data.WareHouseDataSetTableAdapters.WareHouseTypeTableAdapter adapter;
        private System.Windows.Forms.BindingSource bindingSource;
        private Data.WareHouseDataSet dataSet;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}