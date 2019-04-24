namespace UI
{
    partial class CuotasDonacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuotasDonacion));
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblPrestar = new System.Windows.Forms.Label();
            this.gridCuotas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(367, 70);
            this.lblContrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(0, 25);
            this.lblContrato.TabIndex = 3;
            // 
            // lblPrestar
            // 
            this.lblPrestar.AutoSize = true;
            this.lblPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestar.Location = new System.Drawing.Point(48, 43);
            this.lblPrestar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestar.Name = "lblPrestar";
            this.lblPrestar.Size = new System.Drawing.Size(261, 25);
            this.lblPrestar.TabIndex = 2;
            this.lblPrestar.Text = "Contribuciones Préstamo:";
            // 
            // gridCuotas
            // 
            this.gridCuotas.AllowUserToAddRows = false;
            this.gridCuotas.AllowUserToDeleteRows = false;
            this.gridCuotas.AllowUserToOrderColumns = true;
            this.gridCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuotas.Location = new System.Drawing.Point(77, 139);
            this.gridCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCuotas.Name = "gridCuotas";
            this.gridCuotas.ReadOnly = true;
            this.gridCuotas.RowTemplate.Height = 24;
            this.gridCuotas.Size = new System.Drawing.Size(516, 386);
            this.gridCuotas.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(77, 565);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(281, 53);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar Contribución";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Teal;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(453, 568);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(136, 49);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblPrestar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 96);
            this.panel1.TabIndex = 16;
            // 
            // CuotasDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridCuotas);
            this.Controls.Add(this.lblContrato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuotasDonacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contribuciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Label lblPrestar;
        private System.Windows.Forms.DataGridView gridCuotas;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
    }
}