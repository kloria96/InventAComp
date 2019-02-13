using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormularioPrestamo : Form
    {
        public static string idArticulo = "";
        public static string nombreArticulo = "";

        public FormularioPrestamo()
        {
            InitializeComponent();
            lblArticulo.Text = nombreArticulo;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
