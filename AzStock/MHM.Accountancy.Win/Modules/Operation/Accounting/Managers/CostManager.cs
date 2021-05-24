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
using System.Windows.Forms;


namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
     partial class CostManager : MHMManager, IManager
    {
        CostManager(IContainer container, int managerId )
           : base(container, managerId) 
        {
            InitializeComponent();
            //Redesign();

            Loading();
        }


      

        public void Loading()
        {
            vwCostTableAdapter.Fill(dataSet.VwCost);
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new CostForm(this, null, OperationType.Add, true))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }


        protected override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.MHMContainer.InvokeAction(delegate
            //{
            //    using (var frm = new IncludeForm(this, vwDocumentBindingSource, OperationType.Edit, true))
            //    {
            //        if (frm.ShowDialog() == DialogResult.OK)
            //            Loading();
            //    }
            //});
        }


        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {


            var current = vwCostBindingSource.GetBindingRow<AccountingDataSet.VwCostRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new CostForm(this, vwCostBindingSource, OperationType.None))
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
            var current = vwCostBindingSource.GetBindingRow<AccountingDataSet.VwCostRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                vwCostTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }

        }


        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)


        {
            //this.InvokeAction(delegate
            //{
            //    var row = vwCostBindingSource.GetBindingRow<AccountingDataSet.VwCostRow>();
            //    if (row != null)
            //        using (var report = new IncludeReport())
            //        {
            //            Parameters.Clear();
            //            Parameters.Add("@documentId", row.Id);
            //            var ds = (AccountingDataSet)this.dataSet.Clone();
            //            this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwDocumentDetail, "select * from [Accounting].[IFnDocumentDetailReport](@documentId)", Parameters, true, System.Data.CommandType.Text);
            //            for (int i = 0; i < dataSet.VwDocument.Rows.Count; i++)
            //            {
            //                var item = (AccountingDataSet.VwDocumentRow)dataSet.VwDocument.Rows[i];
            //                if (item.Id == row.Id)
            //                    ds.VwDocument.ImportRow(item);
            //            }
            //            report.DataSource = ds;
            //            report.Parameters.Clear();
            //            report.Parameters.AddRange(new[]
            //            {
            //           new DevExpress.XtraReports.Parameters.Parameter(){Name="rowId",Value=string.Format("{0}",row.Id),Visible=false},
            //           new DevExpress.XtraReports.Parameters.Parameter(){Name="docDate",Value=DateTime.Now,Description="Sənəd tarixi"}
            //        });
            //            report.RequestParameters = false;
            //            using (var print = new ReportRibbonForm(this, report, true))
            //                print.ShowDialog();
            //        }
            //});
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
