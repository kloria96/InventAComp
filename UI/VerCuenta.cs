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

        public VerCuenta()
        {
            InitializeComponent();
        }

        private void VerCuenta_Load(object sender, EventArgs e)
        {
            ManejadorCuenta manejCuenta = new ManejadorCuenta();
            BLCuenta cuenta = manejCuenta.existeIdentificador(idCuenta);

            txtId.Text = cuenta.idUsuario;
            txtNombre.Text = cuenta.nombreEmpleado;
            checkEstado.Checked = cuenta.estado;
            txtRol.Text = cuenta.privilegio;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
