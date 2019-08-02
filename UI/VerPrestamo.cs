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
    public partial class VerPrestamo : Form
    {
        public static string idPrestamo = "";

        /// <summary>
        /// Método para inicializar los componentes de la página actual
        /// </summary>
        public VerPrestamo()
        {
            InitializeComponent();
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
        /// Evento para completar los datos del formulario según los datos del préstamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerPrestamo_Load(object sender, EventArgs e)
        {
            ManejadorPrestamo manejPrest = new ManejadorPrestamo();
            BLPrestamo prestamo = manejPrest.obtenerPrestamo(Convert.ToInt32(idPrestamo));
            txtContrato.Text = prestamo.numeroContrato;
            txtPaciente.Text = prestamo.paciente;
            txtResponsable.Text = prestamo.responsable;
            txtFecha.Text = prestamo.fechaPrestamo.ToString("dd/MM/yyyy");
            txtFechaEntrega.Text = prestamo.fechaEntrega.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Evento que abre la ventana de "Ver Artículo" para ver detalladamente los datos del artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            ManejadorPrestamo manejPrest = new ManejadorPrestamo();
            VerArticulo.idArticulo = manejPrest.articuloEnPrestamo(Convert.ToInt32(idPrestamo)) + "";
            new VerArticulo().ShowDialog();
        }

    }
}
