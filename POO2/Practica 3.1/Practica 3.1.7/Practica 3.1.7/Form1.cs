using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1._7
{
    public partial class Form1 : Form
    {
        Bateadores bateador;
        JugadorPosicion jugadorposicion;
        Pitcher pitcher;
        public Form1()
        {
            InitializeComponent();
            txtHits.Enabled = true;
            txtErrores.Enabled = false;
            txtPonches.Enabled = false;
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if(radBateador.Checked)
            {
                bateador = new Bateadores(int.Parse(txtHits.Text), int.Parse(txtNumUniforme.Text), txtNombre.Text,"Bateadores");
            }
            if (radJugadorDePosicion.Checked)
            {
                jugadorposicion = new JugadorPosicion(int.Parse(txtErrores.Text),int.Parse(txtHits.Text), int.Parse(txtNumUniforme.Text), txtNombre.Text, "Jugador de posicion");
            }
            if (radPitcher.Checked)
            {
                pitcher = new Pitcher(int.Parse(txtPonches.Text), int.Parse(txtErrores.Text), int.Parse(txtNumUniforme.Text), txtNombre.Text, "Pitcher");
            }
            MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radBateador.Checked)
            {
                MessageBox.Show(bateador.ToString(), "Bateador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radJugadorDePosicion.Checked)
            {
                MessageBox.Show(jugadorposicion.ToString(), "Jugador de posición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radPitcher.Checked)
            {
                MessageBox.Show(pitcher.ToString(), "Pitcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void radBateador_CheckedChanged(object sender, EventArgs e)
        {
            txtHits.Enabled = true;
            txtErrores.Enabled = false;
            txtPonches.Enabled = false;
        }

        private void radJugadorDePosicion_CheckedChanged(object sender, EventArgs e)
        {
            txtHits.Enabled = true;
            txtErrores.Enabled = true;
            txtPonches.Enabled = false;
        }

        private void radPitcher_CheckedChanged(object sender, EventArgs e)
        {
            txtHits.Enabled = false;
            txtErrores.Enabled = true;
            txtPonches.Enabled = true;
        }
    }
}
