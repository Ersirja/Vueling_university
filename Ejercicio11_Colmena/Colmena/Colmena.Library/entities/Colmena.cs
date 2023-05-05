using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmena.Library.entities
{
    public class Colmena
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Abeja> Abejas { get; set; }
    }
}
