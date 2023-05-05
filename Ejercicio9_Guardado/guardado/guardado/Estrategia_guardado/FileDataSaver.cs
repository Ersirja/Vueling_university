using guardado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guardado.Estrategia_guardado
{
    public class FileDataSaver : IDataSaver
    {
        public void SaveData(string data)
        {
            // Lógica para guardar datos en un fichero
            File.WriteAllText("archivo.txt", data);
        }
    }
}
