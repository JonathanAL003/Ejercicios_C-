namespace Practica_4._1._3
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
            this.grpTipoDeVehiculo = new System.Windows.Forms.GroupBox();
            this.radTractor = new System.Windows.Forms.RadioButton();
            this.radAutobus = new System.Windows.Forms.RadioButton();
            this.grpDatosDelVehiculo = new System.Windows.Forms.GroupBox();
            this.dtmFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtmFechaRenta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblFechaRenta = new System.Windows.Forms.Label();
            this.txtKmDevolver = new System.Windows.Forms.TextBox();
            this.txtKmRenta = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.lblKmAlDevolver = new System.Windows.Forms.Label();
            this.lblKmAlRentar = new System.Windows.Forms.Label();
            this.lblPrecioRenta = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.btnRentar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkDevolver = new System.Windows.Forms.CheckBox();
            this.grpTipoDeVehiculo.SuspendLayout();
            this.grpDatosDelVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoDeVehiculo
            // 
            this.grpTipoDeVehiculo.Controls.Add(this.radTractor);
            this.grpTipoDeVehiculo.Controls.Add(this.radAutobus);
            this.grpTipoDeVehiculo.Location = new System.Drawing.Point(12, 12);
            this.grpTipoDeVehiculo.Name = "grpTipoDeVehiculo";
            this.grpTipoDeVehiculo.Size = new System.Drawing.Size(105, 68);
            this.grpTipoDeVehiculo.TabIndex = 0;
            this.grpTipoDeVehiculo.TabStop = false;
            this.grpTipoDeVehiculo.Text = "Tipo de vehículo";
            // 
            // radTractor
            // 
            this.radTractor.AutoSize = true;
            this.radTractor.Location = new System.Drawing.Point(6, 42);
            this.radTractor.Name = "radTractor";
            this.radTractor.Size = new System.Drawing.Size(59, 17);
            this.radTractor.TabIndex = 1;
            this.radTractor.Text = "Tractor";
            this.radTractor.UseVisualStyleBackColor = true;
            this.radTractor.CheckedChanged += new System.EventHandler(this.radTractor_CheckedChanged);
            // 
            // radAutobus
            // 
            this.radAutobus.AutoSize = true;
            this.radAutobus.Checked = true;
            this.radAutobus.Location = new System.Drawing.Point(6, 19);
            this.radAutobus.Name = "radAutobus";
            this.radAutobus.Size = new System.Drawing.Size(64, 17);
            this.radAutobus.TabIndex = 0;
            this.radAutobus.TabStop = true;
            this.radAutobus.Text = "Autobús";
            this.radAutobus.UseVisualStyleBackColor = true;
            this.radAutobus.CheckedChanged += new System.EventHandler(this.radAutobus_CheckedChanged);
            // 
            // grpDatosDelVehiculo
            // 
            this.grpDatosDelVehiculo.Controls.Add(this.dtmFechaDevolucion);
            this.grpDatosDelVehiculo.Controls.Add(this.dtmFechaRenta);
            this.grpDatosDelVehiculo.Controls.Add(this.lblFechaDevolucion);
            this.grpDatosDelVehiculo.Controls.Add(this.lblFechaRenta);
            this.grpDatosDelVehiculo.Controls.Add(this.txtKmDevolver);
            this.grpDatosDelVehiculo.Controls.Add(this.txtKmRenta);
            this.grpDatosDelVehiculo.Controls.Add(this.txtPrecio);
            this.grpDatosDelVehiculo.Controls.Add(this.txtPlacas);
            this.grpDatosDelVehiculo.Controls.Add(this.lblKmAlDevolver);
            this.grpDatosDelVehiculo.Controls.Add(this.lblKmAlRentar);
            this.grpDatosDelVehiculo.Controls.Add(this.lblPrecioRenta);
            this.grpDatosDelVehiculo.Controls.Add(this.lblPlacas);
            this.grpDatosDelVehiculo.Location = new System.Drawing.Point(12, 86);
            this.grpDatosDelVehiculo.Name = "grpDatosDelVehiculo";
            this.grpDatosDelVehiculo.Size = new System.Drawing.Size(422, 130);
            this.grpDatosDelVehiculo.TabIndex = 1;
            this.grpDatosDelVehiculo.TabStop = false;
            this.grpDatosDelVehiculo.Text = "Datos del vehículo";
            // 
            // dtmFechaDevolucion
            // 
            this.dtmFechaDevolucion.Location = new System.Drawing.Point(214, 97);
            this.dtmFechaDevolucion.Name = "dtmFechaDevolucion";
            this.dtmFechaDevolucion.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaDevolucion.TabIndex = 11;
            // 
            // dtmFechaRenta
            // 
            this.dtmFechaRenta.Enabled = false;
            this.dtmFechaRenta.Location = new System.Drawing.Point(214, 44);
            this.dtmFechaRenta.Name = "dtmFechaRenta";
            this.dtmFechaRenta.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaRenta.TabIndex = 10;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(261, 81);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(107, 13);
            this.lblFechaDevolucion.TabIndex = 9;
            this.lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblFechaRenta
            // 
            this.lblFechaRenta.AutoSize = true;
            this.lblFechaRenta.Location = new System.Drawing.Point(277, 25);
            this.lblFechaRenta.Name = "lblFechaRenta";
            this.lblFechaRenta.Size = new System.Drawing.Size(79, 13);
            this.lblFechaRenta.TabIndex = 8;
            this.lblFechaRenta.Text = "Fecha de renta";
            // 
            // txtKmDevolver
            // 
            this.txtKmDevolver.Location = new System.Drawing.Point(89, 100);
            this.txtKmDevolver.Name = "txtKmDevolver";
            this.txtKmDevolver.Size = new System.Drawing.Size(72, 20);
            this.txtKmDevolver.TabIndex = 7;
            // 
            // txtKmRenta
            // 
            this.txtKmRenta.Location = new System.Drawing.Point(89, 74);
            this.txtKmRenta.Name = "txtKmRenta";
            this.txtKmRenta.Size = new System.Drawing.Size(72, 20);
            this.txtKmRenta.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(89, 48);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(72, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(89, 22);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(110, 20);
            this.txtPlacas.TabIndex = 4;
            // 
            // lblKmAlDevolver
            // 
            this.lblKmAlDevolver.AutoSize = true;
            this.lblKmAlDevolver.Location = new System.Drawing.Point(6, 103);
            this.lblKmAlDevolver.Name = "lblKmAlDevolver";
            this.lblKmAlDevolver.Size = new System.Drawing.Size(77, 13);
            this.lblKmAlDevolver.TabIndex = 3;
            this.lblKmAlDevolver.Text = "Km al devolver";
            // 
            // lblKmAlRentar
            // 
            this.lblKmAlRentar.AutoSize = true;
            this.lblKmAlRentar.Location = new System.Drawing.Point(19, 77);
            this.lblKmAlRentar.Name = "lblKmAlRentar";
            this.lblKmAlRentar.Size = new System.Drawing.Size(63, 13);
            this.lblKmAlRentar.TabIndex = 2;
            this.lblKmAlRentar.Text = "Km al rentar";
            // 
            // lblPrecioRenta
            // 
            this.lblPrecioRenta.AutoSize = true;
            this.lblPrecioRenta.Location = new System.Drawing.Point(19, 51);
            this.lblPrecioRenta.Name = "lblPrecioRenta";
            this.lblPrecioRenta.Size = new System.Drawing.Size(64, 13);
            this.lblPrecioRenta.TabIndex = 1;
            this.lblPrecioRenta.Text = "Precio renta";
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(44, 25);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(39, 13);
            this.lblPlacas.TabIndex = 0;
            this.lblPlacas.Text = "Placas";
            // 
            // btnRentar
            // 
            this.btnRentar.Location = new System.Drawing.Point(136, 31);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(75, 23);
            this.btnRentar.TabIndex = 2;
            this.btnRentar.Text = "&Rentar";
            this.btnRentar.UseVisualStyleBackColor = true;
            this.btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(217, 31);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text = "&Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(358, 31);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkDevolver
            // 
            this.chkDevolver.AutoSize = true;
            this.chkDevolver.Location = new System.Drawing.Point(136, 63);
            this.chkDevolver.Name = "chkDevolver";
            this.chkDevolver.Size = new System.Drawing.Size(69, 17);
            this.chkDevolver.TabIndex = 5;
            this.chkDevolver.Text = "Devolver";
            this.chkDevolver.UseVisualStyleBackColor = true;
            this.chkDevolver.CheckedChanged += new System.EventHandler(this.chkDevolver_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 223);
            this.Controls.Add(this.chkDevolver);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnRentar);
            this.Controls.Add(this.grpDatosDelVehiculo);
            this.Controls.Add(this.grpTipoDeVehiculo);
            this.Name = "Form1";
            this.Text = "Alquiler de vehículos";
            this.grpTipoDeVehiculo.ResumeLayout(false);
            this.grpTipoDeVehiculo.PerformLayout();
            this.grpDatosDelVehiculo.ResumeLayout(false);
            this.grpDatosDelVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoDeVehiculo;
        private System.Windows.Forms.RadioButton radTractor;
        private System.Windows.Forms.RadioButton radAutobus;
        private System.Windows.Forms.GroupBox grpDatosDelVehiculo;
        private System.Windows.Forms.TextBox txtKmDevolver;
        private System.Windows.Forms.TextBox txtKmRenta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label lblKmAlDevolver;
        private System.Windows.Forms.Label lblKmAlRentar;
        private System.Windows.Forms.Label lblPrecioRenta;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.DateTimePicker dtmFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtmFechaRenta;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblFechaRenta;
        private System.Windows.Forms.Button btnRentar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkDevolver;
    }
}

