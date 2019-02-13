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
    public partial class PrestamoEquipo : Form
    {
        public static string idArt = "";

        public PrestamoEquipo()
        {
            InitializeComponent();
            gridArticulos.AutoGenerateColumns = false;
            cargarGrid();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cargarGrid()
        {
            ManejadorArticulo manej = new ManejadorArticulo();
            List<BLArticulo> listaBL = new List<BLArticulo>();
            listaBL = manej.consultarArticulos();
            if (listaBL.Count != 0)
            {
                gridArticulos.ColumnCount = 8;

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
                //gridArticulos.Columns[3].Visible = false;

                gridArticulos.Columns[4].Name = "Descripción";
                gridArticulos.Columns[4].HeaderText = "Descripción";
                gridArticulos.Columns[4].DataPropertyName = "descripcArticulo";
                //gridArticulos.Columns[4].Visible = false;

                gridArticulos.Columns[5].Name = "Estado";
                gridArticulos.Columns[5].HeaderText = "Estado";
                gridArticulos.Columns[5].DataPropertyName = "estadoArticulo";

                gridArticulos.Columns[6].Name = "Ubicación";
                gridArticulos.Columns[6].HeaderText = "Ubicación";
                gridArticulos.Columns[6].DataPropertyName = "ubicacionArticulo";

                gridArticulos.Columns[7].Name = "Categoría";
                gridArticulos.Columns[7].HeaderText = "Categoría";
                gridArticulos.Columns[7].DataPropertyName = "nombCategoria";

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(button);

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(btn2);

                gridArticulos.DataSource = listaBL;
            }
        }

        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                FormularioPrestamo.idArticulo = gridArticulos.Rows[e.RowIndex].Cells[0].Value + "";
                FormularioPrestamo.nombreArticulo = gridArticulos.Rows[e.RowIndex].Cells[2].Value + "";
                new FormularioPrestamo().Show();
            }

            if (e.ColumnIndex == 9)
            {
                //Mostrar las cuotas de donación en una pantalla (forma de tabla por ej.), y poder añadir una nueva cuota
            }
        }

        private void gridArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridArticulos.Rows[e.RowIndex].Cells[8].Value = "Prestar";
            gridArticulos.Rows[e.RowIndex].Cells[9].Value = "Cuotas";
        }


    }
}
