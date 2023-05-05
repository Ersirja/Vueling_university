using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colmena.ServiceLibrary.Service;
using Colmena.Library.entities;

namespace Colmena.ServiceLibrary.Infraestructrures
{
    public class AbejaService
    {
        private readonly IColmenaRepository _colmenaRepository;

        public AbejaService(IColmenaRepository colmenaRepository)
        {
            _colmenaRepository = colmenaRepository;
        }

        public IColmenaRepository Get_colmenaRepository()
        {
            return _colmenaRepository;
        }

        public decimal CalcularPolenPorHora(string formato, bool? estado, int? incidentes, IColmenaRepository _colmenaRepository)
        {
            
            List<Colmena.Library.entities.Colmena> colmenas = _colmenaRepository.ObtenerColmenas();
            decimal polenTotal = 0m; // inicializamos en 0m para indicar que es decimal
            long tiempoTotal = 0;
            int abejasContadas = 0;

            foreach (Colmena.Library.entities.Colmena colmena in colmenas)
            {
                foreach (Abeja abeja in colmena.Abejas)
                {
                    if ((estado == null || abeja.Estado == estado.Value) &&
                        (incidentes == null || abeja.Incidentes == incidentes.Value))
                    {
                        polenTotal += Convert.ToDecimal(abeja.Recoleccion); // convertimos a decimal
                        tiempoTotal += abeja.Tiempo;
                        abejasContadas++;
                    }
                }
            }

            decimal polenPorHora = polenTotal * 3600 / tiempoTotal;
            return Decimal.Round(polenPorHora, 2);
        }
    }
}
