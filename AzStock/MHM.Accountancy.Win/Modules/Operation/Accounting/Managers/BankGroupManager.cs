
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
     partial class BankGroupManager : MHMManager,IManager
    {
         BankGroupManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
        }

        public override void Loading()
        {
            bankGroupTableAdapter.Fill(dataSet.BankGroup);
        }
        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new BankGroupForm(this, null, OperationType.Add, true))
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
            var current = bankGroupBindingSource.GetBindingRow<AccountingDataSet.BankGroupRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new BankGroupForm(this, bankGroupBindingSource, OperationType.Edit))
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
            var current = bankGroupBindingSource.GetBindingRow<AccountingDataSet.BankGroupRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                bankGroupTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = bankGroupBindingSource.GetBindingRow<AccountingDataSet.BankGroupRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new BankGroupForm(this, bankGroupBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

     
        private void gridViewGroup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }

        private void gridViewBankGroup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }
    }
}
