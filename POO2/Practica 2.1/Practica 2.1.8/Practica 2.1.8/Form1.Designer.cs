namespace Practica_2._1._8
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
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.btmConvertirADolares = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese la cantidad de pesos";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(161, 28);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 4;
            // 
            // btmConvertirADolares
            // 
            this.btmConvertirADolares.Location = new System.Drawing.Point(154, 71);
            this.btmConvertirADolares.Name = "btmConvertirADolares";
            this.btmConvertirADolares.Size = new System.Drawing.Size(107, 23);
            this.btmConvertirADolares.TabIndex = 5;
            this.btmConvertirADolares.Text = "&Convertir a Dolares";
            this.btmConvertirADolares.UseVisualStyleBackColor = true;
            this.btmConvertirADolares.Click += new System.EventHandler(this.btmConvertirADolares_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(214, 100);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 134);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btmConvertirADolares);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Casa de Cambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Button btmConvertirADolares;
        private System.Windows.Forms.Button btnSalir;
    }
}

