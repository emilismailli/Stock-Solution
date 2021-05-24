using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class CurrencyForm : MHMForm
    {
        public CurrencyForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
           : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void CurrencyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwCurrency' table. You can move, or remove it, as needed.
            this.VwCurrencyTableAdapter.Fill(this.dataSet.VwCurrency);



            VwCurrencyTableAdapter.Fill(dataSet.VwCurrency);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwCurrencyRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            spinEditBuy.EditValue = current.Buy;
            spinEditSell.EditValue = current.Sell;
            dateEditRefreshDate.EditValue = current.RefreshDate;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
            


        }

        

        private object DateTime(object getdate)
        {
            throw new NotImplementedException();
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwCurrencyRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    VwCurrencyTableAdapter.UpdateQuery(

                         txtName.Text
                       , Convert.ToDecimal(spinEditBuy.EditValue)
                       , Convert.ToDecimal(spinEditBuy.EditValue)
                       , dateEditRefreshDate.DateTime
                       , txtDescription.Text
                        , true
                        ,current.Id


                        );
                }
                else
                    VwCurrencyTableAdapter.InsertQuery(

                          txtName.Text
                        , Convert.ToDecimal(spinEditBuy.EditValue)
                        , Convert.ToDecimal(spinEditBuy.EditValue)
                        , dateEditRefreshDate.DateTime
                        , txtDescription.Text
                        , true
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
