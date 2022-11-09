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
    public partial class FormInventario : Form
    {
        // Cadena de Conexion
        const string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = proyecto";
        // Objeto de conexion a la base de datos
        static MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
        // Declaracion de objeto que prepara el query + la conexion con la base de datos
        static MySqlCommand commandDatabase;
        // Declaracion del ejecutor del query
        static MySqlDataReader myReader;

        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnInicio2_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.formP.Show();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            dtgMaterial.ColumnCount = 4;
            dtgMaterial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            dtgMaterial.Columns[0].Name = "id";
            dtgMaterial.Columns[0].HeaderText = "ID";
            dtgMaterial.Columns[1].Name = "nombrematerial";
            dtgMaterial.Columns[1].HeaderText = "Nombre";
            dtgMaterial.Columns[2].Name = "cantidadmaterial";
            dtgMaterial.Columns[2].HeaderText = "Cantidad";
            dtgMaterial.Columns[3].Name = "precioventa";
            dtgMaterial.Columns[3].HeaderText = "Precio Venta";

            dtgMaterial.Columns["precioventa"].DefaultCellStyle.Format = "C";

            dtgMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMaterial.MultiSelect = false;
            dtgMaterial.ReadOnly = true;
            dtgMaterial.AllowUserToAddRows = false;
            dtgMaterial.AllowUserToDeleteRows = false;

            txtNombreMaterial.Enabled = true;
            txtCantidadMaterial.Enabled = true;
            txtPrecioVenta.Enabled = true;
            txtId.Enabled = false;

            btnRegistrar.Enabled = true;
            btnRegistrar.Visible = true;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;

            btnPrepararActualizar.Enabled = false;

            //Listar materiales 
            ListarMaterial();
        }

        private void GuardarMaterial()
        {
            Material material = new Material(txtNombreMaterial.Text, double.Parse(txtCantidadMaterial.Text), double.Parse(txtPrecioVenta.Text));
            
            string query = "INSERT INTO material(`id_material`, `nombre_material`, `cantidad_material`, `precioventa_material`) VALUES (NULL, '"+txtNombreMaterial.Text+ "', '" + txtCantidadMaterial.Text + "', '" + txtPrecioVenta.Text + "')"; 

            // Creacion de objeto con el query y la conexion
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                // Establecer conexion con la bd
                databaseConnection.Open();
                // Ejecutar el commandDatabase
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Material agragado satisfatoriamente a la base de datos", "Accion completada satisfactoriamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Cerrar conexion a bd
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarMaterial()
        {
            dtgMaterial.Rows.Clear();

            // Query para consultar todos los campos y registros de la tabla
            string query = "SELECT * FROM material";

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
                        Material material = new Material(myReader.GetInt32(0), myReader.GetString(1), myReader.GetDouble(2), myReader.GetDouble(3));

                        // Insertar objeto a DatagridView
                        dtgMaterial.Rows.Add(material.IdMaterial, material.NombreMaterial, material.CantidadMaterial, material.PrecioVentaMaterial);
                    }
                }

                databaseConnection.Close();
                dtgMaterial.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ListarMaterialActualizar()
        {
            // Query para consultar todos los campos y registros de la tabla
            string query = $"SELECT * FROM `material` WHERE `id_material` = '{txtId.Text}'";

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
                        Material material = new Material(myReader.GetInt32(0), myReader.GetString(1), myReader.GetDouble(2), myReader.GetDouble(3));

                        txtNombreMaterial.Text = myReader.GetString(1);
                        txtCantidadMaterial.Text = Convert.ToString(myReader.GetDouble(2));
                        txtPrecioVenta.Text = Convert.ToString(myReader.GetDouble(3));
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMaterial(Material material)
        {
            string query = $"UPDATE `material` SET `cantidad_material`= '{material.CantidadMaterial}',`precioventa_material`= '{double.Parse(txtPrecioVenta.Text)}' WHERE `id_material` = '{txtId.Text}'";
            
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Material actualizado satisfatoriamente \rID: " + int.Parse(txtId.Text), "Accion completada satisfactoriamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizado satisfactoriamente
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void EliminarMaterial()
        {
            string query = $"DELETE FROM `material` WHERE `id_material` = '{txtId.Text}'";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                DialogResult result = MessageBox.Show("Desea eliminar el material con ID: " + int.Parse(txtId.Text), "Confirmar eliminar Material", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        myReader = commandDatabase.ExecuteReader();
                        // Eliminado satisfactoriamente
                        databaseConnection.Close();
                        MessageBox.Show("El material con el ID: " + int.Parse(txtId.Text) + " ha sido eliminado satisfactoriamente", "Confirmando eliminacion de Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case DialogResult.No:
                        databaseConnection.Close();
                        MessageBox.Show("El material no ha sido eliminado", "Eliminacion no confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        

        private void radRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            txtNombreMaterial.Enabled = true;
            txtCantidadMaterial.Enabled = true;
            txtPrecioVenta.Enabled = true;
            txtId.Enabled = false;

            btnRegistrar.Enabled = true;
            btnRegistrar.Visible = true;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;

            btnPrepararActualizar.Enabled = false;
        }

        private void radActualizar_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            txtNombreMaterial.Enabled = false;
            txtCantidadMaterial.Enabled = false;
            txtPrecioVenta.Enabled = false;
            txtId.Enabled = true;

            btnRegistrar.Enabled = false;
            btnRegistrar.Visible = false;
            btnActualizar.Visible = true;
            btnEliminar.Enabled = false;
            btnEliminar.Visible = false;

            btnPrepararActualizar.Enabled = true;
        }

        private void radEliminar_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            txtNombreMaterial.Enabled = false;
            txtCantidadMaterial.Enabled = false;
            txtPrecioVenta.Enabled = false;
            txtId.Enabled = true;

            btnRegistrar.Enabled = false;
            btnRegistrar.Visible = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;
            btnEliminar.Enabled = true;
            btnEliminar.Visible = true;

            btnPrepararActualizar.Enabled = false;
        }

        private void btnPrepararActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("No deje vacio el ID, porfavor escriba un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListarMaterialActualizar();
                btnActualizar.Enabled = true;
                txtCantidadMaterial.Enabled = true;
                txtPrecioVenta.Enabled = true;
            }            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                double z;
                z = double.Parse(txtCantidadMaterial.Text);
                if (z < 0)
                {
                    MessageBox.Show("No puede haber existencias negativas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidadMaterial.Clear();
                    txtCantidadMaterial.Focus();
                }
                else
                {
                    GuardarMaterial();
                    ListarMaterial();
                    Limpiar();
                    z = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No deje campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreMaterial.Text = "";
                txtCantidadMaterial.Text = "";
                txtPrecioVenta.Text = "";
            }            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                double x, y;
                x = double.Parse(txtCantidadMaterial.Text);
                y = double.Parse(txtPrecioVenta.Text);
                if (x < 0 || y <= 0)
                {
                    MessageBox.Show("No puede haber inventario negativo, o precio $0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x = 0;
                    y = 0;
                }
                else
                {
                    Material material = new Material(double.Parse(txtCantidadMaterial.Text), double.Parse(txtPrecioVenta.Text));
                    ActualizarMaterial(material);
                    ListarMaterial();
                    Limpiar();
                    btnActualizar.Enabled = false;
                    txtCantidadMaterial.Enabled = false;
                    txtPrecioVenta.Enabled = false;
                    x = 0;
                    y = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No deje los campos vacios","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCantidadMaterial.Text = "";
                txtPrecioVenta.Text = "";
            }
                  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {               
            if (txtId.Text == "")
            {
                MessageBox.Show("No deje vacio el ID, porfavor escriba un ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EliminarMaterial();
                ListarMaterial();
            }
 
        }

        public void Limpiar()
        {
            foreach (Control x in grpDatosMaterial.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
        }
    }
}
