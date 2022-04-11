﻿using System;

namespace Entidades
{
    public class Fahrenheit
    {
        private double temp;
        public Fahrenheit(double temp)
        {
            this.temp = temp;
        }
        public double GetTemp()
        {
            return this.temp;
        }
        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }
        public static implicit operator double(Fahrenheit d)
        {
            return d.GetTemp();
        }
        public static implicit operator Fahrenheit(string s)
        {
            return new Fahrenheit(double.Parse(s));
        }
        public static implicit operator string(Fahrenheit t)
        {
            return t.GetTemp().ToString();
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius(Conversor.ConvertirFahrenheitCelsius(f));
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin(Conversor.ConvertirFahrenheitKelvin(f));
        }
        public static double operator +(Fahrenheit f, Celsius c)
        {
            return f.GetTemp() + Conversor.ConvertirCelsiusFahrenheit(c);
        }
        public static double operator +(Fahrenheit f, Kelvin k)
        {
            return f.GetTemp() + Conversor.ConvertirKelvinFahrenheit(k);
        }
        public static double operator -(Fahrenheit f, Celsius c)
        {
            return f.GetTemp() - Conversor.ConvertirCelsiusFahrenheit(c);
        }
        public static double operator -(Fahrenheit f, Kelvin k)
        {
            return f.GetTemp() - Conversor.ConvertirKelvinFahrenheit(k);
        }
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.GetTemp() == Conversor.ConvertirCelsiusFahrenheit(c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.GetTemp() == Conversor.ConvertirKelvinFahrenheit(k);
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
    }
}
