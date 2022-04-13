using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>(this.cantidadCompetidores);
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count() < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)new Random().Next(15, 100);
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Vueltas: {this.cantidadVueltas}, Competidores: {this.cantidadCompetidores}");
            foreach (AutoF1 item in this.competidores)
            {
                sb.AppendLine(item.MostrarDato());
            }
            return sb.ToString();
        }
    }
}
