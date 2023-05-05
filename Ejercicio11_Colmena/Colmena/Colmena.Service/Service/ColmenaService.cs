using Colmena.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Service.Service
{
    public class ColmenaService : IColmenaService
    {
        private readonly List<Abeja> _abejas;

        public ColmenaService(List<Abeja> abejas)
        {
            _abejas = abejas;
        }

        public List<Abeja> FiltrarPorEstado(bool estado)
        {
            return _abejas.Where(x => x.Estado == estado).ToList();
        }

        public List<Abeja> FiltrarPorIncidentes(int incidentes)
        {
            return _abejas.Where(x => x.Incidentes == incidentes).ToList();
        }
    }
}
