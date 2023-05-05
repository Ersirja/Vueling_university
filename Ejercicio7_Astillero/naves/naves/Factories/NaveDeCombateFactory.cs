using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using naves.Interfaces;

namespace naves.Factories
{
    using System;
    using System.Reflection;

    public class NaveDeCombateFactory
    {
        public static INaveDeCombate CrearNaveDeCombate(string modelo)
        {
            switch (modelo)
            {
                case "Xenoh":
                    return new Models.XenohNaveDeCombate();
                case "Turuk":
                    return new Models.TurukNaveDeCombate();
                case "Kamroz":
                    return new Models.KamrozNaveDeCombate();
                default:
                    throw new ArgumentException("Modelo de nave de combate no válido: " + modelo);
            }
        }
    
    }

}
