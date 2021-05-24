using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class DoseForm : MHMForm
    {
        public DoseForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void DoseForm_Load(object sender, EventArgs e)
        {
            vwDoseTableAdapter.Fill(dataSet.VwDose);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.VwDoseRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }


        protected override void btnAccept_Click(object sender, EventArgs e)
        {
            var current = Current.GetBindingRow<CRMDataSet.VwDoseRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                vwDoseTableAdapter.UpdateQuery(

                      txtName.Text
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                vwDoseTableAdapter.InsertQuery(txtName.Text
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
