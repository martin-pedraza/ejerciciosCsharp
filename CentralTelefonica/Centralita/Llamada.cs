using System;
using System.Text;
using Centralita;

namespace Centralita
{
    public enum TipoLLamada { Local, Provincial, Todas };
    public class Llamada
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
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.Duracion.ToString()}");
            sb.AppendLine($"Origen: {this.NroOrigen}");
            sb.AppendLine($"Destino: {this.NroDestino}");
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)llamada2.Duracion - (int)llamada1.Duracion;
        }
    }
}
