using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._1
{
    public partial class Form1 : Form
    {
        Circunferencia unaRueda = new Circunferencia();
        Circunferencia unaMoneda = new Circunferencia();

        public Form1()
        {
            InitializeComponent();
        }

        private void radRueda_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radRueda.Checked == true)
            {
                MessageBox.Show("Area =" + unaRueda.CalcularArea());
            }
            if (radMoneda.Checked == true)
            {
                MessageBox.Show("Area =" + unaMoneda.CalcularArea());
            }
            
        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if (radRueda.Checked == true)
            {
                MessageBox.Show("Perimetro =" + unaRueda.CalcularPerimetro());
            }
            if (radMoneda.Checked == true)
            {
                MessageBox.Show("Perimetro =" + unaMoneda.CalcularPerimetro());
            }
            
        }

        private void btnCapturarRadio_Click(object sender, EventArgs e)
        {
            double r;
            r = double.Parse(txtRadio.Text);
            if (radRueda.Checked == true)
            {
                unaRueda.ModificarRadio(r);
                txtRadio.Clear();
            }
            if (radMoneda.Checked == true)
            {
                unaMoneda.ModificarRadio(r);
                txtRadio.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultarRadio_Click(object sender, EventArgs e)
        {
            if (radRueda.Checked == true)
            {
                MessageBox.Show("El radio de la rueda es de = " + unaRueda.ConsultarRadio());
            }
            if (radMoneda.Checked == true)
            {
                MessageBox.Show("El radio de la moneda es de = " + unaMoneda.ConsultarRadio());
            }
        }
    }
}
