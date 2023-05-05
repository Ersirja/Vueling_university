using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Library.Models
{
    public class Distance
    {
        public int Id { get; set; }
        public int OriginPlanetId { get; set; }
        public int DestinationPlanetId { get; set; }
        public int DistanceInLunarDays { get; set; }
    }
}
