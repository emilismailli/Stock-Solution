
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
    public partial class AccountManager : MHMManager,IManager
    {
         AccountManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
        }
        public override void Loading()
        {
            vwAccountTableAdapter.Fill(dataSet.VwAccount);
            //    Parameters.Clear();
            //    Parameters.Add("@operationType", OperationType.Select);
            //    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwAccount, "[Accounting].[spAccount]", Parameters, true, System.Data.CommandType.StoredProcedure);
            //
        }

        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new AccountForm(this, null, OperationType.Add, true))
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
            var current = vwAccountBindingSource.GetBindingRow<AccountingDataSet.VwAccountRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new AccountForm(this, vwAccountBindingSource, OperationType.Edit))
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
            var row = vwAccountBindingSource.GetBindingRow<AccountingDataSet.VwAccountRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmek istediyinizden eminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {
               

                    Parameters.Clear();
                    Parameters.Add("@operationType", OperationType.Delete)
                    .Add("@id", row.Id);

                    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwAccount, "[Accounting].[spAccount]", Parameters, true, System.Data.CommandType.StoredProcedure);

                Loading();
            }
        }

        AccountingDataSet.VwAccountRow selectedRow;

    

        private void treeListAccount_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

            selectedRow = vwAccountBindingSource.GetBindingRow<AccountingDataSet.VwAccountRow>();
            //permission = PermissionInManager;

            //btnEdit.Enabled = !treeListAccount.IsAutoFilterNode(e.Node) && UpdateAccess;
            //btnDelete.Enabled = !treeListAccount.IsAutoFilterNode(e.Node) && DeleteAccess;
        }
    }
}
