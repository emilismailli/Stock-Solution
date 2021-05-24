
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using System;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    partial class MenuCodesManager : MHMManager, IManager
    {
        MenuCodesManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
            bar2.Visible = false;
        }
        
             public override void Loading()
        {
            menuTableAdapter.Fill(dataSet.Menu);

        }
    
        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            //this.MHMContainer.InvokeAction(delegate
            //{
            //    using (var form = new LogisticForm(this, null, OperationType.Add, true))
            //        if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        {
            //            Loading();
            //        }
            //});
        }

        //protected override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    this.MHMContainer.InvokeAction(delegate
        //    {
        //        using (var frm = new CustomerContractForm(this, vwCustomerBindingSource, OperationType.Edit))
        //        {
        //            if (frm.ShowDialog() == DialogResult.OK)
        //                Loading();
        //        }
        //    });
        //}

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var current = vwLogisticBindingSource.GetBindingRow<AccountingDataSet.VwLogisticRow>();

            //if (current == null) return;//gridden secim edilmeyib demek

            //using (var frm = new LogisticForm(this, vwLogisticBindingSource, OperationType.None))
            //{
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        MHMContainer.PrintSuccess(CommonLang.Success);
            //        Loading();
            //    }
            //}
        }

        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

            this.InvokeAction(delegate
            {
                var row = vwLogisticBindingSource.GetBindingRow<AccountingDataSet.VwLogisticRow>();
                if (row != null)
                    using (var report = new LogisticReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@logisticId", row.Id);
                        var ds = (AccountingDataSet)this.dataSet.Clone();
                        this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwLogisticDetail, "select * from [Accounting].[IFnLogisticDetailReport](@logisticId)", Parameters, true, System.Data.CommandType.Text);
                        for (int i = 0; i < dataSet.VwLogistic.Rows.Count; i++)
                        {
                            var item = (AccountingDataSet.VwLogisticRow)dataSet.VwLogistic.Rows[i];
                            if (item.Id == row.Id)
                                ds.VwLogistic.ImportRow(item);
                        }
                        report.DataSource = ds;
                        report.Parameters.Clear();
                        report.Parameters.AddRange(new[]
                        {
                       new DevExpress.XtraReports.Parameters.Parameter(){Name="rowId",Value=string.Format("{0}",row.Id),Visible=false},
                             new DevExpress.XtraReports.Parameters.Parameter(){Name="docDate",Value=DateTime.Now,Description="Sənəd tarixi"}
                    });
                        report.RequestParameters = false;
                        using (var print = new ReportRibbonForm(this, report, true))
                            print.ShowDialog();

                    }
            });
            }
        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var row = vwLogisticBindingSource.GetBindingRow<AccountingDataSet.VwLogisticRow>();

            //if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            //{
            //    Parameters.Clear();
            //    Parameters.Add("@operationType", OperationType.DeleteWithSelect)
            //    .Add("@id", row.Id);

            //    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwCustomer, "[Accounting].[spLogisticDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);
            //    Loading();
            //}

        }
  
        private void gridViewContract_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }




    }
}
