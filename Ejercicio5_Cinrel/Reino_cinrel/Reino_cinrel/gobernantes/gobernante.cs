using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reino_cinrel.gobernantes
{
    public class Gobernante
    {
        public string Nombre { get; set; }

        public virtual void Gobernar()
        {
            Console.WriteLine($"{Nombre} está gobernando.");
        }
    }
}
