using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class RegionTypeForm : MHMForm
    {
        public RegionTypeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void RegionTypeForm_Load(object sender, EventArgs e)
        {
            vwRegionTypeTableAdapter.Fill(dataSet.VwRegionType);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.VwRegionTypeRow>();
            if (current == null)
                return;

            txtRegionType.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }

        protected override void btnAccept_Click(object sender, EventArgs e)
        {
            var current = Current.GetBindingRow<CRMDataSet.VwRegionTypeRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                vwRegionTypeTableAdapter.UpdateQuery(

                      txtRegionType.Text
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                vwRegionTypeTableAdapter.InsertQuery(txtRegionType.Text
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
