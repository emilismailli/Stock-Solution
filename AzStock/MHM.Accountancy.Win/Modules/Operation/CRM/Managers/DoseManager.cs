using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    public partial class DoseManager : MHMManager,IManager
    {
         DoseManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Loading();
        }

        public void Loading()
        {
            vwDoseTableAdapter.Fill(dataSet.VwDose);
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new DoseForm(this, null, OperationType.Add, true))
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
            var current = vwDoseBindingSource.GetBindingRow<CRMDataSet.VwDoseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new DoseForm(this, vwDoseBindingSource, OperationType.Edit))
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
            var current = vwDoseBindingSource.GetBindingRow<CRMDataSet.VwDoseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                vwDoseTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwDoseBindingSource.GetBindingRow<CRMDataSet.VwDoseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new DoseForm(this, vwDoseBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

 

        private void gridViewDose_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }


    }
}
