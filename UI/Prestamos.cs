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
        /// <summary>
        /// Método para inicializar los componentes de la página actual, así como cargar el grid
        /// </summary>
        public Prestamos()
        {
            InitializeComponent();
            gridPrestamos.AutoGenerateColumns = false;
            cargarGrid();
        }

        /// <summary>
        /// Evento del botón "Atrás" para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Método para cargar el grid con los artículos que se encuentran en préstamo
        /// </summary>
        private void cargarGrid()
        {
            ManejadorPrestamo manej = new ManejadorPrestamo();
            List<BLPrestamo> listaBL = new List<BLPrestamo>();
            listaBL = manej.obtenerArticulosPrestamo();
            if (listaBL.Count != 0)
            {
                gridPrestamos.ColumnCount = 8;

                gridPrestamos.Columns[0].Name = "ID";
                gridPrestamos.Columns[0].HeaderText = "ID";
                gridPrestamos.Columns[0].DataPropertyName = "idPrestamo";
                gridPrestamos.Columns[0].Visible = false;

                gridPrestamos.Columns[1].Name = "Número contrato";
                gridPrestamos.Columns[1].HeaderText = "Número contrato";
                gridPrestamos.Columns[1].DataPropertyName = "numeroContrato";

                gridPrestamos.Columns[2].Name = "Paciente";
                gridPrestamos.Columns[2].HeaderText = "Paciente";
                gridPrestamos.Columns[2].DataPropertyName = "paciente";

                gridPrestamos.Columns[3].Name = "Equipo";
                gridPrestamos.Columns[3].HeaderText = "Equipo";
                gridPrestamos.Columns[3].DataPropertyName = "nombreArticulo";

                gridPrestamos.Columns[4].Name = "Número placa";
                gridPrestamos.Columns[4].HeaderText = "Número placa";
                gridPrestamos.Columns[4].DataPropertyName = "numeroPlacaArticulo";

                gridPrestamos.Columns[5].Name = "Responsable";
                gridPrestamos.Columns[5].HeaderText = "Responsable";
                gridPrestamos.Columns[5].DataPropertyName = "responsable";
                gridPrestamos.Columns[5].Visible = false;

                gridPrestamos.Columns[6].Name = "Fecha préstamo";
                gridPrestamos.Columns[6].HeaderText = "Fecha";
                gridPrestamos.Columns[6].DataPropertyName = "fechaPrestamo";
                gridPrestamos.Columns[6].Visible = false;

                gridPrestamos.Columns[7].Name = "Fecha entrega";
                gridPrestamos.Columns[7].HeaderText = "Fecha entrega";
                gridPrestamos.Columns[7].DataPropertyName = "fechaEntrega";
                gridPrestamos.Columns[7].Visible = false;

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                gridPrestamos.Columns.Add(button);

                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                gridPrestamos.Columns.Add(btn2);

                DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
                gridPrestamos.Columns.Add(btn3);

                gridPrestamos.DataSource = listaBL;
            }
        }

        /// <summary>
        /// Evento para realizar diferentes acciones con el préstamo: "Ver Préstamo", "Ver Contribuciones" y "Terminar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                VerPrestamo.idPrestamo = gridPrestamos.Rows[e.RowIndex].Cells[0].Value + "";
                new VerPrestamo().ShowDialog();
            }

            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                CuotasDonacion.idPrestamo = gridPrestamos.Rows[e.RowIndex].Cells[0].Value + "";
                CuotasDonacion.contratoPrestamo = gridPrestamos.Rows[e.RowIndex].Cells[1].Value + "";
                CuotasDonacion cuotas = new CuotasDonacion();
                cuotas.Owner = this;
                cuotas.Show();
            }
            if (e.ColumnIndex == 10 && e.RowIndex != -1)
            {
                int idPrest = Convert.ToInt32(gridPrestamos.Rows[e.RowIndex].Cells[0].Value);
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

        /// <summary>
        /// Evento para nombrar los botones de las filas del grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridPrestamos.Rows[e.RowIndex].Cells[8].Value = "Ver Préstamo";
            gridPrestamos.Rows[e.RowIndex].Cells[9].Value = "Ver Contribuciones";
            gridPrestamos.Rows[e.RowIndex].Cells[10].Value = "Terminar";
        }

        /// <summary>
        /// Evento para la creación del reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReportePrestamos reporte = new ReportePrestamos();

            for (int i = 0; i < gridPrestamos.Rows.Count; i++)
            {
                BLPrestamo prestamo = new BLPrestamo();
                prestamo.numeroContrato = (string)gridPrestamos.Rows[i].Cells[1].Value;
                prestamo.paciente = (string)gridPrestamos.Rows[i].Cells[2].Value;
                prestamo.responsable = (string)gridPrestamos.Rows[i].Cells[5].Value; //Index pendiente
                prestamo.fechaPrestamo = (DateTime)gridPrestamos.Rows[i].Cells[6].Value; //Index pendiente
                prestamo.fechaEntrega = (DateTime)gridPrestamos.Rows[i].Cells[7].Value; //Index pendiente
                reporte.listaReporte.Add(prestamo);
            }
            reporte.ShowDialog();
        }

    }
}
