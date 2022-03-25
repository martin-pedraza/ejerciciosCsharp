using System;

namespace LogicaNegocio
{
    public class Calendario
    {
        public static double CalcularDias(DateTime nacimiento)
        {
            return ((DateTime.Today - nacimiento).TotalHours) / 24;
        }
    }
}
