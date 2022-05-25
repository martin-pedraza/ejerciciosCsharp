using System;
using Biblioteca;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            //EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            //Console.ForegroundColor = eLapiz.color;
            //Console.WriteLine(eLapiz.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miLapiz);

            //EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            //Console.ForegroundColor = eBoligrafo.color;
            //Console.WriteLine(eBoligrafo.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miBoligrafo);

            CartucheraSimple cartucheraSimple = new CartucheraSimple();
            cartucheraSimple.boligrafos.Add(miBoligrafo);
            cartucheraSimple.lapices.Add(miLapiz);

            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();
            cartucheraMultiuso.elementos.Add(miBoligrafo);
            cartucheraMultiuso.elementos.Add(miLapiz);

            while (cartucheraSimple.RecorrerElementos() && cartucheraMultiuso.RecorrerElemento())
            {
                Console.WriteLine($"Lapiz: {((IAcciones)miLapiz).UnidadesDeEscritura}");
                Console.WriteLine($"Boligrafo: {miBoligrafo.UnidadesDeEscritura}");
            }
            //Console.WriteLine($"Lapiz: {((IAcciones)miLapiz).UnidadesDeEscritura}");
            //Console.WriteLine($"Boligrafo: {miBoligrafo.UnidadesDeEscritura}");

            Console.ReadKey();
        }
    }
}
