using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using MHM.Accountancy.Win.Properties;
using System.Linq;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class CostReportManager : MHMManager,IManager
    {
        AccountingDataSet temp;
        CostReportManager(IContainer container, int managerId)
            : base(container, managerId)
        {
            InitializeComponent();
            //Redesign();
            bar2.Visible = false;
            //Settings.Default["AccountancyConnectionString"] = container.CurrentUser.CurrentConnection.ConnectionString;
            Loading();

        }

        public  void Loading()
        {
            vwCostTableAdapter.Fill(dataSet.VwCost);
        }

        private void gridViewStock_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
            var row = vwCostBindingSource.GetBindingRow<AccountingDataSet.VwCostRow>();
            //permission = PermissionInManager;
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

            

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new CostReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.VwCost.Clear();

                var selectedIndexes = gridViewCost.GetSelectedRows();
                selectedIndexes.Select(r => gridViewCost.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwCost.ImportRow(row);
                });
                report.Parameters.Clear();


                report.DataSource = temp;
                using (var print = new ReportRibbonForm(this, report))
                {
                    print.ShowDialog();
                }
            });
            MHMMessage.ShowInformationMessageBox("Çap Edildi !"); Loading();
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new CostReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.VwCost.Clear();

                var selectedIndexes = gridViewCost.GetSelectedRows();
                selectedIndexes.Select(r => gridViewCost.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwCost.ImportRow(row);
                });
                report.Parameters.Clear();


                report.DataSource = temp;
                using (var print = new ReportRibbonForm(this, report))
                {
                    print.ShowDialog();
                }
            });
            MHMMessage.ShowInformationMessageBox("Çap Edildi !");
        }

        private void btnPrintCost_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
