using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Canal_EcoExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, res;
            //primera y segunda variable para almacenar memoria, res para hacer operaciones
            int opt;
            //guarda las opciones del usuario
            do
            {
                
                Console.WriteLine("Hola, Bienvendio a la calculadora de Jan Reig");
                Console.WriteLine("Seleccione la opción");
                Console.WriteLine("1, Sumar");
                Console.WriteLine("2, Restar");
                Console.WriteLine("3, Multiplicar");
                Console.WriteLine("4, Dividir");
                Console.WriteLine("5, Salir");
                //lo que va a leer el usuario
                opt = int.Parse(Console.ReadLine());
                //para leer la operacion

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Opción Sumar");
                        Console.WriteLine("Coloque el primer numero");
                        v1 = Convert.ToDouble(Console.ReadLine());
                        //primera variable que va a recibir
                        Console.WriteLine("Coloque el segundo numero");
                        v2 = Convert.ToDouble(Console.ReadLine());
                        //segunda variable que va a recibir
                        res= v1 + v2;
                        Console.WriteLine("El resultado de la suma es : " + (res));
                        break;
                    case 2:
                        Console.WriteLine("Opción Restar");
                        Console.WriteLine("Coloque el primer numero");
                        v1 = Convert.ToDouble(Console.ReadLine());
                        //primera variable que va a recibir
                        Console.WriteLine("Coloque el segundo numero");
                        v2 = Convert.ToDouble(Console.ReadLine());
                        //segunda variable que va a recibir
                        res = v1 - v2;
                        Console.WriteLine("El resultado de la resta es : " + (res));
                        break;
                    case 3:
                        Console.WriteLine("Opción multiplicar");
                        Console.WriteLine("Coloque el primer numero");
                        v1 = Convert.ToDouble(Console.ReadLine());
                        //primera variable que va a recibir
                        Console.WriteLine("Coloque el segundo numero");
                        v2 = Convert.ToDouble(Console.ReadLine());
                        //segunda variable que va a recibir
                        res = v1 * v2;
                        Console.WriteLine("El resultado de la multiplicacion es : " + (res));
                        break;
                    case 4:
                        Console.WriteLine("Opción dividir");
                        Console.WriteLine("Coloque el primer numero");
                        v1 = Convert.ToDouble(Console.ReadLine());
                        //primera variable que va a recibir
                        Console.WriteLine("Coloque el segundo numero");
                        v2 = Convert.ToDouble(Console.ReadLine());
                        //segunda variable que va a recibir
                        res = v1 / v2;
                        Console.WriteLine("El resultado de la división es : " + (res));
                        break;



                }
            

            } while ((opt>0)&&(opt<=4)); 
            //si ponemos mas de 4 sales
        
        
        
        }

    }
}
