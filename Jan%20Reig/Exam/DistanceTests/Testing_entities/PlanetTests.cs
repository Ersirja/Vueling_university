using ClassLibrary1.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exam.ServiceLibrary.UnitTest.Testing_entities
{
    public class PlanetTests
    {
        /// <summary>
        /// PlanetTests Testing
        /// </summary>
        [Fact]
        public void TestPlanetProperties()
        {
            // Arrange
            Planet planet = new Planet();

            // Act
            planet.Id = 1;
            planet.Name = "Tatooine";
            planet.RebelInfluence = 0.5m;

            // Assert
            Assert.Equal(1, planet.Id);
            Assert.Equal("Tatooine", planet.Name);
            Assert.Equal(0.5m, planet.RebelInfluence);
        }
    }
}
