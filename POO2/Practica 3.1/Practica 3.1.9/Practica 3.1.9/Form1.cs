using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1._9
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        Empleado empleado;
        public Form1()
        {
            InitializeComponent();
            txtSalario.Enabled = false;
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radCliente.Checked)
            {
                cliente = new Cliente(double.Parse(txtLimiteDeCredito.Text), txtNombre.Text, txtDomicilio.Text);
            }
            if (radEmpleado.Checked)
            {
                empleado = new Empleado(double.Parse(txtSalario.Text), txtNombre.Text, txtDomicilio.Text);
            }
            MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radCliente.Checked)
            {
                MessageBox.Show(cliente.ToString(), "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radEmpleado.Checked)
            {
                MessageBox.Show(empleado.ToString(), "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void radCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtSalario.Enabled = false;
            txtLimiteDeCredito.Enabled = true;
        }

        private void radEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            txtLimiteDeCredito.Enabled = false;
            txtSalario.Enabled = true;
        }
    }
}
