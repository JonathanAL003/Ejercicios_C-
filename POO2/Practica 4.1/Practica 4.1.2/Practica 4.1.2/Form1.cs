using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._1._2
{
    public partial class Form1 : Form
    {
        EmpleadoSinHorasExtras unEmpleadoSinHorasExtras = new EmpleadoSinHorasExtras();
        EmpleadoConHorasDobles unEmpleadoConHorasDobles = new EmpleadoConHorasDobles();
        EmpleadoConHorasTriples unEmpleadoConHorasTriples = new EmpleadoConHorasTriples();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            try
            {
                x = int.Parse(txtHorasTrabajadas.Text);
                y = double.Parse(txtSalarioPorHora.Text);
                if (x <= 0)
                {
                    throw new Exception("Horas invalidas, por favor ingrese un numero valido(No 0 o negativo)");

                }
                if (y <= 0)
                {
                    throw new Exception("Salario invalido, por favor ingrese un salario valido(No 0 o negativo)");
                }               
                if (txtHorasTrabajadas.Text == " " || txtSalarioPorHora.Text == " ")
                {
                    throw new Exception("No deje espacios vacios");
                }
            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
                return;                
            }
            if (x <= 40 )
            {
                unEmpleadoSinHorasExtras.HorasTrabajadas = x;
                unEmpleadoSinHorasExtras.SueldoPorHora = y;
                MessageBox.Show("Horas trabajadas: " + unEmpleadoSinHorasExtras.HorasTrabajadas + "\nSueldo por hora: " + unEmpleadoSinHorasExtras.SueldoPorHora + "\nSalario: " + unEmpleadoSinHorasExtras.CalcularSalario(),"Empleado sin horas extras",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear();
            }
            if (x <=45)
            {
                unEmpleadoConHorasDobles.HorasTrabajadas = x;
                unEmpleadoConHorasDobles.SueldoPorHora = y;
                unEmpleadoConHorasDobles.CalcularSalario();
                MessageBox.Show("Horas trabajadas: " + unEmpleadoConHorasDobles.HorasTrabajadas + "\nSueldo por hora: " + unEmpleadoConHorasDobles.SueldoPorHora + "\nSalario: " + unEmpleadoConHorasDobles.CalcularSalario(), "Empleado con horas dobles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                unEmpleadoConHorasTriples.HorasTrabajadas = x;
                unEmpleadoConHorasTriples.SueldoPorHora = y;
                unEmpleadoConHorasTriples.CalcularSalario();
                MessageBox.Show("Horas trabajadas: " + unEmpleadoConHorasTriples.HorasTrabajadas + "\nSueldo por hora: " + unEmpleadoConHorasTriples.SueldoPorHora + "\nSalario: " + unEmpleadoConHorasTriples.CalcularSalario(), "Empleado con horas triples", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        public void Clear()
        {
            txtHorasTrabajadas.Clear();
            txtSalarioPorHora.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
