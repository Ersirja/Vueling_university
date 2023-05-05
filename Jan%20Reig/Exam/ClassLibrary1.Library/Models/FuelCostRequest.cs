using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Library.Models
{
    public class FuelCostRequest
    {
        public string StartPlanet { get; set; }
        public string EndPlanet { get; set; }
        public decimal FuelConsumption { get; set; }
        public decimal FuelPrice { get; set; }
        public decimal WeightInKg { get; set; }
        public decimal DistanceInLunarDays { get; set; }
    }

}
