using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        private Mascota mascota1;
        private Mascota mascota2;

        public Cliente(string domicilio, string nombre, string apellido, string telefono, Mascota mascota1)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascota1 = mascota1;
        }
        public void SetMascota2(Mascota mascota2)
        {
            this.mascota2 = mascota2;
        }
        public string GetDomicio()
        {
            return this.domicilio;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public string MostrarCliente()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Cliente:");
            text.AppendLine($"Nombre: {GetNombre()}");
            text.AppendLine($"Apellido: {GetApellido()}");
            text.AppendLine($"Domicilio: {GetDomicio()}");
            text.AppendLine($"Telefono: {GetTelefono()}");
            text.AppendLine(mascota1.MostrarMascota());
            if (VerificarMascota2())
            {
                text.AppendLine(mascota2.MostrarMascota());
            }
            return text.ToString();
        }
        private bool VerificarMascota2()
        {
            if (this.mascota2 != null)
            {
                return true;
            }
            return false;
        }
    }
}
