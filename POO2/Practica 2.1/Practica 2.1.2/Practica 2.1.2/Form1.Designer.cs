namespace Practica_2._1._2
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnCapturarRadio = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbObjetos = new System.Windows.Forms.GroupBox();
            this.radMoneda = new System.Windows.Forms.RadioButton();
            this.radRueda = new System.Windows.Forms.RadioButton();
            this.gpbObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(12, 9);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(38, 13);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(56, 6);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(66, 20);
            this.txtRadio.TabIndex = 2;
            // 
            // btnCapturarRadio
            // 
            this.btnCapturarRadio.Location = new System.Drawing.Point(153, 6);
            this.btnCapturarRadio.Name = "btnCapturarRadio";
            this.btnCapturarRadio.Size = new System.Drawing.Size(75, 34);
            this.btnCapturarRadio.TabIndex = 4;
            this.btnCapturarRadio.Text = "Capturar &Radio";
            this.btnCapturarRadio.UseVisualStyleBackColor = true;
            this.btnCapturarRadio.Click += new System.EventHandler(this.btnCapturarRadio_Click);
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(153, 46);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(75, 34);
            this.btnCalcularArea.TabIndex = 5;
            this.btnCalcularArea.Text = "Calcular &Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(153, 88);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(75, 34);
            this.btnCalcularPerimetro.TabIndex = 6;
            this.btnCalcularPerimetro.Text = "Calcular &Perimetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetro.Click += new System.EventHandler(this.btnCalcularPerimetro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(153, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpbObjetos
            // 
            this.gpbObjetos.Controls.Add(this.radMoneda);
            this.gpbObjetos.Controls.Add(this.radRueda);
            this.gpbObjetos.Location = new System.Drawing.Point(12, 65);
            this.gpbObjetos.Name = "gpbObjetos";
            this.gpbObjetos.Size = new System.Drawing.Size(87, 83);
            this.gpbObjetos.TabIndex = 8;
            this.gpbObjetos.TabStop = false;
            this.gpbObjetos.Text = "Objetos";
            // 
            // radMoneda
            // 
            this.radMoneda.AutoSize = true;
            this.radMoneda.Location = new System.Drawing.Point(6, 55);
            this.radMoneda.Name = "radMoneda";
            this.radMoneda.Size = new System.Drawing.Size(64, 17);
            this.radMoneda.TabIndex = 1;
            this.radMoneda.Text = "Moneda";
            this.radMoneda.UseVisualStyleBackColor = true;
            // 
            // radRueda
            // 
            this.radRueda.AutoSize = true;
            this.radRueda.Checked = true;
            this.radRueda.Location = new System.Drawing.Point(6, 32);
            this.radRueda.Name = "radRueda";
            this.radRueda.Size = new System.Drawing.Size(57, 17);
            this.radRueda.TabIndex = 0;
            this.radRueda.TabStop = true;
            this.radRueda.Text = "Rueda";
            this.radRueda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 179);
            this.Controls.Add(this.gpbObjetos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularPerimetro);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.btnCapturarRadio);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Name = "Form1";
            this.Text = "Circunferencia";
            this.gpbObjetos.ResumeLayout(false);
            this.gpbObjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCapturarRadio;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gpbObjetos;
        private System.Windows.Forms.RadioButton radMoneda;
        private System.Windows.Forms.RadioButton radRueda;
    }
}

