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

        public Categorias()
        {
            InitializeComponent();
            gridCategorias.AutoGenerateColumns = false;
            cargarGrid();
        }

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

        private void gridCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridCategorias.Rows[e.RowIndex].Cells[2].Value = "Modificar";
            gridCategorias.Rows[e.RowIndex].Cells[3].Value = "Eliminar";
        }

        private void gridCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
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

            if (e.ColumnIndex == 3)
            {
                if (Convert.ToString(gridCategorias.Rows[e.RowIndex].Cells[0].Value) == "Préstamo")
                {
                    MessageBox.Show("No se puede eliminar esta categoría");
                } else
                {
                    eliminarFila(Convert.ToInt32(gridCategorias.Rows[e.RowIndex].Cells[1].Value));
                }
            }
        }

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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //new Principal().Show();
        }

    }
}
