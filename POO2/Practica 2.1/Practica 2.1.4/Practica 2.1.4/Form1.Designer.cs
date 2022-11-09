namespace Practica_2._1._4
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
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.grpObjetos = new System.Windows.Forms.GroupBox();
            this.radVentana = new System.Windows.Forms.RadioButton();
            this.radPared = new System.Windows.Forms.RadioButton();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnTiempoPintura = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.grpObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(12, 28);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(34, 13);
            this.lblLargo.TabIndex = 12;
            this.lblLargo.Text = "Largo";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(12, 69);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 14;
            this.lblAncho.Text = "Ancho";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(52, 28);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 15;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(52, 66);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 16;
            // 
            // grpObjetos
            // 
            this.grpObjetos.Controls.Add(this.radVentana);
            this.grpObjetos.Controls.Add(this.radPared);
            this.grpObjetos.Location = new System.Drawing.Point(15, 115);
            this.grpObjetos.Name = "grpObjetos";
            this.grpObjetos.Size = new System.Drawing.Size(87, 67);
            this.grpObjetos.TabIndex = 20;
            this.grpObjetos.TabStop = false;
            this.grpObjetos.Text = "Objetos";
            // 
            // radVentana
            // 
            this.radVentana.AutoSize = true;
            this.radVentana.Location = new System.Drawing.Point(6, 42);
            this.radVentana.Name = "radVentana";
            this.radVentana.Size = new System.Drawing.Size(65, 17);
            this.radVentana.TabIndex = 1;
            this.radVentana.Text = "Ventana";
            this.radVentana.UseVisualStyleBackColor = true;
            // 
            // radPared
            // 
            this.radPared.AutoSize = true;
            this.radPared.Checked = true;
            this.radPared.Location = new System.Drawing.Point(6, 19);
            this.radPared.Name = "radPared";
            this.radPared.Size = new System.Drawing.Size(53, 17);
            this.radPared.TabIndex = 0;
            this.radPared.TabStop = true;
            this.radPared.Text = "Pared";
            this.radPared.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(15, 188);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 34);
            this.btnArea.TabIndex = 23;
            this.btnArea.Text = "&Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnTiempoPintura
            // 
            this.btnTiempoPintura.Location = new System.Drawing.Point(96, 188);
            this.btnTiempoPintura.Name = "btnTiempoPintura";
            this.btnTiempoPintura.Size = new System.Drawing.Size(75, 34);
            this.btnTiempoPintura.TabIndex = 24;
            this.btnTiempoPintura.Text = "&Tiempo Pintura";
            this.btnTiempoPintura.UseVisualStyleBackColor = true;
            this.btnTiempoPintura.Click += new System.EventHandler(this.btnTiempoPintura_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(177, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(177, 39);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(75, 34);
            this.btnCapturarDatos.TabIndex = 26;
            this.btnCapturarDatos.Text = "&Capturar Datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 235);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTiempoPintura);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.grpObjetos);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblLargo);
            this.Name = "Form1";
            this.Text = "Pintura";
            this.grpObjetos.ResumeLayout(false);
            this.grpObjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.GroupBox grpObjetos;
        private System.Windows.Forms.RadioButton radVentana;
        private System.Windows.Forms.RadioButton radPared;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnTiempoPintura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCapturarDatos;
    }
}

