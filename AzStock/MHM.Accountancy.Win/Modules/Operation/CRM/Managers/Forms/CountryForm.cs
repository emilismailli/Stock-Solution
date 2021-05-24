using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class CountryForm : MHMForm

    {
        public CountryForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

     

        private void CountryForm_Load(object sender, EventArgs e)
        {
            countryTableAdapter.Fill(dataSet.Country);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.CountryRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtCode.EditValue = current.Code;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            var current = Current.GetBindingRow<CRMDataSet.CountryRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                countryTableAdapter.UpdateQuery(

                      txtName.Text
                    , Convert.ToInt32(txtCode.EditValue)  
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                countryTableAdapter.InsertQuery(txtName.Text
                    , Convert.ToInt32(txtCode.EditValue)
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
