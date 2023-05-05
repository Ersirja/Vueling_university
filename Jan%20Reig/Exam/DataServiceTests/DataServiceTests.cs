using ClassLibrary1.Infraestructure.Implementations.Data;
using ClassLibrary1.Library.Models;
using Xunit;

namespace DataServiceTests
{
    public class DataServiceTests
    {
        private readonly DataService _dataService;

        public DataServiceTests()
        {
            _dataService = new DataService();
        }

        [Fact]
        public void GetPlanets_ReturnsListOfPlanets()
        {
            // Act
            var result = _dataService.GetPlanets();

            // Assert
            Assert.IsType<List<Planet>>(result);
        }

        
    }
}