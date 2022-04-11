using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private double temp;

        public Kelvin(double temp)
        {
            this.temp = temp;
        }
        public double GetTemp()
        {
            return this.temp;
        }
        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }
        public static implicit operator double(Kelvin d)
        {
            return d.GetTemp();
        }
        public static implicit operator Kelvin(string s)
        {
            return new Kelvin(double.Parse(s));
        }
        public static implicit operator string(Kelvin t)
        {
            return t.GetTemp().ToString();
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(Conversor.ConvertirKelvinFahrenheit(k));
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(Conversor.ConvertirKelvinCelsius(k));
        }
        public static double operator +(Kelvin k, Celsius c)
        {
            return k.GetTemp() + ((Kelvin)c).GetTemp();
        }
        public static double operator +(Kelvin k, Fahrenheit f)
        {
            return k.GetTemp() + Conversor.ConvertirFahrenheitKelvin(f);
        }
        public static double operator -(Kelvin k, Celsius c)
        {
            return k.GetTemp() - ((Kelvin)c).GetTemp();
        }
        public static double operator -(Kelvin k, Fahrenheit f)
        {
            return k.GetTemp() - Conversor.ConvertirFahrenheitKelvin(f);
        }
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.GetTemp() == ((Kelvin)c).GetTemp();
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.GetTemp() == Conversor.ConvertirFahrenheitKelvin(f);
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }
    }
}
