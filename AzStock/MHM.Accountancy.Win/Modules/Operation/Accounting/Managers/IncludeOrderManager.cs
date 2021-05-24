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
    public partial class IncludeOrderManager : MHMManager, IManager
    {
        AccountingDataSet temp;
        IncludeOrderManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
            
        }


        public void Loading()
        {

            {
               
                //Parameters.Add("@operationType", OperationType.Select);
                Parameters.Clear();

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spCustomerDebt, "[Accounting].[spCustomerDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);
                vwPaymentIncludeOrderTableAdapter.Fill(dataSet.VwPaymentIncludeOrder);
                //vwCustomerDebtTableAdapter.Fill(dataSet.VwCustomerDebt);
                vwCustomerCreditorTableAdapter.Fill(dataSet.VwCustomerCreditor);
                
            };
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
             {
                 using (var form = new IncludeOrderForm(this, null, OperationType.Add, true))
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
            //var current = vwPaymentIncludeOrderBindingSource.GetBindingRow<AccountingDataSet.VwPaymentIncludeOrderRow>();
 
            //if (current == null) return;//gridden secim edilmeyib demek

            //using (var frm = new IncludeOrderForm(this, vwPaymentIncludeOrderBindingSource, OperationType.None))
            //{
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        MHMContainer.PrintSuccess(CommonLang.Success);
            //        Loading();
            //    }
            //}
        }

        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var row = spPaymentDebtBindingSource.GetBindingRow<AccountingDataSet.spPaymentDebtRow>();

            //if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            //{
            //    Parameters.Clear();
            //    Parameters.Add("@operationType", OperationType.DeleteWithSelect)
            //    .Add("@customerName", row.CustomerName);
            //    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwPaymentIncludeOrder, "[Accounting].[spPaymentDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);
            //    Loading();
            //}
            var current = vwPaymentIncludeOrderBindingSource.GetBindingRow<AccountingDataSet.VwPaymentIncludeOrderRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                vwPaymentIncludeOrderTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }

        }
        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

            this.InvokeAction(delegate
            {
                var report = new OrderReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.VwPayment.Clear();

                var selectedIndexes = gridView1.GetSelectedRows();
                selectedIndexes.Select(r => gridView1.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwPayment.ImportRow(row);
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
    }
}
