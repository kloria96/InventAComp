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
    public partial class NuevaCuenta : Form
    {
        /// <summary>
        /// Método para inicializar los componentes y asignar los datos a la página actual
        /// </summary>
        public NuevaCuenta()
        {
            InitializeComponent();
            llenarComboBox();
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

        /// <summary>
        /// Método para llenar el comboBox con los roles que existen
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
        /// Evento del botón "Guardar" para la creación de una nueva cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxRol.SelectedItem != null)
            {
                if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtContra.Text) && !string.IsNullOrEmpty(txtNombre.Text))
                {
                    BLCuenta cuenta = new BLCuenta();

                    cuenta.idUsuario = txtId.Text.Trim();
                    cuenta.contrasenna = txtContra.Text.Trim();
                    cuenta.nombreEmpleado = txtNombre.Text.Trim();
                    cuenta.estado = checkEstado.Checked;
                    cuenta.privilegio = comboBoxRol.SelectedItem.ToString();

                    ManejadorCuenta manej = new ManejadorCuenta();
                    BLCuenta cuent = manej.existeIdentificador(txtId.Text.Trim());
                    if (string.IsNullOrEmpty(cuent.idUsuario))
                    {
                        manej.insertar(cuenta);
                        this.Owner.Dispose();
                        this.Dispose();
                        MessageBox.Show("El usuario se ha creado con éxito");
                        new Administrador().Show();
                    } else
                    {
                        txtId.Clear();
                        MessageBox.Show("El nombre de usuario ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Debe de ingresar todos los datos");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol para el empleado");
            }
        }

    }
}
