namespace MHM.Accountancy.Business.Infrastructure
{
    partial class MHMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MHMForm));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.checkApplyNew = new DevExpress.XtraEditors.CheckEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintDocument = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(290, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "İmtina Et";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.ImageOptions.Image")));
            this.btnAccept.Location = new System.Drawing.Point(198, 164);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(88, 34);
            this.btnAccept.TabIndex = 13;
            this.btnAccept.Text = "Təsdiqlə";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // checkApplyNew
            // 
            this.checkApplyNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkApplyNew.Location = new System.Drawing.Point(12, 171);
            this.checkApplyNew.Name = "checkApplyNew";
            this.checkApplyNew.Properties.Caption = "Yenisi üçün açıq qalsın";
            this.checkApplyNew.Size = new System.Drawing.Size(129, 19);
            this.checkApplyNew.TabIndex = 15;
            this.checkApplyNew.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(382, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 34);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Silinmə";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.ImageOptions.Image")));
            this.btnPrintDocument.Location = new System.Drawing.Point(474, 164);
            this.btnPrintDocument.Name = "btnPrintDocument";
            this.btnPrintDocument.Size = new System.Drawing.Size(88, 34);
            this.btnPrintDocument.TabIndex = 17;
            this.btnPrintDocument.Text = "Çap Et";
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // MHMForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(567, 203);
            this.Controls.Add(this.btnPrintDocument);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.checkApplyNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MHMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MHMForm";
            this.Load += new System.EventHandler(this.MHMForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkApplyNew.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected DevExpress.XtraEditors.SimpleButton btnAccept;
        protected DevExpress.XtraEditors.SimpleButton btnCancel;
        protected DevExpress.XtraEditors.CheckEdit checkApplyNew;
        protected DevExpress.XtraEditors.SimpleButton btnDelete;
        protected DevExpress.XtraEditors.SimpleButton btnPrintDocument;
    }
}