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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            art.MdiParent = this.MdiParent;
            art.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
