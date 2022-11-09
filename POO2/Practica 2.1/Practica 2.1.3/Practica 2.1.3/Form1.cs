using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._3
{
    public partial class Form1 : Form
    {
        Rectangulo miPared = new Rectangulo();
        Rectangulo miVentana = new Rectangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModificarLargo_Click(object sender, EventArgs e)
        {
            double l;
            l = double.Parse(txtLargo.Text);
            if (radPared.Checked == true)
            {
                miPared.ModificarLargo(l);
                txtLargo.Clear();
            }
            if (radVentana.Checked == true)
            {
                miVentana.ModificarLargo(l);
                txtLargo.Clear();
            }
        }

        private void btnModificarAncho_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(txtAncho.Text);
            if (radPared.Checked == true)
            {
                miPared.ModificarAncho(a);
                txtAncho.Clear();
            }
            if (radVentana.Checked == true)
            {
                miVentana.ModificarAncho(a);
                txtAncho.Clear();
            }
        }

        private void btnConsultarLargo_Click(object sender, EventArgs e)
        {
            if (radPared.Checked == true)
            {
                MessageBox.Show("Largo de la pared = " + miPared.ConsultarLargo());
            }
            if (radVentana.Checked == true)
            {
                MessageBox.Show("Largo de la ventana = " + miVentana.ConsultarLargo());
            }
        }

        private void btnConsultarAncho_Click(object sender, EventArgs e)
        {
            if (radPared.Checked == true)
            {
                MessageBox.Show("Ancho de la pared = " + miPared.ConsultarAncho());
            }
            if (radVentana.Checked == true)
            {
                MessageBox.Show("Ancho de la pared = " + miVentana.ConsultarAncho());
            }
        }

        private void btnTiempoPintura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minutos necesarios para pintar la pared: " + ((miPared.CalcularArea() - miVentana.CalcularArea())*10) + " minutos.");
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
    }
}
