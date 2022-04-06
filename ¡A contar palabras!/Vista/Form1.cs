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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string[] palabra = rchParrafo.Text.Split(' ');
            foreach (string item in palabra)
            {
                if (!diccionario.ContainsKey(item))
                {
                    diccionario.Add(item, 1);
                }
                else
                {
                    diccionario[item]++;
                }
            }    
            mostrarRanking(diccionario);
        }

        public void mostrarRanking(Dictionary<string, int> diccionario)
        {
            StringBuilder ranking = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                foreach (KeyValuePair<string, int> item in diccionario)
                {
                    if (item.Value == diccionario.Values.Max())
                    {
                        ranking.AppendLine($"Palabra: {item.Key}, Cont: {item.Value}");
                        diccionario.Remove(item.Key);
                        break;
                    }
                }

            }
            MessageBox.Show(ranking.ToString());
        }
    }
}
