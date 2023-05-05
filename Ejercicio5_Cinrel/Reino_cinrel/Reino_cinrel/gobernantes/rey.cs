using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reino_cinrel.gobernantes
{
    class Rey : Gobernante
    {
        public void EstablecerHijos(Hijo[] hijos)
        {
            Console.WriteLine($"{Nombre} establece a sus hijos como gobernantes.");
            foreach (var hijo in hijos)
            {
                hijo.Padre = this;
            }
        }
    }
}
