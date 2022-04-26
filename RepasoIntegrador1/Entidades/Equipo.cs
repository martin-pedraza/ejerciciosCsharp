using System;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;
        public string Nombre
        {
            get { return this.nombre; }
        }
        public int PE
        {
            get { return this.partidosEmpatados; }
            set { this.partidosEmpatados = value; }
        }
        public int PG
        {
            get { return this.partidosGanados; }
            set { this.partidosGanados = value; }
        }
        public int PJ
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public int PP
        {
            get { return this.partidosPerdidos; }
            set { this.partidosPerdidos = value; }
        }
        public int Puntuacion
        {
            get { return this.puntuacion; }
            set { this.puntuacion = value; }
        }
        public string Tipo
        {
            get { return this.GetType().Name; }
        }
        protected Equipo(string nombre)
        {
            this.nombre = nombre;
            this.Puntuacion = 0;
        }
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.Equals(e2) && e1.nombre == e2.nombre;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        protected string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            return sb.ToString();
        }
        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA.Equals(equipoB))
            {
                int dificultadA = equipoA.GetDificultad();
                int dificultadB = equipoB.GetDificultad();
                if (dificultadA > dificultadB)
                {
                    equipoA.PG++;
                    equipoA.Puntuacion += 3;
                    equipoB.PP++;
                }
                else if (dificultadA < dificultadB)
                {
                    equipoB.PG++;
                    equipoB.Puntuacion += 3;
                    equipoA.PP++;
                }
                else if (dificultadA == dificultadB)
                {
                    equipoA.PE++;
                    equipoA.Puntuacion += 1;
                    equipoB.PE++;
                    equipoB.Puntuacion += 1;
                }
                equipoA.PJ++;
                equipoB.PJ++;
                return true;
            }
            return false;
        }
        public abstract int GetDificultad();
    }
}
