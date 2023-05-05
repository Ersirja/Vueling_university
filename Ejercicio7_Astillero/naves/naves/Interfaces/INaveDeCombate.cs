using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using naves.Interfaces;
using naves.Factories;

namespace naves.Interfaces
{
    public interface INaveDeCombate : INave
    {

        int NumeroDeArmas { get; set; }
        int NumeroDeMuniciones { get; set; }

        
    }
}
