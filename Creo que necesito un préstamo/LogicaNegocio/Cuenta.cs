using System;

namespace LogicaNegocio
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }
        public string Mostrar()
        {
            return $"Titular: {this.titular}, Cantidad: {this.cantidad}";
        }
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }
        public void Retirar(decimal monto)
        {
            this.cantidad -= monto;
        }
    }
}
