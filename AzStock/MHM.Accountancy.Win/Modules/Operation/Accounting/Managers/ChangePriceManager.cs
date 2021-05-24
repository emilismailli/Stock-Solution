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
    public partial class ChangePriceManager : MHMManager, IManager
    {
        AccountingDataSet temp;
        ChangePriceManager(IContainer container, int managerId)
            : base(container, managerId)
        {
            InitializeComponent();
            Loading();
            

        }
        public void Loading()
        {
            Parameters.Clear();
            this.vwLastPriceTableAdapter.Fill(this.accountingDataSet.VwLastPrice);
            
        }
        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var form = new ChangedPriceForm(this, null, OperationType.Add, true))
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Loading();
                    }
            });
        }

        private void gridViewStock_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //SetEditReadonly(e.FocusedRowHandle < 0);
            //SetRemoveReadonly(e.FocusedRowHandle < 0);
            //SetPrintReadonly(e.FocusedRowHandle < 0);
            //SetShowReadonly(e.FocusedRowHandle < 0);
            //SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
            //var row = vwDeficitGoodStockBindingSource.GetBindingRow<AccountingDataSet.VwDeficitGoodStockRow>();
            ////permission = PermissionInManager;
        }

        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new ChangePriceReport();
                if (temp == null)
                    temp = (AccountingDataSet)accountingDataSet.Clone();
                else
                    temp.spReportMoney4.Clear();
                var selectedIndexes = gridView1.GetSelectedRows();
                selectedIndexes.Select(r => gridView1.GetDataRow(r)).ToList().ForEach(row =>
                {
                    temp.VwLastPrice.ImportRow(row);
                });

                report.Parameters.Clear();
                //report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
                //{
                //    Name = "documentDate",
                //    Value = string.Format("{0:dd.MM.yyyy} - {1:dd.MM.yyyy}", erpDateEditStartDate.DateTime, erpDateEditEndDate.DateTime)
                //});
                report.DataSource = temp;
                report.RequestParameters = false;
                using (var print = new ReportRibbonForm(this, report, true))
                {
                    print.ShowDialog();
                }
            });

        }
        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {



            var current = vwDocumentBindingSource.GetBindingRow<AccountingDataSet.VwDocumentRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new ChangedPriceForm(this, vwDocumentBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }


            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            Loading();
        }


       
    }
}
