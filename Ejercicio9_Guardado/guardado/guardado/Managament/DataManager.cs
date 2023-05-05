using guardado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using guardado.Interfaces;


namespace guardado.Managament
{
    public class DataManager
    {
        private IDataSaver _dataSaver;

        public DataManager(IDataSaver dataSaver)
        {
            _dataSaver = dataSaver;
        }

        public void SaveData(string data)
        {
            _dataSaver.SaveData(data);
        }
    }

}
