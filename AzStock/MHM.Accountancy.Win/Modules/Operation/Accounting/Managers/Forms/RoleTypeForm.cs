using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class RoleTypeForm : MHMForm
    {
        public RoleTypeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void RoleTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwRoleType' table. You can move, or remove it, as needed.
            this.vwRoleTypeTableAdapter.Fill(this.dataSet.VwRoleType);
            vwRoleTypeTableAdapter.Fill(dataSet.VwRoleType);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwRoleTypeRow>();
            if (current == null)
                return;

            txtRoleType.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }



        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {var current = Current.GetBindingRow<AccountingDataSet.VwRoleTypeRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                vwRoleTypeTableAdapter.UpdateQuery(

                      txtRoleType.Text
                    , txtDescription.Text, true, current.Id

                    );
            }
            else
                vwRoleTypeTableAdapter.InsertQuery(txtRoleType.Text
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
