using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_planetas.planetas
{
    class neptuno
    {
        public static double gravedad = 11.15; // gravedad en m/s^2

        public static void CalculateWeight(double weight)
        {
            double result = weight * gravedad;
            Console.WriteLine($"peso en el planeta neptuno: {result} N");
        }
    }
}
