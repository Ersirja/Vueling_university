using ClassLibrary1.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Infraestructure.Contracts.Interfaces
{
    public interface ITradeRouteService
    {
        List<Route> GetRoutes(int originPlanetId, int destinationPlanetId);
    }

}
