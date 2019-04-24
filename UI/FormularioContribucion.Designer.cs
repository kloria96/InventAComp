namespace UI
{
    partial class FormularioContribucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioContribucion));
            this.lblCuota = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.lblRecibo = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(140, 284);
            this.lblCuota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(193, 24);
            this.lblCuota.TabIndex = 25;
            this.lblCuota.Text = "Cuota                        ₡";
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Location = new System.Drawing.Point(348, 362);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(383, 29);
            this.dtFecha.TabIndex = 3;
            // 
            // txtCuota
            // 
            this.txtCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuota.Location = new System.Drawing.Point(348, 284);
            this.txtCuota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(240, 29);
            this.txtCuota.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(140, 362);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 24);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha";
            // 
            // txtRecibo
            // 
            this.txtRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibo.Location = new System.Drawing.Point(348, 215);
            this.txtRecibo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(240, 29);
            this.txtRecibo.TabIndex = 1;
            // 
            // lblRecibo
            // 
            this.lblRecibo.AutoSize = true;
            this.lblRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibo.Location = new System.Drawing.Point(140, 215);
            this.lblRecibo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(164, 24);
            this.lblRecibo.TabIndex = 18;
            this.lblRecibo.Text = "Número de recibo";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(412, 146);
            this.lblContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(0, 25);
            this.lblContrato.TabIndex = 17;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(260, 38);
            this.lblAgregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(217, 25);
            this.lblAgregar.TabIndex = 16;
            this.lblAgregar.Text = "Agregar Contribución";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(206, 459);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 49);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Teal;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(478, 459);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(136, 49);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.Location = new System.Drawing.Point(264, 146);
            this.lblPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(110, 25);
            this.lblPrestamo.TabIndex = 28;
            this.lblPrestamo.Text = "Préstamo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblAgregar);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 100);
            this.panel1.TabIndex = 29;
            // 
            // FormularioContribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtRecibo);
            this.Controls.Add(this.lblRecibo);
            this.Controls.Add(this.lblContrato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioContribucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Contribución";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.Label lblRecibo;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Panel panel1;
    }
}