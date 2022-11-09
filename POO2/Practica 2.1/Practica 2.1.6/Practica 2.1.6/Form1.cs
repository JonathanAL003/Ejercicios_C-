using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._6
{
    public partial class Form1 : Form
    {
        Articulo miArticulo = new Articulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {            
            miArticulo.Clave = int.Parse(txtClave.Text);
            miArticulo.Descripcion = txtDescripcion.Text;
            miArticulo.Precio = double.Parse(txtPrecio.Text);
            miArticulo.Cantidad = int.Parse(txtCantidad.Text);
            txtClave.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void brnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularIVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Articulo: " + miArticulo.Descripcion +
                "\nClave: " + miArticulo.Clave +
                "\nStock: " + miArticulo.Cantidad +
                " \n\nPrecio sin IVA: " + miArticulo.Precio  +
                "\nIVA: " + miArticulo.CalcularIVA() +
                "\nEl precio del articulo con iva es de: " + (miArticulo.Precio+miArticulo.CalcularIVA()));
        }
    }
}
