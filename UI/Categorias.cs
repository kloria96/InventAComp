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
        public static string idCat = "";
        private string nombreCat = "";

        /// <summary>
        /// Muestra las categorías almacenadas en la base de datos, muestra los componentes de la página actual
        /// </summary>
        public Categorias()
        {
            InitializeComponent();
            gridCategorias.AutoGenerateColumns = false;
            cargarGrid();
        }

        /// <summary>
        /// Carga el grid con las categorías que se encuentren en la base de datos
        /// </summary>
        public void cargarGrid()
        {
            ManejadorCategoria manej = new ManejadorCategoria();

            List<BLCategoria> listaCategorias = new List<BLCategoria>();
            listaCategorias = manej.consultarCategorias();
            if (listaCategorias.Count != 0)
            {
                gridCategorias.ColumnCount = 2;

                gridCategorias.Columns[0].Name = "Categoría";
                gridCategorias.Columns[0].HeaderText = "Categoría";
                gridCategorias.Columns[0].DataPropertyName = "nombreCategoria";

                gridCategorias.Columns[1].Name = "ID";
                gridCategorias.Columns[1].HeaderText = "ID";
                gridCategorias.Columns[1].DataPropertyName = "idCategoria";
                gridCategorias.Columns[1].Visible = false;

                DataGridViewButtonColumn but = new DataGridViewButtonColumn();
                gridCategorias.Columns.Add(but);

                DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
                gridCategorias.Columns.Add(but2);
            }
            gridCategorias.DataSource = listaCategorias;
        }

        /// <summary>
        /// Evento utilizado para almacenar una nueva categoría
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNuevaCategoria.Text != "")
            {
                ManejadorCategoria manej = new ManejadorCategoria();
                if (manej.verificarCategoria(txtNuevaCategoria.Text))
                {
                    manej.agregarCategoria(txtNuevaCategoria.Text);
                    txtNuevaCategoria.Clear();
                    MessageBox.Show("Se ha agregado la categoría");
                    gridCategorias.DataSource = manej.consultarCategorias();
                } else
                {
                    MessageBox.Show("Ya existe la categoría", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Ingrese el nombre de la nueva categoría");
            }
        }

        /// <summary>
        /// Evento para nombrar los botones de las filas del grid "Modificar" y "Eliminar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridCategorias.Rows[e.RowIndex].Cells[2].Value = "Modificar";
            gridCategorias.Rows[e.RowIndex].Cells[3].Value = "Eliminar";
        }

        /// <summary>
        /// Método utilizado para modificar o eliminar una categoría seleccionada del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                idCat = gridCategorias.Rows[e.RowIndex].Cells[1].Value + "";
                nombreCat = gridCategorias.Rows[e.RowIndex].Cells[0].Value + "";
                if (actualizarFila(Convert.ToInt32(idCat))) {
                    ManejadorCategoria manej = new ManejadorCategoria();
                    gridCategorias.DataSource = manej.consultarCategorias();
                    MessageBox.Show("Se ha actualizado la categoría");
                } else
                {
                    MessageBox.Show("No se ha podido actualizar la categoría");
                }
            }

            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                eliminarFila(Convert.ToInt32(gridCategorias.Rows[e.RowIndex].Cells[1].Value));
            }
        }

        /// <summary>
        /// Método llamado para eliminar una categoría que se seleccionó del grid
        /// </summary>
        /// <param name="idCategoria">Identificador de la categoría que se desea eliminar</param>
        private void eliminarFila(int idCategoria)
        {
            ManejadorCategoria manejCat = new ManejadorCategoria();
            var confirmResult = MessageBox.Show("¿Desea eliminar la categoría?\nLos artículos dentro de esta categoría serán eliminados.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                if (manejCat.eliminarCategoria(idCategoria))
                {
                    this.Dispose();
                    new Categorias().Show();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar la categoría");
                }
            }
        }

        /// <summary>
        /// Método utilizado para actualizar una categoría
        /// </summary>
        /// <param name="idCat">Identificador de la categoría que se actualiza</param>
        /// <returns>Retorna True si se realizó la actualización de la categoría correctamente</returns>
        public bool actualizarFila(int idCat)
        {
            ModificarCategoria testDialog = new ModificarCategoria();
            testDialog.txtNombre.Text = nombreCat;
            // Mostrar testDialog como modal y determinar si DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Leer el contenido del TextBox de testDialog.
                this.nombreCat = testDialog.txtNombre.Text;
                ManejadorCategoria manejCat = new ManejadorCategoria();
                testDialog.Dispose();
                return manejCat.actualizarCategoria(idCat, nombreCat);
            }
            else
            {
                testDialog.Dispose();
                return false;
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
            //new Principal().Show();
        }

    }
}
