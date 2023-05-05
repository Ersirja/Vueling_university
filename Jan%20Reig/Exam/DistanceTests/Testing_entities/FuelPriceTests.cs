using ClassLibrary1.Library.Models;
using Xunit;

namespace Exam.ServiceLibrary.UnitTest.Testing_entities
{
    public class FuelPriceTests
    {
        /// <summary>
        /// FuelPriceTests Testing
        /// </summary>
        [Fact]
        public void FuelPriceProperties_GetAndSetCorrectly()
        {
            // Arrange
            int id = 1;
            decimal pricePerLunarDay = 10.50m;

            // Act
            FuelPrice fuelPrice = new FuelPrice();
            fuelPrice.Id = id;
            fuelPrice.PricePerLunarDay = pricePerLunarDay;

            // Assert
            Assert.Equal(id, fuelPrice.Id);
            Assert.Equal(pricePerLunarDay, fuelPrice.PricePerLunarDay);
        }
    }
}
