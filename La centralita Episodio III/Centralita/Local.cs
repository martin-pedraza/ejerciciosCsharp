using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo) : base (duracion, destino, origen)
        {
            this.costo = costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}Costo llamada: {this.CostoLlamada}");
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
