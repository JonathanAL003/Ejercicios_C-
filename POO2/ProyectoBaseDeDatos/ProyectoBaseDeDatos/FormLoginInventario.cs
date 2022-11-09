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
    public partial class FormLoginInventario : Form
    {
        public FormLoginInventario()
        {
            InitializeComponent();
        }

        private void btnLoginInventarioIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario1.Text == "admin")
            {
                if (txtContraseña1.Text == "1234")
                {
                    MessageBox.Show("Usuario y contraseña correctos", "Inicio de sesion satisfactorio", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Limpiar();

                    FormInventario formInv = new FormInventario();
                    formInv.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }

        }

        public void Limpiar()
        {
            txtUsuario1.Clear();
            txtContraseña1.Clear();
        }

        private void btnInicio1_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.formP.Show();
        }

        private void txtContraseña1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
