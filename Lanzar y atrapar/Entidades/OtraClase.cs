using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MetodoOtraClase()
        {
            try
            {
                new MiClase(0);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Mi excepcion", ex);
            }
        }
    }
}
