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
    public partial class FormularioPrestamo : Form
    {
        public static string idArticulo = "";
        public static string nombreArticulo = "";

        /// <summary>
        /// Método que inicializa los componentes de la página actual
        /// </summary>
        public FormularioPrestamo()
        {
            InitializeComponent();
            lblArticulo.Text = nombreArticulo;
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

        /// <summary>
        /// Evento del botón "Guardar" para la creación de un nuevo préstamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ManejadorPrestamo manejPrest = new ManejadorPrestamo();
            string contrato = txtContrato.Text;
            string paciente = txtPaciente.Text;
            string responsable = txtResponsable.Text;
            DateTime fechaPrestamo = Convert.ToDateTime(dtPrestamo.Text);
            DateTime fechaEntrega = Convert.ToDateTime(dtEntrega.Text);
            string telefono = txtTel.Text;
            BLPrestamo nuevoPrest = new BLPrestamo(contrato, paciente, responsable, fechaPrestamo, fechaEntrega, Convert.ToInt32(idArticulo), telefono);
            if (manejPrest.agregarPrestamo(nuevoPrest))
            {
                this.Owner.Dispose();
                this.Dispose();
                MessageBox.Show("Se ha guardado el préstamo");
                new PrestamoEquipo().Show();
            } else
            {
                MessageBox.Show("No se ha podido guardar el préstamo. Intente de nuevo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioPrestamo_Load(object sender, EventArgs e)
        {
            label1.Text = "Bzx456";
        }
    }
}
