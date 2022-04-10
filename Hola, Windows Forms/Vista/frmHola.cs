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
    public partial class frmHola : Form
    {
        public frmHola()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text) && string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se debe completar nombre y apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se debe completar nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se debe completar apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmSaludo frmSaludo = new frmSaludo("¡Hola, Windows Forms!", $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.cboMateria.SelectedItem.ToString()}");
                frmSaludo.ShowDialog();
            }
        }

        private void frmHola_Load(object sender, EventArgs e)
        {
            this.cboMateria.Items.Add("Programacion I");
            this.cboMateria.Items.Add("Laboratorio I");
            this.cboMateria.Items.Add("Ingles I");
            this.cboMateria.Items.Add("Sistema operativo");
            this.cboMateria.Items.Add("Matematicas");
            this.cboMateria.Items.Add("Programacion II");
            this.cboMateria.Items.Add("Laboratorio II");
            this.cboMateria.Items.Add("Investigacion Operativa");
            this.cboMateria.Items.Add("Estadistica");
            this.cboMateria.Items.Add("Ingles II");
            this.cboMateria.SelectedIndex = 0;
        }
    }
}
