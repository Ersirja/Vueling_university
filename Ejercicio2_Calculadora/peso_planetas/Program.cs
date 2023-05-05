using peso_planetas.planetas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce tu peso (kg): ");
            double weight = double.Parse(Console.ReadLine());

            tierra.CalculateWeight(weight);
            mercurio.CalculateWeight(weight);
            jupiter.CalculateWeight(weight);
            marte.CalculateWeight(weight);
            venus.CalculateWeight(weight);
            saturno.CalculateWeight(weight);
            urano.CalculateWeight(weight);
            neptuno.CalculateWeight(weight);

            // Crear objetos para los demás planetas
            // y llamar a los métodos para calcular el peso en cada uno de ellos
            // ...

            Console.ReadKey();
        }
    }
}
