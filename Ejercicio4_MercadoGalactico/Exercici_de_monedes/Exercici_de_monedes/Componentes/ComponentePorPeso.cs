using Exercici_de_monedes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercici_de_monedes.Componentes
{
    // Clase para componentes que se miden por peso
    public class ComponentePorPeso : ComponenteBase, IComponente
    {
        public decimal Peso { get; set; }
        public decimal FactorConversion { get; set; }

        public override decimal ObtenerValor()
        {
            return Precio * Peso * FactorConversion;
        }
    }
}
