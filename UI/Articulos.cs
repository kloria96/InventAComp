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
            gridArticulos.AutoGenerateColumns = false;
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
            List<BLArticulo> listaBL = new List<BLArticulo>();
            listaBL = manej.consultarArticulos();
            if(listaBL.Count != 0)
            {
                gridArticulos.ColumnCount = 7;

                gridArticulos.Columns[0].Name = "ID";
                gridArticulos.Columns[0].HeaderText = "ID";
                gridArticulos.Columns[0].DataPropertyName = "idArticulo";
                gridArticulos.Columns[0].Visible = false;

                gridArticulos.Columns[1].Name = "Número placa";
                gridArticulos.Columns[1].HeaderText = "Número placa";
                gridArticulos.Columns[1].DataPropertyName = "numeroPlaca"; 

                gridArticulos.Columns[2].Name = "Nombre";
                gridArticulos.Columns[2].HeaderText = "Nombre";
                gridArticulos.Columns[2].DataPropertyName = "nombArticulo";

                gridArticulos.Columns[3].Name = "Fecha ingreso";
                gridArticulos.Columns[3].HeaderText = "Fecha ingreso";
                gridArticulos.Columns[3].DataPropertyName = "fechaIngreso";

                gridArticulos.Columns[4].Name = "Descripción";
                gridArticulos.Columns[4].HeaderText = "Descripción";
                gridArticulos.Columns[4].DataPropertyName = "descripcArticulo";

                gridArticulos.Columns[5].Name = "Estado";
                gridArticulos.Columns[5].HeaderText = "Estado";
                gridArticulos.Columns[5].DataPropertyName = "estadoArticulo";

                gridArticulos.Columns[6].Name = "Categoría";
                gridArticulos.Columns[6].HeaderText = "Categoría";
                gridArticulos.Columns[6].DataPropertyName = "nombCategoria";

                gridArticulos.DataSource = listaBL;
            }
        }
    }
}
