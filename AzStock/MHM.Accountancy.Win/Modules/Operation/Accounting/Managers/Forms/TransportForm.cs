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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class TransportForm : MHMForm
    {
        public TransportForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
            splitContainer.PanelVisibility = SplitPanelVisibility.Panel1;

            this.WindowState = FormWindowState.Maximized;

        }

        private void TransportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodStockSelect' table. You can move, or remove it, as needed.
            this.vwGoodStockSelectTableAdapter.Fill(this.accountingDataSet.VwGoodStockSelect);
            try
            {
                this.vwWareHouseTableAdapter.Fill(this.accountingDataSet.VwWareHouse);
                this.wareHouseTableAdapter.Fill(this.accountingDataSet.WareHouse);
                this.vwGoodTableAdapter.Fill(this.accountingDataSet.VwGood);
                this.vwGoodStockTableAdapter.Fill(this.accountingDataSet.VwGoodStock);
                this.vwGoodSelectTableAdapter.Fill(this.accountingDataSet.VwGoodSelect);
                this.vwSaleContractChooseTableAdapter.Fill(this.accountingDataSet.VwSaleContractChoose);
                this.vwBarcodeTableAdapter.Fill(this.accountingDataSet.VwBarcode);
                this.vwSaleContractChooseTableAdapter.Fill(this.accountingDataSet.VwSaleContractChoose);
                this.vwAccountTableAdapter.Fill(this.accountingDataSet.VwAccount);
                this.vwUnitTableAdapter.Fill(this.accountingDataSet.VwUnit);

                Parameters.Clear();
                Parameters.Add("@menuId", 54);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", Parameters, true, System.Data.CommandType.StoredProcedure);
                Parameters.Clear();

                erpLookUpEditFromWareHouse.EditValue = accountingDataSet.spWareHouseSelect.FirstOrDefault().Id;
                this.ActiveControl = erpLookUpEditFromWareHouse;
                Parameters.Clear();
                Parameters.Add("@warehouseId", erpLookUpEditFromWareHouse.GetIntValue());
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spWareHouseChangedPrice, "[dbo].[spWareHouseChangedPrice]", Parameters, true, System.Data.CommandType.StoredProcedure);

                this.vwCompanyTableAdapter.Fill(this.accountingDataSet.VwCompany);

                erpLookUpEditCompany.EditValue = 1;
                erpDateEditDate.DateTime = DateTime.Now;

                if (Current == null)
                    return;

                txtNumber.Properties.ReadOnly = true;

                var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRow>();

                txtNumber.EditValue = currentRow.Id.ToString("000000");
                erpLookUpEditCompany.EditValue = currentRow.IsCompanyIdNull() ? (int?)null : currentRow.CompanyId;
                erpLookUpEditWareHouse.EditValue = currentRow.IsWareHouseIdNull() ? (int?)null : currentRow.WareHouseId;
                erpLookUpEditFromWareHouse.EditValue = currentRow.IsFromWarehouseIdNull() ? (int?)null : currentRow.FromWarehouseId;
                //erpLookUpEditWareHouse.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId; //bu sehv yere yazilib brat bunu duzeltmemishdim ContractId-ye deyishersen bunu
                //treewwodda artmadi
                //100 oldu axi  men 100 medaxil etmiwdim 10
                //2 olmalid idi abi bidene treewwordda olmayan biseyi transfer ele
                //okparoseduru ishleddin duzdu? he  brat 
                txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;
                erpDateEditDate.DateTime = currentRow.IncludeDate;

                gridViewDetail.LoadData(delegate
                {
                    Parameters.Clear();
                    Parameters.Add("@id", currentRow.Id);
                    Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwDocumentDetail, "select * from Accounting.ifnSaleGood(@id)", Parameters, true, System.Data.CommandType.Text);
                    Manager.MHMContainer.AccountIdByCode("1.11");
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sizin Hec bir anbara icazeniz yoxdur!!!");
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

        private void gridViewDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;

            var current = vwGoodBindingSource.GetBindingRow<AccountingDataSet.VwGoodRow>();
            current = null;
            if (current == null)
            {
                vwBarcodeTableAdapter.Fill(accountingDataSet.VwBarcode);
                return;
            }

            vwBarcodeTableAdapter.FillByGoodId(accountingDataSet.VwBarcode, current.Id);
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
                    this.vwCompanyTableAdapter.Fill(this.accountingDataSet.VwCompany);
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
                    this.wareHouseTableAdapter.Fill(this.accountingDataSet.WareHouse);
                }

            }
        }

        private void erpLookUpEditCustomerId_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                    this.vwSaleContractChooseTableAdapter.Fill(this.accountingDataSet.VwSaleContractChoose);
                }
            }

        }



        private void btnPrintDocument_Click_1(object sender, EventArgs e)
        {
            Manager.InvokeAction(delegate
            {
                var row = Current.GetBindingRow<AccountingDataSet.VwDocumentRow>();
                if (row != null)

                    using (var report = new SaleReport())
                    {
                        Parameters.Clear();
                        Parameters.Add("@documentId", row.Id);
                        var dataSet = (AccountingDataSet)this.accountingDataSet.Clone();

                        dataSet.VwDocument.ImportRow(row);
                        dataSet.VwDocumentDetail.Clear();

                        gridViewDetail.GetSelectedRows().Select(r => gridViewDetail.GetDataRow(r))
                        .ToList()
                        .ForEach(dRow => accountingDataSet.VwDocumentDetail.ImportRow(dRow));

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


                var barcode = accountingDataSet.VwBarcode.FirstOrDefault(b => b.Barcode == bCodeContainer.ToString());
                bCodeContainer.Clear();

                if (barcode == null)
                    goto reSelect;

                lookup.EditValue = barcode.GoodId;
                var searchF = vwDocumentDetailBindingSource.Find("BarCodeId", barcode.Id);

                if (searchF >= 0)
                {
                    DialogResult dialog = MessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                    lookup.EditValue = default;

                    return;
                }
                //var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());

                var good = accountingDataSet.VwGood.FirstOrDefault(g => g.Id == barcode.GoodId);
                if (good == null)
                    goto reSelect;
                var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();

                current.UnitId = good.UnitId;
                current.GoodId = good.Id;
                current.BarCodeId = good.BarcodeId;
                current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
                current.AccountId = 12;


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
            var good = accountingDataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());
            var searchF = vwDocumentDetailBindingSource.Find("BarCodeId", good.BarcodeId);

            if (searchF >= 0)
            {
                DialogResult dialog = MessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                lookup.EditValue = default;

                return;
            }
            var current = vwDocumentDetailBindingSource.GetBindingRow<AccountingDataSet.VwDocumentDetailRow>();
            current.UnitId = good.UnitId;
            //current.BarCodeId = barcode.Id;
            current.GoodId = current.Id;

            current.BarCodeId = good.BarcodeId;
            current.PriceBuy = Manager.MHMContainer.BuyPricesByGoodId(good.Id).Value;
            current.AccountId = 12;
            //gridViewDetail.UpdateCurrentRow();
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
        }

        private void erpLookUpEditWareHouse_EditValueChanged(object sender, EventArgs e)
        {
            Parameters.Clear();
            Parameters.Add("@wareHouseId", erpLookUpEditFromWareHouse.GetIntValue());
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spGetGoodStock, "[dbo].[spGetGoodStock]", Parameters, true, System.Data.CommandType.StoredProcedure);

            Parameters.Clear();
            Parameters.Add("@warehouseId", erpLookUpEditFromWareHouse.GetIntValue());
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.spWareHouseChangedPrice, "[dbo].[spWareHouseChangedPrice]", Parameters, true, System.Data.CommandType.StoredProcedure);
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

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
            gridViewDetail.FocusedColumn = colBarCodeId;
        }

        private void btnAcceptTransport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (erpLookUpEditFromWareHouse.Text == "")
            {
                MHMMessage.ShowInformationMessageBox("Anbar Əlavə Edin!!!");
                return;
            }

            if (erpLookUpEditWareHouse.GetIntValue() is null)
            {
                MHMMessage.ShowInformationMessageBox("Anbar Əlavə Edin!!!");
                return;
            }


            if (erpLookUpEditWareHouse.GetIntValue() is null)
            {
                MHMMessage.ShowInformationMessageBox("Anbar Əlavə Edin!!!");
                return;
            }

            //if  (gridViewDetail.colQuantity.) 
            //{
            //    MHMMessage.ShowErrorMessageBox("Say Daxil Edin !!!");
            //        return;
            //}


            //object Quantity = gridViewDetail.GetFocusedRowCellValue("Quantity");
            //if (Quantity != null  )
            //{
            //    MHMMessage.ShowInformationMessageBox("Məhsul Sayını Daxil Edin!!!");
            //    return;
            //}
            //else
            //{   }


            DialogResult dialogResult = MessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Parameters.Clear();
                if (   !erpLookUpEditCompany.Validate()
                    || !erpLookUpEditFromWareHouse.Validate() 
                    ) return;


          Parameters.Add("@operationType", operationType)
                    .Add("@companyId", erpLookUpEditCompany.GetIntValue())
                    .Add("@fromWareHouseId", erpLookUpEditFromWareHouse.GetIntValue())
                    .Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue())
                    .Add("@description", txtDescription.Text)
                    .Add("@includeDate", erpDateEditDate.DateTime)
                    .Add("@menuId", 54);

                //.Add("@customerId", erpLookUpEditCustomerId.GetIntValue());



                Parameters.Add("@detail", "[Accounting].[UddtTransport]",
                accountingDataSet.VwDocumentDetail.GetTableByFilter("Quantity     IS NOT NULL",  true, "Id", "StoGoodId", "CompanyName", "CustomerName", "BarcodeId", "AccountId", "GoodId", "Series",
                        "DateOfProduction", "LastExpirationDate", "Quantity", "UnitId", "PriceBuy", "PriceRetail", "PriceWholeSale"
                        , "AmountBuy", "AmountRetail", "AmountWholeSale", "Payment", "Deficit", "Percent"));


                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwDocumentRow>();

                    Parameters.Add("@id", currentRow.Id);
                }



                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwDocument, "[dbo].[spTransport]", Parameters, true, System.Data.CommandType.StoredProcedure);

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

        private void repoIncludedGood_ButtonClick(object sender, ButtonPressedEventArgs e)
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
    }
}
