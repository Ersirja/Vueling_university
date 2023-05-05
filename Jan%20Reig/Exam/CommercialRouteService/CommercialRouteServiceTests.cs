
using ClassLibrary1.Library.Models;
using Xunit;
using Moq;
using Exam.ServiceLibrary.Contracts.Repository;



namespace CommercialRouteService
{
    public class CommercialRouteServiceTests
    {
        [Fact]
        public void GetRoutes_ReturnsListOfRoutes()
        {
            // Arrange
            var mockPlanetRepo = new Mock<IPlanetRepository>();
            var mockDistanceRepo = new Mock<IDistanceRepository>();

            mockPlanetRepo.Setup(repo => repo.GetAllPlanets())
                          .Returns(new List<Planet>
                          {
                          new Planet { Id = 1, Name = "Earth", RebelInfluence = 0.2m },
                          new Planet { Id = 2, Name = "Mars", RebelInfluence = 0.5m },
                          new Planet { Id = 3, Name = "Jupiter", RebelInfluence = 0.8m }
                          });

            mockDistanceRepo.Setup(repo => repo.GetAllDistances())
                            .Returns(new List<Distance>
                            {
                            new Distance { Id = 1, OriginPlanetId = 1, DestinationPlanetId = 2, DistanceInLunarDays = 10 },
                            new Distance { Id = 2, OriginPlanetId = 1, DestinationPlanetId = 3, DistanceInLunarDays = 20 },
                            new Distance { Id = 3, OriginPlanetId = 2, DestinationPlanetId = 3, DistanceInLunarDays = 15 }
                            });

            var service = new CommercialRouteService(mockPlanetRepo.Object,
                                                     mockDistanceRepo.Object);

            // Act
            var routes = service.GetRoutes("Earth", "Mars", 100);

            // Assert
            Assert.NotNull(routes);
            Assert.IsType<List<Route>>(routes);
            Assert.Equal(2, routes.Count);
            Assert.Equal(1, routes[0].OriginPlanetId);
            Assert.Equal(2, routes[0].DestinationPlanetId);
            Assert.Equal(10, routes[0].DistanceInLunarDays);
            Assert.Equal(5, routes[0].PricesPerLunarDay);
            Assert.Equal(2500, routes[0].TotalAmount);
            Assert.Equal(200, routes[0].OriginDefenseCost);
            Assert.Equal(500, routes[0].DestinationDefenseCost);
            Assert.Equal(700, routes[0].EliteDefenseCost);
        }
    }
}