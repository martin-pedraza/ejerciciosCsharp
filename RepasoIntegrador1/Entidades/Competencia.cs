using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        public int CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public List<Equipo> Equipos
        {
            get { return this.equipos; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        private Competencia(string nombre)
        {
            this.Nombre = nombre;
            this.CantidadCompetidores = 5;
        }
        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.Nombre = nombre;
            this.CantidadCompetidores = cantidadCompetidores;
        }
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }
        public static bool operator ==(Competencia c, Equipo e)
        {
            foreach (Equipo item in c.equipos)
            {
                if(item == e)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, Equipo e)
        {
            return !(c == e);
        }
        public static Competencia operator +(Competencia c, Equipo e)
        {
            if (c !=e && c.CantidadCompetidores >= c.equipos.Count)
            {
                c.equipos.Add(e);
            }
            return c;
        }
        public static string MostrarTorneo(Competencia c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia: {c.nombre}");
            sb.AppendLine($"Competidores: {c.equipos.Count}/{c.CantidadCompetidores}");
            sb.AppendLine("--------------------");
            foreach (Equipo item in c.equipos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
