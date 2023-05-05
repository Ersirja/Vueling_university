using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reino_cinrel.gobernantes
{
    class Hijo : Gobernante
    {
        public Rey Padre { get; set; }

        public override void Gobernar()
        {
            Console.WriteLine($"{Nombre} está gobernando siguiendo los métodos de su padre, pero de manera diferente.");
        }
    }
}
