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
        public static string idCuenta = "";

        /// <summary>
        /// Método que llama al método para mostrar el grid con las cuentas guardadas y muestra el resto de componentes
        /// de la página actual
        /// </summary>
        public Administrador()
        {
            InitializeComponent();
            gridEmpleados.AutoGenerateColumns = false;
            llenarGrid();
        }

        /// <summary>
        /// Método que muestra en el grid la lista de las cuentas que se encuentran almacenadas en la base de datos
        /// </summary>
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

                gridEmpleados.Columns[1].Name = "Nombre";
                gridEmpleados.Columns[1].HeaderText = "Nombre";
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

                //DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
                //gridEmpleados.Columns.Add(but2);

                gridEmpleados.DataSource = listaBL;
            }
        }

        /// <summary>
        /// Evento para abrir la ventana de modificar una cuenta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                VerCuenta.idCuenta = gridEmpleados.Rows[e.RowIndex].Cells[0].Value + "";
                new VerCuenta().ShowDialog();
            }

            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                ModificarCuenta.idCuenta = gridEmpleados.Rows[e.RowIndex].Cells[0].Value + "";
                ModificarCuenta.contrasenna = gridEmpleados.Rows[e.RowIndex].Cells[2].Value + "";

                ModificarCuenta modCuent = new ModificarCuenta();
                modCuent.Owner = this;
                modCuent.ShowDialog();
            }

            //if (e.ColumnIndex == 7 && e.RowIndex != -1)
            //{
                //eliminarFila(Convert.ToInt32(gridArticulos.Rows[e.RowIndex].Cells[0].Value));
            //}
        }

    
        /// <summary>
        /// Evento para aasignar el nombre de los botones del grid "Ver" y "Modificar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridEmpleados.Rows[e.RowIndex].Cells[5].Value = "Ver";
            gridEmpleados.Rows[e.RowIndex].Cells[6].Value = "Modificar";
            //gridEmpleados.Rows[e.RowIndex].Cells[7].Value = "Eliminar";
        }

        /// <summary>
        /// Evento para salir de la página actual y mostrar la página de Inicio de Sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Manager.getManager().rol = "";
            Manager.getManager().nombre = "";
            this.Dispose();
            new InicioSesion().Show();
        }

        /// <summary>
        /// Evento para agregar una nueva cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevaCuenta art = new NuevaCuenta();
            art.Owner = this;
            art.MdiParent = this.MdiParent;
            art.ShowDialog();
        }

    }
}
