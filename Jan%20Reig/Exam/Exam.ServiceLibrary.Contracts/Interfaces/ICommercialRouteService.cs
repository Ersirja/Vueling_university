using ClassLibrary1.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.ServiceLibrary.Contracts.Interfaces
{
    public interface ICommercialRouteService
    {
        List<Route> GetRoutes(string originPlanetName, string destinationPlanetName, decimal weight);
    }

}
