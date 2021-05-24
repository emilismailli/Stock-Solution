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
using System.Collections.Generic;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class SaleForm : MHMForm
    {
        public SaleForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
            splitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.dataSet.Cashier);
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStockSelect' table. You can move, or remove it, as needed.
            this.vwGoodStockSelectTableAdapter.Fill(this.accountingDataSet.VwGoodStockSelect);
            try
            {
                // TODO: This line of code loads data into the 'dataSet.VwGoodStock' table. You can move, or remove it, as needed.
                this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);
                // TODO: This line of code loads data into the 'dataSet.VwGoodStock' table. You can move, or remove it, as needed.
                //this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);

                // TODO: This line of code loads data into the 'dataSet.VwGoodSelect' table. You can move, or remove it, as needed.
                this.vwGoodSelectTableAdapter.Fill(this.dataSet.VwGoodSelect);
                // TODO: This line of code loads data into the 'dataSet.WareHouse' table. You can move, or remove it, as needed.
                this.wareHouseTableAdapter.Fill(this.dataSet.WareHouse);
                // TODO: This line of code loads data into the 'dataSet.VwPaymentType' table. You can move, or remove it, as needed.
                this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);
                // TODO: This line of code loads data into the 'dataSet.VwIncludeContractChoose' table. You can move, or remove it, as needed.
                this.vwSaleContractChooseTableAdapter.Fill(this.dataSet.VwSaleContractChoose);

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
                Parameters.Clear();
                Parameters.Add("@menuId", Manager.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);
                Parameters.Clear();

                erpLookUpEditWareHouse.EditValue = dataSet.spWareHouseSelect.FirstOrDefault().Id;

                this.ActiveControl = erpLookUpEditCompany;
                // TODO: This line of code loads data into the 'accountingDataSet.VwCompany' table. You can move, or remove it, as needed.
                this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);

                erpLookUpEditPaymentType.EditValue = 1;
                erpLookUpEditCompany.EditValue = 1;
                erpLookUpEditCustomerId.EditValue = 2;
                erpLookUpEditCashier.EditValue = 1;
                erpDateEditDate.DateTime = DateTime.Now;
                erpDateEditPaymentDate.DateTime = DateTime.Now;


                if (Current == null)
                    return;

                txtNumber.Properties.ReadOnly = true;

                var currentRow = Current.GetBindingRow<AccountingDataSet.spDocumentSaleRow>();

                txtNumber.EditValue = currentRow.Id.ToString("000000");
                erpLookUpEditCompany.EditValue = currentRow.IsCompanyIdNull() ? (int?)null : currentRow.CompanyId;
                erpLookUpEditWareHouse.EditValue = currentRow.IsWareHouseIdNull() ? (int?)null : currentRow.WareHouseId;
                erpLookUpEditCustomerId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;
                txtContractId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                erpLookUpEditCashier.EditValue = currentRow.IsCashierIdNull() ? (int?)null : currentRow.CashierId;
                erpLookUpEditPaymentType.EditValue = currentRow.IsPaymentTypeIdNull() ? (int?)null : currentRow.PaymentTypeId;
                erpDateEditDate.DateTime = currentRow.IncludeDate;
                txtPartnerOrderNo.Text = currentRow.IsPartnerOrderNoNull() ? "" : currentRow.PartnerOrderNo;
                erpDateEditPaymentDate.DateTime = currentRow.PaymentDate;


                gridViewDetail.LoadData(delegate
                {
                    Parameters.Clear();
                    Parameters.Add("@id", currentRow.Id);
                    Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentDetail, "select * from Accounting.ifnSaleGood(@id)", Parameters, true, System.Data.CommandType.Text);
                    Manager.MHMContainer.AccountIdByCode(AccountResources.GoodSaleCode);
                });
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Sizin Hec bir anbara icazeniz yoxdur!!!");
                DialogResult = DialogResult.OK;
            }
        }

        private void chckPinGoodCatalog_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer.PanelVisibility = chckPinGoodCatalog.Checked ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
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



                decimal discountPrice = gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["DiscountPrice"]) == DBNull.Value ? 0
                        : Convert.ToDecimal(gridViewDetail.GetRowCellValue(focusedRowHandle, gridViewDetail.Columns["DiscountPrice"]));






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
                        gridViewDetail.SetRowCellValue(focusedRowHandle, gridViewDetail.Columns["AmountWholeSale"], quantity * (priceWholeSale - discountPrice));
                        gridViewDetail.SetRowCellValue(focusedRowHandle, gridViewDetail.Columns["PriceWholeSale"], priceWholeSale - discountPrice);
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




        private void txtDiscountWholeSale_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal percent = 0;
            decimal.TryParse(txtDiscountWholeSale.Text, out percent);

            foreach (var row in selectedRows)
            {
                row.Data.Percent = txtDiscountWholeSale.Text;
                if ((row.Data.IsPriceWholeSaleReserveNull() || row.Data.PriceWholeSaleReserve == 0) && !row.Data.IsPriceWholeSaleNull())
                    row.Data.PriceWholeSaleReserve = row.Data.PriceWholeSale;

                if (!row.Data.IsPriceWholeSaleReserveNull())
                    row.Data.PriceWholeSale = row.Data.PriceWholeSaleReserve + row.Data.PriceWholeSaleReserve * percent * -0.01M;

                gridViewDetail.RefreshRow(row.RowIndex);
                ReCalcFunction(row.RowIndex, "PriceWholeSale");
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
            var current = dataSet.VwSaleContractChoose.FirstOrDefault(scc => scc.ContractId == erpLookUpEditCustomerId.GetIntValue());
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




        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            if (erpLookUpEditWareHouse.Text == "")
            {
                MHMMessage.ShowInformationMessageBox("Anbar Əlavə Edin!!!");
                return;
            }
            if (erpLookUpEditCustomerId.GetIntValue() is null)
            {
                MHMMessage.ShowInformationMessageBox("Müştəri Müəssisə Əlavə Edin!!!");
                return;
            }



            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                if (!erpLookUpEditCompany.Validate()
                    || !erpLookUpEditWareHouse.Validate()
                    || !erpDateEditDate.Validate()
                    || !erpLookUpEditCompany.Validate()
                    || !erpLookUpEditPaymentType.Validate()
                    || !erpLookUpEditCustomerId.Validate()
                    ) return;



                Parameters.Add("@operationType", operationType)
                    .Add("@includeDate", erpDateEditDate.DateTime)
                    .Add("@companyId", erpLookUpEditCompany.GetIntValue())
                    .Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue())
                    .Add("@contractId", txtContractId.Text)
                    .Add("@description", txtDescription.Text)
                    .Add("@menuId", 27)
                    .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                    .Add("@customerId", erpLookUpEditCustomerId.GetIntValue())
                    .Add("@paymentDate", erpDateEditPaymentDate.DateTime)
                    .Add("@partnerOrderNo", txtPartnerOrderNo.Text);
                //[PartnerOrderNo]
                //.Add("@customerId", erpLookUpEditCustomerId.GetIntValue());



                Parameters.Add("@detail", "[Accounting].[UddtSaleGood]",
                dataSet.VwDocumentDetail.GetTableByFilter("GoodId IS NOT NULL", true, "Id", "StoGoodId", "CompanyName", "CustomerName", "BarcodeId", "AccountId", "GoodId", "Series",
                        "DateOfProduction", "LastExpirationDate", "Quantity", "UnitId", "PriceBuy", "PriceRetail", "PriceWholeSale"
                        , "AmountBuy", "AmountRetail", "AmountWholeSale", "Payment", "Deficit", "Percent", "CostInclude", "CostDeficit", "DiscountPrice"));


                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocument, "[Accounting].[spDocumentSale]", Parameters, true, System.Data.CommandType.StoredProcedure);

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
                var searchF = vwDocumentDetailBindingSource.Find("BarCodeId", barcode.Id);

                if (searchF >= 0)
                {
                    DialogResult dialog = XtraMessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                    lookup.EditValue = default;

                    return;
                }
                //var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());

                var good = dataSet.VwGood.FirstOrDefault(g => g.Id == barcode.GoodId);
                if (good == null)
                    goto reSelect;
                var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();

                current.UnitId = good.UnitId;
                current.GoodId = good.Id;
                current.BarCodeId = good.BarcodeId;
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
            var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());//viewmuz budu ??
            var searchF = vwDocumentDetailBindingSource.Find("BarCodeId", good.BarcodeId);
            // abi
            if (searchF >= 0)
            {
                DialogResult dialog = XtraMessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                lookup.EditValue = default;

                return;
            }
            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();
            current.UnitId = good.UnitId;
            //current.BarCodeId = barcode.Id;
            current.GoodId = current.Id;

            current.BarCodeId = good.BarcodeId;
            current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
            current.PriceWholeSale = Manager.MHMContainer.GoodPriceWholeById(good.Id).Value;
            current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.GoodSaleCode).Value;
            //gridViewDetail.UpdateCurrentRow();
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
        }

        private void erpLookUpEditWareHouse_EditValueChanged(object sender, EventArgs e)
        {
            Parameters.Clear();
            Parameters.Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue());
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spGetGoodStock, "[dbo].[spGetGoodStock]", Parameters, true, System.Data.CommandType.StoredProcedure);

        }

        //private void repoIncludedGood_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    //using (var form = new IncludeForm(Manager, null, OperationType.Add))

        //    //{
        //    //    form.ShowDialog();
        //    //    Manager.Loading();
        //    //}


        //}

        private void btnAddGood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colGoodName;

            //gridViewDetail.IsEditorFocused = colGoodName;
        }

        private void btnDeleteGood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCodeId;
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            //if (sender is SimpleButton btnTransport)
            //{
            //    if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    {
            //        using (var form = new GoodForm(Manager, null, OperationType.Add, true))
            //        {
            //            form.ShowDialog();
            //            Manager.Loading();

            //        }
            //    }

            //    else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
            //    {

            //        // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
            //        this.vwGoodTableAdapter.Fill(this.dataSet.VwGood);
            //    }

            //}
        }




        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTransportGood_Click(object sender, EventArgs e)
        {

            using (var form = new TransportForm(Manager, null, OperationType.Add, true))
            {
                form.ShowDialog();
                Manager.Loading();

            }
        }

        private void btnTransportGoods_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var form = new TransportForm(Manager, null, OperationType.Add, true))
            {
                form.ShowDialog();
                Manager.Loading();

            }



            // TODO: This line of code loads data into the 'dataSet.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.dataSet.Cashier);
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStockSelect' table. You can move, or remove it, as needed.
            this.vwGoodStockSelectTableAdapter.Fill(this.accountingDataSet.VwGoodStockSelect);
            try
            {
                // TODO: This line of code loads data into the 'dataSet.VwGoodStock' table. You can move, or remove it, as needed.
                this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);
                // TODO: This line of code loads data into the 'dataSet.VwGoodStock' table. You can move, or remove it, as needed.
                //this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);

                // TODO: This line of code loads data into the 'dataSet.VwGoodSelect' table. You can move, or remove it, as needed.
                this.vwGoodSelectTableAdapter.Fill(this.dataSet.VwGoodSelect);
                // TODO: This line of code loads data into the 'dataSet.WareHouse' table. You can move, or remove it, as needed.
                this.wareHouseTableAdapter.Fill(this.dataSet.WareHouse);
                // TODO: This line of code loads data into the 'dataSet.VwPaymentType' table. You can move, or remove it, as needed.
                this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);
                // TODO: This line of code loads data into the 'dataSet.VwIncludeContractChoose' table. You can move, or remove it, as needed.
                this.vwSaleContractChooseTableAdapter.Fill(this.dataSet.VwSaleContractChoose);

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
                Parameters.Clear();
                Parameters.Add("@menuId", Manager.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);
                Parameters.Clear();

                erpLookUpEditWareHouse.EditValue = dataSet.spWareHouseSelect.FirstOrDefault().Id;

                this.ActiveControl = erpLookUpEditCompany;
                // TODO: This line of code loads data into the 'accountingDataSet.VwCompany' table. You can move, or remove it, as needed.
                this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);

                erpLookUpEditPaymentType.EditValue = 1;
                erpLookUpEditCompany.EditValue = 1;
                erpLookUpEditCustomerId.EditValue = 2;
                erpLookUpEditCashier.EditValue = 1;
                erpDateEditDate.DateTime = DateTime.Now;
                erpDateEditPaymentDate.DateTime = DateTime.Now;


                if (Current == null)
                    return;

                txtNumber.Properties.ReadOnly = true;

                var currentRow = Current.GetBindingRow<AccountingDataSet.spDocumentSaleRow>();

                txtNumber.EditValue = currentRow.Id.ToString("000000");
                erpLookUpEditCompany.EditValue = currentRow.IsCompanyIdNull() ? (int?)null : currentRow.CompanyId;
                erpLookUpEditWareHouse.EditValue = currentRow.IsWareHouseIdNull() ? (int?)null : currentRow.WareHouseId;
                erpLookUpEditCustomerId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;
                txtContractId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                erpLookUpEditCashier.EditValue = currentRow.IsCashierIdNull() ? (int?)null : currentRow.CashierId;
                erpLookUpEditPaymentType.EditValue = currentRow.IsPaymentTypeIdNull() ? (int?)null : currentRow.PaymentTypeId;
                erpDateEditDate.DateTime = currentRow.IncludeDate;
                txtPartnerOrderNo.Text = currentRow.IsPartnerOrderNoNull() ? "" : currentRow.PartnerOrderNo;
                erpDateEditPaymentDate.DateTime = currentRow.PaymentDate;


                gridViewDetail.LoadData(delegate
                {
                    Parameters.Clear();
                    Parameters.Add("@id", currentRow.Id);
                    Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentDetail, "select * from Accounting.ifnSaleGood(@id)", Parameters, true, System.Data.CommandType.Text);
                    Manager.MHMContainer.AccountIdByCode(AccountResources.GoodSaleCode);
                });
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Sizin Hec bir anbara icazeniz yoxdur!!!");
                DialogResult = DialogResult.OK;
            }

        }

        private void btnAcceptSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (erpLookUpEditWareHouse.Text == "")
            {
                MHMMessage.ShowInformationMessageBox("Anbar Əlavə Edin!!!");
                return;
            }
            if (erpLookUpEditCustomerId.GetIntValue() is null)
            {
                MHMMessage.ShowInformationMessageBox("Müştəri Müəssisə Əlavə Edin!!!");
                return;
            }



            //object Quantity = gridViewDetail.GetFocusedRowCellValue("colQuantity");

            //     if (  Quantity != null && Quantity != DBNull.Value)
            //{
            //    MHMMessage.ShowInformationMessageBox("Məhsul Sayını Daxil Edin!!!");

            //} 



            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                if (!erpLookUpEditCompany.Validate()
                    || !erpLookUpEditWareHouse.Validate()
                    || !erpDateEditDate.Validate()
                    || !erpLookUpEditCompany.Validate()
                    || !erpLookUpEditPaymentType.Validate()
                    || !erpLookUpEditCustomerId.Validate()
                    ) return;



                Parameters.Add("@operationType", operationType)
                    .Add("@includeDate", erpDateEditDate.DateTime)
                    .Add("@companyId", erpLookUpEditCompany.GetIntValue())
                    .Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue())
                    .Add("@contractId", txtContractId.Text)
                    .Add("@description", txtDescription.Text)
                    .Add("@menuId", 27)
                    .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                    .Add("@customerId", erpLookUpEditCustomerId.GetIntValue())
                    .Add("@cashierId", erpLookUpEditCashier.GetIntValue())
                    .Add("@paymentDate", erpDateEditPaymentDate.DateTime)
                    .Add("@partnerOrderNo", txtPartnerOrderNo.Text);
                //[PartnerOrderNo]
                //.Add("@customerId", erpLookUpEditCustomerId.GetIntValue());



                Parameters.Add("@detail", "[Accounting].[UddtSaleGood]",
                dataSet.VwDocumentDetail.GetTableByFilter("Quantity IS NOT NULL", true, "Id", "StoGoodId", "CompanyName", "CustomerName", "BarcodeId", "AccountId", "GoodId", "Series",
                        "DateOfProduction", "LastExpirationDate", "Quantity", "UnitId", "PriceBuy", "PriceRetail", "PriceWholeSale"
                        , "AmountBuy", "AmountRetail", "AmountWholeSale", "Payment", "Deficit", "Percent", "CostInclude", "CostDeficit", "DiscountPrice"));


                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.spDocumentSaleRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spDocumentSale, "[Accounting].[spDocumentSale]", Parameters, true, System.Data.CommandType.StoredProcedure);

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



        private void btnQuantity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colQuantity;
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal discountWholeSale = 0;
            var status = decimal.TryParse(txtDiscountSaleNumber.Text, out discountWholeSale);
            foreach (var row in selectedRows)
            {
                row.Data.DiscountPrice = discountWholeSale;

                if ((row.Data.IsPriceWholeSaleReserveNull() || row.Data.PriceWholeSaleReserve == 0) && !row.Data.IsPriceWholeSaleNull())
                    row.Data.PriceWholeSaleReserve = row.Data.PriceBuy;


                if (!row.Data.IsPriceWholeSaleReserveNull())
                    row.Data.PriceWholeSale = row.Data.PriceWholeSale - discountWholeSale;
                gridViewDetail.RefreshRow(row.RowIndex);
                //ReCalcFunction(row.RowIndex, "PriceWholeSale");
            }
        }


        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            //decimal percent = 0;
            //decimal.TryParse(txtDiscountPercent.Text, out percent);

            //foreach (var row in selectedRows)
            //{
            //    row.Data.Percent = txtDiscountPercent.Text;


            //    if ((row.Data.IsPriceWholeSaleReserveNull() || row.Data.PriceWholeSaleReserve == 0) && !row.Data.IsPriceWholeSaleNull())
            //        row.Data.PriceWholeSaleReserve = row.Data.PriceWholeSale;

            //    if (!row.Data.IsPriceWholeSaleReserveNull())
            //        row.Data.PriceWholeSale = row.Data.PriceWholeSaleReserve + row.Data.PriceWholeSaleReserve * percent * -0.01M;

            //    gridViewDetail.RefreshRow(row.RowIndex);
            //    //ReCalcFunction(row.RowIndex, "PriceWholeSale");

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void erpLookUpEditCashier_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (sender is erpLookUpEdit)
            //{
            //    if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    {
            //        using (var form = new CashierForm(null, null, OperationType.Add, true))
            //        {
            //            form.ShowDialog();
            //            Manager.Loading();

            //        }
            //    }
            //    else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
            //    {

            //        // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
            //        this.cashierTableAdapter.Fill(this.dataSet.Cashier);
            //    }
            //}
        }

        /// satiwda mehsul medaxili
        //using (var form = new IncludeForm(Manager, null, OperationType.Add))

        //{
        //    form.ShowDialog();
        //    Manager.Loading();
        //}





        private void repoIncludedGood_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is LookUpEdit repoIncludedGood)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new IncludeForm(Manager, null, OperationType.Add))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwGoodStockSelectTableAdapter.Fill(this.accountingDataSet.VwGoodStockSelect);
                }


            }
        }


        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer.PanelVisibility = checkButton1.Checked ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel1;

        }
    }
}
