using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colmena.ServiceLibrary.Service
{
    public interface IColmenaRepository
    {
        List<IColmenaRepository> ObtenerColmenas();
        void ActualizarColmena(Colmena.Library.entities.Colmena colmena);

    }
}
