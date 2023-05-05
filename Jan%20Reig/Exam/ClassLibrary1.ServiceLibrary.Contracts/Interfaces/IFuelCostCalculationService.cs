



using ClassLibrary1.Library.Models;
using System.Collections.Generic;

namespace ClassLibrary1.Infraestructure.Contracts.Interfaces
{
    public interface ICommercialRouteService
    {
        List<Route> GetRoutes(string originPlanetName, string destinationPlanetName, decimal weight);
    }
}
