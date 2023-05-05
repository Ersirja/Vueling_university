using naves.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naves.Factories
{
    public class NaveTitanFactory
    {
        public INave CrearNaveTitan(string tipoNave)
        {
            switch (tipoNave)
            {
                case "Tipo1":
                    return new NaveTitanTipo1();
                case "Tipo2":
                    return new NaveTitanTipo2();
                case "Tipo3":
                    return new NaveTitanTipo3();
                default:
                    throw new ArgumentException("Tipo de nave Titan no válido.");
            }
        }
    }
}
