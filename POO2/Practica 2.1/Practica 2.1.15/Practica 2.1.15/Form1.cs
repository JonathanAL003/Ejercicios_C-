using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._15
{
    public partial class Form1 : Form
    {
        LlamadaTelefonica miLlamada = new LlamadaTelefonica();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                miLlamada.DuracionMinutos = int.Parse(txtMinutos.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtMinutos.Text = "";
                txtMinutos.Focus();
                return;
            }
            txtMinutos.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            miLlamada.CalcularCosto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
