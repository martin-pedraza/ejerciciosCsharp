using System;
using Entidades;

namespace Vista
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otra = new OtraClase();
                otra.MetodoOtraClase();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
