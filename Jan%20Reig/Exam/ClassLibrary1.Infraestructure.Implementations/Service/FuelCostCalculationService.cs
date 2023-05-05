
using ClassLibrary1.Library.Models;
using Exam.ServiceLibrary.Contracts.Repository;
using Exam.ServiceLibrary.Contracts.Interfaces;
using System.Collections.Generic;

namespace ClassLibrary1.Infraestructure.Implementations.Service
{
    public class FuelCostCalculationService : IFuelCostCalculationService
    {
        private readonly IFuelPriceRepository _fuelPriceRepository;

        public FuelCostCalculationService(IFuelPriceRepository fuelPriceRepository)
        {
            _fuelPriceRepository = fuelPriceRepository;
        }

        public decimal CalculateFuelCost(Route route, FuelPrice fuelPrice, decimal weight)
        {
            var distance = route.DistanceInLunarDays;
            var fuelConsumptionRate = 0.002m;

            var fuelCost = fuelPrice.Price * distance * weight * fuelConsumptionRate;

            return fuelCost;
        }

        public override bool Equals(object obj)
        {
            return obj is FuelCostCalculationService service &&
                   EqualityComparer<IFuelPriceRepository>.Default.Equals(_fuelPriceRepository, service._fuelPriceRepository);
        }
    }
}
