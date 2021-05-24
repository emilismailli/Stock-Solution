using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ContractTypeForm : MHMForm
    {
        public ContractTypeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void ContractTypeForm_Load(object sender, EventArgs e)
        {
            vwContractTypeTableAdapter.Fill(dataSet.VwContractType);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwContractTypeRow>();
            if (current == null)
                return;

            txtContractType.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

        }


        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwContractTypeRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    vwContractTypeTableAdapter.UpdateQuery(

                          txtContractType.Text
                        , txtDescription.Text, true, current.Id

                        );
                }
                else
                    vwContractTypeTableAdapter.InsertQuery(txtContractType.Text
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
