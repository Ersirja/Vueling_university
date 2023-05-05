using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace ColmeApi.Infraestructure.Interface
{
    public interface IAbejaRepository
    {
        IEnumerable<Abeja> ObtenerAbejas();
        IEnumerable<Abeja> ObtenerAbejasPorEstado(bool estado);
        IEnumerable<Abeja> ObtenerAbejasPorIncidentes(int incidentes);
    }
}
