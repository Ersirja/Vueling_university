using vida.Clases;
using vida.Etapas;

public class Program
{
    public static void Main()
    {
        
        var niñezHandler = new NiñezHandler();
        var adolescenciaHandler = new AdolescenciaHandler();
        var adultezHandler = new AdultezHandler();

       
        niñezHandler.SetSiguiente(adolescenciaHandler);
        adolescenciaHandler.SetSiguiente(adultezHandler);
        
        
        var persona = new Persona("Jan", 25);

        
        for (int i = 0; i <= 30; i++) 
        {
            Console.WriteLine($"Año {i}:");
            persona.Edad = i;
            niñezHandler.Manejar(persona); 
            Console.WriteLine("-----------------");
        }
    }
}