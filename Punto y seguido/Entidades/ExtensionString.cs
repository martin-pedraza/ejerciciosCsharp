using System;

namespace Entidades
{
    public static class ExtensionString
    {
        public static int ContarSignosDePuntuacion(this String s)
        {
            int contador = 0;
            foreach (char c in s)
            {
                if (c == '.' || c == ',' || c == ';')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
