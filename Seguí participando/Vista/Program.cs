//Consigna
//Partir del ejercicio Enciendan sus motores y agregar la clase VehiculoDeCarrera y la clase MotoCross.

//Diagrama de clases

//Mover toda la información pedida a la clase VehiculoDeCarrera, modificando AutoF1 y generando sus correspondientes propiedades.

//Dos VehiculoDeCarrera son iguales si coincide su número y escudería.
//Dos AutoF1 serán iguales cuando, además de coincidir los datos contenidos en VehiculoDeCarrera, coincida el atributo caballosDeFuerza.
//Dos MotoCross son iguales si coincide cuando, además de coincidir los datos contenidos en VehiculoDeCarrera, coincida el atributo cilindrada.
//El método Mostrar de VehiculoDeCarrera será el único capaz de exponer información de este tipo de objetos.
//En la clase Competencia cambiar el tipo de la lista por VehiculoDeCarrera.

//Si la competencia es declarada del tipo CarreraMotoCross, sólo se podrán agregar vehículos del tipo MotoCross. Si la competencia es del tipo F1, sólo se podrán agregar objetos AutoF1. Colocar dicha comparación dentro de la sobrecarga del operador == de la clase Competencia.
//Modificar todo lo que sea necesario para que el sistema siga comportándose de la misma forma, aceptando también vehículos del tipo MotoCross en la competencia.

using System;
using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 15, Competencia.TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            for (int i = 0; i < autos.Length - 1; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                if (formulaUno + autos[i])
                {
                    Console.WriteLine("Se agrego el siguiente auto: {0}", autos[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("Competencia completa");
                }
            }
            MotoCross moto = new MotoCross(2, "Ford");
            try
            {
                if (formulaUno + moto)
                {
                    Console.WriteLine("Se agrego");
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine(formulaUno.MostrarDatos());
        }
    }
}
