using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Data;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using ERP.Infrastructure.Extensions; 

namespace MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers
{
    public partial class WareHouseManager : MHMManager, IManager
    {
        WareHouseManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Loading();
        }

        public void Loading()
        {
             vwWareHouseTableAdapter.Fill(dataSet.VwWareHouse);
            
        }

        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new WareHouseForm(this, null, OperationType.Add, true))
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
            var current = vwWareHouseBindingSource.GetBindingRow<WareHouseDataSet.VwWareHouseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new WareHouseForm(this, vwWareHouseBindingSource, OperationType.Edit))
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
            var current = vwWareHouseBindingSource.GetBindingRow<WareHouseDataSet.VwWareHouseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion)==System.Windows.Forms.DialogResult.OK)
            {
                wareHouseTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwWareHouseBindingSource.GetBindingRow<WareHouseDataSet.VwWareHouseRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new WareHouseForm(this, vwWareHouseBindingSource, OperationType.Edit))
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
    }
}
