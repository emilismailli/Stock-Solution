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
    public partial class IncludeOrderForm : MHMForm
    {
        public IncludeOrderForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
            //splitContainerControl1.SetSplitterPercent(70);
            //splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }

        private void IncludeOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwExpense' table. You can move, or remove it, as needed.
            this.vwExpenseTableAdapter.Fill(this.accountingDataSet.VwExpense);
            // TODO: This line of code loads data into the 'accountingDataSet.VwCash' table. You can move, or remove it, as needed.
            this.vwCashTableAdapter.Fill(this.accountingDataSet.VwCash);
            // TODO: This line of code loads data into the 'accountingDataSet.VwAccountDebt' table. You can move, or remove it, as needed.
            this.vwAccountDebtTableAdapter.Fill(this.accountingDataSet.VwAccountDebt);
            // TODO: This line of code loads data into the 'accountingDataSet.VwAccountDebt' table. You can move, or remove it, as needed.
            //this.vwAccountDebtTableAdapter.Fill(this.accountingDataSet.VwAccountDebt);
            // TODO: This line of code loads data into the 'accountingDataSet.VwPayment' table. You can move, or remove it, as needed.
            //this.vwPaymentTableAdapter.Fill(this.accountingDataSet.VwPayment);
            // TODO: This line of code loads data into the 'accountingDataSet.VwCustomer' table. You can move, or remove it, as needed.
            this.vwCustomerTableAdapter.Fill(this.accountingDataSet.VwCustomer);
            // TODO: This line of code loads data into the 'accountingDataSet.VwPaymentType' table. You can move, or remove it, as needed.
            this.vwPaymentTypeTableAdapter.Fill(this.accountingDataSet.VwPaymentType);
            // TODO: This line of code loads data into the 'accountingDataSet.VwAccount' table. You can move, or remove it, as needed.
            this.vwAccountTableAdapter.Fill(this.accountingDataSet.VwAccount);



            // formun load hissesidi lazim olsa istifade etmeye


            if (Current == null)
                return;

            var currentRow = Current.GetBindingRow<AccountingDataSet.VwPaymentIncludeOrderRow>();
            this.ActiveControl = erpLookUpEditCustomerId;
            //var currentRow=Current.GetBindingRow<AccountingDataSet.VwPaymentRow>();
            //erpLookUpEditCustomerId.EditValue = currentRow.IsCustomerIdNull() ? (int?)null : currentRow.CustomerId;
            //erpLookUpEditAccountId.EditValue = currentRow.IsAccountIdNull() ? (int?)null : currentRow.AccountId;
            erpLookUpEditPaymentType.EditValue = 1; 

        }



        private void btnAccept_Click_1(object sender, EventArgs e)
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
                    .Add("@expenseId" , erpTreeListLookUpEditExpense.GetIntValue())
                    .Add("@cashId" ,erpLookUpEditCash.GetIntValue());




                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwPayment, "[Accounting].[spPaymentDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);




                DialogResult = DialogResult.OK;
            }
        }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Parameters.Clear();
            if (!erpLookUpEdit1.Validate()) return;


            Parameters.Add("@operationType", operationType)
                .Add("@customerId", erpLookUpEdit1.GetIntValue());



            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spDebt, "[Accounting].[spDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }

        private void erpLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

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
                    .Add("@expenseId", erpTreeListLookUpEditExpense.GetIntValue())
                    .Add("@cashId", erpLookUpEditCash.GetIntValue());




                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwPayment, "[Accounting].[spPaymentDebt]", Parameters, true, System.Data.CommandType.StoredProcedure);




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
    }
}
