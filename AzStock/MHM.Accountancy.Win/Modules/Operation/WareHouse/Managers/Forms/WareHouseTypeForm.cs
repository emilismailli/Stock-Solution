using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Data;
using System;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Utils;

namespace MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms
{
    public partial class WareHouseTypeForm : MHMForm
    {
        public WareHouseTypeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
            : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }


        internal WareHouseTypeForm(IManager manager,WareHouseDataSet dataSet, OperationType operationType)
             : this(manager, null, dataSet, operationType)
        {
           
        }
        internal  WareHouseTypeForm(IManager manager, BindingSource bindingSource, WareHouseDataSet dataSet, OperationType operationType)
            : this(manager, bindingSource, operationType)
        {
            this.dataSet = dataSet;
            this.ApplyBindingSourcesDataSet(this.dataSet);
        }

 

        private void WareHouseTypeForm_Load(object sender, EventArgs e)
        {
            if (operationType == OperationType.Add)
                return;

            var current = Current.GetBindingRow<WareHouseDataSet.WareHouseTypeRow>();
            if (current == null)
                return;

            txtName.Text = current.Name;
            txtDescription.Text = current.IsDescriptionNull() ? "" : current.Description;
        }
        protected override void btnAccept_Click(object sender, EventArgs e)
        {
            Manager.MHMContainer.InvokeAction(delegate
            {
                Parameters.Clear();
                if (!txtName.Validate()
                ) return;

                Parameters.Add("@operationType", operationType)
                .Add("@name", txtName.Text)
                .Add("@description", txtDescription.Text);

                //if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                //    Parameters.Add("@description", txtDescription.Text);
  

                if(operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<WareHouseDataSet.WareHouseTypeRow>();
                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwWareHouse, "[WareHouses].[spWareHouseType]", Parameters, true, System.Data.CommandType.StoredProcedure);


                this.DialogResult = DialogResult.OK;
            });
            
        }
    }
}

