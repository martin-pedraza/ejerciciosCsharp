using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }
        public int PesoCarga
        {
            get { return this.pesoCarga; }
            set { this.pesoCarga = value; }
        }
        public Camion(short cantidadMarchas, int peso, short cantidadRuedas, short cantidadPuertas, Colores color) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.PesoCarga = peso;
        }
        public string Mostrar()
        {
            return $"{this.GetType().Name}\n{base.MostrarInfo()}\nMarchas: {this.cantidadMarchas}, Peso: {this.PesoCarga}\n";
        }
    }
}
