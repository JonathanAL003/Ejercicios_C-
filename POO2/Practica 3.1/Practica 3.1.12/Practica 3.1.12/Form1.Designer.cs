namespace Practica_3._1._12
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
            this.grpPersonas = new System.Windows.Forms.GroupBox();
            this.radPersona = new System.Windows.Forms.RadioButton();
            this.radEmpleado = new System.Windows.Forms.RadioButton();
            this.radProfesor = new System.Windows.Forms.RadioButton();
            this.radAdministrador = new System.Windows.Forms.RadioButton();
            this.radEstudiante = new System.Windows.Forms.RadioButton();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblJefe = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpPersonas.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonas
            // 
            this.grpPersonas.Controls.Add(this.radPersona);
            this.grpPersonas.Controls.Add(this.radEmpleado);
            this.grpPersonas.Controls.Add(this.radProfesor);
            this.grpPersonas.Controls.Add(this.radEstudiante);
            this.grpPersonas.Controls.Add(this.radAdministrador);
            this.grpPersonas.Location = new System.Drawing.Point(12, 12);
            this.grpPersonas.Name = "grpPersonas";
            this.grpPersonas.Size = new System.Drawing.Size(116, 149);
            this.grpPersonas.TabIndex = 0;
            this.grpPersonas.TabStop = false;
            this.grpPersonas.Text = "Personas";
            // 
            // radPersona
            // 
            this.radPersona.AutoSize = true;
            this.radPersona.Checked = true;
            this.radPersona.Location = new System.Drawing.Point(6, 19);
            this.radPersona.Name = "radPersona";
            this.radPersona.Size = new System.Drawing.Size(64, 17);
            this.radPersona.TabIndex = 4;
            this.radPersona.TabStop = true;
            this.radPersona.Text = "Persona";
            this.radPersona.UseVisualStyleBackColor = true;
            this.radPersona.CheckedChanged += new System.EventHandler(this.radPersona_CheckedChanged);
            // 
            // radEmpleado
            // 
            this.radEmpleado.AutoSize = true;
            this.radEmpleado.Location = new System.Drawing.Point(6, 42);
            this.radEmpleado.Name = "radEmpleado";
            this.radEmpleado.Size = new System.Drawing.Size(72, 17);
            this.radEmpleado.TabIndex = 3;
            this.radEmpleado.Text = "Empleado";
            this.radEmpleado.UseVisualStyleBackColor = true;
            this.radEmpleado.CheckedChanged += new System.EventHandler(this.radEmpleado_CheckedChanged);
            // 
            // radProfesor
            // 
            this.radProfesor.AutoSize = true;
            this.radProfesor.Location = new System.Drawing.Point(6, 111);
            this.radProfesor.Name = "radProfesor";
            this.radProfesor.Size = new System.Drawing.Size(64, 17);
            this.radProfesor.TabIndex = 2;
            this.radProfesor.TabStop = true;
            this.radProfesor.Text = "Profesor";
            this.radProfesor.UseVisualStyleBackColor = true;
            this.radProfesor.CheckedChanged += new System.EventHandler(this.radProfesor_CheckedChanged);
            // 
            // radAdministrador
            // 
            this.radAdministrador.AutoSize = true;
            this.radAdministrador.Location = new System.Drawing.Point(6, 88);
            this.radAdministrador.Name = "radAdministrador";
            this.radAdministrador.Size = new System.Drawing.Size(88, 17);
            this.radAdministrador.TabIndex = 1;
            this.radAdministrador.Text = "Administrador";
            this.radAdministrador.UseVisualStyleBackColor = true;
            this.radAdministrador.CheckedChanged += new System.EventHandler(this.radAdministrador_CheckedChanged);
            // 
            // radEstudiante
            // 
            this.radEstudiante.AutoSize = true;
            this.radEstudiante.Location = new System.Drawing.Point(6, 65);
            this.radEstudiante.Name = "radEstudiante";
            this.radEstudiante.Size = new System.Drawing.Size(75, 17);
            this.radEstudiante.TabIndex = 0;
            this.radEstudiante.Text = "Estudiante";
            this.radEstudiante.UseVisualStyleBackColor = true;
            this.radEstudiante.CheckedChanged += new System.EventHandler(this.radEstudiante_CheckedChanged);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtCarrera);
            this.grpDatos.Controls.Add(this.txtPuesto);
            this.grpDatos.Controls.Add(this.txtGrupo);
            this.grpDatos.Controls.Add(this.txtGrado);
            this.grpDatos.Controls.Add(this.txtJefe);
            this.grpDatos.Controls.Add(this.txtHorario);
            this.grpDatos.Controls.Add(this.txtDomicilio);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblCarrera);
            this.grpDatos.Controls.Add(this.lblPuesto);
            this.grpDatos.Controls.Add(this.lblGrupo);
            this.grpDatos.Controls.Add(this.lblGrado);
            this.grpDatos.Controls.Add(this.lblJefe);
            this.grpDatos.Controls.Add(this.lblHorario);
            this.grpDatos.Controls.Add(this.lblDomicilio);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Location = new System.Drawing.Point(134, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(327, 222);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(9, 191);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 7;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(10, 165);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 6;
            this.lblPuesto.Text = "Puesto";
            this.lblPuesto.Click += new System.EventHandler(this.lblPuesto_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(177, 130);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(14, 130);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(36, 13);
            this.lblGrado.TabIndex = 4;
            this.lblGrado.Text = "Grado";
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(23, 105);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(27, 13);
            this.lblJefe.TabIndex = 3;
            this.lblJefe.Text = "Jefe";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(9, 74);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horario";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(1, 49);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 1;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(56, 46);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(243, 20);
            this.txtDomicilio.TabIndex = 9;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(56, 72);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 10;
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(56, 98);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(157, 20);
            this.txtJefe.TabIndex = 11;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(56, 127);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(41, 20);
            this.txtGrado.TabIndex = 12;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(219, 127);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(41, 20);
            this.txtGrupo.TabIndex = 13;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(56, 162);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto.TabIndex = 14;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(56, 188);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(157, 20);
            this.txtCarrera.TabIndex = 15;
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(18, 167);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(88, 23);
            this.btnCapturarDatos.TabIndex = 2;
            this.btnCapturarDatos.Text = "&Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(18, 196);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(88, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "&Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(18, 225);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 253);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpPersonas);
            this.Name = "Form1";
            this.Text = "Escuela";
            this.grpPersonas.ResumeLayout(false);
            this.grpPersonas.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonas;
        private System.Windows.Forms.RadioButton radPersona;
        private System.Windows.Forms.RadioButton radEmpleado;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.RadioButton radAdministrador;
        private System.Windows.Forms.RadioButton radEstudiante;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}

