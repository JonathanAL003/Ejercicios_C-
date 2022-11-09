namespace ProyectoBaseDeDatos
{
    partial class FormLoginInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoginInventarioIngresar = new System.Windows.Forms.Button();
            this.btnInicio1 = new System.Windows.Forms.Button();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.lblUsuario1 = new System.Windows.Forms.Label();
            this.lblContraseña1 = new System.Windows.Forms.Label();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginInventarioIngresar
            // 
            this.btnLoginInventarioIngresar.Location = new System.Drawing.Point(221, 22);
            this.btnLoginInventarioIngresar.Name = "btnLoginInventarioIngresar";
            this.btnLoginInventarioIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnLoginInventarioIngresar.TabIndex = 0;
            this.btnLoginInventarioIngresar.Text = "&Ingresar";
            this.btnLoginInventarioIngresar.UseVisualStyleBackColor = true;
            this.btnLoginInventarioIngresar.Click += new System.EventHandler(this.btnLoginInventarioIngresar_Click);
            // 
            // btnInicio1
            // 
            this.btnInicio1.Location = new System.Drawing.Point(169, 81);
            this.btnInicio1.Name = "btnInicio1";
            this.btnInicio1.Size = new System.Drawing.Size(75, 23);
            this.btnInicio1.TabIndex = 1;
            this.btnInicio1.Text = "&Inicio";
            this.btnInicio1.UseVisualStyleBackColor = true;
            this.btnInicio1.Click += new System.EventHandler(this.btnInicio1_Click);
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(82, 29);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario1.TabIndex = 2;
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Location = new System.Drawing.Point(82, 55);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '*';
            this.txtContraseña1.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña1.TabIndex = 3;
            this.txtContraseña1.TextChanged += new System.EventHandler(this.txtContraseña1_TextChanged);
            // 
            // lblUsuario1
            // 
            this.lblUsuario1.AutoSize = true;
            this.lblUsuario1.Location = new System.Drawing.Point(30, 32);
            this.lblUsuario1.Name = "lblUsuario1";
            this.lblUsuario1.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario1.TabIndex = 4;
            this.lblUsuario1.Text = "Usuario:";
            // 
            // lblContraseña1
            // 
            this.lblContraseña1.AutoSize = true;
            this.lblContraseña1.Location = new System.Drawing.Point(12, 58);
            this.lblContraseña1.Name = "lblContraseña1";
            this.lblContraseña1.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña1.TabIndex = 5;
            this.lblContraseña1.Text = "Contraseña:";
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(250, 81);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(46, 23);
            this.btnSalir2.TabIndex = 6;
            this.btnSalir2.Text = "&Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // FormLoginInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 113);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.lblContraseña1);
            this.Controls.Add(this.lblUsuario1);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.btnInicio1);
            this.Controls.Add(this.btnLoginInventarioIngresar);
            this.Name = "FormLoginInventario";
            this.Text = "Login Inventario(Administrador)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginInventarioIngresar;
        private System.Windows.Forms.Button btnInicio1;
        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.Label lblUsuario1;
        private System.Windows.Forms.Label lblContraseña1;
        private System.Windows.Forms.Button btnSalir2;
    }
}