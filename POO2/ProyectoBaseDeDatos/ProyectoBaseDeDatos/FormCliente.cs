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
    public partial class FormCliente : Form
    {
        // Cadena de Conexion
        const string ConnectionString = "datasource = localhost; port= 3306; username = root; password =;database = proyecto";
        // Objeto de conexion a la base de datos
        static MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
        // Declaracion de objeto que prepara el query + la conexion con la base de datos
        static MySqlCommand commandDatabase;
        // Declaracion del ejecutor del query
        static MySqlDataReader myReader;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            dtgMateriales.ColumnCount = 4;
            dtgMateriales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dtgMateriales.Columns[0].Name = "id";
            dtgMateriales.Columns[0].HeaderText = "ID";
            dtgMateriales.Columns[1].Name = "nombrematerial";
            dtgMateriales.Columns[1].HeaderText = "Nombre";
            dtgMateriales.Columns[2].Name = "cantidadmaterial";
            dtgMateriales.Columns[2].HeaderText = "Cantidad";
            dtgMateriales.Columns[3].Name = "precioventa";
            dtgMateriales.Columns[3].HeaderText = "Precio Venta";
            dtgMateriales.Columns["precioventa"].DefaultCellStyle.Format = "C";
            dtgMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMateriales.MultiSelect = false;
            dtgMateriales.ReadOnly = true;
            dtgMateriales.AllowUserToAddRows = false;
            dtgMateriales.AllowUserToDeleteRows = false;

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

            ListarMaterial();
            ListarClientes();

            try
            {
               string selectQuery = "SELECT * FROM constructoras_clientes";
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(selectQuery, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                myReader = commandDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    cboIdCliente.Items.Add(myReader.GetString("id_cliente"));
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string selectQuery = "SELECT * FROM material";
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(selectQuery, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                myReader = commandDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    cboIdMaterial.Items.Add(myReader.GetString("id_material"));
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cboIdCliente.Enabled = false;
            txtExistencias.Visible = false;
            txtPrecioProducto.Visible = false;
            txtCompras.Visible = false;
            txtIdCliente.Visible = false;
        }

        private void ListarMaterial()
        {
            dtgMateriales.Rows.Clear();

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
                        dtgMateriales.Rows.Add(material.IdMaterial, material.NombreMaterial, material.CantidadMaterial, material.PrecioVentaMaterial);
                    }
                }

                databaseConnection.Close();
                dtgMateriales.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnInicio3_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.formP.Show();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkConstructora_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConstructora.Checked ==  true)
            {
                cboIdCliente.Enabled = true;
            }
            if (chkConstructora.Checked == false)
            {
                cboIdCliente.Enabled = false;
                cboIdCliente.SelectedIndex = -1;
                txtNombreConstructora.Clear();
            }
        }

        private void cboIdMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Query para consultar todos los campos y registros de la tabla
            string query = $"SELECT * FROM `material` WHERE `id_material` = '{cboIdMaterial.Text}'";

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
                        txtExistencias.Text = Convert.ToString(myReader.GetDouble(2));
                        txtPrecioProducto.Text = Convert.ToString(myReader.GetDouble(3));
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarCompra(double z)
        {
            string query = $"UPDATE `material` SET `cantidad_material`= '{z}' WHERE `id_material` = '{cboIdMaterial.Text}'";

            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                myReader = commandDatabase.ExecuteReader();
                // Actualizado satisfactoriamente
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarComprasCliente(int a)
        {
            string query = $"UPDATE `constructoras_clientes` SET `compras`= '{a}' WHERE `id_cliente` = '{txtIdCliente.Text}'";

            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                // Actualizado satisfactoriamente
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        double z,SubTotal,TotalSinIva,Total,IVA;

        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Query para consultar todos los campos y registros de la tabla user
            string query = $"SELECT * FROM `constructoras_clientes` WHERE `id_cliente` = '{cboIdCliente.Text}'";

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

                        txtIdCliente.Text = Convert.ToString(myReader.GetInt32(0));
                        txtNombreConstructora.Text = myReader.GetString(1);
                        txtCompras.Text = Convert.ToString(myReader.GetInt32(6));
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                double x, y, w;
                x = double.Parse(txtExistencias.Text);
                y = double.Parse(txtCantidadCompra.Text);
                w = double.Parse(txtPrecioProducto.Text);
                z = x - y;
                if (z < 0)
                {
                    MessageBox.Show("No se cuenta con las existencias que requiere del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (z >= 0)
                {
                    AgregarCompra(z);
                    SubTotal = w * y;
                    TotalSinIva = TotalSinIva + SubTotal;
                    IVA = TotalSinIva * .16;
                    MessageBox.Show("Articulado agragado a la compra", "Articulo agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSubtotal.Text = Convert.ToString(TotalSinIva);
                    txtIva.Text = Convert.ToString(IVA);

                    ListarMaterial();
                    txtCantidadCompra.Clear();
                    cboIdMaterial.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No deje campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboIdMaterial.Text = "";
                txtCantidadCompra.Text = "";
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (txtSubtotal.Text == "")
            {
                MessageBox.Show("Usted no ha seleccionado nada para comprar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (chkConstructora.Checked == false)
                {
                    Total = TotalSinIva + IVA;
                    MessageBox.Show("El total de su compra es de: $" + Total + "\r\rGracias por su compra\rFecha de compra: " + dtmFechaActual.Value.Date, "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubtotal.Clear();
                    txtIva.Clear();
                    SubTotal = 0;
                    TotalSinIva = 0;
                    IVA = 0;
                    Total = 0;
                    txtNombreMaterial.Clear();
                }
                if (chkConstructora.Checked == true)
                {
                    int a, c;
                    double Descuento;
                    c = int.Parse(txtCompras.Text);
                    if (c >= 10 && c < 20)
                    {
                        Total = TotalSinIva + IVA;
                        Descuento = Total * .05;
                        Total = Total - Descuento;
                        MessageBox.Show("Obtuvo un descuento del 5% por su preferencia: -$" + Descuento + "\rEl total de su compra es de: $" + Total + "\r\rGracias por su compra " + txtNombreConstructora.Text + "\rFecha compra: " + dtmFechaActual.Value.Date, "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSubtotal.Clear();
                        txtIva.Clear();
                        SubTotal = 0;
                        TotalSinIva = 0;
                        IVA = 0;
                        Total = 0;
                        a = c + 1;
                        ActualizarComprasCliente(a);
                        a = 0;
                        ListarClientes();
                    }
                    if (c >= 20)
                    {
                        Total = TotalSinIva + IVA;
                        Descuento = Total * .10;
                        Total = Total - Descuento;
                        MessageBox.Show("Obtuvo un descuento del 10% por su preferencia: -$" + Descuento + "\rEl total de su compra es de: $" + Total + "\r\rGracias por su compra " + txtNombreConstructora.Text + "\rFecha compra: " + dtmFechaActual.Value.Date, "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSubtotal.Clear();
                        txtIva.Clear();
                        SubTotal = 0;
                        TotalSinIva = 0;
                        IVA = 0;
                        Total = 0;
                        a = c + 1;
                        ActualizarComprasCliente(a);
                        a = 0;
                        ListarClientes();
                    }
                    if (c < 10)
                    {
                        Total = TotalSinIva + IVA;
                        MessageBox.Show("El total de su compra es de: $" + Total + "\r\rGracias por su compra " + txtNombreConstructora.Text + "\rFecha compra: " + dtmFechaActual.Value.Date, "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSubtotal.Clear();
                        txtIva.Clear();
                        SubTotal = 0;
                        TotalSinIva = 0;
                        IVA = 0;
                        Total = 0;
                        a = c + 1;
                        ActualizarComprasCliente(a);
                        a = 0;
                        ListarClientes();
                    }
                    chkConstructora.Checked = false;
                    cboIdCliente.SelectedIndex = -1;
                    txtNombreConstructora.Clear();
                    txtNombreMaterial.Clear();
                }
            }
                        
        }
    }
}
