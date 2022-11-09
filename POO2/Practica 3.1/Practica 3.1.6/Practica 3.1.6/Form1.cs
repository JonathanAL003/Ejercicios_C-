using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1._6
{
    public partial class Form1 : Form
    {
        Portero portero;
        Goleadores Defensa, Medio, Delantero;
        public Form1()
        {
            InitializeComponent();
            txtGolesAnotados.Enabled = false;
        }
       
        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radPortero.Checked)
            {
                MessageBox.Show(portero.ToString(), "Portero", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radDefensa.Checked)
            {
                MessageBox.Show(Defensa.ToString(), "Defensa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radMedio.Checked)
            {
                MessageBox.Show(Medio.ToString(), "Medio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radDelantero.Checked)
            {
                MessageBox.Show(Delantero.ToString(), "Delantero", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radPortero_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = false;
        }

        private void radDefensa_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = true;
        }

        private void radMedio_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = true;
        }

        private void radDelantero_CheckedChanged(object sender, EventArgs e)
        {
            txtGolesAnotados.Enabled = true;
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radPortero.Checked)
            {
                portero = new Portero(int.Parse(txtNumUniforme.Text), txtNombre.Text, "Portero", int.Parse(txtMinJugados.Text));
            }
            if (radDefensa.Checked)
            {
                Defensa = new Goleadores(int.Parse(txtGolesAnotados.Text), int.Parse(txtNumUniforme.Text), txtNombre.Text, "Defensa", int.Parse(txtMinJugados.Text));
            }
            if (radMedio.Checked)
            {
                Medio = new Goleadores(int.Parse(txtGolesAnotados.Text), int.Parse(txtNumUniforme.Text), txtNombre.Text, "Medio", int.Parse(txtMinJugados.Text));
            }
            if (radDelantero.Checked)
            {
                Delantero = new Goleadores(int.Parse(txtGolesAnotados.Text), int.Parse(txtNumUniforme.Text), txtNombre.Text, "Delantero", int.Parse(txtMinJugados.Text));
            }
            MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }
        public void Clear()
        {
            foreach (Control x in grpDatos.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }
    }
}
