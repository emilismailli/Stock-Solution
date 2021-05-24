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
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Business.Properties;
using DevExpress.XtraEditors;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ChangedPriceForm : MHMForm
    {
        public ChangedPriceForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
         : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();

        }
        

        private void ChangedPriceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStockSelect' table. You can move, or remove it, as needed.
            this.vwGoodStockSelectTableAdapter.Fill(this.accountingDataSet.VwGoodStockSelect);
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodSelect' table. You can move, or remove it, as needed.
            this.vwGoodSelectTableAdapter.Fill(this.accountingDataSet.VwGoodSelect);
            // TODO: This line of code loads data into the 'accountingDataSet.VwBarcodeSelect' table. You can move, or remove it, as needed.
            this.vwBarcodeSelectTableAdapter.Fill(this.accountingDataSet.VwBarcodeSelect);
            // TODO: This line of code loads data into the 'accountingDataSet.WareHouse' table. You can move, or remove it, as needed.
            this.wareHouseTableAdapter.Fill(this.accountingDataSet.WareHouse);
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStock' table. You can move, or remove it, as needed.
            this.vwGoodStockTableAdapter.Fill(this.accountingDataSet.VwGoodStock);

            // TODO: This line of code loads data into the 'accountingDataSet.VwGood' table. You can move, or remove it, as needed.
            this.vwGoodTableAdapter.Fill(this.accountingDataSet.VwGood);
            // TODO: This line of code loads data into the 'accountingDataSet.VwLastPrice' table. You can move, or remove it, as needed.
            this.vwLastPriceTableAdapter.Fill(this.accountingDataSet.VwLastPrice);
            var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRow>();

          

        }

 
        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colGoodName;
        }

        private void btnApplyGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colGoodName;
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colGoodName;
            
        }

        


        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //Parameters.Clear();
                //if (!erpLookUpEditCompany.Validate()
                //    || !erpLookUpEditWareHouse.Validate()
                //    ) return;




                Parameters.Clear();
                Parameters.Add("@description", txtDescription.Text);



                Parameters.Add("@detail", "[Accounting].[UddtChangePrice]",
                accountingDataSet.VwDocumentDetail.GetTableByFilter("GoodId IS NOT NULL", true,"GoodId","PriceBuy", "PriceRetail", "PriceWholeSale", "NewPriceBuy", "NewPriceRetail","NewPriceWholeSale"));


                

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwDocument, "[Accounting].[spChangePrice]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    this.vwGoodStockTableAdapter.Fill(this.accountingDataSet.VwGoodStock);
                    return;
                }
                DialogResult = DialogResult.OK;
            }
        }


        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountRetail_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal discountRetail = 0;
            decimal.TryParse(txtDiscountRetail.Text, out discountRetail);

            foreach (var row in selectedRows)
            { 
                if ((row.Data.IsPriceRetailReserveNull() || row.Data.PriceRetailReserve == 0) && !row.Data.IsPriceRetailNull())
                    row.Data.PriceRetailReserve = row.Data.PriceRetail;

                if (!row.Data.IsPriceRetailReserveNull())
                    row.Data.NewPriceRetail = row.Data.PriceRetailReserve + row.Data.PriceRetailReserve * discountRetail * -0.01M;

                gridViewDetail.RefreshRow(row.RowIndex);

                
            }
        }

        private void txtDiscountWholeSale_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal discountWholeSale = 0;
            decimal.TryParse(txtDiscountWholeSale.Text, out discountWholeSale);

            foreach (var row in selectedRows)
            {
                if ((row.Data.IsPriceWholeSaleReserveNull() || row.Data.PriceWholeSaleReserve == 0) && !row.Data.IsPriceWholeSaleNull())
                    row.Data.PriceWholeSaleReserve = row.Data.PriceWholeSale;

                if (!row.Data.IsPriceWholeSaleReserveNull())
                    row.Data.NewPriceWholeSale = row.Data.PriceWholeSaleReserve + row.Data.PriceWholeSaleReserve * discountWholeSale * -0.01M;

                gridViewDetail.RefreshRow(row.RowIndex);

            }
        }
        private void repoBarcode_EditValueChanged(object sender, EventArgs e)
        {
            
            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var good = accountingDataSet.VwGoodSelect.FirstOrDefault(g => g.Id == lookup.GetIntValue());

            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();

            var searchF = vwDocumentDetailBindingSource.Find("Barcode", good.Id);
            
            if (searchF>=0)
            {
                DialogResult dialog = MessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                lookup.EditValue = default;

                return;
            }
            current.GoodId = good.Id;
            current.BarCodeId = good.BarcodeId;
            //current.Barcode = barcode.Barcode;
            current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
            current.PriceWholeSale = Manager.MHMContainer.GoodPriceWholeById(good.Id).Value;
            current.PriceRetail = Manager.MHMContainer.RetailPricesByGoodId(good.Id).Value;
            
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
        }

        private void repoGood_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var good = accountingDataSet.VwGoodSelect.FirstOrDefault(g => g.Id == lookup.GetIntValue());

            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();

            var searchF = vwDocumentDetailBindingSource.Find("Barcode", good.Id);

            if (searchF >= 0)
            {
                DialogResult dialog = MessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                lookup.EditValue = default;

                return;
            }
            current.GoodId = good.Id;
            current.BarCodeId = good.BarcodeId;
            //current.Barcode = barcode.Barcode;
            current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
            current.PriceWholeSale = Manager.MHMContainer.GoodPriceWholeById(good.Id).Value;
            current.PriceRetail = Manager.MHMContainer.RetailPricesByGoodId(good.Id).Value;

            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);

            //var lookup = (LookUpEdit)sender;
            //if (lookup.EditValue == null) return;
            //var good = accountingDataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());
            //var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();
            //var searchF = vwDocumentDetailBindingSource.Find("BarCodeId", good.BarcodeId);

            //if (searchF >= 0)
            //{
            //    DialogResult dialog = XtraMessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
            //    lookup.EditValue = default;
            //    return; DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {

                //Parameters.Clear();
                //if (!erpLookUpEditCompany.Validate()
                //    || !erpLookUpEditWareHouse.Validate()
                //    ) return;




                Parameters.Clear();
                Parameters.Add("@description", txtDescription.Text);



                Parameters.Add("@detail", "[Accounting].[UddtChangePrice]",
                accountingDataSet.VwDocumentDetail.GetTableByFilter("GoodId IS NOT NULL", true, "GoodId", "PriceBuy", "PriceRetail", "PriceWholeSale", "NewPriceBuy", "NewPriceRetail", "NewPriceWholeSale"));




                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwDocument, "[Accounting].[spChangePrice]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    this.vwGoodStockTableAdapter.Fill(this.accountingDataSet.VwGoodStock);
                    return;
                }
                DialogResult = DialogResult.OK;
            }
            //}
            //current.UnitId = good.UnitId;
            //current.GoodId = current.Id;
            //current.BarCodeId = good.BarcodeId;
            //current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
            //current.PriceWholeSale = Manager.MHMContainer.GoodPriceWholeById(good.Id).Value;
            //current.PriceRetail = Manager.MHMContainer.RetailPricesByGoodId(good.Id).Value;
            //current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.GoodBuyCode).Value;
            //gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colGoodName;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colGoodName;
        }

        private void btnAcceptPrice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //Parameters.Clear();
                //if (!erpLookUpEditCompany.Validate()
                //    || !erpLookUpEditWareHouse.Validate()
                //    ) return;




                Parameters.Clear();
                Parameters.Add("@description", txtDescription.Text);



                Parameters.Add("@detail", "[Accounting].[UddtChangePrice]",
                accountingDataSet.VwDocumentDetail.GetTableByFilter("GoodId IS NOT NULL", true, "GoodId", "PriceBuy", "PriceRetail", "PriceWholeSale", "NewPriceBuy", "NewPriceRetail", "NewPriceWholeSale"));




                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwDocument, "[Accounting].[spChangePrice]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    this.vwGoodStockTableAdapter.Fill(this.accountingDataSet.VwGoodStock);
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
