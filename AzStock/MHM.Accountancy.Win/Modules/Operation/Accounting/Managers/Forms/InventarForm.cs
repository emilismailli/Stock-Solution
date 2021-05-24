using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using System.Text.RegularExpressions;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class InventarForm : MHMForm
    {
        public InventarForm(IManager manager, BindingSource bindingSource, OperationType operationType)
          : base(manager, bindingSource, operationType)
        {
            InitializeComponent();



        }

        private void InventarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwBarcodeSelect' table. You can move, or remove it, as needed.
            this.vwBarcodeSelectTableAdapter.Fill(this.accountingDataSet.VwBarcodeSelect);
            try
            {

                this.AcceptButton = null;
                this.vwGoodStockTableAdapter.Fill(this.accountingDataSet.VwGoodStock);

                Parameters.Clear();
                Parameters.Add("@menuId", Manager.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);

                // TODO: This line of code loads data into the 'accountingDataSet.VwBarcode' table. You can move, or remove it, as needed.
                this.vwBarcodeTableAdapter.Fill(this.accountingDataSet.VwBarcode);
                // TODO: This line of code loads data into the 'accountingDataSet.VwDocumentDetail' table. You can move, or remove it, as needed.
                this.vwDocumentDetailTableAdapter.Fill(this.accountingDataSet.VwDocumentDetail);
                erpLookUpEdit1.EditValue = accountingDataSet.spWareHouseSelect.FirstOrDefault().Id;

                Parameters.Clear();
                Parameters.Add("@wareHouseId", erpLookUpEdit1.GetIntValue());
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spGetGoodStock, "[dbo].[spGetGoodStock]", Parameters, true, System.Data.CommandType.StoredProcedure);
                //Manager.MHMContainer.AccountIdByCode(AccountResources.GoodBuyCode);

                if (Current == null)
                    return;
                

                var currentRow = Current.GetBindingRow<AccountingDataSet.spDocumentInventarSelectRow>();
                gridView1.LoadData(delegate
                {
                    Parameters.Clear();
                    Parameters.Add("@documentInventarId", currentRow.Id)
                    .Add("@operationType", OperationType.Select)
                    .Add("@menuId",42)
                    .Add("@wareHouseId",erpLookUpEdit1.GetIntValue());
                    Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spInventar, "[Accounting].[spInventar]", Parameters, true, System.Data.CommandType.StoredProcedure);

                });
                
                erpLookUpEditBarcode.Focus();
                ActiveControl = erpLookUpEditBarcode;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Sizin Hec bir anbara icazeniz yoxdur!!!");
                DialogResult = DialogResult.OK;
            }
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStock' table. You can move, or remove it, as needed.




        }

        private void erpLookUpEditBarcode_EditValueChanged(object sender, EventArgs e)
     
        {
            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var id = lookup.EditValue;
            decimal selectRealQuantity;
            decimal selectDeficitQuantity;
            decimal selectQuantity;
            var barcode = accountingDataSet.VwBarcode.FirstOrDefault(g => g.Id == Convert.ToInt32(lookup.EditValue));


            var good = accountingDataSet.spGetGoodStock.FirstOrDefault(m => m.Id == barcode.GoodId);
            selectQuantity = good.Quantity;
            selectRealQuantity = good.IsRealQuantityNull()?0: good.RealQuantity;
            selectDeficitQuantity = good.IsDeficitQuantityNull() ? 0 : good.DeficitQuantity;



            selectRealQuantity++;
            selectDeficitQuantity = selectRealQuantity - selectQuantity;
            accountingDataSet.spGetGoodStock.FirstOrDefault(m => m.Id == barcode.GoodId).RealQuantity = selectRealQuantity;
            accountingDataSet.spGetGoodStock.FirstOrDefault(m => m.Id == barcode.GoodId).DeficitQuantity = selectDeficitQuantity;


            lookup.EditValue = default;

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Parameters.Clear();
                Parameters.Add("@operationType", operationType)
                    .Add("@wareHouseId", erpLookUpEdit1.GetIntValue())
                    .Add("@menuId", 42);




                Parameters.Add("@detail", "[Accounting].[UddtInventor]",
                accountingDataSet.spGetGoodStock.GetTableByFilter("Id IS NOT NULL", true, "Id", "FullGoodName", "Quantity", "RealQuantity", "DeficitQuantity"));


                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.Inventar, "[Accounting].[spInventar]", Parameters, true, System.Data.CommandType.StoredProcedure);


                DialogResult = DialogResult.OK;
            }
        }

        private void erpLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            Parameters.Clear();
            Parameters.Add("@wareHouseId", erpLookUpEdit1.GetIntValue());
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spGetGoodStock, "[dbo].[spGetGoodStock]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            var full= gridView1.GetFocusedRowCellValue(colFullGoodName).ToString();
            var selected2 = gridView1.GetFocusedRowCellValue(colRealQuantity).ToString();
            var selected3 = gridView1.GetFocusedRowCellValue(colQuantity).ToString();

            accountingDataSet.spGetGoodStock.FirstOrDefault(m => m.FullGoodName == full).DeficitQuantity = Convert.ToDecimal(selected2) - Convert.ToDecimal(selected3);

            //gridView1.GetFocusedRowCellValue(colDeficitQuantity) = (selected2 - selected3);



        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAcceptInventar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Parameters.Clear();
                Parameters.Add("@operationType", operationType)
                    .Add("@wareHouseId", erpLookUpEdit1.GetIntValue())
                    .Add("@menuId", 42);




                Parameters.Add("@detail", "[Accounting].[UddtInventor]",
                accountingDataSet.spGetGoodStock.GetTableByFilter("Id IS NOT NULL", true, "Id", "FullGoodName", "Quantity", "RealQuantity", "DeficitQuantity"));


                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.Inventar, "[Accounting].[spInventar]", Parameters, true, System.Data.CommandType.StoredProcedure);


                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
