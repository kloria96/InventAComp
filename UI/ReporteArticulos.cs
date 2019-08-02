using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BL;

namespace UI
{
    public partial class ReporteArticulos : Form
    {
        public List<BLArticulo> listaReporte = new List<BLArticulo>();

        /// <summary>
        /// Método para inicializar los componentes de la página actual
        /// </summary>
        public ReporteArticulos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para cargar el reporte de artículos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReporteArticulos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetArticulo", listaReporte));
            ReportParameter parameter1 = new ReportParameter("nombreUsuario", Manager.getManager().nombre);
            reportViewer1.LocalReport.SetParameters(parameter1);
            this.reportViewer1.RefreshReport();
        }
    }
}
