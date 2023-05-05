using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using naves.Factories;
using naves.Interfaces;


namespace naves
{
    namespace NavesApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Crear una fábrica de naves de combate
                NaveFactory naveDeCombateFactory = new NaveDeCombateFactory();
                INaveDeCombate naveDeCombate = naveDeCombateFactory.CrearNaveDeCombate("Xenoh");
                naveDeCombate.MostrarCaracteristicas();

                // Crear una fábrica de naves comerciales
                NaveFactory naveComercialFactory = new NaveComercialFactory();
                INaveComercial naveComercial = naveComercialFactory.CrearNaveComercial("Aglunta");
                naveComercial.MostrarCaracteristicas();

                // Crear una fábrica de naves de lujo
                NaveFactory naveDeLujoFactory = new NaveDeLujoFactory();
                INaveDeLujo naveDeLujo = naveDeLujoFactory.CrearNaveDeLujo("Construccion en Oro");
                naveDeLujo.MostrarCaracteristicas();

                // Crear la nave Titan
                NaveFactory naveTitanFactory = new NaveTitanFactory();
                INave naveTitan = naveTitanFactory.CrearNave();
                naveTitan.MostrarCaracteristicas();

                Console.ReadLine();
            }
        }
    }

}
