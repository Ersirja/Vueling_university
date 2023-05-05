using guardado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guardado.Estrategia_guardado
{
    public class NetworkDataSaver : IDataSaver
    {
        private string _url; // Agregar una variable de instancia para almacenar la URL de destino

        // Constructor que toma la URL de destino como argumento
        public NetworkDataSaver(string url)
        {
            _url = url;
        }
        public void SaveData(string data)
        {            
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(data);
                var response = httpClient.PostAsync("https://ejemplo.com/guardar", content).Result;

                if (!response.IsSuccessStatusCode)
                {
                    // Manejo de errores en caso de que la respuesta no sea exitosa
                    Console.WriteLine($"Error al enviar los datos. Código de respuesta: {response.StatusCode}");
                    
                }
            }
        }
    }
}
