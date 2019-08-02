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

        /// <summary>
        /// Método para mostrar los datos y componentes de la página actual
        /// </summary>
        public ModificarCuenta()
        {
            InitializeComponent();
            llenarComboBox();
            llenarCampos();
        }

        /// <summary>
        /// Método que completa los datos del formulario de la cuenta que se va a modificar
        /// </summary>
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

        /// <summary>
        /// Evento del botón "Guardar" para actualizar los datos de la cuenta en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Método para añadir al comboBox los roles existentes
        /// </summary>
        private void llenarComboBox()
        {
            comboBoxRol.Items.Add("Admin");
            comboBoxRol.Items.Add("Secretaria");
            comboBoxRol.Items.Add("Terapia Física");
            comboBoxRol.Items.Add("Psicología");
            comboBoxRol.Items.Add("Nutrición");
        }

        /// <summary>
        /// Evento del botón "Atrás" para cerrar la página actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
