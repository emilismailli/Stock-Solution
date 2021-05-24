
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions; 
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms;
using System.Windows.Forms; 
using MHM.Accountancy.Business.Infrastructure.Interfaces;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class CustomerContractManager : MHMManager,IManager
    {
         CustomerContractManager(IContainer container, int managerId)
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
                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwCustomer, "[Accounting].[spCustomerContract]", Parameters, true, System.Data.CommandType.StoredProcedure);

            };
        }
        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var form = new CustomerContractForm(this,null, OperationType.Add,true))
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Loading();
                    }
            });
        }

        protected override void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.MHMContainer.InvokeAction(delegate
            {
                using (var frm = new CustomerContractForm(this, vwCustomerBindingSource, OperationType.Edit))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        Loading();
                }
            });
        }





        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            var current = vwCustomerBindingSource.GetBindingRow<AccountingDataSet.VwCustomerRow>();

            if (current == null) return;//gridden secim edilmeyib demek

            using (var frm = new CustomerContractForm(this, vwCustomerBindingSource, OperationType.None))
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
            var row = vwCustomerBindingSource.GetBindingRow<AccountingDataSet.VwCustomerRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmək istədiyinizdən əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {


                Parameters.Clear();
                Parameters.Add("@operationType", OperationType.Delete)
                .Add("@id", row.Id);

                MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwCustomer, "[Accounting].[spCustomerContract]", Parameters, true, System.Data.CommandType.StoredProcedure);


                Loading();
            }

        }
    

        private void gridViewContract_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEditReadonly(e.FocusedRowHandle < 0);
            SetRemoveReadonly(e.FocusedRowHandle < 0);
            SetPrintReadonly(e.FocusedRowHandle < 0);
            SetShowReadonly(e.FocusedRowHandle < 0);
            SetApplyDocumentReadonly(e.FocusedRowHandle < 0);
        }
    }

 

}
