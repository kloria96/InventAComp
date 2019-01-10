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
            MySqlCommand cmd = new MySqlCommand("select a.numeroPlaca, a.nombre, a.fechaIngreso, a.descripcion, a.estado, c.nombre from inventario.articulo as a, inventario.categoria as c where c.idCategoria = a.idCategoria;", conex);
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
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            String qry = "insert into articulo(numeroPlaca, nombre,fechaIngreso,descripcion,estado,idCategoria) values (@numPlac, @nomb, @fechIng, @descripc, @est, @idCateg)";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            cmd.Parameters.AddWithValue("@numPlac", nuevoArt.numeroPlaca);
            cmd.Parameters.AddWithValue("@nomb", nuevoArt.nombArticulo);
            cmd.Parameters.AddWithValue("@fechIng", nuevoArt.fechaIngreso);
            cmd.Parameters.AddWithValue("@descripc", nuevoArt.descripcArticulo);
            cmd.Parameters.AddWithValue("@est", nuevoArt.estadoArticulo);
            cmd.Parameters.AddWithValue("@idCateg", nuevoArt.idCategoria);
            cmd.ExecuteNonQuery();
            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
        }
    }
}
