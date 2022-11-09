#define GenerarEmpleadosAleatorios

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_datos_aleatorios
{
    public partial class Form1 : Form
    {
        Empleado unEmpleado;
        public Form1()
        {
            InitializeComponent();

            dtgEmpleados.Columns.Add("Número", "Número");
            dtgEmpleados.Columns.Add("Nombre", "Nombre");
            dtgEmpleados.Columns.Add("Sueldo", "Sueldo");
            
            dtgEmpleados.Columns["Sueldo"].DefaultCellStyle.Format = "C";
            
            dtgEmpleados.ReadOnly = true;
            dtgEmpleados.AllowUserToAddRows = false;
            dtgEmpleados.AllowUserToDeleteRows = false;
            dtgEmpleados.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dtgEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpleados.MultiSelect = false;

            #if GenerarEmpleadosAleatorios
            // Declaración y creación de un objeto para números aleatorios
            Random rndNumeroAleatorio = new Random();
            // Definir una constante para la cantidad de empleados
            const int intCantidadEmpleados = 50;
            // Definir una constante para la longitud del nombre del empleado
            const int intLongitudNombre = 25;
            // Definir una constante para el sueldo máximo de un empleado
            const int intSueldoMaximo = 100000;
            for (int i = 0; i < intCantidadEmpleados; i++)
            {
                // Declaración y creación de un objeto local para cada empleado
                Empleado miEmpleado = new Empleado(rndNumeroAleatorio.Next(intCantidadEmpleados), Guid.NewGuid().ToString().Substring(0, intLongitudNombre), rndNumeroAleatorio.NextDouble() * intSueldoMaximo);
                // Generar de manera aleatoria los datos del empleado
                miEmpleado.Numero = rndNumeroAleatorio.Next(intCantidadEmpleados);
                miEmpleado.Nombre = Guid.NewGuid().ToString().Substring(0,intLongitudNombre);
                miEmpleado.Sueldo = rndNumeroAleatorio.NextDouble() * intSueldoMaximo;
                // Mostrar los datos del empleado en el dataGridView
                dtgEmpleados.Rows.Add(miEmpleado.Numero, miEmpleado.Nombre, miEmpleado.Sueldo);
            }
            #endif
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            unEmpleado = new Empleado(int.Parse(txtNumero.Text), txtNombre.Text, double.Parse(txtSueldo.Text));
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
