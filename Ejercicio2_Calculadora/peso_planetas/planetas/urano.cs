using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_planetas.planetas
{
    class urano
    {
        public static double gravedad = 8.87; // gravedad en m/s^2

        public static void CalculateWeight(double weight)
        {
            double result = weight * gravedad;
            Console.WriteLine($"peso en el planeta urano: {result} N");
        }
    }
}
