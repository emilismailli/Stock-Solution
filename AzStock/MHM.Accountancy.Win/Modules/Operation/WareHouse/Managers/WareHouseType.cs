using DevExpress.XtraBars;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using MHM.Accountancy.Business.Infrastructure.Utils;
using MHM.Accountancy.Business.Properties;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Data;
using MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers.Forms;
using MHM.Accountancy.Business.Infrastructure.Common;
namespace MHM.Accountancy.Win.Modules.Operation.WareHouse.Managers
{
    public partial class WareHouseType : MHMManager,IManager
    {
        
        WareHouseType(IContainer container,int managerId)
            :base(container,managerId)
        {
            InitializeComponent();

            //DevExpress.Utils.OptionsLayoutGrid opts = new DevExpress.Utils.OptionsLayoutGrid();
            //opts.Columns.RemoveOldColumns = true;
            //opts.Columns.StoreAllOptions = true;
            //opts.StoreVisualOptions = true;
            //opts.Columns.StoreAppearance = true;
            //gridView.RestoreLayoutFromXml(@"Layouts\warehousetype.xml", opts);
            gridViewWareHouseType.ApplyDefaultSettings(true, false);
            //gridView.ApplyNavigatorPermission(permission, false);
            Loading();
        }

        

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            EditableButtons = e.FocusedRowHandle >= 0;
        }


        protected override void btnShow_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new WareHouseTypeForm(this, wareHouseTypeBindingSource, OperationType.None))
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess("Bax");
                    Loading();
                }
        }

       
        protected override void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new WareHouseTypeForm(this, wareHouseTypeBindingSource, OperationType.Add,true))
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
        }

        protected override void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new WareHouseTypeForm(this, wareHouseTypeBindingSource, OperationType.Edit))
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MHMContainer.PrintSuccess(CommonLang.Success);
                    Loading();
                }
        }



        protected override void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

            var row = wareHouseTypeBindingSource.GetBindingRow<WareHouseDataSet.WareHouseTypeRow>();

            if (row != null && MHMMessage.ShowQuestionMessageBox("Silmek istediyinizden əminsinizmi?") == System.Windows.Forms.DialogResult.OK)
            {
                MHMContainer.InvokeAction(delegate
                {
                    gridViewWareHouseType.LoadData(delegate {
                        Parameters.Clear();
                        Parameters.Add("@operationType", OperationType.Delete)
                        .Add("@id", row.Id);

                        MHMContainer.CurrentUser.ExecuteProcedure(dataSet.WareHouseType, "[WareHouses].[spWareHouseType]", Parameters, true, System.Data.CommandType.StoredProcedure);
                    });
                });

                Loading();
            }
        }

        public override void Loading()
        {
            MHMContainer.InvokeAction(delegate
            {
                gridViewWareHouseType.LoadData(delegate {
                    Parameters.Clear();
                    Parameters.Add("@operationType", OperationType.Select)
                   ;

                    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.WareHouseType, "[WareHouses].[spWareHouseType]", Parameters, true, System.Data.CommandType.StoredProcedure);
                });
            });
        }

        public void ExportToExcel()
        {
            throw new System.NotImplementedException();
        }
    }
}
