using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._4
{
    public partial class Form1 : Form
    {
        Rectangulo miPared = new Rectangulo();
        Rectangulo miVentana = new Rectangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radPared.Checked == true)
            {
                miPared.Largo = double.Parse(txtLargo.Text);
                miPared.Ancho = double.Parse(txtAncho.Text);
                txtLargo.Clear();
                txtAncho.Clear();
            }
            if (radVentana.Checked == true)
            {
                miVentana.Largo = double.Parse(txtLargo.Text);
                miVentana.Ancho = double.Parse(txtAncho.Text);
                txtLargo.Clear();
                txtAncho.Clear();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (radPared.Checked == true)
            {
                MessageBox.Show("Area de la pared = " + miPared.CalcularArea());
            }
            if (radVentana.Checked == true)
            {
                MessageBox.Show("Area de la ventana = " + miVentana.CalcularArea());
            }
        }

        private void btnTiempoPintura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minutos necesarios para pintar la pared: " + ((miPared.CalcularArea() - miVentana.CalcularArea()) * 10) + " minutos.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
