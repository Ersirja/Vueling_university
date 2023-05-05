using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using naves.Interfaces;
using naves.Factories;

namespace naves.Interfaces
{
    
        public interface INaveComercial : INave
        {
            // Propiedades específicas de una nave comercial
            string NombreCompania { get; set; }
            string Pasajeros { get; set; }
            
        }
    

}
