using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DAOCategoria
    {
        MySqlConnection conex = new MySqlConnection("server=localhost;user=root;password=1234;database=inventario");

        public DataTable consultarCategorias()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            MySqlCommand cmd = new MySqlCommand("Select nombre from categoria order by nombre;", conex);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            DataTable tableDa = new DataTable();
            adapt.SelectCommand = cmd;
            adapt.Fill(tableDa);
            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return tableDa;
        }

        public void insertarCategoria(String nombre)
        {
            String qry = "insert into categoria(nombre) values (@nomb)";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            cmd.Parameters.AddWithValue("@nomb", nombre);
            cmd.ExecuteNonQuery();
            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

        }

        public DataTable consultarCategoriasOrdenId()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            MySqlCommand cmd = new MySqlCommand("Select nombre from categoria", conex);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            DataTable tableDa = new DataTable();
            adapt.SelectCommand = cmd;
            adapt.Fill(tableDa);
            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            return tableDa;
        }
    }
}
