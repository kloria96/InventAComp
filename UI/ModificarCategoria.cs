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
    public partial class ModificarCategoria : Form
    {
        /// <summary>
        /// Método que inicializa los componentes de la página actual
        /// </summary>
        public ModificarCategoria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del botón "Cancelar" para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
