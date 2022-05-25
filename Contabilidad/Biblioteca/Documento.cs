using System;

namespace Biblioteca
{
    public class Documento
    {
        private int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }
        public override string ToString()
        {
            return $"{this.numero}";
        }
    }
}
