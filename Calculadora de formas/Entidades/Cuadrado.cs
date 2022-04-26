using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuadrado : Rectangulo
    {
        private double lado;
        public Cuadrado(double lado) :base(lado, lado) { }
        public double Lado
        {
            get { return this.lado; }
            set { this.lado = value; }
        }
        public override string Dibujar()
        {
            return "Dibujando cuadrado...";
        }
    }
}
