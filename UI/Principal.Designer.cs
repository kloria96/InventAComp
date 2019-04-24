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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblInventario = new System.Windows.Forms.Label();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lblFil = new System.Windows.Forms.Label();
            this.cbFiltros = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.cbArticulos = new System.Windows.Forms.ComboBox();
            this.cbPrestamos = new System.Windows.Forms.ComboBox();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInventario
            // 
            this.lblInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInventario.Location = new System.Drawing.Point(205, 33);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(490, 36);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inventario Asociación Acompáñame";
            // 
            // btnArticulo
            // 
            this.btnArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArticulo.BackColor = System.Drawing.Color.Teal;
            this.btnArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArticulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnArticulo.Location = new System.Drawing.Point(57, 292);
            this.btnArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(227, 103);
            this.btnArticulo.TabIndex = 1;
            this.btnArticulo.Text = "Administrar Artículos";
            this.btnArticulo.UseVisualStyleBackColor = false;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoria.BackColor = System.Drawing.Color.Teal;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategoria.Location = new System.Drawing.Point(57, 463);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(227, 103);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "Administrar Categorías";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // lblFil
            // 
            this.lblFil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFil.AutoSize = true;
            this.lblFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFil.Location = new System.Drawing.Point(538, 269);
            this.lblFil.Name = "lblFil";
            this.lblFil.Size = new System.Drawing.Size(94, 24);
            this.lblFil.TabIndex = 3;
            this.lblFil.Text = "Filtrar por:";
            // 
            // cbFiltros
            // 
            this.cbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltros.FormattingEnabled = true;
            this.cbFiltros.Items.AddRange(new object[] {
            "Nombre",
            "Categoría",
            "Fecha de ingreso"});
            this.cbFiltros.Location = new System.Drawing.Point(679, 265);
            this.cbFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Size = new System.Drawing.Size(201, 32);
            this.cbFiltros.TabIndex = 4;
            this.cbFiltros.SelectedIndexChanged += new System.EventHandler(this.cbFiltros_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(936, 249);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(189, 55);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar Artículos";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(734, 355);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 26);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Visible = false;
            // 
            // cbCategorias
            // 
            this.cbCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(734, 355);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(237, 28);
            this.cbCategorias.TabIndex = 7;
            this.cbCategorias.Visible = false;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // dtInicio
            // 
            this.dtInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Location = new System.Drawing.Point(734, 355);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(325, 24);
            this.dtInicio.TabIndex = 9;
            this.dtInicio.Visible = false;
            // 
            // dtFin
            // 
            this.dtFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFin.Location = new System.Drawing.Point(734, 406);
            this.dtFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(325, 24);
            this.dtFin.TabIndex = 10;
            this.dtFin.Visible = false;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(600, 358);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(113, 24);
            this.lblFechaIni.TabIndex = 11;
            this.lblFechaIni.Text = "Fecha Inicio";
            this.lblFechaIni.Visible = false;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(600, 406);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(96, 24);
            this.lblFechaFin.TabIndex = 12;
            this.lblFechaFin.Text = "Fecha Fin";
            this.lblFechaFin.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(615, 358);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(615, 360);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(90, 24);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.Visible = false;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.LightBlue;
            this.MenuVertical.Controls.Add(this.cbArticulos);
            this.MenuVertical.Controls.Add(this.cbPrestamos);
            this.MenuVertical.Controls.Add(this.btnPrestamo);
            this.MenuVertical.Controls.Add(this.picBox);
            this.MenuVertical.Controls.Add(this.btnArticulo);
            this.MenuVertical.Controls.Add(this.btnCategoria);
            this.MenuVertical.Location = new System.Drawing.Point(-7, -1);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(331, 872);
            this.MenuVertical.TabIndex = 15;
            // 
            // cbArticulos
            // 
            this.cbArticulos.BackColor = System.Drawing.SystemColors.Window;
            this.cbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArticulos.FormattingEnabled = true;
            this.cbArticulos.Items.AddRange(new object[] {
            "Ingresar Artículo"});
            this.cbArticulos.Location = new System.Drawing.Point(57, 401);
            this.cbArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Size = new System.Drawing.Size(225, 32);
            this.cbArticulos.TabIndex = 18;
            this.cbArticulos.SelectedIndexChanged += new System.EventHandler(this.cbArticulos_SelectedIndexChanged);
            // 
            // cbPrestamos
            // 
            this.cbPrestamos.BackColor = System.Drawing.SystemColors.Window;
            this.cbPrestamos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrestamos.FormattingEnabled = true;
            this.cbPrestamos.Items.AddRange(new object[] {
            "Ingresar Préstamo",
            "Ver Préstamos Activos",
            "Ver Préstamos",
            "Ver Contribuciones"});
            this.cbPrestamos.Location = new System.Drawing.Point(55, 707);
            this.cbPrestamos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrestamos.Name = "cbPrestamos";
            this.cbPrestamos.Size = new System.Drawing.Size(225, 32);
            this.cbPrestamos.TabIndex = 19;
            this.cbPrestamos.SelectedIndexChanged += new System.EventHandler(this.cbPrestamos_SelectedIndexChanged);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrestamo.BackColor = System.Drawing.Color.Teal;
            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrestamo.Location = new System.Drawing.Point(55, 598);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(227, 103);
            this.btnPrestamo.TabIndex = 17;
            this.btnPrestamo.Text = "Préstamo de Equipo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // picBox
            // 
            this.picBox.Image = global::UI.Properties.Resources.asoc;
            this.picBox.Location = new System.Drawing.Point(36, 33);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(268, 220);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.LightBlue;
            this.PanelTitulo.Controls.Add(this.lblInventario);
            this.PanelTitulo.Location = new System.Drawing.Point(323, -1);
            this.PanelTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1051, 87);
            this.PanelTitulo.TabIndex = 16;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Teal;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(876, 659);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(183, 56);
            this.btnCerrarSesion.TabIndex = 17;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.BackColor = System.Drawing.Color.Teal;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfig.Location = new System.Drawing.Point(582, 644);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(183, 86);
            this.btnConfig.TabIndex = 18;
            this.btnConfig.Text = "Configuración Cuenta";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1239, 870);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbFiltros);
            this.Controls.Add(this.lblFil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio del sistema";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label lblFil;
        private System.Windows.Forms.ComboBox cbFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ComboBox cbArticulos;
        private System.Windows.Forms.ComboBox cbPrestamos;
        private System.Windows.Forms.Button btnConfig;
    }
}

