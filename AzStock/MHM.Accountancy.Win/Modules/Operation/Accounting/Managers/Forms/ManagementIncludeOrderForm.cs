using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ManagementIncludeOrderForm : MHMForm
    {
        public ManagementIncludeOrderForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
            //splitContainerControl1.SetSplitterPercent(70);
            //splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }

        private void ManagementIncludeOrderForm_Load(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'accountingDataSet.VwCustomer' table. You can move, or remove it, as needed.
            this.vwCustomerTableAdapter.Fill(this.accountingDataSet.VwCustomer);
            // TODO: This line of code loads data into the 'accountingDataSet.VwPaymentType' table. You can move, or remove it, as needed.
            this.vwPaymentTypeTableAdapter.Fill(this.accountingDataSet.VwPaymentType);
            // TODO: This line of code loads data into the 'accountingDataSet.VwAccount' table. You can move, or remove it, as needed.
            this.vwAccountTableAdapter.Fill(this.accountingDataSet.VwAccount);



            // formun load hissesidi lazim olsa istifade etmeye


            if (Current == null)
                return;
            var currentRow = Current.GetBindingRow<AccountingDataSet.VwPaymentRow>();
            
            this.ActiveControl = erpLookUpEditCustomerId;


            //var currentRow=Current.GetBindingRow<AccountingDataSet.VwPaymentRow>();
            txtPayment.EditValue = currentRow.Payment;
            erpLookUpEditCustomerId.EditValue = currentRow.IsCustomerIdNull() ? (int?)null : currentRow.CustomerId;
            erpLookUpEditAccountId.EditValue = currentRow.IsAccountIdNull() ? (int?)null : currentRow.AccountId;
            erpLookUpEditPaymentType.EditValue = 1; 
            txtDescription.Text=currentRow.IsDescriptionNull() ? "" : currentRow.Description;
            erpDateEditDate.DateTime=currentRow.CreateDate;
        }



 

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Parameters.Clear();
            if (!erpLookUpEdit1.Validate()) return;


            Parameters.Add("@operationType", operationType)
                .Add("@customerId", erpLookUpEdit1.GetIntValue());



            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spDebt, "[Accounting].[spDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }
 

        private void btnAcceptOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                decimal.TryParse(txtPayment.Text, out decimal payment);
                Parameters.Clear();
                Parameters.Add("@operationType", operationType)
                    .Add("@customerId", erpLookUpEditCustomerId.GetIntValue())
                    .Add("@accountId", erpLookUpEditAccountId.GetIntValue())
                    .Add("@payment", payment)
                    .Add("@paymentDate", erpDateEditDate.DateTime)
                    .Add("@description", string.IsNullOrEmpty(txtDescription.Text) ? "--" : txtDescription.Text)
                    .Add("@paymenttypeId", erpLookUpEditPaymentType.GetIntValue())
                    ;
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwPayment, "[Accounting].[spManagementPaymentDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Parameters.Clear();
            if (!erpLookUpEdit1.Validate()) return;


            Parameters.Add("@operationType", operationType)
                .Add("@customerId", erpLookUpEdit1.GetIntValue());



            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spDebt, "[Accounting].[spDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }
        
        
         
    }
}
