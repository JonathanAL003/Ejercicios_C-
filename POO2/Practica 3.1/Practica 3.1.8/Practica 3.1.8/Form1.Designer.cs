namespace Practica_3._1._8
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
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.radEmpleado = new System.Windows.Forms.RadioButton();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtLimiteDeCredito = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblLimiteDeCredito = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpUsuario.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.radEmpleado);
            this.grpUsuario.Controls.Add(this.radCliente);
            this.grpUsuario.Location = new System.Drawing.Point(12, 12);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(139, 75);
            this.grpUsuario.TabIndex = 0;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Usuario";
            // 
            // radEmpleado
            // 
            this.radEmpleado.AutoSize = true;
            this.radEmpleado.Location = new System.Drawing.Point(6, 42);
            this.radEmpleado.Name = "radEmpleado";
            this.radEmpleado.Size = new System.Drawing.Size(72, 17);
            this.radEmpleado.TabIndex = 1;
            this.radEmpleado.Text = "Empleado";
            this.radEmpleado.UseVisualStyleBackColor = true;
            this.radEmpleado.CheckedChanged += new System.EventHandler(this.radEmpleado_CheckedChanged);
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.radCliente.Checked = true;
            this.radCliente.Location = new System.Drawing.Point(6, 19);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(57, 17);
            this.radCliente.TabIndex = 0;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "Cliente";
            this.radCliente.UseVisualStyleBackColor = true;
            this.radCliente.CheckedChanged += new System.EventHandler(this.radCliente_CheckedChanged);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtSalario);
            this.grpDatos.Controls.Add(this.txtLimiteDeCredito);
            this.grpDatos.Controls.Add(this.txtDomicilio);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblSalario);
            this.grpDatos.Controls.Add(this.lblLimiteDeCredito);
            this.grpDatos.Controls.Add(this.lblDomicilio);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Location = new System.Drawing.Point(157, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(247, 151);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(96, 117);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(69, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // txtLimiteDeCredito
            // 
            this.txtLimiteDeCredito.Location = new System.Drawing.Point(96, 91);
            this.txtLimiteDeCredito.Name = "txtLimiteDeCredito";
            this.txtLimiteDeCredito.Size = new System.Drawing.Size(69, 20);
            this.txtLimiteDeCredito.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(96, 62);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(136, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(51, 120);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salario";
            // 
            // lblLimiteDeCredito
            // 
            this.lblLimiteDeCredito.AutoSize = true;
            this.lblLimiteDeCredito.Location = new System.Drawing.Point(6, 94);
            this.lblLimiteDeCredito.Name = "lblLimiteDeCredito";
            this.lblLimiteDeCredito.Size = new System.Drawing.Size(84, 13);
            this.lblLimiteDeCredito.TabIndex = 2;
            this.lblLimiteDeCredito.Text = "Limite de credito";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(41, 65);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 1;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(36, 93);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(86, 23);
            this.btnCapturarDatos.TabIndex = 2;
            this.btnCapturarDatos.Text = "&Capturar Datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(36, 122);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(86, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "&Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(36, 151);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 180);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpUsuario);
            this.Name = "Form1";
            this.Text = "Empresa";
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.RadioButton radEmpleado;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtLimiteDeCredito;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblLimiteDeCredito;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}

