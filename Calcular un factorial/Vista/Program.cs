////Consigna#
////El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

////En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.

using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
            } while (!int.TryParse(Console.ReadLine(), out numero));
            Console.WriteLine($"Factorial: {CalcularFactorial(numero)}");

        }
        public static int CalcularFactorial(int numero)
        {
            int numeroFactorial = 1;
            if (numero > 1)
            {
                for (int i = 1; i <= numero; i++)
                {
                    numeroFactorial *= i;
                }
                return numeroFactorial;
            }
            else if (numero < 0)
            {
                return int.MinValue;
            }
            return 1;
        }
    }
}
