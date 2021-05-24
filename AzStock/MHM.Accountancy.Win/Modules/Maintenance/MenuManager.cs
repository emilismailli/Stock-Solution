using System.Collections.Generic;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Interfaces;

namespace MHM.Accountancy.Win.Modules.Maintenance
{
    public partial class MenuManager : XtraUserControl, IManager
    {
        IContainer container;
        MenuManager(IContainer container, int managerId)
        {
            InitializeComponent();
            this.container = container;
        }

        public int Id => throw new System.NotImplementedException();

        public bool IsFiltered => throw new System.NotImplementedException();

        public int? DocSeriesId => throw new System.NotImplementedException();

        public int? DocCertId => throw new System.NotImplementedException();

        public int? DocTypeId => throw new System.NotImplementedException();

        public List<SqlParameter> Parameters => throw new System.NotImplementedException();

        public IContainer MHMContainer => throw new System.NotImplementedException();

        public void ExportToExcel()
        {
            throw new System.NotImplementedException();
        }

        public void Loading()
        {
            //throw new System.NotImplementedException();
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            container.PrintSuccess("Her sey okeydi deyesen");
        }
    }
}
