using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float PromedioGoles
        {
            get { return (float)this.totalGoles / this.partidosJugados; }
        }
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        public string MostrarDatos()
        {
            return $"Nombre: {this.nombre}, DNI: {this.dni}, Partidos: {this.partidosJugados}, Goles: {this.totalGoles}, Promedio de gol: {this.PromedioGoles}";
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
