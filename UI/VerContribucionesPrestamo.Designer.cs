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
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblContribuciones = new System.Windows.Forms.Label();
            this.gridContribuciones = new System.Windows.Forms.DataGridView();
            this.btnBuscarPrestamos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblDatosPrestamo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridContribuciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(548, 247);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(230, 16);
            this.lblAdvertencia.TabIndex = 70;
            this.lblAdvertencia.Text = "No se han encontrado contribuciones";
            this.lblAdvertencia.Visible = false;
            // 
            // btnBuscarContribuciones
            // 
            this.btnBuscarContribuciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarContribuciones.Enabled = false;
            this.btnBuscarContribuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarContribuciones.Location = new System.Drawing.Point(572, 91);
            this.btnBuscarContribuciones.Name = "btnBuscarContribuciones";
            this.btnBuscarContribuciones.Size = new System.Drawing.Size(186, 35);
            this.btnBuscarContribuciones.TabIndex = 69;
            this.btnBuscarContribuciones.Text = "Buscar Contribuciones";
            this.btnBuscarContribuciones.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(417, 451);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(84, 31);
            this.btnAtras.TabIndex = 68;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblContribuciones
            // 
            this.lblContribuciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContribuciones.AutoSize = true;
            this.lblContribuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContribuciones.Location = new System.Drawing.Point(603, 164);
            this.lblContribuciones.Name = "lblContribuciones";
            this.lblContribuciones.Size = new System.Drawing.Size(122, 18);
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
            this.gridContribuciones.Location = new System.Drawing.Point(463, 202);
            this.gridContribuciones.Name = "gridContribuciones";
            this.gridContribuciones.ReadOnly = true;
            this.gridContribuciones.Size = new System.Drawing.Size(399, 168);
            this.gridContribuciones.TabIndex = 66;
            // 
            // btnBuscarPrestamos
            // 
            this.btnBuscarPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrestamos.Location = new System.Drawing.Point(147, 408);
            this.btnBuscarPrestamos.Name = "btnBuscarPrestamos";
            this.btnBuscarPrestamos.Size = new System.Drawing.Size(138, 27);
            this.btnBuscarPrestamos.TabIndex = 65;
            this.btnBuscarPrestamos.TabStop = false;
            this.btnBuscarPrestamos.Text = "Buscar Préstamo...";
            this.btnBuscarPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(293, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(183, 304);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(168, 22);
            this.txtFecha.TabIndex = 63;
            this.txtFecha.TabStop = false;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(183, 248);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(169, 22);
            this.txtResponsable.TabIndex = 60;
            this.txtResponsable.TabStop = false;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.Location = new System.Drawing.Point(47, 305);
            this.lblFechaPrestamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(49, 18);
            this.lblFechaPrestamo.TabIndex = 62;
            this.lblFechaPrestamo.Text = "Fecha";
            // 
            // lblResponsable
            // 
            this.lblResponsable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(47, 248);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(95, 18);
            this.lblResponsable.TabIndex = 61;
            this.lblResponsable.Text = "Responsable";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(184, 191);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(168, 22);
            this.txtPaciente.TabIndex = 57;
            this.txtPaciente.TabStop = false;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(108, 137);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(169, 22);
            this.txtPlaca.TabIndex = 55;
            // 
            // lblPaciente
            // 
            this.lblPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(47, 192);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(65, 18);
            this.lblPaciente.TabIndex = 59;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblContrato
            // 
            this.lblContrato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(37, 142);
            this.lblContrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(66, 18);
            this.lblContrato.TabIndex = 58;
            this.lblContrato.Text = "Contrato";
            // 
            // lblDatosPrestamo
            // 
            this.lblDatosPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatosPrestamo.AutoSize = true;
            this.lblDatosPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPrestamo.Location = new System.Drawing.Point(119, 91);
            this.lblDatosPrestamo.Name = "lblDatosPrestamo";
            this.lblDatosPrestamo.Size = new System.Drawing.Size(158, 18);
            this.lblDatosPrestamo.TabIndex = 56;
            this.lblDatosPrestamo.Text = "Datos del Préstamo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(254, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(398, 24);
            this.lblTitulo.TabIndex = 54;
            this.lblTitulo.Text = "Contribuciones Realizadas a un Préstamo";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(183, 357);
            this.txtFechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(169, 22);
            this.txtFechaEntrega.TabIndex = 71;
            this.txtFechaEntrega.TabStop = false;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(47, 357);
            this.lblFechaEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(102, 18);
            this.lblFechaEntrega.TabIndex = 72;
            this.lblFechaEntrega.Text = "Fecha entrega";
            // 
            // VerContribucionesPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 515);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnBuscarContribuciones);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblContribuciones);
            this.Controls.Add(this.gridContribuciones);
            this.Controls.Add(this.btnBuscarPrestamos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.lblDatosPrestamo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerContribucionesPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Contribuciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridContribuciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button btnBuscarContribuciones;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblContribuciones;
        private System.Windows.Forms.DataGridView gridContribuciones;
        private System.Windows.Forms.Button btnBuscarPrestamos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblDatosPrestamo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
    }
}