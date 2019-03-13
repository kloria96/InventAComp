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
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string contra = txtContra.Text.Trim();
            ManejadorCuenta manejCuenta = new ManejadorCuenta();
            BLCuenta cuenta = manejCuenta.buscarCuenta(nombre, contra);

            if (cuenta.nombreUsuario != null && !cuenta.nombreUsuario.Equals(""))
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
                        Principal princ = new Principal();
                        princ.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("La cuenta se encuentra deshabilitada");
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario y contraseña no coinciden");
            }
        }
    }
}
