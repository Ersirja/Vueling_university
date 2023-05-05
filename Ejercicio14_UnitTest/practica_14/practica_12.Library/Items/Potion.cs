using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_14.Library.Items
{
    /// <summary>
    /// All the methods for Potion
    /// </summary>
    public class Potion
    {
        public string Name { get; private set; }
        public int Power { get; private set; }
        public int AcquisitionDate { get; private set; }
        public int SalePrice { get; private set; } // Agregar propiedad SalePrice


        public Potion(string nombre, int power, int acquisitionDate)
        {
            Name = nombre;
            Power = power;
            AcquisitionDate = acquisitionDate;
            SalePrice = SalePrice; // Asignar valor a la propiedad SalePrice
        }
    
    }
}
