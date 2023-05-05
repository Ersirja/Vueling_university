using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Library.Models
{
    public class Route
    {
        public int Id { get; set; }
        public int OriginPlanetId { get; set; }
        public int DestinationPlanetId { get; set; }
        public int DistanceInLunarDays { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PricesPerLunarDay { get; set; }
        public decimal OriginDefenseCost { get; set; }
        public decimal DestinationDefenseCost { get; set; }
        public decimal EliteDefenseCost { get; set; }
    }
}
