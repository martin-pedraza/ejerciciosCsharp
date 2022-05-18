using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, MotoCross };
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }
        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public VehiculoDeCarrera this[int i]
        {
            get { return this.competidores[i]; }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>(this.cantidadCompetidores);
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            try
            {
                if (c.competidores.Count() < c.cantidadCompetidores && c != a)
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.CantidadVueltas;
                    a.CantidadCombustible = (short)new Random().Next(15, 100);
                    return true;
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Operator +", ex);
            }
            return false;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if ((c.Tipo == Competencia.TipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) || (c.Tipo == Competencia.TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross)))
            {
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (item == a)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Operator ==");
            }
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Vueltas: {this.CantidadVueltas}, Competidores: {this.CantidadCompetidores}, Tipo: {this.Tipo}");
            foreach (VehiculoDeCarrera item in this.competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}
