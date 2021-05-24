using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
    public partial class WorkTypeManager : MHMManager,IManager
    {
        //test
        WorkTypeManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Loading();
        }

        public override void Loading()
        {
            workTypeTableAdapter.Fill(dataSet.WorkType);
        }

        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new WorkTypeForm(this, null, OperationType.Add, true))
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
            var current = workTypeBindingSource.GetBindingRow<CRMDataSet.WorkTypeRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new WorkTypeForm(this, workTypeBindingSource, OperationType.Edit))
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
            var current = workTypeBindingSource.GetBindingRow<CRMDataSet.WorkTypeRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                workTypeTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = workTypeBindingSource.GetBindingRow<CRMDataSet.WorkTypeRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new WorkTypeForm(this, workTypeBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

    

        private void gridViewWorkType_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }

        //private void barBtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    btnEdit_ItemClick(null, null);
        //}

        private void gridViewWorkType_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                popupMenu.ShowPopup(Control.MousePosition);
            }
        }

        public override  void ExportToExcel()
        {
            throw new System.NotImplementedException();
        }
    }
}
