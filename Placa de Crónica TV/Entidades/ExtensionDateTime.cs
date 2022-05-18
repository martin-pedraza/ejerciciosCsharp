using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionDateTime
    {
        public static string ObtenerPlacaCronicaTV(this Estaciones est)
        {
            switch (Enum.GetName(est))
            {
                case "Verano":
                    return $"Faltan {(new DateTime(2022, 12, 21) - DateTime.Now).Days} dias para el Verano";
                case "Primavera":
                    return $"Faltan {(new DateTime(2022, 09, 21) - DateTime.Now).Days} dias para el Primavera";
                case "Invierno":
                    return $"Faltan {(new DateTime(2022, 06, 21) - DateTime.Now).Days} dias para el Invierno";
                default:
                    return $"Faltan {(new DateTime(2023, 03, 21) - DateTime.Now).Days} dias para el Otonio";
            }
        }
    }
}
