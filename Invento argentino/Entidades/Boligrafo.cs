using System;

namespace Entidades
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if (this.tinta >= 0 && this.tinta <= cantidadTintaMaxima)
            {
                if ((this.tinta + tinta) < 0)
                {
                    this.tinta = 0;
                }
                else if ((this.tinta + tinta) > cantidadTintaMaxima)
                {
                    this.tinta = cantidadTintaMaxima;
                }
                else
                {
                    this.tinta += tinta;
                }
            }
        }
        public void Recargar()
        {
            this.SetTinta((short)(cantidadTintaMaxima - this.tinta));
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = String.Empty;
            int contador = gasto;
            for (int i = 0; i < this.tinta; i++)
            {
                dibujo += "*";
                contador--;
                if (contador == 0)
                {
                    break;
                }
            }
            this.SetTinta((short)-(gasto));
            return true;
        }
    }
}
