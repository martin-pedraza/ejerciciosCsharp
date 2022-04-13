using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        public Moto(short cilindrada, short cantidadRuedas, short cantidadPuertas, Colores color) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.Cilindrada = cilindrada;
        }
        public string Mostrar()
        {
            return $"{this.GetType().Name}\n{base.MostrarInfo()}, Cilindrada:{this.Cilindrada}\n";
        }
    }
}
