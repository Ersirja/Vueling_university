using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Library.Models
{
    public class SpyReport
    {
        public int Id { get; set; }
        public int PlanetId { get; set; }
        
        public string PlanetName { get; set; }
        public decimal RebelInfluence { get; set; }
    }   
}
