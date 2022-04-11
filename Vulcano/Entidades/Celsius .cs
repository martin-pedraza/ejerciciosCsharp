﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celsius
    {
        public double temp;

        public Celsius(double temp)
        {
            this.temp = temp;
        }
        public double GetTemp()
        {
            return this.temp;
        }
        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }
        public static implicit operator double(Celsius d)
        {
            return d.GetTemp();
        }
        public static implicit operator Celsius(string s)
        {
            return new Celsius(double.Parse(s));
        }
        public static implicit operator string(Celsius t)
        {
            return t.GetTemp().ToString();
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(Conversor.ConvertirCelsiusFahrenheit(c));
        }
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(Conversor.ConvertirCelsiusKelvin(c));
        }
        public static double operator +(Celsius c, Kelvin k)
        {
            return c.GetTemp() + ((Celsius)k).GetTemp();
        }
        public static double operator +(Celsius c, Fahrenheit f)
        {
            return c.GetTemp() + Conversor.ConvertirFahrenheitCelsius(f);
        }
        public static double operator -(Celsius c, Kelvin k)
        {
            return c.GetTemp() - ((Celsius)k).GetTemp();
        }
        public static double operator -(Celsius c, Fahrenheit f)
        {
            return c.GetTemp() - Conversor.ConvertirFahrenheitCelsius(f);
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.GetTemp() == ((Celsius)k).GetTemp();
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.GetTemp() == Conversor.ConvertirFahrenheitCelsius(f);
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }
    }
}
