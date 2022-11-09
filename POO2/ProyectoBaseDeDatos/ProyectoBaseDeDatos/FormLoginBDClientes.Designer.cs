namespace ProyectoBaseDeDatos
{
    partial class FormLoginBDClientes
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
            this.lblContraseña2 = new System.Windows.Forms.Label();
            this.lblUsuario2 = new System.Windows.Forms.Label();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.txtUsuario2 = new System.Windows.Forms.TextBox();
            this.btnInicio4 = new System.Windows.Forms.Button();
            this.btnLoginBDClientesIngresar = new System.Windows.Forms.Button();
            this.btnSalir5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContraseña2
            // 
            this.lblContraseña2.AutoSize = true;
            this.lblContraseña2.Location = new System.Drawing.Point(7, 60);
            this.lblContraseña2.Name = "lblContraseña2";
            this.lblContraseña2.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña2.TabIndex = 11;
            this.lblContraseña2.Text = "Contraseña:";
            // 
            // lblUsuario2
            // 
            this.lblUsuario2.AutoSize = true;
            this.lblUsuario2.Location = new System.Drawing.Point(25, 34);
            this.lblUsuario2.Name = "lblUsuario2";
            this.lblUsuario2.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario2.TabIndex = 10;
            this.lblUsuario2.Text = "Usuario:";
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(77, 57);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '*';
            this.txtContraseña2.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña2.TabIndex = 9;
            // 
            // txtUsuario2
            // 
            this.txtUsuario2.Location = new System.Drawing.Point(77, 31);
            this.txtUsuario2.Name = "txtUsuario2";
            this.txtUsuario2.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario2.TabIndex = 8;
            // 
            // btnInicio4
            // 
            this.btnInicio4.Location = new System.Drawing.Point(189, 94);
            this.btnInicio4.Name = "btnInicio4";
            this.btnInicio4.Size = new System.Drawing.Size(75, 23);
            this.btnInicio4.TabIndex = 7;
            this.btnInicio4.Text = "&Inicio";
            this.btnInicio4.UseVisualStyleBackColor = true;
            this.btnInicio4.Click += new System.EventHandler(this.btnInicio4_Click);
            // 
            // btnLoginBDClientesIngresar
            // 
            this.btnLoginBDClientesIngresar.Location = new System.Drawing.Point(216, 24);
            this.btnLoginBDClientesIngresar.Name = "btnLoginBDClientesIngresar";
            this.btnLoginBDClientesIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnLoginBDClientesIngresar.TabIndex = 6;
            this.btnLoginBDClientesIngresar.Text = "&Ingresar";
            this.btnLoginBDClientesIngresar.UseVisualStyleBackColor = true;
            this.btnLoginBDClientesIngresar.Click += new System.EventHandler(this.btnLoginBDClientesIngresar_Click);
            // 
            // btnSalir5
            // 
            this.btnSalir5.Location = new System.Drawing.Point(270, 94);
            this.btnSalir5.Name = "btnSalir5";
            this.btnSalir5.Size = new System.Drawing.Size(46, 23);
            this.btnSalir5.TabIndex = 12;
            this.btnSalir5.Text = "&Salir";
            this.btnSalir5.UseVisualStyleBackColor = true;
            this.btnSalir5.Click += new System.EventHandler(this.btnSalir5_Click);
            // 
            // FormLoginBDClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 129);
            this.Controls.Add(this.btnSalir5);
            this.Controls.Add(this.lblContraseña2);
            this.Controls.Add(this.lblUsuario2);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtUsuario2);
            this.Controls.Add(this.btnInicio4);
            this.Controls.Add(this.btnLoginBDClientesIngresar);
            this.Name = "FormLoginBDClientes";
            this.Text = "Login base de datos clientes(Administrador)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseña2;
        private System.Windows.Forms.Label lblUsuario2;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.TextBox txtUsuario2;
        private System.Windows.Forms.Button btnInicio4;
        private System.Windows.Forms.Button btnLoginBDClientesIngresar;
        private System.Windows.Forms.Button btnSalir5;
    }
}