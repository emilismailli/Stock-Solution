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
    public partial class BankGroupForm : MHMForm
    {
        public BankGroupForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void BankGroupForm_Load(object sender, EventArgs e)
        {
            bankGroupTableAdapter.Fill(dataSet.BankGroup);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.BankGroupRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.BankGroupRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    bankGroupTableAdapter.UpdateQuery(

                          txtName.Text
                        , txtDescription.Text, true, current.Id

                        );
                }
                else
                    bankGroupTableAdapter.InsertQuery(txtName.Text
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
