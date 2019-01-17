using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;


namespace UI
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();

            cargarGrid();
        }

        public void cargarGrid()
        {
            ManejadorCategoria manej = new ManejadorCategoria();

            List<BLCategoria> listaCategorias = new List<BLCategoria>();
            listaCategorias = manej.consultarCategorias();
            if (listaCategorias.Count != 0)
            {
                dataGridView1.ColumnCount = 2;

                dataGridView1.Columns[0].Name = "Categoría";
                dataGridView1.Columns[0].HeaderText = "Categoría";
                dataGridView1.Columns[0].DataPropertyName = "nombreCategoria";

                dataGridView1.Columns[1].Name = "ID";
                dataGridView1.Columns[1].HeaderText = "ID";
                dataGridView1.Columns[1].DataPropertyName = "idCategoria";
                dataGridView1.Columns[1].Visible = false;

            }

            dataGridView1.DataSource = listaCategorias;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ManejadorCategoria manej = new ManejadorCategoria();
            manej.agregarCategoria(txtNuevaCategoria.Text);
            dataGridView1.DataSource = manej.consultarCategorias();

            }
    }
}
