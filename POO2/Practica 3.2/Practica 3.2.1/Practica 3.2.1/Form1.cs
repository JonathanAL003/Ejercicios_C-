#define DatosPrueba

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._2._1
{
    public partial class Form1 : Form
    {
        Empresa miEmpresa = new Empresa();

        public Form1()
        {
            InitializeComponent();

            dtgDepartamentos.Columns.Add("Numero", "Numero");
            dtgDepartamentos.Columns.Add("Nombre", "Nombre");
            dtgDepartamentos.Columns.Add("Jefe", "Jefe");

            dtgDepartamentos.ReadOnly = true;
            dtgDepartamentos.AllowUserToAddRows = false;
            dtgDepartamentos.AllowUserToDeleteRows = false;
            dtgDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

#if DatosPrueba
            Empresa miEmpresa = new Empresa();
            miEmpresa.RFC = "ABCD-901214-FGH";
            miEmpresa.RazonSocial = "Empresa S.A de C.V";
            miEmpresa.Gerente = "ASDF";

           Random rndNumeroAleatorio = new Random();
           const int intCantidadMaximaDepartamentos = 5;
           const int intLongitudNombre = 25;
           const int intLongitudJefe = 25;
           for (int i = 0; i < intCantidadMaximaDepartamentos; i++)
           {
                Departamento unDepartamento = new Departamento();
                unDepartamento.Numero = rndNumeroAleatorio.Next(intCantidadMaximaDepartamentos);
                unDepartamento.Nombre = Guid.NewGuid().ToString().Substring(0, intLongitudNombre);
                unDepartamento.Jefe = Guid.NewGuid().ToString().Substring(0, intLongitudJefe);
                miEmpresa.InsertarDepartamento(unDepartamento);
                dtgDepartamentos.Rows.Add(unDepartamento.Numero, unDepartamento.Nombre, unDepartamento.Jefe);
            }           
#endif
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            miEmpresa.RFC = txtRFC.Text;
            miEmpresa.RazonSocial = txtRazonSocial.Text;
            miEmpresa.Gerente = txtGerente.Text;

            MessageBox.Show("Empresa capturada correctamente.");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Departamento unDepartamento = new Departamento();
            unDepartamento.Numero = int.Parse(txtNum.Text);
            unDepartamento.Nombre = txtNombre.Text;
            unDepartamento.Jefe = txtJefe.Text;

            miEmpresa.InsertarDepartamento(unDepartamento);
            dtgDepartamentos.Rows.Add(unDepartamento.Numero, unDepartamento.Nombre, unDepartamento.Jefe);

            MessageBox.Show("Nuevo departamento creado en la empresa");

            foreach (Control control in grpDepartamento.Controls)
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
    }
}
