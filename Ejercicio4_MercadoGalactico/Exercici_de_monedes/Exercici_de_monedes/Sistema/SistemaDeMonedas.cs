using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercici_de_monedes.Sistema
{
    public class SistemaDeMonedas
    {
        public string MonedaBase { get; set; }
        public Dictionary<string, decimal> FactoresConversion { get; set; }

        public decimal Convertir(decimal valor, string monedaOrigen, string monedaDestino)
        {
            decimal factorOrigen = monedaOrigen == MonedaBase ? 1 : FactoresConversion[monedaOrigen];
            decimal factorDestino = monedaDestino == MonedaBase ? 1 : FactoresConversion[monedaDestino];

            return valor * (factorDestino / factorOrigen);
        }
    }

}
