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
    public partial class LogisticForm : MHMForm
    {
        public LogisticForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        private void LogisticForm_Load(object sender, EventArgs e)
        {

            this.vwGoodTableAdapter.Fill(this.dataSet.VwGood);
            this.vwBarcodeTableAdapter.Fill(this.dataSet.VwBarcode);

            // TODO: This line of code loads data into the 'dataSet.VwUnit' table. You can move, or remove it, as needed.
            this.vwUnitTableAdapter.Fill(this.dataSet.VwUnit);
            
            // TODO: This line of code loads data into the 'dataSet.VwGoodSelect' table. You can move, or remove it, as needed.
            this.vwGoodSelectTableAdapter.Fill(this.dataSet.VwGoodSelect);
            // TODO: This line of code loads data into the 'accountingDataSet.VwLogisticDetail' table. You can move, or remove it, as needed.
            //this.vwLogisticDetailTableAdapter.Fill(this.dataSet.VwLogisticDetail);

            gridViewDetail.LoadData(delegate
            {
                if (Current == null)
                    return;

                txtNumber.Properties.ReadOnly = true;

                var currentRow = Current.GetBindingRow<AccountingDataSet.VwLogisticRow>();

                txtNumber.Text = currentRow.Id.ToString("000000");
                txtDriver.Text = currentRow.IsDriverNull() ? "" : currentRow.Driver;
                txtFin.Text = currentRow.IsFinNull() ? "" : currentRow.Fin;
                txtTransportation.Text = currentRow.IsTransportationNull() ? "" : currentRow.Transportation;
                txtCart.Text = currentRow.IsCartNull() ? "" : currentRow.Cart;
                txtSender.Text = currentRow.IsSenderNull() ? "" : currentRow.Sender;
                txtSenderAddress.Text = currentRow.IsSenderAddressNull() ? "" : currentRow.SenderAddress;
                txtSenderManager.Text = currentRow.IsSenderManagerNull() ? "" : currentRow.SenderManager;
                //
                txtReceived.Text = currentRow.IsSenderNull() ? "" : currentRow.Received;
                txtReceivedAddress.Text = currentRow.IsSenderAddressNull() ? "" : currentRow.ReceivedAddress;
                txtReceivedManager.Text = currentRow.IsSenderManagerNull() ? "" : currentRow.ReceivedManager;

                dateEditDate.EditValue =  currentRow.Date;
                erpDateEditDeliveryDate.EditValue = currentRow.DeliveryDate;
                txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;

                Parameters.Clear();
                Parameters.Add("@id", currentRow.Id);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwLogisticDetail, "select * from Accounting.ifnLogisticDetail(@id)", Parameters, true, System.Data.CommandType.Text);

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
            var searchF = vwLogisticDetailBindingSource.Find("BarcodeId", good.BarcodeId);

            if (searchF >= 0)
            {
                DialogResult dialog = MessageBox.Show("Bu Mehsulu Artiq Daxil Etmisiz!!!");
                lookup.EditValue = default;

                return;
            }
            var current = vwLogisticDetailBindingSource.GetBindingRow<AccountingDataSet.VwLogisticDetailRow>();
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
                var searchF = vwLogisticDetailBindingSource.Find("BarcodeId", barcode.Id);

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
                var current = vwLogisticDetailBindingSource.GetBindingRow<AccountingDataSet.VwLogisticDetailRow>();

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
                .Add("@driver", txtDriver.Text)
                .Add("@fin", txtFin.Text)
                .Add("@transportation", txtTransportation.Text)
                .Add("@cart", txtCart.Text)
                .Add("@sender", txtSender.Text)
                .Add("@senderAddress", txtSenderAddress.Text)
                .Add("@senderManager", txtSenderManager.Text)
                .Add("@received", txtReceived.Text)
                .Add("@receivedAddress", txtReceivedAddress.Text)
                .Add("@receivedManager", txtReceivedManager.Text)
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

                Parameters.Add("@details", "[Accounting].[UddtLogisticDetail]",
              dataSet.VwLogisticDetail.GetTableByFilter("GoodId IS NOT NULL", true,  "LogisticId", "BarcodeId", "GoodId", "Quantity", "UnitId", "Description"));
                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwLogisticRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwLogistic, "[Accounting].[spLogisticDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlDetail.EmbeddedNavigator.Buttons.DoClick(gridControlDetail.EmbeddedNavigator.Buttons.Remove);
            ActiveControl = gridControlDetail;
            gridViewDetail.FocusedColumn = colBarcodeId;
        }

        private void btnAcceptLogistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                .Add("@driver", txtDriver.Text)
                .Add("@fin", txtFin.Text)
                .Add("@transportation", txtTransportation.Text)
                .Add("@cart", txtCart.Text)
                .Add("@sender", txtSender.Text)
                .Add("@senderAddress", txtSenderAddress.Text)
                .Add("@senderManager", txtSenderManager.Text)
                .Add("@received", txtReceived.Text)
                .Add("@receivedAddress", txtReceivedAddress.Text)
                .Add("@receivedManager", txtReceivedManager.Text)
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

                Parameters.Add("@details", "[Accounting].[UddtLogisticDetail]",
              dataSet.VwLogisticDetail.GetTableByFilter("Quantity IS NOT NULL", true, "LogisticId", "BarcodeId", "GoodId", "Quantity", "UnitId", "Description"));
                if (operationType != OperationType.Add && operationType != OperationType.AddWithSelect)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwLogisticRow>();

                    Parameters.Add("@id", currentRow.Id);
                }

                Manager.MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwLogistic, "[Accounting].[spLogisticDocument]", Parameters, true, System.Data.CommandType.StoredProcedure);


                if (checkApplyNew.Checked)
                {
                    base.ClearInputs();
                    Manager.Loading();
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
