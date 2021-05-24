using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.CRM.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;

namespace MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms
{
    public partial class WorkTypeForm : MHMForm
    {
        public WorkTypeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void WorkTypeForm_Load(object sender, EventArgs e)
        {
            workTypeTableAdapter.Fill(dataSet.WorkType);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<CRMDataSet.WorkTypeRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var current = Current.GetBindingRow<CRMDataSet.WorkTypeRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                workTypeTableAdapter.UpdateQuery(

                      txtName.Text
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                workTypeTableAdapter.InsertQuery(txtName.Text
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
