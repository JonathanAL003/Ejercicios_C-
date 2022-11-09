namespace Practica_2._1._10
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
            this.grpCantidadAlimentos = new System.Windows.Forms.GroupBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtHE = new System.Windows.Forms.TextBox();
            this.txtHQ = new System.Windows.Forms.TextBox();
            this.txtHS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHamburguesasSencillas = new System.Windows.Forms.Label();
            this.cboMesas = new System.Windows.Forms.ComboBox();
            this.btnCapturarOrden = new System.Windows.Forms.Button();
            this.btnCalcularCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpCantidadAlimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCantidadAlimentos
            // 
            this.grpCantidadAlimentos.Controls.Add(this.txtP);
            this.grpCantidadAlimentos.Controls.Add(this.txtR);
            this.grpCantidadAlimentos.Controls.Add(this.txtPF);
            this.grpCantidadAlimentos.Controls.Add(this.txtHE);
            this.grpCantidadAlimentos.Controls.Add(this.txtHQ);
            this.grpCantidadAlimentos.Controls.Add(this.txtHS);
            this.grpCantidadAlimentos.Controls.Add(this.label5);
            this.grpCantidadAlimentos.Controls.Add(this.label4);
            this.grpCantidadAlimentos.Controls.Add(this.label3);
            this.grpCantidadAlimentos.Controls.Add(this.label2);
            this.grpCantidadAlimentos.Controls.Add(this.label1);
            this.grpCantidadAlimentos.Controls.Add(this.lblHamburguesasSencillas);
            this.grpCantidadAlimentos.Location = new System.Drawing.Point(12, 12);
            this.grpCantidadAlimentos.Name = "grpCantidadAlimentos";
            this.grpCantidadAlimentos.Size = new System.Drawing.Size(218, 208);
            this.grpCantidadAlimentos.TabIndex = 0;
            this.grpCantidadAlimentos.TabStop = false;
            this.grpCantidadAlimentos.Text = "Cantidad Alimentos";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(150, 166);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(62, 20);
            this.txtP.TabIndex = 11;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(150, 140);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(62, 20);
            this.txtR.TabIndex = 10;
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(150, 114);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(62, 20);
            this.txtPF.TabIndex = 9;
            // 
            // txtHE
            // 
            this.txtHE.Location = new System.Drawing.Point(150, 88);
            this.txtHE.Name = "txtHE";
            this.txtHE.Size = new System.Drawing.Size(62, 20);
            this.txtHE.TabIndex = 8;
            // 
            // txtHQ
            // 
            this.txtHQ.Location = new System.Drawing.Point(150, 62);
            this.txtHQ.Name = "txtHQ";
            this.txtHQ.Size = new System.Drawing.Size(62, 20);
            this.txtHQ.TabIndex = 7;
            // 
            // txtHS
            // 
            this.txtHS.Location = new System.Drawing.Point(150, 31);
            this.txtHS.Name = "txtHS";
            this.txtHS.Size = new System.Drawing.Size(62, 20);
            this.txtHS.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Refrescos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Papas Fritas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hamburguesas Especiales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hamburguesas c/ queso";
            // 
            // lblHamburguesasSencillas
            // 
            this.lblHamburguesasSencillas.AutoSize = true;
            this.lblHamburguesasSencillas.Location = new System.Drawing.Point(6, 34);
            this.lblHamburguesasSencillas.Name = "lblHamburguesasSencillas";
            this.lblHamburguesasSencillas.Size = new System.Drawing.Size(123, 13);
            this.lblHamburguesasSencillas.TabIndex = 0;
            this.lblHamburguesasSencillas.Text = "Hamburguesas Sencillas";
            // 
            // cboMesas
            // 
            this.cboMesas.FormattingEnabled = true;
            this.cboMesas.Location = new System.Drawing.Point(12, 247);
            this.cboMesas.Name = "cboMesas";
            this.cboMesas.Size = new System.Drawing.Size(121, 21);
            this.cboMesas.TabIndex = 1;
            // 
            // btnCapturarOrden
            // 
            this.btnCapturarOrden.Location = new System.Drawing.Point(244, 22);
            this.btnCapturarOrden.Name = "btnCapturarOrden";
            this.btnCapturarOrden.Size = new System.Drawing.Size(92, 23);
            this.btnCapturarOrden.TabIndex = 2;
            this.btnCapturarOrden.Text = "&Capturar Orden";
            this.btnCapturarOrden.UseVisualStyleBackColor = true;
            this.btnCapturarOrden.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularCuenta
            // 
            this.btnCalcularCuenta.Location = new System.Drawing.Point(244, 51);
            this.btnCalcularCuenta.Name = "btnCalcularCuenta";
            this.btnCalcularCuenta.Size = new System.Drawing.Size(92, 23);
            this.btnCalcularCuenta.TabIndex = 3;
            this.btnCalcularCuenta.Text = "C&alcular Cuenta";
            this.btnCalcularCuenta.UseVisualStyleBackColor = true;
            this.btnCalcularCuenta.Click += new System.EventHandler(this.btnCalcularCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 297);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcularCuenta);
            this.Controls.Add(this.btnCapturarOrden);
            this.Controls.Add(this.cboMesas);
            this.Controls.Add(this.grpCantidadAlimentos);
            this.Name = "Form1";
            this.Text = "Restaurante Hamburgesas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCantidadAlimentos.ResumeLayout(false);
            this.grpCantidadAlimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCantidadAlimentos;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtHE;
        private System.Windows.Forms.TextBox txtHQ;
        private System.Windows.Forms.TextBox txtHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHamburguesasSencillas;
        private System.Windows.Forms.ComboBox cboMesas;
        private System.Windows.Forms.Button btnCapturarOrden;
        private System.Windows.Forms.Button btnCalcularCuenta;
        private System.Windows.Forms.Button btnSalir;
    }
}

