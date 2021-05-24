using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using System.Windows.Forms;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Business.Properties; 
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using System;
using System.Linq;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class TransferMoneyManager : MHMManager, IManager
    {
        AccountingDataSet temp;
        TransferMoneyManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
            
        }


        public void Loading()
        {

            {
               
    
                Parameters.Clear();

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spCustomerDebt, "[Accounting].[spCustomerDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);
                vwPaymentTransferTableAdapter.Fill(accountingDataSet.VwPaymentTransfer);
                //vwCustomerDebtTableAdapter.Fill(dataSet.VwCustomerDebt);
                vwCashTableAdapter.Fill(dataSet.VwCash);
                
            };
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
             {
                 using (var form = new TransferMoneyForm(this, null, OperationType.Add, true))
                     if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                     {
                         Loading();
                     }
             });
        }


        //protected override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    this.MHMContainer.InvokeAction(delegate
        //    {
        //        using (var frm = new IncludeOrderForm(this, vwPaymentBindingSource, OperationType.Edit, true))
        //        {
        //            if (frm.ShowDialog() == DialogResult.OK)
        //                Loading();
        //        }
        //    });
        //}


        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwPaymentBindingSource.GetBindingRow<AccountingDataSet.spIncludeOrderRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new TransferMoneyForm(this, vwPaymentBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var row = .GetBindingRow<AccountingDataSet.spIncludeOrderRow>();

            //if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            //{
            //    Parameters.Clear();
            //    Parameters.Add("@operationType", OperationType.DeleteWithSelect)
            //    .Add("@customerName", row.CustomerName);
            //    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocument, "[Accounting].[spDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);
            //    Loading();
            //}

        }
        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

            this.InvokeAction(delegate
            {
                var report = new CashTransport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.VwPaymentTransfer.Clear();

                var selectedIndexes = gridViewPaymentMoneyTransport.GetSelectedRows();
                selectedIndexes.Select(r => gridViewPaymentMoneyTransport.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwPaymentTransfer.ImportRow(row);
                });
                report.DataSource = temp;
                report.Parameters.Clear();
                report.Parameters.AddRange(new[]
                    {
                       //new DevExpress.XtraReports.Parameters.Parameter(){Name="docNumber",Value=string.Format("{0}"),Visible=false},
                       new DevExpress.XtraReports.Parameters.Parameter(){Name="docDate",Value=DateTime.Now,Description="Sənəd tarixi"}
                    });
                report.RequestParameters = false;
                using (var print = new ReportRibbonForm(this, report))
                    print.ShowDialog();

            });


        }

        private void gridViewOrder_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
