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
    public partial class FrmMenu : Form
    {
        private Centralita centralita = new Centralita();
        FrmLlamador frmLlamador;
        public FrmMenu()
        {
            InitializeComponent();
            frmLlamador = new FrmLlamador(this.centralita);
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(frmLlamador.Centralita, TipoLLamada.Local);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(frmLlamador.Centralita, TipoLLamada.Provincial);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(frmLlamador.Centralita, TipoLLamada.Todas);
            frmMostrar.ShowDialog();
        }
    }
}
