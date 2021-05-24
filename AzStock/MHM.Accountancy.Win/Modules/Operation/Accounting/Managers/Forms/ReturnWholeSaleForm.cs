using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ReturnWholeSaleForm : MHMForm
    {
        public ReturnWholeSaleForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
            splitContainer.SetSplitterPercent(70);
            splitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }

        private void ReturnIncludeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwSaleContractChoose' table. You can move, or remove it, as needed.
            this.vwSaleContractChooseTableAdapter.Fill(this.dataSet.VwSaleContractChoose);
            // TODO: This line of code loads data into the 'dataSet.VwCustomer' table. You can move, or remove it, as needed.
            this.vwCustomerTableAdapter.Fill(this.dataSet.VwCustomer);
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStock' table. You can move, or remove it, as needed.
            this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);
            // TODO: This line of code loads data into the 'accountingDataSet.VwGood' table. You can move, or remove it, as needed.
            this.vwGoodTableAdapter.Fill(this.dataSet.VwGood);
            // TODO: This line of code loads data into the 'dataSet.VwIncludeContractChoose' table. You can move, or remove it, as needed.
            this.vwIncludeContractChooseTableAdapter.Fill(this.dataSet.VwIncludeContractChoose);

            // TODO: This line of code loads data into the 'accountingDataSet.vwBarcode' table. You can move, or remove it, as needed.
            this.vwBarcodeTableAdapter.Fill(this.dataSet.VwBarcode);
            // TODO: This line of code loads data into the 'dataSet.VwContract' table. You can move, or remove it, as needed.
            this.vwContractTableAdapter.Fill(this.dataSet.VwContract);
            // TODO: This line of code loads data into the 'dataSet.VwAccount' table. You can move, or remove it, as needed.
            this.vwAccountTableAdapter.Fill(this.dataSet.VwAccount);
            // TODO: This line of code loads data into the 'dataSet.VwUnit' table. You can move, or remove it, as needed.
            this.vwUnitTableAdapter.Fill(this.dataSet.VwUnit);
            // TODO: This line of code loads data into the 'accountingDataSet.VwWareHouse' table. You can move, or remove it, as needed.
            this.vwWareHouseTableAdapter.Fill(this.dataSet.VwWareHouse);
            // TODO: This line of code loads data into the 'accountingDataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);

            erpLookUpEditCompany.EditValue = 1;
         
            erpLookUpEditWareHouse.EditValue = 1;
            erpDateEditDate.DateTime = DateTime.Now;

            if (Current == null)
                return;

            txtNumber.Properties.ReadOnly = true;

            var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRow>();

            txtNumber.EditValue = currentRow.Id.ToString("000000");
            erpLookUpEditCompany.EditValue = currentRow.IsCompanyIdNull() ? (int?)null : currentRow.CompanyId;
            erpLookUpEditWareHouse.EditValue = currentRow.IsWareHouseIdNull() ? (int?)null : currentRow.WareHouseId;
            //erpLookUpEditCustomerId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
            //txtContractId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
            erpDateEditDate.DateTime = currentRow.IncludeDate.Date;

            gridViewDetail.LoadData(delegate
            {
                Parameters.Clear();
                Parameters.Add("@id", currentRow.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentDetail, "select * from Accounting.ifnIncludeGood(@id)", Parameters, true, System.Data.CommandType.Text);
                Manager.MHMContainer.AccountIdByCode(AccountResources.GoodBuyCode);
            });
        }

        private void chckPinGoodCatalog_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer.PanelVisibility = chckPinGoodCatalog.Checked ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }



        protected override void btnAccept_Click(object sender, EventArgs e)
        {

            Parameters.Clear();
            if (!erpLookUpEditCompany.Validate()
                || !erpLookUpEditWareHouse.Validate()
                ) return;


            Parameters.Add("@operationType", operationType)
                      .Add("@includeDate", erpDateEditDate.DateTime)
                      .Add("@companyId", erpLookUpEditCompany.GetIntValue())
                      .Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue())
                      //.Add("@contractId", txtContractId.Text)
                      ;
            //.Add("@customerId", erpLookUpEditCustomerId.GetIntValue());



            Parameters.Add("@detail", "[Accounting].[UddtIncludeReturn]",
            dataSet.VwDocumentDetail.GetTableByFilter
            ("", true, "Id","StoGoodId","CompanyName","CustomerName", "BarCodeId", "AccountId", "GoodId",  "Series",
                    "DateOfProduction", "LastExpirationDate", "Quantity", "UnitId"
                    , "PriceBuy", "PriceRetail", "PriceWholeSale"
                    , "AmountBuy", "AmountRetail", "AmountWholeSale", "Payment", "Deficit"));


            if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
            {
                var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRow>();

                Parameters.Add("@id", currentRow.Id);
            }

            Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocument, "[Accounting].[spDocumentReturnWholeSale]", Parameters, true, System.Data.CommandType.StoredProcedure);


            if (checkApplyNew.Checked)
            {
                base.ClearInputs();
                Manager.Loading();
                this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);
                return;
            }

            DialogResult = DialogResult.OK;
        }




        private void gridViewDetail_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)

        {
            ReCalcFunction(gridViewDetail.FocusedRowHandle, e?.PrevFocusedColumn?.FieldName);
        }

        private void ReCalcFunction(int focusedRowHandle, string fieldName)
        {
            try
            {
                decimal quantity = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Quantity"]) == DBNull.Value ? 0
                           : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Quantity"]));

                switch (fieldName)
                {
                    case "Quantity":
                    case "PriceBuy":
                        decimal priceBuy = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["PriceBuy"]) == DBNull.Value ? 0
                           : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["PriceBuy"]));
                        gridViewDetail.SetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountBuy"], quantity * priceBuy);
                        break;


                    case "PriceRetail":
                        decimal priceRetail = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["PriceRetail"]) == DBNull.Value ? 0

                            : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["PriceRetail"]));

                        gridViewDetail.SetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountRetail"], quantity * priceRetail);
                        break;

                    case "PriceWholeSale":
                        decimal priceWholeSale = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["PriceWholeSale"]) == DBNull.Value ? 0
                              : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["PriceWholeSale"]));
                        gridViewDetail.SetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountWholeSale"], quantity * priceWholeSale);
                        break;



                    case "Payment":
                        decimal amountBuy = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountBuy"]) == DBNull.Value ? 0
                            : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountBuy"]));
                        decimal payment = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Payment"]) == DBNull.Value ? 0
                            : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Payment"]));
                        gridViewDetail.SetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Deficit"], amountBuy - payment);
                        break;



                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }



        private void txtSaleRetail_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal percent = 0;
            decimal.TryParse(txtSaleRetail.Text, out percent);

            foreach (var row in selectedRows)
            {
                if ((row.Data.IsPriceRetailReserveNull() || row.Data.PriceRetailReserve == 0) && !row.Data.IsPriceRetailNull())
                    row.Data.PriceRetailReserve = row.Data.PriceRetail;

                //if ((row.IsPriceWholeSaleReserveNull() || row.PriceWholeSaleReserve == 0) && !row.IsPriceWholeSaleNull())
                //    row.PriceWholeSaleReserve = row.PriceWholeSale;

                if (!row.Data.IsPriceRetailReserveNull())
                    row.Data.PriceRetail = row.Data.PriceRetailReserve + row.Data.PriceRetailReserve * percent * 0.01M;

                gridViewDetail.RefreshRow(row.RowIndex);
                ReCalcFunction(row.RowIndex, "PriceRetail");
            }
        }

        private void txtDiscountWholeSale_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal percent = 0;
            decimal.TryParse(txtDiscountWholeSale.Text, out percent);

            foreach (var row in selectedRows)
            {
                if ((row.Data.IsPriceWholeSaleReserveNull() || row.Data.PriceWholeSaleReserve == 0) && !row.Data.IsPriceWholeSaleNull())
                    row.Data.PriceWholeSaleReserve = row.Data.PriceWholeSale;

                if (!row.Data.IsPriceWholeSaleReserveNull())
                    row.Data.PriceWholeSale = row.Data.PriceWholeSaleReserve + row.Data.PriceRetailReserve * percent * 0.01M;

                gridViewDetail.RefreshRow(row.RowIndex);
                ReCalcFunction(row.RowIndex, "PriceWholeSale");
            }
        }

        private void txtDiscountBuy_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal percent = 0;
            decimal.TryParse(txtDiscountBuy.Text, out percent);

            foreach (var row in selectedRows)
            {
                if ((row.Data.IsPriceWholeSaleReserveNull() || row.Data.PriceBuyReserve == 0) && !row.Data.IsPriceBuyNull())
                    row.Data.PriceBuyReserve = row.Data.PriceBuy;

                if (!row.Data.IsPriceBuyReserveNull())
                    row.Data.PriceBuy = row.Data.PriceBuyReserve + row.Data.PriceBuyReserve * percent * 0.01M;

                gridViewDetail.RefreshRow(row.RowIndex);
                ReCalcFunction(row.RowIndex, "PriceBuy");
            }
        }


        
        private void erpLookUpEditCustomerId_EditValueChanged(object sender, EventArgs e)
        {
            //txtContractId.EditValue = "";
            //if (erpLookUpEditCustomerId.EditValue == null) return;
            //var current = dataSet.VwIncludeContractChoose.FirstOrDefault(icc => icc.Id == erpLookUpEditCustomerId.GetIntValue());

            //if (current == null) return;
            //txtContractId.EditValue = current.Id;
        }


        private void detailView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var selected = (gridViewStock.GetFocusedRow() as DataRowView)?.Row as AccountingDataSet.VwGoodRow;
            if (selected == null) return;

            if (!dataSet.VwDocumentDetail.AsEnumerable().Any(g => g.GoodId == selected.Id))
                dataSet.VwDocumentDetail.AddVwDocumentDetailRow(
                       StoGoodId: 0
                    , DocumentId: 0
                    ,CompanyId:0
                    , CompanyName: ""
                    ,CustomerId:0
                    , CustomerName: ""
                    , AccountId: 0
                    , AccountParentId: 0
                    , AccountCode: ""
                    , AccountName: ""
                    , GoodId: selected.Id
                    , GoodName: ""
                    , BarCodeId: 0
                    , FullGoodName: ""
                    , Series: ""
                    , DateOfProduction: DateTime.Now
                    , LastExpirationDate: DateTime.Now
                    , Quantity: 0
                    , UnitId: 0
                    , UnitName: ""
                    , PriceBuyReserve: 0
                    , PriceBuy:  0
                    , PriceRetailReserve: 0
                    , PriceRetail: 0
                    , PriceWholeSaleReserve: 0
                    , PriceWholeSale:0
                    , AmountBuy: 0
                    , AmountRetail: 0
                    , AmountWholeSale: 0
                    , Payment: 0
                    , Deficit: 0);
        }

     
        private void gridControlStock_DoubleClick(object sender, EventArgs e)
        {
            var selected = (gridViewStock.GetFocusedRow() as DataRowView)?.Row as AccountingDataSet.VwGoodStockRow;
            if (selected == null) return;

            if (!dataSet.VwDocumentDetail.AsEnumerable().Any(g => g.GoodId == selected.Id))
                dataSet.VwDocumentDetail.AddVwDocumentDetailRow(

                     StoGoodId: 0
                    , DocumentId: 0
                    ,CompanyId:0
                    , CompanyName: ""
                    ,CustomerId:0
                    , CustomerName: ""
                    , AccountId: 0
                    , AccountParentId: 0
                    , AccountCode: ""
                    , AccountName: ""
                    , GoodId: selected.Id
                    , GoodName: ""
                    , BarCodeId: 0
                    , FullGoodName: ""
                    , Series: ""
                    , DateOfProduction: DateTime.Now
                    , LastExpirationDate: DateTime.Now
                    , Quantity: 0
                    , UnitId: 0
                    , UnitName: ""
                    , PriceBuyReserve: 0
                    , PriceBuy:
                    //prices != null && !prices.IsPriceBuyNull() ? prices.PriceBuy :
                    0
                    , PriceRetailReserve: 0
                    , PriceRetail:
                    //prices != null && !prices.IsPriceRetailNull() ? prices.PriceRetail :
                    0
                    , PriceWholeSaleReserve: 0
                    , PriceWholeSale:
                    //prices != null && !prices.IsPriceWholeSaleNull() ? prices.PriceWholeSale :
                    0
                    , AmountBuy: 0
                    , AmountRetail: 0
                    , AmountWholeSale: 0
                    , Payment: 0
                    , Deficit: 0);

        }
        private void gridViewStock_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            var masterView = sender as GridView;
            var detailView = masterView.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;

            detailView.Columns["Id"].Visible = detailView.Columns["GoodId"].Visible = false;
            detailView.Columns["GoodId"].OptionsColumn.AllowEdit = false;
            detailView.Columns["CustomerId"].OptionsColumn.AllowEdit = false;
            //detailView.Columns["Barcode"].OptionsColumn.AllowEdit = false;

           // detailView.Columns["BarcodeId"].OptionsColumn.ReadOnly = true;

            detailView.RowCellClick -= detailView_RowCellClick;
            detailView.RowCellClick += detailView_RowCellClick;
        }
        
        private void IncludeForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gridViewDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;

            var current = vwGoodBindingSource.GetBindingRow<AccountingDataSet.VwGoodRow>();

            if (current == null) {
                vwBarcodeTableAdapter.Fill(dataSet.VwBarcode);
                return;
            }

            vwBarcodeTableAdapter.FillByGoodId(dataSet.VwBarcode,current.Id);

        }

        private void repoCustomer_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void repoIncludedGood_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());
            if (good == null)
            {
                vwBarcodeTableAdapter.Fill(dataSet.VwBarcode);
                return;
            }

            vwBarcodeTableAdapter.FillByGoodId(dataSet.VwBarcode, good.Id);

            var barcode = dataSet.VwBarcode.FirstOrDefault(b => b.Barcode == lookup.ToString());
            if (barcode == null) return;


            var customer = dataSet.VwCustomer.FirstOrDefault(c => c.Id == lookup.GetIntValue());
            if (customer == null)
            {
                vwCustomerTableAdapter.Fill(dataSet.VwCustomer);
                return;
            }

            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();
            current.UnitId = good.UnitId;
            current.BarCodeId = barcode.Id;
            current.GoodId = current.Id;
            current.CustomerName = current.CustomerName;
      //     current.AccountId = Manager.MHMContainer.AccountIdByCode(ReturnWholeSale.ReturnIncludeGood);

        }

        private void repoBarcode_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var barcode = dataSet.VwBarcode.FirstOrDefault(b => b.Id == lookup.GetIntValue());
            if (barcode == null) return;


            var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());
            if (good == null) return;

            //var document = dataSet.VwDocument.FirstOrDefault(d => d.Id == lookup.GetIntValue());
            //if (document == null) return;

            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();



            current.UnitId = good.UnitId;
            current.GoodId = good.Id;
            current.BarCodeId = good.Id;
            current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.ReturnRetailSaleCode);

            //current.CustomerId = good.Id;

            current.Quantity = good.Id;
            current.PriceRetail = good.Id;
            current.AmountRetail = good.Id;
            current.Payment = good.Id;
            current.Deficit = good.Id;

        }



        private void erpLookUpEditCompany_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new CompanyForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);
                }

            }
        }

        private void erpLookUpEditWareHouse_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new WareHouseForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwWareHouseTableAdapter.Fill(this.dataSet.VwWareHouse);
                }
            }
        }
    }
}
