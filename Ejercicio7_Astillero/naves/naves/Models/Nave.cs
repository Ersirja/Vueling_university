using naves.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naves.Models
{
    namespace Models
    {
        public class Nave : INave
        {
            // Propiedades de una nave
            public string Nombre { get; set; }
            public int Capacidad { get; set; }
            public int Velocidad { get; set; }
            // ... otras propiedades y métodos específicos de una nave
        }
    }

}
