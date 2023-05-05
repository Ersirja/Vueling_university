using System.Collections.Generic;
using System.Linq;
using Exam.ServiceLibrary.Contracts.Interfaces;
using ClassLibrary1.Library.Models;
using Exam.ServiceLibrary.Contracts.Repository;

namespace ClassLibrary1.Infraestructure.Implementations.Service
{
    public class CommercialRouteService : ICommercialRouteService
    {
        private readonly IPlanetRepository _planetRepository;
        private readonly IDistanceRepository _distanceRepository;

        public CommercialRouteService(IPlanetRepository planetRepository, IDistanceRepository distanceRepository)
        {
            _planetRepository = planetRepository;
            _distanceRepository = distanceRepository;
        }

        public List<Route> GetRoutes(string originPlanetName, string destinationPlanetName, decimal weight)
        {
            var planets = _planetRepository.GetAllPlanets();
            List<Distance> distances = _distanceRepository.GetAllDistances();
            var routes = new List<Route>();

            foreach (var origin in planets)
            {
                foreach (var destination in planets)
                {
                    if (origin.Id != destination.Id)
                    {
                        var distance = distances.FirstOrDefault(d =>
                            (d.OriginPlanetId == origin.Id && d.DestinationPlanetId == destination.Id) ||
                            (d.OriginPlanetId == destination.Id && d.DestinationPlanetId == origin.Id));

                        if (distance != null)
                        {
                            var fuelPrice = distance.DistanceInLunarDays * 0.5m; 

                            var route = new Route
                            {
                                Id = routes.Count + 1,
                                OriginPlanetId = origin.Id,
                                DestinationPlanetId = destination.Id,
                                DistanceInLunarDays = distance.DistanceInLunarDays,
                                PricesPerLunarDay = fuelPrice,
                                TotalAmount = fuelPrice * 500, 
                                OriginDefenseCost = origin.RebelInfluence * 1000, 
                                DestinationDefenseCost = destination.RebelInfluence * 1000, 
                                EliteDefenseCost = (origin.RebelInfluence + destination.RebelInfluence) * 1000 
                            };

                            routes.Add(route);
                        }
                    }
                }
            }

            return routes;
        }
    }


}
