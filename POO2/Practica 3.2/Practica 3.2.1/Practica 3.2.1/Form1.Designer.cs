namespace Practica_3._2._1
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
            this.grpDatosDeLaEmpresa = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.txtGerente = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblGerente = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.grpDepartamento = new System.Windows.Forms.GroupBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.dtgDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatosDeLaEmpresa.SuspendLayout();
            this.grpDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosDeLaEmpresa
            // 
            this.grpDatosDeLaEmpresa.Controls.Add(this.btnCapturar);
            this.grpDatosDeLaEmpresa.Controls.Add(this.txtGerente);
            this.grpDatosDeLaEmpresa.Controls.Add(this.txtRazonSocial);
            this.grpDatosDeLaEmpresa.Controls.Add(this.txtRFC);
            this.grpDatosDeLaEmpresa.Controls.Add(this.lblGerente);
            this.grpDatosDeLaEmpresa.Controls.Add(this.lblRazonSocial);
            this.grpDatosDeLaEmpresa.Controls.Add(this.lblRFC);
            this.grpDatosDeLaEmpresa.Location = new System.Drawing.Point(12, 12);
            this.grpDatosDeLaEmpresa.Name = "grpDatosDeLaEmpresa";
            this.grpDatosDeLaEmpresa.Size = new System.Drawing.Size(383, 125);
            this.grpDatosDeLaEmpresa.TabIndex = 0;
            this.grpDatosDeLaEmpresa.TabStop = false;
            this.grpDatosDeLaEmpresa.Text = "Datos de la empresa";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(295, 96);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 6;
            this.btnCapturar.Text = "&Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // txtGerente
            // 
            this.txtGerente.Location = new System.Drawing.Point(80, 76);
            this.txtGerente.Name = "txtGerente";
            this.txtGerente.Size = new System.Drawing.Size(156, 20);
            this.txtGerente.TabIndex = 5;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(80, 50);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(120, 20);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(80, 23);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(209, 20);
            this.txtRFC.TabIndex = 3;
            // 
            // lblGerente
            // 
            this.lblGerente.AutoSize = true;
            this.lblGerente.Location = new System.Drawing.Point(29, 79);
            this.lblGerente.Name = "lblGerente";
            this.lblGerente.Size = new System.Drawing.Size(45, 13);
            this.lblGerente.TabIndex = 2;
            this.lblGerente.Text = "Gerente";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(6, 53);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(46, 26);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(28, 13);
            this.lblRFC.TabIndex = 0;
            this.lblRFC.Text = "RFC";
            // 
            // grpDepartamento
            // 
            this.grpDepartamento.Controls.Add(this.btnInsertar);
            this.grpDepartamento.Controls.Add(this.txtJefe);
            this.grpDepartamento.Controls.Add(this.txtNombre);
            this.grpDepartamento.Controls.Add(this.txtNum);
            this.grpDepartamento.Controls.Add(this.lblJefe);
            this.grpDepartamento.Controls.Add(this.lblNombre);
            this.grpDepartamento.Controls.Add(this.lblNum);
            this.grpDepartamento.Location = new System.Drawing.Point(12, 143);
            this.grpDepartamento.Name = "grpDepartamento";
            this.grpDepartamento.Size = new System.Drawing.Size(383, 132);
            this.grpDepartamento.TabIndex = 1;
            this.grpDepartamento.TabStop = false;
            this.grpDepartamento.Text = "Departamentos";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(295, 103);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "&Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(56, 87);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(180, 20);
            this.txtJefe.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(56, 27);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(52, 20);
            this.txtNum.TabIndex = 3;
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(23, 90);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(27, 13);
            this.lblJefe.TabIndex = 2;
            this.lblJefe.Text = "Jefe";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(18, 30);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(32, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Núm.";
            // 
            // dtgDepartamentos
            // 
            this.dtgDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDepartamentos.Location = new System.Drawing.Point(12, 281);
            this.dtgDepartamentos.Name = "dtgDepartamentos";
            this.dtgDepartamentos.Size = new System.Drawing.Size(383, 259);
            this.dtgDepartamentos.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(307, 546);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 574);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgDepartamentos);
            this.Controls.Add(this.grpDepartamento);
            this.Controls.Add(this.grpDatosDeLaEmpresa);
            this.Name = "Form1";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatosDeLaEmpresa.ResumeLayout(false);
            this.grpDatosDeLaEmpresa.PerformLayout();
            this.grpDepartamento.ResumeLayout(false);
            this.grpDepartamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosDeLaEmpresa;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtGerente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblGerente;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.GroupBox grpDepartamento;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.DataGridView dtgDepartamentos;
        private System.Windows.Forms.Button btnSalir;
    }
}

