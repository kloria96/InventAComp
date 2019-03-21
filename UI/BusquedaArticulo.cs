using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace UI
{
    public partial class BusquedaArticulo : Form
    {
        public BusquedaArticulo()
        {
            InitializeComponent();
            gridArticulos.AutoGenerateColumns = false;
            cargarGrid();
        }

        private void cargarGrid()
        {
            ManejadorArticulo manej = new ManejadorArticulo();
            List<BLArticulo> listaBL = new List<BLArticulo>();
            listaBL = manej.consultarArticulos();
            if (listaBL.Count != 0)
            {
                gridArticulos.ColumnCount = 6;

                gridArticulos.Columns[0].Name = "ID";
                gridArticulos.Columns[0].HeaderText = "ID";
                gridArticulos.Columns[0].DataPropertyName = "idArticulo";
                gridArticulos.Columns[0].Visible = false;

                gridArticulos.Columns[1].Name = "Número placa";
                gridArticulos.Columns[1].HeaderText = "Número placa";
                gridArticulos.Columns[1].DataPropertyName = "numeroPlaca";

                gridArticulos.Columns[2].Name = "Nombre";
                gridArticulos.Columns[2].HeaderText = "Nombre";
                gridArticulos.Columns[2].DataPropertyName = "nombArticulo";

                gridArticulos.Columns[3].Name = "Estado";
                gridArticulos.Columns[3].HeaderText = "Estado";
                gridArticulos.Columns[3].DataPropertyName = "estadoArticulo";

                gridArticulos.Columns[4].Name = "Ubicación";
                gridArticulos.Columns[4].HeaderText = "Ubicación";
                gridArticulos.Columns[4].DataPropertyName = "ubicacionArticulo";

                gridArticulos.Columns[5].Name = "Categoría";
                gridArticulos.Columns[5].HeaderText = "Categoría";
                gridArticulos.Columns[5].DataPropertyName = "nombCategoria";

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();

                gridArticulos.DataSource = listaBL;
            }
        }

        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                PrestarArticulo.idArticulo = Convert.ToInt32(gridArticulos.Rows[e.RowIndex].Cells[0].Value);
                this.Dispose();
            }
        }

        private void gridArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridArticulos.Rows[e.RowIndex].Cells[6].Value = "Seleccionar";
        }

        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltros.SelectedItem.ToString() == "")
            {
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblCategoria.Visible = false;
                cbCategorias.Visible = false;
            }
            if (cbFiltros.SelectedItem.ToString() == "Nombre")
            {
                lblCategoria.Visible = false;
                cbCategorias.Visible = false;

                lblNombre.Visible = true;
                txtNombre.Visible = true;
            }
            if (cbFiltros.SelectedItem.ToString() == "Categoría")
            {
                cbCategorias.Items.Clear();
                lblNombre.Visible = false;
                txtNombre.Visible = false;

                lblCategoria.Visible = true;
                cbCategorias.Visible = true;

                cargarDepartamentos();
            }
        }

        private void cargarDepartamentos()
        {
            ManejadorCategoria manejCat = new ManejadorCategoria();
            foreach (BLCategoria categoria in manejCat.consultarCategorias())
            {
                cbCategorias.Items.Add(categoria.nombreCategoria);
            }

        }

    }
}
