using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        private DirectorTecnico(string nombre) : base(nombre)
        {
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.FechaNacimiento = fechaNacimiento;
            base.Dni = new Random().Next(10000000, 99000000);
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"Nacimiento: {this.FechaNacimiento.ToString("MM/yyyy")}";
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
