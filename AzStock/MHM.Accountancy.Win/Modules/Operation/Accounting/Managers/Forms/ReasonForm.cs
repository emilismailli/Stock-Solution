using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
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

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ReasonForm : MHMForm
    {
        public ReasonForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void ReasonForm_Load(object sender, EventArgs e)
        {
            vwReasonTableAdapter.Fill(dataSet.VwReason);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwReasonRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }


        
        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwReasonRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    vwReasonTableAdapter.UpdateQuery(

                          txtName.Text
                        , txtDescription.Text, true, current.Id

                        );
                }
                else
                    vwReasonTableAdapter.InsertQuery(txtName.Text
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
