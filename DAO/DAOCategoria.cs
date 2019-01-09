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
            
            conex.Open();
            MySqlCommand cmd = new MySqlCommand("Select nombre from categoria;", conex);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            DataTable tableDa = new DataTable();
            adapt.SelectCommand = cmd;
            adapt.Fill(tableDa);
            conex.Close();
            return tableDa;
        }

    }
}
