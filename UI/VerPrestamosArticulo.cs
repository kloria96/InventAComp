﻿using System;
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

        /// <summary>
        /// Método para inicializar los componentes de la página actual
        /// </summary>
        public VerPrestamosArticulo()
        {
            InitializeComponent();
            gridPrestamos.AutoGenerateColumns = false;
            activo = true;
        }

        /// <summary>
        /// Evento para buscar un artículo de acuerdo a su placa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("No existe un artículo bajo ese número de placa");
                txtPlaca.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCategoria.Clear();
            }
        }

        /// <summary>
        /// Evento para buscar un artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            BusquedaArticulo busqueda = new BusquedaArticulo();
            busqueda.Owner = this;
            busqueda.ShowDialog();
        }

        /// <summary>
        /// Método para completar los datos del formulario de acuerdo a la búsqueda realizada
        /// </summary>
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

        /// <summary>
        /// Método para completar el grid con la lista de préstamos de un artículo
        /// </summary>
        /// <param name="listaPrestamos">Lista del histórico de préstamos de un artículo</param>
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

        /// <summary>
        /// Evento para mostrar el histórico de préstamos de un artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarPrestamos_Click(object sender, EventArgs e)
        {
            ManejadorPrestamo manejPrest = new ManejadorPrestamo();
            List<BLPrestamo> listaPrestamos = manejPrest.prestamosArticulo(idArticulo);
            mostrarPrestamos(listaPrestamos);
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
        /// Evento para activar o desactivar el botón de buscar de acuerdo a un campo de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = !string.IsNullOrEmpty(txtPlaca.Text);
        }
    }
}
