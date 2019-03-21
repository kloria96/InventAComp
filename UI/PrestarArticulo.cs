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

        public PrestarArticulo()
        {
            InitializeComponent();
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
                btnGuardar.Enabled = true;
            } else
            {
                MessageBox.Show("No existe el artículo");
                txtPlaca.Clear();
                btnBuscarArticulo.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContrato.Text != "")
            {
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            new BusquedaArticulo().ShowDialog();
            //Después de llamar a este método (después de seleccionar el artículo en BusquedaArticulo, hacer una consulta
            //a la BD para cargar los datos del artículo con ese ID (se selecciona en BusquedaArticulo)
        }
    }
}
