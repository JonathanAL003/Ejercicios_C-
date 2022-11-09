using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._1._3
{
    public partial class Form1 : Form
    {
        Autobus unAutobus = new Autobus();
        Tractor unTractor = new Tractor();

        public Form1()
        {
            InitializeComponent();

            dtmFechaDevolucion.Enabled = false;
            txtKmDevolver.Enabled = false;
            txtKmRenta.Enabled = true;
        }

        private void radAutobus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDevolver.Checked == true)
            {
                txtPlacas.Enabled = false;
                txtPrecio.Enabled = false;
                txtKmRenta.Enabled = false;
                txtKmDevolver.Enabled = true;
                dtmFechaDevolucion.Enabled = false;
            }
            if (chkDevolver.Checked == false)
            {
                txtPlacas.Enabled = true;
                txtPrecio.Enabled = true;
                txtKmRenta.Enabled = true;
                txtKmDevolver.Enabled = false;
                dtmFechaDevolucion.Enabled = false;
            }
        }

        private void radTractor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDevolver.Checked == true)
            {
                txtPlacas.Enabled = false;
                txtPrecio.Enabled = false;
                txtKmRenta.Enabled = false;
                txtKmDevolver.Enabled = false;
                dtmFechaDevolucion.Enabled = true;
            }
            if (chkDevolver.Checked == false)
            {
                txtPlacas.Enabled = true;
                txtPrecio.Enabled = true;
                txtKmRenta.Enabled = false;
                txtKmDevolver.Enabled = false;
                dtmFechaDevolucion.Enabled = false;
            }
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radAutobus.Checked)
                {
                    unAutobus.Placas = txtPlacas.Text;
                    unAutobus.Precio = double.Parse(txtPrecio.Text);
                    unAutobus.KilometrosRenta = double.Parse(txtKmRenta.Text);
                    unAutobus.Alquilada = true;
                    MessageBox.Show("Placas: " + unAutobus.Placas + "\nPrecio por km: $" + unAutobus.Precio + "\nKms. al rentar: " + unAutobus.KilometrosRenta + "\nAutobus: " + unAutobus.ConsultarDisponibilidad(), "Renta de Autobús", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (radTractor.Checked)
                {
                    unTractor.Placas = txtPlacas.Text;
                    unTractor.Precio = double.Parse(txtPrecio.Text);
                    unTractor.FechaRenta = dtmFechaRenta.Value;
                    unTractor.Alquilada = true;
                    MessageBox.Show("Placas: " + unTractor.Placas + "\nPrecio por día: $" + unTractor.Precio + "\nFecha de renta: " + unTractor.FechaRenta + "\nTractor: " + unTractor.ConsultarDisponibilidad(), "Renta de Tractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
                txtKmRenta.Text = "";
                txtPlacas.Text = "";
                txtPrecio.Text = "";
                return;
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (radAutobus.Checked)
                {
                    unAutobus.KilometrosDevuelve = double.Parse(txtKmDevolver.Text);
                    unAutobus.Alquilada = false;
                    double Costo = 0.0;
                    double KilometrosRecorridos = 0.0;
                    KilometrosRecorridos = unAutobus.KilometrosDevuelve - unAutobus.KilometrosRenta;
                    Costo = (KilometrosRecorridos* unAutobus.Precio);
                    MessageBox.Show("Placas: " + unAutobus.Placas + "\nPrecio por km: $" + unAutobus.Precio + "\nKms. al rentar: " + unAutobus.KilometrosRenta + "\nAutobus: " + unAutobus.ConsultarDisponibilidad() + "\n\nKm al devolver: " + unAutobus.KilometrosDevuelve + "\nKilometros recorridos: " + KilometrosRecorridos + "\nCosto por renta: $" + Costo, "Devolución de Autobús", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (radTractor.Checked)
                {
                    unTractor.FechaDevolucion = dtmFechaDevolucion.Value;
                    unAutobus.Alquilada = false;
                    double Costo = 0.0;
                    DateTime FechaRenta = dtmFechaRenta.Value.Date;
                    DateTime FechaDevolucion = dtmFechaDevolucion.Value.Date;
                    TimeSpan tSpan = FechaDevolucion - FechaRenta;
                    int DiasRentados = tSpan.Days;
                    Costo = unTractor.Precio * DiasRentados;
                    MessageBox.Show("Placas: " + unTractor.Placas + "\nPrecio por día: $" + unTractor.Precio + "\nFecha de la renta: " + unTractor.FechaRenta + "\nTractor: " + unTractor.ConsultarDisponibilidad() + "\n\nFecha de devolución: " + unTractor.FechaDevolucion + "\nDías rentados: " + DiasRentados + "\nCosto por renta: $" + Costo, "Devolución de Tractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtKmDevolver.Text = "";
                return;
            }
        }

        public void Clear()
        {
            foreach (Control x in grpDatosDelVehiculo.Controls)
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

        private void chkDevolver_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDevolver.Checked == true)
            { 
                if (radAutobus.Checked)
                {
                    Clear();
                    txtPlacas.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtKmRenta.Enabled = false;
                    txtKmDevolver.Enabled = true;
                    dtmFechaDevolucion.Enabled = false;
                    
                    txtPlacas.Text = unAutobus.Placas;
                    txtPrecio.Text = unAutobus.Precio.ToString("C");
                    txtKmRenta.Text = unAutobus.KilometrosRenta.ToString();
                }
                if (radTractor.Checked)
                {
                    Clear();
                    txtPlacas.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtKmRenta.Enabled = false;
                    txtKmDevolver.Enabled = false;
                    dtmFechaDevolucion.Enabled = true;

                    txtPlacas.Text = unTractor.Placas;
                    txtPrecio.Text = unTractor.Precio.ToString("C");
                }
            }
            if (chkDevolver.Checked == false)
            {
                if (radAutobus.Checked)
                {
                    txtPlacas.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtKmRenta.Enabled = true;
                    txtKmDevolver.Enabled = false;
                    dtmFechaDevolucion.Enabled = false;
                    Clear();
                }
                if (radTractor.Checked)
                {
                    txtPlacas.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtKmRenta.Enabled = false;
                    txtKmDevolver.Enabled = false;
                    dtmFechaDevolucion.Enabled = false;
                    Clear();
                }
            }
        }
    }
}
