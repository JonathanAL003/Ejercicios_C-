namespace ProyectoBaseDeDatos
{
    partial class FormInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInicio2 = new System.Windows.Forms.Button();
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.dtgMaterial = new System.Windows.Forms.DataGridView();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.txtCantidadMaterial = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.grpDatosMaterial = new System.Windows.Forms.GroupBox();
            this.radEliminar = new System.Windows.Forms.RadioButton();
            this.radActualizar = new System.Windows.Forms.RadioButton();
            this.radRegistrar = new System.Windows.Forms.RadioButton();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblCantidadMaterial = new System.Windows.Forms.Label();
            this.lblNombreMaterial = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrepararActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterial)).BeginInit();
            this.grpDatosMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio2
            // 
            this.btnInicio2.Location = new System.Drawing.Point(656, 230);
            this.btnInicio2.Name = "btnInicio2";
            this.btnInicio2.Size = new System.Drawing.Size(75, 23);
            this.btnInicio2.TabIndex = 0;
            this.btnInicio2.Text = "&Inicio";
            this.btnInicio2.UseVisualStyleBackColor = true;
            this.btnInicio2.Click += new System.EventHandler(this.btnInicio2_Click);
            // 
            // btnSalir3
            // 
            this.btnSalir3.Location = new System.Drawing.Point(737, 230);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(52, 23);
            this.btnSalir3.TabIndex = 1;
            this.btnSalir3.Text = "&Salir";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // dtgMaterial
            // 
            this.dtgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaterial.Location = new System.Drawing.Point(322, 12);
            this.dtgMaterial.Name = "dtgMaterial";
            this.dtgMaterial.Size = new System.Drawing.Size(456, 212);
            this.dtgMaterial.TabIndex = 2;
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(119, 92);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(167, 20);
            this.txtNombreMaterial.TabIndex = 3;
            // 
            // txtCantidadMaterial
            // 
            this.txtCantidadMaterial.Location = new System.Drawing.Point(119, 118);
            this.txtCantidadMaterial.Name = "txtCantidadMaterial";
            this.txtCantidadMaterial.Size = new System.Drawing.Size(83, 20);
            this.txtCantidadMaterial.TabIndex = 4;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(119, 144);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(83, 20);
            this.txtPrecioVenta.TabIndex = 6;
            // 
            // grpDatosMaterial
            // 
            this.grpDatosMaterial.Controls.Add(this.btnPrepararActualizar);
            this.grpDatosMaterial.Controls.Add(this.btnEliminar);
            this.grpDatosMaterial.Controls.Add(this.btnActualizar);
            this.grpDatosMaterial.Controls.Add(this.btnRegistrar);
            this.grpDatosMaterial.Controls.Add(this.radEliminar);
            this.grpDatosMaterial.Controls.Add(this.radActualizar);
            this.grpDatosMaterial.Controls.Add(this.radRegistrar);
            this.grpDatosMaterial.Controls.Add(this.lblId);
            this.grpDatosMaterial.Controls.Add(this.txtId);
            this.grpDatosMaterial.Controls.Add(this.lblPrecioVenta);
            this.grpDatosMaterial.Controls.Add(this.lblCantidadMaterial);
            this.grpDatosMaterial.Controls.Add(this.lblNombreMaterial);
            this.grpDatosMaterial.Controls.Add(this.txtPrecioVenta);
            this.grpDatosMaterial.Controls.Add(this.txtNombreMaterial);
            this.grpDatosMaterial.Controls.Add(this.txtCantidadMaterial);
            this.grpDatosMaterial.Location = new System.Drawing.Point(12, 9);
            this.grpDatosMaterial.Name = "grpDatosMaterial";
            this.grpDatosMaterial.Size = new System.Drawing.Size(304, 229);
            this.grpDatosMaterial.TabIndex = 7;
            this.grpDatosMaterial.TabStop = false;
            this.grpDatosMaterial.Text = "Datos:";
            // 
            // radEliminar
            // 
            this.radEliminar.AutoSize = true;
            this.radEliminar.Location = new System.Drawing.Point(6, 65);
            this.radEliminar.Name = "radEliminar";
            this.radEliminar.Size = new System.Drawing.Size(61, 17);
            this.radEliminar.TabIndex = 17;
            this.radEliminar.Text = "Eliminar";
            this.radEliminar.UseVisualStyleBackColor = true;
            this.radEliminar.CheckedChanged += new System.EventHandler(this.radEliminar_CheckedChanged);
            // 
            // radActualizar
            // 
            this.radActualizar.AutoSize = true;
            this.radActualizar.Location = new System.Drawing.Point(6, 42);
            this.radActualizar.Name = "radActualizar";
            this.radActualizar.Size = new System.Drawing.Size(71, 17);
            this.radActualizar.TabIndex = 16;
            this.radActualizar.Text = "Actualizar";
            this.radActualizar.UseVisualStyleBackColor = true;
            this.radActualizar.CheckedChanged += new System.EventHandler(this.radActualizar_CheckedChanged);
            // 
            // radRegistrar
            // 
            this.radRegistrar.AutoSize = true;
            this.radRegistrar.Checked = true;
            this.radRegistrar.Location = new System.Drawing.Point(6, 19);
            this.radRegistrar.Name = "radRegistrar";
            this.radRegistrar.Size = new System.Drawing.Size(67, 17);
            this.radRegistrar.TabIndex = 15;
            this.radRegistrar.TabStop = true;
            this.radRegistrar.Text = "Registrar";
            this.radRegistrar.UseVisualStyleBackColor = true;
            this.radRegistrar.CheckedChanged += new System.EventHandler(this.radRegistrar_CheckedChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(97, 173);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 170);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 20);
            this.txtId.TabIndex = 8;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(5, 147);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(108, 13);
            this.lblPrecioVenta.TabIndex = 10;
            this.lblPrecioVenta.Text = "Precio Venta(Unidad)";
            // 
            // lblCantidadMaterial
            // 
            this.lblCantidadMaterial.AutoSize = true;
            this.lblCantidadMaterial.Location = new System.Drawing.Point(24, 121);
            this.lblCantidadMaterial.Name = "lblCantidadMaterial";
            this.lblCantidadMaterial.Size = new System.Drawing.Size(89, 13);
            this.lblCantidadMaterial.TabIndex = 8;
            this.lblCantidadMaterial.Text = "Cantidad Material";
            // 
            // lblNombreMaterial
            // 
            this.lblNombreMaterial.AutoSize = true;
            this.lblNombreMaterial.Location = new System.Drawing.Point(30, 95);
            this.lblNombreMaterial.Name = "lblNombreMaterial";
            this.lblNombreMaterial.Size = new System.Drawing.Size(83, 13);
            this.lblNombreMaterial.TabIndex = 7;
            this.lblNombreMaterial.Text = "Nombre material";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(223, 200);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(223, 199);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(223, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPrepararActualizar
            // 
            this.btnPrepararActualizar.Location = new System.Drawing.Point(181, 170);
            this.btnPrepararActualizar.Name = "btnPrepararActualizar";
            this.btnPrepararActualizar.Size = new System.Drawing.Size(114, 23);
            this.btnPrepararActualizar.TabIndex = 23;
            this.btnPrepararActualizar.Text = "&Preparar Actualizar";
            this.btnPrepararActualizar.UseVisualStyleBackColor = true;
            this.btnPrepararActualizar.Click += new System.EventHandler(this.btnPrepararActualizar_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 260);
            this.Controls.Add(this.grpDatosMaterial);
            this.Controls.Add(this.dtgMaterial);
            this.Controls.Add(this.btnSalir3);
            this.Controls.Add(this.btnInicio2);
            this.Name = "FormInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterial)).EndInit();
            this.grpDatosMaterial.ResumeLayout(false);
            this.grpDatosMaterial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio2;
        private System.Windows.Forms.Button btnSalir3;
        private System.Windows.Forms.DataGridView dtgMaterial;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.TextBox txtCantidadMaterial;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.GroupBox grpDatosMaterial;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblCantidadMaterial;
        private System.Windows.Forms.Label lblNombreMaterial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RadioButton radEliminar;
        private System.Windows.Forms.RadioButton radActualizar;
        private System.Windows.Forms.RadioButton radRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnPrepararActualizar;
    }
}