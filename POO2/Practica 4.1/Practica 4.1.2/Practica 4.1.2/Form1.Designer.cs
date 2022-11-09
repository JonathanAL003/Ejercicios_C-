namespace Practica_4._1._2
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
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.lblSalarioPorHora = new System.Windows.Forms.Label();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtSalarioPorHora = new System.Windows.Forms.TextBox();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(12, 15);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(91, 13);
            this.lblHorasTrabajadas.TabIndex = 0;
            this.lblHorasTrabajadas.Text = "Horas Trabajadas";
            // 
            // lblSalarioPorHora
            // 
            this.lblSalarioPorHora.AutoSize = true;
            this.lblSalarioPorHora.Location = new System.Drawing.Point(20, 41);
            this.lblSalarioPorHora.Name = "lblSalarioPorHora";
            this.lblSalarioPorHora.Size = new System.Drawing.Size(83, 13);
            this.lblSalarioPorHora.TabIndex = 1;
            this.lblSalarioPorHora.Text = "Salario por Hora";
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(109, 12);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(59, 20);
            this.txtHorasTrabajadas.TabIndex = 2;
            // 
            // txtSalarioPorHora
            // 
            this.txtSalarioPorHora.Location = new System.Drawing.Point(109, 38);
            this.txtSalarioPorHora.Name = "txtSalarioPorHora";
            this.txtSalarioPorHora.Size = new System.Drawing.Size(59, 20);
            this.txtSalarioPorHora.TabIndex = 3;
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(43, 83);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(98, 23);
            this.btnCalcularSalario.TabIndex = 4;
            this.btnCalcularSalario.Text = "&Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(135, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.txtSalarioPorHora);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.lblSalarioPorHora);
            this.Controls.Add(this.lblHorasTrabajadas);
            this.Name = "Form1";
            this.Text = "Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorasTrabajadas;
        private System.Windows.Forms.Label lblSalarioPorHora;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtSalarioPorHora;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Button btnSalir;
    }
}

