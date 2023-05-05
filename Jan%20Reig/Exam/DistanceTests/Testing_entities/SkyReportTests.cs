using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Library.Models;
using Xunit;

namespace Exam.ServiceLibrary.UnitTest.Testing_entities
{


    public class SpyReportTest
    {
        [Fact]
        public void TestSpyReportId()
        {
            // Arranges
            int expectedId = 1;
            var spyReport = new SpyReport();

            // Act
            spyReport.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, spyReport.Id);
        }

        [Fact]
        public void TestSpyReportPlanetId()
        {
            // Arrange
            int expectedPlanetId = 2;
            var spyReport = new SpyReport();

            // Act
            spyReport.PlanetId = expectedPlanetId;

            // Assert
            Assert.Equal(expectedPlanetId, spyReport.PlanetId);
        }

        [Fact]
        public void TestSpyReportRebelInfluence()
        {
            // Arrange
            decimal expectedRebelInfluence = 0.5m;
            var spyReport = new SpyReport();

            // Act
            spyReport.RebelInfluence = expectedRebelInfluence;

            // Assert
            Assert.Equal(expectedRebelInfluence, spyReport.RebelInfluence);
        }
    }
}
