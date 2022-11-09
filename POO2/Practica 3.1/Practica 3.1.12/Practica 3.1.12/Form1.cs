using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1._12
{
    public partial class Form1 : Form
    {
        Persona unaPersona = new Persona();
        Empleado unEmpleado = new Empleado();
        Estudiante unEstudiante =new Estudiante();
        Administrador unAdministrador = new Administrador();
        Profesor unProfesor = new Profesor();

        public Form1()
        {
            InitializeComponent();
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtHorario.Enabled = true;
            txtJefe.Enabled = false;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtPuesto.Enabled = false;
            txtCarrera.Enabled = false;
        }

        private void lblPuesto_Click(object sender, EventArgs e)
        {

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

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radPersona.Checked)
            {
                unaPersona.Nombre = txtNombre.Text;
                unaPersona.Domicilio = txtDomicilio.Text;
                unaPersona.Horario = txtHorario.Text;
            }
            if (radEmpleado.Checked)
            {
                unEmpleado.Nombre = txtNombre.Text;
                unEmpleado.Domicilio = txtDomicilio.Text;
                unEmpleado.Horario = txtHorario.Text;
                unEmpleado.Jefe = txtJefe.Text;
            }
            if (radEstudiante.Checked)
            {
                unEstudiante.Nombre = txtNombre.Text;
                unEstudiante.Domicilio = txtDomicilio.Text;
                unEstudiante.Horario = txtHorario.Text;
                unEstudiante.Grado = Convert.ToChar(txtGrado.Text);
                unEstudiante.Grupo = Convert.ToChar(txtGrupo.Text);
            }
            if (radAdministrador.Checked)
            {
                unAdministrador.Nombre = txtNombre.Text;
                unAdministrador.Domicilio = txtDomicilio.Text;
                unAdministrador.Horario = txtHorario.Text;
                unAdministrador.Jefe = txtJefe.Text;
                unAdministrador.Puesto = txtPuesto.Text;
            }
            if (radProfesor.Checked)
            {
                unProfesor.Nombre = txtNombre.Text;
                unProfesor.Domicilio = txtDomicilio.Text;
                unProfesor.Horario = txtHorario.Text;
                unProfesor.Jefe = txtJefe.Text;
                unProfesor.Carrera = txtCarrera.Text;
            }
            MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radPersona.Checked)
            {
                unaPersona.Asistir();
                MessageBox.Show("Datos\nNombre: " + unaPersona.Nombre + "\nDomicilio: " + unaPersona.Domicilio + "\nHorario: " + unaPersona.Horario + "\n" + unaPersona.a , "Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radEmpleado.Checked)
            {
                unEmpleado.Asistir();
                unEmpleado.Cobrar();
                MessageBox.Show("Datos\nNombre: " + unEmpleado.Nombre + "\nDomicilio: " + unEmpleado.Domicilio + "\nHorario: " + unEmpleado.Horario + "\nJefe: " + unEmpleado.Jefe + "\n" + unEmpleado.a + "\n" + unEmpleado.b, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radEstudiante.Checked)
            {
                unEstudiante.Asistir();
                unEstudiante.Estudiar();
                MessageBox.Show("Datos\nNombre: " + unEstudiante.Nombre + "\nDomicilio: " + unEstudiante.Domicilio + "\nHorario: " + unEstudiante.Horario + "\nGrado: " + unEstudiante.Grado + "\nGrupo: " + unEstudiante.Grupo + "\n" + unEstudiante.a + "\n" + unEstudiante.c, "Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radAdministrador.Checked)
            {
                unAdministrador.Asistir();
                unAdministrador.Cobrar();
                unAdministrador.Administrar();
                MessageBox.Show("Datos\nNombre: " + unAdministrador.Nombre + "\nDomicilio: " + unAdministrador.Domicilio + "\nHorario: " + unAdministrador.Horario + "\nJefe: " + unAdministrador.Jefe + "\nPuesto: " + unAdministrador.Puesto + "\n" + unAdministrador.a + "\n" + unAdministrador.b + "\n" + unAdministrador.d, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radProfesor.Checked)
            {
                unProfesor.Asistir();
                unProfesor.Cobrar();
                unProfesor.Enseña();
                MessageBox.Show("Datos\nNombre: " + unProfesor.Nombre + "\nDomicilio: " + unProfesor.Domicilio + "\nHorario: " + unProfesor.Horario + "\nJefe: " + unProfesor.Jefe + "\nCarrera: " + unProfesor.Carrera + "\n" + unProfesor.a + "\n" + unProfesor.b + "\n" + unProfesor.e, "Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radProfesor_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtHorario.Enabled = true;
            txtJefe.Enabled = true;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtPuesto.Enabled = false;
            txtCarrera.Enabled = true;
        }

        private void radPersona_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtHorario.Enabled = true;
            txtJefe.Enabled = false;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtPuesto.Enabled = false;
            txtCarrera.Enabled = false;
        }

        private void radEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtHorario.Enabled = true;
            txtJefe.Enabled = true;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtPuesto.Enabled = false;
            txtCarrera.Enabled = false;
        }

        private void radEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtHorario.Enabled = true;
            txtJefe.Enabled = false;
            txtGrado.Enabled = true;
            txtGrupo.Enabled = true;
            txtPuesto.Enabled = false;
            txtCarrera.Enabled = false;
        }

        private void radAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtHorario.Enabled = true;
            txtJefe.Enabled = true;
            txtGrado.Enabled = false;
            txtGrupo.Enabled = false;
            txtPuesto.Enabled = true;
            txtCarrera.Enabled = false;
        }
    }
}
