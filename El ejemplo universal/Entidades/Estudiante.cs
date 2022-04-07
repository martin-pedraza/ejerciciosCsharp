using System;
using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random Random;

        static Estudiante()
        {
            Estudiante.Random = new Random();
        }
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }
        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return Estudiante.Random.Next(5) + 6;
            }
            return -1;
        }
        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre: {this.nombre}, Apellido: {this.apellido} y Legajo: {this.legajo}");
            datos.AppendLine($"Primer Parcial: {this.notaPrimerParcial}, Segundo Parcial: {this.notaSegundoParcial}");
            datos.AppendLine($"Promedio: {this.CalcularPromedio()}");
            if (this.CalcularNotaFinal()==-1)
            {
                datos.AppendLine("Alumno desaprobado");
            }
            else
            {
                datos.AppendLine($"Nota final: {this.CalcularNotaFinal()}");
            }
            return datos.ToString();
        }
    }
}
