using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public double GetNumero()
        {
            return this.numero;
        }
        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return new NumeroDecimal(Conversor.ConvertirBinarioADecimal(numeroBinario.GetNumero()));
        }
        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static double operator +(NumeroDecimal nD, NumeroBinario nb)
        {
            return nD.GetNumero() + Conversor.ConvertirBinarioADecimal(nb.GetNumero());
        }
        public static double operator -(NumeroDecimal nD, NumeroBinario nb)
        {
            return nD.GetNumero() - Conversor.ConvertirBinarioADecimal(nb.GetNumero());
        }
        public static bool operator ==(NumeroDecimal nD, NumeroBinario nb)
        {
            return nD.GetNumero() == Conversor.ConvertirBinarioADecimal(nb.GetNumero());
        }
        public static bool operator !=(NumeroDecimal nD, NumeroBinario nb)
        {
            return !(nD == nb);
        }
    }
}
