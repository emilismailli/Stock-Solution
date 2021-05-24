using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class RegionForm : MHMForm
    {
        public RegionForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void RegionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwRegionType' table. You can move, or remove it, as needed.
            this.vwRegionTypeTableAdapter.Fill(this.dataSet.VwRegionType);


          vwRegionTableAdapter.Fill(dataSet.VwRegion);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.VwRegionRow>();
            if (current == null)
                return;

            txtRegionName.Text = current.Name;
            lookUpEditRegionType.EditValue = current.RegionTypeId;
            treeListLookUpEditParent.EditValue = current.ParentId;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }

        protected override void btnAccept_Click(object sender, EventArgs e)
        {
            var current = Current.GetBindingRow<CRMDataSet.VwRegionRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                vwRegionTableAdapter.UpdateQuery(

                      Convert.ToInt32(treeListLookUpEditParent.EditValue)
                    , txtRegionName.Text
                    , Convert.ToInt32(lookUpEditRegionType.EditValue)
                    , txtDescription.Text, current.Id

                    );
            }
            else
                vwRegionTableAdapter.InsertQuery(

                      Convert.ToInt32(treeListLookUpEditParent.EditValue)
                    , txtRegionName.Text
                    , Convert.ToInt32(lookUpEditRegionType.EditValue)
                    , txtDescription.Text);

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
