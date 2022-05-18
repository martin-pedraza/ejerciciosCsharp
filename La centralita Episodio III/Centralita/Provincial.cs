using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Franjas { Franja_1, Franja_2, Franja_3 }
    public class Provincial : Llamada
    {
        protected Franjas franjaHoraria;
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        private float CalcularCosto()
        {
            switch (franjaHoraria)
            {
                case Franjas.Franja_1:
                    return base.Duracion * 0.99f;
                case Franjas.Franja_2:
                    return base.Duracion * 1.25f;
                default:
                    return base.Duracion * 0.66f;
            }
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo llamada: {this.CostoLlamada}");
            sb.AppendLine($"Franjas: {this.franjaHoraria}");
            return sb.ToString();
        }
        public Provincial(Franjas miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franjas miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
