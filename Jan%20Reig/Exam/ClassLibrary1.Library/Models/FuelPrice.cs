using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Library.Models
{
    public class FuelPrice
    {
        public int Id { get; set; }
        public decimal PricePerLunarDay { get; set; }

        public decimal Price { get; set; }
    }
}
