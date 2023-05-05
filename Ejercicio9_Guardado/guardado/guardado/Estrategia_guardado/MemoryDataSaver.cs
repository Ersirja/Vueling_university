using guardado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guardado.Estrategia_guardado
{
    public class MemoryDataSaver : IDataSaver
    {
        private string _savedData;

        public void SaveData(string data)
        {
            // Lógica para guardar datos en memoria
            _savedData = data;
        }
    }
}
