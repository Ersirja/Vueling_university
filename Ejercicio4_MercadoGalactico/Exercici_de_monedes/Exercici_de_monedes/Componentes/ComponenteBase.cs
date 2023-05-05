using Exercici_de_monedes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_de_monedes.Componentes
{
    public abstract class ComponenteBase : IComponente
    {
        public decimal Precio { get; set; }

        public virtual decimal ObtenerValor()
        {
            return Precio;
        }
    }
}
