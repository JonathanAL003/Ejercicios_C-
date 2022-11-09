namespace ProyectoBaseDeDatos
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
            this.btnLoginInventario = new System.Windows.Forms.Button();
            this.btnInterfazCliente = new System.Windows.Forms.Button();
            this.btnLoginBDClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtmGeneral1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnLoginInventario
            // 
            this.btnLoginInventario.Location = new System.Drawing.Point(12, 12);
            this.btnLoginInventario.Name = "btnLoginInventario";
            this.btnLoginInventario.Size = new System.Drawing.Size(138, 55);
            this.btnLoginInventario.TabIndex = 0;
            this.btnLoginInventario.Text = "&Inventario(Administrador)";
            this.btnLoginInventario.UseVisualStyleBackColor = true;
            this.btnLoginInventario.Click += new System.EventHandler(this.btnLoginInventario_Click);
            // 
            // btnInterfazCliente
            // 
            this.btnInterfazCliente.Location = new System.Drawing.Point(12, 73);
            this.btnInterfazCliente.Name = "btnInterfazCliente";
            this.btnInterfazCliente.Size = new System.Drawing.Size(138, 55);
            this.btnInterfazCliente.TabIndex = 1;
            this.btnInterfazCliente.Text = "&Cliente";
            this.btnInterfazCliente.UseVisualStyleBackColor = true;
            this.btnInterfazCliente.Click += new System.EventHandler(this.btnInterfazCliente_Click);
            // 
            // btnLoginBDClientes
            // 
            this.btnLoginBDClientes.Location = new System.Drawing.Point(156, 12);
            this.btnLoginBDClientes.Name = "btnLoginBDClientes";
            this.btnLoginBDClientes.Size = new System.Drawing.Size(138, 55);
            this.btnLoginBDClientes.TabIndex = 2;
            this.btnLoginBDClientes.Text = "&Registro Clientes(Administrador)";
            this.btnLoginBDClientes.UseVisualStyleBackColor = true;
            this.btnLoginBDClientes.Click += new System.EventHandler(this.btnLoginBDClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(156, 73);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 55);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtmGeneral1
            // 
            this.dtmGeneral1.Checked = false;
            this.dtmGeneral1.Enabled = false;
            this.dtmGeneral1.Location = new System.Drawing.Point(48, 134);
            this.dtmGeneral1.Name = "dtmGeneral1";
            this.dtmGeneral1.Size = new System.Drawing.Size(210, 20);
            this.dtmGeneral1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 162);
            this.Controls.Add(this.dtmGeneral1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLoginBDClientes);
            this.Controls.Add(this.btnInterfazCliente);
            this.Controls.Add(this.btnLoginInventario);
            this.Name = "Form1";
            this.Text = "Ferreteria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginInventario;
        private System.Windows.Forms.Button btnInterfazCliente;
        private System.Windows.Forms.Button btnLoginBDClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtmGeneral1;
    }
}

