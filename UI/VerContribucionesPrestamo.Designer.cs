namespace UI
{
    partial class VerContribucionesPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerContribucionesPrestamo));
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnBuscarContribuciones = new System.Windows.Forms.Button();
            this.lblContribuciones = new System.Windows.Forms.Label();
            this.gridContribuciones = new System.Windows.Forms.DataGridView();
            this.btnBuscarPrestamos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblDatosPrestamo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridContribuciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(731, 310);
            this.lblAdvertencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(287, 20);
            this.lblAdvertencia.TabIndex = 70;
            this.lblAdvertencia.Text = "No se han encontrado contribuciones";
            this.lblAdvertencia.Visible = false;
            // 
            // btnBuscarContribuciones
            // 
            this.btnBuscarContribuciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarContribuciones.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarContribuciones.Enabled = false;
            this.btnBuscarContribuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarContribuciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarContribuciones.Location = new System.Drawing.Point(763, 140);
            this.btnBuscarContribuciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarContribuciones.Name = "btnBuscarContribuciones";
            this.btnBuscarContribuciones.Size = new System.Drawing.Size(279, 57);
            this.btnBuscarContribuciones.TabIndex = 69;
            this.btnBuscarContribuciones.Text = "Buscar Contribuciones";
            this.btnBuscarContribuciones.UseVisualStyleBackColor = false;
            this.btnBuscarContribuciones.Click += new System.EventHandler(this.btnBuscarContribuciones_Click);
            // 
            // lblContribuciones
            // 
            this.lblContribuciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContribuciones.AutoSize = true;
            this.lblContribuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContribuciones.Location = new System.Drawing.Point(804, 244);
            this.lblContribuciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContribuciones.Name = "lblContribuciones";
            this.lblContribuciones.Size = new System.Drawing.Size(151, 24);
            this.lblContribuciones.TabIndex = 67;
            this.lblContribuciones.Text = "Contribuciones";
            // 
            // gridContribuciones
            // 
            this.gridContribuciones.AllowUserToAddRows = false;
            this.gridContribuciones.AllowUserToDeleteRows = false;
            this.gridContribuciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridContribuciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContribuciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridContribuciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContribuciones.Location = new System.Drawing.Point(617, 291);
            this.gridContribuciones.Margin = new System.Windows.Forms.Padding(4);
            this.gridContribuciones.Name = "gridContribuciones";
            this.gridContribuciones.ReadOnly = true;
            this.gridContribuciones.Size = new System.Drawing.Size(532, 207);
            this.gridContribuciones.TabIndex = 66;
            // 
            // btnBuscarPrestamos
            // 
            this.btnBuscarPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPrestamos.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrestamos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarPrestamos.Location = new System.Drawing.Point(230, 637);
            this.btnBuscarPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPrestamos.Name = "btnBuscarPrestamos";
            this.btnBuscarPrestamos.Size = new System.Drawing.Size(227, 52);
            this.btnBuscarPrestamos.TabIndex = 65;
            this.btnBuscarPrestamos.TabStop = false;
            this.btnBuscarPrestamos.Text = "Buscar Préstamo...";
            this.btnBuscarPrestamos.UseVisualStyleBackColor = false;
            this.btnBuscarPrestamos.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(391, 199);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 46);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(244, 416);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(224, 26);
            this.txtFecha.TabIndex = 63;
            this.txtFecha.TabStop = false;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(244, 347);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(224, 26);
            this.txtResponsable.TabIndex = 60;
            this.txtResponsable.TabStop = false;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.Location = new System.Drawing.Point(63, 417);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(64, 24);
            this.lblFechaPrestamo.TabIndex = 62;
            this.lblFechaPrestamo.Text = "Fecha";
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(63, 347);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(121, 24);
            this.lblResponsable.TabIndex = 61;
            this.lblResponsable.Text = "Responsable";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(245, 277);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(224, 26);
            this.txtPaciente.TabIndex = 57;
            this.txtPaciente.TabStop = false;
            // 
            // txtContrato
            // 
            this.txtContrato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.Location = new System.Drawing.Point(144, 211);
            this.txtContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(224, 26);
            this.txtContrato.TabIndex = 55;
            this.txtContrato.TextChanged += new System.EventHandler(this.txtContrato_TextChanged);
            // 
            // lblPaciente
            // 
            this.lblPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(63, 278);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(83, 24);
            this.lblPaciente.TabIndex = 59;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblContrato
            // 
            this.lblContrato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(49, 217);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(80, 24);
            this.lblContrato.TabIndex = 58;
            this.lblContrato.Text = "Contrato";
            // 
            // lblDatosPrestamo
            // 
            this.lblDatosPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatosPrestamo.AutoSize = true;
            this.lblDatosPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPrestamo.Location = new System.Drawing.Point(159, 154);
            this.lblDatosPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosPrestamo.Name = "lblDatosPrestamo";
            this.lblDatosPrestamo.Size = new System.Drawing.Size(190, 24);
            this.lblDatosPrestamo.TabIndex = 56;
            this.lblDatosPrestamo.Text = "Datos del Préstamo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(349, 38);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(499, 29);
            this.lblTitulo.TabIndex = 54;
            this.lblTitulo.Text = "Contribuciones Realizadas a un Préstamo";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(244, 481);
            this.txtFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(224, 26);
            this.txtFechaEntrega.TabIndex = 71;
            this.txtFechaEntrega.TabStop = false;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(63, 481);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(133, 24);
            this.lblFechaEntrega.TabIndex = 72;
            this.lblFechaEntrega.Text = "Fecha entrega";
            // 
            // cbActivo
            // 
            this.cbActivo.AutoCheck = false;
            this.cbActivo.AutoSize = true;
            this.cbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivo.Location = new System.Drawing.Point(67, 616);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(4);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(83, 28);
            this.cbActivo.TabIndex = 73;
            this.cbActivo.TabStop = false;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            this.cbActivo.CheckedChanged += new System.EventHandler(this.cbActivo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 100);
            this.panel1.TabIndex = 74;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(654, 637);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 75;
            this.button1.TabStop = false;
            this.button1.Text = "Atrás";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTel.Location = new System.Drawing.Point(63, 548);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(85, 24);
            this.lblTel.TabIndex = 76;
            this.lblTel.Text = "Teléfono";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTel.Location = new System.Drawing.Point(244, 549);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(224, 26);
            this.txtTel.TabIndex = 77;
            this.txtTel.TabStop = false;
            // 
            // VerContribucionesPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 707);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnBuscarContribuciones);
            this.Controls.Add(this.lblContribuciones);
            this.Controls.Add(this.gridContribuciones);
            this.Controls.Add(this.btnBuscarPrestamos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.lblDatosPrestamo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerContribucionesPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Contribuciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridContribuciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button btnBuscarContribuciones;
        private System.Windows.Forms.Label lblContribuciones;
        private System.Windows.Forms.DataGridView gridContribuciones;
        private System.Windows.Forms.Button btnBuscarPrestamos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblDatosPrestamo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
    }
}