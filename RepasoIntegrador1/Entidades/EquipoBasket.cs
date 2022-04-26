using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {
        public enum ELiga { NBA, Euroleague, ACB };
        private ELiga liga;

        public EquipoBasket(string nombre) : base(nombre)
        {
            this.liga = ELiga.NBA;
        }
        public EquipoBasket(string nombre, ELiga liga) : base(nombre)
        {
            this.liga = liga;
        }
        public override int GetDificultad()
        {
            if (this.liga == ELiga.NBA)
            {
                return new Random().Next(8, 10);
            }
            else if (this.liga == ELiga.Euroleague)
            {
                return new Random().Next(5, 10);
            }
            else
            {
                return new Random().Next(1, 7);
            }
        }
        protected new string MostrarDatos()
        {
            return $"Basket - {this.nombre}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
