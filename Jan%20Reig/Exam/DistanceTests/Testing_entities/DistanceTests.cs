
using ClassLibrary1.Library.Models;
using Xunit;


namespace Exam.ServiceLibrary.UnitTest.Testing_entities
{




    public class DistanceTests
    {
        /// <summary>
        /// DistanceTests Testing
        /// </summary>
        [Fact]
        public void DistanceProperties_GetAndSetCorrectly()
        {
            // Arrange
            int id = 1;
            int originPlanetId = 2;
            int destinationPlanetId = 3;
            int distanceInLunarDays = 4;

            // Act
            Distance distance = new Distance();
            distance.Id = id;
            distance.OriginPlanetId = originPlanetId;
            distance.DestinationPlanetId = destinationPlanetId;
            distance.DistanceInLunarDays = distanceInLunarDays;

            // Assert
            Assert.Equal(id, distance.Id);
            Assert.Equal(originPlanetId, distance.OriginPlanetId);
            Assert.Equal(destinationPlanetId, distance.DestinationPlanetId);
            Assert.Equal(distanceInLunarDays, distance.DistanceInLunarDays);
        }
    }
}