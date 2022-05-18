using System;

namespace Entidades
{
    public static class ExtensionInt64
    {
        public static int ContarCantidadDeDigitos(this Int64 i)
        {
            int contador = 0;
            while (i > 0)
            {
                contador++;
                i /= 10;
                
            } 
            return contador;
        }
    }
}
