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
    public partial class Principal : Form
    {
        public static string value = "";
        public static string fechaFin = "";
        public static string opcion = ""; //1: Por nombre, 2: Por departamento, 3: Por fecha (inicio/fin)

        public Principal()
        {
            InitializeComponent();
            revisarLogin();
            cbFiltros.SelectedIndex = 0;
        }

        public void revisarLogin()
        {
            string privilegio = Manager.getManager().rol;

            if (!privilegio.Equals("Secretaria"))
            {
                btnCategoria.Visible = false;
            }
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            art.MdiParent = this.MdiParent;
            art.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            cat.MdiParent = this.MdiParent;
            cat.Show();
        }

        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltros.SelectedItem.ToString() == "")
            {
                opcion = "0";
                btnBuscar.Enabled = false;
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblCategoria.Visible = false;
                cbCategorias.Visible = false;
                lblFechaIni.Visible = false;
                lblFechaFin.Visible = false;
                dtInicio.Visible = false;
                dtFin.Visible = false;
            }
            if (cbFiltros.SelectedItem.ToString() == "Nombre")
            {
                opcion = "1";
                lblCategoria.Visible = false;
                cbCategorias.Visible = false;
                lblFechaIni.Visible = false;
                lblFechaFin.Visible = false;
                dtInicio.Visible = false;
                dtFin.Visible = false;

                lblNombre.Visible = true;
                txtNombre.Visible = true;
                btnBuscar.Enabled = true;
            }
            if (cbFiltros.SelectedItem.ToString() == "Categoría")
            {
                opcion = "2";
                cbCategorias.Items.Clear();
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblFechaIni.Visible = false;
                lblFechaFin.Visible = false;
                dtInicio.Visible = false;
                dtFin.Visible = false;

                lblCategoria.Visible = true;
                cbCategorias.Visible = true;
                btnBuscar.Enabled = true;

                cargarDepartamentos();
            }
            if (cbFiltros.SelectedItem.ToString() == "Fecha de ingreso")
            {
                opcion = "3";
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblCategoria.Visible = false;
                cbCategorias.Visible = false;

                lblFechaIni.Visible = true;
                lblFechaFin.Visible = true;
                dtInicio.Visible = true;
                dtFin.Visible = true;
                btnBuscar.Enabled = true;
            }
        }

        private void cargarDepartamentos()
        {
            ManejadorCategoria manejCat = new ManejadorCategoria();
            foreach (BLCategoria categoria in manejCat.consultarCategorias())
            {
                cbCategorias.Items.Add(categoria.nombreCategoria);
            }
            
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = cbCategorias.SelectedItem.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case "1":
                    if (txtNombre.Text != "")
                    {
                        value = txtNombre.Text;
                        MostrarArticulos mostrarA = new MostrarArticulos();
                        mostrarA.MdiParent = this.MdiParent;
                        mostrarA.Show();
                        txtNombre.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el nombre del artículo a buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "2":
                    if (cbCategorias.SelectedItem != null)
                    {
                        value = cbCategorias.SelectedItem.ToString();
                        MostrarArticulos mostrarAr = new MostrarArticulos();
                        mostrarAr.MdiParent = this.MdiParent;
                        mostrarAr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una categoría");
                    }
                    break;
                case "3":
                    value = dtInicio.Value.ToString("yyyy-MM-dd");
                    fechaFin = dtFin.Value.ToString("yyyy-MM-dd");
                    MostrarArticulos mostrarArt = new MostrarArticulos();
                    mostrarArt.MdiParent = this.MdiParent;
                    mostrarArt.Show();
                    break;
            }
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            new PrestamoEquipo().Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar sesión
            //Application.Exit();
            Manager.getManager().rol = "";
            Manager.getManager().nombre = "";
            this.Dispose();
            new InicioSesion().Show();
        }

        private void cbPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPrestamos.SelectedItem.ToString() == "Ingresar Préstamo")
            {
                //Ingresar Préstamo
                new PrestarArticulo().ShowDialog();
            }
            if (cbPrestamos.SelectedItem.ToString() == "Ver Préstamos Activos")
            {
                //Ver préstamos activos
                new Prestamos().ShowDialog();
            }
            if (cbPrestamos.SelectedItem.ToString() == "Ver Préstamos")
            {
                //Ver Préstamos de un Artículo
                new VerPrestamosArticulo().Show();
            }
            if (cbPrestamos.SelectedItem.ToString() == "Ver Contribuciones")
            {
                //Ver contribuciones de un préstamo
                new VerContribucionesPrestamo().Show();
            }
        }

        private void cbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            NuevoArticulo art = new NuevoArticulo();
            //art.Owner = this;
            art.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigCuenta cat = new ConfigCuenta();
            cat.MdiParent = this.MdiParent;
            cat.ShowDialog();
        }
    }
}
