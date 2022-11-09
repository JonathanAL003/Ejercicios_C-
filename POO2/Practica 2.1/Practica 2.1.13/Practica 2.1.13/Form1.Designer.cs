namespace Practica_2._1._13
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnConvertirASegundos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de dias:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(155, 9);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(83, 20);
            this.txtDias.TabIndex = 1;
            // 
            // btnConvertirASegundos
            // 
            this.btnConvertirASegundos.Location = new System.Drawing.Point(28, 47);
            this.btnConvertirASegundos.Name = "btnConvertirASegundos";
            this.btnConvertirASegundos.Size = new System.Drawing.Size(121, 23);
            this.btnConvertirASegundos.TabIndex = 2;
            this.btnConvertirASegundos.Text = "&Convertir a Segundos";
            this.btnConvertirASegundos.UseVisualStyleBackColor = true;
            this.btnConvertirASegundos.Click += new System.EventHandler(this.btnConvertirASegundos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(163, 47);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 92);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertirASegundos);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tiempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnConvertirASegundos;
        private System.Windows.Forms.Button btnSalir;
    }
}

