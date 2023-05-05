using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reino_cinrel.gobernantes
{
    class Abuelo : Gobernante
    {
        public override void Gobernar()
        {
            Console.WriteLine($"{Nombre} está gobernando de una manera diferente y no comparte los métodos del padre.");
        }
    }
}
