using System;

namespace LogicaNegocio
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(double numeroEntero)
        {
            string binario = "";
            string binarioOrdenado = "";
            while (numeroEntero > 0)
            {
                if (numeroEntero % 2 == 0)
                {
                    binario += "0";
                }
                else
                {
                    binario += "1";
                    numeroEntero--;
                }
                numeroEntero /= 2;
            }
            for (int i = 1; i <= binario.Length; i++)
            {
                binarioOrdenado += binario[^i];
            }
            return binarioOrdenado;
        }
        public static double ConvertirBinarioADecimal(string numeroEntero)
        {
            double numeroDecimal = 0;
            for (int i = 0; i < numeroEntero.Length; i++)
            {
                if (numeroEntero[i] == '1')
                {
                    numeroDecimal += Math.Pow(2, numeroEntero.Length - 1 - i);
                }
            }
            return numeroDecimal;
        }
    }
}
