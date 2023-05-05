using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using naves.Interfaces;
using naves.Models;



namespace naves.Factories
{
    public class NaveFactory
    {
        private static bool naveTitanUsada = false; // Variable para verificar si la nave titán ha sido usada

        // Método para crear una nave de combate
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

        // Método para crear una nave comercial
        public static INaveComercial CrearNaveComercial(string modelo)
        {
            switch (modelo)
            {
                case "Aglunta":
                    return new Models.AgluntaNaveComercial();
                case "Serpent":
                    return new Models.SerpentNaveComercial();
                case "Tennak":
                    return new Models.TennakNaveComercial();
                default:
                    throw new ArgumentException("Modelo de nave comercial no válido: " + modelo);
            }
        }

        // Método para crear una nave de lujo
        public static INaveDeLujo CrearNaveDeLujo(string opcion)
        {
            switch (opcion)
            {
                case "Construccion en Platino":
                    return new Models.NaveDeLujoPlatino();
                case "Construccion en Oro":
                    return new Models.NaveDeLujoOro();
                case "Construccion en Uranio":
                    return new Models.NaveDeLujoUranio();
                default:
                    throw new ArgumentException("Opción de construcción de nave de lujo no válida: " + opcion);
            }
        }

        // Método para crear una nave titán
        public static Models.NaveTitan CrearNaveTitan(string modelo)
        {
            if (naveTitanUsada)
            {
                throw new InvalidOperationException("La nave titán solo se puede usar una vez.");
            }

            switch (modelo)
            {
                case "Titan1":
                    naveTitanUsada = true;
                    return new Models.NaveTitan1();
                case "Titan2":
                    naveTitanUsada = true;
                    return new Models.NaveTitan2();
                case "Titan3":
                    naveTitanUsada = true;
                    return new Models.NaveTitan3();
                default:
                    throw new ArgumentException("Modelo de nave titán no válido: " + modelo);
            }
        }
    }
}

