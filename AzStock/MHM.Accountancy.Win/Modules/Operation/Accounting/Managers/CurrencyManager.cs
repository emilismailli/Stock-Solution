
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
     partial class CurrencyManager : MHMManager,IManager
    {
         CurrencyManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
        }

        public void Loading()
        {
            vwCurrencyTableAdapter.Fill(dataSet.VwCurrency);
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new CurrencyForm(this, null, OperationType.Add, true))
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
            //var current = vwCurrencyBindingSource.GetBindingRow<AccountingDataSet.VwCurrencyRow>();

            //if (current == null) return;//gridden secim edilmeyib demek

            //using (var frm = new CurrencyForm(this, vwCurrencyBindingSource, OperationType.Edit))
            //{
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        MHMContainer.PrintSuccess(CommonLang.Success);
            //        Loading();
            //    }
            //}
        }

        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwCurrencyBindingSource.GetBindingRow<AccountingDataSet.VwCurrencyRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                vwCurrencyTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwCurrencyBindingSource.GetBindingRow<AccountingDataSet.VwCurrencyRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new CurrencyForm(this, vwCurrencyBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

     

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }

        private void gridViewCurrency_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }
    }
}
