using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colmena.Service
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
