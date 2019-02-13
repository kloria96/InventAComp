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
        public static string categoriaArticulo = "";
        public static string estadoArticulo = "";

        public ModificarArticulo()
        {
            InitializeComponent();
            cargarDatosArticulo();
            cargarCategorias();
            cargarEstados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ManejadorArticulo manejArt = new ManejadorArticulo();
            int idA = Convert.ToInt32(idArticulo);
            string nombre = txtNombre.Text;
            string numeroPlaca = txtPlaca.Text;
            string descripcion = txtDescripcion.Text;
            string estado = comboEstados.SelectedItem.ToString();
            string ubicacion = txtUbicacion.Text;
            bool propiedad_jps = chb_jps.Checked;
            string categoria = comboCategoria.SelectedItem.ToString();
            if (manejArt.actualizarArticulo(idA, numeroPlaca, nombre, descripcion, estado, ubicacion, propiedad_jps, categoria))
            {
                this.Owner.Dispose();
                this.Dispose();
                MessageBox.Show("Se han actualizado los datos del artículo");
                new Articulos().Show();
            } else
            {
                MessageBox.Show("No se ha podido actualizar el artículo");
                this.Dispose();
            }
        }

        private void cargarDatosArticulo()
        {
            if (MostrarArticulos.idArt != "")
            {
                idArticulo = MostrarArticulos.idArt;
                MostrarArticulos.idArt = "";
            } else
            {
                idArticulo = Articulos.idArt;
                Articulos.idArt = "";
            }

            ManejadorArticulo manejArt = new ManejadorArticulo();
            BLArticulo articulo = manejArt.obtenerArticulo(Convert.ToInt32(idArticulo));

            txtPlaca.Text = articulo.numeroPlaca;
            txtNombre.Text = articulo.nombArticulo;
            txtIngreso.Text = articulo.fechaIngreso.ToString("dd/MM/yyyy");
            txtDescripcion.Text = articulo.descripcArticulo;
            txtUbicacion.Text = articulo.ubicacionArticulo;
            chb_jps.Checked = articulo.propiedad_JPS;
            
        }

        private void cargarCategorias()
        {
            ManejadorCategoria manejCart = new ManejadorCategoria();
            List<BLCategoria> listaCategorias = manejCart.consultarCategorias(categoriaArticulo);
            comboCategoria.Items.Add(categoriaArticulo);
            foreach (BLCategoria categoria in listaCategorias)
            {
                comboCategoria.Items.Add(categoria.nombreCategoria);
            }
            comboCategoria.SelectedIndex = 0;
        }

        private void cargarEstados()
        {
            List<String> listaEstados = new List<String>();
            listaEstados.Add("Bueno");
            listaEstados.Add("Regular");
            listaEstados.Add("Malo");
            listaEstados.Add("Eliminado");
            listaEstados.Add("Donado");
            listaEstados.Add("Otros");
            comboEstados.Items.Add(estadoArticulo);
            foreach (String estado in listaEstados)
            {
                if (estado != estadoArticulo)
                {
                    comboEstados.Items.Add(estado);
                }
            }
            comboEstados.SelectedIndex = 0;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
