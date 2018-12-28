using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOArticulo
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);

        public void Guardar_Articulo(TOArticulo articulo)
        {
            try
            {


            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable consultar_Articulos()
        {
            try
            {
                String query = "Select * from Articulo";
                //SqlCommand sentencia = new SqlCommand(query, conexion);
                DataTable tablaTemporal = new DataTable();

                tablaTemporal.Columns.Add("Numero_Placa", Type.GetType("System.String"));
                tablaTemporal.Columns.Add("Nombre", Type.GetType("System.String"));
                tablaTemporal.Columns.Add("Identificador", Type.GetType("System.Integer"));
                tablaTemporal.Columns.Add("Fecha_Ingreso", Type.GetType("System.DataTime"));
                tablaTemporal.Columns.Add("Descripcion", Type.GetType("System.String"));
                tablaTemporal.Columns.Add("Estado", Type.GetType("System.String"));
                tablaTemporal.Columns.Add("Id_Categoria", Type.GetType("System.Integer"));

                //        if (conexion.State != ConnectionState.Open) {
                //            conexion.Open()
                //}

                //SqlDataReader datRead = sentencia.ExecuteReader();

                //if (datRead.HasRows)
                //{
                //    while(datRead.Read())
                //    {
                //        tablaTemporal.Rows.Add(datRead("Numero_Placa"), datRead("Nombre"), datRead("Identificador"), datRead("Fecha_Ingreso") datRead("Descripcion"),
                //            datRead("Estado"), datRead("Id_Categoria"));
                //    }
                //} else
                //{
                //    tablaTemporal.Rows.Add(datRead("--"), datRead("--"), datRead("--"), datRead("--") datRead("--"),
                //            datRead("--"), datRead("--"));
                //}

                //        if (conexion.State != ConnectionState.Closed) {
                //            conexion.Close()
                //}

                return tablaTemporal;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
