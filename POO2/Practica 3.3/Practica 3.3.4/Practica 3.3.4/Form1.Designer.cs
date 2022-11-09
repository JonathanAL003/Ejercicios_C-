namespace Practica_3._3._4
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
            this.grpPastel = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidadDePersonas = new System.Windows.Forms.TextBox();
            this.txtNombrePastel = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidadDePersonas = new System.Windows.Forms.Label();
            this.lblNombrePastel = new System.Windows.Forms.Label();
            this.grpIngrediente = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.radMililitros = new System.Windows.Forms.RadioButton();
            this.radPiezas = new System.Windows.Forms.RadioButton();
            this.radGramos = new System.Windows.Forms.RadioButton();
            this.txtCaloriasPorPorcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreIngrediente = new System.Windows.Forms.TextBox();
            this.lblCaloriasPorPorcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidadDeMedida = new System.Windows.Forms.Label();
            this.lblNombreIngrediente = new System.Windows.Forms.Label();
            this.dtgIngredientes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSumarCalorias = new System.Windows.Forms.Button();
            this.btnContarIngredientes = new System.Windows.Forms.Button();
            this.lstPasteles = new System.Windows.Forms.ListBox();
            this.btnTotalIngredientes = new System.Windows.Forms.Button();
            this.btnTotalCalorias = new System.Windows.Forms.Button();
            this.btnPastelMasCaro = new System.Windows.Forms.Button();
            this.btnPastelMasBarato = new System.Windows.Forms.Button();
            this.grpPastel.SuspendLayout();
            this.grpIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPastel
            // 
            this.grpPastel.Controls.Add(this.btnCrear);
            this.grpPastel.Controls.Add(this.txtPrecio);
            this.grpPastel.Controls.Add(this.txtCantidadDePersonas);
            this.grpPastel.Controls.Add(this.txtNombrePastel);
            this.grpPastel.Controls.Add(this.lblPrecio);
            this.grpPastel.Controls.Add(this.lblCantidadDePersonas);
            this.grpPastel.Controls.Add(this.lblNombrePastel);
            this.grpPastel.Location = new System.Drawing.Point(12, 12);
            this.grpPastel.Name = "grpPastel";
            this.grpPastel.Size = new System.Drawing.Size(306, 107);
            this.grpPastel.TabIndex = 1;
            this.grpPastel.TabStop = false;
            this.grpPastel.Text = "Pastel";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(218, 75);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "&Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(122, 79);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(51, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtCantidadDePersonas
            // 
            this.txtCantidadDePersonas.Location = new System.Drawing.Point(122, 53);
            this.txtCantidadDePersonas.Name = "txtCantidadDePersonas";
            this.txtCantidadDePersonas.Size = new System.Drawing.Size(45, 20);
            this.txtCantidadDePersonas.TabIndex = 4;
            // 
            // txtNombrePastel
            // 
            this.txtNombrePastel.Location = new System.Drawing.Point(122, 24);
            this.txtNombrePastel.Name = "txtNombrePastel";
            this.txtNombrePastel.Size = new System.Drawing.Size(171, 20);
            this.txtNombrePastel.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(79, 82);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidadDePersonas
            // 
            this.lblCantidadDePersonas.AutoSize = true;
            this.lblCantidadDePersonas.Location = new System.Drawing.Point(6, 56);
            this.lblCantidadDePersonas.Name = "lblCantidadDePersonas";
            this.lblCantidadDePersonas.Size = new System.Drawing.Size(110, 13);
            this.lblCantidadDePersonas.TabIndex = 1;
            this.lblCantidadDePersonas.Text = "Cantidad de personas";
            // 
            // lblNombrePastel
            // 
            this.lblNombrePastel.AutoSize = true;
            this.lblNombrePastel.Location = new System.Drawing.Point(72, 27);
            this.lblNombrePastel.Name = "lblNombrePastel";
            this.lblNombrePastel.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePastel.TabIndex = 0;
            this.lblNombrePastel.Text = "Nombre";
            // 
            // grpIngrediente
            // 
            this.grpIngrediente.Controls.Add(this.btnAgregar);
            this.grpIngrediente.Controls.Add(this.radMililitros);
            this.grpIngrediente.Controls.Add(this.radPiezas);
            this.grpIngrediente.Controls.Add(this.radGramos);
            this.grpIngrediente.Controls.Add(this.txtCaloriasPorPorcion);
            this.grpIngrediente.Controls.Add(this.txtCantidad);
            this.grpIngrediente.Controls.Add(this.txtNombreIngrediente);
            this.grpIngrediente.Controls.Add(this.lblCaloriasPorPorcion);
            this.grpIngrediente.Controls.Add(this.lblCantidad);
            this.grpIngrediente.Controls.Add(this.lblUnidadDeMedida);
            this.grpIngrediente.Controls.Add(this.lblNombreIngrediente);
            this.grpIngrediente.Location = new System.Drawing.Point(12, 125);
            this.grpIngrediente.Name = "grpIngrediente";
            this.grpIngrediente.Size = new System.Drawing.Size(306, 129);
            this.grpIngrediente.TabIndex = 2;
            this.grpIngrediente.TabStop = false;
            this.grpIngrediente.Text = "Ingrediente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(218, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // radMililitros
            // 
            this.radMililitros.AutoSize = true;
            this.radMililitros.Location = new System.Drawing.Point(171, 53);
            this.radMililitros.Name = "radMililitros";
            this.radMililitros.Size = new System.Drawing.Size(61, 17);
            this.radMililitros.TabIndex = 9;
            this.radMililitros.Text = "Mililitros";
            this.radMililitros.UseVisualStyleBackColor = true;
            // 
            // radPiezas
            // 
            this.radPiezas.AutoSize = true;
            this.radPiezas.Location = new System.Drawing.Point(237, 53);
            this.radPiezas.Name = "radPiezas";
            this.radPiezas.Size = new System.Drawing.Size(56, 17);
            this.radPiezas.TabIndex = 8;
            this.radPiezas.Text = "Piezas";
            this.radPiezas.UseVisualStyleBackColor = true;
            // 
            // radGramos
            // 
            this.radGramos.AutoSize = true;
            this.radGramos.Checked = true;
            this.radGramos.Location = new System.Drawing.Point(112, 53);
            this.radGramos.Name = "radGramos";
            this.radGramos.Size = new System.Drawing.Size(61, 17);
            this.radGramos.TabIndex = 7;
            this.radGramos.TabStop = true;
            this.radGramos.Text = "Gramos";
            this.radGramos.UseVisualStyleBackColor = true;
            // 
            // txtCaloriasPorPorcion
            // 
            this.txtCaloriasPorPorcion.Location = new System.Drawing.Point(112, 102);
            this.txtCaloriasPorPorcion.Name = "txtCaloriasPorPorcion";
            this.txtCaloriasPorPorcion.Size = new System.Drawing.Size(72, 20);
            this.txtCaloriasPorPorcion.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 76);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtNombreIngrediente
            // 
            this.txtNombreIngrediente.Location = new System.Drawing.Point(112, 27);
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.Size = new System.Drawing.Size(120, 20);
            this.txtNombreIngrediente.TabIndex = 4;
            // 
            // lblCaloriasPorPorcion
            // 
            this.lblCaloriasPorPorcion.AutoSize = true;
            this.lblCaloriasPorPorcion.Location = new System.Drawing.Point(6, 105);
            this.lblCaloriasPorPorcion.Name = "lblCaloriasPorPorcion";
            this.lblCaloriasPorPorcion.Size = new System.Drawing.Size(100, 13);
            this.lblCaloriasPorPorcion.TabIndex = 3;
            this.lblCaloriasPorPorcion.Text = "Calorias por porción";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(54, 79);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantitdad";
            // 
            // lblUnidadDeMedida
            // 
            this.lblUnidadDeMedida.AutoSize = true;
            this.lblUnidadDeMedida.Location = new System.Drawing.Point(13, 55);
            this.lblUnidadDeMedida.Name = "lblUnidadDeMedida";
            this.lblUnidadDeMedida.Size = new System.Drawing.Size(93, 13);
            this.lblUnidadDeMedida.TabIndex = 1;
            this.lblUnidadDeMedida.Text = "Unidad de medida";
            // 
            // lblNombreIngrediente
            // 
            this.lblNombreIngrediente.AutoSize = true;
            this.lblNombreIngrediente.Location = new System.Drawing.Point(62, 30);
            this.lblNombreIngrediente.Name = "lblNombreIngrediente";
            this.lblNombreIngrediente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreIngrediente.TabIndex = 0;
            this.lblNombreIngrediente.Text = "Nombre";
            // 
            // dtgIngredientes
            // 
            this.dtgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngredientes.Location = new System.Drawing.Point(469, 18);
            this.dtgIngredientes.Name = "dtgIngredientes";
            this.dtgIngredientes.Size = new System.Drawing.Size(395, 236);
            this.dtgIngredientes.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(789, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSumarCalorias
            // 
            this.btnSumarCalorias.Location = new System.Drawing.Point(12, 289);
            this.btnSumarCalorias.Name = "btnSumarCalorias";
            this.btnSumarCalorias.Size = new System.Drawing.Size(167, 23);
            this.btnSumarCalorias.TabIndex = 13;
            this.btnSumarCalorias.Text = "&Sumar calorias pastel actual";
            this.btnSumarCalorias.UseVisualStyleBackColor = true;
            this.btnSumarCalorias.Click += new System.EventHandler(this.btnSumarCalorias_Click);
            // 
            // btnContarIngredientes
            // 
            this.btnContarIngredientes.Location = new System.Drawing.Point(12, 260);
            this.btnContarIngredientes.Name = "btnContarIngredientes";
            this.btnContarIngredientes.Size = new System.Drawing.Size(173, 23);
            this.btnContarIngredientes.TabIndex = 14;
            this.btnContarIngredientes.Text = "&Contar Ingredientes pastel actual";
            this.btnContarIngredientes.UseVisualStyleBackColor = true;
            this.btnContarIngredientes.Click += new System.EventHandler(this.btnContarIngredientes_Click);
            // 
            // lstPasteles
            // 
            this.lstPasteles.FormattingEnabled = true;
            this.lstPasteles.Location = new System.Drawing.Point(324, 18);
            this.lstPasteles.Name = "lstPasteles";
            this.lstPasteles.Size = new System.Drawing.Size(139, 238);
            this.lstPasteles.TabIndex = 15;
            this.lstPasteles.Click += new System.EventHandler(this.lstPasteles_Click);
            // 
            // btnTotalIngredientes
            // 
            this.btnTotalIngredientes.Location = new System.Drawing.Point(244, 260);
            this.btnTotalIngredientes.Name = "btnTotalIngredientes";
            this.btnTotalIngredientes.Size = new System.Drawing.Size(202, 23);
            this.btnTotalIngredientes.TabIndex = 16;
            this.btnTotalIngredientes.Text = "&Total ingredientes, todos los pasteles";
            this.btnTotalIngredientes.UseVisualStyleBackColor = true;
            this.btnTotalIngredientes.Click += new System.EventHandler(this.btnTotalIngredientes_Click);
            // 
            // btnTotalCalorias
            // 
            this.btnTotalCalorias.Location = new System.Drawing.Point(452, 260);
            this.btnTotalCalorias.Name = "btnTotalCalorias";
            this.btnTotalCalorias.Size = new System.Drawing.Size(202, 23);
            this.btnTotalCalorias.TabIndex = 17;
            this.btnTotalCalorias.Text = "&Total calorias, todos los pasteles";
            this.btnTotalCalorias.UseVisualStyleBackColor = true;
            this.btnTotalCalorias.Click += new System.EventHandler(this.btnTotalCalorias_Click);
            // 
            // btnPastelMasCaro
            // 
            this.btnPastelMasCaro.Location = new System.Drawing.Point(660, 260);
            this.btnPastelMasCaro.Name = "btnPastelMasCaro";
            this.btnPastelMasCaro.Size = new System.Drawing.Size(99, 23);
            this.btnPastelMasCaro.TabIndex = 18;
            this.btnPastelMasCaro.Text = "&Pastel más caro";
            this.btnPastelMasCaro.UseVisualStyleBackColor = true;
            this.btnPastelMasCaro.Click += new System.EventHandler(this.btnPastelMasCaro_Click);
            // 
            // btnPastelMasBarato
            // 
            this.btnPastelMasBarato.Location = new System.Drawing.Point(765, 260);
            this.btnPastelMasBarato.Name = "btnPastelMasBarato";
            this.btnPastelMasBarato.Size = new System.Drawing.Size(99, 23);
            this.btnPastelMasBarato.TabIndex = 19;
            this.btnPastelMasBarato.Text = "&Pastel más barato";
            this.btnPastelMasBarato.UseVisualStyleBackColor = true;
            this.btnPastelMasBarato.Click += new System.EventHandler(this.btnPastelMasBarato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 333);
            this.Controls.Add(this.btnPastelMasBarato);
            this.Controls.Add(this.btnPastelMasCaro);
            this.Controls.Add(this.btnTotalCalorias);
            this.Controls.Add(this.btnTotalIngredientes);
            this.Controls.Add(this.lstPasteles);
            this.Controls.Add(this.btnContarIngredientes);
            this.Controls.Add(this.btnSumarCalorias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgIngredientes);
            this.Controls.Add(this.grpIngrediente);
            this.Controls.Add(this.grpPastel);
            this.Name = "Form1";
            this.Text = "Pasteleria";
            this.grpPastel.ResumeLayout(false);
            this.grpPastel.PerformLayout();
            this.grpIngrediente.ResumeLayout(false);
            this.grpIngrediente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPastel;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidadDePersonas;
        private System.Windows.Forms.TextBox txtNombrePastel;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidadDePersonas;
        private System.Windows.Forms.Label lblNombrePastel;
        private System.Windows.Forms.GroupBox grpIngrediente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radMililitros;
        private System.Windows.Forms.RadioButton radPiezas;
        private System.Windows.Forms.RadioButton radGramos;
        private System.Windows.Forms.TextBox txtCaloriasPorPorcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombreIngrediente;
        private System.Windows.Forms.Label lblCaloriasPorPorcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUnidadDeMedida;
        private System.Windows.Forms.Label lblNombreIngrediente;
        private System.Windows.Forms.DataGridView dtgIngredientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSumarCalorias;
        private System.Windows.Forms.Button btnContarIngredientes;
        private System.Windows.Forms.ListBox lstPasteles;
        private System.Windows.Forms.Button btnTotalIngredientes;
        private System.Windows.Forms.Button btnTotalCalorias;
        private System.Windows.Forms.Button btnPastelMasCaro;
        private System.Windows.Forms.Button btnPastelMasBarato;
    }
}

