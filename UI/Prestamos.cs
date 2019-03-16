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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
            gridArticulos.AutoGenerateColumns = false;
            cargarGrid();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cargarGrid()
        {
            ManejadorPrestamo manej = new ManejadorPrestamo();
            List<BLPrestamo> listaBL = new List<BLPrestamo>();
            listaBL = manej.obtenerArticulosPrestamo();
            if (listaBL.Count != 0)
            {
                gridArticulos.ColumnCount = 5;

                gridArticulos.Columns[0].Name = "ID";
                gridArticulos.Columns[0].HeaderText = "ID";
                gridArticulos.Columns[0].DataPropertyName = "idPrestamo";
                gridArticulos.Columns[0].Visible = false;

                gridArticulos.Columns[1].Name = "Número contrato";
                gridArticulos.Columns[1].HeaderText = "Número contrato";
                gridArticulos.Columns[1].DataPropertyName = "numeroContrato";

                gridArticulos.Columns[2].Name = "Paciente";
                gridArticulos.Columns[2].HeaderText = "Paciente";
                gridArticulos.Columns[2].DataPropertyName = "paciente";

                gridArticulos.Columns[3].Name = "Equipo";
                gridArticulos.Columns[3].HeaderText = "Equipo";
                gridArticulos.Columns[3].DataPropertyName = "nombreArticulo";

                gridArticulos.Columns[4].Name = "Número placa";
                gridArticulos.Columns[4].HeaderText = "Número placa";
                gridArticulos.Columns[4].DataPropertyName = "numeroPlacaArticulo";

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(button);

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(btn2);

                DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(btn3);

                gridArticulos.DataSource = listaBL;
            }
        }

        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                VerPrestamo.idPrestamo = gridArticulos.Rows[e.RowIndex].Cells[0].Value + "";
                new VerPrestamo().ShowDialog();
            }

            if (e.ColumnIndex == 6)
            {
                CuotasDonacion.idPrestamo = gridArticulos.Rows[e.RowIndex].Cells[0].Value + "";
                CuotasDonacion.contratoPrestamo = gridArticulos.Rows[e.RowIndex].Cells[1].Value + "";
                CuotasDonacion cuotas = new CuotasDonacion();
                cuotas.Owner = this;
                cuotas.Show();
            }
            if (e.ColumnIndex == 7)
            {
                int idPrest = Convert.ToInt32(gridArticulos.Rows[e.RowIndex].Cells[0].Value);
                ManejadorPrestamo manejPrest = new ManejadorPrestamo();
                var confirmResult = MessageBox.Show("¿Desea terminar el préstamo?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (manejPrest.terminarPrestamo(idPrest))
                    {
                        this.Dispose();
                        new Prestamos().Show();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el artículo");
                    }

                }
            }
        }

        private void gridArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridArticulos.Rows[e.RowIndex].Cells[5].Value = "Ver Préstamo";
            gridArticulos.Rows[e.RowIndex].Cells[6].Value = "Ver Contribuciones";
            gridArticulos.Rows[e.RowIndex].Cells[7].Value = "Terminar";
        }

    }
}
