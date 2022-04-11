using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1 / 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double ctzRespectoDolar) : this(cantidad)
        {
            Euro.cotzRespectoDolar = ctzRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            cotzRespectoDolar = cotizacion;
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * (1/Euro.GetCotizacion()));
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)(Dolar)e;
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static implicit operator Euro(string s)
        {
            return new Euro(double.Parse(s));
        }
        public static implicit operator string(Euro n)
        {
            return n.GetCantidad().ToString();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return e.GetCantidad() != ((Euro)d).GetCantidad();
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return !(d != e);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return e1.GetCantidad() != e2.GetCantidad();
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return !(e1 != e2);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Dolar)p).GetCantidad());
        }
    }
}
