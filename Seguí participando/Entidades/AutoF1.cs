using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
            this.CaballosDeFuerza = 0;
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $", Caballos de Fuerza: {this.CaballosDeFuerza}";
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
