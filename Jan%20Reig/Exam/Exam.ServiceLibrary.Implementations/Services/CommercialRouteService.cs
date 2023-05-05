using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClassLibrary1.Library.Models;
using Exam.ServiceLibrary.Contracts.Interfaces;

namespace Exam.ServiceLibrary.Implementations.Services
{
    public class CommercialRouteService : ICommercialRouteService
    {
        public List<Route> GetRoutes()
        {
            // Implementation to obtain commercial route information from a web service and convert it into the desired format
            throw new NotImplementedException();
        }

        public Task<List<Route>> GetRoutesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
