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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            llenarComboBox();
        }

        private void llenarComboBox()
        {
            comboBoxRol.Items.Add("Admin");
            comboBoxRol.Items.Add("Secretaria");
            comboBoxRol.Items.Add("Terapia Física");
            comboBoxRol.Items.Add("Psicologia");
            comboBoxRol.Items.Add("Nutricion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLCuenta cuenta = new BLCuenta();
            MessageBox.Show(comboBoxRol.SelectedItem.ToString());

            cuenta.idUsuario = txtId.Text.Trim();
            cuenta.contrasenna = txtContra.Text.Trim();
            cuenta.nombreEmpleado = txtNombre.Text.Trim();
            cuenta.estado = checkEstado.Checked;
            cuenta.privilegio = comboBoxRol.SelectedText;

            ManejadorCuenta manej = new ManejadorCuenta();
            manej.insertarActualizar(cuenta);
            MessageBox.Show("El usuario se ha creado con éxito");
        }
    }
}
