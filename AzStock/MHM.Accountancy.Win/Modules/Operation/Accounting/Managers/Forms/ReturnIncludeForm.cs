using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Reports;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class ReturnIncludeForm : MHMForm
    {
        public ReturnIncludeForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
            splitContainer.SetSplitterPercent(70);
            splitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
        }



        private void ReturnIncludeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwGoodStockSelect' table. You can move, or remove it, as needed.
            this.vwGoodStockSelectTableAdapter.Fill(this.dataSet.VwGoodStockSelect);
            try
            {
                // TODO: This line of code loads data into the 'dataSet.VwPaymentType' table. You can move, or remove it, as needed.
                this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);
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
                Parameters.Clear();
                Parameters.Add("@menuId", Manager.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);
                // TODO: This line of code loads data into the 'accountingDataSet.VwCompany' table. You can move, or remove it, as needed.
                this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);
                erpLookUpEditWareHouse.EditValue = dataSet.spWareHouseSelect.FirstOrDefault().Id;
                erpLookUpEditCompany.EditValue = 1;
                erpLookUpEditCustomerId.EditValue = 1;
                erpLookUpEditAccountId.EditValue = 9;
                erpLookUpEditPaymentType.EditValue = 1;
                erpDateEditDate.DateTime = DateTime.Now;
                erpDateEditPaymentDate.DateTime = DateTime.Now;
                if (Current == null)
                    return;

                txtNumber.Properties.ReadOnly = true;

                var currentRow = Current.GetBindingRow<AccountingDataSet.spDocumentReturnIncludeRow>();

                txtNumber.EditValue = currentRow.Id.ToString("000000");
                erpLookUpEditCompany.EditValue = currentRow.IsCompanyIdNull() ? (int?)null : currentRow.CompanyId;
                erpLookUpEditWareHouse.EditValue = currentRow.IsWareHouseIdNull() ? (int?)null : currentRow.WareHouseId;
                //erpLookUpEditAccountId.EditValue = currentRow.IsAccountIdNull() ? (int?)null : currentRow.AccountId;
                erpLookUpEditCustomerId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                txtContractId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                erpLookUpEditPaymentType.EditValue = currentRow.IsPaymentTypeIdNull() ? (int?)null : currentRow.PaymentTypeId;
                erpDateEditDate.DateTime = currentRow.IncludeDate.Date;
                txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;
                txtPartnerOrderNo.Text = currentRow.IsPartnerOrderNoNull() ? "" : currentRow.PartnerOrderNo;
                erpDateEditPaymentDate.DateTime = currentRow.PaymentDate;
                txtIncludeNo.EditValue = currentRow.IsMainNumberNull() ? (int?)null : currentRow.MainNumber;

                gridViewDetail.LoadData(delegate
                {
                    Parameters.Clear();
                    Parameters.Add("@id", currentRow.Id);
                    Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentDetail, "select * from Accounting.ifnIncludeGood(@id)", Parameters, true, System.Data.CommandType.Text);
                    Manager.MHMContainer.AccountIdByCode(AccountResources.ReturnIncludeGoodCode);
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










        private void detailView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var selected = (gridViewStock.GetFocusedRow() as DataRowView)?.Row as AccountingDataSet.VwGoodRow;
            if (selected == null) return;

            if (!dataSet.VwDocumentDetail.AsEnumerable().Any(g => g.GoodId == selected.Id))
                dataSet.VwDocumentDetail.AddVwDocumentDetailRow(
                       StoGoodId: 0
                    , DocumentId: 0
                    , CompanyId: 0
                    , CompanyName: ""
                    , CustomerId: 0
                    , CustomerName: ""
                    , AccountId: 0
                    , AccountParentId: 0
                    , AccountCode: ""
                    , AccountName: ""
                    , GoodId: selected.Id
                    , GoodName: ""
                    , BarCodeId: 0
                      , Barcode: ""
                    , FullGoodName: ""
                    , Series: ""
                    , DateOfProduction: DateTime.Now
                    , LastExpirationDate: DateTime.Now
                    , Quantity: 0
                    , UnitId: 0
                    , UnitName: ""
                    , PriceBuyReserve: 0
                    , PriceBuy: 0
                    , PriceRetailReserve: 0
                    , PriceRetail: 0
                    , PriceWholeSaleReserve: 0
                    , PriceWholeSale: 0
                    , AmountBuy: 0
                    , AmountRetail: 0
                    , AmountWholeSale: 0
                    , Payment: 0
                    , Deficit: 0
                     , Description: ""
                     , Percent: ""
                     //, DiscountPercent: 0
                     , DiscountNumber: ""
                     , PercentWholeReserve: ""
                     , PercentRetailReserve: ""
                     , NewPriceBuy: 0
                     , NewPriceRetail: 0
                     , NewPriceWholeSale: 0
                      , DeficitQuantity: 0
                     , RealQuantity: 0
                     , CostInclude: 0
                     , CostDeficit: 0

                     , DiscountPrice: 0
                     );
        }


        private void gridControlStock_DoubleClick(object sender, EventArgs e)
        {
            //var selected = (gridViewStock.GetFocusedRow() as DataRowView)?.Row as AccountingDataSet.VwGoodStockRow;
            //if (selected == null) return;

            //if (!dataSet.VwDocumentDetail.AsEnumerable().Any(g => g.GoodId == selected.Id))
            //    dataSet.VwDocumentDetail.AddVwDocumentDetailRow(

            //         StoGoodId: 0
            //        , DocumentId: 0
            //        , CompanyId: 0
            //        , CompanyName: ""
            //        , CustomerId: 0
            //        , CustomerName: ""
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
            //        , PriceBuy:
            //        //prices != null && !prices.IsPriceBuyNull() ? prices.PriceBuy :
            //        0
            //        , PriceRetailReserve: 0
            //        , PriceRetail:
            //        //prices != null && !prices.IsPriceRetailNull() ? prices.PriceRetail :
            //        0
            //        , PriceWholeSaleReserve: 0
            //        , PriceWholeSale:
            //        //prices != null && !prices.IsPriceWholeSaleNull() ? prices.PriceWholeSale :
            //        0
            //        , AmountBuy: 0
            //        , AmountRetail: 0
            //        , AmountWholeSale: 0
            //        , Payment: 0
            //        , Deficit: 0
            //         , Description: ""
            //         , Percent:""
            //         , NewPriceRetail: 0
            //         , NewPriceWholeSale: 0
            //          , DeficitQuantity: 0
            //         , RealQuantity: 0);

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
            current = null;
            if (current == null)
            {
                vwBarcodeTableAdapter.Fill(dataSet.VwBarcode);
                return;
            }

            vwBarcodeTableAdapter.FillByGoodId(dataSet.VwBarcode, current.Id);

        }





        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (erpLookUpEditWareHouse.Text == "")
            {
                MHMMessage.ShowInformationMessageBox("Anbar Əlavə Edin!!!");
                return;
            }
            if (erpLookUpEditCustomerId.GetIntValue() is null)
            {
                MHMMessage.ShowInformationMessageBox("Müəssisə Əlavə Edin!!!");
                return;
            }

            object Quantity = gridViewDetail.GetFocusedRowCellValue("Quantity");
            if (Quantity != null)
            {
                MHMMessage.ShowInformationMessageBox("Məhsul Sayını Daxil Edin!!!");
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
                          //.Add("@accountId", erpLookUpEditAccountId.GetIntValue())
                          .Add("@contractId", txtContractId.Text)
                          .Add("@menuId", 31)
                          .Add("@customerId", erpLookUpEditCustomerId.GetIntValue())
                            .Add("description", txtDescription.Text)
                          //.Add("@customerId",erpLookUpEditCustomerId.GetIntValue())
                          .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                          .Add("@paymentDate", erpDateEditPaymentDate.DateTime)
                          .Add("@partnerOrderNo", txtPartnerOrderNo.Text)
                          .Add("@mainNumber", txtIncludeNo.Text)
                          ;

                //;



                Parameters.Add("@detail", "[Accounting].[UddtIncludeReturn]",
                dataSet.VwDocumentDetail.GetTableByFilter
                ("GoodId IS NOT NULL", true, "Id", "StoGoodId", "CompanyName", "CustomerName", "BarCodeId", "AccountId", "GoodId", "Series",
                        "DateOfProduction", "LastExpirationDate", "Quantity", "UnitId"
                        , "PriceBuy", "PriceRetail", "PriceWholeSale"
                        , "AmountBuy", "AmountRetail", "AmountWholeSale", "Payment", "Deficit"));


                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentReturnIncludeRow>();
                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentReturnInclude, "[Accounting].[spDocumentReturnInclude]", Parameters, true, System.Data.CommandType.StoredProcedure);


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



        private void erpLookUpEditCustomerId_EditValueChanged(object sender, EventArgs e)
        {
            txtContractId.EditValue = "";
            if (erpLookUpEditCustomerId.EditValue == null) return;
            var current = dataSet.VwIncludeContractChoose.FirstOrDefault(icc => icc.ContractId == erpLookUpEditCustomerId.GetIntValue());

            if (current == null) return;
            txtContractId.EditValue = current.ContractId;
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
                    this.vwIncludeContractChooseTableAdapter.Fill(this.dataSet.VwIncludeContractChoose);
                }
            }
        }

        private void btnPrintDocument_Click(object sender, EventArgs e)
        {
            Manager.InvokeAction(delegate
            {
                var row = Current.GetBindingRow<AccountingDataSet.VwDocumentReturnIncludeRow>();
                if (row != null)

                    using (var report = new ReturnIncludeReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var dataSet = (AccountingDataSet)this.dataSet.Clone();

                        dataSet.VwDocumentReturnInclude.ImportRow(row);
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
                current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
                current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.ReturnIncludeGoodCode).Value;


                gridViewDetail.UpdateCurrentRow();
                gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            }
            return;
        reSelect:
            ActiveControl = btnAddGoods;
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCode1;
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCode1;
        }

        private void btnApplyGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCode1;
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarCode1;

        }

        private void repoIncludedGood_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());

            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();

            var searchF = vwDocumentDetailBindingSource.Find("BarCodeId", good.BarcodeId);

            if (searchF >= 0)
            {
                DialogResult dialog = XtraMessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                lookup.EditValue = default;

                return;
            }

            current.UnitId = good.UnitId;
            //current.BarCodeId = barcode.Id;
            current.GoodId = current.Id;

            current.BarCodeId = good.BarcodeId;
            current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
            current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.ReturnIncludeGoodCode).Value;
            //gridViewDetail.UpdateCurrentRow();
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
        }

        private void erpLookUpEditWareHouse_EditValueChanged(object sender, EventArgs e)
        {
            Parameters.Clear();
            Parameters.Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue());
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.spGetGoodStock, "[dbo].[spGetGoodStock]", Parameters, true, System.Data.CommandType.StoredProcedure);

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

        private void btnReturn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (erpLookUpEditWareHouse.Text == "")
            {
                MHMMessage.ShowInformationMessageBox("Anbar Əlavə Edin!!!");
                return;
            }
            if (erpLookUpEditCustomerId.GetIntValue() is null)
            {
                MHMMessage.ShowInformationMessageBox("Müəssisə Əlavə Edin!!!");
                return;
            }
            //object Quantity = gridViewDetail.GetFocusedRowCellValue("Quantity");
            //if (Quantity != null)
            //{
            //    MHMMessage.ShowInformationMessageBox("Məhsul Sayını Daxil Edin!!!");
            //    return;
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
                          //.Add("@accountId", erpLookUpEditAccountId.GetIntValue())
                          .Add("@contractId", txtContractId.Text)
                          .Add("@menuId", 31)
                          .Add("@customerId", erpLookUpEditCustomerId.GetIntValue())
                            .Add("description", txtDescription.Text)
                          //.Add("@customerId",erpLookUpEditCustomerId.GetIntValue())
                          .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                          .Add("@paymentDate", erpDateEditPaymentDate.DateTime)
                          .Add("@partnerOrderNo", txtPartnerOrderNo.Text)
                          .Add("@mainNumber", txtIncludeNo.Text)
                          ;

                //;



                Parameters.Add("@detail", "[Accounting].[UddtIncludeReturn]",
                dataSet.VwDocumentDetail.GetTableByFilter
                ("Quantity IS NOT NULL", true, "Id", "StoGoodId", "CompanyName", "CustomerName", "BarCodeId", "AccountId", "GoodId", "Series",
                        "DateOfProduction", "LastExpirationDate", "Quantity", "UnitId"
                        , "PriceBuy", "PriceRetail", "PriceWholeSale"
                        , "AmountBuy", "AmountRetail", "AmountWholeSale", "Payment", "Deficit"));


                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentReturnIncludeRow>();
                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwDocumentReturnInclude, "[Accounting].[spDocumentReturnInclude]", Parameters, true, System.Data.CommandType.StoredProcedure);


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

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwDocumentDetailRow });
            decimal discountInclude = 0;
            var status = decimal.TryParse(txtDiscountSaleNumber.Text, out discountInclude);
            foreach (var row in selectedRows)
            {
                row.Data.DiscountPrice = discountInclude;

                if ((row.Data.IsPriceBuyReserveNull() || row.Data.PriceBuyReserve == 0) && !row.Data.IsPriceBuyNull())
                    row.Data.PriceBuyReserve = row.Data.PriceBuy;


                if (!row.Data.IsPriceBuyReserveNull())
                    row.Data.PriceBuy = row.Data.PriceBuy - discountInclude;
                gridViewDetail.RefreshRow(row.RowIndex);
                //ReCalcFunction(row.RowIndex, "PriceWholeSale");
            }
        }
    }
}
