using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Identity;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class InventorForm : MHMForm
    {
        public InventorForm(IManager manager, BindingSource bindingSource, OperationType operationType)
          : base(manager, bindingSource, operationType)
        {
            InitializeComponent();



        }

        private void InventorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.Inventar' table. You can move, or remove it, as needed.
            this.inventarTableAdapter.Fill(this.accountingDataSet.Inventar);

            Parameters.Clear();
            Parameters.Add("@menuId", Manager.Id);
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);

            try
            {
          

               
                if (Current == null)
                    return;


                var currentRow = Current.GetBindingRow<AccountingDataSet.spDocumentInventarSelectRow>();
                gridView1.LoadData(delegate
                {
                    Parameters.Clear();
                    Parameters.Add("@documentInventarId", currentRow.Id)
                    .Add("@operationType", OperationType.Select)
                    .Add("@menuId", 42)
                    .Add("@wareHouseId", accountingDataSet.spWareHouseSelect.FirstOrDefault().Id);
                    Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.Inventar, "[Accounting].[spInventar]", Parameters, true, System.Data.CommandType.StoredProcedure);

                });
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Sizin Hec bir anbara icazeniz yoxdur!!!");
                DialogResult = DialogResult.OK;
            }
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStock' table. You can move, or remove it, as needed.







        }

       

        

       

    }
}
