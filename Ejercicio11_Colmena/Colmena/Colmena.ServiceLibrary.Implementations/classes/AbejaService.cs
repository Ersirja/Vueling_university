using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colmena.ServiceLibrary.Service;
using Colmena.Library.entities;


namespace Colmena.ServiceLibrary.Implementations
{
    public class AbejaService : IAbejaService
    {
        public double CalcularPolenPorHora(Abeja abeja)
        {
            double polenPorHora = (abeja.Recoleccion / abeja.Tiempo) * 3600 / 1000000;
            return polenPorHora;
        }
    }
}
