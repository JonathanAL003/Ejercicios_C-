namespace Practica_2._1._7
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
            this.lblGradosCentigrados = new System.Windows.Forms.Label();
            this.txtGradosCentigrados = new System.Windows.Forms.TextBox();
            this.btnConvertirAFarenheit = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCapturarGrados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradosCentigrados
            // 
            this.lblGradosCentigrados.AutoSize = true;
            this.lblGradosCentigrados.Location = new System.Drawing.Point(12, 22);
            this.lblGradosCentigrados.Name = "lblGradosCentigrados";
            this.lblGradosCentigrados.Size = new System.Drawing.Size(103, 13);
            this.lblGradosCentigrados.TabIndex = 0;
            this.lblGradosCentigrados.Text = "Grados Centigrados:";
            // 
            // txtGradosCentigrados
            // 
            this.txtGradosCentigrados.Location = new System.Drawing.Point(121, 19);
            this.txtGradosCentigrados.Name = "txtGradosCentigrados";
            this.txtGradosCentigrados.Size = new System.Drawing.Size(68, 20);
            this.txtGradosCentigrados.TabIndex = 1;
            // 
            // btnConvertirAFarenheit
            // 
            this.btnConvertirAFarenheit.Location = new System.Drawing.Point(74, 91);
            this.btnConvertirAFarenheit.Name = "btnConvertirAFarenheit";
            this.btnConvertirAFarenheit.Size = new System.Drawing.Size(115, 23);
            this.btnConvertirAFarenheit.TabIndex = 2;
            this.btnConvertirAFarenheit.Text = "&Convertir a Farenheit";
            this.btnConvertirAFarenheit.UseVisualStyleBackColor = true;
            this.btnConvertirAFarenheit.Click += new System.EventHandler(this.btnConvertirAFarenheit_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(114, 120);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCapturarGrados
            // 
            this.btnCapturarGrados.Location = new System.Drawing.Point(74, 62);
            this.btnCapturarGrados.Name = "btnCapturarGrados";
            this.btnCapturarGrados.Size = new System.Drawing.Size(115, 23);
            this.btnCapturarGrados.TabIndex = 4;
            this.btnCapturarGrados.Text = "Capturar &Grados";
            this.btnCapturarGrados.UseVisualStyleBackColor = true;
            this.btnCapturarGrados.Click += new System.EventHandler(this.btnCapturarGrados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 155);
            this.Controls.Add(this.btnCapturarGrados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertirAFarenheit);
            this.Controls.Add(this.txtGradosCentigrados);
            this.Controls.Add(this.lblGradosCentigrados);
            this.Name = "Form1";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradosCentigrados;
        private System.Windows.Forms.TextBox txtGradosCentigrados;
        private System.Windows.Forms.Button btnConvertirAFarenheit;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCapturarGrados;
    }
}

