using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoFutbol : Equipo
    {
        public EquipoFutbol(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }

        public override string Ficha()
        {
            return $"{base.Nombre} fundado el {base.FechaCreacion.ToString("dd/MM/yyyy")}";
        }
    }
}
