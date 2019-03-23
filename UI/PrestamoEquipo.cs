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
    public partial class PrestamoEquipo : Form
    {
        
        public PrestamoEquipo()
        {
            InitializeComponent();
            gridArticulos.AutoGenerateColumns = false;
            cargarGrid();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cargarGrid()
        {
            ManejadorPrestamo manej = new ManejadorPrestamo();
            List<BLArticulo> listaBL = new List<BLArticulo>();
            listaBL = manej.consultarArticulosDisponibles();
            if (listaBL.Count != 0)
            {
                gridArticulos.ColumnCount = 8;

                gridArticulos.Columns[0].Name = "ID";
                gridArticulos.Columns[0].HeaderText = "ID";
                gridArticulos.Columns[0].DataPropertyName = "idArticulo";
                gridArticulos.Columns[0].Visible = false;

                gridArticulos.Columns[1].Name = "Número placa";
                gridArticulos.Columns[1].HeaderText = "Número placa";
                gridArticulos.Columns[1].DataPropertyName = "numeroPlaca";

                gridArticulos.Columns[2].Name = "Nombre";
                gridArticulos.Columns[2].HeaderText = "Nombre";
                gridArticulos.Columns[2].DataPropertyName = "nombArticulo";

                gridArticulos.Columns[3].Name = "Fecha ingreso";
                gridArticulos.Columns[3].HeaderText = "Fecha ingreso";
                gridArticulos.Columns[3].DataPropertyName = "fechaIngreso";

                gridArticulos.Columns[4].Name = "Descripción";
                gridArticulos.Columns[4].HeaderText = "Descripción";
                gridArticulos.Columns[4].DataPropertyName = "descripcArticulo";

                gridArticulos.Columns[5].Name = "Estado";
                gridArticulos.Columns[5].HeaderText = "Estado";
                gridArticulos.Columns[5].DataPropertyName = "estadoArticulo";

                gridArticulos.Columns[6].Name = "Ubicación";
                gridArticulos.Columns[6].HeaderText = "Ubicación";
                gridArticulos.Columns[6].DataPropertyName = "ubicacionArticulo";

                gridArticulos.Columns[7].Name = "Categoría";
                gridArticulos.Columns[7].HeaderText = "Categoría";
                gridArticulos.Columns[7].DataPropertyName = "nombCategoria";

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                gridArticulos.Columns.Add(button);

                string role = Manager.getManager().rol;
                if (role == "Secretaria")
                {
                    gridArticulos.DataSource = listaBL;
                }
                else
                {
                    List<BLArticulo> listaCategoria = new List<BLArticulo>();
                    foreach (BLArticulo art in listaBL)
                    {
                        if (art.nombCategoria.Equals(role))
                        {
                            listaCategoria.Add(art);
                        }
                        gridArticulos.DataSource = listaCategoria;
                    }
                }

                //if (role.Equals("Secretaria"))
                //{
                //    gridArticulos.DataSource = listaBL;
                //}
                //else
                //{
                //    if (role.Equals("Nutrición"))
                //    {
                //        foreach (BLArticulo art in listaBL)
                //        {
                //            if (art.nombCategoria.Equals("Nutrición"))
                //            {
                //                listaCategoria.Add(art);
                //            }
                //        }
                //        gridArticulos.DataSource = listaCategoria;
                //    }
                //    else
                //    {
                //        if (Manager.getManager().rol.Equals("Psicología"))
                //        {
                //            foreach (BLArticulo art in listaBL)
                //            {
                //                if (art.nombCategoria.Equals("Psicología"))
                //                {
                //                    listaCategoria.Add(art);
                //                }
                //            }
                //            gridArticulos.DataSource = listaCategoria;
                //        }
                //        else
                //        {
                //            if (Manager.getManager().rol.Equals("Terapia Física"))
                //            {
                //                foreach (BLArticulo art in listaBL)
                //                {
                //                    if (art.nombCategoria.Equals("Terapia Física"))
                //                    {
                //                        listaCategoria.Add(art);
                //                    }
                //                }
                //                gridArticulos.DataSource = listaCategoria;
                //            }
                //        }
                //    }
                //}
            }
        }

        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                FormularioPrestamo.idArticulo = gridArticulos.Rows[e.RowIndex].Cells[0].Value + "";
                FormularioPrestamo.nombreArticulo = gridArticulos.Rows[e.RowIndex].Cells[2].Value + "";
                FormularioPrestamo formPrest = new FormularioPrestamo();
                formPrest.Owner = this;
                formPrest.ShowDialog();
            }
        }

        private void gridArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            gridArticulos.Rows[e.RowIndex].Cells[8].Value = "Prestar";
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            new Prestamos().Show();
            this.Dispose();
        }
    }
}
