using MHM.Accountancy.Business.Infrastructure.Identity;
using MHM.Accountancy.Business.DataCenter;
using MHM.Accountancy.Business.DataCenter.DataSetMainTableAdapters;
 
namespace MHM.Accountancy.Business
{
    public static class Adapter
    {
        public static void FillMenuByUser(this User user, DataSetMain dataSet)
        {
            dataSet.spMenuPermitted.Clear();
            using (var adapter = new spMenuPermittedTableAdapter())
            {
                adapter.Fill(dataSet.spMenuPermitted,user.Id);
            }
        }
    }
}
