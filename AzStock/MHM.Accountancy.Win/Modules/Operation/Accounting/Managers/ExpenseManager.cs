
using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class ExpenseManager : MHMManager,IManager
    {
        ExpenseManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
        }
        public override void Loading()
        {
            vwExpenseTableAdapter.Fill(dataSet.VwExpense);
            //    Parameters.Clear();
            //    Parameters.Add("@operationType", OperationType.Select);
            //    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwAccount, "[Accounting].[spAccount]", Parameters, true, System.Data.CommandType.StoredProcedure);
            //
        }

        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new ExpenseForm(this, null, OperationType.Add, true))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwExpenseBindingSource.GetBindingRow<AccountingDataSet.VwExpenseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new ExpenseForm(this, vwExpenseBindingSource, OperationType.Edit))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }



        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwExpenseBindingSource.GetBindingRow<AccountingDataSet.VwExpenseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new ExpenseForm(this, vwExpenseBindingSource, OperationType.None))
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
            var row = vwExpenseBindingSource.GetBindingRow<AccountingDataSet.VwExpenseRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmek istediyinizden eminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {
               

                    Parameters.Clear();
                    Parameters.Add("@operationType", OperationType.Delete)
                    .Add("@id", row.Id);

                    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwExpense, "[Accounting].[spExpense]", Parameters, true, System.Data.CommandType.StoredProcedure);

                Loading();
            }
        }

        AccountingDataSet.VwExpenseRow selectedRow;

    
        private void treeList1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }

    }
}
