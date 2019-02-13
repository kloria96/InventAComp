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

        public VerArticulo()
        {
            InitializeComponent();
        }

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
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
