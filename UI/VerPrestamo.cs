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

        public VerPrestamo()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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
    }
}
