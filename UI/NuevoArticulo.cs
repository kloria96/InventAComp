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
    public partial class NuevoArticulo : Form
    {
        /// <summary>
        /// Método para inicializar los componentes de la página actual, además de cargar datos por defecto
        /// </summary>
        public NuevoArticulo()
        {
            InitializeComponent();
            llenarComboBox();
            cargarEstados();
        }

        /// <summary>
        /// Método para llenar el comboBox de las categorías
        /// </summary>
        private void llenarComboBox()
        {
            string rol = Manager.getManager().rol;
            if (rol == "Secretaria")
            {
                ManejadorCategoria manejCat = new ManejadorCategoria();
                DataTable tabla = manejCat.consultarCategoriasOrdenId();

                string comboBoxNombre;
                foreach (DataRow fila in tabla.Rows)
                {
                    comboBoxNombre = fila["nombre"].ToString();
                    comboCategoria.Items.Add(comboBoxNombre);
                }
            } else
            {
                comboCategoria.Items.Add(rol);
                comboCategoria.SelectedIndex = 0;
                comboCategoria.Enabled = false;
            }
        }

        /// <summary>
        /// Método para cargar el comboBox de los estados posibles de los artículos
        /// </summary>
        private void cargarEstados()
        {
            List<String> listaEstados = new List<String>();
            listaEstados.Add("Bueno");
            listaEstados.Add("Regular");
            listaEstados.Add("Malo");
            listaEstados.Add("Eliminado");
            listaEstados.Add("Donado");
            listaEstados.Add("Otros");

            foreach (String estado in listaEstados)
            {
                comboEstados.Items.Add(estado);
            }
        }
        
        /// <summary>
        /// Evento para guardar un nuevo artículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboEstados.SelectedItem != null && comboCategoria.SelectedItem != null)
            {
                ManejadorArticulo manejArt = new ManejadorArticulo();
                ManejadorCategoria manejCat = new ManejadorCategoria();
                int idCateg = manejCat.obtenerIDCategoria(comboCategoria.SelectedItem.ToString());
                BLArticulo artNuevo = new BLArticulo(txtPlaca.Text, txtNombre.Text, Convert.ToDateTime(datePickerIngreso.Text), txtDescripcion.Text, comboEstados.SelectedItem.ToString(), txtUbicacion.Text, chb_jps.Checked, idCateg);
                
                if (manejArt.agregarArticulo(artNuevo))
                {
                    if (this.Owner != null)
                    {
                        this.Owner.Dispose();
                        this.Dispose();
                        MessageBox.Show("Se ha agregado el artículo");
                        new Articulos().Show();
                    } else
                    {
                        this.Dispose();
                        MessageBox.Show("Se ha agregado el artículo");
                    }
                } else
                {
                    MessageBox.Show("No se ha podido ingresar el artículo");
                }
            } else
            {
                if (comboEstados.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione el estado del artículo");
                }
                if (comboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una categoría");
                }
            }
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
