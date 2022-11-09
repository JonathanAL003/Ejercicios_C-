namespace Practica_2._1._3
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
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.btnModificarLargo = new System.Windows.Forms.Button();
            this.btnModificarAncho = new System.Windows.Forms.Button();
            this.btnConsultarLargo = new System.Windows.Forms.Button();
            this.btnConsultarAncho = new System.Windows.Forms.Button();
            this.grpObjetos = new System.Windows.Forms.GroupBox();
            this.radPared = new System.Windows.Forms.RadioButton();
            this.radVentana = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTiempoPintura = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.grpObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(12, 19);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(34, 13);
            this.lblLargo.TabIndex = 11;
            this.lblLargo.Text = "Largo";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(52, 17);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 12;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(12, 61);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 13;
            this.lblAncho.Text = "Ancho";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(56, 58);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 14;
            // 
            // btnModificarLargo
            // 
            this.btnModificarLargo.Location = new System.Drawing.Point(158, 15);
            this.btnModificarLargo.Name = "btnModificarLargo";
            this.btnModificarLargo.Size = new System.Drawing.Size(98, 23);
            this.btnModificarLargo.TabIndex = 15;
            this.btnModificarLargo.Text = "Modificar Largo";
            this.btnModificarLargo.UseVisualStyleBackColor = true;
            this.btnModificarLargo.Click += new System.EventHandler(this.btnModificarLargo_Click);
            // 
            // btnModificarAncho
            // 
            this.btnModificarAncho.Location = new System.Drawing.Point(162, 56);
            this.btnModificarAncho.Name = "btnModificarAncho";
            this.btnModificarAncho.Size = new System.Drawing.Size(98, 23);
            this.btnModificarAncho.TabIndex = 16;
            this.btnModificarAncho.Text = "Modificar Ancho";
            this.btnModificarAncho.UseVisualStyleBackColor = true;
            this.btnModificarAncho.Click += new System.EventHandler(this.btnModificarAncho_Click);
            // 
            // btnConsultarLargo
            // 
            this.btnConsultarLargo.Location = new System.Drawing.Point(262, 15);
            this.btnConsultarLargo.Name = "btnConsultarLargo";
            this.btnConsultarLargo.Size = new System.Drawing.Size(95, 23);
            this.btnConsultarLargo.TabIndex = 17;
            this.btnConsultarLargo.Text = "Consultar Largo";
            this.btnConsultarLargo.UseVisualStyleBackColor = true;
            this.btnConsultarLargo.Click += new System.EventHandler(this.btnConsultarLargo_Click);
            // 
            // btnConsultarAncho
            // 
            this.btnConsultarAncho.Location = new System.Drawing.Point(266, 56);
            this.btnConsultarAncho.Name = "btnConsultarAncho";
            this.btnConsultarAncho.Size = new System.Drawing.Size(95, 23);
            this.btnConsultarAncho.TabIndex = 18;
            this.btnConsultarAncho.Text = "Consultar Ancho";
            this.btnConsultarAncho.UseVisualStyleBackColor = true;
            this.btnConsultarAncho.Click += new System.EventHandler(this.btnConsultarAncho_Click);
            // 
            // grpObjetos
            // 
            this.grpObjetos.Controls.Add(this.radVentana);
            this.grpObjetos.Controls.Add(this.radPared);
            this.grpObjetos.Location = new System.Drawing.Point(15, 108);
            this.grpObjetos.Name = "grpObjetos";
            this.grpObjetos.Size = new System.Drawing.Size(87, 67);
            this.grpObjetos.TabIndex = 19;
            this.grpObjetos.TabStop = false;
            this.grpObjetos.Text = "Objetos";
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(290, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTiempoPintura
            // 
            this.btnTiempoPintura.Location = new System.Drawing.Point(209, 142);
            this.btnTiempoPintura.Name = "btnTiempoPintura";
            this.btnTiempoPintura.Size = new System.Drawing.Size(75, 34);
            this.btnTiempoPintura.TabIndex = 21;
            this.btnTiempoPintura.Text = "&Tiempo Pintura";
            this.btnTiempoPintura.UseVisualStyleBackColor = true;
            this.btnTiempoPintura.Click += new System.EventHandler(this.btnTiempoPintura_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(128, 141);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 34);
            this.btnArea.TabIndex = 22;
            this.btnArea.Text = "&Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 188);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnTiempoPintura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpObjetos);
            this.Controls.Add(this.btnConsultarAncho);
            this.Controls.Add(this.btnConsultarLargo);
            this.Controls.Add(this.btnModificarAncho);
            this.Controls.Add(this.btnModificarLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtLargo);
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
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Button btnModificarLargo;
        private System.Windows.Forms.Button btnModificarAncho;
        private System.Windows.Forms.Button btnConsultarLargo;
        private System.Windows.Forms.Button btnConsultarAncho;
        private System.Windows.Forms.GroupBox grpObjetos;
        private System.Windows.Forms.RadioButton radVentana;
        private System.Windows.Forms.RadioButton radPared;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTiempoPintura;
        private System.Windows.Forms.Button btnArea;
    }
}

