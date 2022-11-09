using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._7
{
    public partial class Form1 : Form
    {
        Temperatura miTemperatura = new Temperatura();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirAFarenheit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miTemperatura.GradosCentigrados + "° grados centigrados equivale a " + miTemperatura.ConvertirAFarenheit() + "° grados Farenheit.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapturarGrados_Click(object sender, EventArgs e)
        {
            miTemperatura.GradosCentigrados = double.Parse(txtGradosCentigrados.Text);
            txtGradosCentigrados.Clear();
        }
    }
}
