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
    public partial class ModificarCuenta : Form
    {
        //private string idCuenta = "";
        public static string contrasenna = "";
        public static string idCuenta = "";


        public ModificarCuenta()
        {
            InitializeComponent();
            llenarComboBox();
            llenarCampos();
        }

        private void llenarCampos()
        {
            ManejadorCuenta manej = new ManejadorCuenta();
            BLCuenta cuenta = manej.existeIdentificador(idCuenta);
            txtId.Text = cuenta.idUsuario;
            txtNombre.Text = cuenta.nombreEmpleado;
            comboBoxRol.SelectedItem = cuenta.privilegio;
            checkEstado.Checked = cuenta.estado;

            if (cuenta.privilegio == "Admin")
            {
                comboBoxRol.Enabled = false;
                checkEstado.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ManejadorCuenta manejCuenta = new ManejadorCuenta();
            
            if (manejCuenta.modificarCuenta(new BLCuenta(idCuenta, txtNombre.Text.Trim(), contrasenna, comboBoxRol.SelectedItem.ToString(), checkEstado.Checked)))
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

        private void llenarComboBox()
        {
            comboBoxRol.Items.Add("Admin");
            comboBoxRol.Items.Add("Secretaria");
            comboBoxRol.Items.Add("Terapia Física");
            comboBoxRol.Items.Add("Psicología");
            comboBoxRol.Items.Add("Nutrición");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
