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
    public partial class VerCuenta : Form
    {
        public static string idCuenta = "";

        /// <summary>
        /// Método para inicializar los componentes de la página actual
        /// </summary>
        public VerCuenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento para completar los datos del formulario de acuerdo al identificador de la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerCuenta_Load(object sender, EventArgs e)
        {
            ManejadorCuenta manejCuenta = new ManejadorCuenta();
            BLCuenta cuenta = manejCuenta.existeIdentificador(idCuenta);

            txtId.Text = cuenta.idUsuario;
            txtNombre.Text = cuenta.nombreEmpleado;
            checkEstado.Checked = cuenta.estado;
            txtRol.Text = cuenta.privilegio;
        }

        /// <summary>
        /// Evento para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
