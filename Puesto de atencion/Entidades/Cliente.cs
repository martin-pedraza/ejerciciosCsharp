using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Numero
        {
            get { return this.numero; }
        }
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Nombre == c2.Nombre;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
