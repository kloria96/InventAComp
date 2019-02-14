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
    public partial class CuotasDonacion : Form
    {
        public static string idPrestamo = "";
        public static string contratoPrestamo = "";

        public CuotasDonacion()
        {
            InitializeComponent();
            lblContrato.Text = contratoPrestamo;
            gridCuotas.AutoGenerateColumns = false; //Cuota = Contribucion
            cargarGrid();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cargarGrid()
        {
            ManejadorContribucion manejCont = new ManejadorContribucion();
            List<BLContribucion> listaBL = new List<BLContribucion>();
            listaBL = manejCont.obtenerContribucionesPrestamo(Convert.ToInt32(idPrestamo));
            if (listaBL.Count != 0)
            {
                gridCuotas.ColumnCount = 5;

                gridCuotas.Columns[0].Name = "ID";
                gridCuotas.Columns[0].HeaderText = "ID";
                gridCuotas.Columns[0].DataPropertyName = "idContribucion";
                gridCuotas.Columns[0].Visible = false;

                gridCuotas.Columns[1].Name = "Número recibo";
                gridCuotas.Columns[1].HeaderText = "Número recibo";
                gridCuotas.Columns[1].DataPropertyName = "numeroRecibo";

                gridCuotas.Columns[2].Name = "Cuota";
                gridCuotas.Columns[2].HeaderText = "Cuota";
                gridCuotas.Columns[2].DataPropertyName = "cuota";

                gridCuotas.Columns[3].Name = "Fecha";
                gridCuotas.Columns[3].HeaderText = "Fecha";
                gridCuotas.Columns[3].DataPropertyName = "fecha";

                gridCuotas.Columns[4].Name = "IDPr";
                gridCuotas.Columns[4].HeaderText = "IDPr";
                gridCuotas.Columns[4].DataPropertyName = "idPrestamo";
                gridCuotas.Columns[4].Visible = false;

                gridCuotas.DataSource = listaBL;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormularioContribucion.idPrestamo = idPrestamo;
            FormularioContribucion.contratoPrestamo = contratoPrestamo;
            FormularioContribucion formulario = new FormularioContribucion();
            formulario.Owner = this;
            formulario.ShowDialog();
        }

    }
}
