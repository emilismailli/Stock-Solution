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
    public partial class PriceViewManager : MHMManager,IManager
    {
        AccountingDataSet temp;
        PriceViewManager(IContainer container, int managerId)
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
            Parameters.Clear();
            Parameters.Add("@menuId", managerId);
            MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDeficitGoodStock, "[Accounting].[spDeficitStock]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }

        private void gridViewStock_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
            var row = vwDeficitGoodStockBindingSource.GetBindingRow<AccountingDataSet.VwDeficitGoodStockRow>();
            //permission = PermissionInManager;
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

            

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            Loading();
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new DeficitStockReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.VwDeficitGoodStock.Clear();

                var selectedIndexes = gridViewStock.GetSelectedRows();
                selectedIndexes.Select(r => gridViewStock.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwDeficitGoodStock.ImportRow(row);
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

        private void btnPrintPrices_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new DeficitStockReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.VwDeficitGoodStock.Clear();

                var selectedIndexes = gridViewStock.GetSelectedRows();
                selectedIndexes.Select(r => gridViewStock.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwDeficitGoodStock.ImportRow(row);
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
    }
}
