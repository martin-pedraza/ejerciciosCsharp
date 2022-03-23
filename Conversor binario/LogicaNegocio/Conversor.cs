using System;

namespace LogicaNegocio
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
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
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            double numeroDecimal = 0;
            for (int i = 0; i < numeroEntero.ToString().Length; i++)
            {
                if (numeroEntero.ToString()[i] == '1')
                {
                    numeroDecimal += Math.Pow(2, numeroEntero.ToString().Length - 1 - i);
                }
            }
            return (int)numeroDecimal;
        }
    }
}
