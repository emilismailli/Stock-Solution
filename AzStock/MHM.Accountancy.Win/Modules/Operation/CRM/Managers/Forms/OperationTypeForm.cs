using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class OperationTypeForm : MHMForm
    {
        public OperationTypeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void OperationTypeForm_Load(object sender, System.EventArgs e)
        {
            operationTypeTableAdapter.Fill(dataSet.OperationType);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.OperationTypeRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }

        override protected void btnAccept_Click(object sender, System.EventArgs e)
        {
            var current = Current.GetBindingRow<CRMDataSet.OperationTypeRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                operationTypeTableAdapter.UpdateQuery(

                      txtName.Text
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                operationTypeTableAdapter.InsertQuery(txtName.Text
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
