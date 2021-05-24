
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
    partial class OfflineNewSaleManager : MHMManager, IManager
    {
        OfflineNewSaleManager(IContainer container, int managerId)
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
                Parameters.Add("@operationType", OperationType.Select);
                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwOfflineSale, "[Accounting].[spOfflineSaleDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);

            };
        }
        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var form = new OfflineNewSaleForm(this, null, OperationType.Add, true))
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Loading();
                    }
            });
        }

        protected override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var frm = new OfflineNewSaleForm(this, vwOfflineSaleBindingSource, OperationType.Edit))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        Loading();
                }
            });
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwOfflineSaleBindingSource.GetBindingRow<AccountingDataSet.VwOfflineSaleRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new OfflineNewSaleForm(this, vwOfflineSaleBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }
        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.InvokeAction(delegate
            {
                var row = vwOfflineSaleBindingSource.GetBindingRow<AccountingDataSet.VwOfflineSaleRow>();
                if (row != null)
                    using (var report = new OfflineSaleReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@OfflineSaleId", row.Id);
                        var ds = (AccountingDataSet)this.dataSet.Clone();
                        this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwOfflineSaleDetail, "select * from [Accounting].[IFnOfflineSaleDetailReport](@logisticId)", Parameters, true, System.Data.CommandType.Text);
                        for (int i = 0; i < dataSet.VwOfflineSale.Rows.Count; i++)
                        {
                            var item = (AccountingDataSet.VwOfflineSaleRow)dataSet.VwOfflineSale.Rows[i];
                            if (item.Id == row.Id)
                                ds.VwOfflineSale.ImportRow(item);
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
            var row = vwOfflineSaleBindingSource.GetBindingRow<AccountingDataSet.VwOfflineSaleRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {
                Parameters.Clear();
                Parameters.Add("@operationType", OperationType.Delete)
                .Add("@id", row.Id);

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwOfflineSale, "[Accounting].[spOfflineSaleDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);
                Loading();
            }

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
