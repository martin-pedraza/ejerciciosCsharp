using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;

        public EquipoFutbol(string nombre) : base(nombre)
        {
            this.jugadoresEstrellas = false;
        }
        public EquipoFutbol(string nombre, bool jugadoresEstrellas) : base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }
        public override int GetDificultad()
        {
            if (this.jugadoresEstrellas)
            {
                return 2 * new Random().Next(7, 10);
            }
            return new Random().Next(7, 10);
        }
        protected new string MostrarDatos()
        {
            return $"Futbol - {this.nombre}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
