using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using MHM.Accountancy.Business.Infrastructure.Identity;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class IncludeReportManager : MHMManager, IManager
    {

        //AccountingDataSet temp;
        IncludeReportManager(IContainer container, int managerId)
          : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
            bar2.Visible = false;
        }
        public override void Loading()
        {

            vwIncludeReportTableAdapter.Fill(accountingDataSet.VwIncludeReport);
            //this.InvokeAction(delegate
            //{
            //    if (!erpDateEdit1.Validate()
            //        || !erpDateEdit2.Validate())
            //        return;

            //    Parameters.Clear();
            //    Parameters.Add("@beginDate", erpDateEdit1.DateTime)
            //          Parameters.Add("@endDate", erpDateEdit2.DateTime);

            //    if (erpLookUpEdit1.EditValue != null)
            //        Parameters.Add("@contractId", erpLookUpEdit1.EditValue);

            //    if (erpLookUpEdit2.EditValue != null)
            //        Parameters.Add("@wareHouseId", erpLookUpEdit2.EditValue);



            //MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spReportMoneyCirculation, "[Accounting].[spReportMoneyCirculation]", Parameters, true, /*System.Data.CommandType.StoredProcedure);*/


            //});
        }



            private void btnSearchReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
             //   Loading();
            }

            private void erpLookUpEdit2_EditValueChanged(object sender, EventArgs e)
            {
                //txtContractId.EditValue = "";
                //if (erpLookUpEdit2.EditValue == null) return;
                //var current = accountingDataSet.VwIncludeContractChoose.FirstOrDefault(icc => icc.ContractId == erpLookUpEdit2.GetIntValue());

                //if (current == null) return;
                //txtContractId.EditValue = current.ContractId;
            }

            private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                //var row = spReportMoneyCirculationBindingSource.GetBindingRow<AccountingDataSet.spReportMoneyCirculationRow>();


                btnSearchReport.Enabled = e.FocusedRowHandle >= 0;
                btnPrintReport.Enabled = e.FocusedRowHandle >= 0;
            }

            private void btnPrintReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                //this.InvokeAction(delegate
                //{
                //    var report = new MoneyCirculationReport();

                //    //VwSearch
                //    if (temp == null)
                //        temp = (AccountingDataSet)accountingDataSet.Clone();
                //    else
                //        temp.VwSearch.Clear();

                //    var selectedIndexes = gridViewDetail1.GetSelectedRows();

                //    selectedIndexes.Select(r => gridViewDetail1.GetDataRow(r)).ToList()
                //    .ForEach(row => {
                //        temp.spReportMoneyCirculation.ImportRow(row);
                //    });

                //    report.Parameters.Clear();
                //    report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
                //    {
                //        Name = "documentDate",
                //        Value = string.Format("{0:dd.MM.yyyy} - {1:dd.MM.yyyy}", erpDateEdit1.DateTime, erpDateEdit2.DateTime)
                //    });
                //    report.DataSource = temp;

                //    using (var print = new ReportRibbonForm(this, report))
                //    {
                //        print.ShowDialog();
                //    }

                //});
            }
        }
    }