using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using cuerpo_humano.cuerpo_humano;

namespace cuerpo_humano
{
    class Program
    {
        static void Main(string[] args)
        {
            CuerpoHumano cuerpo = new CuerpoHumano();
            cuerpo.MoverExtremidad(); 

            cuerpo.ModificarExtremidadConGadget();
            cuerpo.MoverExtremidad(); 

            cuerpo.ModificarExtremidadConMejoraBiologica();
            cuerpo.MoverExtremidad(); 
        }
    }
}
