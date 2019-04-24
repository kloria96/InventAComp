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
    public partial class ConfigCuenta : Form
    {
        //public static string contrasenna = "";
        //public static string idCuenta = "";

        public ConfigCuenta()
        {
            InitializeComponent();
            llenar();
        }

        private void llenar()
        {
            ManejadorCuenta manejCuenta = new ManejadorCuenta();
            BLCuenta cuenta = manejCuenta.existeIdentificador(Manager.getManager().id);

            txtId.Text = cuenta.idUsuario;
            txtNombre.Text = cuenta.nombreEmpleado;
            txtContra.Text = cuenta.contrasenna;
            txtRol.Text = cuenta.privilegio;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ManejadorCuenta manejCuenta = new ManejadorCuenta();

            if (manejCuenta.modificarCuenta(new BLCuenta(txtId.Text.Trim(), txtNombre.Text.Trim(), txtContra.Text.Trim(), txtRol.Text.Trim(), true)))
            {
                this.Owner.Dispose();
                this.Dispose();
                MessageBox.Show("Se han actualizado los datos de la cuenta");
                new Administrador().Show();
            }
            else
            {
                MessageBox.Show("No se ha podido actualizar la cuenta");
                this.Dispose();
            }
        }

        private void ConfigCuenta_Load(object sender, EventArgs e)
        {
            //ManejadorCuenta manej = new ManejadorCuenta();
            //BLCuenta cuenta = manej.existeIdentificador(idCuenta);
            //txtId.Text = cuenta.idUsuario;
            //txtNombre.Text = cuenta.nombreEmpleado;
            //comboBoxRol.SelectedItem = cuenta.privilegio;
            //txtContra.Text = cuenta.contrasenna;
        }
    }
}
