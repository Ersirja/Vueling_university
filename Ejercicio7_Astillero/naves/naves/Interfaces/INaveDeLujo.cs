using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using naves.Interfaces;
using naves.Factories;

namespace naves.Interfaces
{
    
        public interface INaveDeLujo : INave
        {
            // Propiedades específicas de una nave de lujo
            int NumHabitaciones { get; set; }
            string TipoEntretenimiento { get; set; }
        }
    

}
