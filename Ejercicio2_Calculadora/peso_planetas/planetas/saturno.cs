using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_planetas.planetas
{
    class saturno
    {
        public static double gravedad = 10.44; // gravedad en m/s^2

        public static void CalculateWeight(double weight)
        {
            double result = weight * gravedad;
            Console.WriteLine($"peso en el planeta saturno: {result} N");
        }
    }
}
