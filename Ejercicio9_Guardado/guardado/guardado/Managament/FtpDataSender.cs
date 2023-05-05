using guardado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace guardado.Managament
{
    public class FtpDataSender : IDataSender
    {
        
        public void SendData(string data)
        {
            // Lógica para enviar datos a través de FTP
            // Implementa la lógica para enviar datos a un servidor FTP

            // Ejemplo de implementación utilizando la clase WebClient de .NET
            using (var webClient = new WebClient())
            {
                // Configurar las credenciales de FTP
                webClient.Credentials = new NetworkCredential("usuario", "contraseña");

                // Convertir los datos a bytes
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);

                // Especificar la URL del servidor FTP y el nombre del archivo a crear
                string ftpUrl = "ftp://ejemplo.com/nombre_archivo.txt";

                try
                {
                    // Enviar los datos a través de FTP
                    webClient.UploadData(ftpUrl, "STOR", dataBytes);
                    Console.WriteLine("Datos enviados exitosamente a través de FTP.");
                }
                catch (WebException ex)
                {
                    // Manejo de errores en caso de una excepción en la conexión FTP
                    Console.WriteLine($"Error al enviar los datos a través de FTP: {ex.Message}");
                    // Otras acciones de manejo de errores, como registrar el error en un log, notificar a un administrador, etc.
                }
            }
        }
    }

}
