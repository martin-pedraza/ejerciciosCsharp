using System;

namespace Entidades
{
    public class Conductor
    {
        private string nombre;
        private int dia1;
        private int dia2;
        private int dia3;
        private int dia4;
        private int dia5;
        private int dia6;
        private int dia7;

        public Conductor()
        {

        }
        public Conductor(string nombre, int dia1, int dia2, int dia3, int dia4, int dia5, int dia6, int dia7)
        {
            this.nombre = nombre;
            this.dia1 = dia1;
            this.dia2 = dia2;
            this.dia3 = dia3;
            this.dia4 = dia4;
            this.dia5 = dia5;
            this.dia6 = dia6;
            this.dia7 = dia7;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public int GetDia1()
        {
            return this.dia1;
        }
        public int GetDia2()
        {
            return this.dia2;
        }
        public int GetDia3()
        {
            return this.dia3;
        }
        public int GetDia4()
        {
            return this.dia4;
        }
        public int GetDia5()
        {
            return this.dia5;
        }
        public int GetDia6()
        {
            return this.dia6;
        }
        public int GetDia7()
        {
            return this.dia7;
        }
        private static int ConfirmarDia(Conductor conductor, int numeroDia)
        {
            switch (numeroDia)
            {
                case 1:
                    return conductor.GetDia1();
                case 2:
                    return conductor.GetDia2();
                case 3:
                    return conductor.GetDia3();
                case 4:
                    return conductor.GetDia4();
                case 5:
                    return conductor.GetDia5();
                case 6:
                    return conductor.GetDia6();
                case 7:
                    return conductor.GetDia7();
                default:
                    return -1;
            }
        }
        public static void CompararEmpleadosPorDia(Conductor[] nomina, int dia)
        {
            int max = int.MinValue;
            int indice = 0;
            for (int i = 0; i < nomina.Length; i++)
            {
                if (max < ConfirmarDia(nomina[i], dia))
                {
                    max = ConfirmarDia(nomina[i], dia);
                    indice = i;
                }
            }
            MostrarConductor(nomina[indice]);
        }
        private static void MostrarConductor(Conductor conductor)
        {
            Console.WriteLine(conductor.GetNombre());
        }
        public static void CompararEmpleadoPorSemana(Conductor[] nomina)
        {
            int max = int.MinValue;
            int indice = 0;
            int sumador;
            for (int i = 0; i < nomina.Length; i++)
            {
                sumador = 0;
                for (int j = 1; j <= 7; j++)
                {
                    sumador += Conductor.ConfirmarDia(nomina[i], j);
                }
                if (max < sumador)
                {
                    max = sumador;
                    indice = i;
                }
            }
            Conductor.MostrarConductor(nomina[indice]);

        }


    }
}