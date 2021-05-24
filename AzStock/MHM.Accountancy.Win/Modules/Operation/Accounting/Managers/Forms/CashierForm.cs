using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class CashierForm : MHMForm
    {
        public CashierForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.dataSet.Cashier);
            cashierTableAdapter.Fill(dataSet.Cashier);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.CashierRow>();
            if (current == null)
                return;

            txtCashier.Text = current.CashierName;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.CashierRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    cashierTableAdapter.UpdateQuery(

                          txtCashier.Text
                        , txtDescription.Text, true, current.Id

                        );
                }
                else
                    cashierTableAdapter.InsertQuery(txtCashier.Text
                        , txtDescription.Text, true);

                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }
    }
}
