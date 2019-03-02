namespace UI
{
    partial class VerPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPrestamo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 71);
            this.panel1.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(353, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Datos del Préstamo";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(623, 174);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(164, 22);
            this.txtFechaEntrega.TabIndex = 25;
            this.txtFechaEntrega.TabStop = false;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(250, 172);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(203, 22);
            this.txtPaciente.TabIndex = 4;
            this.txtPaciente.TabStop = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(623, 109);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(164, 22);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.TabStop = false;
            // 
            // txtContrato
            // 
            this.txtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.Location = new System.Drawing.Point(250, 108);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.ReadOnly = true;
            this.txtContrato.Size = new System.Drawing.Size(203, 22);
            this.txtContrato.TabIndex = 2;
            this.txtContrato.TabStop = false;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(501, 177);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(102, 18);
            this.lblFechaEntrega.TabIndex = 21;
            this.lblFechaEntrega.Text = "Fecha entrega";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(102, 177);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(65, 18);
            this.lblPaciente.TabIndex = 20;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(501, 109);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 18);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha préstamo";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(103, 109);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(141, 18);
            this.lblContrato.TabIndex = 18;
            this.lblContrato.Text = "Número de contrato";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.Location = new System.Drawing.Point(250, 241);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(203, 22);
            this.txtResponsable.TabIndex = 6;
            this.txtResponsable.TabStop = false;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(103, 242);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(95, 18);
            this.lblResponsable.TabIndex = 26;
            this.lblResponsable.Text = "Responsable";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Teal;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(662, 310);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(107, 46);
            this.btnAtras.TabIndex = 28;
            this.btnAtras.TabStop = false;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // VerPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 401);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Préstamo";
            this.Load += new System.EventHandler(this.VerPrestamo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Button btnAtras;
    }
}