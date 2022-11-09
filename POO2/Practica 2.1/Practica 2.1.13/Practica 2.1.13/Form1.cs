using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._13
{
    public partial class Form1 : Form
    {
        Tiempo miTiempo = new Tiempo(1, 86400);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirASegundos_Click(object sender, EventArgs e)
        {
            try
            {
                miTiempo.Dias = double.Parse(txtDias.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtDias.Text = "";
                txtDias.Focus();
                return;
            }
            txtDias.Clear();
            MessageBox.Show(miTiempo.Dias + " dias equivale a " + miTiempo.ConvertirASegundos() + " segundos");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
