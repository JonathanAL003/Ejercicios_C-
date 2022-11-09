namespace Examen_Unidad_2
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
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtSO = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblSO = new System.Windows.Forms.Label();
            this.lblHuellaDactilar = new System.Windows.Forms.Label();
            this.lblCantidadCamaras = new System.Windows.Forms.Label();
            this.lblTipoPuerto = new System.Windows.Forms.Label();
            this.radiPhone = new System.Windows.Forms.RadioButton();
            this.radMacBook = new System.Windows.Forms.RadioButton();
            this.radiPad = new System.Windows.Forms.RadioButton();
            this.radSi = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.txtCantidadCamaras = new System.Windows.Forms.TextBox();
            this.txtTipoPuerto = new System.Windows.Forms.TextBox();
            this.grpChip = new System.Windows.Forms.GroupBox();
            this.lblChip = new System.Windows.Forms.Label();
            this.txtNombreChip = new System.Windows.Forms.TextBox();
            this.lblCapcidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.grpDispositivos = new System.Windows.Forms.GroupBox();
            this.txtNombreDispositivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioDispositivo = new System.Windows.Forms.TextBox();
            this.lblPrecioDispositivo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstiPhone = new System.Windows.Forms.ListBox();
            this.dtgChip = new System.Windows.Forms.DataGridView();
            this.dtgDispositivos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpProducto.SuspendLayout();
            this.grpChip.SuspendLayout();
            this.grpDispositivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.txtTipoPuerto);
            this.grpProducto.Controls.Add(this.txtCantidadCamaras);
            this.grpProducto.Controls.Add(this.radNo);
            this.grpProducto.Controls.Add(this.radSi);
            this.grpProducto.Controls.Add(this.radiPad);
            this.grpProducto.Controls.Add(this.radMacBook);
            this.grpProducto.Controls.Add(this.radiPhone);
            this.grpProducto.Controls.Add(this.lblTipoPuerto);
            this.grpProducto.Controls.Add(this.lblCantidadCamaras);
            this.grpProducto.Controls.Add(this.lblHuellaDactilar);
            this.grpProducto.Controls.Add(this.btnCrear);
            this.grpProducto.Controls.Add(this.txtPrecioProducto);
            this.grpProducto.Controls.Add(this.txtRam);
            this.grpProducto.Controls.Add(this.txtSO);
            this.grpProducto.Controls.Add(this.lblPrecioProducto);
            this.grpProducto.Controls.Add(this.lblRam);
            this.grpProducto.Controls.Add(this.lblSO);
            this.grpProducto.Location = new System.Drawing.Point(12, 12);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(306, 195);
            this.grpProducto.TabIndex = 2;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(225, 19);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "&Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(112, 93);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(51, 20);
            this.txtPrecioProducto.TabIndex = 5;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(112, 67);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(45, 20);
            this.txtRam.TabIndex = 4;
            // 
            // txtSO
            // 
            this.txtSO.Enabled = false;
            this.txtSO.Location = new System.Drawing.Point(112, 41);
            this.txtSO.Name = "txtSO";
            this.txtSO.Size = new System.Drawing.Size(45, 20);
            this.txtSO.TabIndex = 3;
            this.txtSO.Text = "iOS";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(69, 96);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioProducto.TabIndex = 2;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(75, 74);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(31, 13);
            this.lblRam.TabIndex = 1;
            this.lblRam.Text = "RAM";
            // 
            // lblSO
            // 
            this.lblSO.AutoSize = true;
            this.lblSO.Location = new System.Drawing.Point(84, 44);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(22, 13);
            this.lblSO.TabIndex = 0;
            this.lblSO.Text = "SO";
            // 
            // lblHuellaDactilar
            // 
            this.lblHuellaDactilar.AutoSize = true;
            this.lblHuellaDactilar.Location = new System.Drawing.Point(32, 123);
            this.lblHuellaDactilar.Name = "lblHuellaDactilar";
            this.lblHuellaDactilar.Size = new System.Drawing.Size(74, 13);
            this.lblHuellaDactilar.TabIndex = 7;
            this.lblHuellaDactilar.Text = "Huella dactilar";
            // 
            // lblCantidadCamaras
            // 
            this.lblCantidadCamaras.AutoSize = true;
            this.lblCantidadCamaras.Location = new System.Drawing.Point(-3, 145);
            this.lblCantidadCamaras.Name = "lblCantidadCamaras";
            this.lblCantidadCamaras.Size = new System.Drawing.Size(107, 13);
            this.lblCantidadCamaras.TabIndex = 8;
            this.lblCantidadCamaras.Text = "Cantidad de camaras";
            // 
            // lblTipoPuerto
            // 
            this.lblTipoPuerto.AutoSize = true;
            this.lblTipoPuerto.Location = new System.Drawing.Point(30, 171);
            this.lblTipoPuerto.Name = "lblTipoPuerto";
            this.lblTipoPuerto.Size = new System.Drawing.Size(76, 13);
            this.lblTipoPuerto.TabIndex = 9;
            this.lblTipoPuerto.Text = "Tipo de puerto";
            // 
            // radiPhone
            // 
            this.radiPhone.AutoSize = true;
            this.radiPhone.Checked = true;
            this.radiPhone.Location = new System.Drawing.Point(6, 19);
            this.radiPhone.Name = "radiPhone";
            this.radiPhone.Size = new System.Drawing.Size(58, 17);
            this.radiPhone.TabIndex = 10;
            this.radiPhone.TabStop = true;
            this.radiPhone.Text = "iPhone";
            this.radiPhone.UseVisualStyleBackColor = true;
            // 
            // radMacBook
            // 
            this.radMacBook.AutoSize = true;
            this.radMacBook.Enabled = false;
            this.radMacBook.Location = new System.Drawing.Point(70, 19);
            this.radMacBook.Name = "radMacBook";
            this.radMacBook.Size = new System.Drawing.Size(71, 17);
            this.radMacBook.TabIndex = 11;
            this.radMacBook.Text = "MacBook";
            this.radMacBook.UseVisualStyleBackColor = true;
            // 
            // radiPad
            // 
            this.radiPad.AutoSize = true;
            this.radiPad.Enabled = false;
            this.radiPad.Location = new System.Drawing.Point(147, 19);
            this.radiPad.Name = "radiPad";
            this.radiPad.Size = new System.Drawing.Size(46, 17);
            this.radiPad.TabIndex = 12;
            this.radiPad.Text = "iPad";
            this.radiPad.UseVisualStyleBackColor = true;
            // 
            // radSi
            // 
            this.radSi.AutoSize = true;
            this.radSi.Location = new System.Drawing.Point(112, 119);
            this.radSi.Name = "radSi";
            this.radSi.Size = new System.Drawing.Size(34, 17);
            this.radSi.TabIndex = 13;
            this.radSi.TabStop = true;
            this.radSi.Text = "Si";
            this.radSi.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(154, 119);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 14;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // txtCantidadCamaras
            // 
            this.txtCantidadCamaras.Location = new System.Drawing.Point(112, 142);
            this.txtCantidadCamaras.Name = "txtCantidadCamaras";
            this.txtCantidadCamaras.Size = new System.Drawing.Size(45, 20);
            this.txtCantidadCamaras.TabIndex = 15;
            // 
            // txtTipoPuerto
            // 
            this.txtTipoPuerto.Enabled = false;
            this.txtTipoPuerto.Location = new System.Drawing.Point(112, 168);
            this.txtTipoPuerto.Name = "txtTipoPuerto";
            this.txtTipoPuerto.Size = new System.Drawing.Size(51, 20);
            this.txtTipoPuerto.TabIndex = 16;
            this.txtTipoPuerto.Text = "lithgning";
            // 
            // grpChip
            // 
            this.grpChip.Controls.Add(this.btnInsertar);
            this.grpChip.Controls.Add(this.txtCapacidad);
            this.grpChip.Controls.Add(this.lblCapcidad);
            this.grpChip.Controls.Add(this.txtNombreChip);
            this.grpChip.Controls.Add(this.lblChip);
            this.grpChip.Location = new System.Drawing.Point(12, 213);
            this.grpChip.Name = "grpChip";
            this.grpChip.Size = new System.Drawing.Size(306, 115);
            this.grpChip.TabIndex = 3;
            this.grpChip.TabStop = false;
            this.grpChip.Text = "Chip";
            // 
            // lblChip
            // 
            this.lblChip.AutoSize = true;
            this.lblChip.Location = new System.Drawing.Point(24, 32);
            this.lblChip.Name = "lblChip";
            this.lblChip.Size = new System.Drawing.Size(67, 13);
            this.lblChip.TabIndex = 0;
            this.lblChip.Text = "Nombre chip";
            // 
            // txtNombreChip
            // 
            this.txtNombreChip.Location = new System.Drawing.Point(97, 29);
            this.txtNombreChip.Name = "txtNombreChip";
            this.txtNombreChip.Size = new System.Drawing.Size(100, 20);
            this.txtNombreChip.TabIndex = 1;
            // 
            // lblCapcidad
            // 
            this.lblCapcidad.AutoSize = true;
            this.lblCapcidad.Location = new System.Drawing.Point(6, 55);
            this.lblCapcidad.Name = "lblCapcidad";
            this.lblCapcidad.Size = new System.Drawing.Size(85, 13);
            this.lblCapcidad.TabIndex = 2;
            this.lblCapcidad.Text = "Capacidad(GHz)";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(97, 55);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(58, 20);
            this.txtCapacidad.TabIndex = 3;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(164, 87);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "&Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // grpDispositivos
            // 
            this.grpDispositivos.Controls.Add(this.btnAgregar);
            this.grpDispositivos.Controls.Add(this.txtPrecioDispositivo);
            this.grpDispositivos.Controls.Add(this.lblPrecioDispositivo);
            this.grpDispositivos.Controls.Add(this.txtNombreDispositivo);
            this.grpDispositivos.Controls.Add(this.label1);
            this.grpDispositivos.Location = new System.Drawing.Point(324, 19);
            this.grpDispositivos.Name = "grpDispositivos";
            this.grpDispositivos.Size = new System.Drawing.Size(245, 106);
            this.grpDispositivos.TabIndex = 4;
            this.grpDispositivos.TabStop = false;
            this.grpDispositivos.Text = "Dispositivos";
            // 
            // txtNombreDispositivo
            // 
            this.txtNombreDispositivo.Location = new System.Drawing.Point(108, 19);
            this.txtNombreDispositivo.Name = "txtNombreDispositivo";
            this.txtNombreDispositivo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDispositivo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre dispositivo";
            // 
            // txtPrecioDispositivo
            // 
            this.txtPrecioDispositivo.Location = new System.Drawing.Point(108, 45);
            this.txtPrecioDispositivo.Name = "txtPrecioDispositivo";
            this.txtPrecioDispositivo.Size = new System.Drawing.Size(65, 20);
            this.txtPrecioDispositivo.TabIndex = 7;
            // 
            // lblPrecioDispositivo
            // 
            this.lblPrecioDispositivo.AutoSize = true;
            this.lblPrecioDispositivo.Location = new System.Drawing.Point(65, 48);
            this.lblPrecioDispositivo.Name = "lblPrecioDispositivo";
            this.lblPrecioDispositivo.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioDispositivo.TabIndex = 6;
            this.lblPrecioDispositivo.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(164, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstiPhone
            // 
            this.lstiPhone.FormattingEnabled = true;
            this.lstiPhone.Location = new System.Drawing.Point(324, 131);
            this.lstiPhone.Name = "lstiPhone";
            this.lstiPhone.Size = new System.Drawing.Size(102, 199);
            this.lstiPhone.TabIndex = 5;
            this.lstiPhone.Click += new System.EventHandler(this.lstiPhone_Click);
            // 
            // dtgChip
            // 
            this.dtgChip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChip.Location = new System.Drawing.Point(586, 24);
            this.dtgChip.Name = "dtgChip";
            this.dtgChip.Size = new System.Drawing.Size(288, 101);
            this.dtgChip.TabIndex = 6;
            // 
            // dtgDispositivos
            // 
            this.dtgDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDispositivos.Location = new System.Drawing.Point(432, 131);
            this.dtgDispositivos.Name = "dtgDispositivos";
            this.dtgDispositivos.Size = new System.Drawing.Size(442, 178);
            this.dtgDispositivos.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(789, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 343);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgDispositivos);
            this.Controls.Add(this.dtgChip);
            this.Controls.Add(this.lstiPhone);
            this.Controls.Add(this.grpDispositivos);
            this.Controls.Add(this.grpChip);
            this.Controls.Add(this.grpProducto);
            this.Name = "Form1";
            this.Text = "\r\nApple";
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            this.grpChip.ResumeLayout(false);
            this.grpChip.PerformLayout();
            this.grpDispositivos.ResumeLayout(false);
            this.grpDispositivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDispositivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.TextBox txtTipoPuerto;
        private System.Windows.Forms.TextBox txtCantidadCamaras;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radSi;
        private System.Windows.Forms.RadioButton radiPad;
        private System.Windows.Forms.RadioButton radMacBook;
        private System.Windows.Forms.RadioButton radiPhone;
        private System.Windows.Forms.Label lblTipoPuerto;
        private System.Windows.Forms.Label lblCantidadCamaras;
        private System.Windows.Forms.Label lblHuellaDactilar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtSO;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblSO;
        private System.Windows.Forms.GroupBox grpChip;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblCapcidad;
        private System.Windows.Forms.TextBox txtNombreChip;
        private System.Windows.Forms.Label lblChip;
        private System.Windows.Forms.GroupBox grpDispositivos;
        private System.Windows.Forms.TextBox txtPrecioDispositivo;
        private System.Windows.Forms.Label lblPrecioDispositivo;
        private System.Windows.Forms.TextBox txtNombreDispositivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstiPhone;
        private System.Windows.Forms.DataGridView dtgChip;
        private System.Windows.Forms.DataGridView dtgDispositivos;
        private System.Windows.Forms.Button btnSalir;
    }
}

