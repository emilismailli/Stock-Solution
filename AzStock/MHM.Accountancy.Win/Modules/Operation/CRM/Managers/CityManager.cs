


using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers
{
     partial class CityManager : MHMManager,IManager
    {
         CityManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Loading();
        }

     
        public void Loading()
        {
            cityTableAdapter.Fill(dataSet.City);
        }
        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new CityForm(this, null, OperationType.Add, true))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

        //protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    var current = cityBindingSource.GetBindingRow<CRMDataSet.CityRow>();

        //    if (current == null) return;//gridden secim edilmeyib demek

        //    using (var frm = new CityForm(this, cityBindingSource, OperationType.Edit))
        //    {
        //        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            MHMContainer.PrintSuccess(CommonLang.Success);
        //            Loading();
        //        }
        //    }
        //}

        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = cityBindingSource.GetBindingRow<CRMDataSet.CityRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            {
                cityTableAdapter.DeleteQuery(current.Id);
                MHMContainer.PrintSuccess(CommonLang.Success);
                Loading();
            }
        }

        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = cityBindingSource.GetBindingRow<CRMDataSet.CityRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new CityForm(this, cityBindingSource, OperationType.None))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
            }
        }

 

        private void gridViewCity_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }

    }
}
