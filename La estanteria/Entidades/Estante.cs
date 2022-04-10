using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < e.productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e.GetProductos()[i]));
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto item in e.GetProductos())
            {
                if (item == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.GetProductos()[i] is null)
                    {
                        e.GetProductos()[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.GetProductos()[i] = null;
                    break;
                }
            }
            return e;
        }
    }
}
