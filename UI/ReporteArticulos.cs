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

        public ReporteArticulos()
        {
            InitializeComponent();
        }

        private void ReporteArticulos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetArticulo", listaReporte));
            this.reportViewer1.RefreshReport();
        }
    }
}
