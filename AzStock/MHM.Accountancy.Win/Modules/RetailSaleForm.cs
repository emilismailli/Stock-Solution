using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Identity;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinCustom.Customizer;

namespace MHM.Accountancy.Win
{
    public partial class RetailSaleForm : Form
    {
        class ReceiptInfo
        {
            public int PaymentTypeId { get; set; }
            public decimal Discount { get; set; }
            public decimal Payment { get; set; }
        }

        private string printerName = "Aclas Printer";
        double FirstNumber;
        string Operation;
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        // string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        MouseMove mover;
        User currentUser;
        List<SqlParameter> parameters;
        public RetailSaleForm(User user)

        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;



            //splitContainer.Panel2.Width = 410;
            //splitContainer.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;

            mover = new MouseMove();
            currentUser = user;
            parameters = new List<SqlParameter>();
        }



        private void presentationImage_MouseDown(object sender, MouseEventArgs e)
        {
            mover.On(e);
        }

        private void presentationImage_MouseUp(object sender, MouseEventArgs e)
        {
            mover.Off();
        }

        private void presentationImage_MouseMove(object sender, MouseEventArgs e)
        {
            mover.Move(this, e);
        }




        private void RetailSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwRetailReceiptHistory' table. You can move, or remove it, as needed.
            this.vwRetailReceiptHistoryTableAdapter.Fill(this.dataSet.VwRetailReceiptHistory, currentUser.Id);

            try
            {
                parameters.Clear();

                currentUser.ExecuteProcedure<AccountingDataSet.spRetailAddTmpsDataTable>(dataSet.spRetailAddTmps, "[Accounting].[spRetailAddTmps]", parameters, true, System.Data.CommandType.StoredProcedure);


                // TODO: This line of code loads data into the 'accountingDataSet.DocumentDetail' table. You can move, or remove it, as needed.
                this.documentDetailTableAdapter.Fill(this.dataSet.DocumentDetail);
                // TODO: This line of code loads data into the 'dataSet.VwDocumentDetailTmp' table. You can move, or remove it, as needed.
                this.vwDocumentDetailTmpTableAdapter.Fill(this.dataSet.VwDocumentDetailTmp);
                //// TODO: This line of code loads data into the 'dataSet.VwGood' table. You can move, or remove it, as needed.
                this.vwGoodTableAdapter.Fill(this.dataSet.VwGood);
                // TODO: This line of code loads data into the 'dataSet.VwPaymentType' table. You can move, or remove it, as needed.
                this.vwPaymentTypeTableAdapter.Fill(this.dataSet.VwPaymentType);
                // TODO: This line of code loads data into the 'dataSet.VwBarcode' table. You can move, or remove it, as needed.
                this.vwBarcodeTableAdapter.Fill(this.dataSet.VwBarcode);
                //// TODO: This line of code loads data into the 'dataSet.VwGoodStock' table. You can move, or remove it, as needed.
                //this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);
                this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);


                this.KeyPreview = true;
                parameters.Clear();
                parameters.Add("@operationTypeId", MHM.Accountancy.Business.Infrastructure.Common.OperationType.Select);
                currentUser.ExecuteProcedure<AccountingDataSet.spGetGoodDataTable>(dataSet.spGetGood, "[Accounting].[spDocumentRetailTmp]", parameters, true, System.Data.CommandType.StoredProcedure);
                parameters.Clear();
                parameters.Add("@menuId", 58);
                currentUser.ExecuteProcedure<AccountingDataSet.spWareHouseSelectDataTable>(dataSet.spWareHouseSelect, "[dbo].[spWareHouseSelect]", parameters, true, System.Data.CommandType.StoredProcedure);

                this.ActiveControl = erpLookUpEditBarcode;


                erpLookUpEditPaymentType.EditValue = Convert.ToInt32(1);

                if (dataSet.spGetGood.Count != 0)
                {
                    //digitalGaugeAmount
                    RefreshMonitor();
                }
                parameters.Clear();
                parameters.Add("@wareHouseId", dataSet.spWareHouseSelect.FirstOrDefault().Id);
                currentUser.ExecuteProcedure<AccountingDataSet.spGetGoodStockDataTable>(dataSet.spGetGoodStock, "[dbo].[spGetGoodStock]", parameters, true, System.Data.CommandType.StoredProcedure);
                parameters.Clear();
                parameters.Add("@wareHouseId", dataSet.spWareHouseSelect.FirstOrDefault().Id);
                currentUser.ExecuteProcedure<AccountingDataSet.spBarcodeSelectDataTable>(dataSet.spBarcodeSelect, "[dbo].[spBarcodeSelect]", parameters, true, System.Data.CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Sizin Hec bir anbara icazeniz yoxdur!!!");
                DialogResult = DialogResult.OK;
            }


        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMaximized_CheckedChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void chckPinGoodCatalog_CheckedChanged_CheckedChanged(object sender, EventArgs e)
        {
            //splitContainer.PanelVisibility = chckPinGoodCatalog_CheckedChanged.Checked ? DevExpress.XtraEditors.SplitPanelVisibility.Both : DevExpress.XtraEditors.SplitPanelVisibility.Panel1;


        }




        private void gridViewRetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (e.FocusedRowHandle < 0) return;

            var current = vwGoodBindingSource.GetBindingRow<AccountingDataSet.VwGoodRow>();

            if (current == null)
            {
                //vwBarcodeTableAdapter.Fill(dataSet.VwBarcode);
                return;
            }

            //vwBarcodeTableAdapter.FillByGoodId(dataSet.VwBarcode, current.Id);
        }

        public static string SetValueForText1 = "";
        private string resaultValues;
        private bool isOperationPerformed;

        private void btnApplySale_Click(object sender, EventArgs e)
        {


            if (!dataSet.spGetGood.Any())
            {
                MHMMessage.ShowWarningMessageBox("Xəta baş verdi!");
                this.ActiveControl = erpLookUpEditBarcode;
                return;

            }


            if (!decimal.TryParse(txtPayment.Text, out decimal sum))
            {
                MHMMessage.ShowInformationMessageBox("Ödəniş sahəsini doldurun");
                return;
            }
            if (!decimal.TryParse(digitalGaugeAmount.Text, out decimal payment))
            {
                MHMMessage.ShowInformationMessageBox("Ödəniş sahəsini doldurun");
                return;
            }
            if (!decimal.TryParse(txtDeficit.Text, out decimal deficit))
            {
                MHMMessage.ShowInformationMessageBox("Ödəniş sahəsini doldurun");
                return;
            }



            //parameters.Clear();
            //parameters.Add("@payment", payment)
            //    .Add("@totalsum", sum)
            //    .Add("@deficit", deficit)
            //    .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())

            //    .Add("@accountCode", "2.2")
            //    .Add("@percent", string.IsNullOrEmpty(txtSaleRetail.Text) ? "0" : (txtSaleRetail.Text + " % Endirim"))
            //    .Add("@basket", "[Accounting].[UddtRetailSale]", dataSet.spGetGood.GetTableByFilter
            //    ("", true, "GoodId", "Quantity", "FullGoodName", "BarcodeId", "Barcode", "Account", "GoodName", "Price", "PriceBuy", "PriceWholeSale"));

            try
            {
                parameters.Clear();

                parameters.Add("@payment", payment)
                    .Add("@contractId", Program.RetailDefaultContractId)
                    .Add("@totalsum", sum)
                    .Add("@deficit", deficit)
                    .Add("@paymentTypeId", erpLookUpEditPaymentType.GetIntValue())
                    .Add("@accountCode", "2.2")
                    .Add("@wareHouseId", dataSet.spWareHouseSelect.FirstOrDefault().Id) //Bura deyismelidir kassirin access i oldugu anbara gore
                    .Add("@percent", string.IsNullOrEmpty(txtSaleRetail.Text) ? "0" : (txtSaleRetail.Text + " % Endirim"))
                    .Add("@discountNumber", string.IsNullOrEmpty(txtDiscountNumber.Text) ? "0" : (txtDiscountNumber.Text + " AZN Endirim"))
                    .Add("@basket", "[Accounting].[UddtRetailSale]", dataSet.spGetGood.GetTableByFilter
                    ("", true, "GoodId", "Quantity", "FullGoodName", "BarcodeId", "Barcode", "Account", "GoodName", "Price", "PriceBuy", "PriceWholeSale"));

                currentUser.ExecuteProcedure("[Accounting].[spDocumentRetail]", parameters, System.Data.CommandType.StoredProcedure);

                using (var basket = new DataTable())
                {
                    basket.Columns.Add("Id", typeof(int));
                    basket.Columns.Add("GoodId", typeof(int));
                    basket.Columns.Add("BarcodeId", typeof(int));
                    basket.Columns.Add("Quantity", typeof(decimal));

                    for (int i = 0; i < dataSet.spGetGood.Rows.Count; i++)
                    {
                        var row = dataSet.spGetGood.Rows[i] as AccountingDataSet.spGetGoodRow;

                        basket.Rows.Add(dataSet.spGetGood.Columns["Id"] == null || dataSet.spGetGood.Rows[i]["Id"] == DBNull.Value ? -i : Convert.ToInt32(dataSet.spGetGood.Rows[i]["Id"]), row.GoodId, row.BarcodeId, row.Quantity);
                    }

                    parameters.Clear();
                    parameters.Add("@statusId", 1)
                        .Add("@infoJson", GetReceiptInfo())
                        .Add("@date", DateTime.UtcNow.AddHours(4))
                        .Add("@details", "[Accounting].[UddtReceiptsRetail]", basket);
                    currentUser.ExecuteProcedure("[Accounting].[spRetailReceipts]", parameters, System.Data.CommandType.StoredProcedure);
                }


                parameters.Clear();
                parameters.Add("@operationTypeId", MHM.Accountancy.Business.Infrastructure.Common.OperationType.Delete);
                currentUser.ExecuteProcedure(dataSet.spGetGood, "[Accounting].[spDocumentRetailTmp]", parameters, false, System.Data.CommandType.StoredProcedure);

                parameters.Clear();
                currentUser.ExecuteProcedure(dataSet.spRetailPrint, "[Accounting].[spRetailPrint]", parameters, false, System.Data.CommandType.StoredProcedure);

                this.vwGoodStockTableAdapter.Fill(this.dataSet.VwGoodStock);

                // TODO: This line of code loads data into the 'dataSet.VwRetailReceiptHistory' table. You can move, or remove it, as needed.
                this.vwRetailReceiptHistoryTableAdapter.Fill(this.dataSet.VwRetailReceiptHistory, currentUser.Id);



                var report = new RetailReport()
                {
                    DataSource = this.dataSet
                };
                report.PrintingSystem.ShowMarginsWarning = false;
                report.PrintingSystem.ShowPrintStatusDialog = false;

                ReportPrintTool printTool = new ReportPrintTool(report);




                printTool.Print(printerName);

                dataSet.spGetGood.Clear();
                txtPayment.Text = String.Empty;
                txtDeficit.Text = String.Empty;
                txtQuantity.Text = String.Empty;
                digitalGaugeAmount.Text = String.Empty;
                txtSaleRetail.Text = String.Empty;
                txtDiscountNumber.Text = String.Empty;
                erpLookUpEditBarcode.EditValue = null;
                ActiveControl = erpLookUpEditBarcode;
                parameters.Clear();
                parameters.Add("@wareHouseId", dataSet.spWareHouseSelect.FirstOrDefault().Id);
                currentUser.ExecuteProcedure(dataSet.spGetGoodStock, "[dbo].[spGetGoodStock]", parameters, true, System.Data.CommandType.StoredProcedure);
                RefreshMonitor();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Stokda kifayet qeder mehsul yoxdur");
            }
            //printTool.Report.CreateDocument(false);
            //printTool.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            //Aclas Printer 80(72.1)X297 mm
        }

        void PreviewForm_Load(object sender, EventArgs e)
        {
            PrintPreviewFormEx frm = (PrintPreviewFormEx)sender;
            frm.PrintingSystem.ExecCommand(PrintingSystemCommand.Scale, new object[] { 0.7f });
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            using (var selecteds = dataSet.spGetGood.Clone())
            {
                foreach (var index in gridViewRetail.GetSelectedRows())
                {
                    var row = gridViewRetail.GetDataRow(index);

                    if (row != null)
                        selecteds.ImportRow(row);
                }

                parameters.Clear();
                parameters.Add("@selectedDelIds", "[Accounting].[UdttIds]", selecteds.GetTableByFilter("[TempId] IS NOT NULL", true, "TempId"))
                    .Add("@operationTypeId", MHM.Accountancy.Business.Infrastructure.Common.OperationType.Delete);
                currentUser.ExecuteProcedure(dataSet.spGetGood, "[Accounting].[spDocumentRetailTmp]", parameters, true, System.Data.CommandType.StoredProcedure);
                RefreshMonitor();
            }
        }

        private void btnRejectOfSale_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                parameters.Clear();
                parameters.Add("@operationTypeId", MHM.Accountancy.Business.Infrastructure.Common.OperationType.Delete);
                currentUser.ExecuteProcedure<AccountingDataSet.spGetGoodDataTable>(dataSet.spGetGood, "[Accounting].[spDocumentRetailTmp]", parameters, true, System.Data.CommandType.StoredProcedure);
                //dataSet.spRetailAddTmps.Clear();
                dataSet.spGetGood.Clear();
                txtPayment.Text = String.Empty;
                txtDeficit.Text = String.Empty;
                digitalGaugeAmount.Text = String.Empty;
                txtQuantity.Text = String.Empty;
                txtSaleRetail.Text = String.Empty;
                txtDiscountNumber.Text = String.Empty;
            }
        }

        private void btnApplySale_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataSet.spGetGood.Clear();
            txtPayment.Text = String.Empty;
            txtDeficit.Text = String.Empty;
            digitalGaugeAmount.Text = String.Empty;
            txtSaleRetail.Text = String.Empty;
            txtDiscountNumber.Text = String.Empty;
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

            try
            {
                txtDeficit.Text = (float.Parse(txtPayment.Text) - float.Parse(digitalGaugeAmount.Text)).ToString();
            }

            catch
            {

            }

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            //using (var frm = new ReturnRetailSaleForm())
            //{
            //    SetValueForText1 = digitalGaugeAmount.Text;
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {

            //    }
            //}
        }

        #region Calculator
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "1";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "1";
            }
        }

        private void btnTripleZero_Click(object sender, EventArgs e)
        {
            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "000";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "000";
            }
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "2";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "3";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {

            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "4";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {

            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "5";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {

            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "6";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {

            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "7";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {

            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "8";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {

            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "9";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "9";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + "0";
        }

        private void btnDoubleZero_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + "00";
        }

        private void btnPlusTen_Click(object sender, EventArgs e)
        {
            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "10";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "10";
            }
        }

        private void btnPlusTwenty_Click(object sender, EventArgs e)
        {
            if (txtCalcDisplay.Text == "0" && txtCalcDisplay.Text != null)
            {
                txtCalcDisplay.Text = "20";
            }
            else
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text + "20";
            }
        }

 

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = txtCalcDisplay.Text + ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtCalcDisplay.Text);
            txtCalcDisplay.Text = "+";
            Operation = "+";

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtCalcDisplay.Text);
            txtCalcDisplay.Text = "-";
            Operation = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtCalcDisplay.Text);
            txtCalcDisplay.Text = "*";
            Operation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtCalcDisplay.Text);
            txtCalcDisplay.Text = "/";
            Operation = "/";
        }

        private void btnEquality_Click(object sender, EventArgs e)
        {



            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtCalcDisplay.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtCalcDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtCalcDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtCalcDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtCalcDisplay.Text = "Bölmə sıfır ola bilməz!";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtCalcDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtCalcDisplay.Text = "0";
            resaultValues = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed == true)
            {

            }
            else if (txtCalcDisplay.Text.Length > 0)
            {
                txtCalcDisplay.Text = txtCalcDisplay.Text.Remove(txtCalcDisplay.Text.Length - 1);
            }
        }

        private void txtCalcDisplay_TextChanged(object sender, EventArgs e)
        {
            txtPayment.Text = txtCalcDisplay.Text;
        }
        #endregion

        TextEdit selectedInput;
        private void txtQuantity_MouseEnter(object sender, EventArgs e)
        {
            selectedInput = (TextEdit)sender;
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        Regex regexTimes = new Regex(@"\+(?<value>(\d+)) AZN");
        decimal current = 0;
        private decimal sum;

        private void btn_CalcItem_Click(object sender, EventArgs e)
        {
            if (selectedInput == null)
                selectedInput = txtPayment;

            var btn = sender as SimpleButton;

            switch (btn.Text)
            {
                case "+":
                    current += Convert.ToDecimal(this.selectedInput.Text);
                    PrintMonitor(current);
                    goto case "end";
                case "-":
                    current -= Convert.ToDecimal(this.selectedInput.Text);
                    PrintMonitor(current);
                    goto case "end";
                case "X":
                    current *= Convert.ToDecimal(this.selectedInput.Text);
                    PrintMonitor(current);
                    goto case "end";
                case "/":
                    current /= Convert.ToDecimal(this.selectedInput.Text);
                    PrintMonitor(current);
                    goto case "end";
                case "end":
                    this.Tag = btn.Text;
                    this.selectedInput.Tag = current;
                    //this.selectedInput.Text = "";
                    break;
                case "C":
                    this.Tag = null;
                    this.selectedInput.Tag = null;
                    this.selectedInput.Text = "";
                    current = 0;
                    break;
                case "=":
                    decimal.TryParse(selectedInput.Text, out current);
                    Calc(this.Tag?.ToString(), Convert.ToDecimal(this.selectedInput.Tag));
                    this.Tag = null;
                    this.selectedInput.Tag = null;
                    break;
                case ".":
                default:
                    var matchTimes = regexTimes.Match(btn.Text);

                    if (matchTimes.Success)
                    {
                        PrintMonitor(current + decimal.Parse(matchTimes.Groups["value"].Value));
                    }
                    else if (selectedInput.Text == btn.Text && selectedInput.Text != null)
                    {
                        selectedInput.Text = btn.Text;
                    }
                    else if (Regex.IsMatch(Convert.ToString(this.Tag), @"[+,\-,X,/,*]$"))
                    {
                        Calc(this.Tag?.ToString(), Convert.ToDecimal(this.selectedInput.Tag));
                        //selectedInput.Text = "";
                    }
                    else
                        selectedInput.Text = selectedInput.Text + btn.Text;

                    break;
            }
        }

        void Calc(string operation, decimal secondValue)
        {
            switch (operation)
            {
                case "+":
                    current += Convert.ToDecimal(this.selectedInput.Tag);
                    PrintMonitor(current);
                    break;
                case "-":
                    current -= Convert.ToDecimal(this.selectedInput.Tag);
                    PrintMonitor(current);
                    break;
                case "X":
                    current *= Convert.ToDecimal(this.selectedInput.Tag);
                    PrintMonitor(current);
                    break;
                case "/":
                    current /= Convert.ToDecimal(this.selectedInput.Tag);
                    PrintMonitor(current);
                    break;
                default:
                    break;
            }
        }

        private void PrintMonitor(decimal value)
        {
            if (selectedInput == null)
                selectedInput = txtPayment;

            selectedInput.Text = value.ToString("0.00");
        }

        private void PrintMonitor(string value)
        {
            if (selectedInput == null)
                selectedInput = txtPayment;

            selectedInput.Text = value;
        }




        private void erpLookUpEditBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            var barcode = vwBarcodeBindingSource.GetBindingRow<AccountingDataSet.VwBarcodeRow>();

            if (e.KeyCode == Keys.Enter)
            {
                this.erpLookUpEditBarcode.KeyUp -= erpLookUpEditBarcode_KeyUp;
                if (!erpLookUpEditBarcode.GetIntValue().HasValue) goto reset;

                long barcodeId;

                if (long.TryParse(this.erpLookUpEditBarcode.Text, out barcodeId) && erpLookUpEditBarcode.GetIntValue().HasValue)
                {
                    var good = spGetGoodTableAdapter.GetData(currentUser.Id, dataSet.spWareHouseSelect.FirstOrDefault().Id, 4, 0, barcodeId.ToString(), 0).FirstOrDefault();
                    if (good == null)
                        goto reset;


                    RefreshMonitor();
                }

            reset://not found
                this.erpLookUpEditBarcode.Text = "";
                this.erpLookUpEditBarcode.SelectedText = "";
                this.ActiveControl = erpLookUpEditBarcode;
                this.erpLookUpEditBarcode.EditValue = null;
                this.erpLookUpEditBarcode.ClosePopup();
                this.erpLookUpEditBarcode.KeyUp += erpLookUpEditBarcode_KeyUp;
                this.txtQuantity.Text = String.Empty;
            }
        }


        /// <summary>
        /// Toplami Monitorda gosterir
        /// </summary>
        private void RefreshMonitor()
        {
            //if(_percent>0)
            //{ 
            //digitalGaugeAmount.Text = this.dataSet.spGetGood.AsEnumerable().Sum(l => (l.Price+(l.Price*_percent)) * l.Quantity).ToString("#.00");
            //}
            digitalGaugeAmount.Text = this.dataSet.spGetGood.AsEnumerable().Sum(l => l.Price * l.Quantity).ToString("0.00");

        }

        private void RetailSaleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemMinus)
            {
                txtPayment.Focus();

            }


            //if (e.Control && e.KeyCode == Keys.Oemplus)
            //{
            //    txtPayment.PerformClick();
            //}





        }



        async private void erpLookUpEditBarcode_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = (erpLookUpEdit)sender;
            if (lookup.EditValue == null) return;
            var good = dataSet.VwGood.FirstOrDefault(g => g.Id == lookup.GetIntValue());
            //var good = spGetGoodTableAdapter.GetData(currentUser.Id, OperationType.Add);
            if (good == null)
                return;

            vwBarcodeTableAdapter.FillByGoodId(dataSet.VwBarcode, good.Id);

            var barcode = vwBarcodeBindingSource.GetBindingRow<AccountingDataSet.VwBarcodeRow>();
            //var barcodes = dataSet.VwBarcode.FirstOrDefault(b => b.GoodId == lookup.GetIntValue());
            if (barcode == null)
                return;

            var basketItem = dataSet.spGetGood.FirstOrDefault(g => g.GoodId == good.Id);
            parameters.Clear();

            if (basketItem != null)
            {
                basketItem.Quantity++;
                parameters.Add("@quantity", basketItem.Quantity);
            }
            else
            {
               //await Task.Run(new Action(() => {
                   decimal? retailPrice = currentUser.RetailPricesByGoodId(good.Id).Value;
                   if (!retailPrice.HasValue)
                   {
                       MHMMessage.ShowErrorMessageBox("Qiymet tapilmadi");
                       return;
                   }


                   decimal? buyPrice = currentUser.BuyPricesByGoodId(good.Id).Value;
                   if (!buyPrice.HasValue)
                   {
                       MHMMessage.ShowErrorMessageBox("Qiymet tapilmadi");
                       return;
                   }

                   decimal? wholeSalePrice = currentUser.GoodPriceWholeById(good.Id).Value;
                   if (!wholeSalePrice.HasValue)
                   {
                       MHMMessage.ShowErrorMessageBox("Qiymet tapilmadi");
                       return;
                   }

                   #region AddGoodRow
                   var row = (AccountingDataSet.spGetGoodRow)(dataSet.spGetGood.NewRow());
                   row["GoodId"] = good.Id;
                   row["FullGoodName"] = good.FullGoodName;
                   row["Quantity"] = 1;
                   row["BarcodeId"] = barcode.Id;
                   row["Barcode"] = barcode.Barcode;
                   row["Account"] = currentUser.AccountIdByCode(AccountResources.RetailSaleCode).Value;
                   row["GoodName"] = good.GoodName;
                   row["Price"] = retailPrice.Value;
                   row["PriceBuy"] = buyPrice.Value;
                   row["PriceWholeSale"] = wholeSalePrice.Value;
                   //row["TempId"] = DBNull.Value;

                   dataSet.spGetGood.AddspGetGoodRow(row);
                   #endregion
               //}));

                //dataSet.spGetGood.AddspGetGoodRow(

                //     good.Id,
                //     good.FullGoodName
                //    , 1
                //    , barcode.Id
                //    , barcode.Barcode
                //    , currentUser.AccountIdByCode(AccountResources.RetailSaleCode).Value
                //    , good.GoodName
                //    , retailPrice.Value
                //    , buyPrice.Value
                //    , wholeSalePrice.Value


                //    );


            }
            parameters.Add("@goodId", good.Id);
            parameters.Add("@barcodeId", barcode.Id);
            currentUser.ExecuteProcedure(dataSet.spGetGood, "[Accounting].[spDocumentRetailTmp]", parameters, true, System.Data.CommandType.StoredProcedure);

            erpLookUpEditBarcode.EditValue = null;
            RefreshMonitor();
            //vwBarcodeTableAdapter.FillAvailable(dataSet.VwBarcode);
            //this.txtQuantity.Text = String.Empty;

            //var column = gridViewRetail.Columns[1];
            //if (column != null)
            //{
            //    column.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

            //}
        }



        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {

            var barcode = vwBarcodeBindingSource.GetBindingRow<AccountingDataSet.VwBarcodeRow>();
            var good = spGetGoodBindingSource.GetBindingRow<AccountingDataSet.spGetGoodRow>();

            if (good == null)
            {
                RefreshMonitor();
                return;
            }

            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                good.Quantity = quantity;
                var selectedGood = dataSet.spGetGood.FirstOrDefault(g => g.GoodId == good.GoodId);
                parameters.Add("@quantity", selectedGood.Quantity);
            }
            else
            {
                good.Quantity = 1;
                parameters.Add("@quantity", good.Quantity);
            }

            parameters.Clear();
            parameters.Add("@goodId", good.GoodId);
            parameters.Add("@barcodeId", barcode.Id);
            currentUser.ExecuteProcedure("[Accounting].[spDocumentRetailTmp]", parameters, System.Data.CommandType.StoredProcedure);
            RefreshMonitor();
        }

        private void gridControlStock_DoubleClick(object sender, EventArgs e)
        {
            //parameters.Clear();

            //var goodstock = vwGoodStockBindingSource.GetBindingRow<AccountingDataSet.VwGoodStockRow>();
            //var good = dataSet.VwGood.FirstOrDefault(g => g.Id == goodstock.Id);
            //var barcode = dataSet.VwBarcode.FirstOrDefault(b => b.Id == good.BarcodeId);

            //var selected = (gridViewStock.GetFocusedRow() as DataRowView)?.Row as AccountingDataSet.VwGoodStockRow;
            //if (selected == null) return;
            //if (!dataSet.spGetGood.AsEnumerable().Any(g => g.GoodId == selected.Id))
            //{
            //    dataSet.spGetGood.AddspGetGoodRow(
            //     good.Id,
            //    good.FullGoodName
            //   , 1
            //   , barcode.Id
            //   , barcode.Barcode
            //   , currentUser.AccountIdByCode(AccountResources.RetailSaleCode).Value
            //   , good.GoodName
            //   , currentUser.RetailPricesByGoodId(good.Id).Value
            //   , currentUser.BuyPricesByGoodId(good.Id).Value
            //   , currentUser.GoodPriceWholeById(good.Id).Value
            //   );
            //    parameters.Add("@BarcodeId", barcode.Id);
            //    parameters.Add("@quantity", 1);
            //}
            //else
            //{
            //    var selectedGood = dataSet.spGetGood.FirstOrDefault(g => g.GoodId == good.Id);
            //    selectedGood.Quantity++;

            //    parameters.Add("@quantity", selectedGood.Quantity);

            //    parameters.Add("@BarcodeId", barcode.Id);
            //}
            //parameters.Add("@goodId", good.Id);
            //currentUser.ExecuteProcedure("[Accounting].[spDocumentRetailTmp]", parameters, System.Data.CommandType.StoredProcedure);
            //RefreshMonitor();
            //decimal payment = txtPayment.Text == "" ? 0 : Convert.ToDecimal(txtPayment.Text) - Convert.ToDecimal(digitalGaugeAmount.Text);
            //payment = payment - sum;
            //parameters.Clear();

            //var column = gridViewRetail.Columns[1];
            //if (column != null)
            //{
            //    column.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

            //}


        }

        private void gridControlTmp_Load(object sender, EventArgs e)
        {
            //var selected = (gridViewTmp.GetFocusedRow() as DataRowView)?.Row as AccountingDataSet.VwDocumentDetailTmpRow;
        }

        private void btnOneByOne_CheckedChanged(object sender, EventArgs e)
        {
            using (var frm = new OneByOneSaleForm())
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
            txtQuantity.Text = Convert.ToString(OneByOneSaleForm.quantity);
        }

        private void txtDeficit_EditValueChanged(object sender, EventArgs e)
        {

        }

       


        private void txtPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnApplySale.PerformClick();
            }
        }

        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {

            var barcode = vwBarcodeBindingSource.GetBindingRow<AccountingDataSet.VwBarcodeRow>();
            //gridViewRetail.SelectRow(barcode.Id);
            var good = spGetGoodBindingSource.GetBindingRow<AccountingDataSet.spGetGoodRow>();


            if (good == null) return;
            parameters.Clear();
            if (decimal.TryParse(txtQuantity.Text, out decimal quantity))
            {
                good.Quantity = quantity;
                good.Price = good.Price;
                var selectedGood = dataSet.spGetGood.FirstOrDefault(g => g.GoodId == good.GoodId);
                parameters.Add("@quantity", selectedGood.Quantity);
            }

            else
            {

                good.Quantity = 1;
                parameters.Add("@quantity", good.Quantity);
            }


            parameters.Add("@goodId", good.GoodId);
            parameters.Add("@barcodeId", barcode.Id);
            currentUser.ExecuteProcedure("[Accounting].[spDocumentRetailTmp]", parameters, System.Data.CommandType.StoredProcedure);
            //gridViewRetail.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector();
            //gridViewRetail.OptionsSelection.MultiSelect = false;

            RefreshMonitor();
        }

        private void erpLookUpEditPaymentType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReceipts_Click(object sender, EventArgs e)
        {
            using (var basket = new DataTable())
            {
                basket.Columns.Add("Id", typeof(int));
                basket.Columns.Add("GoodId", typeof(int));
                basket.Columns.Add("BarcodeId", typeof(int));
                basket.Columns.Add("Quantity", typeof(decimal));

                for (int i = 0; i < dataSet.spGetGood.Rows.Count; i++)
                {
                    var row = dataSet.spGetGood.Rows[i] as AccountingDataSet.spGetGoodRow;
                    basket.Rows.Add(-i, row.GoodId, row.BarcodeId, row.Quantity);
                }



                parameters.Clear();
                parameters.Add("@statusId", 2)
                    .Add("@date", DateTime.UtcNow.AddHours(4))
                    .Add("@infoJson", GetReceiptInfo())
                    .Add("@details", "[Accounting].[UddtReceiptsRetail]", basket);
                currentUser.ExecuteProcedure("[Accounting].[spRetailReceipts]", parameters, System.Data.CommandType.StoredProcedure);

                dataSet.spGetGood.Clear();
            }
            // TODO: This line of code loads data into the 'dataSet.VwRetailReceiptHistory' table. You can move, or remove it, as needed.
            this.vwRetailReceiptHistoryTableAdapter.Fill(this.dataSet.VwRetailReceiptHistory, currentUser.Id);

            //digitalGaugeAmount.Text = "";
            RefreshMonitor();
        }

        private string GetReceiptInfo()
        {
            //Receipt Info Json
            var info = new ReceiptInfo();

            if (decimal.TryParse(txtPayment.Text, out decimal paymentInfo))
                info.Payment = paymentInfo;

            if (decimal.TryParse(txtSaleRetail.Text, out decimal discountInfo))
                info.Discount = discountInfo;

            info.PaymentTypeId = erpLookUpEditPaymentType.GetIntValue() ?? 0;

            return JsonConvert.SerializeObject(info);
        }

        private void gcRetailReceipts_DoubleClick(object sender, EventArgs e)
        {
            var current = vwRetailReceiptHistoryBindingSource.GetBindingRow<AccountingDataSet.VwRetailReceiptHistoryRow>();
            if (current == null)
                return;

            parameters.Clear();
            parameters.Add("@operationTypeId", MHM.Accountancy.Business.Infrastructure.Common.OperationType.RetailReceiptSelect)
             .Add("@createDate", current.CreateDate);

            currentUser.ExecuteProcedure<AccountingDataSet.spGetGoodDataTable>(dataSet.spGetGood, "[Accounting].[spDocumentRetailTmp]", parameters, true,
                CommandType.StoredProcedure);


            RefreshMonitor();
            if (!string.IsNullOrWhiteSpace(current.InfoJson))
            {
                var info = JsonConvert.DeserializeObject<ReceiptInfo>(current.InfoJson);

                txtPayment.Text = info.Payment.ToString("0.##");
                erpLookUpEditPaymentType.EditValue = info.PaymentTypeId;
                txtSaleRetail.Text = info.Discount.ToString("0.##");
                if (decimal.TryParse(digitalGaugeAmount.Text, out decimal deficit))
                {
                    txtDeficit.Text = (info.Payment - deficit).ToString("0.##");
                }

            }
        }







        private void txtDiscountNumber_EditValueChanged(object sender, EventArgs e)
        {
            //if (!(txtDiscountNumber.Text == ""))
            //{
            //    decimal.TryParse(txtDiscountNumber.Text, out decimal discount);
            //    //RefreshMonitor();
            //    if (!decimal.TryParse(digitalGaugeAmount.Text, out decimal payment))
            //    {
            //        MHMMessage.ShowInformationMessageBox("Ancaq rəqəm  daxil edin");
            //        return;
            //    }
            //    else
            //    {
            //        payment = payment - discount;
            //        digitalGaugeAmount.Text = payment.ToString("#.00");
            //    }
            //}
            //else
            //    RefreshMonitor();
        }




        private void txtSaleRetail_EditValueChanged(object sender, EventArgs e)
        {
             
            //if (!(txtSaleRetail.Text == ""))
            //{
            //    decimal.TryParse(txtSaleRetail.Text, out decimal percent);
            //    RefreshMonitor();
            //    if (!decimal.TryParse(digitalGaugeAmount.Text, out decimal payment))
            //    {
            //        MHMMessage.ShowInformationMessageBox("Məhsul əlavə edin");
            //        return;
            //    }
            //    else
            //    {
            //        payment = payment + (payment * (percent * (-0.01M)));
            //        digitalGaugeAmount.Text = payment.ToString("#.00");
            //    }
            //}
            //else
            //    RefreshMonitor();
        }

        private void btnDiscountByNumber_Click(object sender, EventArgs e)
        {
            if (!(txtDiscountNumber.Text == ""))
            {
                decimal.TryParse(txtDiscountNumber.Text, out decimal discount);
                //RefreshMonitor();
                if (!decimal.TryParse(digitalGaugeAmount.Text, out decimal payment))
                {
                    MHMMessage.ShowInformationMessageBox("Ancaq rəqəm  daxil edin");
                    return;
                }
                else
                {
                    payment = payment - discount;
                    digitalGaugeAmount.Text = payment.ToString("#.00");
                }
            }
            else
                RefreshMonitor();
        }

        private void btnDiscountPercent_Click(object sender, EventArgs e)
        {

            if (!(txtSaleRetail.Text == ""))
            {
                decimal.TryParse(txtSaleRetail.Text, out decimal percent);
                RefreshMonitor();
                if (!decimal.TryParse(digitalGaugeAmount.Text, out decimal payment))
                {
                    MHMMessage.ShowInformationMessageBox("Məhsul əlavə edin");
                    return;
                }
                else
                {
                    payment = payment + (payment * (percent * (-0.01M)));
                    digitalGaugeAmount.Text = payment.ToString("#.00");
                }
            }
            else
                RefreshMonitor();
        }
    }
}

