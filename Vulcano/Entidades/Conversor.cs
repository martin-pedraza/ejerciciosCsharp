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
            return (c.GetTemp() * 1.8) + 32;
        }
        public static double ConvertirFahrenheitCelsius(Fahrenheit f)
        {
            return (f.GetTemp() - 32) / 1.8;
        }
        public static double ConvertirKelvinFahrenheit(Kelvin k)
        {
            return ((k.GetTemp() - 273.15) * 1.8) + 32;
        }
        public static double ConvertirFahrenheitKelvin(Fahrenheit f)
        {
            return ((f.GetTemp() - 32) / 1.8) + 273.15;
        }
        public static double ConvertirCelsiusKelvin(Celsius c)
        {
            return c.GetTemp() + 273.15;
        }
        public static double ConvertirKelvinCelsius(Kelvin k)
        {
            return k.GetTemp() - 273.15;
        }
    }
}
