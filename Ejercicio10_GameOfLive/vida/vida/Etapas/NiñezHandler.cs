using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vida.Clases;

namespace vida.Etapas
{
    public class NiñezHandler : EtapaVidaHandler
    {
        public override void Manejar(Persona persona)
        {
            if (persona.Edad < 12)
            {
                Console.WriteLine($"{persona.Nombre} está en la etapa de Niñez.");
            }
            else if (_siguiente != null)
            {
                _siguiente.Manejar(persona);
            }
        }
    }
}
