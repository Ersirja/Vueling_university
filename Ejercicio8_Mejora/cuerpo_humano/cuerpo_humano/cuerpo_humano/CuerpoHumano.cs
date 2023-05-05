using cuerpo_humano.atributos;
using cuerpo_humano.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuerpo_humano.cuerpo_humano
{
    public class CuerpoHumano
    {
        private IExtremidad _extremidad;

        public CuerpoHumano()
        {
            
            _extremidad = new ExtremidadBiologica();
        }

        public void ModificarExtremidadConGadget()
        {
            _extremidad = new MejoraGadget(_extremidad);
        }

        public void ModificarExtremidadConMejoraBiologica()
        {
            _extremidad = new MejoraBiologica(_extremidad);
        }

        public void MoverExtremidad()
        {
            _extremidad.Mover();
        }
    }
}
