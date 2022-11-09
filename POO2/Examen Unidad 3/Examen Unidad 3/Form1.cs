using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Unidad_3
{
    public partial class Form1 : Form
    {
        Repartidor unRepartidor;
        Comercial unComercial;

        public Form1()
        {
            InitializeComponent();

            cboZona.Items.Add("Zona 1");
            cboZona.Items.Add("Zona 2");
            cboZona.Items.Add("Zona 3");

            dtmFechaActual.Enabled = false;
            cboZona.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radRepartidor_CheckedChanged(object sender, EventArgs e)
        {
            txtComision.Enabled = true;
            cboZona.Enabled = false;
        }

        private void radComercial_CheckedChanged(object sender, EventArgs e)
        {
            txtComision.Enabled = false;
            cboZona.Enabled = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (radRepartidor.Checked)
            {
                CalcularEdad(dtmFechaNacimiento);
                unRepartidor.PagoExtra();
                unRepartidor = new Repartidor(cboZona.Text, txtNombre.Text, unRepartidor.Edad , unRepartidor.Salario);
                Clear();
            }
            if(radComercial.Checked)
            {
                CalcularEdad(dtmFechaNacimiento);
                unComercial.PagoExtra();
                unComercial = new Comercial(double.Parse(txtComision.Text), txtNombre.Text, unComercial.Edad , unComercial.Salario);
                Clear();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CalcularEdad()
        {
            if (radRepartidor.Checked)
            {
                DateTime dtmFechaActual = DateTime.Today;
                

                if (dtmFechaNacimiento > dtmFechaActual)
                {
                    MessageBox.Show("Fecha invalida");
                }
                else
                {
                    unRepartidor.Edad = dtmFechaActual.Year - dtmFechaNacimiento.Year;
                    if (dtmFechaNacimiento.Month > dtmFechaActual.Month)
                    {
                        unRepartidor.Edad = unRepartidor.Edad - 1;
                    }
                }
            }
            if (radComercial.Checked)
            {
                DateTime dtmFechaActual = DateTime.Today;

                if (dtmFechaNacimiento > dtmFechaActual)
                {
                    MessageBox.Show("Fecha invalida");
                }
                else
                {
                    unComercial.Edad = dtmFechaActual.Year - dtmFechaNacimiento.Year;
                    if (dtmFechaNacimiento.Month > dtmFechaActual.Month)
                    {
                        unComercial.Edad = unRepartidor.Edad - 1;
                    }
                }
            }
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

        private void lstEmpleados_Click(object sender, EventArgs e)
        {
            Empleado empleadoSelected = new Empleado();
            empleadoSelected = ()lstEmpleados.SelectedItem;
            if (empleadoSelected is null)
            {
                MessageBox.Show("Debe seleccionar un empleado de la lista");
            }
            
        }
    }
}
