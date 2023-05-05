using cuerpo_humano.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuerpo_humano.atributos
{
    public class MejoraBiologica : ExtremidadDecorator
    {
        public MejoraBiologica(IExtremidad extremidad) : base(extremidad)
        {
        }

        public override void Mover()
        {
            base.Mover();
            Console.WriteLine("Se ha aplicado una mejora biológica a la extremidad.");
        }
    }
}
