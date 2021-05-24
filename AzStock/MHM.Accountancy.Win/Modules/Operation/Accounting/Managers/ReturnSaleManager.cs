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
     public partial class ReturnSaleManager : MHMManager,IManager
    {
           ReturnSaleManager(IContainer container, int managerId)
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
                Parameters.Add("@operationType", OperationType.Select)
                    .Add("@menuId", managerId);
                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spDocumentSaleReturn, "[Accounting].[spDocumentSaleReturn]", Parameters, true, System.Data.CommandType.StoredProcedure);

            };
        }



        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var form = new ReturnSaleForm(this, null, OperationType.Add, true))
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
        //        using (var frm = new ReturnSaleForm(this, vwDocumentReturnSaleBindingSource, 
        //            OperationType.Edit, true))            
        //        {
        //            if (frm.ShowDialog() == DialogResult.OK)
        //                Loading();
        //        }
        //    });
        //}


        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = spDocumentSaleReturnBindingSource.GetBindingRow<AccountingDataSet.spDocumentSaleReturnRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new ReturnSaleForm(this, spDocumentSaleReturnBindingSource, OperationType.None))
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
            var row = spDocumentSaleReturnBindingSource.GetBindingRow<AccountingDataSet.spDocumentSaleReturnRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {


                Parameters.Clear();
                Parameters.Add("@operationType", OperationType.Delete)
                    .Add("@wareHouseId", row.WareHouseId)
                    .Add("@menuId", managerId)
                .Add("@id", row.Id);

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spDocumentSaleReturn, "[Accounting].[spDocumentSaleReturn]", Parameters, true, System.Data.CommandType.StoredProcedure);


                Loading();
            }

        }


        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.InvokeAction(delegate {
                var row = spDocumentSaleReturnBindingSource.GetBindingRow<AccountingDataSet.spDocumentSaleReturnRow>();
                if (row != null)
                    using (var report = new ReturnSaleReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var ds = (AccountingDataSet)this.dataSet.Clone();
                        this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwDocumentDetail, "select * from [Accounting].[IFnDocumentDetailReport](@documentId)", Parameters, true, System.Data.CommandType.Text);
                        for (int i = 0; i < dataSet.spDocumentSaleReturn.Rows.Count; i++)
                        {
                            var item = (AccountingDataSet.spDocumentSaleReturnRow)dataSet.spDocumentSaleReturn.Rows[i];
                            if (item.Id == row.Id)
                                ds.VwDocumentReturnSale.ImportRow(item);
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
      

    

        private void gridViewDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }
    }
}
