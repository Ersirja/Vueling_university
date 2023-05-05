using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vida.Clases;

namespace vida.Etapas
{
    public class AdultezHandler : EtapaVidaHandler
    {
        public override void Manejar(Persona persona)
        {
            if (persona.Edad >= 18)
            {
                Console.WriteLine($"{persona.Nombre} está en la etapa de Adultez.");
            }
            else if (_siguiente != null)
            {
                _siguiente.Manejar(persona);
            }
        }
    }
}
