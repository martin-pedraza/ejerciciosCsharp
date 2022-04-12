﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }
        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (item== c)
                {
                    return false;
                }
            }
            n.clientes.Enqueue(c);
            return true;
        }
        public Cliente Cliente
        {
            get{ return this.clientes.Dequeue(); }
            set{ bool resultado = this + value; }
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
    }
}
