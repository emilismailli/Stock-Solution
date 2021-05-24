using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHM.Accountancy.Business.Infrastructure;
using MHM.Accountancy.Business.Infrastructure.Interfaces;

namespace MHM.Accountancy.Win.Modules.Operation.Accounting.Managers
{
    public partial class WholeSaleReportManager : MHMManager, IManager
    {
        WholeSaleReportManager(IContainer container, int managerId)
           : base(container, managerId)
        {
            InitializeComponent();
            Redesign();
            Loading();
            bar2.Visible = false;
        }
        public override void Loading()
        {
            vwWholeSaleReportTableAdapter.Fill(accountingDataSet.VwWholeSaleReport);
            //    Parameters.Clear();
            //    Parameters.Add("@operationType", OperationType.Select);
            //    MHMContainer.CurrentUser.ExecuteProcedure(dataSet.VwAccount, "[Accounting].[spAccount]", Parameters, true, System.Data.CommandType.StoredProcedure);
            //
        }
    }
}
 
