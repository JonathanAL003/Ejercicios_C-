using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBaseDeDatos
{
    public partial class FormLoginBDClientes : Form
    {
        public FormLoginBDClientes()
        {
            InitializeComponent();
        }

        private void btnLoginBDClientesIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario2.Text == "admin" && txtContraseña2.Text == "1234")
            {
                MessageBox.Show("Usuario y contraseña correctos", "Inicio de sesion satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

                FormBDClientes formBDClie = new FormBDClientes();
                formBDClie.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        public void Limpiar()
        {
            txtUsuario2.Clear();
            txtContraseña2.Clear();
        }

        private void btnInicio4_Click(object sender, EventArgs e)
        {           
            this.Close();

            Program.formP.Show();
        }

        private void btnSalir5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
