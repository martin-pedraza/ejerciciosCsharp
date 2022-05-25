using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> elementos;
        public CartucheraMultiuso()
        {
            this.elementos = new List<IAcciones>();
        }
        public bool RecorrerElemento()
        {
            bool retorno = true;
            foreach (IAcciones e in this.elementos)
            {
                e.UnidadesDeEscritura -= 1;
                if (e.UnidadesDeEscritura <= 0)
                {
                    retorno = false;
                    e.UnidadesDeEscritura += 20;
                }
            }
            return retorno;
        }
    }
}
