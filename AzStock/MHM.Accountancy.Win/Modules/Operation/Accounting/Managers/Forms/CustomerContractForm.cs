using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
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
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using MHM.Accountancy.Business.Infrastructure.UI;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class CustomerContractForm : MHMForm
    {
        public CustomerContractForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }
        
        private void gridViewContract_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            //AccountingDataSet.VwContractRow current;
            //switch (e.Button.ButtonType)
            //{
            //    case DevExpress.XtraEditors.NavigatorButtonType.Append:
            //        using (var frm = new ContractForm(null, OperationType.Add))
            //            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //            {

            //            }
            //        e.Handled = true;
            //        break;

            //    case DevExpress.XtraEditors.NavigatorButtonType.Edit:
            //        current = vwContractBindingSource.GetBindingRow<AccountingDataSet.VwContractRow>();

            //        if (current == null) return;//gridden secim edilmeyib demek

            //        using (var frm = new ContractForm(vwContractBindingSource, OperationType.Edit))
            //        {
            //            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //            {
            //                container.PrintSuccess(CommonLang.Success);

            //            }
            //        }
            //        //using (var frm = new ContractForm(null, OperationType.Edit))
            //        //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        //    {
            //        //        if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        //        {

            //        //        }
            //        //    }
            //        e.Handled = true;
            //        break;
            //    case DevExpress.XtraEditors.NavigatorButtonType.Remove:

            //        current = vwContractBindingSource.GetBindingRow<AccountingDataSet.VwContractRow>();

            //        if (current == null) return;//gridden secim edilmeyib demek

            //        if (MHMMessage.ShowQuestionMessageBox(CommonLang.DeleteQuestion) == System.Windows.Forms.DialogResult.OK)
            //        {
            //            //vwContractTableAdapter.DeleteQuery(current.Id);
            //            container.PrintSuccess(CommonLang.Success);
            //        }

            //        //using (var frm = new ContractForm(null, OperationType.Delete))
            //        //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        //    {

            //        //    }
            //        e.Handled = true;
            //        break;
            //    case DevExpress.XtraEditors.NavigatorButtonType.Custom:
            //    case DevExpress.XtraEditors.NavigatorButtonType.First:
            //    case DevExpress.XtraEditors.NavigatorButtonType.PrevPage:
            //    case DevExpress.XtraEditors.NavigatorButtonType.Prev:
            //    case DevExpress.XtraEditors.NavigatorButtonType.Next:
            //    case DevExpress.XtraEditors.NavigatorButtonType.NextPage:
            //    case DevExpress.XtraEditors.NavigatorButtonType.Last:
            //    case DevExpress.XtraEditors.NavigatorButtonType.EndEdit:
            //    case DevExpress.XtraEditors.NavigatorButtonType.CancelEdit:
            //    default:
            //        break;
            //}
        }
        
        private void CustomerContractForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
            this.vwRegionTableAdapter.Fill(this.dataSet.VwRegion);
            // TODO: This line of code loads data into the 'dataSet.VwCustomer' table. You can move, or remove it, as needed.
            this.vwCustomerTableAdapter.Fill(this.dataSet.VwCustomer);
            // TODO: This line of code loads data into the 'dataSet.CompanyType' table. You can move, or remove it, as needed.
            this.companyTypeTableAdapter.Fill(this.dataSet.CompanyType);
            // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
            this.vwRegionTableAdapter.Fill(this.dataSet.VwRegion);
            // TODO: This line of code loads data into the 'dataSet.VwContractType' table. You can move, or remove it, as needed.
            this.vwContractTypeTableAdapter.Fill(this.dataSet.VwContractType);
            // TODO: This line of code loads data into the 'dataSet.OperationType' table. You can move, or remove it, as needed.
            this.operationTypeTableAdapter.Fill(this.dataSet.OperationType);
            // TODO: This line of code loads data into the 'dataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);
            // TODO: This line of code loads data into the 'dataSet.VwBank' table. You can move, or remove it, as needed.
            this.vwBankTableAdapter.Fill(this.dataSet.VwBank);
            // TODO: This line of code loads data into the 'dataSet.VwCurrency' table. You can move, or remove it, as needed.
            this.vwCurrencyTableAdapter.Fill(this.dataSet.VwCurrency);
            // TODO: This line of code loads data into the 'dataSet.VwWorkType' table. You can move, or remove it, as needed.
            this.vwWorkTypeTableAdapter.Fill(this.dataSet.VwWorkType);


            if (Current == null)
                return;

            txtNumber.Properties.ReadOnly = true;

            var currentRow = Current.GetBindingRow<AccountingDataSet.VwCustomerRow>();

            txtNumber.Text = currentRow.Id.ToString("000000");
            txtCustomerName.Text = currentRow.IsCustomerNameNull() ? "" : currentRow.CustomerName;
            txtCustomerLeader.Text = currentRow.IsCustomerLeaderNull() ? "" : currentRow.CustomerLeader;
            erpLookUpEditWorkType.EditValue = currentRow.IsWorkTypeIdNull() ? (int?)null : currentRow.WorkTypeId;
            erpLookUpEditCompanyType.EditValue = currentRow.IsWorkTypeIdNull() ? (int?)null: currentRow.TypeId;
            lookUpParentCustomer.EditValue = currentRow.IsParentIdNull() ? (int?)null : currentRow.ParentId;
            txtVoen.Text = currentRow.IsVoenNull() ? "" : currentRow.Voen;
            erpLookUpEditCurrency.EditValue = currentRow.IsCurrencyIdNull() ? (int?)null : currentRow.CurrencyId;
            erpLookUpEditBank.EditValue = currentRow.IsBankIdNull() ? (int?)null : currentRow.BankId;
            txtBankSwift.Text = currentRow.IsBankSwiftNull() ? "" : currentRow.BankSwift;
            treeListLookUpEditRegion.EditValue = currentRow.IsRegionIdNull() ? (int?)null : currentRow.RegionId;
            txtLegalAddress.Text = currentRow.IsLegalAddressNull() ? "" : currentRow.LegalAddress;
            txtActualAddress.Text = currentRow.IsActualAddressNull() ? "" : currentRow.ActualAddress;
            txtEmail.Text = currentRow.IsEmailNull() ? "" : currentRow.Email;
            txtTel.Text = currentRow.IsTelNull() ? "" : currentRow.Tel;
            dateEditDesc.EditValue = currentRow.IsDateNull() ? (DateTime?)null : currentRow.Date;
            erpMemoExEditDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;
            

            gridViewContract.LoadData(delegate
            {
                Parameters.Clear();
                Parameters.Add("@id", currentRow.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwContract, "select * from Accounting.IFnContractCustomer(@id)", Parameters, true, System.Data.CommandType.Text);

            });

        }
        
        private void erpLookUpEditBank_EditValueChanged(object sender, EventArgs e)
        {
            txtBankSwift.Text = "";
            if (erpLookUpEditBank.EditValue == null) return;

            var current = dataSet.VwBank.FirstOrDefault(b => b.Id == Convert.ToInt32(erpLookUpEditBank.EditValue));

            txtBankSwift.Text = current.Swift;
        }

        private void treeListLookUpEditRegion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                    this.vwRegionTableAdapter.Fill(this.dataSet.VwRegion);
                }

            }
        }

        private void erpLookUpEditWorkType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (sender is erpLookUpEdit)
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
                    this.vwWorkTypeTableAdapter.Fill(this.dataSet.VwWorkType);
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

        private void erpLookUpEditBank_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (sender is erpLookUpEdit)
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

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                Parameters.Add("@operationType", operationType)

               //.Add("@id", txtNumber.Text)
               .Add("@customerName", txtCustomerName.Text)
               .Add("@customerLeader", txtCustomerLeader.Text)
               .Add("@workTypeId", erpLookUpEditWorkType.GetIntValue())
               .Add("@voen", txtVoen.Text)
               .Add("@currencyId", erpLookUpEditCurrency.GetIntValue())
               .Add("@bankId", erpLookUpEditBank.GetIntValue())
               .Add("@bankSwift", txtBankSwift.Text)
               .Add("@regionId", treeListLookUpEditRegion.GetIntValue())
               .Add("@legalAddress", txtLegalAddress.Text)
               .Add("@actualAddress", txtActualAddress.Text)
               .Add("@email", txtEmail.Text)
               .Add("@tel", txtTel.Text)
               .Add("@date", dateEditDesc.DateTime)
               .Add("@description", erpMemoExEditDescription.Text)
               .Add("@typeId", erpLookUpEditCompanyType.GetIntValue())
               .Add("@parentId",lookUpParentCustomer.GetIntValue());

                Parameters.Add("@contract", "[Accounting].[UddtContractCustomer]",
              dataSet.VwContract.GetTableByFilter("", true, "Id", "CustomerId", "ContractDate", "CurrencyId", "OperationTypeId", "CompanyId", "ContractTypeId", "Description"));
                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwCustomerRow>();

                    Parameters.Add("@id", currentRow.Id);
                }
                
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwCustomer, "[Accounting].[spCustomerContract]", Parameters, true, System.Data.CommandType.StoredProcedure);


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

        private void btnAddContracts_Click(object sender, EventArgs e)
        {
            gridControlContract.EmbeddedNavigator.Buttons.DoClick(gridControlContract.EmbeddedNavigator.Buttons.Append);
        }

        private void btnApplyContracts_Click(object sender, EventArgs e)
        {
            gridControlContract.EmbeddedNavigator.Buttons.DoClick(gridControlContract.EmbeddedNavigator.Buttons.EndEdit);
        }

        private void btnDeleteContracts_Click(object sender, EventArgs e)
        {
            gridControlContract.EmbeddedNavigator.Buttons.DoClick(gridControlContract.EmbeddedNavigator.Buttons.Remove);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlContract.EmbeddedNavigator.Buttons.DoClick(gridControlContract.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlContract.EmbeddedNavigator.Buttons.DoClick(gridControlContract.EmbeddedNavigator.Buttons.Remove);
        }

        private void btnAceptCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                Parameters.Add("@operationType", operationType)

               //.Add("@id", txtNumber.Text)
               .Add("@customerName", txtCustomerName.Text)
               .Add("@customerLeader", txtCustomerLeader.Text)
               .Add("@workTypeId", erpLookUpEditWorkType.GetIntValue())
               .Add("@voen", txtVoen.Text)
               .Add("@currencyId", erpLookUpEditCurrency.GetIntValue())
               .Add("@bankId", erpLookUpEditBank.GetIntValue())
               .Add("@bankSwift", txtBankSwift.Text)
               .Add("@regionId", treeListLookUpEditRegion.GetIntValue())
               .Add("@legalAddress", txtLegalAddress.Text)
               .Add("@actualAddress", txtActualAddress.Text)
               .Add("@email", txtEmail.Text)
               .Add("@tel", txtTel.Text)
               .Add("@date", dateEditDesc.DateTime)
               .Add("@description", erpMemoExEditDescription.Text)
               .Add("@typeId", erpLookUpEditCompanyType.GetIntValue())
               .Add("@parentId", lookUpParentCustomer.GetIntValue());

                Parameters.Add("@contract", "[Accounting].[UddtContractCustomer]",
              dataSet.VwContract.GetTableByFilter("", true, "Id", "CustomerId", "ContractDate", "CurrencyId", "OperationTypeId", "CompanyId", "ContractTypeId", "Description"));
                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwCustomerRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwCustomer, "[Accounting].[spCustomerContract]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
