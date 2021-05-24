using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Win.Modules.Operation.Accounting.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.UI;
using MHM.Accountancy.Win.Modules.Operation.CRM.Managers.Forms;
using System.Data;
using DevExpress.XtraEditors;
using System.Drawing;
using System.IO;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers.Forms
{
    public partial class GoodForm : MHMForm
    {
        private IncludeForm includeForm;
        private OperationType select;

        public GoodForm(IManager manager, BindingSource bindingSource, OperationType operationType, bool applyNew = false)
          : base(manager, bindingSource, operationType, applyNew)
        {
            InitializeComponent();
        }

        public GoodForm(IncludeForm includeForm, BindingSource vwGoodBindingSource, OperationType select)
        {
            this.includeForm = includeForm;
            this.vwGoodBindingSource = vwGoodBindingSource;
            this.select = select;
        }

        private void GoodForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
            this.vwRegionTableAdapter.Fill(this.dataSet.VwRegion);
            // TODO: This line of code loads data into the 'accountingDataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.accountingDataSet.VwCompany);
            // TODO: This line of code loads data into the 'accountingDataSet.VwGoodType' table. You can move, or remove it, as needed.
            this.vwGoodTypeTableAdapter.Fill(this.accountingDataSet.VwGoodType);
            // TODO: This line of code loads data into the 'accountingDataSet.ImagesGood' table. You can move, or remove it, as needed.
            this.imagesGoodTableAdapter.Fill(this.accountingDataSet.ImagesGood);
            // TODO: This line of code loads data into the 'dataSet.VwGood' table. You can move, or remove it, as needed.
            this.vwGoodTableAdapter.Fill(this.accountingDataSet.VwGood); 
            // TODO: This line of code loads data into the 'dataSet.BarcodeGenerate' table. You can move, or remove it, as needed.
            this.barcodeGenerateTableAdapter.Fill(this.accountingDataSet.BarcodeGenerate);


            // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
            this.vwRegionTableAdapter.Fill(this.accountingDataSet.VwRegion);

            // TODO: This line of code loads data into the 'dataSet.VwGoodType' table. You can move, or remove it, as needed.
            this.vwGoodTypeTableAdapter.Fill(this.accountingDataSet.VwGoodType);

            // TODO: This line of code loads data into the 'cRMDataSet.VwUnit' table. You can move, or remove it, as needed.
            this.vwUnitTableAdapter.Fill(this.cRMDataSet.VwUnit);

            // TODO: This line of code loads data into the 'cRMDataSet.VwDose' table. You can move, or remove it, as needed.
            this.vwDoseTableAdapter.Fill(this.cRMDataSet.VwDose);

            // TODO: This line of code loads data into the 'cRMDataSet.VwPackingType' table. You can move, or remove it, as needed.
            this.vwPackingTypeTableAdapter.Fill(this.cRMDataSet.VwPackingType);

            // TODO: This line of code loads data into the 'dataSet.VwCompany' table. You can move, or remove it, as needed.
            this.vwCompanyTableAdapter.Fill(this.accountingDataSet.VwCompany);



            if (operationType == OperationType.Add)
                return;

            var currentRow = Current.GetBindingRow<AccountingDataSet.VwGoodRow>();
            if (currentRow == null)
                return;

            txtGoodName.Text = currentRow.GoodName;
            erpLookUpEditGoodTypeId.EditValue = currentRow.IsRegionIdNull() ? (int?)null : currentRow.GoodTypeId;
            erpLookUpEditManufacturerCompanyId.EditValue = currentRow.IsManufacturerCompanyIdNull() ? (int?)null :currentRow.ManufacturerCompanyId;
            erpTreeListLookUpEditRegionId.EditValue = currentRow.IsRegionIdNull() ? (int?)null : currentRow.RegionId;
            txtGoodCode.Text = currentRow.Id.ToString("000000000");
            erpLookUpEditPackingTypeId.EditValue = currentRow.IsPackingTypeIdNull() ? (int?)null : currentRow.PackingTypeId;
            erpLookUpEditDoseId.EditValue = currentRow.IsDoseIdNull() ? (int?)null : currentRow.DoseId;
            erpLookUpEditUnitId.EditValue = currentRow.IsUnitIdNull() ? (int?)null : currentRow.UnitId;
            txtDescription.Text = currentRow.IsDescriptionNull() ? "" : currentRow.Description;
            txtCode.Text = currentRow.IsGoodCodeNull() ? "" : currentRow.GoodCode;
            pictureEdit.Image = currentRow.IsPhotoNull() ? null : currentRow.Photo.ToImage();


            gridViewBarcode.LoadData(delegate
            {
                Parameters.Clear();
                Parameters.Add("@id", currentRow.BarcodeId);
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwBarcode, "select * from Accounting.IFnBarcodeGood(@id)", Parameters, true, System.Data.CommandType.Text);

            });

        }




        private void erpLookUpEditCustomerIdId_EditValueChanged(object sender, EventArgs e)
        {
            erpTreeListLookUpEditRegionId.Text = "";
            if (erpLookUpEditManufacturerCompanyId.EditValue == null) return;

            var current = accountingDataSet.VwCompany.FirstOrDefault(c => c.Id == Convert.ToInt32(erpLookUpEditManufacturerCompanyId.EditValue));

            erpTreeListLookUpEditRegionId.Text = current.RegionName;
        }

        private void erpLookUpEditGoodTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new GoodTypeForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwGoodTypeTableAdapter.Fill(this.accountingDataSet.VwGoodType);
                }

            }
        }

        private void erpLookUpEditCustomerIdId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void erpTreeListLookUpEditRegionId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpTreeListLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new RegionForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwRegionTableAdapter.Fill(this.accountingDataSet.VwRegion);
                }

            }
        }

        private void erpLookUpEditPackingTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new PackingTypeForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwPackingTypeTableAdapter.Fill(this.cRMDataSet.VwPackingType);
                }

            }
        }

        private void erpLookUpEditCustomerId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void erpLookUpEditUnitId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (sender is erpLookUpEdit)
            {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                {
                    using (var form = new UnitForm(null, null, OperationType.Add, true))
                    {
                        form.ShowDialog();
                        Manager.Loading();

                    }
                }

                else if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)
                {

                    // TODO: This line of code loads data into the 'dataSet.VwRegion' table. You can move, or remove it, as needed.
                    this.vwUnitTableAdapter.Fill(this.cRMDataSet.VwUnit);
                }

            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                Parameters.Clear();
                if (!txtGoodName.Validate()
                    || !erpLookUpEditGoodTypeId.Validate("Bu sahe bow buraxila bilmez !!!")
                    || !erpLookUpEditManufacturerCompanyId.Validate()
                    || !erpTreeListLookUpEditRegionId.Validate()
                    || !erpLookUpEditPackingTypeId.Validate()
                    || !erpLookUpEditDoseId.Validate()
                    || !erpLookUpEditUnitId.Validate()
                    ) return;



                Parameters.Clear();
                Parameters.Add("@operationType", operationType)
                    .Add("@goodName", txtGoodName.Text)
                    .Add("@goodTypeId", erpLookUpEditGoodTypeId.GetIntValue())
                    .Add("@regionId", erpTreeListLookUpEditRegionId.GetIntValue())
                    .Add("@manufacturerCompanyId", erpLookUpEditManufacturerCompanyId.GetIntValue())
                    .Add("@unitId", erpLookUpEditUnitId.GetIntValue())
                    .Add("@doseId", erpLookUpEditDoseId.GetIntValue())
                    .Add("@packingTypeId", erpLookUpEditPackingTypeId.GetIntValue())
                    .Add("@description", txtDescription.Text)
                    .Add("@goodCode", txtCode.Text);

                if (pictureEdit.Image != null)
                    Parameters.Add("@photo", pictureEdit.Image.GetBytes());

                Parameters.Add("@detail", "[Accounting].[UddtBarcodeGood]",
                    accountingDataSet.VwBarcode.GetTableByFilter("", true, "Id", "GoodId", "Barcode"));
                if (operationType != OperationType.Add && operationType != OperationType.Add)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwGoodRow>();

                    Parameters.Add("@id", currentRow.Id);
                }
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwGood, "[Accounting].[spGood]", Parameters, true, System.Data.CommandType.StoredProcedure);
                if (checkApplyNew.Checked)
                {
                    accountingDataSet.VwBarcode.Clear();
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void btnAddBarcode_Click(object sender, EventArgs e)
        {

            gridControlBarcode.EmbeddedNavigator.Buttons.DoClick(gridControlBarcode.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlBarcode;
            gridViewBarcode.FocusedColumn = colBarcode;
        }
        private void btnApplyBarcode_Click(object sender, EventArgs e)
        {
            gridControlBarcode.EmbeddedNavigator.Buttons.DoClick(gridControlBarcode.EmbeddedNavigator.Buttons.EndEdit);
        }
        private void btnDeleteBarcode_Click(object sender, EventArgs e)
        {
            gridControlBarcode.EmbeddedNavigator.Buttons.DoClick(gridControlBarcode.EmbeddedNavigator.Buttons.Remove);
        }

        private void btnBarcodeGeneration_Click(object sender, EventArgs e)
        {
            Parameters.Clear();
            Parameters.Add("@barcodeGen", (long)0, ParameterDirection.InputOutput);
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwBarcode, "[Accounting].[spBarcodeGenerate]", Parameters, false, System.Data.CommandType.StoredProcedure);

            accountingDataSet.VwBarcode.AddVwBarcodeRow(0,"",0, Parameters.FirstOrDefault(p=>p.ParameterName== "@barcodeGen").Value.ToString());
            
        }

        private void erpLookUpEditManufacturerCompanyId_EditValueChanged(object sender, EventArgs e)
        {
            erpTreeListLookUpEditRegionId.EditValue = "";
            if (erpLookUpEditManufacturerCompanyId.EditValue == null) return;
            var current = accountingDataSet.VwCompany.FirstOrDefault(c => c.Id == erpLookUpEditManufacturerCompanyId.GetIntValue());

            if (current == null) return;
            erpTreeListLookUpEditRegionId.EditValue = current.RegionId;
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new ImageForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataSet.ImagesGood.AddImagesGoodRow(0, form.IsMain, form.ImageBuffer,0,DateTime.Now,DateTime.Now,0);
                }
            }
        }

        private void btnBarcodeAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlBarcode.EmbeddedNavigator.Buttons.DoClick(gridControlBarcode.EmbeddedNavigator.Buttons.Append);
            ActiveControl = gridControlBarcode;
            gridViewBarcode.FocusedColumn = colBarcode;
        }

        private void btnBarcodeDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlBarcode.EmbeddedNavigator.Buttons.DoClick(gridControlBarcode.EmbeddedNavigator.Buttons.Remove);
        }

        private void btnBarcodeGen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Parameters.Clear();
            Parameters.Add("@barcodeGen", (long)0, ParameterDirection.InputOutput);
            Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwBarcode, "[Accounting].[spBarcodeGenerate]", Parameters, false, System.Data.CommandType.StoredProcedure);

            accountingDataSet.VwBarcode.AddVwBarcodeRow(0, "", 0, Parameters.FirstOrDefault(p => p.ParameterName == "@barcodeGen").Value.ToString());

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAcceptGood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Təsdiqləmək İstədiyinizə Əminsiz?", "Diqqət!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                Parameters.Clear();
                if (!txtGoodName.Validate()
                    || !erpLookUpEditGoodTypeId.Validate("Bu sahe bow buraxila bilmez !!!")
                    || !erpLookUpEditManufacturerCompanyId.Validate()
                    || !erpTreeListLookUpEditRegionId.Validate()
                    || !erpLookUpEditPackingTypeId.Validate()
                    || !erpLookUpEditDoseId.Validate()
                    || !erpLookUpEditUnitId.Validate()
                    ) return;



                Parameters.Clear();
                Parameters.Add("@operationType", operationType)
                    .Add("@goodName", txtGoodName.Text)
                    .Add("@goodTypeId", erpLookUpEditGoodTypeId.GetIntValue())
                    .Add("@regionId", erpTreeListLookUpEditRegionId.GetIntValue())
                    .Add("@manufacturerCompanyId", erpLookUpEditManufacturerCompanyId.GetIntValue())
                    .Add("@unitId", erpLookUpEditUnitId.GetIntValue())
                    .Add("@doseId", erpLookUpEditDoseId.GetIntValue())
                    .Add("@packingTypeId", erpLookUpEditPackingTypeId.GetIntValue())
                    .Add("@description", txtDescription.Text)
                    .Add("@goodCode", txtCode.Text);

                if (pictureEdit.Image != null)
                    Parameters.Add("@photo", pictureEdit.Image.GetBytes());

                Parameters.Add("@detail", "[Accounting].[UddtBarcodeGood]",
                    accountingDataSet.VwBarcode.GetTableByFilter("", true, "Id", "GoodId", "Barcode"));
                if (operationType != OperationType.Add && operationType != OperationType.Add)
                {
                    var currentRow = Current.GetBindingRow<AccountingDataSet.VwGoodRow>();

                    Parameters.Add("@id", currentRow.Id);
                }
                Manager.MHMContainer.CurrentUser.ExecuteProcedure(accountingDataSet.VwGood, "[Accounting].[spGood]", Parameters, true, System.Data.CommandType.StoredProcedure);
                if (checkApplyNew.Checked)
                {
                    accountingDataSet.VwBarcode.Clear();
                    base.ClearInputs();
                    Manager.Loading();
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }




        //private void lookUpEditBase_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    switch (e.Button.Kind)
        //    {
        //        case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete:
        //            (sender as LookUpEditBase).EditValue = null;
        //            break;
        //        default:
        //            break;
        //    }
        //}

    }
}