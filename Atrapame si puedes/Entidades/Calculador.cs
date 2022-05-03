using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculador
    {
        public static decimal Calcular(int kilometro, int litro)
        {
            try
            {
                return (decimal)kilometro / litro;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
}
