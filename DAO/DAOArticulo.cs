using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace DAO
{
    public class DAOArticulo
    {
        MySqlConnection conex = new MySqlConnection("server=localhost;user=root;password=1234;database=inventario");

        public DataTable consultar_Articulos()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            MySqlCommand cmd = new MySqlCommand("Select numeroPlaca,nombre,fechaIngreso,descripcion,estado from articulo order by nombre;", conex);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            DataTable tableDa = new DataTable();
            //tableDa.Columns.Add(new DataColumn("Categoria"));
            adapt.SelectCommand = cmd;
            adapt.Fill(tableDa);
            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return tableDa;
        }

        public void agregarArticulo(TOArticulo nuevoArt)
        {

        }
    }
}
