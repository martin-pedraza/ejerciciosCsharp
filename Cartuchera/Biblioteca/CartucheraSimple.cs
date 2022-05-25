using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public CartucheraSimple()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }
        public bool RecorrerElementos()
        {
            bool retorno = true;
            foreach (Boligrafo e in this.boligrafos)
            {
                e.UnidadesDeEscritura -= 1;
                if (e.UnidadesDeEscritura <= 0)
                {
                    retorno = false;
                    e.UnidadesDeEscritura += 20;
                }
            }
            foreach (Lapiz e in this.lapices)
            {
                ((IAcciones)e).UnidadesDeEscritura -= 1;
                if (((IAcciones)e).UnidadesDeEscritura <= 0)
                {
                    retorno = false;
                    ((IAcciones)e).UnidadesDeEscritura += 20;
                }
            }
            return retorno;
        }
    }
}
