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
    public partial class Articulos : Form
    {
        public static string idArt = "";

        /// <summary>
        /// Método que llama al método para mostrar el grid con los artículos actuales y muestra el resto de componentes
        /// de la página actual
        /// </summary>
        public Articulos()
        {
            InitializeComponent();
            gridArticulos.AutoGenerateColumns = false;
            cargarGrid();
        }

        /// <summary>
        /// Evento que muestra la ventana de agregar un nuevo artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoArticulo art = new NuevoArticulo();
            art.Owner = this;
            art.MdiParent = this.MdiParent;
            art.ShowDialog();
            this.Dispose();
        }

        /// <summary>
        /// Método para agregar los artículos y sus características en el grid de la página actual
        /// </summary>
        private void cargarGrid()
        {
            ManejadorArticulo manej = new ManejadorArticulo();
            List<BLArticulo> listaBL = new List<BLArticulo>();
            listaBL = manej.consultarArticulos();
            if (listaBL.Count != 0)
            {
                gridArticulos.ColumnCount = 8;

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

                gridArticulos.Columns[3].Name = "Fecha ingreso";
                gridArticulos.Columns[3].HeaderText = "Fecha ingreso";
                gridArticulos.Columns[3].DataPropertyName = "fechaIngreso";
                gridArticulos.Columns[3].Visible = false;

                gridArticulos.Columns[4].Name = "Descripción";
                gridArticulos.Columns[4].HeaderText = "Descripción";
                gridArticulos.Columns[4].DataPropertyName = "descripcArticulo";
                gridArticulos.Columns[4].Visible = false;

                gridArticulos.Columns[5].Name = "Estado";
                gridArticulos.Columns[5].HeaderText = "Estado";
                gridArticulos.Columns[5].DataPropertyName = "estadoArticulo";

                gridArticulos.Columns[6].Name = "Ubicación";
                gridArticulos.Columns[6].HeaderText = "Ubicación";
                gridArticulos.Columns[6].DataPropertyName = "ubicacionArticulo";

                gridArticulos.Columns[7].Name = "Categoría";
                gridArticulos.Columns[7].HeaderText = "Categoría";
                gridArticulos.Columns[7].DataPropertyName = "nombCategoria";

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(button);

                DataGridViewButtonColumn but = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(but);

                DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(but2);

                string role = Manager.getManager().rol;
                if (role == "Secretaria")
                {
                    gridArticulos.DataSource = listaBL;
                } else
                {
                    List<BLArticulo> listaCategoria = new List<BLArticulo>();
                    foreach (BLArticulo art in listaBL)
                    {
                        if (art.nombCategoria == role)
                        {
                            listaCategoria.Add(art);
                        }
                    }
                    gridArticulos.DataSource = listaCategoria;
                }
            }
        }

        /// <summary>
        /// Evento para abrir la página de "Ver" o "Modificar" un artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                VerArticulo.idArticulo = gridArticulos.Rows[e.RowIndex].Cells[0].Value + "";
                new VerArticulo().Show();
                this.Dispose();
            }

            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                idArt = gridArticulos.Rows[e.RowIndex].Cells[0].Value + "";
                ModificarArticulo.categoriaArticulo = gridArticulos.Rows[e.RowIndex].Cells[7].Value + "";
                ModificarArticulo.estadoArticulo = gridArticulos.Rows[e.RowIndex].Cells[5].Value + "";

                //ModificarArticulo modArt = new ModificarArticulo();
                //modArt.Owner = this;

                //modArt.ShowDialog();
                new ModificarArticulo().Show();
                this.Dispose();

            }

            if (e.ColumnIndex == 10 && e.RowIndex != -1)
            {
                eliminarFila(Convert.ToInt32(gridArticulos.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        /// <summary>
        /// Método para cambiar el nombre de los botones del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridArticulos.Rows[e.RowIndex].Cells[8].Value = "Ver";
            gridArticulos.Rows[e.RowIndex].Cells[9].Value = "Modificar";
            gridArticulos.Rows[e.RowIndex].Cells[10].Value = "Eliminar";
        }

        /// <summary>
        /// Método para eliminar un artículo
        /// </summary>
        /// <param name="idArticulo">Identificador del artículo que se desea eliminar</param>
        private void eliminarFila(int idArticulo)
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            var confirmResult = MessageBox.Show("¿Desea eliminar el artículo?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (manejArt.eliminarArticulo(idArticulo))
                {
                    this.Dispose();
                    if (this.GetType().ToString() == "BL.Articulos")
                    {
                        new MostrarArticulos().Show();
                    }
                    else
                    {
                        new Articulos().Show();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el artículo");
                }

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
            new Principal().Show();
        }

        /// <summary>
        /// Método para mostrar el reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteArticulos reporte = new ReporteArticulos();

            for (int i = 0; i < gridArticulos.Rows.Count; i++)
            {
                BLArticulo articulo = new BLArticulo();
                articulo.numeroPlaca = (string)gridArticulos.Rows[i].Cells[1].Value;
                articulo.nombArticulo = (string)gridArticulos.Rows[i].Cells[2].Value;
                articulo.estadoArticulo = (string)gridArticulos.Rows[i].Cells[5].Value;
                articulo.ubicacionArticulo = (string)gridArticulos.Rows[i].Cells[6].Value;
                articulo.nombCategoria = (string)gridArticulos.Rows[i].Cells[7].Value;
                reporte.listaReporte.Add(articulo);
            }
            reporte.ShowDialog();
        }

    }
}
