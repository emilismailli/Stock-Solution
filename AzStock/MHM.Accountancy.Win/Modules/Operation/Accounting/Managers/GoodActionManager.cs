 
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using System;
using System.Collections.Generic; 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class GoodActionManager : MHMManager,IManager
    {
        AccountingDataSet temp;
          GoodActionManager(IContainer container, int managerId)
            : base(container, managerId)
        {
            InitializeComponent();
            //Redesign();
            bar2.Visible = false;
            //Settings.Default["AccountancyConnectionString"] = container.CurrentUser.CurrentConnection.ConnectionString;
            Loading();

        }
        public void Loading()
        {
            vwGoodActionTableAdapter.Fill(dataSet.VwGoodAction); 
        }

        private void gridViewGoodAction_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
            var row = vwGoodActionBindingSource.GetBindingRow<AccountingDataSet.VwGoodActionRow>();
            //permission = PermissionInManager;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //this.InvokeAction(delegate
            //{
            //    var report = new GoodActionReport();
            //    if (temp == null)
            //        temp = (AccountingDataSet)dataSet.Clone();
            //    else
            //        temp.VwDeficitGoodStock.Clear();

            //    var selectedIndexes = gridViewGoodAction.GetSelectedRows();
            //    selectedIndexes.Select(r => gridViewGoodAction.GetDataRow(r)).ToList()

            //    .ForEach(row =>
            //    {
            //        temp.VwGoodAction.ImportRow(row);
            //    });
            //    report.Parameters.Clear();


            //    report.DataSource = temp;
            //    using (var print = new ReportRibbonForm(this, report))
            //    {
            //        print.ShowDialog();
            //    }
            //});
        }

        private void btnDocPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.InvokeAction(delegate
            {
                var report = new GoodActionReport();
                if (temp == null)
                    temp = (AccountingDataSet)dataSet.Clone();
                else
                    temp.VwDeficitGoodStock.Clear();

                var selectedIndexes = gridViewGoodAction.GetSelectedRows();
                selectedIndexes.Select(r => gridViewGoodAction.GetDataRow(r)).ToList()

                .ForEach(row =>
                {
                    temp.VwGoodAction.ImportRow(row);
                });
                report.Parameters.Clear();


                report.DataSource = temp;
                using (var print = new ReportRibbonForm(this, report))
                {
                    print.ShowDialog();
                }
            });
        }
    }
}
