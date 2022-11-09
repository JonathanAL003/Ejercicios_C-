using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btmConvertirADolares_Click(object sender, EventArgs e)
        {
            CambioDivisas miCambioDivisas = new CambioDivisas(21.14);
            miCambioDivisas.Pesos = double.Parse(txtPesos.Text);
            MessageBox.Show("Sus dolares son = $" + miCambioDivisas.ConvertirADolares());
            txtPesos.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
