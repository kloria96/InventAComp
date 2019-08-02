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
    public partial class PrestarArticulo : Form
    {
        public static int idArticulo;

        /// <summary>
        /// Método para inicializar los componentes de la página actual
        /// </summary>
        public PrestarArticulo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para buscar un artículo y completar los campos del formulario
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
                button2.Enabled = true;
            } else
            {
                MessageBox.Show("No existe el artículo");
                txtPlaca.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCategoria.Clear();
                button2.Enabled = false;
            }
        }

        /// <summary>
        /// Evento para la creación de un préstamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContrato.Text != "")
            {
                ManejadorArticulo manejArt = new ManejadorArticulo();
                if (manejArt.articuloEnPrestamo(idArticulo))
                {
                    MessageBox.Show("El artículo se encuentra actualmente en préstamo");
                    limpiarCampos();
                    return;
                }

                ManejadorPrestamo manejPrest = new ManejadorPrestamo();
                string contrato = txtContrato.Text;
                string paciente = txtPaciente.Text;
                string responsable = txtResponsable.Text;
                DateTime fechaPrestamo = Convert.ToDateTime(dtPrestamo.Text);
                DateTime fechaEntrega = Convert.ToDateTime(dtEntrega.Text);
                BLPrestamo nuevoPrest = new BLPrestamo(contrato, paciente, responsable, fechaPrestamo, fechaEntrega, idArticulo);
                if (manejPrest.agregarPrestamo(nuevoPrest))
                {
                    this.Dispose();
                    MessageBox.Show("Se ha guardado el préstamo");
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar el préstamo. Intente de nuevo");
                }
            } else
            {
                MessageBox.Show("Complete todos los datos");
            }
        }

        /// <summary>
        /// Método para completar los datos del formulario de acuerdo al resultado de la búsqueda
        /// </summary>
        public void modificarCampos()
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            BLArticulo articulo = manejArt.obtenerArticuloBusqueda(idArticulo);
            txtPlaca.Text = articulo.numeroPlaca;
            txtNombre.Text = articulo.nombArticulo;
            txtDescripcion.Text = articulo.descripcArticulo;
            txtCategoria.Text = articulo.nombCategoria;
            button2.Enabled = true;
        }

        /// <summary>
        /// Método para eliminar los campos del formulario
        /// </summary>
        private void limpiarCampos()
        {
            txtPlaca.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
        }

        /// <summary>
        /// Evento del botón "Atrás" para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
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

        private void PrestarArticulo_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Evento del botón "Guardar" para el almacenamiento de un nuevo préstamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtContrato.Text != "")
            {
                ManejadorArticulo manejArt = new ManejadorArticulo();
                if (manejArt.articuloEnPrestamo(idArticulo))
                {
                    MessageBox.Show("El artículo se encuentra actualmente en préstamo");
                    limpiarCampos();
                    return;
                }

                ManejadorPrestamo manejPrest = new ManejadorPrestamo();
                string contrato = txtContrato.Text;
                string paciente = txtPaciente.Text;
                string responsable = txtResponsable.Text;
                DateTime fechaPrestamo = Convert.ToDateTime(dtPrestamo.Text);
                DateTime fechaEntrega = Convert.ToDateTime(dtEntrega.Text);
                BLPrestamo nuevoPrest = new BLPrestamo(contrato, paciente, responsable, fechaPrestamo, fechaEntrega, idArticulo);
                if (manejPrest.agregarPrestamo(nuevoPrest))
                {
                    this.Dispose();
                    MessageBox.Show("Se ha guardado el préstamo");
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar el préstamo. Intente de nuevo");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los datos");
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = !string.IsNullOrEmpty(txtPlaca.Text);
        }
    }
}
