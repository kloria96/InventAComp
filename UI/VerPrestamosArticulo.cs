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
    public partial class VerPrestamosArticulo : Form
    {
        public static int idArticulo;
        public static bool activo = false;

        public VerPrestamosArticulo()
        {
            InitializeComponent();
            gridPrestamos.AutoGenerateColumns = false;
            activo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            if (manejArt.existeArticuloPlaca(txtPlaca.Text))
            {
                BLArticulo articulo = manejArt.buscarArticuloPlaca(txtPlaca.Text);
                idArticulo = articulo.idArticulo;
                txtNombre.Text = articulo.nombArticulo;
                txtDescripcion.Text = articulo.descripcArticulo;
                txtCategoria.Text = articulo.nombCategoria;
                btnBuscarPrestamos.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe el artículo");
                txtPlaca.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCategoria.Clear();
            }
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            BusquedaArticulo busqueda = new BusquedaArticulo();
            busqueda.Owner = this;
            busqueda.ShowDialog();
        }

        public void modificarCampos()
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            BLArticulo articulo = manejArt.obtenerArticuloBusqueda(idArticulo);
            txtPlaca.Text = articulo.numeroPlaca;
            txtNombre.Text = articulo.nombArticulo;
            txtDescripcion.Text = articulo.descripcArticulo;
            txtCategoria.Text = articulo.nombCategoria;
            btnBuscarPrestamos.Enabled = true;
        }

        private void mostrarPrestamos(List<BLPrestamo> listaPrestamos)
        {
            ManejadorPrestamo manej = new ManejadorPrestamo();
            if (gridPrestamos.DataSource != null)
            {
                gridPrestamos.DataSource = null;
                gridPrestamos.Rows.Clear();
            }

            if (listaPrestamos.Count != 0)
            {
                lblAdvertencia.Visible = false;
                gridPrestamos.ColumnCount = 6;

                gridPrestamos.Columns[0].Name = "ID";
                gridPrestamos.Columns[0].HeaderText = "ID";
                gridPrestamos.Columns[0].DataPropertyName = "idPrestamo";
                gridPrestamos.Columns[0].Visible = false;

                gridPrestamos.Columns[1].Name = "Número contrato";
                gridPrestamos.Columns[1].HeaderText = "Número contrato";
                gridPrestamos.Columns[1].DataPropertyName = "numeroContrato";

                gridPrestamos.Columns[2].Name = "Paciente";
                gridPrestamos.Columns[2].HeaderText = "Paciente";
                gridPrestamos.Columns[2].DataPropertyName = "paciente";

                gridPrestamos.Columns[3].Name = "Responsable";
                gridPrestamos.Columns[3].HeaderText = "Responsable";
                gridPrestamos.Columns[3].DataPropertyName = "responsable";

                gridPrestamos.Columns[4].Name = "Fecha préstamo";
                gridPrestamos.Columns[4].HeaderText = "Fecha";
                gridPrestamos.Columns[4].DataPropertyName = "fechaPrestamo";

                gridPrestamos.Columns[5].Name = "Fecha entrega";
                gridPrestamos.Columns[5].HeaderText = "Fecha entrega";
                gridPrestamos.Columns[5].DataPropertyName = "fechaEntrega";

                gridPrestamos.DataSource = listaPrestamos;
            } else
            {
                lblAdvertencia.Visible = true;
            }
        }

        private void btnBuscarPrestamos_Click(object sender, EventArgs e)
        {
            ManejadorPrestamo manejPrest = new ManejadorPrestamo();
            List<BLPrestamo> listaPrestamos = manejPrest.prestamosArticulo(idArticulo);
            mostrarPrestamos(listaPrestamos);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
