using System;

namespace LogicaNegocio
{
    public class Calculadora
    {
        public static int Calcular(int primerOperando, int segundoOperando, string operacionMatematica)
        {
            switch (operacionMatematica)
            {
                case "+":
                    return primerOperando + segundoOperando;
                case "-":
                    return primerOperando - segundoOperando;
                case "*":
                    return primerOperando * segundoOperando;
                case "/":
                    if (Validar(segundoOperando))
                    {
                        return primerOperando / segundoOperando;
                    }
                    break;                    
            }
            return int.MinValue;
        }
        private static bool Validar(int segundoOperando)
        {
            return segundoOperando != 0;
        }
    }
}
