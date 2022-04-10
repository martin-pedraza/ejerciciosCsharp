using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public string GetNumero()
        {
            return this.numero;
        }
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return new NumeroBinario(Conversor.ConvertirDecimalABinario(numeroDecimal.GetNumero()));
        }
        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return Conversor.ConvertirDecimalABinario(((NumeroDecimal)numeroBinario).GetNumero() + numeroDecimal.GetNumero());
        }
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return Conversor.ConvertirDecimalABinario(((NumeroDecimal)numeroBinario).GetNumero() - numeroDecimal.GetNumero());
        }
        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.GetNumero() == ((NumeroBinario)numeroDecimal).GetNumero();
        }
        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario==numeroDecimal);
        }
    }
}
