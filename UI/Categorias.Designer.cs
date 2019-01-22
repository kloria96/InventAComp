namespace UI
{
    partial class Categorias
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
            this.lblCategorias = new System.Windows.Forms.Label();
            this.gridCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(241, 32);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(117, 25);
            this.lblCategorias.TabIndex = 0;
            this.lblCategorias.Text = "Categorías";
            // 
            // gridCategorias
            // 
            this.gridCategorias.AllowUserToAddRows = false;
            this.gridCategorias.AllowUserToDeleteRows = false;
            this.gridCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Location = new System.Drawing.Point(113, 90);
            this.gridCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.ReadOnly = true;
            this.gridCategorias.RowTemplate.Height = 24;
            this.gridCategorias.Size = new System.Drawing.Size(366, 170);
            this.gridCategorias.TabIndex = 1;
            this.gridCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategorias_CellClick);
            this.gridCategorias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridCategorias_CellFormatting);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(336, 295);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 33);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Nueva Categoría";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(159, 302);
            this.txtNuevaCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(138, 20);
            this.txtNuevaCategoria.TabIndex = 3;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(459, 359);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(88, 29);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 418);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.DataGridView gridCategorias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
        private System.Windows.Forms.Button btnAtras;
    }
}