using System;
using System.Text;
using Entidades;

namespace Entidades
{
    public enum TipoLLamada { Local, Provincial, Todas };
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public abstract float CostoLlamada { get; }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.Duracion.ToString()}");
            sb.AppendLine($"Origen: {this.NroOrigen}");
            sb.AppendLine($"Destino: {this.NroDestino}");
            return sb.ToString();
        }
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.GetType() == l2.GetType() && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)llamada2.Duracion - (int)llamada1.Duracion;
        }
    }
}
