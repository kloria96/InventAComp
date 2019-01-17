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
    public partial class ModificarArticulo : Form
    {
        private string idArticulo = "";

        public ModificarArticulo()
        {
            InitializeComponent();
            cargarDatosArticulo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            int idA = Convert.ToInt32(idArticulo);
            string nombre = txtNombre.Text;
            string numeroPlaca = txtPlaca.Text;
            string descripcion = txtDescripcion.Text;
            string estado = txtEstado.Text;
            string categoria = comboCategoria.SelectedItem.ToString();
            if (manejArt.actualizarArticulo(idA, numeroPlaca, nombre, descripcion, estado, categoria))
            {
                MessageBox.Show("Se han actualizado los datos del artículo");
            } else
            {
                MessageBox.Show("No se ha podido actualizar el artículo");
            }
        }

        private void cargarDatosArticulo()
        {
            idArticulo = MostrarArticulos.idArt;
            ManejadorArticulo manejArt = new ManejadorArticulo();
            BLArticulo articulo = manejArt.obtenerArticulo(Convert.ToInt32(idArticulo));

            txtPlaca.Text = articulo.numeroPlaca;
            txtNombre.Text = articulo.nombArticulo;
            txtDescripcion.Text = articulo.descripcArticulo;
            txtEstado.Text = articulo.estadoArticulo;

        }

        private void cargarCategorias()
        {
            ManejadorCategoria manejCart = new ManejadorCategoria();
            List<BLCategoria> listaCategorias = manejCart.consultarCategorias();

        }

    }
}
