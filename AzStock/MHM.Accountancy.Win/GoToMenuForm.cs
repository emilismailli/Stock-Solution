using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using System.Windows.Forms;

namespace MHM.Accountancy.Win
{
    public partial class GoToMenuForm : XtraForm
    {
        public GoToMenuForm()
        {
            InitializeComponent();
        }

        private void btnGoToMenu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Close)
                this.DialogResult = DialogResult.Cancel;
            else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Search && !string.IsNullOrWhiteSpace(btnGoToMenu.Text))
                this.DialogResult = DialogResult.OK;
        }

        private void GoToMenuForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void btnGoToMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
            else if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(btnGoToMenu.Text))
                this.DialogResult = DialogResult.OK;
        }
    }
}
