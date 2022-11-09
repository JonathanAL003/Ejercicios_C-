namespace Generador_de_datos_aleatorios
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarTodosLosEmpleados = new System.Windows.Forms.Button();
            this.btnEmpleadoConSueldoMayor = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnSalir);
            this.grpDatos.Controls.Add(this.btnBorrarTodosLosEmpleados);
            this.grpDatos.Controls.Add(this.btnEmpleadoConSueldoMayor);
            this.grpDatos.Controls.Add(this.btnCapturar);
            this.grpDatos.Controls.Add(this.txtSueldo);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtNumero);
            this.grpDatos.Controls.Add(this.lblSueldo);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblNumero);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(252, 192);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Empleado";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(9, 162);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarTodosLosEmpleados
            // 
            this.btnBorrarTodosLosEmpleados.Location = new System.Drawing.Point(90, 162);
            this.btnBorrarTodosLosEmpleados.Name = "btnBorrarTodosLosEmpleados";
            this.btnBorrarTodosLosEmpleados.Size = new System.Drawing.Size(153, 23);
            this.btnBorrarTodosLosEmpleados.TabIndex = 8;
            this.btnBorrarTodosLosEmpleados.Text = "&Borrar todos los empleados";
            this.btnBorrarTodosLosEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnEmpleadoConSueldoMayor
            // 
            this.btnEmpleadoConSueldoMayor.Location = new System.Drawing.Point(90, 133);
            this.btnEmpleadoConSueldoMayor.Name = "btnEmpleadoConSueldoMayor";
            this.btnEmpleadoConSueldoMayor.Size = new System.Drawing.Size(153, 23);
            this.btnEmpleadoConSueldoMayor.TabIndex = 7;
            this.btnEmpleadoConSueldoMayor.Text = "&Empleado con sueldo mayor";
            this.btnEmpleadoConSueldoMayor.UseVisualStyleBackColor = true;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(9, 133);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 6;
            this.btnCapturar.Text = "&Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(61, 95);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(63, 20);
            this.txtSueldo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(56, 34);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(40, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(15, 98);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(15, 210);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.Size = new System.Drawing.Size(240, 150);
            this.dtgEmpleados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 378);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "Ejemplo de compilacion condicional";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarTodosLosEmpleados;
        private System.Windows.Forms.Button btnEmpleadoConSueldoMayor;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DataGridView dtgEmpleados;
    }
}

