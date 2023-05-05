using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using naves.Interfaces;
using naves.Factories;

namespace naves.Interfaces
{
    public interface INave
    {
        string Nombre { get; set; }
        int Capacidad{ get; set; }
        int Velocidad { get; set; }
       
    }
}
