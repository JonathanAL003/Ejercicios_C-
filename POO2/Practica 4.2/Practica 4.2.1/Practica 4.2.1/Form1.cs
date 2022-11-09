using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._2._1
{
    public partial class Form1 : Form
    {
        Rectangulo unRectangulo = new Rectangulo();
        Circunferencia unaCircunferencia = new Circunferencia();
        TrianguloEquilatero unTrianguloEquilatero = new TrianguloEquilatero();

        public Form1()
        {
            InitializeComponent();

            txtLado.Enabled = false;
            txtRadio.Enabled = false;
            txtAncho.Enabled = true;
            txtLargo.Enabled = true;
        }

        private void btnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            try
            {
                if (radRectangulo.Checked)
                {
                    unRectangulo.Ancho = double.Parse(txtAncho.Text);
                    unRectangulo.Largo = double.Parse(txtLargo.Text);
                    MessageBox.Show("Ancho: " + unRectangulo.Ancho + "\nAncho: " + unRectangulo.Ancho + "\n\nEl perimetro del rectangulo es de " + unRectangulo.CalcularPerimetro() + " unidades","Perimetro del Rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (radCircunferencia.Checked)
                {
                    unaCircunferencia.Radio = double.Parse(txtRadio.Text);
                    MessageBox.Show("Radio: " + unaCircunferencia.Radio + "\n\nEl perimetro de la circunferencia es de " + unaCircunferencia.CalcularPerimetro() + " unidades", "Perimetro de la Circunferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (radTrianguloEquilatero.Checked)
                {
                    unTrianguloEquilatero.Lado = double.Parse(txtLado.Text);
                    MessageBox.Show("Lado: " + unTrianguloEquilatero.Lado + "\n\nEl perimetro del triangulo equilatero es de " + unTrianguloEquilatero.CalcularPerimetro() + " unidades", "Perimetro del Triangulo Equilatero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
                txtAncho.Text = "";
                txtLargo.Text = "";
                txtLado.Text = "";
                txtRadio.Text = "";
                return;
            }
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (radRectangulo.Checked)
                {
                    unRectangulo.Ancho = double.Parse(txtAncho.Text);
                    unRectangulo.Largo = double.Parse(txtLargo.Text);
                    MessageBox.Show("Ancho: " + unRectangulo.Ancho + "\nAncho: " + unRectangulo.Ancho + "\n\nEl area del rectangulo es de " + unRectangulo.CalcularArea() + " unidades", "Area del Rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (radCircunferencia.Checked)
                {
                    unaCircunferencia.Radio = double.Parse(txtRadio.Text);
                    MessageBox.Show("Radio: " + unaCircunferencia.Radio + "\n\nEl area de la circunferencia es de " + unaCircunferencia.CalcularArea() + " unidades", "Area de la Circunferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (radTrianguloEquilatero.Checked)
                {
                    unTrianguloEquilatero.Lado = double.Parse(txtLado.Text);
                    MessageBox.Show("Lado: " + unTrianguloEquilatero.Lado + "\n\nEl area del triangulo equilatero es de " + unTrianguloEquilatero.CalcularArea() + " unidades", "Area del Triangulo Equilatero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtAncho.Text = "";
                txtLargo.Text = "";
                txtLado.Text = "";
                txtRadio.Text = "";
                return;
            }
        }

        public void Clear()
        {
            foreach (Control x in grpDatosDeLaFigura.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            
        }

        private void radRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtLado.Enabled = false;
            txtRadio.Enabled = false;
            txtAncho.Enabled = true;
            txtLargo.Enabled = true;
        }

        private void radCircunferencia_CheckedChanged(object sender, EventArgs e)
        {
            txtLado.Enabled = false;
            txtRadio.Enabled = true;
            txtAncho.Enabled = false;
            txtLargo.Enabled = false;
        }

        private void radTrianguloEquilatero_CheckedChanged(object sender, EventArgs e)
        {
            txtLado.Enabled = true;
            txtRadio.Enabled = false;
            txtAncho.Enabled = false;
            txtLargo.Enabled = false;
        }
    }
}
