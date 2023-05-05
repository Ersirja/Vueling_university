using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Colmena.ServiceLibrary.Service;
using Newtonsoft.Json;
using Colmena.Library.entities;
using Colmena.ServiceLibrary.Infraestructrures;

namespace Colmena.ServiceLibrary.Infraestructrures
{
    public class ColmenaRepository : IColmenaRepository
    {

        private readonly string _rutaArchivo;

        public ColmenaRepository(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }

        public List<Colmena.Library.entities.Colmena> ObtenerColmenas()
        {
            string json = File.ReadAllText(_rutaArchivo);
            List<Colmena.Library.entities.Colmena> colmenas = JsonConvert.DeserializeObject<List<Colmena.Library.entities.Colmena>>(json);
            return colmenas;
        }

        public void ActualizarColmena(Colmena.Library.entities.Colmena colmena)
        {
            List<Colmena.Library.entities.Colmena> colmenas = ObtenerColmenas();
            int index = colmenas.FindIndex(c => c.Id == colmena.Id);
            if (index != -1)
            {
                colmenas[index] = colmena;
                string json = JsonConvert.SerializeObject(colmenas, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(_rutaArchivo, json);
            }
        }

        List<IColmenaRepository> IColmenaRepository.ObtenerColmenas()
        {
            throw new NotImplementedException();
        }
    }
}
