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
    partial class SaleManager : MHMManager, IManager
    {


        private string printerName = "Aclas Printer";
        SaleManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();


           
        }

      
        public override void Loading()
        {
            Parameters.Clear();
                Parameters.Add("@operationType", OperationType.Select)
                    .Add("@menuId", managerId);
                

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spDocumentSale, "[Accounting].[spDocumentSale]", Parameters, true, System.Data.CommandType.StoredProcedure);

        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
             {
                 using (var form = new SaleForm(this, null, OperationType.Add, true))
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
                using (var frm = new SaleForm(this, spDocumentSaleBindingSource, OperationType.Edit, true))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        Loading();
                }
            });
        }


        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = spDocumentSaleBindingSource.GetBindingRow<AccountingDataSet.spDocumentSaleRow>();
 
            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new SaleForm(this, spDocumentSaleBindingSource, OperationType.None))
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
            var row = spDocumentSaleBindingSource.GetBindingRow<AccountingDataSet.spDocumentSaleRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {


                 Parameters.Clear();
                 Parameters.Add("@operationType", OperationType.Delete)
                .Add("@wareHouseId", row.WareHouseId)
                .Add("@menuId", managerId)
                .Add("@id", row.Id);

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spDocumentSale, "[Accounting].[spDocumentSale]", Parameters, true, System.Data.CommandType.StoredProcedure);
                Loading();
            }
        }

       
        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {

            this.InvokeAction(delegate {
                var row = spDocumentSaleBindingSource.GetBindingRow<AccountingDataSet.spDocumentSaleRow>();
                if (row != null)
                    using (var report = new SaleReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var ds = (AccountingDataSet)this.dataSet.Clone();
                        this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwDocumentDetail, "select * from [Accounting].[IFnDocumentDetailReport](@documentId)", Parameters, true, System.Data.CommandType.Text);
                        for (int i = 0; i < dataSet.spDocumentSale.Rows.Count; i++)
                        {
                            var item = (AccountingDataSet.spDocumentSaleRow)dataSet.spDocumentSale.Rows[i];
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

        protected override void btnPosPrinter_ItemClick(object sender, ItemClickEventArgs e)
        {

            this.InvokeAction(delegate {
                var row = spDocumentSaleBindingSource.GetBindingRow<AccountingDataSet.spDocumentSaleRow>();
                if (row != null)
                    using (var report = new PostSaleReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var ds = (AccountingDataSet)this.dataSet.Clone();
                        this.MHMContainer.CurrentUser.ExecuteProcedure(ds.VwDocumentDetail, "select * from [Accounting].[IFnDocumentDetailReport](@documentId)", Parameters, true, System.Data.CommandType.Text);
                        for (int i = 0; i < dataSet.spDocumentSale.Rows.Count; i++)
                        {
                            var item = (AccountingDataSet.spDocumentSaleRow)dataSet.spDocumentSale.Rows[i];
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

      

        private void gridViewSale_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }


        protected override void btnApplyDocument_ItemClick(object sender,DevExpress.XtraBars. ItemClickEventArgs e)
        {

                var row = vwDocumentBindingSource.GetBindingRow<AccountingDataSet.VwDocumentRow>();

                if (row != null && row.IsLockIdNull() && row.IsDeleteIdNull() && MHMMessage.ShowQuestionMessageBox("Sənəd təsdiqlənsin?") == System.Windows.Forms.DialogResult.OK)
                {

                    gridViewSale.LoadData(delegate
                    {
                        Parameters.Clear();
                        Parameters.Add("@operationType", OperationType.LockWithSelect)
                        .Add("@wareHouseId", row.WareHouseId)
                        .Add("@menuId", managerId)
                        .Add("@id", row.Id);
                        if (DocCertId.HasValue) Parameters.Add("@docCertId", DocCertId.Value);

                        MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocument, "[Accounting].[spDocumentSale]", Parameters, true, System.Data.CommandType.StoredProcedure);
                    });

                }
          
        }

    }
}
