namespace Practica_2._1._5
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnModificarFecha = new System.Windows.Forms.Button();
            this.btnConsultarFecha = new System.Windows.Forms.Button();
            this.btnConsultarFechaLetra = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(12, 9);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(31, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Día: ";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(12, 36);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(12, 62);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(49, 9);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(42, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(49, 36);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(42, 20);
            this.txtMes.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(49, 62);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(52, 20);
            this.txtAño.TabIndex = 5;
            // 
            // btnModificarFecha
            // 
            this.btnModificarFecha.Location = new System.Drawing.Point(122, 9);
            this.btnModificarFecha.Name = "btnModificarFecha";
            this.btnModificarFecha.Size = new System.Drawing.Size(142, 22);
            this.btnModificarFecha.TabIndex = 6;
            this.btnModificarFecha.Text = "&Modificar Fecha";
            this.btnModificarFecha.UseVisualStyleBackColor = true;
            this.btnModificarFecha.Click += new System.EventHandler(this.btnModificarFecha_Click);
            // 
            // btnConsultarFecha
            // 
            this.btnConsultarFecha.Location = new System.Drawing.Point(122, 62);
            this.btnConsultarFecha.Name = "btnConsultarFecha";
            this.btnConsultarFecha.Size = new System.Drawing.Size(142, 23);
            this.btnConsultarFecha.TabIndex = 7;
            this.btnConsultarFecha.Text = "Consultar &Fecha";
            this.btnConsultarFecha.UseVisualStyleBackColor = true;
            this.btnConsultarFecha.Click += new System.EventHandler(this.btnConsultarFecha_Click);
            // 
            // btnConsultarFechaLetra
            // 
            this.btnConsultarFechaLetra.Location = new System.Drawing.Point(122, 90);
            this.btnConsultarFechaLetra.Name = "btnConsultarFechaLetra";
            this.btnConsultarFechaLetra.Size = new System.Drawing.Size(142, 23);
            this.btnConsultarFechaLetra.TabIndex = 8;
            this.btnConsultarFechaLetra.Text = "&Consultar Fecha con Letra";
            this.btnConsultarFechaLetra.UseVisualStyleBackColor = true;
            this.btnConsultarFechaLetra.Click += new System.EventHandler(this.btnConsultarFechaLetra_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(209, 119);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 22);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(122, 36);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(142, 23);
            this.btnVerificar.TabIndex = 27;
            this.btnVerificar.Text = "&Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 151);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultarFechaLetra);
            this.Controls.Add(this.btnConsultarFecha);
            this.Controls.Add(this.btnModificarFecha);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Name = "Form1";
            this.Text = "Fechas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnModificarFecha;
        private System.Windows.Forms.Button btnConsultarFecha;
        private System.Windows.Forms.Button btnConsultarFechaLetra;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerificar;
    }
}

