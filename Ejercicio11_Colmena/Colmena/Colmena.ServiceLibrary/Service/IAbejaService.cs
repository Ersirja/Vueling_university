using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Colmena.Library.entities;

namespace Colmena.ServiceLibrary
{
    public interface IAbejaService
    {
        double CalcularPolenPorHora(Abeja abeja);
    }
}
