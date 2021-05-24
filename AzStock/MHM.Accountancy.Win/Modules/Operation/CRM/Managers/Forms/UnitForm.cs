using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class UnitForm : MHMForm
    {
        public UnitForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            vwUnitTableAdapter.Fill(dataSet.VwUnit);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.VwUnitRow>();
            if (current == null)
                return;

            txtUnitName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

        }

        override protected void btnAccept_Click(object sender, EventArgs e)
        {

            var current = Current.GetBindingRow<CRMDataSet.VwUnitRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                vwUnitTableAdapter.UpdateQuery(

                      txtUnitName.Text
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                vwUnitTableAdapter.InsertQuery(txtUnitName.Text
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
