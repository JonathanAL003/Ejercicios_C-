namespace Practica_3._1._11
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPlatillos = new System.Windows.Forms.GroupBox();
            this.radBebida = new System.Windows.Forms.RadioButton();
            this.radPostre = new System.Windows.Forms.RadioButton();
            this.radSopa = new System.Windows.Forms.RadioButton();
            this.radEnsalada = new System.Windows.Forms.RadioButton();
            this.radPlatilloFuerte = new System.Windows.Forms.RadioButton();
            this.grpAlimentos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpIngredientes = new System.Windows.Forms.GroupBox();
            this.chkVaso = new System.Windows.Forms.CheckBox();
            this.chkPopote = new System.Windows.Forms.CheckBox();
            this.chkAzucar = new System.Windows.Forms.CheckBox();
            this.chkCuchillo = new System.Windows.Forms.CheckBox();
            this.chkCuchara = new System.Windows.Forms.CheckBox();
            this.chkTenedor = new System.Windows.Forms.CheckBox();
            this.chkSal = new System.Windows.Forms.CheckBox();
            this.chkCarne = new System.Windows.Forms.CheckBox();
            this.chkPollo = new System.Windows.Forms.CheckBox();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboMesa = new System.Windows.Forms.ComboBox();
            this.btnMesa = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.grpPlatillos.SuspendLayout();
            this.grpAlimentos.SuspendLayout();
            this.grpIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlatillos
            // 
            this.grpPlatillos.Controls.Add(this.radBebida);
            this.grpPlatillos.Controls.Add(this.radPostre);
            this.grpPlatillos.Controls.Add(this.radSopa);
            this.grpPlatillos.Controls.Add(this.radEnsalada);
            this.grpPlatillos.Controls.Add(this.radPlatilloFuerte);
            this.grpPlatillos.Location = new System.Drawing.Point(12, 12);
            this.grpPlatillos.Name = "grpPlatillos";
            this.grpPlatillos.Size = new System.Drawing.Size(101, 135);
            this.grpPlatillos.TabIndex = 0;
            this.grpPlatillos.TabStop = false;
            this.grpPlatillos.Text = "Platillos";
            // 
            // radBebida
            // 
            this.radBebida.AutoSize = true;
            this.radBebida.Location = new System.Drawing.Point(6, 111);
            this.radBebida.Name = "radBebida";
            this.radBebida.Size = new System.Drawing.Size(58, 17);
            this.radBebida.TabIndex = 4;
            this.radBebida.Text = "Bebida";
            this.radBebida.UseVisualStyleBackColor = true;
            this.radBebida.CheckedChanged += new System.EventHandler(this.radBebida_CheckedChanged);
            // 
            // radPostre
            // 
            this.radPostre.AutoSize = true;
            this.radPostre.Location = new System.Drawing.Point(6, 88);
            this.radPostre.Name = "radPostre";
            this.radPostre.Size = new System.Drawing.Size(55, 17);
            this.radPostre.TabIndex = 3;
            this.radPostre.Text = "Postre";
            this.radPostre.UseVisualStyleBackColor = true;
            this.radPostre.CheckedChanged += new System.EventHandler(this.radPostre_CheckedChanged);
            // 
            // radSopa
            // 
            this.radSopa.AutoSize = true;
            this.radSopa.Location = new System.Drawing.Point(6, 65);
            this.radSopa.Name = "radSopa";
            this.radSopa.Size = new System.Drawing.Size(50, 17);
            this.radSopa.TabIndex = 2;
            this.radSopa.Text = "Sopa";
            this.radSopa.UseVisualStyleBackColor = true;
            this.radSopa.CheckedChanged += new System.EventHandler(this.radSopa_CheckedChanged);
            // 
            // radEnsalada
            // 
            this.radEnsalada.AutoSize = true;
            this.radEnsalada.Location = new System.Drawing.Point(6, 42);
            this.radEnsalada.Name = "radEnsalada";
            this.radEnsalada.Size = new System.Drawing.Size(69, 17);
            this.radEnsalada.TabIndex = 1;
            this.radEnsalada.Text = "Ensalada";
            this.radEnsalada.UseVisualStyleBackColor = true;
            this.radEnsalada.CheckedChanged += new System.EventHandler(this.radEnsalada_CheckedChanged);
            // 
            // radPlatilloFuerte
            // 
            this.radPlatilloFuerte.AutoSize = true;
            this.radPlatilloFuerte.Checked = true;
            this.radPlatilloFuerte.Location = new System.Drawing.Point(6, 19);
            this.radPlatilloFuerte.Name = "radPlatilloFuerte";
            this.radPlatilloFuerte.Size = new System.Drawing.Size(85, 17);
            this.radPlatilloFuerte.TabIndex = 0;
            this.radPlatilloFuerte.TabStop = true;
            this.radPlatilloFuerte.Text = "Platillo fuerte";
            this.radPlatilloFuerte.UseVisualStyleBackColor = true;
            this.radPlatilloFuerte.CheckedChanged += new System.EventHandler(this.radPlatilloFuerte_CheckedChanged);
            // 
            // grpAlimentos
            // 
            this.grpAlimentos.Controls.Add(this.txtPrecio);
            this.grpAlimentos.Controls.Add(this.txtNombre);
            this.grpAlimentos.Controls.Add(this.lblPrecio);
            this.grpAlimentos.Controls.Add(this.lblNombre);
            this.grpAlimentos.Location = new System.Drawing.Point(12, 153);
            this.grpAlimentos.Name = "grpAlimentos";
            this.grpAlimentos.Size = new System.Drawing.Size(200, 81);
            this.grpAlimentos.TabIndex = 1;
            this.grpAlimentos.TabStop = false;
            this.grpAlimentos.Text = "Alimentos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(56, 50);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(61, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 54);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.chkVaso);
            this.grpIngredientes.Controls.Add(this.chkPopote);
            this.grpIngredientes.Controls.Add(this.chkAzucar);
            this.grpIngredientes.Controls.Add(this.chkCuchillo);
            this.grpIngredientes.Controls.Add(this.chkCuchara);
            this.grpIngredientes.Controls.Add(this.chkTenedor);
            this.grpIngredientes.Controls.Add(this.chkSal);
            this.grpIngredientes.Controls.Add(this.chkCarne);
            this.grpIngredientes.Controls.Add(this.chkPollo);
            this.grpIngredientes.Location = new System.Drawing.Point(119, 17);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(218, 110);
            this.grpIngredientes.TabIndex = 2;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Ingredientes";
            // 
            // chkVaso
            // 
            this.chkVaso.AutoSize = true;
            this.chkVaso.Checked = true;
            this.chkVaso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVaso.Enabled = false;
            this.chkVaso.Location = new System.Drawing.Point(72, 84);
            this.chkVaso.Name = "chkVaso";
            this.chkVaso.Size = new System.Drawing.Size(50, 17);
            this.chkVaso.TabIndex = 8;
            this.chkVaso.Text = "Vaso";
            this.chkVaso.UseVisualStyleBackColor = true;
            // 
            // chkPopote
            // 
            this.chkPopote.AutoSize = true;
            this.chkPopote.Location = new System.Drawing.Point(6, 84);
            this.chkPopote.Name = "chkPopote";
            this.chkPopote.Size = new System.Drawing.Size(60, 17);
            this.chkPopote.TabIndex = 7;
            this.chkPopote.Text = "Popote";
            this.chkPopote.UseVisualStyleBackColor = true;
            // 
            // chkAzucar
            // 
            this.chkAzucar.AutoSize = true;
            this.chkAzucar.Location = new System.Drawing.Point(61, 38);
            this.chkAzucar.Name = "chkAzucar";
            this.chkAzucar.Size = new System.Drawing.Size(59, 17);
            this.chkAzucar.TabIndex = 6;
            this.chkAzucar.Text = "Azucar";
            this.chkAzucar.UseVisualStyleBackColor = true;
            // 
            // chkCuchillo
            // 
            this.chkCuchillo.AutoSize = true;
            this.chkCuchillo.Location = new System.Drawing.Point(150, 61);
            this.chkCuchillo.Name = "chkCuchillo";
            this.chkCuchillo.Size = new System.Drawing.Size(63, 17);
            this.chkCuchillo.TabIndex = 5;
            this.chkCuchillo.Text = "Cuchillo";
            this.chkCuchillo.UseVisualStyleBackColor = true;
            // 
            // chkCuchara
            // 
            this.chkCuchara.AutoSize = true;
            this.chkCuchara.Location = new System.Drawing.Point(78, 60);
            this.chkCuchara.Name = "chkCuchara";
            this.chkCuchara.Size = new System.Drawing.Size(66, 17);
            this.chkCuchara.TabIndex = 4;
            this.chkCuchara.Text = "Cuchara";
            this.chkCuchara.UseVisualStyleBackColor = true;
            // 
            // chkTenedor
            // 
            this.chkTenedor.AutoSize = true;
            this.chkTenedor.Location = new System.Drawing.Point(6, 60);
            this.chkTenedor.Name = "chkTenedor";
            this.chkTenedor.Size = new System.Drawing.Size(66, 17);
            this.chkTenedor.TabIndex = 3;
            this.chkTenedor.Text = "Tenedor";
            this.chkTenedor.UseVisualStyleBackColor = true;
            // 
            // chkSal
            // 
            this.chkSal.AutoSize = true;
            this.chkSal.Location = new System.Drawing.Point(6, 38);
            this.chkSal.Name = "chkSal";
            this.chkSal.Size = new System.Drawing.Size(41, 17);
            this.chkSal.TabIndex = 2;
            this.chkSal.Text = "Sal";
            this.chkSal.UseVisualStyleBackColor = true;
            // 
            // chkCarne
            // 
            this.chkCarne.AutoSize = true;
            this.chkCarne.Location = new System.Drawing.Point(61, 19);
            this.chkCarne.Name = "chkCarne";
            this.chkCarne.Size = new System.Drawing.Size(54, 17);
            this.chkCarne.TabIndex = 1;
            this.chkCarne.Text = "Carne";
            this.chkCarne.UseVisualStyleBackColor = true;
            // 
            // chkPollo
            // 
            this.chkPollo.AutoSize = true;
            this.chkPollo.Location = new System.Drawing.Point(6, 19);
            this.chkPollo.Name = "chkPollo";
            this.chkPollo.Size = new System.Drawing.Size(49, 17);
            this.chkPollo.TabIndex = 0;
            this.chkPollo.Text = "Pollo";
            this.chkPollo.UseVisualStyleBackColor = true;
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(124, 133);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(88, 23);
            this.btnCapturarDatos.TabIndex = 3;
            this.btnCapturarDatos.Text = "&Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(218, 133);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(88, 23);
            this.btnMostrarDatos.TabIndex = 4;
            this.btnMostrarDatos.Text = "&Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(312, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(316, 170);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(88, 23);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "&Mostrar cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(218, 172);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(92, 21);
            this.cboCliente.TabIndex = 7;
            // 
            // cboMesa
            // 
            this.cboMesa.FormattingEnabled = true;
            this.cboMesa.Location = new System.Drawing.Point(218, 207);
            this.cboMesa.Name = "cboMesa";
            this.cboMesa.Size = new System.Drawing.Size(92, 21);
            this.cboMesa.TabIndex = 8;
            // 
            // btnMesa
            // 
            this.btnMesa.Location = new System.Drawing.Point(316, 205);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(88, 23);
            this.btnMesa.TabIndex = 9;
            this.btnMesa.Text = "&Mostrar mesa";
            this.btnMesa.UseVisualStyleBackColor = true;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(346, 31);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(188, 13);
            this.lblNota1.TabIndex = 10;
            this.lblNota1.Text = "*Nota: Seleccione un cliente y Mesa 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(346, 54);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(277, 13);
            this.lblNota2.TabIndex = 11;
            this.lblNota2.Text = "**NOTA 2: Rellene todos los platillos de todos los clientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 245);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnMesa);
            this.Controls.Add(this.cboMesa);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grpIngredientes);
            this.Controls.Add(this.grpAlimentos);
            this.Controls.Add(this.grpPlatillos);
            this.Name = "Form1";
            this.Text = "Restaurante";
            this.grpPlatillos.ResumeLayout(false);
            this.grpPlatillos.PerformLayout();
            this.grpAlimentos.ResumeLayout(false);
            this.grpAlimentos.PerformLayout();
            this.grpIngredientes.ResumeLayout(false);
            this.grpIngredientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlatillos;
        private System.Windows.Forms.RadioButton radBebida;
        private System.Windows.Forms.RadioButton radPostre;
        private System.Windows.Forms.RadioButton radSopa;
        private System.Windows.Forms.RadioButton radEnsalada;
        private System.Windows.Forms.RadioButton radPlatilloFuerte;
        private System.Windows.Forms.GroupBox grpAlimentos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpIngredientes;
        private System.Windows.Forms.CheckBox chkPollo;
        private System.Windows.Forms.CheckBox chkSal;
        private System.Windows.Forms.CheckBox chkCarne;
        private System.Windows.Forms.CheckBox chkVaso;
        private System.Windows.Forms.CheckBox chkPopote;
        private System.Windows.Forms.CheckBox chkAzucar;
        private System.Windows.Forms.CheckBox chkCuchillo;
        private System.Windows.Forms.CheckBox chkCuchara;
        private System.Windows.Forms.CheckBox chkTenedor;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboMesa;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
    }
}

