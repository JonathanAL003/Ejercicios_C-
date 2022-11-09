namespace ProyectoBaseDeDatos
{
    partial class FormCliente
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
            this.dtgMateriales = new System.Windows.Forms.DataGridView();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.btnInicio3 = new System.Windows.Forms.Button();
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.cboIdMaterial = new System.Windows.Forms.ComboBox();
            this.cboIdCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblIDMaterial = new System.Windows.Forms.Label();
            this.chkConstructora = new System.Windows.Forms.CheckBox();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadCompra = new System.Windows.Forms.TextBox();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreConstructora = new System.Windows.Forms.TextBox();
            this.dtmFechaActual = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMateriales
            // 
            this.dtgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMateriales.Location = new System.Drawing.Point(12, 248);
            this.dtgMateriales.Name = "dtgMateriales";
            this.dtgMateriales.Size = new System.Drawing.Size(417, 224);
            this.dtgMateriales.TabIndex = 0;
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(12, 12);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(901, 224);
            this.dtgClientes.TabIndex = 1;
            // 
            // btnInicio3
            // 
            this.btnInicio3.Location = new System.Drawing.Point(787, 449);
            this.btnInicio3.Name = "btnInicio3";
            this.btnInicio3.Size = new System.Drawing.Size(75, 23);
            this.btnInicio3.TabIndex = 2;
            this.btnInicio3.Text = "&Inicio";
            this.btnInicio3.UseVisualStyleBackColor = true;
            this.btnInicio3.Click += new System.EventHandler(this.btnInicio3_Click);
            // 
            // btnSalir3
            // 
            this.btnSalir3.Location = new System.Drawing.Point(868, 449);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(42, 23);
            this.btnSalir3.TabIndex = 3;
            this.btnSalir3.Text = "&Salir";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // cboIdMaterial
            // 
            this.cboIdMaterial.FormattingEnabled = true;
            this.cboIdMaterial.Location = new System.Drawing.Point(618, 304);
            this.cboIdMaterial.Name = "cboIdMaterial";
            this.cboIdMaterial.Size = new System.Drawing.Size(54, 21);
            this.cboIdMaterial.TabIndex = 4;
            this.cboIdMaterial.SelectedIndexChanged += new System.EventHandler(this.cboIdMaterial_SelectedIndexChanged);
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.FormattingEnabled = true;
            this.cboIdCliente.Location = new System.Drawing.Point(618, 280);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Size = new System.Drawing.Size(54, 21);
            this.cboIdCliente.TabIndex = 5;
            this.cboIdCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(545, 280);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 13);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Constructora";
            // 
            // lblIDMaterial
            // 
            this.lblIDMaterial.AutoSize = true;
            this.lblIDMaterial.Location = new System.Drawing.Point(444, 307);
            this.lblIDMaterial.Name = "lblIDMaterial";
            this.lblIDMaterial.Size = new System.Drawing.Size(168, 13);
            this.lblIDMaterial.TabIndex = 7;
            this.lblIDMaterial.Text = "ID del material que desea comprar";
            // 
            // chkConstructora
            // 
            this.chkConstructora.AutoSize = true;
            this.chkConstructora.Location = new System.Drawing.Point(435, 248);
            this.chkConstructora.Name = "chkConstructora";
            this.chkConstructora.Size = new System.Drawing.Size(303, 17);
            this.chkConstructora.TabIndex = 8;
            this.chkConstructora.Text = "Marque la casilla, si es una constructora afiliada a nosotros";
            this.chkConstructora.UseVisualStyleBackColor = true;
            this.chkConstructora.CheckedChanged += new System.EventHandler(this.chkConstructora_CheckedChanged);
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Enabled = false;
            this.txtNombreMaterial.Location = new System.Drawing.Point(678, 304);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(184, 20);
            this.txtNombreMaterial.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(563, 334);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Location = new System.Drawing.Point(618, 331);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Size = new System.Drawing.Size(72, 20);
            this.txtCantidadCompra.TabIndex = 11;
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Location = new System.Drawing.Point(435, 359);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(128, 23);
            this.btnAgregarCompra.TabIndex = 12;
            this.btnAgregarCompra.Text = "&Agregar a la compra";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(435, 388);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(128, 23);
            this.btnFinalizarCompra.TabIndex = 13;
            this.btnFinalizarCompra.Text = "&Finalizar compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(618, 361);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(90, 20);
            this.txtSubtotal.TabIndex = 14;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(773, 361);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(74, 20);
            this.txtIva.TabIndex = 15;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(566, 364);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubTotal.TabIndex = 16;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(714, 364);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(53, 13);
            this.lblIva.TabIndex = 17;
            this.lblIva.Text = "IVA (16%)";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Enabled = false;
            this.txtExistencias.Location = new System.Drawing.Point(868, 305);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(45, 20);
            this.txtExistencias.TabIndex = 18;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Enabled = false;
            this.txtPrecioProducto.Location = new System.Drawing.Point(853, 334);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(63, 20);
            this.txtPrecioProducto.TabIndex = 19;
            // 
            // txtCompras
            // 
            this.txtCompras.Enabled = false;
            this.txtCompras.Location = new System.Drawing.Point(868, 251);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(45, 20);
            this.txtCompras.TabIndex = 20;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(817, 251);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(45, 20);
            this.txtIdCliente.TabIndex = 21;
            // 
            // txtNombreConstructora
            // 
            this.txtNombreConstructora.Enabled = false;
            this.txtNombreConstructora.Location = new System.Drawing.Point(678, 281);
            this.txtNombreConstructora.Name = "txtNombreConstructora";
            this.txtNombreConstructora.Size = new System.Drawing.Size(184, 20);
            this.txtNombreConstructora.TabIndex = 22;
            // 
            // dtmFechaActual
            // 
            this.dtmFechaActual.Enabled = false;
            this.dtmFechaActual.Location = new System.Drawing.Point(508, 449);
            this.dtmFechaActual.Name = "dtmFechaActual";
            this.dtmFechaActual.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaActual.TabIndex = 23;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 484);
            this.Controls.Add(this.dtmFechaActual);
            this.Controls.Add(this.txtNombreConstructora);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtCompras);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnAgregarCompra);
            this.Controls.Add(this.txtCantidadCompra);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.chkConstructora);
            this.Controls.Add(this.lblIDMaterial);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboIdCliente);
            this.Controls.Add(this.cboIdMaterial);
            this.Controls.Add(this.btnSalir3);
            this.Controls.Add(this.btnInicio3);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.dtgMateriales);
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCliente_FormClosed);
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMateriales;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Button btnInicio3;
        private System.Windows.Forms.Button btnSalir3;
        private System.Windows.Forms.ComboBox cboIdMaterial;
        private System.Windows.Forms.ComboBox cboIdCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblIDMaterial;
        private System.Windows.Forms.CheckBox chkConstructora;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadCompra;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCompras;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNombreConstructora;
        private System.Windows.Forms.DateTimePicker dtmFechaActual;
    }
}