using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;
        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $" Cilindrada: {this.Cilindrada}";
        }
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
            this.Cilindrada = 0;
        }
        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.Cilindrada == a2.Cilindrada;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
