using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Unidad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dtgChip.Columns.Add("Nombre", "Nombre");
            dtgChip.Columns.Add("Unidad de medida", "Unidad de medida");

            dtgDispositivos.Columns.Add("Cantidad", "Cantidad");
            dtgDispositivos.Columns.Add("Calorias por porción", "Calorias por porción");

            dtgChip.ReadOnly = true;
            dtgChip.AllowUserToAddRows = false;
            dtgChip.AllowUserToDeleteRows = false;
            dtgChip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgDispositivos.ReadOnly = true;
            dtgDispositivos.AllowUserToAddRows = false;
            dtgDispositivos.AllowUserToDeleteRows = false;
            dtgDispositivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            iPhone uniPhone = new iPhone();
            uniPhone.Ram = int.Parse(txtRam.Text);
            uniPhone.PrecioProducto = double.Parse(txtPrecioProducto.Text);
            uniPhone.SO = "iOS";
            if (radSi.Checked)
            {
                uniPhone.HuellaDactilar = "Si";
            }
            if (radNo.Checked)
            {
                uniPhone.HuellaDactilar = "NO";
            }
            uniPhone.CantidadCamaras = int.Parse(txtCantidadCamaras.Text);
            uniPhone.TipoPuerto = "lithgning";

            lstiPhone.Items.Add(uniPhone);
            MessageBox.Show("iPhone capturado correctamente");

            foreach (Control control in grpProducto.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        iPhone SeleccionariPhone()
        {
            iPhone iPhoneSelected = new iPhone();
            iPhoneSelected = (iPhone)lstiPhone.SelectedItem;
            if (iPhoneSelected is null)
            {
                MessageBox.Show("Debe seleccionar un iPhone de la lista");
            }
            return iPhoneSelected;
        }

        void MostrarChip(iPhone c)
        {
            dtgChip.Rows.Clear();
            //foreach (Chip unChip in c)
            {
                //dtgChip.Rows.Add(unChip.NombreChip, unChip.Capacidad);
            }
        }

        void MostrarDispositivos(iPhone d)
        {
            dtgDispositivos.Rows.Clear();
            foreach (Dispositivo unDispositivo in d)
            {
                dtgDispositivos.Rows.Add(unDispositivo.NombreDispositivo, unDispositivo.PrecioDispositivo);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            iPhone iPhoneSelected = SeleccionariPhone();

            Chip unChip = new Chip();
            unChip.NombreChip = txtNombreChip.Text;
            unChip.Capacidad = double.Parse(txtCapacidad.Text);
            
            iPhoneSelected.InsertarChip(unChip);

            MostrarChip(iPhoneSelected);

            MessageBox.Show("Chip agragado");

            foreach (Control control in grpChip.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            iPhone iPhoneSelected = SeleccionariPhone();

            Dispositivo unDispositivo = new Dispositivo();
            unDispositivo.NombreDispositivo = txtNombreDispositivo.Text;
            unDispositivo.PrecioDispositivo = double.Parse(txtPrecioDispositivo.Text);
            
            iPhoneSelected.AgregarDispositivo(unDispositivo);

            MostrarDispositivos(iPhoneSelected);

            MessageBox.Show("Nuevo dispositivo agragado");

            foreach (Control control in grpDispositivos.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstiPhone_Click(object sender, EventArgs e)
        {
            iPhone iPhoneSelected = new iPhone();
            iPhoneSelected = (iPhone)lstiPhone.SelectedItem;
            if (iPhoneSelected is null)
            {
                MessageBox.Show("Debe seleccionar un iPhone de la lista");
            }
            MostrarChip(iPhoneSelected);
            MostrarDispositivos(iPhoneSelected);
        }
    }
}
