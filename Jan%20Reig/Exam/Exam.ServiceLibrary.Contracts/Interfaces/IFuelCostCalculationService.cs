using ClassLibrary1.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.ServiceLibrary.Contracts.Interfaces
{
    public interface IFuelCostCalculationService
    {
        decimal CalculateFuelCost(Route route, FuelPrice fuelPrice, decimal weight);
    }
}
