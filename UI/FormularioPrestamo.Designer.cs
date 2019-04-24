namespace UI
{
    partial class FormularioPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrestamo));
            this.lblPrestar = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.dtEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrestar
            // 
            this.lblPrestar.AutoSize = true;
            this.lblPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestar.Location = new System.Drawing.Point(112, 44);
            this.lblPrestar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestar.Name = "lblPrestar";
            this.lblPrestar.Size = new System.Drawing.Size(167, 25);
            this.lblPrestar.TabIndex = 0;
            this.lblPrestar.Text = "Prestar Artículo:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(361, 73);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(0, 25);
            this.lblArticulo.TabIndex = 1;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(91, 164);
            this.lblContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(178, 24);
            this.lblContrato.TabIndex = 2;
            this.lblContrato.Text = "Número de contrato";
            // 
            // txtContrato
            // 
            this.txtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.Location = new System.Drawing.Point(299, 164);
            this.txtContrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(283, 29);
            this.txtContrato.TabIndex = 2;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(299, 233);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(283, 29);
            this.txtPaciente.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(91, 373);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(174, 24);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de préstamo";
            // 
            // dtPrestamo
            // 
            this.dtPrestamo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPrestamo.Location = new System.Drawing.Point(299, 373);
            this.dtPrestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPrestamo.Name = "dtPrestamo";
            this.dtPrestamo.Size = new System.Drawing.Size(383, 29);
            this.dtPrestamo.TabIndex = 5;
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrega.Location = new System.Drawing.Point(91, 443);
            this.lblEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(160, 24);
            this.lblEntrega.TabIndex = 7;
            this.lblEntrega.Text = "Fecha de entrega";
            // 
            // dtEntrega
            // 
            this.dtEntrega.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEntrega.Location = new System.Drawing.Point(299, 443);
            this.dtEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.Size = new System.Drawing.Size(383, 29);
            this.dtEntrega.TabIndex = 6;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(91, 233);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(83, 24);
            this.lblPaciente.TabIndex = 9;
            this.lblPaciente.Text = "Paciente";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Teal;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(441, 543);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(136, 49);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(169, 543);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 49);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(91, 300);
            this.lblResponsable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(121, 24);
            this.lblResponsable.TabIndex = 15;
            this.lblResponsable.Text = "Responsable";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(299, 300);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(283, 29);
            this.txtResponsable.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblPrestar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 100);
            this.panel1.TabIndex = 16;
            // 
            // FormularioPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.dtEntrega);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.dtPrestamo);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.lblArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Préstamo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrestar;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtPrestamo;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.DateTimePicker dtEntrega;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Panel panel1;
    }
}