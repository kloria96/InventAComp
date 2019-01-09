using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;


namespace UI
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
            cargarGrid();
        }

        public void cargarGrid()
        {
            ManejadorCategoria manej = new ManejadorCategoria();
            dataGridView1.DataSource = manej.consultarCategorias();
        }
    }
}
