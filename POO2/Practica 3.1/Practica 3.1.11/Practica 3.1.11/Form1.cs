using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3._1._11
{
    public partial class Form1 : Form
    {
        PlatilloFuerte platillofuerte1, platillofuerte2, platillofuerte3, platillofuerte4;
        Ensalada ensalada1, ensalada2, ensalada3, ensalada4;
        Sopa sopa1, sopa2, sopa3, sopa4;
        Postre postre1, postre2, postre3, postre4;
        Bebida bebida1, bebida2, bebida3, bebida4;

        public Form1()
        {
            InitializeComponent();

            chkPollo.Enabled = true;
            chkCarne.Enabled = true;
            chkSal.Enabled = true;
            chkAzucar.Enabled = false;
            chkTenedor.Enabled = true;
            chkCuchara.Enabled = false;
            chkCuchillo.Enabled = true;
            chkPopote.Enabled = false;
            chkVaso.Enabled = false;

            cboCliente.Items.Add("Cliente 1");
            cboCliente.Items.Add("Cliente 2");
            cboCliente.Items.Add("Cliente 3");
            cboCliente.Items.Add("Cliente 4");

            cboMesa.Items.Add("Mesa 1");
            //cboMesa.Items.Add("Mesa 2");
            //cboMesa.Items.Add("Mesa 3");
            //cboMesa.Items.Add("Mesa 4");
            //cboMesa.Items.Add("Mesa 5");
            //cboMesa.Items.Add("Mesa 6");
            //cboMesa.Items.Add("Mesa 7");
            //cboMesa.Items.Add("Mesa 8");
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (cboMesa.SelectedItem.ToString() == "Mesa 1")
            {
                if (cboCliente.SelectedItem.ToString() == "Cliente 1")
                {
                    if (radPlatilloFuerte.Checked)
                    {
                        platillofuerte1 = new PlatilloFuerte(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, chkCarne.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radEnsalada.Checked)
                    {
                        ensalada1 = new Ensalada(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radSopa.Checked)
                    {
                        sopa1 = new Sopa(chkPollo.Checked, chkSal.Checked, chkCuchara.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radPostre.Checked)
                    {
                        postre1 = new Postre(chkAzucar.Checked, chkCuchara.Checked, chkTenedor.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radBebida.Checked)
                    {
                        bebida1 = new Bebida(chkAzucar.Checked, chkPopote.Checked, true, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (cboCliente.SelectedItem.ToString() == "Cliente 2")
                {
                    if (radPlatilloFuerte.Checked)
                    {
                        platillofuerte2 = new PlatilloFuerte(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, chkCarne.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radEnsalada.Checked)
                    {
                        ensalada2 = new Ensalada(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radSopa.Checked)
                    {
                        sopa2 = new Sopa(chkPollo.Checked, chkSal.Checked, chkCuchara.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radPostre.Checked)
                    {
                        postre2 = new Postre(chkAzucar.Checked, chkCuchara.Checked, chkTenedor.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radBebida.Checked)
                    {
                        bebida2 = new Bebida(chkAzucar.Checked, chkPopote.Checked, true, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (cboCliente.SelectedItem.ToString() == "Cliente 3")
                {
                    if (radPlatilloFuerte.Checked)
                    {
                        platillofuerte3 = new PlatilloFuerte(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, chkCarne.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radEnsalada.Checked)
                    {
                        ensalada3 = new Ensalada(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radSopa.Checked)
                    {
                        sopa3 = new Sopa(chkPollo.Checked, chkSal.Checked, chkCuchara.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radPostre.Checked)
                    {
                        postre3 = new Postre(chkAzucar.Checked, chkCuchara.Checked, chkTenedor.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radBebida.Checked)
                    {
                        bebida3 = new Bebida(chkAzucar.Checked, chkPopote.Checked, true, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                if (cboCliente.SelectedItem.ToString() == "Cliente 4")
                {
                    if (radPlatilloFuerte.Checked)
                    {
                        platillofuerte4 = new PlatilloFuerte(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, chkCarne.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radEnsalada.Checked)
                    {
                        ensalada4 = new Ensalada(chkPollo.Checked, chkSal.Checked, chkTenedor.Checked, chkCuchillo.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radSopa.Checked)
                    {
                        sopa4 = new Sopa(chkPollo.Checked, chkSal.Checked, chkCuchara.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radPostre.Checked)
                    {
                        postre4 = new Postre(chkAzucar.Checked, chkCuchara.Checked, chkTenedor.Checked, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    if (radBebida.Checked)
                    {
                        bebida4 = new Bebida(chkAzucar.Checked, chkPopote.Checked, true, txtNombre.Text, double.Parse(txtPrecio.Text));
                    }
                    MessageBox.Show("Los datos fueron capturados correctamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        public void Clear()
        {
            foreach (Control x in grpAlimentos.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }
            chkPollo.Checked = false;
            chkCarne.Checked = false;
            chkSal.Checked = false;
            chkAzucar.Checked = false;
            chkTenedor.Checked = false;
            chkCuchara.Checked = false;
            chkCuchillo.Checked = false;
            chkPopote.Checked = false;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem.ToString() == "Cliente 1")
            {
                if (radPlatilloFuerte.Checked)
                {
                    MessageBox.Show(platillofuerte1.ToString(), "Platillo fuerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radEnsalada.Checked)
                {
                    MessageBox.Show(ensalada1.ToString(), "Ensalada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radSopa.Checked)
                {
                    MessageBox.Show(sopa1.ToString(), "Sopa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radPostre.Checked)
                {
                    MessageBox.Show(postre1.ToString(), "Postre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radBebida.Checked)
                {
                    MessageBox.Show(bebida1.ToString(), "Bebida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cboCliente.SelectedItem.ToString() == "Cliente 2")
            {
                if (radPlatilloFuerte.Checked)
                {
                    MessageBox.Show(platillofuerte2.ToString(), "Platillo fuerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radEnsalada.Checked)
                {
                    MessageBox.Show(ensalada2.ToString(), "Ensalada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radSopa.Checked)
                {
                    MessageBox.Show(sopa2.ToString(), "Sopa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radPostre.Checked)
                {
                    MessageBox.Show(postre2.ToString(), "Postre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radBebida.Checked)
                {
                    MessageBox.Show(bebida2.ToString(), "Bebida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cboCliente.SelectedItem.ToString() == "Cliente 3")
            {
                if (radPlatilloFuerte.Checked)
                {
                    MessageBox.Show(platillofuerte3.ToString(), "Platillo fuerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radEnsalada.Checked)
                {
                    MessageBox.Show(ensalada3.ToString(), "Ensalada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radSopa.Checked)
                {
                    MessageBox.Show(sopa3.ToString(), "Sopa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radPostre.Checked)
                {
                    MessageBox.Show(postre3.ToString(), "Postre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radBebida.Checked)
                {
                    MessageBox.Show(bebida3.ToString(), "Bebida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cboCliente.SelectedItem.ToString() == "Cliente 4")
            {
                if (radPlatilloFuerte.Checked)
                {
                    MessageBox.Show(platillofuerte4.ToString(), "Platillo fuerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radEnsalada.Checked)
                {
                    MessageBox.Show(ensalada4.ToString(), "Ensalada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radSopa.Checked)
                {
                    MessageBox.Show(sopa4.ToString(), "Sopa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radPostre.Checked)
                {
                    MessageBox.Show(postre4.ToString(), "Postre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (radBebida.Checked)
                {
                    MessageBox.Show(bebida4.ToString(), "Bebida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radPlatilloFuerte_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = true;
            chkCarne.Enabled = true;
            chkSal.Enabled = true;
            chkAzucar.Enabled = false;
            chkTenedor.Enabled = true;
            chkCuchara.Enabled = false;
            chkCuchillo.Enabled = true;
            chkPopote.Enabled = false;
            chkVaso.Enabled = false;
        }

        private void radEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = true;
            chkCarne.Enabled = false;
            chkSal.Enabled = true;
            chkAzucar.Enabled = false;
            chkTenedor.Enabled = true;
            chkCuchara.Enabled = false;
            chkCuchillo.Enabled = true;
            chkPopote.Enabled = false;
            chkVaso.Enabled = false;
        }

        private void radSopa_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = true;
            chkCarne.Enabled = false;
            chkSal.Enabled = true;
            chkAzucar.Enabled = false;
            chkTenedor.Enabled = false;
            chkCuchara.Enabled = true;
            chkCuchillo.Enabled = false;
            chkPopote.Enabled = false;
            chkVaso.Enabled = false;
        }

        private void radPostre_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = false;
            chkCarne.Enabled = false;
            chkSal.Enabled = false;
            chkAzucar.Enabled = true;
            chkTenedor.Enabled = true;
            chkCuchara.Enabled = true;
            chkCuchillo.Enabled = false;
            chkPopote.Enabled = false;
            chkVaso.Enabled = false;
        }

        private void radBebida_CheckedChanged(object sender, EventArgs e)
        {
            chkPollo.Enabled = false;
            chkCarne.Enabled = false;
            chkSal.Enabled = false;
            chkAzucar.Enabled = true;
            chkTenedor.Enabled = false;
            chkCuchara.Enabled = false;
            chkCuchillo.Enabled = false;
            chkPopote.Enabled = true;
            chkVaso.Enabled = false;
        }

        double TotalCliente1,TotalCliente2,TotalCliente3,TotalCliente4;

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem.ToString() == "Cliente 1")
            {
                TotalCliente1 = platillofuerte1.Precio + ensalada1.Precio + sopa1.Precio + postre1.Precio + bebida1.Precio;
                MessageBox.Show(platillofuerte1.ToString() + "\n\n" + ensalada1.ToString() + "\n\n" + sopa1.ToString() + "\n\n" + postre1.ToString() + "\n\n" + bebida1.ToString() + "\n\nTotal cliente 1: $" + TotalCliente1, "Cliente 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cboCliente.SelectedItem.ToString() == "Cliente 2")
            {
                TotalCliente2 = platillofuerte2.Precio + ensalada2.Precio + sopa2.Precio + postre2.Precio + bebida2.Precio;
                MessageBox.Show(platillofuerte2.ToString() + "\n\n" + ensalada2.ToString() + "\n\n" + sopa2.ToString() + "\n\n" + postre2.ToString() + "\n\n" + bebida2.ToString() + "\n\nTotal cliente 2: $" + TotalCliente2, "Cliente 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cboCliente.SelectedItem.ToString() == "Cliente 3")
            {
                TotalCliente3 = platillofuerte3.Precio + ensalada3.Precio + sopa3.Precio + postre3.Precio + bebida3.Precio;
                MessageBox.Show(platillofuerte3.ToString() + "\n\n" + ensalada3.ToString() + "\n\n" + sopa3.ToString() + "\n\n" + postre3.ToString() + "\n\n" + bebida3.ToString() + "\n\nTotal cliente 3: $" + TotalCliente3, "Cliente 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cboCliente.SelectedItem.ToString() == "Cliente 4")
            {
                TotalCliente4 = platillofuerte4.Precio + ensalada4.Precio + sopa4.Precio + postre4.Precio + bebida4.Precio;
                MessageBox.Show(platillofuerte4.ToString() + "\n\n" + ensalada4.ToString() + "\n\n" + sopa4.ToString() + "\n\n" + postre4.ToString() + "\n\n" + bebida4.ToString() + "\n\nTotal cliente 4: $" + TotalCliente4, "Cliente 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        double TotalMesa1;

        private void btnMesa_Click(object sender, EventArgs e)
        {
            if (cboMesa.SelectedItem.ToString() == "Mesa 1")
            {
                TotalMesa1 = TotalCliente1 + TotalCliente2 + TotalCliente3 + TotalCliente4;
                MessageBox.Show(platillofuerte1.ToString() + "\n\n" + ensalada1.ToString() + "\n\n" + sopa1.ToString() + "\n\n" + postre1.ToString() + "\n\n" + bebida1.ToString() + "\n\nTotal cliente 1: $" + TotalCliente1, "Cliente 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(platillofuerte2.ToString() + "\n\n" + ensalada2.ToString() + "\n\n" + sopa2.ToString() + "\n\n" + postre2.ToString() + "\n\n" + bebida2.ToString() + "\n\nTotal cliente 2: $" + TotalCliente2, "Cliente 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(platillofuerte3.ToString() + "\n\n" + ensalada3.ToString() + "\n\n" + sopa3.ToString() + "\n\n" + postre3.ToString() + "\n\n" + bebida3.ToString() + "\n\nTotal cliente 3: $" + TotalCliente3, "Cliente 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(platillofuerte4.ToString() + "\n\n" + ensalada4.ToString() + "\n\n" + sopa4.ToString() + "\n\n" + postre4.ToString() + "\n\n" + bebida4.ToString() + "\n\nTotal cliente 4: $" + TotalCliente4, "Cliente 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("El total a pagar de la mesa 1 es de: $" + TotalMesa1, "Mesa 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
