using System;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }
        public int CantidadPasajeros
        {
            get { return this.cantidadPasajeros; }
            set { this.cantidadPasajeros = value; }
        }
        public Automovil(short cantidadMarchas, int cantidadPasajeros, short cantidadRuedas, short cantidadPuertas, Colores color)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadPasajeros = cantidadPasajeros;
        }
        public string Mostrar()
        {
            return $"{this.GetType().Name}\n{base.MostrarInfo()}\nMarchas: {this.cantidadMarchas}, Pasajeros: {this.cantidadPasajeros}\n";
        }
    }
}
