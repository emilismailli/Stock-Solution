using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Business.Infrastructure.Common;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class CostForm : MHMForm
    {
        public CostForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void CostForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwPaymentType' table. You can move, or remove it, as needed.
            this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);

            
            
            vwCostTableAdapter.Fill(dataSet.VwCost);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwCostRow>();
            erpLookUpEditPaymentType.EditValue = 1;
            if (current == null)
                return;
            
            txtPerson.Text = current.IsPersonNull() ? "" : current.Person;
            txtPlace.Text = current.IsPlaceNull() ? "" : current.Place;
            txtAmount.Text = current.IsAmountNull() ? "" : current.Amount.ToString();
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
            erpLookUpEditPaymentType.EditValue = current.IsPaymentTypeIdNull() ? (int?)null : current.PaymentTypeId;
            erpDateEditDate.DateTime = current.CostDate;
            
        }

        private void erpLookUpEditPaymentType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new PaymentTypeForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);
                }
            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {  
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwCostRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    vwCostTableAdapter.UpdateQuery(

                         txtPerson.Text
                       , txtPlace.Text
                       , Convert.ToDecimal(txtAmount.EditValue)
                       , erpDateEditDate.DateTime
                       , erpLookUpEditPaymentType.GetIntValue()
                       , txtDescription.Text
                       , current.Id
                        
                       );
                }
                else
                    vwCostTableAdapter.InsertQuery(
                       
                           txtPerson.Text
                         , txtPlace.Text 
                         , Convert.ToDecimal(txtAmount.EditValue)
                         , erpDateEditDate.DateTime
                         , erpLookUpEditPaymentType.GetIntValue()
                         , txtDescription.Text
                          
                         );

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
