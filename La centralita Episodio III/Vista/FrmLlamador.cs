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
    public partial class FrmLlamador : Form
    {

        private Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }
        public Centralita Centralita
        {
            get { return this.centralita; }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Franjas));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = String.Empty;
            this.cmbFranja.Enabled = true;
        }

        private void btnSharp_Click(object sender, EventArgs e)
        {
            if (this.txtNroDestino.Text == String.Empty)
            {
                this.txtNroDestino.Text += "#";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
            DiscandoLocal();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
            DiscandoLocal();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
            DiscandoLocal();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
            DiscandoLocal();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
            DiscandoLocal();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
            DiscandoLocal();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
            DiscandoLocal();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
            DiscandoLocal();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
            DiscandoLocal();
        }

        private void brn0_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
            DiscandoLocal();
        }

        private void DiscandoLocal()
        {
            if (this.txtNroDestino.Text[0] != '#')
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {

            if (this.txtNroDestino.Text != String.Empty && this.txtNroDestino.Text.Length >= 8)
            {
                if (this.txtNroDestino.Text[0] == '#')
                {
                    Franjas franjas;
                    Enum.TryParse<Franjas>(cmbFranja.SelectedValue.ToString(), out franjas);
                    Provincial p = new Provincial(txtNroOrigen.Text, franjas, new Random().Next(1, 50), txtNroDestino.Text);
                    try
                    {
                        centralita += p;
                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show($"Clase:{ex.NombreClase}, Metodo:{ex.NombreMetodo}", $"{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Local l = new Local(txtNroOrigen.Text, new Random().Next(1, 50), txtNroDestino.Text, (new Random().Next(0, 5) + 0.6f));
                    try
                    {
                        centralita += l;
                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show($"{ex.Message}", $"Clase:{ex.NombreClase}, Metodo:{ex.NombreMetodo}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Numero no valido. Minimo 8 digitos.");
            }
        }
    }
}
