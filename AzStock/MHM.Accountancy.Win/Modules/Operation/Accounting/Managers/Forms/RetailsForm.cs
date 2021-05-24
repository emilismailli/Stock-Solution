using DevExpress.XtraEditors;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using System.Text;
using System.Text.RegularExpressions;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class RetailsForm : MHMForm
    {
        public RetailsForm(IManager manager,  BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
            splitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }

        private void RetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwRetailSaleContractChoose' table. You can move, or remove it, as needed.
            this.vwRetailSaleContractChooseTableAdapter.Fill(this.dataSet.VwRetailSaleContractChoose);
            // TODO: This line of code loads data into the 'dataSet.WareHouse' table. You can move, or remove it, as needed.
            this.wareHouseTableAdapter.Fill(this.dataSet.WareHouse);
            // TODO: This line of code loads data into the 'dataSet.VwPaymentType' table. You can move, or remove it, as needed.
            this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);
         // TODO: This line of code loads data into the 'dataSet.VwIncludeContractChoose' table. You can move, or remove it, as needed.
            this.vwSaleContractChooseTableAdapter.Fill(this.dataSet.VwSaleContractChoose);
            // TODO: This line of code loads data into the 'dataSet.VwGoodStock' table. You can move, or remove it, as needed.
            this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);
            // TODO: This line of code loads data into the 'dataSet.VwBarcode' table. You can move, or remove it, as needed.
            this.vwBarcodeTableAdapter.Fill(this.dataSet.VwBarcode);
            // TODO: This line of code loads data into the 'dataSet.VwSaleContractChoose' table. You can move, or remove it, as needed.
            this.vwSaleContractChooseTableAdapter.Fill(this.dataSet.VwSaleContractChoose);
            // TODO: This line of code loads data into the 'dataSet.VwGood' table. You can move, or remove it, as needed.
            this.vwGoodTableAdapter.Fill(this.dataSet.VwGood);
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

            erpLookUpEditPaymentType.EditValue = 1;
            erpLookUpEditCompany.EditValue = 1;
            erpLookUpEditWareHouse.EditValue = 1;
            erpDateEditDate.DateTime = DateTime.Now;

            if (Current == null)
                return;

            txtNumber.Properties.ReadOnly = true;

            var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRetailsSaleRow>();

            txtNumber.EditValue = currentRow.Id.ToString("000000");
            erpLookUpEditCompany.EditValue = currentRow.IsCompanyIdNull() ? (int?)null : currentRow.CompanyId;
            erpLookUpEditWareHouse.EditValue = currentRow.IsWareHouseIdNull() ? (int?)null : currentRow.WareHouseId;
            erpLookUpEditCustomerId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
            txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;
            txtContractId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
            erpLookUpEditPaymentType.EditValue = currentRow.IsPaymentTypeIdNull() ? (int?)null : currentRow.PaymentTypeId;
            erpDateEditDate.DateTime = currentRow.IncludeDate;

            gridViewDetail.LoadData(delegate
            {
                Parameters.Clear();
                Parameters.Add("@id", currentRow.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentDetail, "select * from Accounting.ifnSaleGood(@id)", Parameters, true, System.Data.CommandType.Text);
                Manager.MHMContainer.AccountIdByCode(AccountResources.GoodSaleCode);
            });
        }

        private void chckPinGoodCatalog_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer.PanelVisibility = chckPinGoodCatalog.Checked ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }


        protected override void btnAccept_Click(object sender, EventArgs e)
        {

            

            //if (checkApplyNew.Checked)
            //{
            //    base.ClearInputs();
            //    Manager.Loading();
            //    return;
            //}

            // DialogResult = DialogResult.OK;
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
                        decimal amountWholeSale = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountWholeSale"]) == DBNull.Value ? 0
                            : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountWholeSale"]));
                        decimal payment = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Payment"]) == DBNull.Value ? 0
                            : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Payment"]));
                        gridViewDetail.SetRowCellValue(focusedRowHandle, gridViewDetail.Columns["Deficit"], amountWholeSale - payment);
                        break;



                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }



 
        private void txtDiscountRetailSale_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal percent = 0;
            decimal.TryParse(txtDiscountRetailSale.Text, out percent);

            foreach (var row in selectedRows)
            {
                row.Data.Percent = txtDiscountRetailSale.Text;
                if ((row.Data.IsPriceRetailReserveNull() || row.Data.PriceRetailReserve == 0) && !row.Data.IsPriceRetailNull())
                    row.Data.PriceRetailReserve = row.Data.PriceRetail;

                if (!row.Data.IsPriceRetailReserveNull())
                    row.Data.PriceRetail = row.Data.PriceRetailReserve + row.Data.PriceRetailReserve * percent * (-0.01M);

                gridViewDetail.RefreshRow(row.RowIndex);
                ReCalcFunction(row.RowIndex, "PriceRetail");
            }
        }

      
      
        private void gridViewDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (e.FocusedRowHandle < 0) return;

            var current = vwGoodBindingSource.GetBindingRow<AccountingDataSet.VwGoodRow>();
            current = null;
            if (current == null)
            {
                vwBarcodeTableAdapter.Fill(dataSet.VwBarcode);
                return;
            }

            vwBarcodeTableAdapter.FillByGoodId(dataSet.VwBarcode, current.Id);
        }

        private void gridControlStock_DoubleClick(object sender, EventArgs e)
        {
            //var selected = (gridViewStock.GetFocusedRow() as DataRowView)?.Row as AccountingDataSet.VwGoodStockRow;
            //if (selected == null) return;
            //Parameters.Clear();
            //Parameters.Add("@id", selected.Id);
            //Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.IFnPricesByGoodId, "select * from [Accounting].[IFnPricesByGoodId](@id)", Parameters, true, System.Data.CommandType.Text);

            //var prices = dataSet.IFnPricesByGoodId.FirstOrDefault();

            //if (!dataSet.VwDocumentDetail.AsEnumerable().Any(g => g.GoodId == selected.Id))
            //    dataSet.VwDocumentDetail.AddVwDocumentDetailRow(
            //           StoGoodId: 0
            //        , DocumentId: 0
            //        ,CompanyId:0
            //        ,CompanyName:""
            //        ,CustomerId:0
            //        ,CustomerName:""
            //        , AccountId: 0
            //        , AccountParentId: 0
            //        , AccountCode: ""
            //        , AccountName: ""
            //        , GoodId: selected.Id
            //        , GoodName: ""
            //        , BarCodeId: 0
            //          , Barcode: ""
            //        , FullGoodName: ""
            //        , Series: ""
            //        , DateOfProduction: DateTime.Now
            //        , LastExpirationDate: DateTime.Now
            //        , Quantity: 0
            //        , UnitId: 0
            //        , UnitName: ""
            //        , PriceBuyReserve: 0
            //        , PriceBuy: prices != null && !prices.IsPriceBuyNull() ? prices.PriceBuy : 0
            //        , PriceRetailReserve: 0
            //        , PriceRetail: prices != null && !prices.IsPriceRetailNull() ? prices.PriceRetail : 0
            //        , PriceWholeSaleReserve: 0
            //        , PriceWholeSale: prices != null && !prices.IsPriceWholeSaleNull() ? prices.PriceWholeSale : 0
            //        , AmountBuy: 0
            //        , AmountRetail: 0
            //        , AmountWholeSale: 0
            //        , Payment: 0
            //        , Deficit: 0
            //         , Description: "" 
            //         ,Percent:""
            //         , NewPriceRetail: 0
            //         , NewPriceWholeSale: 0
            //          , DeficitQuantity: 0
            //         , RealQuantity: 0
            //        );

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
                    this.wareHouseTableAdapter.Fill(this.dataSet.WareHouse);
                }

            }
        }

        private void erpLookUpEditCustomerId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new CustomerContractForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwSaleContractChooseTableAdapter.Fill(this.dataSet.VwSaleContractChoose);
                }
            }
        }

        private void erpLookUpEditCustomerId_EditValueChanged(object sender, EventArgs e)
        {
            txtContractId.Text = "";
            if (erpLookUpEditCustomerId.GetIntValue() == null) return;
            var current = dataSet.VwRetailSaleContractChoose.FirstOrDefault(scc => scc.ContractId == erpLookUpEditCustomerId.GetIntValue());
            if (current == null) return;

            txtContractId.EditValue = current.ContractId;
        }

        private void erpLookUpEditPaymentType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new PaymentTypeForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }
                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);
                }
            }
        }


        private void btnPrintDocument_Click(object sender, EventArgs e)
        {
            Manager.InvokeAction(delegate
            {
                var row = Current.GetBindingRow<AccountingDataSet.VwDocumentRetailsSaleRow>();
                if (row != null)

                    using (var report = new SaleReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var dataSet = (AccountingDataSet)this.dataSet.Clone();

                        dataSet.VwDocumentRetailsSale.ImportRow(row);
                        dataSet.VwDocumentDetail.Clear();

                        gridViewDetail.GetSelectedRows().Select(r => gridViewDetail.GetDataRow(r))
                        .ToList()
                        .ForEach(dRow => dataSet.VwDocumentDetail.ImportRow(dRow));

                        report.DataSource = dataSet;
                        report.Parameters.Clear();
                        report.Parameters.AddRange(new[]
                        {
                             new DevExpress.XtraReports.Parameters.Parameter(){Name="rowId",Value=string.Format("{0}",row.Id),Visible=false},
                             new DevExpress.XtraReports.Parameters.Parameter(){Name="docDate",Value=DateTime.Now,Description="Sənəd tarixi"}
                            });
                        report.RequestParameters = false;
                        using (var print = new ReportRibbonForm(Manager, report, true))
                            print.ShowDialog();
                    }
            });
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                if (!erpLookUpEditCompany.Validate()
                    || !erpLookUpEditWareHouse.Validate()
                    ) return;



                Parameters.Add("@operationType", operationType)
                    .Add("@includeDate", erpDateEditDate.DateTime)
                    .Add("@companyId", erpLookUpEditCompany.GetIntValue())
                    .Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue())
                    .Add("@contractId", txtContractId.Text)
                    .Add("description", txtDescription.Text)
                    .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                    .Add("@customerId", erpLookUpEditCustomerId.GetIntValue());

                //.Add("@customerId", erpLookUpEditCustomerId.GetIntValue());



                Parameters.Add("@detail", "[Accounting].[UddtSaleGood]",
                dataSet.VwDocumentDetail.GetTableByFilter("GoodId IS NOT NULL", true, "Id", "StoGoodId", "CompanyName", "CustomerName", "BarcodeId", "AccountId", "GoodId", "Series",
                        "DateOfProduction", "LastExpirationDate", "Quantity", "UnitId", "PriceBuy", "PriceRetail", "PriceWholeSale"
                        , "AmountBuy", "AmountRetail", "AmountWholeSale", "Payment", "Deficit","Percent"));


                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRetailsSaleRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentRetailsSale, "[Accounting].[spDocumentSale]", Parameters, true, System.Data.CommandType.StoredProcedure);

                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);
                    return;
                }

                DialogResult = DialogResult.OK;
            }
            
        }


        StringBuilder bCodeContainer = new StringBuilder();
        private void repoBarcode_KeyDown(object sender, KeyEventArgs e)
       
        {
            if (Regex.IsMatch(((char)e.KeyValue).ToString(), "[a-zA-z0-9]"))
                bCodeContainer.Append((char)e.KeyValue);


            if (e.KeyCode == Keys.Enter)
            {
                var lookup = (LookUpEdit)sender;
                //var selected = lookup.GetIntValue();
                //if (!selected.HasValue) return;


                var barcode = dataSet.VwBarcode.FirstOrDefault(b => b.Barcode == bCodeContainer.ToString());
                bCodeContainer.Clear();

                if (barcode == null)
                    goto reSelect;

                lookup.EditValue = barcode.GoodId;

                //var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());

                var good = dataSet.VwGood.FirstOrDefault(g => g.Id == barcode.GoodId);
                if (good == null)
                    goto reSelect;
                var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();

                current.UnitId = good.UnitId;
                current.GoodId = good.Id;
                current.BarCodeId = good.Id;
                current.PriceWholeSale = Manager.MHMContainer.GoodPriceWholeById(good.Id).Value;
                current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.GoodSaleCode).Value;


                gridViewDetail.UpdateCurrentRow();
                gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            }
            return;
        reSelect:
            ActiveControl = btnAddGoods;
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCodeId;
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCodeId;
        }

        private void btnApplyGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.EndEdit);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCodeId;
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCodeId;
        }

        private void repoIncludedGood_EditValueChanged(object sender, EventArgs e)
        {

            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());

            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();
            current.UnitId = good.UnitId;
            //current.BarCodeId = barcode.Id;
            current.GoodId = current.Id;
            current.PriceWholeSale = Manager.MHMContainer.GoodPriceWholeById(good.Id).Value;
            current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.GoodSaleCode).Value;
            //gridViewDetail.UpdateCurrentRow();
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
        }

        private void txtDiscountRetailSale_EditValueChanged_1(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal percent = 0;
            decimal.TryParse(txtDiscountRetailSale.Text, out percent);

            foreach (var row in selectedRows)
            {
                row.Data.Percent = txtDiscountRetailSale.Text;
                if ((row.Data.IsPriceRetailReserveNull() || row.Data.PriceRetailReserve == 0) && !row.Data.IsPriceRetailNull())
                    row.Data.PriceRetailReserve = row.Data.PriceRetail;

                if (!row.Data.IsPriceRetailReserveNull())
                    row.Data.PriceRetail = row.Data.PriceRetailReserve + row.Data.PriceRetailReserve * percent * (-0.01M);

                gridViewDetail.RefreshRow(row.RowIndex);
                ReCalcFunction(row.RowIndex, "PriceRetail");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCodeId;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCodeId;

        }
    }
}