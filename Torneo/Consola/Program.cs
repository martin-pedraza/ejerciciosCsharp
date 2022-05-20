using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Superliga");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            EquipoFutbol ef1 = new EquipoFutbol("Chacarita", DateTime.Parse("10/10/1995"));
            EquipoFutbol ef2 = new EquipoFutbol("Boedo", DateTime.Parse("01/10/1905"));
            EquipoFutbol ef3 = new EquipoFutbol("Barracas", DateTime.Parse("7/11/1875"));

            EquipoBasquet eb1 = new EquipoBasquet("Spurs", DateTime.Parse("05/12/1923"));
            EquipoBasquet eb2 = new EquipoBasquet("Chicago", DateTime.Parse("05/1/1935"));
            EquipoBasquet eb3 = new EquipoBasquet("Miami", DateTime.Parse("18/4/1959"));

            torneoFutbol += ef1;
            torneoFutbol += ef2;
            torneoFutbol += ef3;
            torneoFutbol += eb1;
            torneoFutbol += eb2;
            torneoFutbol += eb3;

            torneoBasquet += ef1;
            torneoBasquet += ef3;
            torneoBasquet += ef2;
            torneoBasquet += eb1;
            torneoBasquet += eb2;
            torneoBasquet += eb3;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            
        }
    }
}
