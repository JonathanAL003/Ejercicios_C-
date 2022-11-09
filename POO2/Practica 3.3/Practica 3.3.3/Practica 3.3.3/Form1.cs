    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._3._3
{
    public partial class Form1 : Form
    {
        Pastel miPastel = new Pastel();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            miPastel.NombrePastel = txtNombrePastel.Text;
            miPastel.CantidadDePersonas = int.Parse(txtCantidadDePersonas.Text);
            miPastel.Precio = double.Parse(txtPrecio.Text);

            MessageBox.Show("Pastel capturado correctamente");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
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

            miPastel.AgregarIngrediente(unIngrediente);

            MostrarIngredientes();
            
            MessageBox.Show("Nuevo ingrediente agragado");

            foreach (Control control in grpIngrediente.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        public void MostrarIngredientes()
        {
            dtgIngredientes.Rows.Clear();
            foreach (Ingrediente unIngrediente in miPastel)
            {
                dtgIngredientes.Rows.Add(unIngrediente.NombreIngrediente, unIngrediente.UnidadDeMedida, unIngrediente.Cantidad, unIngrediente.CaloriasPorPorcion);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContarIngredientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los ingredientes del pastel " + miPastel.NombrePastel + " son: " + miPastel.ContarIngredientes());
        }

        private void btnSumarCalorias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suma de las calorias del pastel " + miPastel.NombrePastel + " es de: " + miPastel.SumarCalorias());
        }
    }
}
