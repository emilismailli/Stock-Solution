using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using System;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class UserForm : MHMForm
    {
        public UserForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, System.EventArgs e)
        { 
            
            // TODO: This line of code loads data into the 'accountingDataSet.VwRegion' table. You can move, or remove it, as needed.
            this.vwRegionTableAdapter.Fill(this.dataSet.VwRegion); 
            // TODO: This line of code loads data into the 'accountingDataSet.VwRoleType' table. You can move, or remove it, as needed.
            this.vwRoleTypeTableAdapter.Fill(this.dataSet.VwRoleType);





            vwUserTableAdapter.Fill(dataSet.VwUser);
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<AccountingDataSet.VwUserRow>();
            if (current == null)
                return;

            //txtUserNo.Text = current.UserNo;
            txtUserName.Text = current.UserName;
            txtUserSurname.Text = current.UserSurname;
            txtUserPatryonmic.Text = current.UserPatryonmic;
            txtPin.Text = current.Pin.ToString();
            erpLookUpEditRoleTypeName.EditValue = current.RoleId;
            erpDateEditBirthDate.EditValue = current.BirthOfDate;
            txtLogin.Text = current.Login;
            txtPassword.Text = current.Password; 
            treeListLookUpEditRegion.EditValue = current.RegionName;
            txtAddress.Text = current.Address;
            txtDescription.Text = current.Description;
            LBLid.Text = current.Id.ToString();
        }


        private void erpLookUpEditRoleTypeName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is LookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new RoleTypeForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwRoleTypeTableAdapter.Fill(dataSet.VwRoleType);
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
                    this.vwRegionTableAdapter.Fill(dataSet.VwRegion);
                }
            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (operationType == OperationType.Edit)
                {
                    vwUserTableAdapter.UpdateQuery(
                         txtUserName.Text
                        , txtUserSurname.Text
                        , txtUserPatryonmic.Text
                        , txtPin.Text
                        , Convert.ToInt32(erpLookUpEditRoleTypeName.EditValue)
                        , txtLogin.Text
                        , txtPassword.Text
                        , erpDateEditBirthDate.DateTime
                        , Convert.ToInt32(treeListLookUpEditRegion.EditValue)
                        , txtAddress.Text
                        , txtDescription.Text
                        , int.Parse(LBLid.Text)
                         );


                }
                else
                    vwUserTableAdapter.InsertQuery(

                         txtUserName.Text
                        , txtUserSurname.Text
                        , txtUserPatryonmic.Text
                        , txtPin.Text
                        , Convert.ToInt32(erpLookUpEditRoleTypeName.EditValue)
                        , txtLogin.Text
                        , txtPassword.Text
                        , erpDateEditBirthDate.DateTime
                        , Convert.ToInt32(treeListLookUpEditRegion.EditValue)
                        , txtAddress.Text
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
