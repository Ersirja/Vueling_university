using naves.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace naves.Models
{
    public class NaveComercial : INaveComercial
    {

        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public int Velocidad { get; set; }
        // Propiedades de una nave comercial
        public string NombreCompania { get; set; }

        public string Pasajeros { get; set; }


    }
}
