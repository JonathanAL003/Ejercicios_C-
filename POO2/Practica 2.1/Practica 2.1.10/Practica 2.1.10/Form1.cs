using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1._10
{
    public partial class Form1 : Form
    {
        Restaurante Mesa1 = new Restaurante(15, 18, 20, 8, 5, 6);
        Restaurante Mesa2 = new Restaurante(15, 18, 20, 8, 5, 6);
        Restaurante Mesa3 = new Restaurante(15, 18, 20, 8, 5, 6);
        Restaurante Mesa4 = new Restaurante(15, 18, 20, 8, 5, 6);
        Restaurante Mesa5 = new Restaurante(15, 18, 20, 8, 5, 6);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cboMesas.Items.Add("Mesa 1");
            cboMesas.Items.Add("Mesa 2");
            cboMesas.Items.Add("Mesa 3");
            cboMesas.Items.Add("Mesa 4");
            cboMesas.Items.Add("Mesa 5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboMesas.SelectedItem.ToString() == "Mesa 1")
            {
                Mesa1.CantidadHS = int.Parse(txtHS.Text);
                Mesa1.CantidadHQ = int.Parse(txtHQ.Text);
                Mesa1.CantidadHE = int.Parse(txtHE.Text);
                Mesa1.CantidadPF = int.Parse(txtPF.Text);
                Mesa1.CantidadR = int.Parse(txtR.Text);
                Mesa1.CantidadP = int.Parse(txtP.Text);
                txtHS.Clear();
                txtHQ.Clear();
                txtHE.Clear();
                txtPF.Clear();
                txtR.Clear();
                txtP.Clear();
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 2")
            {
                Mesa2.CantidadHS = int.Parse(txtHS.Text);
                Mesa2.CantidadHQ = int.Parse(txtHQ.Text);
                Mesa2.CantidadHE = int.Parse(txtHE.Text);
                Mesa2.CantidadPF = int.Parse(txtPF.Text);
                Mesa2.CantidadR = int.Parse(txtR.Text);
                Mesa2.CantidadP = int.Parse(txtP.Text);
                txtHS.Clear();
                txtHQ.Clear();
                txtHE.Clear();
                txtPF.Clear();
                txtR.Clear();
                txtP.Clear();
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 3")
            {
                Mesa3.CantidadHS = int.Parse(txtHS.Text);
                Mesa3.CantidadHQ = int.Parse(txtHQ.Text);
                Mesa3.CantidadHE = int.Parse(txtHE.Text);
                Mesa3.CantidadPF = int.Parse(txtPF.Text);
                Mesa3.CantidadR = int.Parse(txtR.Text);
                Mesa3.CantidadP = int.Parse(txtP.Text);
                txtHS.Clear();
                txtHQ.Clear();
                txtHE.Clear();
                txtPF.Clear();
                txtR.Clear();
                txtP.Clear();
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 4")
            {
                Mesa4.CantidadHS = int.Parse(txtHS.Text);
                Mesa4.CantidadHQ = int.Parse(txtHQ.Text);
                Mesa4.CantidadHE = int.Parse(txtHE.Text);
                Mesa4.CantidadPF = int.Parse(txtPF.Text);
                Mesa4.CantidadR = int.Parse(txtR.Text);
                Mesa4.CantidadP = int.Parse(txtP.Text);
                txtHS.Clear();
                txtHQ.Clear();
                txtHE.Clear();
                txtPF.Clear();
                txtR.Clear();
                txtP.Clear();
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 5")
            {
                Mesa5.CantidadHS = int.Parse(txtHS.Text);
                Mesa5.CantidadHQ = int.Parse(txtHQ.Text);
                Mesa5.CantidadHE = int.Parse(txtHE.Text);
                Mesa5.CantidadPF = int.Parse(txtPF.Text);
                Mesa5.CantidadR = int.Parse(txtR.Text);
                Mesa5.CantidadP = int.Parse(txtP.Text);
                txtHS.Clear();
                txtHQ.Clear();
                txtHE.Clear();
                txtPF.Clear();
                txtR.Clear();
                txtP.Clear();
            }
        }

        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            if (cboMesas.SelectedItem.ToString() == "Mesa 1")
            {
                MessageBox.Show("Mesa 1\nSu total a pagar es de : $" + Mesa1.CalcularTotal());
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 2")
            {
                MessageBox.Show("Mesa 2\nSu total a pagar es de : $" + Mesa2.CalcularTotal());
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 3")
            {
                MessageBox.Show("Mesa 3\nSu total a pagar es de : $" + Mesa3.CalcularTotal());
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 4")
            {
                MessageBox.Show("Mesa 4\nSu total a pagar es de : $" + Mesa4.CalcularTotal());
            }
            if (cboMesas.SelectedItem.ToString() == "Mesa 5")
            {
                MessageBox.Show("Mesa 5\nSu total a pagar es de : $" + Mesa5.CalcularTotal());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
