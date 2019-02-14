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

        public FormularioPrestamo()
        {
            InitializeComponent();
            lblArticulo.Text = nombreArticulo;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ManejadorPrestamo manejPrest = new ManejadorPrestamo();
            string contrato = txtContrato.Text;
            string paciente = txtPaciente.Text;
            string responsable = txtResponsable.Text;
            DateTime fechaPrestamo = Convert.ToDateTime(dtPrestamo.Text);
            DateTime fechaEntrega = Convert.ToDateTime(dtEntrega.Text);
            BLPrestamo nuevoPrest = new BLPrestamo(contrato, paciente, responsable, fechaPrestamo, fechaEntrega, Convert.ToInt32(idArticulo));
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
    }
}
