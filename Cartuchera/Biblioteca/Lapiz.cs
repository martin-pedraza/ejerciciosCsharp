using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set => throw new NotImplementedException();
        }
        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                ((IAcciones)this).UnidadesDeEscritura -= 0.1f;
            }
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Tipo: {this.GetType()}, Color: {((IAcciones)this).Color}, Tinta: {((IAcciones)this).UnidadesDeEscritura.ToString()}";
        }
    }
}
