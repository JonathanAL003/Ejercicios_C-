using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCostoFinal_Click(object sender, EventArgs e)
        {
            Automovil miAutomovil = new Automovil();
            miAutomovil.CostoAutomovil = double.Parse(txtCostoAuto.Text);
            MessageBox.Show("El costo base del automovil es de $" + miAutomovil.CostoAutomovil +
                "\nGanancia del vendedor es de: $" + miAutomovil.CalcularGanancia() +
                "\nImpuesto de: $" +miAutomovil.CalcularImpuesto() +
                "\n\nEl total a pagar por su automovil es de: $" + miAutomovil.CalcularCostoFinal());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
