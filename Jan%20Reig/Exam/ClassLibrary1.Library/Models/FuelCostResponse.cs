using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Library.Models
{
    public class FuelCostResponse
    {
        public string StartPlanet { get; set; }
        public string EndPlanet { get; set; }
        public decimal Distance { get; set; }
        public decimal FuelConsumption { get; set; }
        public decimal FuelPrice { get; set; }
        public decimal TotalFuelCost { get; set; }

        public decimal FuelCost { get; set; }
    }
}
