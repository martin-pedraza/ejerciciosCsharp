using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalDeGoles;

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public int TotalDeGoles
        {
            get { return this.totalDeGoles; }
            set { this.totalDeGoles = value; }
        }
        public float PromedioDeGoles
        {
            get { return (float)this.TotalDeGoles / this.PartidosJugados; }
        }
        public Jugador(int dni, string nombre) :base(dni, nombre)
        {
            this.PartidosJugados = 0;
            this.TotalDeGoles = 0;
        }
        public  Jugador(int dni, string nombre, int totalDeGoles, int partidosJugados) : base(dni, nombre)
        {
            this.PartidosJugados = partidosJugados;
            this.TotalDeGoles = totalDeGoles;
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"Goles: {this.TotalDeGoles} Partidos: {this.PartidosJugados} Promedio: {this.PromedioDeGoles}";
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni && j1.Nombre == j2.Nombre;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
