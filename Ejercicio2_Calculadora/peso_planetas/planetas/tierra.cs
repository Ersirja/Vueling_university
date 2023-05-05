using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_planetas.planetas
{
    class tierra
    {
        public static double gravedad = 9.81; // gravedad en m/s^2

        public static void CalculateWeight(double weight)
        {
            double result = weight * gravedad;
            Console.WriteLine($"peso en el planeta tierra: {result} N");
        }
    }
}
