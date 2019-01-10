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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
            cargarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoArticulo art = new NuevoArticulo();
            art.MdiParent = this.MdiParent;
            art.Show();
        }

        public void cargarGrid()
        {
            ManejadorArticulo manej = new ManejadorArticulo();
            gridArticulos.DataSource = manej.consultarArticulos();
        }
    }
}
