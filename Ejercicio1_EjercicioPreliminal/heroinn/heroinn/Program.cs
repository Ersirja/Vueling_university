using System;
using System.Collections.Generic;

class Heroe
{
    public string nombre;
    public int nivel;
    public bool contratado;
    public List<string> habilidades = new List<string>();
}

class Program
{
    static List<Heroe> heroes = new List<Heroe>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("TABERNA DE CONTRATOS PARA HÉROES");
            Console.WriteLine("================================\n");

            Console.WriteLine("1. Registrar un nuevo héroe");
            Console.WriteLine("2. Mostrar todos los héroes");
            Console.WriteLine("3. Mostrar héroes contratados");
            Console.WriteLine("4. Mostrar héroes no contratados");
            Console.WriteLine("5. Ordenar héroes por nivel");
            Console.WriteLine("6. Salir\n");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarHeroe();
                    break;
                case "2":
                    MostrarHeroes(heroes);
                    break;
                case "3":
                    MostrarHeroes(heroes.FindAll(heroe => heroe.contratado));
                    break;
                case "4":
                    MostrarHeroes(heroes.FindAll(heroe => !heroe.contratado));
                    break;
                case "5":
                    OrdenarHeroesPorNivel();
                    break;
                case "6":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }

        
    }

    static void RegistrarHeroe()
    {
        Console.Clear();
        Console.WriteLine("REGISTRAR NUEVO HÉROE\n");

        Heroe heroe = new Heroe();

        Console.Write("Nombre: ");
        heroe.nombre = Console.ReadLine();

        Console.Write("Nivel: ");
        heroe.nivel = int.Parse(Console.ReadLine());

        Console.Write("Contratado (S/N): ");
        heroe.contratado = Console.ReadLine().ToUpper() == "S";

        Console.Write("Habilidades (separadas por coma): ");
        string[] habilidades = Console.ReadLine().Split(',');
        heroe.habilidades.AddRange(habilidades);

        heroes.Add(heroe);

        Console.WriteLine("\nHéroe registrado con éxito. Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void MostrarHeroes(List<Heroe> listaHeroes)
    {
        Console.Clear();
        Console.WriteLine("LISTA DE HÉROES\n");

        foreach (Heroe heroe in listaHeroes)
        {
            Console.WriteLine($"Nombre: {heroe.nombre}");
            Console.WriteLine($"Nivel: {heroe.nivel}");
            Console.WriteLine($"Contratado: {(heroe.contratado ? "Sí" : "No")}");

            if (heroe.habilidades.Count > 0)
            {
                Console.WriteLine($"Habilidades: {string.Join(", ", heroe.habilidades)}");
            }

            Console.WriteLine("");
        }

        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void OrdenarHeroesPorNivel()
    {
        heroes.Sort((heroe1, heroe2) => heroe2.nivel.CompareTo(heroe1.nivel));
        Console.WriteLine("Los héroes se han ordenado por nivel.");
        MostrarHeroes(heroes);
    }

}
