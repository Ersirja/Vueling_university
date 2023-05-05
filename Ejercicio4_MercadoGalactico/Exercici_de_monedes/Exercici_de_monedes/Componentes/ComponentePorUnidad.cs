using Exercici_de_monedes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_de_monedes.Componentes
{
    public class ComponentePorUnidad : ComponenteBase, IComponente
    {
        public int Cantidad { get; set; }
        public decimal FactorConversion { get; set; }

        public override decimal ObtenerValor()
        {
            return Precio * Cantidad * FactorConversion;
        }
    }
}
