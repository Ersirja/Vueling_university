using cuerpo_humano.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuerpo_humano.atributos
{
    public abstract class ExtremidadDecorator : IExtremidad
    {
        protected IExtremidad _extremidad;

        public ExtremidadDecorator(IExtremidad extremidad)
        {
            _extremidad = extremidad;
        }

        public virtual void Mover()
        {
            _extremidad.Mover();
        }
    }
}
