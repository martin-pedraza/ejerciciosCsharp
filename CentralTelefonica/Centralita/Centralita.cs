using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(TipoLLamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(TipoLLamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return CalcularGanancia(TipoLLamada.Todas); }
        }
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(TipoLLamada tipo)
        {
            float sumadorLocal = 0;
            float sumadorProvincial = 0;
            foreach (var item in this.Llamadas)
            {
                if (item is Local)
                {
                    sumadorLocal += ((Local)item).CostoLlamada;
                }
                if (item is Provincial)
                {
                    sumadorProvincial += ((Provincial)item).CostoLlamada;
                }
            }
            switch (tipo)
            {
                case TipoLLamada.Local:
                    return sumadorLocal;
                case TipoLLamada.Provincial:
                    return sumadorProvincial;
                default:
                    return sumadorLocal + sumadorProvincial;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}\n"
                + $"Ganancias ({this.GananciasPorTotal}):\n"
                + $"Local: {this.GananciasPorLocal}\n"
                + $"Provincial: {this.GananciasPorProvincial}\n"
                + "--------------------\n"
                + "Llamadas:");
            foreach (var item in this.Llamadas)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
