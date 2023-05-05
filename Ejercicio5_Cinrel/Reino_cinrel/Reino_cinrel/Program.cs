
using Reino_cinrel.gobernantes;


using Reino_cinrel.reino_cinrel;
class Program
{   
    static void Main(string[] args)
    {
        ReinoCinrel reino = new();

        
        Hijo[] hijos = new Hijo[]
        {
            new Hijo { Nombre = "I Quinto" },
            new Hijo { Nombre = "I Septimo" },
            new Hijo { Nombre = "I Noveno" }
        };
        reino.EstablecerHijos(hijos);

        reino.SimularGobierno();
    }
}