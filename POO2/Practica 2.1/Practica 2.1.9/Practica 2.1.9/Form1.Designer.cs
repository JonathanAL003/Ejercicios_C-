﻿namespace Practica_2._1._9
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
            this.txtGalones = new System.Windows.Forms.TextBox();
            this.btnCosto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de galones despachados:";
            // 
            // txtGalones
            // 
            this.txtGalones.Location = new System.Drawing.Point(240, 22);
            this.txtGalones.Name = "txtGalones";
            this.txtGalones.Size = new System.Drawing.Size(60, 20);
            this.txtGalones.TabIndex = 1;
            // 
            // btnCosto
            // 
            this.btnCosto.Location = new System.Drawing.Point(225, 48);
            this.btnCosto.Name = "btnCosto";
            this.btnCosto.Size = new System.Drawing.Size(75, 23);
            this.btnCosto.TabIndex = 2;
            this.btnCosto.Text = "Costo";
            this.btnCosto.UseVisualStyleBackColor = true;
            this.btnCosto.Click += new System.EventHandler(this.btnCosto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(225, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 114);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCosto);
            this.Controls.Add(this.txtGalones);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gasolinera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGalones;
        private System.Windows.Forms.Button btnCosto;
        private System.Windows.Forms.Button btnSalir;
    }
}

