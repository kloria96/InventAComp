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
    public partial class VerArticulo : Form
    {
        public static string idArticulo = "";

        /// <summary>
        /// Método para inicializar los componentes de la página actual
        /// </summary>
        public VerArticulo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para cargar los datos del artículo en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerArticulo_Load(object sender, EventArgs e)
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            BLArticulo articulo = manejArt.obtenerArticuloCategoria(Convert.ToInt32(idArticulo));

            txtPlaca.Text = articulo.numeroPlaca;
            txtNombre.Text = articulo.nombArticulo;
            txtIngreso.Text = articulo.fechaIngreso.ToString("dd/MM/yyyy");
            txtEstado.Text = articulo.estadoArticulo;
            txtDescripcion.Text = articulo.descripcArticulo;
            txtCategoria.Text = articulo.nombCategoria;
            txtUbicacion.Text = articulo.ubicacionArticulo;
            chb_jps.Checked = articulo.propiedad_JPS;
            cbPrestamo.Checked = articulo.prestado;
        }

        /// <summary>
        /// Evento del botón "Atrás" para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
