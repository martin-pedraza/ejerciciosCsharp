using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                return this.CalcularPartido(this.equipos[random.Next(0, equipos.Count)], this.equipos[random.Next(0, equipos.Count)]);
            }
        }
        public static bool operator ==(Torneo<T> t, Equipo e)
        {
            foreach (var item in t.equipos)
            {
                if (item == e)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> t, Equipo e)
        {
            return !(t == e);
        }
        public static Torneo<T> operator +(Torneo<T> t, Equipo e)
        {
            if (t != e && typeof(T)==e.GetType())
            {
                t.equipos.Add((T)e);
            }
            return t;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.nombre}");
            foreach (var item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            return $"{equipo1.Nombre} {random.Next(0, 5)} - {random.Next(0, 5)} {equipo2.Nombre}";
        }
    }
}
