using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._2
{
    public partial class Form1 : Form
    {
        Circunferencia unaRueda = new Circunferencia();
        Circunferencia unaMoneda = new Circunferencia();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturarRadio_Click(object sender, EventArgs e)
        {
            if (radRueda.Checked == true)
            {
                unaRueda.Radio = double.Parse(txtRadio.Text);
                txtRadio.Clear();
            }
            if (radMoneda.Checked == true)
            {
                unaMoneda.Radio = double.Parse(txtRadio.Text);
                txtRadio.Clear();
            }
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
