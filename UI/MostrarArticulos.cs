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
    public partial class MostrarArticulos : Form
    {
        private string value = ""; //Nombre del articulo, departamento o fecha de inicio
        private string fechaFin = "";
        private string opcion = ""; //1: Nombre, 2: Departamento, 3: Fecha de ingreso
        public static string idArt = "";
        private ManejadorArticulo manejArt = new ManejadorArticulo();

        public MostrarArticulos()
        {
            InitializeComponent();
            dgvArticulos.AutoGenerateColumns = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarArticulos_Load(object sender, EventArgs e)
        {
            opcion = Principal.opcion;
            value = Principal.value;

            switch (opcion)
            {
                case "1":
                    mostrarArticulos(manejArt.obtenerArticulosNombre(value));
                    break;
                case "2":
                    mostrarArticulos(manejArt.obtenerArticulosCategoria(value));
                    break;
                case "3":
                    fechaFin = Principal.fechaFin;
                    mostrarArticulos(manejArt.obtenerArticulosFecha(value, fechaFin));
                    break;
            }
        }

        private void mostrarArticulos(List<BLArticulo> listaArticulos)
        {
            if (listaArticulos.Count != 0)
            {
                dgvArticulos.ColumnCount = 7;
                dgvArticulos.Columns[0].Name = "Número placa";
                dgvArticulos.Columns[0].HeaderText = "Número placa";
                dgvArticulos.Columns[0].DataPropertyName = "numeroPlaca"; // DataPropertyName debe coincidir con el nombre de los atributos del
                                                                     // objeto (en la clase)
                dgvArticulos.Columns[1].Name = "Nombre";
                dgvArticulos.Columns[1].HeaderText = "Nombre";
                dgvArticulos.Columns[1].DataPropertyName = "nombArticulo";

                dgvArticulos.Columns[2].Name = "Fecha ingreso";
                dgvArticulos.Columns[2].HeaderText = "Fecha ingreso";
                dgvArticulos.Columns[2].DataPropertyName = "fechaIngreso";

                dgvArticulos.Columns[3].Name = "Descripción";
                dgvArticulos.Columns[3].HeaderText = "Descripción";
                dgvArticulos.Columns[3].DataPropertyName = "descripcArticulo";

                dgvArticulos.Columns[4].Name = "Estado";
                dgvArticulos.Columns[4].HeaderText = "Estado";
                dgvArticulos.Columns[4].DataPropertyName = "estadoArticulo";

                dgvArticulos.Columns[5].Name = "Categoría";
                dgvArticulos.Columns[5].HeaderText = "Categoría";
                dgvArticulos.Columns[5].DataPropertyName = "nombCategoria";

                dgvArticulos.Columns[6].Name = "ID";
                dgvArticulos.Columns[6].HeaderText = "ID";
                dgvArticulos.Columns[6].DataPropertyName = "idArticulo";
                dgvArticulos.Columns[6].Visible = false;

                DataGridViewButtonColumn but = new DataGridViewButtonColumn();
                dgvArticulos.Columns.Add(but);

                DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
                dgvArticulos.Columns.Add(but2);

                dgvArticulos.DataSource = listaArticulos;
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                idArt = dgvArticulos.Rows[e.RowIndex].Cells[6].Value + "";
                ModificarArticulo.categoriaArticulo = dgvArticulos.Rows[e.RowIndex].Cells[5].Value + "";
                ModificarArticulo.estadoArticulo = dgvArticulos.Rows[e.RowIndex].Cells[4].Value + "";
                new ModificarArticulo().Show();
            }

            if (e.ColumnIndex == 8)
            {
                eliminarFila(Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells[6].Value));
            }
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvArticulos.Rows[e.RowIndex].Cells[7].Value = "Modificar";
            dgvArticulos.Rows[e.RowIndex].Cells[8].Value = "Eliminar";
        }

        private void eliminarFila(int idArticulo)
        {
            var confirmResult = MessageBox.Show("¿Desea eliminar el artículo?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (manejArt.eliminarArticulo(idArticulo)) {
                    MostrarArticulos mosArt = new MostrarArticulos();
                    this.Dispose();
                    mosArt.Show();
                } else
                {
                    MessageBox.Show("No se ha podido eliminar el artículo");
                }
                
            }
        }

    }
}
