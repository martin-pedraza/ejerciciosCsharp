using System;
using System.Text;

namespace Entidades
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string historialVacunacion;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }
        public void SetHistorialVacunacion(string historialVacunacion)
        {
            this.historialVacunacion = historialVacunacion;
        }
        public string GetEspecie()
        {
            return this.especie;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public string GetHistorialVacunacion()
        {
            return this.historialVacunacion;
        }
        public string MostrarMascota()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Mascota:");
            text.AppendLine($"Nombre: {GetNombre()}");
            text.AppendLine($"Especie: {GetEspecie()}");
            text.AppendLine($"Fecha de Nacimiento: {GetFechaNacimiento().ToString("dd-MM-yyyy")}");
            text.AppendLine($"Historial de vacunacion: {VerificarVacunacion()}");
            return text.ToString();
        }
        private string VerificarVacunacion()
        {
            if (string.IsNullOrEmpty(GetHistorialVacunacion()))
            {
                return "Sin vacunar";
            }
            return GetHistorialVacunacion();
        }
    }
}
