using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using System.Windows.Forms;

namespace MHM.Accountancy.Win
{
    public partial class ManagerForm : XtraForm
    {
        XtraTabPage currentTab;
        public ManagerForm(XtraTabPage currentTab)
        {
            InitializeComponent();
            this.currentTab = currentTab;
        }

        private void ManagerForm_Load(object sender, System.EventArgs e)
        {

            // IManager manager,
            if (currentTab == null || currentTab.Controls.Count <= 0)
            {
                Problem();
                return;
            }

            var manager = (XtraUserControl)currentTab.Controls[0];
            if (manager == null)
                return;

            manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(manager);
            this.Text = currentTab.Text;

            currentTab.PageVisible = false;
            (manager as IManager).Loading();

        }

        void Problem()
        {
            MHMMessage.ShowErrorMessageBox("Yeni formda göstərmək mümkün olmadı.");
            this.Close();
        }

        private void ManagerForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (currentTab != null)
            {
                currentTab.PageVisible = true;
                currentTab.Controls.Clear();
                var manager = (XtraUserControl)this.Controls[0];
                if (manager == null)
                    return;

                manager.Dock = DockStyle.Fill;
                currentTab.Controls.Add(manager);
                (manager as MHMManager).Loading();
            }
        }

        private void ManagerForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            //this.Dispose();
        }
    }
}