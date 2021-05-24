using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class GoodManager : MHMManager,IManager
    {
         GoodManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
        }

        public void Loading()
        {

            {
                Parameters.Clear();
                Parameters.Add("@operationType", OperationType.Select);


                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwGood, "[Accounting].[spGood]", Parameters, true, System.Data.CommandType.StoredProcedure);

            };
            
        }


        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new GoodForm(this, null, OperationType.Add, true))
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
            var current = vwGoodBindingSource.GetBindingRow<AccountingDataSet.VwGoodRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new GoodForm(this, vwGoodBindingSource, OperationType.Edit))
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
            var row = vwGoodBindingSource.GetBindingRow<AccountingDataSet.VwGoodRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {


                Parameters.Clear();
                Parameters.Add("@operationType", OperationType.DeleteWithSelect)
                .Add("@id", row.BarcodeId);

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwGood, "[Accounting].[spGood]", Parameters, true, System.Data.CommandType.StoredProcedure);


                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwGoodBindingSource.GetBindingRow<AccountingDataSet.VwGoodRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new GoodForm(this, vwGoodBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

       

        private void gridViewGood_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }

        private void barBtnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnShow_ItemClick(null, null);
        }

   

        private void barBtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barBtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnDelete_ItemClick(null, null);
        }

        private void gridViewGood_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                popupMenu.ShowPopup(Control.MousePosition);
            }
        }

        private void gridViewGood_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }
    }
}
