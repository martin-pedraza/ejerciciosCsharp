using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();

            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("Relanzo dividir por cero", ex);
            }
        }
        public MiClase(int i)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Una excepcion", ex);
            }
        }
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
    }
}
