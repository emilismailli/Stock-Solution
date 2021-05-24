using MHM.Accountancy.Business.Infrastructure;
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
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class PaymentTypeForm : MHMForm
    {
        public PaymentTypeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void PaymentTypeForm_Load(object sender, EventArgs e)
        {
            vwPaymentTypeTableAdapter.Fill(dataSet.VwPaymentType);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwPaymentTypeRow>();
            if (current == null)
                return;

            txtPaymentType.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

        }


        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwPaymentTypeRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    vwPaymentTypeTableAdapter.UpdateQuery(

                          txtPaymentType.Text
                        , txtDescription.Text, true, current.Id

                        );
                }
                else
                    vwPaymentTypeTableAdapter.InsertQuery(
                        txtPaymentType.Text
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
