using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtgIngredientes.Columns.Add("Nombre", "Nombre");
            dtgIngredientes.Columns.Add("Unidad de medida", "Unidad de medida");
            dtgIngredientes.Columns.Add("Cantidad", "Cantidad");
            dtgIngredientes.Columns.Add("Calorias por porción", "Calorias por porción");

            dtgIngredientes.ReadOnly = true;
            dtgIngredientes.AllowUserToAddRows = false;
            dtgIngredientes.AllowUserToDeleteRows = false;
            dtgIngredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pastel unPastel = new Pastel();
            unPastel.NombrePastel = txtNombrePastel.Text;
            unPastel.CantidadDePersonas = int.Parse(txtCantidadDePersonas.Text);
            unPastel.Precio = double.Parse(txtPrecio.Text);

            lstPasteles.Items.Add(unPastel);
            MessageBox.Show("Pastel capturado correctamente");

            foreach (Control control in grpPastel.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        Pastel SeleccionarPastel()
        {
            Pastel pastelSelected = new Pastel();
            pastelSelected = (Pastel)lstPasteles.SelectedItem;
            if (pastelSelected is null)
            {
                MessageBox.Show("Debe seleccionar un pastel de la lista");
            }
            return pastelSelected;
        }

        void MostrarIngredientes(Pastel p)
        {
            dtgIngredientes.Rows.Clear();
            foreach (Ingrediente unIngrediente in p)
            {
                dtgIngredientes.Rows.Add(unIngrediente.NombreIngrediente, unIngrediente.UnidadDeMedida, unIngrediente.Cantidad, unIngrediente.CaloriasPorPorcion);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pastel pastelSelected = SeleccionarPastel();

            Ingrediente unIngrediente = new Ingrediente();
            unIngrediente.NombreIngrediente = txtNombreIngrediente.Text;
            if (radGramos.Checked)
            {
                unIngrediente.UnidadDeMedida = radGramos.Text;
            }
            if (radMililitros.Checked)
            {
                unIngrediente.UnidadDeMedida = radMililitros.Text;
            }
            if (radPiezas.Checked)
            {
                unIngrediente.UnidadDeMedida = radPiezas.Text;
            }
            unIngrediente.Cantidad = double.Parse(txtCantidad.Text);
            unIngrediente.CaloriasPorPorcion = double.Parse(txtCaloriasPorPorcion.Text);

            pastelSelected.AgregarIngrediente(unIngrediente);

            MostrarIngredientes(pastelSelected);

            MessageBox.Show("Nuevo ingrediente agragado");

            foreach (Control control in grpIngrediente.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void lstPasteles_Click(object sender, EventArgs e)
        {
            Pastel pastelSelected = new Pastel();
            pastelSelected = (Pastel)lstPasteles.SelectedItem;
            if (pastelSelected is null)
            {
                MessageBox.Show("Debe seleccionar un pastel de la lista");
            }
            MostrarIngredientes(pastelSelected);
        }

        private void btnContarIngredientes_Click(object sender, EventArgs e)
        {
            Pastel unPastel = SeleccionarPastel();
            MessageBox.Show("Los ingredientes del pastel " + unPastel.NombrePastel + " son: " + unPastel.ContarIngredientes());
        }

        private void btnSumarCalorias_Click(object sender, EventArgs e)
        {
            Pastel unPastel = SeleccionarPastel();
            MessageBox.Show("La suma de las calorias del pastel " + unPastel.NombrePastel + " es de: " + unPastel.SumarCalorias());
        }

        private void btnTotalIngredientes_Click(object sender, EventArgs e)
        {
            int sumaIngredientes = 0;
            foreach (Pastel unPastel in lstPasteles.Items)
            {
                sumaIngredientes += unPastel.ContarIngredientes();
            }
            MessageBox.Show("La cantidad total de ingredientes es de: " + sumaIngredientes);
        }

        private void btnTotalCalorias_Click(object sender, EventArgs e)
        {
            double sumaCalorias = 0.0;
            foreach (Pastel unPastel in lstPasteles.Items)
            {
                sumaCalorias += unPastel.SumarCalorias();
            }
            MessageBox.Show("La suma de las calorias de todos los pasteles es de: " + sumaCalorias);
        }

        private void btnPastelMasCaro_Click(object sender, EventArgs e)
        {
            Pastel pastelMasCaro = new Pastel();
            pastelMasCaro.Precio = 0.0;
            foreach (Pastel unPastel in lstPasteles.Items)
            {
                if (unPastel.Precio > pastelMasCaro.Precio)
                {
                    pastelMasCaro = unPastel;
                }
            }
            MessageBox.Show("El pastel más caro es: " + pastelMasCaro.NombrePastel + " cuesta $ " + pastelMasCaro.Precio);
        }

        private void btnPastelMasBarato_Click(object sender, EventArgs e)
        {
            Pastel pastelMasBarato = new Pastel();
            bool first = true;
            foreach (Pastel unPastel in lstPasteles.Items)
            {
                if (first)
                {
                    pastelMasBarato = unPastel;
                    first = false;
                }
                if (unPastel.Precio < pastelMasBarato.Precio)
                {
                    pastelMasBarato = unPastel;
                }
            }
            MessageBox.Show("El pastel más barato es: " + pastelMasBarato.NombrePastel + " cuesta $ " + pastelMasBarato.Precio);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
