using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }
        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.Nombre = nombre;
            this.FechaCreacion = fechaCreacion;
        }
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public abstract string Ficha();
    }
}
