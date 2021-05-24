using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using System;
using System.Linq;
using System.Windows.Forms;



namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class RetailOrderManager : MHMManager, IManager
    {
        AccountingDataSet temp;

        RetailOrderManager(IContainer container, int managerId)
            : base(container, managerId)
        {
            InitializeComponent();
            Loading();
            bar2.Visible = false;

        }

        public void Loading()
        {
            this.vwPaymentRetailTableAdapter.Fill(this.accountingDataSet.VwPaymentRetail);
            //MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spViewLastPrice, "[Accounting].[spViewLastPrice]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new RetailOrderReport();
                if (temp == null)
                    temp = (AccountingDataSet)accountingDataSet.Clone();
                else
                    temp.VwDeficitGoodStock.Clear();

                var selectedIndexes = gridView1.GetSelectedRows();
                selectedIndexes.Select(r => gridView1.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwPaymentRetail.ImportRow(row);
                });
                report.Parameters.Clear();


                report.DataSource = temp;
                using (var print = new ReportRibbonForm(this, report))
                {
                    print.ShowDialog();
                }
            });
            //MHMMessage.ShowInformationMessageBox("Çap Edildi !");
        }

        private void btnPrinter_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new RetailOrderReport();
                if (temp == null)
                    temp = (AccountingDataSet)accountingDataSet.Clone();
                else
                    temp.VwDeficitGoodStock.Clear();

                var selectedIndexes = gridView1.GetSelectedRows();
                selectedIndexes.Select(r => gridView1.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwPaymentRetail.ImportRow(row);
                });
                report.Parameters.Clear();


                report.DataSource = temp;
                using (var print = new ReportRibbonForm(this, report))
                {
                    print.ShowDialog();
                }
            });
        }
    }
}
