using guardado.Estrategia_guardado;
using guardado.Interfaces;
using System;

using guardado.Managament;
class Program
{
    static void Main()
    {
       

        string url = "https://ejemplo.com/guardar"; 
        IDataSaver dataSaver = new NetworkDataSaver(url);

        
        string data = "Datos a guardar";
        dataSaver.SaveData(data);

        

        dataSaver = new FileDataSaver();
        dataSaver.SaveData(data);

        dataSaver = new MemoryDataSaver();
        dataSaver.SaveData(data);

        dataSaver = new ConsoleDataSaver();
        dataSaver.SaveData(data);

      
        Console.WriteLine("Presione Enter para salir...");
        Console.ReadLine();
    }
}
