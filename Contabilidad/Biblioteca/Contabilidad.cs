using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contabilidad<T, U> where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        public string Egresos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (T t in this.egresos)
                {
                    sb.AppendLine($"Factura: {t.ToString()}");
                }
                return sb.ToString();
            }
        }
        public string Ingresos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (U u in this.ingresos)
                {
                    sb.AppendLine($"Recibo: {u.ToString()}");
                }
                return sb.ToString();
            }
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }
    }
}
