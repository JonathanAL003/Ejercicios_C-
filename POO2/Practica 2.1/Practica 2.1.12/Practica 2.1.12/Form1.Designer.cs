namespace Practica_2._1._12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoordenadaX = new System.Windows.Forms.TextBox();
            this.txtCoordenadaY = new System.Windows.Forms.TextBox();
            this.radPunto1 = new System.Windows.Forms.RadioButton();
            this.radPunto2 = new System.Windows.Forms.RadioButton();
            this.btnCapturarCoordenadas = new System.Windows.Forms.Button();
            this.btnCalcularDistancia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCoordenadaY);
            this.groupBox1.Controls.Add(this.txtCoordenadaX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas del punto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radPunto2);
            this.groupBox2.Controls.Add(this.radPunto1);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un punto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordenada X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coordenada Y";
            // 
            // txtCoordenadaX
            // 
            this.txtCoordenadaX.Location = new System.Drawing.Point(87, 25);
            this.txtCoordenadaX.Name = "txtCoordenadaX";
            this.txtCoordenadaX.Size = new System.Drawing.Size(51, 20);
            this.txtCoordenadaX.TabIndex = 2;
            // 
            // txtCoordenadaY
            // 
            this.txtCoordenadaY.Location = new System.Drawing.Point(87, 55);
            this.txtCoordenadaY.Name = "txtCoordenadaY";
            this.txtCoordenadaY.Size = new System.Drawing.Size(51, 20);
            this.txtCoordenadaY.TabIndex = 2;
            // 
            // radPunto1
            // 
            this.radPunto1.AutoSize = true;
            this.radPunto1.Checked = true;
            this.radPunto1.Location = new System.Drawing.Point(6, 29);
            this.radPunto1.Name = "radPunto1";
            this.radPunto1.Size = new System.Drawing.Size(62, 17);
            this.radPunto1.TabIndex = 0;
            this.radPunto1.TabStop = true;
            this.radPunto1.Text = "Punto 1";
            this.radPunto1.UseVisualStyleBackColor = true;
            // 
            // radPunto2
            // 
            this.radPunto2.AutoSize = true;
            this.radPunto2.Location = new System.Drawing.Point(6, 52);
            this.radPunto2.Name = "radPunto2";
            this.radPunto2.Size = new System.Drawing.Size(62, 17);
            this.radPunto2.TabIndex = 1;
            this.radPunto2.Text = "Punto 2";
            this.radPunto2.UseVisualStyleBackColor = true;
            // 
            // btnCapturarCoordenadas
            // 
            this.btnCapturarCoordenadas.Location = new System.Drawing.Point(183, 12);
            this.btnCapturarCoordenadas.Name = "btnCapturarCoordenadas";
            this.btnCapturarCoordenadas.Size = new System.Drawing.Size(79, 41);
            this.btnCapturarCoordenadas.TabIndex = 2;
            this.btnCapturarCoordenadas.Text = "&Capturar Coordenadas";
            this.btnCapturarCoordenadas.UseVisualStyleBackColor = true;
            this.btnCapturarCoordenadas.Click += new System.EventHandler(this.btnCapturarCoordenadas_Click);
            // 
            // btnCalcularDistancia
            // 
            this.btnCalcularDistancia.Location = new System.Drawing.Point(183, 67);
            this.btnCalcularDistancia.Name = "btnCalcularDistancia";
            this.btnCalcularDistancia.Size = new System.Drawing.Size(79, 41);
            this.btnCalcularDistancia.TabIndex = 3;
            this.btnCalcularDistancia.Text = "Calcular &Distancia";
            this.btnCalcularDistancia.UseVisualStyleBackColor = true;
            this.btnCalcularDistancia.Click += new System.EventHandler(this.btnCalcularDistancia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(183, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 235);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularDistancia);
            this.Controls.Add(this.btnCapturarCoordenadas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Puntos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCoordenadaY;
        private System.Windows.Forms.TextBox txtCoordenadaX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radPunto2;
        private System.Windows.Forms.RadioButton radPunto1;
        private System.Windows.Forms.Button btnCapturarCoordenadas;
        private System.Windows.Forms.Button btnCalcularDistancia;
        private System.Windows.Forms.Button btnSalir;
    }
}

