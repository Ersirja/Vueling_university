
using naves.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace naves.Models
{
    public class NaveDeLujo : INaveDeLujo

    {

        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public int Velocidad { get; set; }
        // Propiedades de una nave de lujo

        public int NumHabitaciones { get; set; }
        public string TipoEntretenimiento { get; set; }

    }

}
