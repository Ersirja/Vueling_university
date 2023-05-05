using ClassLibrary1.Library.Models;
using System.Collections.Generic;

namespace ClassLibrary1.Infraestructure.Contracts.Interfaces
{
    public interface ISpyReportService
    {
        List<SpyReport> GetSpyReports();
    }
}
