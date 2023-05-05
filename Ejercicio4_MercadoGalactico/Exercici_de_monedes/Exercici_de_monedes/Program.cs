using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercici_de_monedes.interfaces;

using Exercici_de_monedes.Componentes;
using Exercici_de_monedes.Sistema;

namespace Exercici_de_monedes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un sistema de monedas con USD como moneda base y factores de conversión
            var sistemaMonedas = new SistemaDeMonedas
            {
                MonedaBase = "USD",
                FactoresConversion = new Dictionary<string, decimal>
            {
                { "EUR", 0.85M },
                { "MXN", 20.08M },
                { "JPY", 110.94M }
            }
            };

            // Crear componentes y agregarlos al sistema
            var componente1 = new ComponentePorPeso
            {
                Precio = 10,
                Peso = 5,
                FactorConversion = sistemaMonedas.FactoresConversion["MXN"]
            };

            var componente2 = new ComponentePorUnidad
            {
                Precio = 15,
                Cantidad = 2,
                FactorConversion = sistemaMonedas.FactoresConversion["EUR"]
            };

            var totalValor = componente1.ObtenerValor() + componente2.ObtenerValor();

            //PORQUE NO ES CORRECTO ESTA PARTE Y QUE DA ERROR, PORQUE NO SE IMPRIME LA PAGINA? PREGUNTAR A ADRIAN

            // Convertir el valor a otras monedas utilizando el sistema de monedas
            var valorUSD = sistemaMonedas.Convertir(totalValor, "MXN", "USD");
            var valorJPY = sistemaMonedas.Convertir(totalValor, "MXN", "JPY");

            Console.WriteLine($"El valor total en USD es: {valorUSD}");
            Console.WriteLine($"El valor total en JPY es: {valorJPY}");
            Console.ReadLine();
        }
    }
}
