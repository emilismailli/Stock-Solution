namespace MHM.Accountancy.Win
{
    partial class GoToMenuForm
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
            this.btnGoToMenu = new DevExpress.XtraEditors.ButtonEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnGoToMenu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToMenu.EditValue = "";
            this.btnGoToMenu.Location = new System.Drawing.Point(0, 0);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnGoToMenu.Properties.Appearance.Options.UseFont = true;
            this.btnGoToMenu.Properties.Appearance.Options.UseTextOptions = true;
            this.btnGoToMenu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.btnGoToMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.btnGoToMenu.Properties.HideSelection = false;
            this.btnGoToMenu.Properties.Mask.BeepOnError = true;
            this.btnGoToMenu.Properties.Mask.EditMask = "[0-9]*";
            this.btnGoToMenu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.btnGoToMenu.Properties.MaxLength = 6;
            this.btnGoToMenu.Properties.NullText = "Menyu kodunu daxil edin";
            this.btnGoToMenu.Size = new System.Drawing.Size(315, 32);
            this.btnGoToMenu.TabIndex = 0;
            this.btnGoToMenu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnGoToMenu_ButtonClick);
            this.btnGoToMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGoToMenu_KeyDown);
            // 
            // GoToMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 33);
            this.Controls.Add(this.btnGoToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoToMenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToMenuForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnGoToMenu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.ButtonEdit btnGoToMenu;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}