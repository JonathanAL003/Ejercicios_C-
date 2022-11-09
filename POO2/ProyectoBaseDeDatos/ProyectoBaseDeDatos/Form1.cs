using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //LIBIRERIA PARA CONECTAR BASE DE DATOS SQL

namespace ProyectoBaseDeDatos
{
    public partial class Form1 : Form
    {
        // Cadena de Conexion
        const string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = proyecto";
        // Objeto de conexion a la base de datos
        static MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
        // Declaracion de objeto que prepara el query + la conexion con la base de datos
        static MySqlCommand commandDatabase;
        // Declaracion del ejecutor del query
        static MySqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();

            // Verificacion de conexion a la bd
            try
            {
                // Establecer conexion
                databaseConnection.Open();

                MessageBox.Show("Conexion a base de datos establecida con exito.","Conexion satisfactoria", MessageBoxButtons.OK,MessageBoxIcon.Information);

                // Cerrar conexion
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error de conexion a la base de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnLoginInventario_Click(object sender, EventArgs e)
        {
            FormLoginInventario formLoginInv = new FormLoginInventario();
            formLoginInv.Show();

            this.Hide();
        }

        private void btnInterfazCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCl = new FormCliente();
            formCl.Show();

            this.Hide();
        }

        private void btnLoginBDClientes_Click(object sender, EventArgs e)
        {
            FormLoginBDClientes formLoginBDCl = new FormLoginBDClientes();
            formLoginBDCl.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
