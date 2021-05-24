using ERP.Infrastructure.Extensions;
using MHM.Accountancy.Business.Infrastructure.Extensions;
using System;

namespace MHM.Accountancy.Business.Infrastructure.Identity
{
    public class ManagerPermission : IDisposable
    {
        public ManagerPermission()
        {
            ShowAccess = true;
            CreateAccess = UpdateAccess = DeleteAccess = ContainerInAccess = false;
        }

        internal static ManagerPermission SetPermissions(User user, int managerId)
        {

            using (var table = new MainDataSet.IfnUserPermissionDataTable())
            using (ManagerPermission permission = new ManagerPermission())
            {
                var parameters = Helper.Init().Add("@managerid", managerId).Add("@userId", user.Id);
                user.ExecuteProcedure(table, "select isnull([Show],0) [Show],isnull([Create],0)[Create],isnull([Update],0)[Update],isnull([Delete],0)[Delete],isnull([AllowInContainer],0)[AllowInContainer] from [dbo].[IfnUserPermission](@userId,@managerid)", parameters);

                foreach (MainDataSet.IfnUserPermissionRow row in table)
                {
                    permission.ShowAccess = row.Show;
                    permission.CreateAccess = row.Create;
                    permission.UpdateAccess = row.Update;
                    permission.DeleteAccess = row.Delete;
                    permission.ContainerInAccess = row.AllowInContainer;
                    break;
                }

                return permission;
                }
            }

        public void Dispose()
        {
        }

        public bool ShowAccess { get; internal set; }
        public bool CreateAccess { get; internal set; }
        public bool UpdateAccess { get; internal set; }
        public bool DeleteAccess { get; internal set; }
        internal bool ContainerInAccess { get; set; }
        public bool ContainerInCreateAccess { get { return ContainerInAccess && CreateAccess; } }
        public bool ContainerInUpdateAccess { get { return ContainerInAccess && UpdateAccess; } }
        public bool ContainerInDeleteAccess { get { return ContainerInAccess && DeleteAccess; } }

    }
}
