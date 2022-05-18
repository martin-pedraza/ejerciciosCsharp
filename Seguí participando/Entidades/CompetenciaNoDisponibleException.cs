using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string message, string clase, string metodo) : this(message, clase, metodo, null)
        {
        }

        public CompetenciaNoDisponibleException(string message, string clase, string metodo, Exception innerException) : base(message, innerException)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

        public string NombreClase { get { return this.nombreClase; } }
        public string NombreMetodo { get { return this.nombreMetodo; } }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine(this.Message);
            sb.AppendLine($"{this.InnerException}\t");
            return sb.ToString();
        }
    }
}
