using ERP.Infrastructure.Extensions;
using MHM.Accountancy.Business.DataCenter.DataSetMainTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;
using static MHM.Accountancy.Business.DataCenter.DataSetMain;
using ext = MHM.Accountancy.Business.Infrastructure.Extensions.Extension;

namespace MHM.Accountancy.Win
{
    public partial class UserPermissionForm : DevExpress.XtraEditors.XtraForm
    {
        int principalId;
        public UserPermissionForm(int principalId)
        {
            InitializeComponent();
            this.principalId = principalId; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            treeUserPermission.EndUpdate();
            var permissions = (spUserPermissionsDataTable)treeUserPermission.DataSource;


            var table = ext.GetTableByFilter(permissions, "", true, "Id", "AllowShow", "AllowCreate", "AllowUpdate", "AllowDelete", "AllowInContainer", "AllowRetail","AllowApplyDocument", "ShowCreate" ,"ShowUpdate","ShowDelete","ShowApplyDocument");
            var @params = ERP.Infrastructure.Extensions.Extension.InitParameters()
                .Add("@principialId", principalId)
                .Add("@permission", "dbo.[UddtSetPermissions]", table);
            ext.ExecuteProcedure(Program.CurrentUser, "dbo.spSetPermissions", @params, System.Data.CommandType.StoredProcedure);

            @params.Clear();


            this.DialogResult = DialogResult.OK;
        }

        private void UserPermissionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet.WareHouse' table. You can move, or remove it, as needed.
            //this.wareHouseTableAdapter.Fill(this.accountingDataSet.WareHouse);
            using (var adp = new spUserPermissionsTableAdapter())
            using (var table = new spUserPermissionsDataTable())
            {
                adp.Fill(table, principalId);
                treeUserPermission.DataSource = table;
            }
        }




        private void treeUserPermission_Click(object sender, EventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tree = sender as DevExpress.XtraTreeList.TreeList;



            var row = (tree.GetFocusedRow() as DataRowView)?.Row as spUserPermissionsRow;

            var user = principalId;
            if (row.Id > 3)
            {
                this.accountingDataSet.spWareHousePermitted.Clear();
                if (row != null)
                {


                    if (!(accountingDataSet.spWareHousePermitted.ReserveMenuIdColumn is null))
                    {

                        accountingDataSet.spWareHousePermitted.ReserveMenuIdColumn.DefaultValue = row.Id;


                    }
                    this.spWareHousePermittedTableAdapter.Fill(this.accountingDataSet.spWareHousePermitted, principalId, row.Id);
                }


            }

        }











        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var permissions2 = accountingDataSet.spWareHousePermitted;

            var table2 = ext.GetTableByFilter(permissions2, "", true, "Allow", "Id", "ReserveMenuId");

            var @params = ERP.Infrastructure.Extensions.Extension.InitParameters();
            @params.Clear();

            @params.Add("@principialId", principalId)
                .Add("@permission", "dbo.UddtWareHousePermission", table2)
                ;
            ext.ExecuteProcedure(Program.CurrentUser, "dbo.spSetWareHousePermissions", @params, System.Data.CommandType.StoredProcedure);
        }
    }
}