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
    public partial class TransferMoneyForm : MHMForm
    {
        public TransferMoneyForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void TransferMoneyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet1.VwCash' table. You can move, or remove it, as needed.
            this.vwCashTableAdapter.Fill(this.accountingDataSet1.VwCash);
            // TODO: This line of code loads data into the 'accountingDataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.accountingDataSet.VwCompany);
            // TODO: This line of code loads data into the 'accountingDataSet.VwCashMoney' table. You can move, or remove it, as needed.
            this.vwCashMoneyTableAdapter.Fill(this.accountingDataSet.VwCashMoney);
            // TODO: This line of code loads data into the 'accountingDataSet.VwExpense' table. You can move, or remove it, as needed.
            this.vwExpenseTableAdapter.Fill(this.accountingDataSet.VwExpense);
            // TODO: This line of code loads data into the 'accountingDataSet.VwCash' table. You can move, or remove it, as needed.
            this.vwCashTableAdapter.Fill(this.accountingDataSet.VwCash);
            // TODO: This line of code loads data into the 'accountingDataSet.VwAccountDebt' table. You can move, or remove it, as needed.
            this.vwAccountDebtTableAdapter.Fill(this.accountingDataSet.VwAccountDebt);
      
            this.vwPaymentTypeTableAdapter.Fill(this.accountingDataSet.VwPaymentType);
            // TODO: This line of code loads data into the 'accountingDataSet.VwAccount' table. You can move, or remove it, as needed.
            this.vwAccountTableAdapter.Fill(this.accountingDataSet.VwAccount);
            Parameters.Clear();

            Parameters.Add("@menuId", Manager.Id);
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spCashFromMoney, "[Accounting].[spCashFromMoney]", Parameters, true, System.Data.CommandType.StoredProcedure);
            Parameters.Clear();
            //Parameters.Add("@cashId", Manager.Id);
            //Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spCashToMoney, "[Accounting].[spCashToMoney]", Parameters, true, System.Data.CommandType.StoredProcedure);
            //Parameters.Clear();
            erpLookUpEditCompany.EditValue = 1;
            erpLookUpEditPaymentType.EditValue = 1;
            erpLookUpEditPaymentType.EditValue = 1;
            erpDateEdit1.DateTime = DateTime.Now;
            // formun load hissesidi lazim olsa istifade etmeye
            this.ActiveControl = erpLookUpEditCompany;

            //if (Current == null) 
            //        return;

            //var currentRow=Current.GetBindingRow<AccountingDataSet.VwPaymentRow>();
            //erpLookUpEditCustomerId.EditValue = currentRow.IsCustomerIdNull() ? (int?)null : currentRow.CustomerId;
            //erpLookUpEditAccountId.EditValue = currentRow.IsAccountIdNull() ? (int?)null : currentRow.AccountId;
            //erpLookUpEditPaymentType.EditValue = currentRow.IsPaymentTypeIdNull() ? (int?)null : currentRow.PaymentTypeId;
            //txtPayment.Text = currentRow.IsPaymentNull() ? "" : currentRow.Payment.ToString();
            //txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;

        }

         
        private void btnAcceptOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                decimal.TryParse(txtPayment.Text, out decimal payment);
                Parameters.Clear();
                Parameters.Add("@operationType", operationType)
                    .Add("@customerId", erpLookUpEditCompany.GetIntValue())
                    //.Add("@accountId", erpLookUpEditAccountId.GetIntValue())
                    .Add("@payment", payment)
                    .Add("@paymentDate", erpDateEdit1.DateTime)
                    .Add("@description", string.IsNullOrEmpty(txtDescription.Text) ? "--" : txtDescription.Text)
                    .Add("@paymenttypeId", erpLookUpEditPaymentType.GetIntValue())
                    .Add("@expenseId", erpTreeListLookUpEditExpense.GetIntValue())
                    .Add("@cashFromId", erpLookUpEditFromCash.GetIntValue()) 
                    .Add("@cashId", erpLookUpEditToCash.GetIntValue());




                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwPayment, "[Accounting].[spCashTrasnport]", Parameters, true, System.Data.CommandType.StoredProcedure);




                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        



        private void btnExpense_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var form = new ExpenseForm(Manager, null, OperationType.Add, true))
            {
                form.ShowDialog();
                Manager.Loading();

            }

            
           

        }  

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var form = new CashForm(Manager, null, OperationType.Add, true))
            {
                form.ShowDialog();
                Manager.Loading();

            }
        }




        private void erpLookUpEditCash_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
                 if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)


            {

                // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                this.vwCashTableAdapter.Fill(this.accountingDataSet.VwCash);


                this.vwExpenseTableAdapter.Fill(this.accountingDataSet.VwExpense);
            }

        }

        private void erpLookUpEditFromCash_EditValueChanged(object sender, EventArgs e)
        {
            int? cashId = erpLookUpEditFromCash.GetIntValue();

            if (cashId.HasValue && cashId.Value>0)
            {

                Parameters.Clear();
                Parameters.Add("@cashId", cashId.Value);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spCashToMoney, "[Accounting].[spCashToMoney]", Parameters, true, System.Data.CommandType.StoredProcedure);
            }

      
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
