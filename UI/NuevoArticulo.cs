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
        }

        public void llenarComboBox()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                ManejadorArticulo manejArt = new ManejadorArticulo();
            BLArticulo artNuevo = new BLArticulo(txtPlaca.Text, txtNombre.Text, Convert.ToDateTime(datePickerIngreso.Text), txtDescripcion.Text, txtEstado.Text, comboCategoria.SelectedIndex + 1);
            manejArt.agregarArticulo(artNuevo);
        }
    }
}
