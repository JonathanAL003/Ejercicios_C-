namespace Practica_3._1._6
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
            this.grpPosicion = new System.Windows.Forms.GroupBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.radPortero = new System.Windows.Forms.RadioButton();
            this.radDefensa = new System.Windows.Forms.RadioButton();
            this.radMedio = new System.Windows.Forms.RadioButton();
            this.radDelantero = new System.Windows.Forms.RadioButton();
            this.lblNumUniforme = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMinJugados = new System.Windows.Forms.Label();
            this.lblGolesAnotados = new System.Windows.Forms.Label();
            this.txtNumUniforme = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMinJugados = new System.Windows.Forms.TextBox();
            this.txtGolesAnotados = new System.Windows.Forms.TextBox();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpPosicion.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPosicion
            // 
            this.grpPosicion.Controls.Add(this.radDelantero);
            this.grpPosicion.Controls.Add(this.radMedio);
            this.grpPosicion.Controls.Add(this.radDefensa);
            this.grpPosicion.Controls.Add(this.radPortero);
            this.grpPosicion.Location = new System.Drawing.Point(12, 12);
            this.grpPosicion.Name = "grpPosicion";
            this.grpPosicion.Size = new System.Drawing.Size(123, 124);
            this.grpPosicion.TabIndex = 0;
            this.grpPosicion.TabStop = false;
            this.grpPosicion.Text = "Posicion del jugador";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtGolesAnotados);
            this.grpDatos.Controls.Add(this.txtMinJugados);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtNumUniforme);
            this.grpDatos.Controls.Add(this.lblGolesAnotados);
            this.grpDatos.Controls.Add(this.lblMinJugados);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblNumUniforme);
            this.grpDatos.Location = new System.Drawing.Point(12, 142);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(234, 157);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del jugador";
            // 
            // radPortero
            // 
            this.radPortero.AutoSize = true;
            this.radPortero.Checked = true;
            this.radPortero.Location = new System.Drawing.Point(6, 19);
            this.radPortero.Name = "radPortero";
            this.radPortero.Size = new System.Drawing.Size(59, 17);
            this.radPortero.TabIndex = 0;
            this.radPortero.TabStop = true;
            this.radPortero.Text = "Portero";
            this.radPortero.UseVisualStyleBackColor = true;
            this.radPortero.CheckedChanged += new System.EventHandler(this.radPortero_CheckedChanged);
            // 
            // radDefensa
            // 
            this.radDefensa.AutoSize = true;
            this.radDefensa.Location = new System.Drawing.Point(6, 42);
            this.radDefensa.Name = "radDefensa";
            this.radDefensa.Size = new System.Drawing.Size(65, 17);
            this.radDefensa.TabIndex = 1;
            this.radDefensa.Text = "Defensa";
            this.radDefensa.UseVisualStyleBackColor = true;
            this.radDefensa.CheckedChanged += new System.EventHandler(this.radDefensa_CheckedChanged);
            // 
            // radMedio
            // 
            this.radMedio.AutoSize = true;
            this.radMedio.Location = new System.Drawing.Point(6, 65);
            this.radMedio.Name = "radMedio";
            this.radMedio.Size = new System.Drawing.Size(54, 17);
            this.radMedio.TabIndex = 2;
            this.radMedio.Text = "Medio";
            this.radMedio.UseVisualStyleBackColor = true;
            this.radMedio.CheckedChanged += new System.EventHandler(this.radMedio_CheckedChanged);
            // 
            // radDelantero
            // 
            this.radDelantero.AutoSize = true;
            this.radDelantero.Location = new System.Drawing.Point(6, 88);
            this.radDelantero.Name = "radDelantero";
            this.radDelantero.Size = new System.Drawing.Size(71, 17);
            this.radDelantero.TabIndex = 3;
            this.radDelantero.Text = "Delantero";
            this.radDelantero.UseVisualStyleBackColor = true;
            this.radDelantero.CheckedChanged += new System.EventHandler(this.radDelantero_CheckedChanged);
            // 
            // lblNumUniforme
            // 
            this.lblNumUniforme.AutoSize = true;
            this.lblNumUniforme.Location = new System.Drawing.Point(6, 31);
            this.lblNumUniforme.Name = "lblNumUniforme";
            this.lblNumUniforme.Size = new System.Drawing.Size(75, 13);
            this.lblNumUniforme.TabIndex = 0;
            this.lblNumUniforme.Text = "Núm. uniforme";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMinJugados
            // 
            this.lblMinJugados.AutoSize = true;
            this.lblMinJugados.Location = new System.Drawing.Point(6, 96);
            this.lblMinJugados.Name = "lblMinJugados";
            this.lblMinJugados.Size = new System.Drawing.Size(70, 13);
            this.lblMinJugados.TabIndex = 2;
            this.lblMinJugados.Text = "Min. Jugados";
            // 
            // lblGolesAnotados
            // 
            this.lblGolesAnotados.AutoSize = true;
            this.lblGolesAnotados.Location = new System.Drawing.Point(6, 126);
            this.lblGolesAnotados.Name = "lblGolesAnotados";
            this.lblGolesAnotados.Size = new System.Drawing.Size(81, 13);
            this.lblGolesAnotados.TabIndex = 3;
            this.lblGolesAnotados.Text = "Goles anotados";
            // 
            // txtNumUniforme
            // 
            this.txtNumUniforme.Location = new System.Drawing.Point(83, 31);
            this.txtNumUniforme.Name = "txtNumUniforme";
            this.txtNumUniforme.Size = new System.Drawing.Size(40, 20);
            this.txtNumUniforme.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtMinJugados
            // 
            this.txtMinJugados.Location = new System.Drawing.Point(83, 93);
            this.txtMinJugados.Name = "txtMinJugados";
            this.txtMinJugados.Size = new System.Drawing.Size(29, 20);
            this.txtMinJugados.TabIndex = 6;
            // 
            // txtGolesAnotados
            // 
            this.txtGolesAnotados.Location = new System.Drawing.Point(83, 123);
            this.txtGolesAnotados.Name = "txtGolesAnotados";
            this.txtGolesAnotados.Size = new System.Drawing.Size(29, 20);
            this.txtGolesAnotados.TabIndex = 7;
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(150, 25);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(96, 23);
            this.btnCapturarDatos.TabIndex = 2;
            this.btnCapturarDatos.Text = "&Capturar Datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(150, 60);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(96, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "&Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(150, 94);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 324);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpPosicion);
            this.Name = "Form1";
            this.Text = "Equipo";
            this.grpPosicion.ResumeLayout(false);
            this.grpPosicion.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPosicion;
        private System.Windows.Forms.RadioButton radDelantero;
        private System.Windows.Forms.RadioButton radMedio;
        private System.Windows.Forms.RadioButton radDefensa;
        private System.Windows.Forms.RadioButton radPortero;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtGolesAnotados;
        private System.Windows.Forms.TextBox txtMinJugados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumUniforme;
        private System.Windows.Forms.Label lblGolesAnotados;
        private System.Windows.Forms.Label lblMinJugados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumUniforme;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}

