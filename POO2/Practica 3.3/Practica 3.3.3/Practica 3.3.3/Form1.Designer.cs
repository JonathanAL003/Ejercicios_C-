namespace Practica_3._3._3
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
            this.lblNombrePastel = new System.Windows.Forms.Label();
            this.lblCantidadDePersonas = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombrePastel = new System.Windows.Forms.TextBox();
            this.txtCantidadDePersonas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.grpIngrediente = new System.Windows.Forms.GroupBox();
            this.lblNombreIngrediente = new System.Windows.Forms.Label();
            this.lblUnidadDeMedida = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCaloriasPorPorcion = new System.Windows.Forms.Label();
            this.txtNombreIngrediente = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCaloriasPorPorcion = new System.Windows.Forms.TextBox();
            this.radGramos = new System.Windows.Forms.RadioButton();
            this.radPiezas = new System.Windows.Forms.RadioButton();
            this.radMililitros = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgIngredientes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnContarIngredientes = new System.Windows.Forms.Button();
            this.btnSumarCalorias = new System.Windows.Forms.Button();
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
            this.grpPastel.TabIndex = 0;
            this.grpPastel.TabStop = false;
            this.grpPastel.Text = "Pastel";
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
            // lblCantidadDePersonas
            // 
            this.lblCantidadDePersonas.AutoSize = true;
            this.lblCantidadDePersonas.Location = new System.Drawing.Point(6, 56);
            this.lblCantidadDePersonas.Name = "lblCantidadDePersonas";
            this.lblCantidadDePersonas.Size = new System.Drawing.Size(110, 13);
            this.lblCantidadDePersonas.TabIndex = 1;
            this.lblCantidadDePersonas.Text = "Cantidad de personas";
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
            // txtNombrePastel
            // 
            this.txtNombrePastel.Location = new System.Drawing.Point(122, 24);
            this.txtNombrePastel.Name = "txtNombrePastel";
            this.txtNombrePastel.Size = new System.Drawing.Size(171, 20);
            this.txtNombrePastel.TabIndex = 3;
            // 
            // txtCantidadDePersonas
            // 
            this.txtCantidadDePersonas.Location = new System.Drawing.Point(122, 53);
            this.txtCantidadDePersonas.Name = "txtCantidadDePersonas";
            this.txtCantidadDePersonas.Size = new System.Drawing.Size(45, 20);
            this.txtCantidadDePersonas.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(122, 79);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(51, 20);
            this.txtPrecio.TabIndex = 5;
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
            this.grpIngrediente.TabIndex = 1;
            this.grpIngrediente.TabStop = false;
            this.grpIngrediente.Text = "Ingrediente";
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
            // lblUnidadDeMedida
            // 
            this.lblUnidadDeMedida.AutoSize = true;
            this.lblUnidadDeMedida.Location = new System.Drawing.Point(13, 55);
            this.lblUnidadDeMedida.Name = "lblUnidadDeMedida";
            this.lblUnidadDeMedida.Size = new System.Drawing.Size(93, 13);
            this.lblUnidadDeMedida.TabIndex = 1;
            this.lblUnidadDeMedida.Text = "Unidad de medida";
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
            // lblCaloriasPorPorcion
            // 
            this.lblCaloriasPorPorcion.AutoSize = true;
            this.lblCaloriasPorPorcion.Location = new System.Drawing.Point(6, 105);
            this.lblCaloriasPorPorcion.Name = "lblCaloriasPorPorcion";
            this.lblCaloriasPorPorcion.Size = new System.Drawing.Size(100, 13);
            this.lblCaloriasPorPorcion.TabIndex = 3;
            this.lblCaloriasPorPorcion.Text = "Calorias por porción";
            // 
            // txtNombreIngrediente
            // 
            this.txtNombreIngrediente.Location = new System.Drawing.Point(112, 27);
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.Size = new System.Drawing.Size(120, 20);
            this.txtNombreIngrediente.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 76);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtCaloriasPorPorcion
            // 
            this.txtCaloriasPorPorcion.Location = new System.Drawing.Point(112, 102);
            this.txtCaloriasPorPorcion.Name = "txtCaloriasPorPorcion";
            this.txtCaloriasPorPorcion.Size = new System.Drawing.Size(72, 20);
            this.txtCaloriasPorPorcion.TabIndex = 6;
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
            // dtgIngredientes
            // 
            this.dtgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngredientes.Location = new System.Drawing.Point(324, 18);
            this.dtgIngredientes.Name = "dtgIngredientes";
            this.dtgIngredientes.Size = new System.Drawing.Size(395, 203);
            this.dtgIngredientes.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(644, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnContarIngredientes
            // 
            this.btnContarIngredientes.Location = new System.Drawing.Point(324, 229);
            this.btnContarIngredientes.Name = "btnContarIngredientes";
            this.btnContarIngredientes.Size = new System.Drawing.Size(116, 23);
            this.btnContarIngredientes.TabIndex = 11;
            this.btnContarIngredientes.Text = "&Contar Ingredientes";
            this.btnContarIngredientes.UseVisualStyleBackColor = true;
            this.btnContarIngredientes.Click += new System.EventHandler(this.btnContarIngredientes_Click);
            // 
            // btnSumarCalorias
            // 
            this.btnSumarCalorias.Location = new System.Drawing.Point(446, 230);
            this.btnSumarCalorias.Name = "btnSumarCalorias";
            this.btnSumarCalorias.Size = new System.Drawing.Size(116, 23);
            this.btnSumarCalorias.TabIndex = 12;
            this.btnSumarCalorias.Text = "&Sumar calorias";
            this.btnSumarCalorias.UseVisualStyleBackColor = true;
            this.btnSumarCalorias.Click += new System.EventHandler(this.btnSumarCalorias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 259);
            this.Controls.Add(this.btnSumarCalorias);
            this.Controls.Add(this.btnContarIngredientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgIngredientes);
            this.Controls.Add(this.grpIngrediente);
            this.Controls.Add(this.grpPastel);
            this.Name = "Form1";
            this.Text = "Pasteleria";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnContarIngredientes;
        private System.Windows.Forms.Button btnSumarCalorias;
    }
}

