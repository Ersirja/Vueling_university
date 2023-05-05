using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colmena.Library.entities;
using Colmena.ServiceLibrary.Service;
using Colmena.ServiceLibrary.Infraestructrures;


namespace Colmena.ServiceLibrary.Implementations.classes
{
    public class ColmenaService 
    {
        private readonly List<Abeja> _abejas;

        public ColmenaService(List<Abeja> abejas)
        {
            _abejas = abejas;
        }

        public List<Abeja> FiltrarPorEstado(bool estado)
        {
            return _abejas.FindAll(x => x.Estado == estado);
        }

        public List<Abeja> FiltrarPorIncidentes(int incidentes)
        {
            return _abejas.FindAll(x => x.Incidentes == incidentes);
        }
    }

    


}