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
    public partial class InicioSesion : Form
    {
        /// <summary>
        /// Método para inicializar los componentes de la página actual
        /// </summary>
        public InicioSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento del botón "Salir" para salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento del botón "Ingresar" en la que se verifican las credenciales y se inicia sesión en la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string contra = txtContra.Text.Trim();
            ManejadorCuenta manejCuenta = new ManejadorCuenta();
            BLCuenta cuenta = manejCuenta.buscarCuenta(nombre, contra);

            if (cuenta.idUsuario != null && !cuenta.idUsuario.Equals(""))
            {
                if (cuenta.estado == true)
                {
                    if (cuenta.privilegio.Equals("Admin"))
                    {
                        Administrador admin = new Administrador();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        Manager.getManager().rol = cuenta.privilegio;
                        Manager.getManager().nombre = cuenta.nombreEmpleado;
                        Manager.getManager().id = cuenta.idUsuario;
                        this.Hide();
                        Principal princ = new Principal();
                        princ.Show();
                    }
                }
                else
                {
                    MessageBox.Show("La cuenta se encuentra deshabilitada");
                    //txtNombre.Clear();
                    txtContra.Clear();
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario y contraseña no coinciden");
                //txtNombre.Clear();
                txtContra.Clear();
            }
        }

    }
}
