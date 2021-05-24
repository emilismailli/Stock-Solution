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
    public partial class InventorManager : MHMManager,IManager
    {
        //AccountingDataSet temp;
        InventorManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
    
            Loading();
        }



        //public void Loading()
        //{
        //    Parameters.Clear();
        //    Parameters.Add("@operationType", OperationType.Select);


        //    MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwInventar, "[Accounting].[spDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);
        //}

        public         void Loading()
        {
            //Parameters.Clear();
            //Parameters.Add("@menuId", managerId);
             vwInventarTableAdapter.Fill(accountingDataSet.VwInventar);

            //MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spInventar, "[dbo].[spDocumentInventarSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);

        }


      

        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var form = new InventarForm(this, null, OperationType.Add))


                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Loading();
                    }
            });
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {



            var current = vwInventarBindingSource.GetBindingRow<AccountingDataSet.VwInventarRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new InventorForm(this, vwInventarBindingSource, OperationType.Select))
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
            //var row = spDocumentInventarSelectBindingSource.GetBindingRow<AccountingDataSet.spDocumentInventarSelectRow>();

            //if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            //{


            //    Parameters.Clear();
            //    Parameters.Add("@operationType", OperationType.Delete)
            //        .Add("@menuId", managerId)
            //    //.Add("@wareHouseId",1)
            //    .Add("@documentInventarId", row.Id);

            //    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spInventar, "[Accounting].[spInventar]", Parameters, true, System.Data.CommandType.StoredProcedure);


            //    Loading();
            //}

        }


        protected override void btnPrint_ItemClick(object sender, ItemClickEventArgs e)


        {
            //this.InvokeAction(delegate
            //{
            //    var row = vwInventarBindingSource.GetBindingRow<AccountingDataSet.VwInventarRow>();
            //    if (row != null)
            //        using (var report = new InventarReport())
            //        {
            //            Parameters.Clear();
            //            Parameters.Add("@documentInventarId", row.Id);
            //            var ds = (AccountingDataSet)this.dataSet.Clone();
            //            this.MHMContainer.CurrentUser.ExecuteProcedure(ds.Inventar, "select * from [Accounting].[IFnInventarGood](@documentInventarId)", Parameters, true, System.Data.CommandType.Text);
            //            for (int i = 0; i < dataSet.spDocumentInventarSelect.Rows.Count; i++)
            //            {
            //                var item = (AccountingDataSet.VwInventarRow)dataSet.spDocumentInventarSelect.Rows[i];
            //                if (item.Id == row.Id)
            //                    ds.spDocumentInventarSelect.ImportRow(item);
            //            }
            //            report.DataSource = ds;
            //            report.Parameters.Clear();
            //            report.Parameters.AddRange(new[]
            //            {
            //           new DevExpress.XtraReports.Parameters.Parameter(){Name="rowId",Value=string.Format("{0}",row.Id),Visible=false},
            //                 new DevExpress.XtraReports.Parameters.Parameter(){Name="docDate",Value=DateTime.Now,Description="Sənəd tarixi"}
            //        }
            //            );
            //            report.RequestParameters = false;
            //            using (var print = new ReportRibbonForm(this, report, true))
            //                print.ShowDialog();
            //        }
            //});
        }

       
    }
}
