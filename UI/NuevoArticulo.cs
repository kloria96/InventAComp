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
        public NuevoArticulo()
        {
            InitializeComponent();
            llenarComboBox();
            cargarEstados();
        }

        private void llenarComboBox()
        {
            ManejadorCategoria manejCat = new ManejadorCategoria();
            DataTable tabla = manejCat.consultarCategoriasOrdenId();

            string comboBoxNombre;
            foreach (DataRow fila in tabla.Rows)
            {
                comboBoxNombre = fila["nombre"].ToString();
                comboCategoria.Items.Add(comboBoxNombre);
            }
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

            foreach (String estado in listaEstados)
            {
                comboEstados.Items.Add(estado);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboEstados.SelectedItem != null && comboCategoria.SelectedItem != null)
            {
                ManejadorArticulo manejArt = new ManejadorArticulo();
                BLArticulo artNuevo = new BLArticulo(txtPlaca.Text, txtNombre.Text, Convert.ToDateTime(datePickerIngreso.Text), txtDescripcion.Text, comboEstados.SelectedItem.ToString(), txtUbicacion.Text, chb_jps.Checked, comboCategoria.SelectedIndex + 1);
                
                if (manejArt.agregarArticulo(artNuevo))
                {
                    this.Owner.Dispose();
                    this.Dispose();
                    MessageBox.Show("Se ha agregado el artículo");
                    new Articulos().Show();
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
