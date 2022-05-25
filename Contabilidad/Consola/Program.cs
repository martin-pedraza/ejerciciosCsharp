using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo();
            Recibo recibo2 = new Recibo(6);
            Recibo recibo3 = new Recibo(10);
            Factura factura1 = new Factura(555);
            Factura factura2 = new Factura(100);
            Factura factura3 = new Factura(156);
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += recibo2;
            contabilidad += recibo3;

            contabilidad += factura1;
            contabilidad += factura2;
            contabilidad += factura3;

            Console.WriteLine(contabilidad.Egresos);
            Console.WriteLine(contabilidad.Ingresos);
        }
    }
}
