namespace MHM.Accountancy.Win
{
    partial class OneByOneSaleForm
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
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalQuantity = new DevExpress.XtraEditors.TextEdit();
            this.txtSaleQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(221, 71);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 31);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Təsdiqlə";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(316, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İmtina Et";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Satılan Say";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Location = new System.Drawing.Point(98, 12);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Properties.AutoHeight = false;
            this.txtTotalQuantity.Size = new System.Drawing.Size(310, 22);
            this.txtTotalQuantity.TabIndex = 1;
            // 
            // txtSaleQuantity
            // 
            this.txtSaleQuantity.Location = new System.Drawing.Point(98, 40);
            this.txtSaleQuantity.Name = "txtSaleQuantity";
            this.txtSaleQuantity.Properties.AutoHeight = false;
            this.txtSaleQuantity.Size = new System.Drawing.Size(310, 21);
            this.txtSaleQuantity.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ümumi Say";
            // 
            // OneByOneSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 114);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSaleQuantity);
            this.Controls.Add(this.txtTotalQuantity);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OneByOneSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OneByOneSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleQuantity.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotalQuantity;
        private DevExpress.XtraEditors.TextEdit txtSaleQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}