using naves.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naves.Models
{
    public class NaveTitan : INave
    {
        // Propiedades de una nave titán
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public int Velocidad { get; set; }

    }
}
