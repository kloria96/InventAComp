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
            this.Dispose();
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

            if (dgvArticulos.Rows.Count == 0)
            {
                lblBusqueda.Visible = true;
                btnReporte.Visible = false;
            }
        }

        private void mostrarArticulos(List<BLArticulo> listaArticulos)
        {
            if (listaArticulos.Count != 0)
            {
                dgvArticulos.ColumnCount = 8;
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
                dgvArticulos.Columns[2].Visible = false;

                dgvArticulos.Columns[3].Name = "Descripción";
                dgvArticulos.Columns[3].HeaderText = "Descripción";
                dgvArticulos.Columns[3].DataPropertyName = "descripcArticulo";
                dgvArticulos.Columns[3].Visible = false;

                dgvArticulos.Columns[4].Name = "Estado";
                dgvArticulos.Columns[4].HeaderText = "Estado";
                dgvArticulos.Columns[4].DataPropertyName = "estadoArticulo";

                dgvArticulos.Columns[5].Name = "Ubicación";
                dgvArticulos.Columns[5].HeaderText = "Ubicación";
                dgvArticulos.Columns[5].DataPropertyName = "ubicacionArticulo";

                dgvArticulos.Columns[6].Name = "Categoría";
                dgvArticulos.Columns[6].HeaderText = "Categoría";
                dgvArticulos.Columns[6].DataPropertyName = "nombCategoria";

                dgvArticulos.Columns[7].Name = "ID";
                dgvArticulos.Columns[7].HeaderText = "ID";
                dgvArticulos.Columns[7].DataPropertyName = "idArticulo";
                dgvArticulos.Columns[7].Visible = false;

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                dgvArticulos.Columns.Add(button);

                DataGridViewButtonColumn but = new DataGridViewButtonColumn();
                dgvArticulos.Columns.Add(but);

                DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
                dgvArticulos.Columns.Add(but2);

                dgvArticulos.DataSource = listaArticulos;
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                VerArticulo.idArticulo = dgvArticulos.Rows[e.RowIndex].Cells[7].Value + "";
                new VerArticulo().Show();
            }

            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                idArt = dgvArticulos.Rows[e.RowIndex].Cells[7].Value + "";
                ModificarArticulo.categoriaArticulo = dgvArticulos.Rows[e.RowIndex].Cells[6].Value + "";
                ModificarArticulo.estadoArticulo = dgvArticulos.Rows[e.RowIndex].Cells[4].Value + "";

                ModificarArticulo modArt = new ModificarArticulo();
                modArt.Owner = this;
                modArt.ShowDialog();
            }

            if (e.ColumnIndex == 10 && e.RowIndex != -1)
            {
                eliminarFila(Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells[7].Value));
                this.Dispose();
            }
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvArticulos.Rows[e.RowIndex].Cells[8].Value = "Ver";
            dgvArticulos.Rows[e.RowIndex].Cells[9].Value = "Modificar";
            dgvArticulos.Rows[e.RowIndex].Cells[10].Value = "Eliminar";
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteArticulos reporte = new ReporteArticulos();

            for (int i = 0; i < dgvArticulos.Rows.Count; i++)
            {
                BLArticulo articulo = new BLArticulo();
                articulo.numeroPlaca = (string)dgvArticulos.Rows[i].Cells[0].Value;
                articulo.nombArticulo = (string)dgvArticulos.Rows[i].Cells[1].Value;
                articulo.estadoArticulo = (string)dgvArticulos.Rows[i].Cells[4].Value;
                articulo.ubicacionArticulo = (string)dgvArticulos.Rows[i].Cells[5].Value;
                articulo.nombCategoria = (string)dgvArticulos.Rows[i].Cells[6].Value;
                reporte.listaReporte.Add(articulo);
            }
            reporte.ShowDialog();
        }

        private void mostrarReporteEjemplo()
        {
            ReporteArticulos reporte = new ReporteArticulos();
            BLArticulo art1 = new BLArticulo();
            art1.numeroPlaca = "H81273";
            art1.nombArticulo = "Manual de conductor";
            art1.estadoArticulo = "Bueno";
            art1.ubicacionArticulo = "Departamento";
            art1.nombCategoria = "General";
            reporte.listaReporte.Add(art1);

            BLArticulo art2 = new BLArticulo();
            art2.numeroPlaca = "881205";
            art2.nombArticulo = "Borrador";
            art2.estadoArticulo = "Malo";
            art2.ubicacionArticulo = "Bodegas";
            art2.nombCategoria = "Nutrición";
            reporte.listaReporte.Add(art2);

            BLArticulo art3 = new BLArticulo();
            art3.numeroPlaca = "94014";
            art3.nombArticulo = "Sacapuntas";
            art3.estadoArticulo = "Bueno";
            art3.ubicacionArticulo = "Departamento";
            art3.nombCategoria = "Administración";
            reporte.listaReporte.Add(art3);

            reporte.ShowDialog();
        }

    }
}
