using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Circulo : Figura
    {
        private double radio;
        public Circulo(double radio)
        {
            this.Radio = radio;
        }
        public double Radio
        {
            get { return this.radio; }
            set { this.radio = value; }
        }
        public override string Dibujar()
        {
            return "Dibujando círculo...";
        }
        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }
        public override double CalcularPerimetro()
        {
            return Math.PI * (2 * this.Radio);
        }
    }
}
