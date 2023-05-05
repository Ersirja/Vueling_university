using naves.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using naves.Interfaces;
using naves.Factories;


namespace naves.Models
{
    public class NaveDeCombate : INaveDeCombate

    {

        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public int Velocidad { get; set; }

        public int NumeroDeArmas { get; set; }
        public int NumeroDeMuniciones { get; set; }

    }
}
