using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class ReturnWholeSaleManager : MHMManager, IManager
    {
        ReturnWholeSaleManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Loading();
        }

      
        public  void Loading()
        {
            Parameters.Clear();
            Parameters.Add("@operationType", OperationType.Select);


            MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocument, "[Accounting].[spDocumentReturnWholeSale]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
             {
                 using (var form = new ReturnWholeSaleForm(this, null, OperationType.Add, true))
                     if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                     {
                         Loading();
                     }
             });
        }


        protected override  void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var frm = new ReturnWholeSaleForm(this, vwDocumentBindingSource, OperationType.Edit, true))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        Loading();
                }
            });
        }


        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwDocumentBindingSource.GetBindingRow<AccountingDataSet.VwDocumentRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new ReturnWholeSaleForm(this, vwDocumentBindingSource, OperationType.None))
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
                .Add("@id", row.Id);

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocument, "[Accounting].[spDocumentReturnWholeSale]", Parameters, true, System.Data.CommandType.StoredProcedure);

                
                Loading();
            }

        }


        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

        //    this.InvokeAction(delegate
        //    {

        //        var row = vwDocumentBindingSource.GetBindingRow<AccountingDataSet.VwDocumentRow>();
        //        if (row != null)
        //            using (var report = new IncludeReport())
        //            {
        //                Parameters.Clear();
        //                Parameters.Add("@goodId", row.Id);

        //                var ds = (AccountingDataSet)this.dataSet.Clone();
        //                this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwDocumentDetail, "select * from [Accounting].[IFnBarcodeGood](@goodId)", Parameters, true, System.Data.CommandType.Text);

        //                for (int i = 0; i < dataSet.VwDocument.Rows.Count; i++)
        //                {
        //                    var item = (AccountingDataSet.VwDocumentRow)dataSet.VwDocument.Rows[i];
        //                    if (item.Id == row.Id)
        //                        ds.VwDocument.ImportRow(item);
        //                }
        //                report.DataSource = ds;

        //                report.Parameters.Clear();
        //                report.Parameters.AddRange(new[]
        //                {
        //                   new DevExpress.XtraReports.Parameters.Parameter(){ Name="docNumber",Value=string.Format("{0} {1}",row.Series,row.Number)},
        //                   new DevExpress.XtraReports.Parameters.Parameter(){Name="docDate",Value=(row.DocumentDate as DateTime?).DateToText()}
        //                });
        //                using (var print = new ReportForm(this, report))
        //                    print.ShowDialog();
        //            }
        //    });

        }
        protected override void btnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridViewWholeSaleReturn.OptionsView.ShowAutoFilterRow = !gridViewWholeSaleReturn.OptionsView.ShowAutoFilterRow;
        }

        private void gridControlInclude_Click(object sender, System.EventArgs e)
        {

        }
    }
}
