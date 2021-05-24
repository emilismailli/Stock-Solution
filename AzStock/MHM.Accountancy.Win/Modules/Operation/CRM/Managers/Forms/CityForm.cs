using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class CityForm : MHMForm
    {
        public CityForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            cityTableAdapter.Fill(dataSet.City);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.CityRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            var current = Current.GetBindingRow<CRMDataSet.CityRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                cityTableAdapter.UpdateQuery(

                      txtName.Text
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                cityTableAdapter.InsertQuery(txtName.Text
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
