using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Estaciones.Verano.ObtenerPlacaCronicaTV());
            Console.WriteLine(Estaciones.Primavera.ObtenerPlacaCronicaTV());
            Console.WriteLine(Estaciones.Invierno.ObtenerPlacaCronicaTV());
            Console.WriteLine(Estaciones.Otonio.ObtenerPlacaCronicaTV());
        }
    }
}
