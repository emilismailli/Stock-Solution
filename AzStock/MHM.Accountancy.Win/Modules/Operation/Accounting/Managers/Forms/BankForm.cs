using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class BankForm : MHMForm
    {
        public BankForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void BankForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dataSet.VwDocumentDetail' table. You can move, or remove it, as needed.
            //this.vwDocumentDetailTableAdapter.Fill(this.dataSet.VwDocumentDetail);
            // TODO: This line of code loads data into the 'cRMDataSet.VwRegion' table. You can move, or remove it, as needed.
            this.vwRegionTableAdapter.Fill(this.cRMDataSet.VwRegion);
            // TODO: This line of code loads data into the 'cRMDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cRMDataSet.City);
            // TODO: This line of code loads data into the 'dataSet.VwCurrency' table. You can move, or remove it, as needed.
            this.vwCurrencyTableAdapter.Fill(this.dataSet.VwCurrency);
            //TODO: This line of code loads data into the 'dataSet.VwBankGroup' table.You can move, or remove it, as needed.
            this.vwBankGroupTableAdapter.Fill(this.dataSet.VwBankGroup);

            vwBankTableAdapter.Fill(dataSet.VwBank);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwBankRow>();
            if (current == null)
                return;

            erpLookUpEditBankGroupId.EditValue = current.GroupId;
            txtName.Text = current.Name;
            txtBankSwift.Text = current.Swift;
            txtVoen.Text = current.Voen;
            erpLookUpEditCurrency.EditValue=current.CurrencyId;
            erpTreeListLookUpEditRegion.EditValue=current.RegionId;



        }


        private void erpLookUpEditBankGroupId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new BankGroupForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwBankGroupTableAdapter.Fill(this.dataSet.VwBankGroup);
                }

            }
        }

        private void erpLookUpEditCurrency_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new CurrencyForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwCurrencyTableAdapter.Fill(this.dataSet.VwCurrency);
                }

            }

        }

        private void erpTreeListLookUpEditRegionId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpTreeListLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new RegionForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwRegionTableAdapter.Fill(this.cRMDataSet.VwRegion);
                }

            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwBankRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    vwBankTableAdapter.UpdateQuery(

                            Convert.ToInt32(erpLookUpEditBankGroupId.EditValue)
                          , txtName.Text
                          , txtBankSwift.Text
                          , txtVoen.Text
                          , Convert.ToInt32(erpLookUpEditCurrency.EditValue)
                          , Convert.ToInt32(erpTreeListLookUpEditRegion.EditValue)
                          , current.Id);
                }
                else
                    vwBankTableAdapter.InsertQuery(
                            Convert.ToInt32(erpLookUpEditBankGroupId.EditValue)
                          , txtName.Text
                          , txtBankSwift.Text
                          , txtVoen.Text
                          , Convert.ToInt32(erpLookUpEditCurrency.EditValue)
                          , Convert.ToInt32(erpTreeListLookUpEditRegion.EditValue));

                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }

        }

        private void btnPrintDocument_Click_1(object sender, EventArgs e)
        {

        }
    }
}
