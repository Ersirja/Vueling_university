using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colmena.ServiceLibrary.Service;
using Colmena.ServiceLibrary.Infraestructrures;
using Newtonsoft.Json;


namespace Presentacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            IColmenaRepository colmenaRepository = new ColmenaRepository(@"C:\datos.json");
            AbejaService abejaService = new AbejaService(colmenaRepository);

            Console.WriteLine("Cantidad de polen por hora:");
            Console.WriteLine("----------------------------");

            while (true)
            {
                Console.WriteLine("¿Desea filtrar por estado? (s/n)");
                string respuestaEstado = Console.ReadLine();

                bool? estado = null;
                if (respuestaEstado.ToLower() == "s")
                {
                    Console.WriteLine("¿Cuál es el estado? (true/false)");
                    estado = Convert.ToBoolean(Console.ReadLine());
                }

                Console.WriteLine("¿Desea filtrar por cantidad de incidentes? (s/n)");
                string respuestaIncidentes = Console.ReadLine();

                int? incidentes = null;
                if (respuestaIncidentes.ToLower() == "s")
                {
                    Console.WriteLine("¿Cuántos incidentes?");
                    incidentes = Convert.ToInt32(Console.ReadLine());
                }

                decimal polenPorHora = abejaService.CalcularPolenPorHora("hh:mm:ss", estado, incidentes, abejaService.Get_colmenaRepository());

                Console.WriteLine($"El polen recolectado por hora es: {polenPorHora} mg");

                Console.WriteLine("¿Desea hacer otra consulta? (s/n)");
                string respuestaOtraConsulta = Console.ReadLine();

                if (respuestaOtraConsulta.ToLower() == "n")
                {
                    break;
                }
            }

            Console.WriteLine("Fin del programa.");
            Console.ReadLine();
        }
    }

}