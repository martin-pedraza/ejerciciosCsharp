using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>(this.cantidadDeJugadores);
        }
        public Equipo(short cantidadDeJugadores, string nombre) :this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                {
                    return false;
                }
            }
            e.jugadores.Add(j);
            return true;
        }
    }
}
