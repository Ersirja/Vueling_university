using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_12.Library.Items
{
    /// <summary>
    /// All the methods for Weapon
    /// </summary>
    public class Weapon
    {
        public string Name { get; private set; }
        public int Ataque { get; private set; }
        public int AcquisitionDate { get; private set; }
        public int SalePrice { get; private set; } // Agregar propiedad SalePrice


        public Weapon(string name, int ataque, int acquisitionDate)
        {
            Name = name;
            Ataque = ataque;
            AcquisitionDate = acquisitionDate;
            SalePrice = SalePrice; // Asignar valor a la propiedad SalePrice
        }
    }
}

