using cuerpo_humano.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuerpo_humano.atributos
{
    public class MejoraGadget : ExtremidadDecorator
    {
        public MejoraGadget(IExtremidad extremidad) : base(extremidad)
        {
        }

        public override void Mover()
        {
            base.Mover();
            Console.WriteLine("Se ha aplicado una mejora de gadget a la extremidad.");
        }
    }
}
