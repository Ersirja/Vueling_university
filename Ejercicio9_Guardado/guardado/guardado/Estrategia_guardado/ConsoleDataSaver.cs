using guardado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guardado.Estrategia_guardado
{
    
    public class ConsoleDataSaver : IDataSaver
    {
        public void SaveData(string data)
        {
            // guardar datos en la consola
            Console.WriteLine("Los datos se han guardado en la consola:");
            Console.WriteLine(data);
        }
    }
}
