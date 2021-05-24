using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using System;
using System.Windows.Forms;


namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class IncludeManager : MHMManager, IManager
    {
        IncludeManager(IContainer container, int managerId )//, int docType = 0
           : base(container, managerId) //, !(docType == 1)
        {
            InitializeComponent();
            //Redesign();

            Loading();
        }


      

        public void Loading()
        {
            Parameters.Clear();
            Parameters.Add("@operationType", OperationType.Select)
                    .Add("@menuId", managerId);


            MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spDocument, "[Accounting].[spDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
             {
                 using (var form = new IncludeForm(this, null, OperationType.Add))


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
                using (var frm = new IncludeForm(this, spDocumentBindingSource, OperationType.Edit))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        Loading();
                }
            });
        }


        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = spDocumentBindingSource.GetBindingRow<AccountingDataSet.spDocumentRow>();
            if (current == null) return;//gridden secim edilmeyib demek
            using (var frm = new IncludeForm(this, spDocumentBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }
        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var row = spDocumentBindingSource.GetBindingRow<AccountingDataSet.spDocumentRow>();
            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {
                Parameters.Clear();
                Parameters.Add("@operationType", OperationType.Delete)
                    .Add("@menuId", managerId)
                .Add("@id", row.Id);
                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spDocument, "[Accounting].[spDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);
                Loading();
            }
        }
        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.InvokeAction(delegate
            {
                var row = spDocumentBindingSource.GetBindingRow<AccountingDataSet.spDocumentRow>();
                if (row != null)
                    using (var report = new IncludeReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var ds = (AccountingDataSet)this.dataSet.Clone();
                        this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwDocumentDetail, "select * from [Accounting].[IFnDocumentDetailReport](@documentId)", Parameters, true, System.Data.CommandType.Text);
                        for (int i = 0; i < dataSet.spDocument.Rows.Count; i++)
                        {
                            var item = (AccountingDataSet.spDocumentRow)dataSet.spDocument.Rows[i];
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
  

        private void gridControlInclude_Click(object sender, System.EventArgs e)
        {

        }

        private void gridViewInclude_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //SetEditReadonly(e.FocusedRowHandle < 0);
            //SetRemoveReadonly(e.FocusedRowHandle < 0);
            //SetPrintReadonly(e.FocusedRowHandle < 0);
            //SetShowReadonly(e.FocusedRowHandle < 0);
            //SetApplyDocumentReadonly(e.FocusedRowHandle < 0);

        }
    }
}
