using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCosto_Click(object sender, EventArgs e)
        {
            Gasolinera miGasolinera = new Gasolinera(13.74);
            miGasolinera.Galones = double.Parse(txtGalones.Text);
            MessageBox.Show(miGasolinera.CalcularFactura());
            txtGalones.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
