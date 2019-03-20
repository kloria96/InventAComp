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
            gridEmpleados.AutoGenerateColumns = false;
            llenarGrid();
            llenarComboBox();
        }

        private void llenarGrid()
        {
            ManejadorCuenta manej = new ManejadorCuenta();
            List<BLCuenta> listaBL = new List<BLCuenta>();
            listaBL = manej.listaCuentas();
            if (listaBL.Count != 0)
            {
                gridEmpleados.ColumnCount = 5;

                gridEmpleados.Columns[0].Name = "Identificador";
                gridEmpleados.Columns[0].HeaderText = "Identificador";
                gridEmpleados.Columns[0].DataPropertyName = "idUsuario";

                gridEmpleados.Columns[1].Name = "Nombre Empleado";
                gridEmpleados.Columns[1].HeaderText = "Nombre Empleado";
                gridEmpleados.Columns[1].DataPropertyName = "nombreEmpleado";

                gridEmpleados.Columns[2].Name = "Contraseña";
                gridEmpleados.Columns[2].HeaderText = "Contraseña";
                gridEmpleados.Columns[2].DataPropertyName = "contrasenna";
                gridEmpleados.Columns[2].Visible = false;

                gridEmpleados.Columns[3].Name = "Rol";
                gridEmpleados.Columns[3].HeaderText = "Rol";
                gridEmpleados.Columns[3].DataPropertyName = "privilegio";

                gridEmpleados.Columns[4].Name = "Estado";
                gridEmpleados.Columns[4].HeaderText = "Estado";
                gridEmpleados.Columns[4].DataPropertyName = "estado";
                gridEmpleados.Columns[4].Visible = false;

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                gridEmpleados.Columns.Add(button);

                DataGridViewButtonColumn but = new DataGridViewButtonColumn();
                gridEmpleados.Columns.Add(but);

                DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
                gridEmpleados.Columns.Add(but2);

                gridEmpleados.DataSource = listaBL;
            }
        }

        private void gridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                //VerCuenta.idArticulo = gridEmpleados.Rows[e.RowIndex].Cells[0].Value + "";
                VerCuenta.idArticulo = gridEmpleados.Rows[e.RowIndex].Cells[0].Value + "";
                new VerCuenta().Show();
            }

            if (e.ColumnIndex == 6)
            {
                idArt = gridArticulos.Rows[e.RowIndex].Cells[0].Value + "";
                ModificarArticulo.categoriaArticulo = gridArticulos.Rows[e.RowIndex].Cells[7].Value + "";
                ModificarArticulo.estadoArticulo = gridArticulos.Rows[e.RowIndex].Cells[5].Value + "";

                ModificarArticulo modArt = new ModificarArticulo();
                modArt.Owner = this;
                modArt.ShowDialog();
            }

            if (e.ColumnIndex == 7)
            {
                eliminarFila(Convert.ToInt32(gridArticulos.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void gridEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridEmpleados.Rows[e.RowIndex].Cells[5].Value = "Ver";
            gridEmpleados.Rows[e.RowIndex].Cells[6].Value = "Modificar";
            gridEmpleados.Rows[e.RowIndex].Cells[7].Value = "Eliminar";
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

            cuenta.idUsuario = txtId.Text.Trim();
            cuenta.contrasenna = txtContra.Text.Trim();
            cuenta.nombreEmpleado = txtNombre.Text.Trim();
            cuenta.estado = checkEstado.Checked;
            cuenta.privilegio = comboBoxRol.SelectedItem.ToString();

            ManejadorCuenta manej = new ManejadorCuenta();
            manej.insertar(cuenta);
            MessageBox.Show("El usuario se ha creado con éxito");
            txtId.Text = "";
            txtContra.Text = "";
            txtNombre.Text = "";
        }
    }
}
