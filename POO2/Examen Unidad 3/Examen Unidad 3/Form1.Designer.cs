namespace Examen_Unidad_3
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
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.radRepartidor = new System.Windows.Forms.RadioButton();
            this.radComercial = new System.Windows.Forms.RadioButton();
            this.dtmFechaActual = new System.Windows.Forms.DateTimePicker();
            this.dtmFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.cboZona = new System.Windows.Forms.ComboBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cboZona);
            this.grpDatos.Controls.Add(this.lblZona);
            this.grpDatos.Controls.Add(this.txtComision);
            this.grpDatos.Controls.Add(this.lblComision);
            this.grpDatos.Controls.Add(this.txtSalario);
            this.grpDatos.Controls.Add(this.lblSalario);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblFechaNacimiento);
            this.grpDatos.Controls.Add(this.dtmFechaNacimiento);
            this.grpDatos.Controls.Add(this.radComercial);
            this.grpDatos.Controls.Add(this.radRepartidor);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(271, 236);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos empleados";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(289, 12);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(175, 238);
            this.lstEmpleados.TabIndex = 1;
            this.lstEmpleados.Click += new System.EventHandler(this.lstEmpleados_Click);
            // 
            // radRepartidor
            // 
            this.radRepartidor.AutoSize = true;
            this.radRepartidor.Checked = true;
            this.radRepartidor.Location = new System.Drawing.Point(6, 19);
            this.radRepartidor.Name = "radRepartidor";
            this.radRepartidor.Size = new System.Drawing.Size(74, 17);
            this.radRepartidor.TabIndex = 0;
            this.radRepartidor.TabStop = true;
            this.radRepartidor.Text = "Repartidor";
            this.radRepartidor.UseVisualStyleBackColor = true;
            this.radRepartidor.CheckedChanged += new System.EventHandler(this.radRepartidor_CheckedChanged);
            // 
            // radComercial
            // 
            this.radComercial.AutoSize = true;
            this.radComercial.Location = new System.Drawing.Point(6, 42);
            this.radComercial.Name = "radComercial";
            this.radComercial.Size = new System.Drawing.Size(71, 17);
            this.radComercial.TabIndex = 1;
            this.radComercial.Text = "Comercial";
            this.radComercial.UseVisualStyleBackColor = true;
            this.radComercial.CheckedChanged += new System.EventHandler(this.radComercial_CheckedChanged);
            // 
            // dtmFechaActual
            // 
            this.dtmFechaActual.Enabled = false;
            this.dtmFechaActual.Location = new System.Drawing.Point(394, 301);
            this.dtmFechaActual.Name = "dtmFechaActual";
            this.dtmFechaActual.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaActual.TabIndex = 2;
            // 
            // dtmFechaNacimiento
            // 
            this.dtmFechaNacimiento.Location = new System.Drawing.Point(34, 86);
            this.dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            this.dtmFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaNacimiento.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(86, 70);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(11, 153);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(56, 150);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(1, 179);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(49, 13);
            this.lblComision.TabIndex = 8;
            this.lblComision.Text = "Comision";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(56, 176);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(100, 20);
            this.txtComision.TabIndex = 9;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(18, 205);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(32, 13);
            this.lblZona.TabIndex = 10;
            this.lblZona.Text = "Zona";
            // 
            // cboZona
            // 
            this.cboZona.FormattingEnabled = true;
            this.cboZona.Location = new System.Drawing.Point(56, 202);
            this.cboZona.Name = "cboZona";
            this.cboZona.Size = new System.Drawing.Size(100, 21);
            this.cboZona.TabIndex = 11;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(318, 305);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(70, 13);
            this.lblFechaActual.TabIndex = 3;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 295);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(95, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "&Crear empleado";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(116, 295);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 324);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.dtmFechaActual);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.ComboBox cboZona;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtmFechaNacimiento;
        private System.Windows.Forms.RadioButton radComercial;
        private System.Windows.Forms.RadioButton radRepartidor;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.DateTimePicker dtmFechaActual;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

