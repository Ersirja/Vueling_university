using cuerpo_humano.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuerpo_humano.atributos
{
    public class ExtremidadBiologica : IExtremidad
    {
        public void Mover()
        {
            Console.WriteLine("La extremidad biológica se mueve naturalmente.");
        }
    }
}
