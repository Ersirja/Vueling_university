using naves.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naves.Factories
{
    public class NaveDeLujoFactory
    {
        public INaveDeLujo CrearNaveDeLujo(string tipoNave)
        {
            switch (tipoNave)
            {
                case "Tipo1":
                    return new NaveDeLujoTipo1();
                case "Tipo2":
                    return new NaveDeLujoTipo2();
                case "Tipo3":
                    return new NaveDeLujoTipo3();
                default:
                    throw new ArgumentException("Tipo de nave de lujo inválido");
            }
        }
    }
}
