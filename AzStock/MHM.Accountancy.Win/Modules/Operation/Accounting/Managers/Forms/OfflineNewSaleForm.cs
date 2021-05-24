using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using DevExpress.XtraEditors;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using MHM.Accountancy.Business.Infrastructure.UI;
using System.Text.RegularExpressions;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class OfflineNewSaleForm : MHMForm
    {
        public OfflineNewSaleForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void OfflineNewSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwSaleContractChoose' table. You can move, or remove it, as needed.
            this.vwSaleContractChooseTableAdapter.Fill(this.dataSet.VwSaleContractChoose);
            // TODO: This line of code loads data into the 'dataSet.VwWareHouse' table. You can move, or remove it, as needed.
            this.vwWareHouseTableAdapter.Fill(this.dataSet.VwWareHouse);
            // TODO: This line of code loads data into the 'dataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);
            // TODO: This line of code loads data into the 'dataSet.VwPaymentType' table. You can move, or remove it, as needed.
            this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);

            this.vwGoodTableAdapter.Fill(this.dataSet.VwGood);
            this.vwBarcodeTableAdapter.Fill(this.dataSet.VwBarcode);

            // TODO: This line of code loads data into the 'dataSet.VwUnit' table. You can move, or remove it, as needed.
            this.vwUnitTableAdapter.Fill(this.dataSet.VwUnit);
            
            // TODO: This line of code loads data into the 'dataSet.VwGoodSelect' table. You can move, or remove it, as needed.
            this.vwGoodSelectTableAdapter.Fill(this.dataSet.VwGoodSelect);
            // TODO: This line of code loads data into the 'accountingDataSet.VwOfflineSaleDetail' table. You can move, or remove it, as needed.
            //this.vwOfflineSaleDetailTableAdapter.Fill(this.dataSet.VwOfflineSaleDetail);



            //this.vwCompanyTableAdapter.Fill(this.dataSet.VwCompany);
            this.ActiveControl = btnAddContracts;
            erpLookUpEditPaymentType.EditValue = 1;
            erpLookUpEditCompany.EditValue = 1;
            erpLookUpEditWareHouse.EditValue = 1;
            erpLookUpEditCustomerId.EditValue = 2;

            erpDateEditDeliveryDate.DateTime = DateTime.Now;
            dateEditDate.DateTime = DateTime.Now;

            gridViewDetail.LoadData(delegate
            {
                if (Current == null)
                    return;

                txtNumber.Properties.ReadOnly = true;

                var currentRow = Current.GetBindingRow<AccountingDataSet.VwOfflineSaleRow>();

                txtNumber.Text = currentRow.Id.ToString("000000"); 
                 
                erpLookUpEditCompany.EditValue = currentRow.IsCompanyIdNull() ? (int?)null : currentRow.CompanyId;
                erpLookUpEditWareHouse.EditValue = currentRow.IsWareHouseIdNull() ? (int?)null : currentRow.WareHouseId;
                erpLookUpEditCustomerId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                txtContractId.EditValue = currentRow.IsContractIdNull() ? (int?)null : currentRow.ContractId;
                erpLookUpEditPaymentType.EditValue = currentRow.IsPaymentTypeIdNull() ? (int?)null : currentRow.PaymentTypeId;


                dateEditDate.EditValue =  currentRow.Date;
                erpDateEditDeliveryDate.EditValue = currentRow.DeliveryDate;
                txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;

                Parameters.Clear();
                Parameters.Add("@id", currentRow.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwOfflineSaleDetail, "select * from Accounting.ifnOfflineSaleDetail(@id)", Parameters, true, System.Data.CommandType.Text);

            });
        }
      
        private void btnAddContracts_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;

        }

        private void btnApplyContracts_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.EndEdit);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;

        }

        private void btnDeleteContracts_Click(object sender, EventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;

        }

        private void repoGood_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = (LookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());
            var searchF = vwOfflineSaleDetailBindingSource.Find("BarcodeId", good.BarcodeId);

            if (searchF >= 0)
            {
                DialogResult dialog = MessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                lookup.EditValue = default;

                return;
            }
            var current = vwOfflineSaleDetailBindingSource.GetBindingRow<AccountingDataSet.VwOfflineSaleDetailRow>();
            current.UnitId = good.UnitId;
            //current.BarcodeId = barcode.Id;
            current.GoodId = good.Id;

            current.BarcodeId = good.BarcodeId;
            //current.PriceWholeSale = Manager.MHMContainer.GoodPriceWholeById(good.Id).Value;
            //current.AccountId = Manager.MHMContainer.AccountIdByCode(AccountResources.GoodSaleCode).Value;
            //gridViewDetail.UpdateCurrentRow();
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
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
                var searchF = vwOfflineSaleDetailBindingSource.Find("BarcodeId", barcode.Id);

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
                var current = vwOfflineSaleDetailBindingSource.GetBindingRow<AccountingDataSet.VwOfflineSaleDetailRow>();

                current.UnitId = good.UnitId;
                current.GoodId = good.Id;
                current.BarcodeId = good.BarcodeId; 

                //gridViewDetail.UpdateCurrentRow();
                gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            }
            return;
        reSelect:
            ActiveControl = btnAddContracts;
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;
        }

        private void btnAccept_Click_2(object sender, EventArgs e)
        {


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
                Parameters.Add("@operationType", operationType)

                 //.Add("@id", txtNumber.Text)
                 //.Add("@driver", txtDriver.Text)
                 //.Add("@fin", txtFin.Text)
                 //.Add("@transportation", txtTransportation.Text)
                 //.Add("@cart", txtCart.Text)
                 //.Add("@sender", txtSender.Text)
                 //.Add("@senderAddress", txtSenderAddress.Text)
                 //.Add("@senderManager", txtSenderManager.Text)
                 //.Add("@received", txtReceived.Text)
                 //.Add("@receivedAddress", txtReceivedAddress.Text)
                 //.Add("@receivedManager", txtReceivedManager.Text)

                 .Add("@companyId", erpLookUpEditCompany.GetIntValue())
                    .Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue())
                    .Add("@contractId", txtContractId.Text)

                    .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                    .Add("@customerId", erpLookUpEditCustomerId.GetIntValue())


                .Add("@date", dateEditDate.DateTime)
                .Add("@deliveryDate", erpDateEditDeliveryDate.DateTime)
                .Add("@description", txtDescription.Text);
                //.Add("@customerLeader", txtCustomerLeader.Text)
                //.Add("@workTypeId", erpLookUpEditWorkType.GetIntValue())
                //.Add("@voen", txtVoen.Text)
                //.Add("@currencyId", erpLookUpEditCurrency.GetIntValue())
                //.Add("@bankId", erpLookUpEditBank.GetIntValue())
                //.Add("@bankSwift", txtBankSwift.Text)
                //.Add("@regionId", treeListLookUpEditRegion.GetIntValue())
                //.Add("@legalAddress", txtLegalAddress.Text)
                //.Add("@actualAddress", txtActualAddress.Text)
                //.Add("@email", txtEmail.Text)
                //.Add("@tel", txtTel.Text)
                //.Add("@date", dateEditDesc.DateTime)
                //.Add("@description", erpMemoExEditDescription.Text)
                //.Add("@typeId", erpLookUpEditCompanyType.GetIntValue())
                //.Add("@parentId", lookUpParentCustomer.GetIntValue());

                Parameters.Add("@details", "[Accounting].[UddtOfflineSaleDetail]",
              dataSet.VwOfflineSaleDetail.GetTableByFilter("GoodId IS NOT NULL", true,  "LogisticId", "BarcodeId", "GoodId", "Quantity","PriceWholeSale","AmountWholeSale","Percent", "UnitId", "Description"));
                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwOfflineSaleRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwOfflineSale, "[Accounting].[spOfflineSaleDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
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




      

        private void gridViewDetail_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            ReCalcFunction(gridViewDetail.FocusedRowHandle, e?.PrevFocusedColumn?.FieldName);
        }

        private void erpLookUpEditCustomerId_EditValueChanged(object sender, EventArgs e)
        {
            txtContractId.Text = "";
            if (erpLookUpEditCustomerId.GetIntValue() == null) return;
            var current = dataSet.VwSaleContractChoose.FirstOrDefault(scc => scc.ContractId == erpLookUpEditCustomerId.GetIntValue());
            if (current == null) return;

            txtContractId.EditValue = current.ContractId;
        }

        private void txtDiscountWholeSale_EditValueChanged(object sender, EventArgs e)
        {
            var selectedRows = gridViewDetail.GetSelectedRows().Select(i => new { RowIndex = i, Data = gridViewDetail.GetDataRow(i) as AccountingDataSet.VwOfflineSaleDetailRow });
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

        private void btnAddGoods_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;
        }

        private void btnDeleteGoods_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;
        }

        private void repoGood_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is LookUpEdit repoGood)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new GoodForm(Manager, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwGoodTableAdapter.Fill(this.dataSet.VwGood);
                }

            }
        }

        private void chckPinGoodCatalog_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                Parameters.Add("@operationType", operationType)

                 //.Add("@id", txtNumber.Text)
                 //.Add("@driver", txtDriver.Text)
                 //.Add("@fin", txtFin.Text)
                 //.Add("@transportation", txtTransportation.Text)
                 //.Add("@cart", txtCart.Text)
                 //.Add("@sender", txtSender.Text)
                 //.Add("@senderAddress", txtSenderAddress.Text)
                 //.Add("@senderManager", txtSenderManager.Text)
                 //.Add("@received", txtReceived.Text)
                 //.Add("@receivedAddress", txtReceivedAddress.Text)
                 //.Add("@receivedManager", txtReceivedManager.Text)

                 .Add("@companyId", erpLookUpEditCompany.GetIntValue())
                    .Add("@wareHouseId", erpLookUpEditWareHouse.GetIntValue())
                    .Add("@contractId", txtContractId.Text)

                    .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                    .Add("@customerId", erpLookUpEditCustomerId.GetIntValue())


                .Add("@date", dateEditDate.DateTime)
                .Add("@deliveryDate", erpDateEditDeliveryDate.DateTime)
                .Add("@description", txtDescription.Text);
                //.Add("@customerLeader", txtCustomerLeader.Text)
                //.Add("@workTypeId", erpLookUpEditWorkType.GetIntValue())
                //.Add("@voen", txtVoen.Text)
                //.Add("@currencyId", erpLookUpEditCurrency.GetIntValue())
                //.Add("@bankId", erpLookUpEditBank.GetIntValue())
                //.Add("@bankSwift", txtBankSwift.Text)
                //.Add("@regionId", treeListLookUpEditRegion.GetIntValue())
                //.Add("@legalAddress", txtLegalAddress.Text)
                //.Add("@actualAddress", txtActualAddress.Text)
                //.Add("@email", txtEmail.Text)
                //.Add("@tel", txtTel.Text)
                //.Add("@date", dateEditDesc.DateTime)
                //.Add("@description", erpMemoExEditDescription.Text)
                //.Add("@typeId", erpLookUpEditCompanyType.GetIntValue())
                //.Add("@parentId", lookUpParentCustomer.GetIntValue());

                Parameters.Add("@details", "[Accounting].[UddtOfflineSaleDetail]",
              dataSet.VwOfflineSaleDetail.GetTableByFilter("Quantity IS NOT NULL", true, "LogisticId", "BarcodeId", "GoodId", "Quantity", "PriceWholeSale", "AmountWholeSale", "Percent", "UnitId", "Description"));
                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwOfflineSaleRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwOfflineSale, "[Accounting].[spOfflineSaleDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }
    }
}
