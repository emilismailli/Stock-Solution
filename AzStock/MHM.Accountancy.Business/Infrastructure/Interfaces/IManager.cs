using System.Collections.Generic;
using System.Data.SqlClient;

namespace MHM.Accountancy.Business.Infrastructure.Interfaces
{
    public interface IManager
    {
        int Id { get; }
        bool IsFiltered { get; }
        int? DocSeriesId { get; }
        int? DocCertId { get; }
        int? DocTypeId { get; }
        List<SqlParameter> Parameters { get; }
        IContainer MHMContainer { get; }

        void Loading();

        void ExportToExcel();
    }
}
