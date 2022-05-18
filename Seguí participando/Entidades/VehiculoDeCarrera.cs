using System;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }
        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }
        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }
        public virtual string MostrarDatos()
        {
            return $"Numero: {this.Numero}, Escuderia: {this.Escuderia}, Combustible: {this.CantidadCombustible}, Vueltas: {this.VueltasRestantes}, En competencia: {this.EnCompetencia}";
        }
    }
}
