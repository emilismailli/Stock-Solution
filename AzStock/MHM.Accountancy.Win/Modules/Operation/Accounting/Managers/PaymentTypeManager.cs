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
     public  partial class PaymentTypeManager : MHMManager,IManager
     {
         PaymentTypeManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
        }
        
        public void Loading()
        {
            vwPaymentTypeTableAdapter.Fill(dataSet.VwPaymentType);
        }





        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new PaymentTypeForm(this, null, OperationType.Add, true))
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
            var current = vwPaymentTypeBindingSource.GetBindingRow<AccountingDataSet.VwPaymentTypeRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new PaymentTypeForm(this, vwPaymentTypeBindingSource, OperationType.Edit))
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
            var current = vwPaymentTypeBindingSource.GetBindingRow<AccountingDataSet.VwPaymentTypeRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                vwPaymentTypeTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwPaymentTypeBindingSource.GetBindingRow<AccountingDataSet.VwPaymentTypeRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new PaymentTypeForm(this, vwPaymentTypeBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

   

        private void gridViewPaymentType_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }

     
    }
}
