namespace Practica_3._1._7
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
            this.radPitcher = new System.Windows.Forms.RadioButton();
            this.radJugadorDePosicion = new System.Windows.Forms.RadioButton();
            this.radBateador = new System.Windows.Forms.RadioButton();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNumUniforme = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPonches = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.txtNumUniforme = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPonches = new System.Windows.Forms.TextBox();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.grpPosicion.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPosicion
            // 
            this.grpPosicion.Controls.Add(this.radBateador);
            this.grpPosicion.Controls.Add(this.radJugadorDePosicion);
            this.grpPosicion.Controls.Add(this.radPitcher);
            this.grpPosicion.Location = new System.Drawing.Point(12, 12);
            this.grpPosicion.Name = "grpPosicion";
            this.grpPosicion.Size = new System.Drawing.Size(143, 92);
            this.grpPosicion.TabIndex = 0;
            this.grpPosicion.TabStop = false;
            this.grpPosicion.Text = "Posición del jugador";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtErrores);
            this.grpDatos.Controls.Add(this.txtHits);
            this.grpDatos.Controls.Add(this.txtPonches);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtNumUniforme);
            this.grpDatos.Controls.Add(this.lblErrores);
            this.grpDatos.Controls.Add(this.lblHits);
            this.grpDatos.Controls.Add(this.lblPonches);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblNumUniforme);
            this.grpDatos.Location = new System.Drawing.Point(171, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(219, 168);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del jugador";
            // 
            // radPitcher
            // 
            this.radPitcher.AutoSize = true;
            this.radPitcher.Location = new System.Drawing.Point(6, 65);
            this.radPitcher.Name = "radPitcher";
            this.radPitcher.Size = new System.Drawing.Size(58, 17);
            this.radPitcher.TabIndex = 0;
            this.radPitcher.Text = "Pitcher";
            this.radPitcher.UseVisualStyleBackColor = true;
            this.radPitcher.CheckedChanged += new System.EventHandler(this.radPitcher_CheckedChanged);
            // 
            // radJugadorDePosicion
            // 
            this.radJugadorDePosicion.AutoSize = true;
            this.radJugadorDePosicion.Location = new System.Drawing.Point(6, 42);
            this.radJugadorDePosicion.Name = "radJugadorDePosicion";
            this.radJugadorDePosicion.Size = new System.Drawing.Size(120, 17);
            this.radJugadorDePosicion.TabIndex = 1;
            this.radJugadorDePosicion.Text = "Jugador de posición";
            this.radJugadorDePosicion.UseVisualStyleBackColor = true;
            this.radJugadorDePosicion.CheckedChanged += new System.EventHandler(this.radJugadorDePosicion_CheckedChanged);
            // 
            // radBateador
            // 
            this.radBateador.AutoSize = true;
            this.radBateador.Checked = true;
            this.radBateador.Location = new System.Drawing.Point(6, 19);
            this.radBateador.Name = "radBateador";
            this.radBateador.Size = new System.Drawing.Size(120, 17);
            this.radBateador.TabIndex = 2;
            this.radBateador.TabStop = true;
            this.radBateador.Text = "Bateador designado";
            this.radBateador.UseVisualStyleBackColor = true;
            this.radBateador.CheckedChanged += new System.EventHandler(this.radBateador_CheckedChanged);
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(12, 110);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(94, 23);
            this.btnCapturarDatos.TabIndex = 2;
            this.btnCapturarDatos.Text = "&Capturar Datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(12, 139);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(94, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "&Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 168);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNumUniforme
            // 
            this.lblNumUniforme.AutoSize = true;
            this.lblNumUniforme.Location = new System.Drawing.Point(6, 23);
            this.lblNumUniforme.Name = "lblNumUniforme";
            this.lblNumUniforme.Size = new System.Drawing.Size(75, 13);
            this.lblNumUniforme.TabIndex = 0;
            this.lblNumUniforme.Text = "Núm. uniforme";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPonches
            // 
            this.lblPonches.AutoSize = true;
            this.lblPonches.Location = new System.Drawing.Point(32, 79);
            this.lblPonches.Name = "lblPonches";
            this.lblPonches.Size = new System.Drawing.Size(49, 13);
            this.lblPonches.TabIndex = 2;
            this.lblPonches.Text = "Ponches";
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Location = new System.Drawing.Point(56, 110);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(25, 13);
            this.lblHits.TabIndex = 3;
            this.lblHits.Text = "Hits";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(41, 140);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(40, 13);
            this.lblErrores.TabIndex = 4;
            this.lblErrores.Text = "Errores";
            // 
            // txtNumUniforme
            // 
            this.txtNumUniforme.Location = new System.Drawing.Point(87, 20);
            this.txtNumUniforme.Name = "txtNumUniforme";
            this.txtNumUniforme.Size = new System.Drawing.Size(39, 20);
            this.txtNumUniforme.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtPonches
            // 
            this.txtPonches.Location = new System.Drawing.Point(87, 76);
            this.txtPonches.Name = "txtPonches";
            this.txtPonches.Size = new System.Drawing.Size(39, 20);
            this.txtPonches.TabIndex = 7;
            // 
            // txtHits
            // 
            this.txtHits.Location = new System.Drawing.Point(87, 107);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(39, 20);
            this.txtHits.TabIndex = 8;
            // 
            // txtErrores
            // 
            this.txtErrores.Location = new System.Drawing.Point(87, 137);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.Size = new System.Drawing.Size(39, 20);
            this.txtErrores.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 202);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpPosicion);
            this.Name = "Form1";
            this.Text = "Equipo de beisbol";
            this.grpPosicion.ResumeLayout(false);
            this.grpPosicion.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPosicion;
        private System.Windows.Forms.RadioButton radBateador;
        private System.Windows.Forms.RadioButton radJugadorDePosicion;
        private System.Windows.Forms.RadioButton radPitcher;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.TextBox txtPonches;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumUniforme;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblPonches;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumUniforme;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}

