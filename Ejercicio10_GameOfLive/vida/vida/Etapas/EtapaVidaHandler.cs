using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vida.Clases;

namespace vida.Etapas
{
    public abstract class EtapaVidaHandler
    {
        protected EtapaVidaHandler _siguiente;

        public void SetSiguiente(EtapaVidaHandler siguiente)
        {
            _siguiente = siguiente;
        }

        public abstract void Manejar(Persona persona);
    }
}
