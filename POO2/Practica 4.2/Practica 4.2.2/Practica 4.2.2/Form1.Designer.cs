namespace Practica_4._2._2
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
            this.grpTipoDeFigura = new System.Windows.Forms.GroupBox();
            this.radTrianguloEquilatero = new System.Windows.Forms.RadioButton();
            this.radCircunferencia = new System.Windows.Forms.RadioButton();
            this.radRectangulo = new System.Windows.Forms.RadioButton();
            this.grpDatosDeLaFigura = new System.Windows.Forms.GroupBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.btnCalcularPerimetro = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.grpTipoDeFigura.SuspendLayout();
            this.grpDatosDeLaFigura.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoDeFigura
            // 
            this.grpTipoDeFigura.Controls.Add(this.radTrianguloEquilatero);
            this.grpTipoDeFigura.Controls.Add(this.radCircunferencia);
            this.grpTipoDeFigura.Controls.Add(this.radRectangulo);
            this.grpTipoDeFigura.Location = new System.Drawing.Point(12, 12);
            this.grpTipoDeFigura.Name = "grpTipoDeFigura";
            this.grpTipoDeFigura.Size = new System.Drawing.Size(129, 87);
            this.grpTipoDeFigura.TabIndex = 1;
            this.grpTipoDeFigura.TabStop = false;
            this.grpTipoDeFigura.Text = "Tipo de Figura";
            // 
            // radTrianguloEquilatero
            // 
            this.radTrianguloEquilatero.AutoSize = true;
            this.radTrianguloEquilatero.Location = new System.Drawing.Point(6, 65);
            this.radTrianguloEquilatero.Name = "radTrianguloEquilatero";
            this.radTrianguloEquilatero.Size = new System.Drawing.Size(119, 17);
            this.radTrianguloEquilatero.TabIndex = 2;
            this.radTrianguloEquilatero.Text = "Triangulo Equilatero";
            this.radTrianguloEquilatero.UseVisualStyleBackColor = true;
            this.radTrianguloEquilatero.CheckedChanged += new System.EventHandler(this.radTrianguloEquilatero_CheckedChanged);
            // 
            // radCircunferencia
            // 
            this.radCircunferencia.AutoSize = true;
            this.radCircunferencia.Location = new System.Drawing.Point(6, 42);
            this.radCircunferencia.Name = "radCircunferencia";
            this.radCircunferencia.Size = new System.Drawing.Size(93, 17);
            this.radCircunferencia.TabIndex = 1;
            this.radCircunferencia.Text = "Circunferencia";
            this.radCircunferencia.UseVisualStyleBackColor = true;
            this.radCircunferencia.CheckedChanged += new System.EventHandler(this.radCircunferencia_CheckedChanged);
            // 
            // radRectangulo
            // 
            this.radRectangulo.AutoSize = true;
            this.radRectangulo.Checked = true;
            this.radRectangulo.Location = new System.Drawing.Point(6, 19);
            this.radRectangulo.Name = "radRectangulo";
            this.radRectangulo.Size = new System.Drawing.Size(80, 17);
            this.radRectangulo.TabIndex = 0;
            this.radRectangulo.TabStop = true;
            this.radRectangulo.Text = "Rectángulo";
            this.radRectangulo.UseVisualStyleBackColor = true;
            this.radRectangulo.CheckedChanged += new System.EventHandler(this.radRectangulo_CheckedChanged);
            // 
            // grpDatosDeLaFigura
            // 
            this.grpDatosDeLaFigura.Controls.Add(this.txtLado);
            this.grpDatosDeLaFigura.Controls.Add(this.txtRadio);
            this.grpDatosDeLaFigura.Controls.Add(this.txtAncho);
            this.grpDatosDeLaFigura.Controls.Add(this.txtLargo);
            this.grpDatosDeLaFigura.Controls.Add(this.lblLado);
            this.grpDatosDeLaFigura.Controls.Add(this.lblRadio);
            this.grpDatosDeLaFigura.Controls.Add(this.lblAncho);
            this.grpDatosDeLaFigura.Controls.Add(this.lblLargo);
            this.grpDatosDeLaFigura.Location = new System.Drawing.Point(12, 105);
            this.grpDatosDeLaFigura.Name = "grpDatosDeLaFigura";
            this.grpDatosDeLaFigura.Size = new System.Drawing.Size(129, 134);
            this.grpDatosDeLaFigura.TabIndex = 2;
            this.grpDatosDeLaFigura.TabStop = false;
            this.grpDatosDeLaFigura.Text = "Datos de la Figura";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(50, 101);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(49, 20);
            this.txtLado.TabIndex = 7;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(50, 75);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(49, 20);
            this.txtRadio.TabIndex = 6;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(50, 49);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(49, 20);
            this.txtAncho.TabIndex = 5;
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(50, 23);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(49, 20);
            this.txtLargo.TabIndex = 4;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(13, 104);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 3;
            this.lblLado.Text = "Lado";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(9, 78);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(35, 13);
            this.lblRadio.TabIndex = 2;
            this.lblRadio.Text = "Radio";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(6, 52);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 1;
            this.lblAncho.Text = "Ancho";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(10, 26);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(34, 13);
            this.lblLargo.TabIndex = 0;
            this.lblLargo.Text = "Largo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(147, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.Location = new System.Drawing.Point(147, 41);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(107, 23);
            this.btnCalcularArea.TabIndex = 6;
            this.btnCalcularArea.Text = "&Calcular Area";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // btnCalcularPerimetro
            // 
            this.btnCalcularPerimetro.Location = new System.Drawing.Point(147, 12);
            this.btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            this.btnCalcularPerimetro.Size = new System.Drawing.Size(107, 23);
            this.btnCalcularPerimetro.TabIndex = 5;
            this.btnCalcularPerimetro.Text = "&Calcular Perimetro";
            this.btnCalcularPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetro.Click += new System.EventHandler(this.btnCalcularPerimetro_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(149, 131);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(107, 23);
            this.btnEquals.TabIndex = 8;
            this.btnEquals.Text = "&Circulo y Triangulo";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 249);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.btnCalcularPerimetro);
            this.Controls.Add(this.grpDatosDeLaFigura);
            this.Controls.Add(this.grpTipoDeFigura);
            this.Name = "Form1";
            this.Text = "Figuras Geométricas";
            this.grpTipoDeFigura.ResumeLayout(false);
            this.grpTipoDeFigura.PerformLayout();
            this.grpDatosDeLaFigura.ResumeLayout(false);
            this.grpDatosDeLaFigura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoDeFigura;
        private System.Windows.Forms.RadioButton radTrianguloEquilatero;
        private System.Windows.Forms.RadioButton radCircunferencia;
        private System.Windows.Forms.RadioButton radRectangulo;
        private System.Windows.Forms.GroupBox grpDatosDeLaFigura;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Button btnCalcularPerimetro;
        private System.Windows.Forms.Button btnEquals;
    }
}

