
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms
{
    public partial class WareHouseForm : MHMForm
    {
        public WareHouseForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }


        private void WareHouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);


            wareHouseTypeAdapter.Fill(dataSet.WareHouseType);

            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<WareHouseDataSet.VwWareHouseRow>();
            if (current == null)
                return;
             
            txtWareHouseName.Text = current.Name;
            lookUpParentCompany.EditValue = current.CompanyId;
            lookUpEditWareHouseTypeId.EditValue = current.WareHouseTypeId;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }

        

        private void lookUpEditWareHouseTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is LookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new WareHouseTypeForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var current = Current.GetBindingRow<WareHouseDataSet.VwWareHouseRow>();
            if (operationType == OperationType.Edit && current != null)
            {
                vwWareHouseTableAdapter.UpdateQuery(
                      Convert.ToInt32(lookUpParentCompany.EditValue)
                    , txtWareHouseName.Text
                    , Convert.ToInt32(lookUpEditWareHouseTypeId.EditValue)
                    , txtDescription.Text, true
                
                    
                    , current.Id

                    );
            }
            else
                vwWareHouseTableAdapter.InsertQuery(
                    Convert.ToInt32(lookUpParentCompany.EditValue)
                    , txtWareHouseName.Text
                    , Convert.ToInt32(lookUpEditWareHouseTypeId.EditValue)
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
