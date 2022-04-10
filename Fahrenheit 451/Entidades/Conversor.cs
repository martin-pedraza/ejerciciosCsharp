using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static double ConvertirCelsiusFahrenheit(Celsius c)
        {
            return ((c.GetTemp() * (9 / 5)) + 32);
        }
        public static double ConvertirFahrenheitCelsius(Fahrenheit f)
        {
            return (f.GetTemp() - 32) * (5 / 9);
        }
        public static double ConvertirKelvinFahrenheir(Kelvin k)
        {
            return (k.GetTemp() * (9 / 5)) - 459.67;
        }
        public static double ConvertirFahrenheirKelvin(Fahrenheit f)
        {
            return (f.GetTemp() + 459.67) * (5 / 9);
        }
    }
}
