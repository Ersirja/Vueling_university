using ClassLibrary1.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exam.ServiceLibrary.UnitTest.Testing_entities
{
    public class SpyReportTests
    {
        public SpyReportTests()
        {
        }

        [Fact]
        public void TestCreateSpyReport()
        {
            // Arrange
            int expectedId = 1;
            int expectedPlanetId = 2;
            decimal expectedRebelInfluence = 0.5m;

            // Act
            var spyReport = new SpyReport
            {
                Id = expectedId,
                PlanetId = expectedPlanetId,
                RebelInfluence = expectedRebelInfluence
            };

            // Assert
            Assert.Equal(expectedId, spyReport.Id);
            Assert.Equal(expectedPlanetId, spyReport.PlanetId);
            Assert.Equal(expectedRebelInfluence, spyReport.RebelInfluence);
        }
    }
}
