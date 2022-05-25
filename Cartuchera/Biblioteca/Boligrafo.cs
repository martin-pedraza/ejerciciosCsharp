using System;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }
        public ConsoleColor Color
        { 
            get {return this.colorTinta;}
            set => throw new NotImplementedException(); 
        }
        public float UnidadesDeEscritura 
        { 
            get {return this.tinta; }
            set { this.tinta = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                this.UnidadesDeEscritura -= 0.3f;
            }
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }
        public override string ToString()
        {
            return $"Tipo: {this.GetType()}, Color: {this.Color}, Tinta: {this.UnidadesDeEscritura}";
        }
    }
}
