using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraEditors;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class CompanyForm : MHMForm
    {
        private IncludeForm includeForm;
        private object p;
        private OperationType add;
        private bool v;

        public CompanyForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        public CompanyForm(SaleForm saleForm, object p, OperationType add, bool v)
        {
        }

        public CompanyForm(IncludeForm includeForm, object p, OperationType add, bool v)
        {
            this.includeForm = includeForm;
            this.p = p;
            this.add = add;
            this.v = v;
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwCompanyMain' table. You can move, or remove it, as needed.
            this.vwCompanyMainTableAdapter.Fill(this.accountingDataSet.VwCompanyMain);
            // TODO: This line of code loads data into the 'dataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);
            // TODO: This line of code loads data into the 'dataSet.CompanyType' table. You can move, or remove it, as needed.
            this.companyTypeTableAdapter.Fill(this.dataSet.CompanyType);
            // TODO: This line of code loads data into the 'dataSet.WorkType' table. You can move, or remove it, as needed.
            this.workTypeTableAdapter.Fill(this.dataSet.WorkType);
            // TODO: This line of code loads data into the 'dataSet.VwWorkType' table. You can move, or remove it, as needed.
            this.vwWorkTypeTableAdapter.Fill(this.dataSet.VwWorkType);
            // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
            this.vwRegionTableAdapter.Fill(this.dataSet.VwRegion);
            // TODO: This line of code loads data into the 'dataSet.VwBank' table. You can move, or remove it, as needed.
            this.vwBankTableAdapter.Fill(this.dataSet.VwBank);
            // TODO: This line of code loads data into the 'dataSet.VwCurrency' table. You can move, or remove it, as needed.
            this.vwCurrencyTableAdapter.Fill(this.dataSet.VwCurrency);
            

            // vwCompanyTableAdapter.Fill(dataSet.VwCompany);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwCompanyRow>();
            if (current == null)
                return;

            txtPrivateNumber.Text = current.PrivateNumber;
            txtCompanyName.Text = current.CompanyName;
            txtCompanyManager.Text = current.CompanyLeader;
            treeListLookUpEditRegion.EditValue =current.IsRegionIdNull() ? (int?)null : current.RegionId;
            lookUpEditCompanyMain.EditValue = current.IsCompanyNameNull() ? (int?)null : current.ParentId;
            lookUpCompanyType.EditValue = current.TypeId;
            lookUpEditWorkTypeId.EditValue = current.IsWorkTypeIdNull() ? (int?)null : current.WorkTypeId;
            txtVoen.Text = current.Voen;
            lookUpEditCurrencyId.EditValue = current.IsCurrencyIdNull() ? (int?)null : current.CurrencyId;
            lookUpEditBankId.EditValue = current.IsBankIdNull() ? (int?)null : current.BankId;
            txtBankSwift.Text = current.BankSwift;
            txtLegalAddress.Text = current.LegalAddress;
            txtActualAddress.Text = current.ActualAddress;
            txtEmail.Text = current.Email;
            txtTel.Text = current.Tel;
            
            dateEditDesc.DateTime = current.Date;
            memoEditDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }

        

        private void lookUpEditBank_EditValueChanged(object sender, EventArgs e)
        {
            txtBankSwift.Text = "";
            if (lookUpEditBankId.EditValue == null) return;

            var current = dataSet.VwBank.FirstOrDefault(b => b.Id == Convert.ToInt32(lookUpEditBankId.EditValue));

            txtBankSwift.Text = current.Swift;
        }

        private void lookUpEditWorkTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is LookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new WorkTypeForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.workTypeTableAdapter.Fill(this.dataSet.WorkType);
                }
            }
        }

        private void lookUpEditCurrencyId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is LookUpEdit)
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

        private void lookUpEditBankId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is LookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new BankForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwBankTableAdapter.Fill(this.dataSet.VwBank);
                }

            }
        }

        private void treeListLookUpEditRegion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is TreeListLookUpEdit)
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
                    this.vwRegionTableAdapter.Fill(this.dataSet.VwRegion);
                }

            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwCompanyRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    vwCompanyTableAdapter.UpdateQuery(

                       txtPrivateNumber.Text
                       , txtCompanyName.Text
                       , txtCompanyManager.Text
                       , Convert.ToInt32(treeListLookUpEditRegion.EditValue)
                       , Convert.ToInt32(lookUpEditWorkTypeId.EditValue)
                       , txtVoen.Text
                       , Convert.ToInt32(lookUpEditCurrencyId.EditValue)
                       , Convert.ToInt32(lookUpEditBankId.EditValue)
                       , txtBankSwift.Text
                       , txtLegalAddress.Text
                       , txtActualAddress.Text
                       , txtEmail.Text
                       , txtTel.Text
                       , dateEditDesc.DateTime
                       , memoEditDescription.Text
                       , Convert.ToInt32(lookUpEditCompanyMain.EditValue)
                       , Convert.ToInt32(lookUpCompanyType.EditValue)
                       , current.Id
                        );
                }
                else
                    vwCompanyTableAdapter.InsertQuery(

                         txtPrivateNumber.Text
                       , txtCompanyName.Text
                       , txtCompanyManager.Text
                       , Convert.ToInt32(treeListLookUpEditRegion.EditValue)
                       , Convert.ToInt32(lookUpEditWorkTypeId.EditValue)
                       , txtVoen.Text
                       , Convert.ToInt32(lookUpEditCurrencyId.EditValue)
                       , Convert.ToInt32(lookUpEditBankId.EditValue)
                       , txtBankSwift.Text
                       , txtLegalAddress.Text
                       , txtActualAddress.Text
                       , txtEmail.Text
                       , txtTel.Text
                       , dateEditDesc.DateTime
                       , memoEditDescription.Text 
                       , Convert.ToInt32(lookUpEditCompanyMain.EditValue)
                       , Convert.ToInt32(lookUpCompanyType.EditValue)
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
