using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;

namespace ColmeApi.Infraestructure.Interface
{
    public class AbejaRepository : IAbejaRepository
    {
        private readonly List<Abeja> _abejas;

        public AbejaRepository(IEnumerable<Abeja> abejas)
        {
            _abejas = new List<Abeja>(abejas);
        }

        public IEnumerable<Abeja> ObtenerAbejas()
        {
            return _abejas;
        }

        public IEnumerable<Abeja> ObtenerAbejasPorEstado(bool estado)
        {
            return _abejas.Where(a => a.Estado == estado);
        }

        public IEnumerable<Abeja> ObtenerAbejasPorIncidentes(int incidentes)
        {
            return _abejas.Where(a => a.Incidentes == incidentes);
        }
    }
}
