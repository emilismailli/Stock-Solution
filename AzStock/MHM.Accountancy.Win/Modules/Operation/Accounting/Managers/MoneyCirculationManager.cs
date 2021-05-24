using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Identity;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms;
using MHM.Accountancy.Win.Properties;
using System; 
using System.Data;
using System.Drawing;
using System.Linq;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class MoneyCirculationManager : MHMManager, IManager
    {
        //ManagerPermission permission;
        AccountingDataSet temp;

        MoneyCirculationManager(IContainer container, int managerId)
            : base(container, managerId)
        {
            InitializeComponent();
            //Redesign();
            //Settings.Default["AccountancyConnectionString"] = container.CurrentUser.CurrentConnection.ConnectionString;
            bar2.Visible = false;
             
        }


        public override void Loading()
        {
            this.InvokeAction(delegate
            {
                if (!erpDateEditStartDate.Validate()
                    || !erpDateEditEndDate.Validate())
                    return;

                Parameters.Clear();
                Parameters
                .Add("@beginDate", erpDateEditStartDate.DateTime)
                .Add("@endDate", erpDateEditEndDate.DateTime)
                .Add("@profit", 0, ParameterDirection.Output)
                .Add("@cost", 0, ParameterDirection.Output);
                //.Add("@goodId", erpGridLookUpEdit1.Text)
                //.Add("@customerId", erpGridLookUpEditCustomer.Text)
                //.Add("@accountId", erpGridLookUpEditAccount.Text)




                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spReportMoney4, "[dbo].[spReportMoney4]", Parameters, true, System.Data.CommandType.StoredProcedure);
                decimal profit = Convert.ToDecimal(Parameters.FirstOrDefault(p => p.ParameterName == "@profit").Value);
                decimal cost = Convert.ToDecimal(Parameters.FirstOrDefault(p => p.ParameterName == "@cost").Value);
                //txtProfit.Text = profit.ToString("0.00");
                //txtCost.Text = cost.ToString("0.00");
                //txtSummary.Text = (profit - cost).ToString("0.00");
                //decimal totalcost = Convert.ToDecimal(Parameters.FirstOrDefault(p => p.ParameterName == "TotalCost").Value);
                //decimal totalprofit = Convert.ToDecimal(Parameters.FirstOrDefault(p => p.ParameterName == "TotalProfit").Value);

            });
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new MoneyCirculationReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.spReportMoney4.Clear();
                var selectedIndexes = gridViewMoneyCirculation.GetSelectedRows();
                selectedIndexes.Select(r => gridViewMoneyCirculation.GetDataRow(r)).ToList().ForEach(row =>
                {
                    temp.spReportMoney4.ImportRow(row);
                });

                report.Parameters.Clear();
                report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
                {
                    Name = "documentDate",
                    Value = string.Format("{0:dd.MM.yyyy} - {1:dd.MM.yyyy}", erpDateEditStartDate.DateTime, erpDateEditEndDate.DateTime)
                });
                report.DataSource = temp;
                report.RequestParameters = false;
                using (var print = new ReportRibbonForm(this, report,true))
                {
                    print.ShowDialog();
                }

            });
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //dataSet.spReportMoney4.Clear();
            //txtSummary.Text = String.Empty;
            //txtCost.Text = String.Empty;
            //txtProfit.Text = String.Empty;
            erpDateEditEndDate.EditValue = String.Empty;
            erpDateEditStartDate.EditValue = String.Empty;


        }

        private void gridViewMoneyCirculation_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
            var row = spReportMoney4BindingSource.GetBindingRow<AccountingDataSet.spReportMoney4Row>();
            //permission = PermissionInManager;

            barButtonItem1.Enabled = e.FocusedRowHandle >= 0;
            barButtonItem2.Enabled = e.FocusedRowHandle >= 0;
        }


        private void erpGridLookUpEditGood_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpGridLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new GoodForm(this, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Loading();

                    }
                }
            }
        }

       

        private void ErpDateEditEndDate_EditValueChanged(object sender, EventArgs e)
        {

        }

      

        private void btnStockDeficit_Click(object sender, EventArgs e)
        {

        }

        private void GridViewMoneyCirculation_ColumnFilterChanged(object sender, EventArgs e)
        {
            var filtered = dataSet.spReportMoney4.GetTableByFilter<AccountingDataSet.spReportMoney4DataTable>(gridViewMoneyCirculation.RowFilter, false, "Profit", "Cost");

            var total = from filter in filtered.AsEnumerable()
                        select new
                        {
                            profit = filter.Field<decimal>("Profit"),
                            cost = filter.Field<decimal>("Cost")
                        };

            //txtProfit.Text = total.Sum(x => x.profit).ToString("0.00");
            //txtCost.Text = total.Sum(x => x.cost).ToString("0.00");
            //txtSummary.Text = (total.Sum(x => x.profit) - total.Sum(x => x.cost)).ToString("0.00");
        }

        private void gridControlMoneyCirculation_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loading();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new MoneyCirculationReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.spReportMoney4.Clear();
                var selectedIndexes = gridViewMoneyCirculation.GetSelectedRows();
                selectedIndexes.Select(r => gridViewMoneyCirculation.GetDataRow(r)).ToList().ForEach(row =>
                {
                    temp.spReportMoney4.ImportRow(row);
                });

                report.Parameters.Clear();
                report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter()
                {
                    Name = "documentDate",
                    Value = string.Format("{0:dd.MM.yyyy} - {1:dd.MM.yyyy}", erpDateEditStartDate.DateTime, erpDateEditEndDate.DateTime)
                });
                report.DataSource = temp;
                report.RequestParameters = false;
                using (var print = new ReportRibbonForm(this, report, true))
                {
                    print.ShowDialog();
                }

            });
        }
    }
}


