using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using naves.Models;
using naves.Interfaces;

using naves.Models.NaveComercial;

namespace naves.Factories
{
    public class NaveComercialFactory
    {
        public INaveComercial CrearNaveComercial(string tipoNave)
        {
            switch (tipoNave)
            {
                case "Tipo1":
                    return new NaveComercialTipo1();
                case "Tipo2":
                    return new NaveComercialTipo2();
                case "Tipo3":
                    return new NaveComercialTipo3();
                default:
                    throw new ArgumentException("Tipo de nave comercial inválido");
            }
        }
    }
}
