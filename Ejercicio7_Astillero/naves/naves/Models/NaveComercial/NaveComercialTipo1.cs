using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using naves.Models;

namespace naves.Models.NaveComercial
{
    using System;

    namespace naves.Models
    {
        public class NaveComercialTipo1
        {
            // Propiedades de la nave comercial Tipo1
            public string Propiedad1 { get; set; }
            public int Propiedad2 { get; set; }
            // ... otras propiedades y/o métodos

            public string Nombre { get; set; }
            public int Capacidad { get; set; }
            public int Velocidad { get; set; }
            // Propiedades de una nave comercial
            public string NombreCompania { get; set; }

            public string Pasajeros { get; set; }

            // Constructor de la nave comercial Tipo1
            public NaveComercialTipo1(string Aglunta, int 300, int 5, string No  )
            {
                Nombre = Aglunta;
                Capacidad = 300;
                Velocidad = 5;
                NombreCompania = Aglunta;
                Pasajeros = No;



            }
        }
    }

}
