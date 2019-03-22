using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TO;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DAOPrestamo
    {
        //MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionString);
        MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringM);
        //MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringJ);

        // connectionStringJ (Juan Diego)
        // connectionStringM (Melany)
        // connectionString (Asoc. Acompañame)

        public bool agregarPrestamo(TOPrestamo nuevoPrest)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "insert into prestamo (numeroContrato, paciente, responsable, fechaPrestamo, fechaEntrega, estado, idArticulo) values (@con, @pac, @res, @fecPr, @fecEn, 1, @idArt);";
            MySqlCommand cmd = new MySqlCommand(qry, conex);

            cmd.Parameters.AddWithValue("@con", nuevoPrest.numeroContrato);
            cmd.Parameters.AddWithValue("@pac", nuevoPrest.paciente);
            cmd.Parameters.AddWithValue("@res", nuevoPrest.responsable);
            cmd.Parameters.AddWithValue("@fecPr", nuevoPrest.fechaPrestamo);
            cmd.Parameters.AddWithValue("@fecEn", nuevoPrest.fechaEntrega);
            cmd.Parameters.AddWithValue("@idArt", nuevoPrest.idArticulo);
            int result = cmd.ExecuteNonQuery();

            bool prestado = articuloPrestado(nuevoPrest.idArticulo);

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

            if (prestado && result > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private bool articuloPrestado(int idArticulo)
        {
            String qry = "update articulo set prestado = 1 where idArticulo = @idArt";
            MySqlCommand cmd = new MySqlCommand(qry, conex);

            cmd.Parameters.AddWithValue("@idArt", idArticulo);

            int res = cmd.ExecuteNonQuery();
            return (res > 0 ? true : false);
        }

        private bool modificarCategoriaPrestamo(int idArticulo)
        {
            String qry = "update articulo set idCategoria = (select idCategoria from categoria where nombre = 'Préstamo') where idArticulo = @idArt";
            MySqlCommand cmd = new MySqlCommand(qry, conex);

            cmd.Parameters.AddWithValue("@idArt", idArticulo);

            int res = cmd.ExecuteNonQuery();
            return (res > 0 ? true : false);
        }

        public List<TOPrestamo> obtenerPrestamosArticulo(int idArticulo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select * from prestamo where idArticulo = @idArt;";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idArt", idArticulo);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOPrestamo> lista = new List<TOPrestamo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new TOPrestamo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetInt32(6)));
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        //Retorna true cuando se eliminó correctamente, false cuando no se pudo eliminar
        public bool eliminarPrestamo(int idPrestamo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "delete from prestamo where idPrestamo = @idPres;";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idPres", idPrestamo);

            int result = cmd.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
        }

        public List<TOPrestamo> obtenerArticulosPrestamo()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            String qry = "select p.idPrestamo, p.numeroContrato, p.paciente, a.numeroPlaca, a.nombre from prestamo p join articulo a on p.idArticulo = a.idArticulo where p.estado = 1;";
            MySqlCommand cmd = new MySqlCommand(qry, conex);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOPrestamo> lista = new List<TOPrestamo>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new TOPrestamo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        public List<TOArticulo> consultarArticulosDisponibles()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.fechaIngreso, a.descripcion, a.estado, a.ubicacion, c.nombre from inventario.articulo as a, inventario.categoria as c where c.idCategoria = a.idCategoria and c.nombre != 'Préstamo';";
            MySqlCommand cmd = new MySqlCommand(qry, conex);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOArticulo> lista = new List<TOArticulo>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TOArticulo to = new TOArticulo();
                    to.idArticulo = reader.GetInt32(0);
                    to.numeroPlaca = reader.GetString(1);
                    to.nombArticulo = reader.GetString(2);
                    to.fechaIngreso = reader.GetDateTime(3);
                    to.descripcArticulo = reader.GetString(4);
                    to.estadoArticulo = reader.GetString(5);
                    to.ubicacionArticulo = reader.GetString(6);
                    to.nombreCategoria = reader.GetString(7);
                    lista.Add(to);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        //Desactiva el préstamo (estado = 0), no lo elimina de la BD. Ademas, establece el estado del artículo como 0
        public bool terminarPrestamo(int idPrestamo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            string query1 = "select idArticulo from prestamo where idPrestamo = @idPr";
            MySqlCommand cmd1 = new MySqlCommand(query1, conex);
            cmd1.Parameters.AddWithValue("@idPr", idPrestamo);
            int idArticuloPrestamo = Convert.ToInt32(cmd1.ExecuteScalar());

            string query2 = "update prestamo set estado = 0 where idPrestamo = @idPre;" +
                "update articulo set prestado = 0 where idArticulo = @idArt";
            MySqlCommand cmd2 = new MySqlCommand(query2, conex);
            cmd2.Parameters.AddWithValue("@idPre", idPrestamo);
            cmd2.Parameters.AddWithValue("@idArt", idArticuloPrestamo);
            int result = cmd2.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
        }

        //Retorna el id del artículo en préstamo. Para ver los datos del artículo desde VerPrestamo
        public Int32 articuloEnPrestamo(int idPrestamo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            string query = "select idArticulo from prestamo where idPrestamo = @idPr";
            MySqlCommand cmd = new MySqlCommand(query, conex);
            cmd.Parameters.AddWithValue("@idPr", idPrestamo);
            int idArticuloPrestamo = Convert.ToInt32(cmd.ExecuteScalar());

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return idArticuloPrestamo;
        }

        public TOPrestamo obtenerPrestamo(int idPrestamo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select numeroContrato, paciente, responsable, fechaPrestamo, fechaEntrega, idArticulo from prestamo where idPrestamo = @idPrest;";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idPrest", idPrestamo);

            MySqlDataReader reader = cmd.ExecuteReader();
            TOPrestamo prestamo = new TOPrestamo();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    prestamo.numeroContrato = reader.GetString(0);
                    prestamo.paciente = reader.GetString(1);
                    prestamo.responsable = reader.GetString(2);
                    prestamo.fechaPrestamo = reader.GetDateTime(3);
                    prestamo.fechaEntrega = reader.GetDateTime(4);
                    prestamo.idArticulo = reader.GetInt32(5);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return prestamo;
        }

    }
}
