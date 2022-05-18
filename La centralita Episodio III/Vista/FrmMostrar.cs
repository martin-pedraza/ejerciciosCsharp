using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private TipoLLamada tipo;
        public FrmMostrar(Centralita centralita, TipoLLamada tipo)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.tipo = tipo;
        }
        public TipoLLamada Tipo
        {
            get { return this.tipo; }
        }
        private void MostrarLlamadas(TipoLLamada tipo)
        {
            StringBuilder sb = new StringBuilder();
            switch (tipo)
            {
                case TipoLLamada.Local:
                    sb.AppendLine($"Ganancia llamada local: {this.centralita.GananciasPorLocal}");
                    sb.AppendLine("----------------------");
                    foreach (Llamada item in this.centralita.Llamadas)
                    {
                        if (item is Local)
                        {
                            sb.AppendLine(item.ToString());
                        }
                    }
                    this.richTextBox.Text = sb.ToString();
                    break;
                case TipoLLamada.Provincial:
                    sb.AppendLine($"Ganancia llamada Provincial: {this.centralita.GananciasPorProvincial}");
                    sb.AppendLine("----------------------");
                    foreach (Llamada item in this.centralita.Llamadas)
                    {
                        if (item is Provincial)
                        {
                            sb.AppendLine(item.ToString());
                        }
                    }
                    this.richTextBox.Text = sb.ToString();
                    break;
                default:
                    this.richTextBox.Text = this.centralita.ToString();
                    break;
            }

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            MostrarLlamadas(this.Tipo);
        }
    }
}
