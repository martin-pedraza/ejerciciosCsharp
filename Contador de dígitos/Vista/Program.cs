using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 n;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero:\t");
                n = Int64.Parse(Console.ReadLine());
                Console.WriteLine($"Numero de \t\t{n.ContarCantidadDeDigitos()} digitos");
            }
        }
    }
}
