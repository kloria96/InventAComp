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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
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
            this.lblCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(300, 21);
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
            this.gridCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategorias.Location = new System.Drawing.Point(144, 88);
            this.gridCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.ReadOnly = true;
            this.gridCategorias.RowTemplate.Height = 24;
            this.gridCategorias.Size = new System.Drawing.Size(416, 170);
            this.gridCategorias.TabIndex = 1;
            this.gridCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategorias_CellClick);
            this.gridCategorias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridCategorias_CellFormatting);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(407, 303);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Nueva Categoría";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaCategoria.Location = new System.Drawing.Point(182, 311);
            this.txtNuevaCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(180, 22);
            this.txtNuevaCategoria.TabIndex = 3;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(450, 380);
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
            this.ClientSize = new System.Drawing.Size(687, 463);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";
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