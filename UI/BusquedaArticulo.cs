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
        public static int opcion = 0;

        /// <summary>
        /// Método para mostrar los componentes de la página actual
        /// </summary>
        public BusquedaArticulo()
        {
            InitializeComponent();
            gridArticulos.AutoGenerateColumns = false;
            //cargarGrid();
            cbFiltros.SelectedIndex = 0;
        }

        //No usado
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
                gridArticulos.Columns.Add(button);

                gridArticulos.DataSource = listaBL;
            }
        }

        /// <summary>
        /// Método para mostrar la lista de los artículos en el grid
        /// </summary>
        /// <param name="listaArticulos">Lista de artículos para mostrar en el grid</param>
        private void mostrarArticulos(List<BLArticulo> listaArticulos)
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            if (gridArticulos.DataSource != null)
            {
                gridArticulos.DataSource = null;
                gridArticulos.Rows.Clear();
            }

            if (listaArticulos.Count != 0)
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
                gridArticulos.Columns.Add(button);

                gridArticulos.DataSource = listaArticulos;
            }
        }

        /// <summary>
        /// Evento para ver los préstamos activos o para prestar un artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6 && e.RowIndex != -1)
                {
                    if (VerPrestamosArticulo.activo)
                    {
                        VerPrestamosArticulo.idArticulo = Convert.ToInt32(gridArticulos.Rows[e.RowIndex].Cells[0].Value);
                        VerPrestamosArticulo formPrestamos = (VerPrestamosArticulo)this.Owner;
                        formPrestamos.modificarCampos();
                        this.Dispose();
                    }
                    else
                    {
                        PrestarArticulo.idArticulo = Convert.ToInt32(gridArticulos.Rows[e.RowIndex].Cells[0].Value);
                        PrestarArticulo form = (PrestarArticulo)this.Owner;
                        form.modificarCampos();
                        this.Dispose();
                    }
                }
            } catch (Exception exe)
            {
                MessageBox.Show("Hubo un error. Por favor regrese a la página principal e inténtelo de nuevo");
            }
        }

        /// <summary>
        /// Evento para asignar el nombre "Seleccionar" a las filas del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridArticulos.Rows[e.RowIndex].Cells[6].Value = "Seleccionar";
        }

        /// <summary>
        /// Evento que coloca el nombre de los filtros que se pueden realizar, además de guardar la opción que se selecciona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltros.SelectedItem.ToString() == "")
            {
                txtNombre.Visible = false;
                cbCategorias.Visible = false;
            }
            if (cbFiltros.SelectedItem.ToString() == "Nombre")
            {
                cbCategorias.Visible = false;

                txtNombre.Visible = true;
                opcion = 1;
            }
            if (cbFiltros.SelectedItem.ToString() == "Categoría")
            {
                cbCategorias.Items.Clear();
                txtNombre.Visible = false;

                cbCategorias.Visible = true;

                cargarDepartamentos();
                opcion = 2;
            }
        }

        /// <summary>
        /// Método para recargar en la página las diferentes categorías que se encuentran en la base de datos
        /// </summary>
        private void cargarDepartamentos()
        {
            ManejadorCategoria manejCat = new ManejadorCategoria();
            foreach (BLCategoria categoria in manejCat.consultarCategorias())
            {
                cbCategorias.Items.Add(categoria.nombreCategoria);
            }

        }

        /// <summary>
        /// Evento para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //    ManejadorArticulo manejArt = new ManejadorArticulo();
            //    List<BLArticulo> listaBL = new List<BLArticulo>();
            //    switch (opcion)
            //    {
            //        case 0:

            //            break;
            //        case 1:
            //            listaBL = manejArt.obtenerArticulosNombre(txtNombre.Text);
            //            mostrarArticulos(listaBL);
            //            break;
            //        case 2:
            //            if (cbCategorias.SelectedItem == null)
            //            {
            //                MessageBox.Show("Seleccione una categoría");
            //            } else
            //            {
            //                listaBL = manejArt.obtenerArticulosCategoria(cbCategorias.SelectedItem.ToString());
            //                mostrarArticulos(listaBL);
            //            }
            //            break;
            //}
        }

        /// <summary>
        /// Evento para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Evento del botón "Buscar Artículo"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            List<BLArticulo> listaBL = new List<BLArticulo>();
            switch (opcion)
            {
                case 0:

                    break;
                case 1:
                    listaBL = manejArt.obtenerArticulosNombre(txtNombre.Text);
                    mostrarArticulos(listaBL);
                    break;
                case 2:
                    if (cbCategorias.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione una categoría");
                    }
                    else
                    {
                        listaBL = manejArt.obtenerArticulosCategoria(cbCategorias.SelectedItem.ToString());
                        mostrarArticulos(listaBL);
                    }
                    break;
            }
        }
    }
}
