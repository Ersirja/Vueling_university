using Reino_cinrel.gobernantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;










using Reino_cinrel.gobernantes;



namespace Reino_cinrel.reino_cinrel
{
    class ReinoCinrel
    {
        private readonly Rey rey;
        private Hijo[] hijos;
        private readonly Abuelo abuelo;

        public ReinoCinrel()
        {
            rey = new Rey { Nombre = "I Tercero" };
            abuelo = new Abuelo { Nombre = "Cenrelon" };
        }

        public void EstablecerHijos(Hijo[] hijos)
        {
            rey.EstablecerHijos(hijos);
            this.hijos = hijos;
        }

        public void SimularGobierno()
        {
            for (int i = 0; i < hijos.Length; i++)
            {
                Console.WriteLine($"Mes {i + 1}: {hijos[i].Nombre} asume el gobierno.");
                hijos[i].Gobernar();
            }

            Console.WriteLine("Último mes: El abuelo Cenrelon se levanta contra los nietos para reclamar el reinado.");
            abuelo.Gobernar();
        }
    }


}
