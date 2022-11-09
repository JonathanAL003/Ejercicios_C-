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

namespace ProyectoBaseDeDatos
{
    public partial class FormBDClientes : Form
    {
        // Cadena de Conexion
        const string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = proyecto";
        // Objeto de conexion a la base de datos
        static MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
        // Declaracion de objeto que prepara el query + la conexion con la base de datos
        static MySqlCommand commandDatabase;
        // Declaracion del ejecutor del query
        static MySqlDataReader myReader;

        public FormBDClientes()
        {
            InitializeComponent();
        }

        private void btnInicio5_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.formP.Show();
        }

        private void btnSalir6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormBDClientes_Load(object sender, EventArgs e)
        {
            dtgClientes.ColumnCount = 7;
            dtgClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            dtgClientes.Columns[0].Name = "idcliente";
            dtgClientes.Columns[0].HeaderText = "ID Cliente";
            dtgClientes.Columns[1].Name = "nombreconstructora";
            dtgClientes.Columns[1].HeaderText = "Nombre Constructora";
            dtgClientes.Columns[2].Name = "telefonoconstructora";
            dtgClientes.Columns[2].HeaderText = "Telefono Constructora";
            dtgClientes.Columns[3].Name = "correoelectronicoconstructora";
            dtgClientes.Columns[3].HeaderText = "Correo Electronico Constructora";
            dtgClientes.Columns[4].Name = "nombrecontactoconstructora";
            dtgClientes.Columns[4].HeaderText = "Nombre Contacto Constructora";
            dtgClientes.Columns[5].Name = "dirrecionconstructora";
            dtgClientes.Columns[5].HeaderText = "Dirrecion Constructora";
            dtgClientes.Columns[6].Name = "compras";
            dtgClientes.Columns[6].HeaderText = "Compras Realizadas";

            dtgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgClientes.MultiSelect = false;
            dtgClientes.ReadOnly = true;
            dtgClientes.AllowUserToAddRows = false;
            dtgClientes.AllowUserToDeleteRows = false;

            txtNombreConstructora.Enabled = true;
            txtTelefonoConstructora.Enabled = true;
            txtCorreoElectronicaConstructora.Enabled = true;
            txtNombreContacto.Enabled = true;
            txtDireccionConstructora.Enabled = true;
            txtId.Enabled = false;

            btnRegistrar2.Enabled = true;
            btnRegistrar2.Visible = true;
            btnActualizar2.Enabled = false;
            btnActualizar2.Visible = false;
            btnEliminar2.Enabled = false;
            btnEliminar2.Visible = false;

            btnPrepararActualizar.Enabled = false;

            //Listar clientes 
            ListarClientes();
        }
        
        private void GuardarCliente()
        {
            Cliente cliente = new Cliente(txtNombreConstructora.Text, txtTelefonoConstructora.Text, txtCorreoElectronicaConstructora.Text, txtNombreContacto.Text, txtDireccionConstructora.Text);

            string query = "INSERT INTO constructoras_clientes(`id_cliente`, `nombre_constructora`, `telefono_constructora`, `correoelectronico_constructora`, `nombrecontacto_constructora`, `direccion_constructora`, `compras`) VALUES (NULL, '" + txtNombreConstructora.Text + "', '" + txtTelefonoConstructora.Text + "', '" + txtCorreoElectronicaConstructora.Text + "', '" + txtNombreContacto.Text + "', '"  + txtDireccionConstructora.Text + "', 0 )";

            // Creacion de objeto con el query y la conexion
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion con la bd
                databaseConnection.Open();
                // Ejecutar el commandDatabase
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Cliente agragado satisfatoriamente a la base de datos", "Accion completada satisfactoriamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Cerrar conexion a bd
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarClientes()
        {
            dtgClientes.Rows.Clear();

            // Query para consultar todos los campos y registros de la tabla user
            string query = "SELECT * FROM constructoras_clientes";

            // Creacion de objeto con query y conexion a bd
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion conn bd
                databaseConnection.Open();
                // Ejecutar query y guardar el resultado en myReader
                myReader = commandDatabase.ExecuteReader();

                // Verificacion de que myReader tiene renglones con contenido
                if (myReader.HasRows)
                {
                    // Mientras pueda leer un siguiente reenglon...
                    while (myReader.Read())
                    {
                        // Creacion de objeto por cada registro devuelto
                        Cliente cliente = new Cliente(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetString(5), myReader.GetInt32(6));

                        // Insertar objeto a DatagridView
                        dtgClientes.Rows.Add(cliente.IdCliente, cliente.NombreConstructora, cliente.TelefonoConstructora, cliente.CorreoElectronicoConstructora, cliente.NombreContactoConstructora, cliente.DireccionConstructora, cliente.Compras);
                    }
                }

                databaseConnection.Close();

                dtgClientes.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCliente(Cliente cliente)
        {
            string cadena = "UPDATE CLIENTES SET Nombre1='"{cliente.Nombre1}',`telefono_constructora`= '{cliente.TelefonoConstructora}',`correoelectronico_constructora`= '{cliente.CorreoElectronicoConstructora}',`nombrecontacto_constructora`= '{cliente.NombreContactoConstructora}',`direccion_constructora`= '{cliente.DireccionConstructora}' WHERE `id_cliente` = '{txtId.Text}'";

            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Cliente actualizado satisfatoriamente \rID: " + int.Parse(txtId.Text), "Accion completada satisfactoriamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizado satisfactoriamente
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarCliente()
        {
            string query = $"DELETE FROM `constructoras_clientes` WHERE `id_cliente` = '{txtId.Text}'";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                DialogResult result = MessageBox.Show("Desea eliminar el cliente con ID: " + int.Parse(txtId.Text), "Confirmar eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        myReader = commandDatabase.ExecuteReader();
                        // Eliminado satisfactoriamente
                        databaseConnection.Close();
                        MessageBox.Show("El cliente con el ID: " + int.Parse(txtId.Text) + " ha sido eliminado satisfactoriamente", "Confirmando eliminacion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DialogResult.No:
                        databaseConnection.Close();
                        MessageBox.Show("El cliente no ha sido eliminado", "Eliminacion no confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            foreach (Control x in grpDatosClientes.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void ListarClientesActualizar()
        {
            // Query para consultar todos los campos y registros de la tabla
            string query = $"SELECT * FROM `constructoras_clientes` WHERE `id_cliente` = '{txtId.Text}'";

            // Creacion de objeto con query y conexion a bd
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion conn bd
                databaseConnection.Open();
                // Ejecutar query y guardar el resultado en myReader
                myReader = commandDatabase.ExecuteReader();

                // Verificacion de que myReader tiene renglones con contenido
                if (myReader.HasRows)
                {
                    // Mientras pueda leer un siguiente reenglon...
                    while (myReader.Read())
                    {
                        // Creacion de objeto por cada registro devuelto
                        Cliente cliente = new Cliente(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetString(5), myReader.GetInt32(6));

                        txtNombreConstructora.Text = myReader.GetString(1);
                        txtTelefonoConstructora.Text = myReader.GetString(2);
                        txtCorreoElectronicaConstructora.Text = myReader.GetString(3);
                        txtNombreContacto.Text = myReader.GetString(4);
                        txtDireccionConstructora.Text = myReader.GetString(5);
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radRegistrar2_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            txtNombreConstructora.Enabled = true;
            txtTelefonoConstructora.Enabled = true;
            txtCorreoElectronicaConstructora.Enabled = true;
            txtNombreContacto.Enabled = true;
            txtDireccionConstructora.Enabled = true;
            txtId.Enabled = false;

            btnRegistrar2.Enabled = true;
            btnRegistrar2.Visible = true;
            btnActualizar2.Enabled = false;
            btnActualizar2.Visible = false;
            btnEliminar2.Enabled = false;
            btnEliminar2.Visible = false;

            btnPrepararActualizar.Enabled = false;
        }

        private void radActualizar2_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            txtNombreConstructora.Enabled = false;
            txtTelefonoConstructora.Enabled = false;
            txtCorreoElectronicaConstructora.Enabled = false;
            txtNombreContacto.Enabled = false;
            txtDireccionConstructora.Enabled = false;
            txtId.Enabled = true;

            btnRegistrar2.Enabled = false;
            btnRegistrar2.Visible = false;           
            btnActualizar2.Visible = true;
            btnEliminar2.Enabled = false;
            btnEliminar2.Visible = false;

            btnPrepararActualizar.Enabled = true;
        }

        private void radEliminar2_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            txtNombreConstructora.Enabled = false;
            txtTelefonoConstructora.Enabled = false;
            txtCorreoElectronicaConstructora.Enabled = false;
            txtNombreContacto.Enabled = false;
            txtDireccionConstructora.Enabled = false;
            txtId.Enabled = true;

            btnRegistrar2.Enabled = false;
            btnRegistrar2.Visible = false;
            btnActualizar2.Enabled = false;
            btnActualizar2.Visible = false;
            btnEliminar2.Enabled = true;
            btnEliminar2.Visible = true;

            btnPrepararActualizar.Enabled = false;
        }    

        private void txtTelefonoConstructora_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelefonoConstructora.Text,"[^0-9]"))
            {
                MessageBox.Show("Ingrese solo numeros");
                txtTelefonoConstructora.Text = txtTelefonoConstructora.Text.Remove(txtTelefonoConstructora.Text.Length - 1);
            }
        }

        private void btnPrepararActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("No deje vacio el ID, porfavor escriba un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListarClientesActualizar();
                btnActualizar2.Enabled = true;

                txtNombreConstructora.Enabled = true;
                txtTelefonoConstructora.Enabled = true;
                txtCorreoElectronicaConstructora.Enabled = true;
                txtNombreContacto.Enabled = true;
                txtDireccionConstructora.Enabled = true;
            }            
        }

        private void btnRegistrar2_Click(object sender, EventArgs e)
        {
            if (txtNombreConstructora.Text == "" || txtTelefonoConstructora.Text == "" || txtCorreoElectronicaConstructora.Text == "" || txtNombreContacto.Text == "" || txtDireccionConstructora.Text == "")
            {
                MessageBox.Show("No deje campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GuardarCliente();
                ListarClientes();
                Limpiar();
            }        
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            if (txtNombreConstructora.Text == "" || txtTelefonoConstructora.Text == "" || txtCorreoElectronicaConstructora.Text == "" || txtNombreContacto.Text == "" || txtDireccionConstructora.Text == "")
            {
                MessageBox.Show("No deje campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cliente = new Cliente(txtNombreConstructora.Text, txtTelefonoConstructora.Text, txtCorreoElectronicaConstructora.Text, txtNombreContacto.Text, txtDireccionConstructora.Text);
                ActualizarCliente(cliente);
                ListarClientes();
                Limpiar();
                btnActualizar2.Enabled = false;

                txtNombreConstructora.Enabled = false;
                txtTelefonoConstructora.Enabled = false;
                txtCorreoElectronicaConstructora.Enabled = false;
                txtNombreContacto.Enabled = false;
                txtDireccionConstructora.Enabled = false;
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("No deje vacio el ID, porfavor escriba un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EliminarCliente();
                ListarClientes();
            }           
        }
    }
}
