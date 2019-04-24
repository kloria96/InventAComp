namespace UI
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.gridPrestamos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrestamos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPrestamos
            // 
            this.gridPrestamos.AllowUserToAddRows = false;
            this.gridPrestamos.AllowUserToDeleteRows = false;
            this.gridPrestamos.AllowUserToOrderColumns = true;
            this.gridPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrestamos.Location = new System.Drawing.Point(68, 108);
            this.gridPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridPrestamos.Name = "gridPrestamos";
            this.gridPrestamos.ReadOnly = true;
            this.gridPrestamos.RowTemplate.Height = 24;
            this.gridPrestamos.Size = new System.Drawing.Size(1099, 446);
            this.gridPrestamos.TabIndex = 9;
            this.gridPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArticulos_CellClick);
            this.gridPrestamos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridArticulos_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblPrestamo);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 87);
            this.panel1.TabIndex = 8;
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.Location = new System.Drawing.Point(487, 31);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(242, 29);
            this.lblPrestamo.TabIndex = 0;
            this.lblPrestamo.Text = "Préstamos Activos";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.BackColor = System.Drawing.Color.Teal;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(925, 580);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(143, 57);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Teal;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReporte.Location = new System.Drawing.Point(516, 580);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(187, 57);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "Crear Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 662);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridPrestamos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos Activos";
            ((System.ComponentModel.ISupportInitialize)(this.gridPrestamos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPrestamos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnReporte;
    }
}