using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._5
{
    public partial class Form1 : Form
    {
        Fecha miFecha = new Fecha(25, 10, 2001);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModificarFecha_Click(object sender, EventArgs e)
        {
            miFecha.Dia = int.Parse(txtDia.Text);
            miFecha.Mes = int.Parse(txtMes.Text);
            miFecha.Año = int.Parse(txtAño.Text);
        }

        private void btnConsultarFecha_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miFecha.ConsultarFecha());
        }

        private void btnConsultarFechaLetra_Click(object sender, EventArgs e)
        {
            miFecha.ConsultarFechaLetra();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miFecha.VerificarFecha());
        }
    }
}
