namespace UI
{
    partial class Principal
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
            this.lblInventario = new System.Windows.Forms.Label();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lblFil = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboBoxCategor = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.timePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.TimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(416, 31);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(70, 17);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inventario";
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(169, 120);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(144, 71);
            this.btnArticulo.TabIndex = 1;
            this.btnArticulo.Text = "Administrar Artículos";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(560, 120);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(144, 71);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Administrar Categorías";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // lblFil
            // 
            this.lblFil.AutoSize = true;
            this.lblFil.Location = new System.Drawing.Point(245, 310);
            this.lblFil.Name = "lblFil";
            this.lblFil.Size = new System.Drawing.Size(73, 17);
            this.lblFil.TabIndex = 3;
            this.lblFil.Text = "Filtrar por:";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(339, 303);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(152, 24);
            this.comboBoxFiltro.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(391, 387);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 355);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Visible = false;
            // 
            // comboBoxCategor
            // 
            this.comboBoxCategor.FormattingEnabled = true;
            this.comboBoxCategor.Location = new System.Drawing.Point(483, 353);
            this.comboBoxCategor.Name = "comboBoxCategor";
            this.comboBoxCategor.Size = new System.Drawing.Size(169, 24);
            this.comboBoxCategor.TabIndex = 7;
            this.comboBoxCategor.Visible = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(526, 303);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // timePickerInicio
            // 
            this.timePickerInicio.Location = new System.Drawing.Point(188, 432);
            this.timePickerInicio.Name = "timePickerInicio";
            this.timePickerInicio.Size = new System.Drawing.Size(200, 22);
            this.timePickerInicio.TabIndex = 9;
            this.timePickerInicio.Visible = false;
            // 
            // TimePickerFin
            // 
            this.TimePickerFin.Location = new System.Drawing.Point(507, 432);
            this.TimePickerFin.Name = "TimePickerFin";
            this.TimePickerFin.Size = new System.Drawing.Size(200, 22);
            this.TimePickerFin.TabIndex = 10;
            this.TimePickerFin.Visible = false;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Location = new System.Drawing.Point(188, 409);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(83, 17);
            this.lblFechaIni.TabIndex = 11;
            this.lblFechaIni.Text = "Fecha Inicio";
            this.lblFechaIni.Visible = false;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(507, 409);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(70, 17);
            this.lblFechaFin.TabIndex = 12;
            this.lblFechaFin.Text = "Fecha Fin";
            this.lblFechaFin.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 575);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.TimePickerFin);
            this.Controls.Add(this.timePickerInicio);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.comboBoxCategor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.lblFil);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.lblInventario);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label lblFil;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBoxCategor;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker timePickerInicio;
        private System.Windows.Forms.DateTimePicker TimePickerFin;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblFechaFin;
    }
}

