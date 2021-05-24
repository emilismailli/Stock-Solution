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
using System.Linq;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class CashForm : MHMForm
    {
        public CashForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);

            Parameters.Clear();
            Parameters.Add("@menuId", Manager.Id);
            //Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);
            Parameters.Clear();

            //erpLookUpEditWareHouse.EditValue = dataSet.spWareHouseSelect.FirstOrDefault().Id;

            this.ActiveControl = erpLookUpEditCompany;
            vwCashTableAdapter.Fill(dataSet.VwCash);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwCashRow>();
            if (current == null)
                return;

            erpLookUpEditCompany.EditValue = current.CompanyId;
            txtCash.Text = current.CashName;
            txtBalance.EditValue=current.IsBalanceNull() ? (decimal?)null : current.Balance;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;

            //erpLookUpEditWareHouse.EditValue=current.WareHouseId; 



        }

 

        

        private void btnAcceptCash_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var current = Current.GetBindingRow<AccountingDataSet.VwCashRow>();
                if (operationType == OperationType.Edit && current != null)
                {
                    vwCashTableAdapter.UpdateQuery(

                            Convert.ToInt32(erpLookUpEditCompany.EditValue)
                          , txtCash.Text
                          , Convert.ToDecimal(txtBalance.EditValue)
                          //, Convert.ToInt32(erpLookUpEditWareHouse.EditValue) 
                          , txtDescription.Text 
                          , current.Id);
                }
                else
                    vwCashTableAdapter.InsertQuery(
                            Convert.ToInt32(erpLookUpEditCompany.EditValue)  
                          , txtCash.Text
                          , Convert.ToDecimal(txtBalance.EditValue)
                          //, Convert.ToInt32(erpLookUpEditWareHouse.EditValue)
                          , txtDescription.Text );

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
