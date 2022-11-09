namespace Practica_2._1._11
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
            this.lblCostoAuto = new System.Windows.Forms.Label();
            this.txtCostoAuto = new System.Windows.Forms.TextBox();
            this.btnCostoFinal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCostoAuto
            // 
            this.lblCostoAuto.AutoSize = true;
            this.lblCostoAuto.Location = new System.Drawing.Point(12, 24);
            this.lblCostoAuto.Name = "lblCostoAuto";
            this.lblCostoAuto.Size = new System.Drawing.Size(104, 13);
            this.lblCostoAuto.TabIndex = 0;
            this.lblCostoAuto.Text = "Costo base del auto:";
            // 
            // txtCostoAuto
            // 
            this.txtCostoAuto.Location = new System.Drawing.Point(122, 21);
            this.txtCostoAuto.Name = "txtCostoAuto";
            this.txtCostoAuto.Size = new System.Drawing.Size(100, 20);
            this.txtCostoAuto.TabIndex = 1;
            // 
            // btnCostoFinal
            // 
            this.btnCostoFinal.Location = new System.Drawing.Point(15, 70);
            this.btnCostoFinal.Name = "btnCostoFinal";
            this.btnCostoFinal.Size = new System.Drawing.Size(113, 23);
            this.btnCostoFinal.TabIndex = 2;
            this.btnCostoFinal.Text = "&Calcular Costo Final";
            this.btnCostoFinal.UseVisualStyleBackColor = true;
            this.btnCostoFinal.Click += new System.EventHandler(this.btnCostoFinal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(147, 70);
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
            this.ClientSize = new System.Drawing.Size(233, 105);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCostoFinal);
            this.Controls.Add(this.txtCostoAuto);
            this.Controls.Add(this.lblCostoAuto);
            this.Name = "Form1";
            this.Text = "Venta de auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCostoAuto;
        private System.Windows.Forms.TextBox txtCostoAuto;
        private System.Windows.Forms.Button btnCostoFinal;
        private System.Windows.Forms.Button btnSalir;
    }
}

