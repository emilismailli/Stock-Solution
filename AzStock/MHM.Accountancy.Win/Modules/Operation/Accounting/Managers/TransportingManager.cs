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

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class TransportingManager : MHMManager,IManager
    {
        TransportingManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();

            Loading();
        }

   
        public override void Loading()
        {
            Parameters.Clear();
            Parameters.Add("@menuId", managerId)
                .Add("@operationtype",OperationType.Select);


            MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwDocument, "[dbo].[spTransport]", Parameters, true, System.Data.CommandType.StoredProcedure);

        }




        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var form = new TransportForm(this, null, OperationType.Add))


                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Loading();
                    }
            });
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {



            var current = vwDocumentBindingSource.GetBindingRow<AccountingDataSet.VwDocumentRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new TransportForm(this, vwDocumentBindingSource, OperationType.None))
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
            var row = vwDocumentBindingSource.GetBindingRow<AccountingDataSet.VwDocumentRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {


                Parameters.Clear();
                Parameters.Add("@operationType", OperationType.Delete)
                    .Add("@wareHouseId", row.WareHouseId)
                    .Add("@menuId", managerId)
                .Add("@id", row.Id);

                MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwDocument, "[dbo].[spTransport]", Parameters, true, System.Data.CommandType.StoredProcedure);


                Loading();
            }

        }


        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

            this.InvokeAction(delegate
            {
                var row = vwDocumentBindingSource.GetBindingRow<AccountingDataSet.VwDocumentRow>();
                if (row != null)
                    using (var report = new TransportReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var ds = (AccountingDataSet)this.accountingDataSet.Clone();
                        this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwDocumentDetail, "select * from [Accounting].[IFnDocumentDetailReport](@documentId)", Parameters, true, System.Data.CommandType.Text);
                        for (int i = 0; i < accountingDataSet.VwDocument.Rows.Count; i++)
                        {
                            var item = (AccountingDataSet.VwDocumentRow)accountingDataSet.VwDocument.Rows[i];
                            if (item.Id == row.Id)
                                ds.VwDocument.ImportRow(item);
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

        private void erpLookUpEdit1_Properties_EditValueChanged(object sender, System.EventArgs e)
        {

        }
    }

}
