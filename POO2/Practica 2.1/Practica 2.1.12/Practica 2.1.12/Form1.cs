using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._12
{
    public partial class Form1 : Form
    {
        Punto miPunto1 = new Punto();
        Punto miPunto2 = new Punto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturarCoordenadas_Click(object sender, EventArgs e)
        {
            if (radPunto1.Checked == true)
            {
                miPunto1.CoordenadaX = int.Parse(txtCoordenadaX.Text);
                miPunto1.CoordenadaY = int.Parse(txtCoordenadaY.Text);
                txtCoordenadaX.Clear();
                txtCoordenadaY.Clear();
            }
            if (radPunto2.Checked == true)
            {
                miPunto2.CoordenadaX = int.Parse(txtCoordenadaX.Text);
                miPunto2.CoordenadaY = int.Parse(txtCoordenadaY.Text);
                txtCoordenadaX.Clear();
                txtCoordenadaY.Clear();
            }
        }
        public double CalcularDistancia()
        {
            return (Math.Round(Math.Sqrt(Math.Pow(miPunto2.CoordenadaX - miPunto1.CoordenadaX,2) + Math.Pow(miPunto2.CoordenadaY - miPunto1.CoordenadaY,2)),2));
        }

        private void btnCalcularDistancia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La distancia entre los puntos (" + miPunto1.CoordenadaX + "," + miPunto1.CoordenadaY + ") y (" + miPunto2.CoordenadaX + "," + miPunto2.CoordenadaY + ")" + 
                "\n\nEs de " + CalcularDistancia() + " unidades");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
