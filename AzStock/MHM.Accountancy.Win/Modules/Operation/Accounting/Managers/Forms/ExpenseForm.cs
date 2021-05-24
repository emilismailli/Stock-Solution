using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Business.Infrastructure.Common;
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ExpenseForm : MHMForm

    {
        public ExpenseForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }
        internal ExpenseForm(IManager manager, AccountingDataSet dataSet, OperationType operationType)
           : this(manager, null, dataSet, operationType)
        {
        }

        internal ExpenseForm(IManager manager, BindingSource bindingSource, AccountingDataSet dataSet, OperationType operationType)
            : this(manager, bindingSource, operationType)
        {
            this.dataSet = dataSet;
            this.ApplyBindingSourcesDataSet(this.dataSet);
        }


        private void ExpenseForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwExpense' table. You can move, or remove it, as needed.
            this.vwExpenseChooseTableAdapter.Fill(this.dataSet.VwExpenseChoose);


            erpTreeListLookUpEditMain.EditValue = null;

            if (Current == null)
                return;

            var currentRow = Current.GetBindingRow<AccountingDataSet.VwExpenseRow>();

            erpTreeListLookUpEditMain.EditValue = currentRow.IsParentIdNull() ? (int?)null : currentRow.ParentId;

            txtCode.Text = GetSubCode(currentRow.Code);
            txtName.Text = currentRow.ExpenseName;

            txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;

        }
        string GetSubCode(string code)
        {
            if (code.EndsWith(".") && code.Replace(".", "").Length > 0)
                code = code.Substring(0, code.LastIndexOf("."));

            if (string.IsNullOrWhiteSpace(code) || code.IndexOf(".") == -1)
                return code;

            int lastPointIndex = code.LastIndexOf(".") + 1;

            return code.Substring(lastPointIndex, code.Length - lastPointIndex);
        }




 






        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAcceptCost_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                txtCode.Text = string.Join(".", txtCode.Text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries));

                if (!txtCode.Validate()
                || !txtName.Validate()
                ) return;
                string code = "";
                var current = vwExpenseChooseBindingSource.GetBindingRow<AccountingDataSet.VwExpenseChooseRow>();
                if (current != null && !string.IsNullOrWhiteSpace(current.Code))
                    code = string.Format("{0}.{1}", current.Code, txtCode.Text);
                else
                    code = txtCode.Text;

                Parameters.Add("@operationType", operationType)
                .Add("@expenseName", txtName.Text)
                .Add("@code", code);

                if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                    Parameters.Add("@description", txtDescription.Text);
                if (erpTreeListLookUpEditMain.EditValue != null)
                    Parameters.Add("@parentId", erpTreeListLookUpEditMain.GetIntValue());

                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwExpenseRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwExpense, "[Accounting].[spExpense]", Parameters, true, System.Data.CommandType.StoredProcedure);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void erpTreeListLookUpEditMain_EditValueChanged(object sender, EventArgs e)
        {
            vwExpenseChooseBindingSource.Position = -1;

            if (erpTreeListLookUpEditMain.EditValue == null)
                return;

            vwExpenseChooseBindingSource.Position = vwExpenseChooseBindingSource.Find("Id", erpTreeListLookUpEditMain.GetIntValue());
        }

       
    }
}
