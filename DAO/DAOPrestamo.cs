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
        //MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringM);
        MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringJ);

        // connectionStringJ (Juan Diego)
        // connectionStringM (Melany)

        public bool agregarPrestamo(TOPrestamo nuevoPrest)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "insert into prestamo (numerocontrato, paciente, responsable, fechaprestamo, fechaentrega, idarticulo) values (@con, @pac, @res, @fecPr, @fecEn, @idArt);";
            MySqlCommand cmd = new MySqlCommand(qry, conex);

            cmd.Parameters.AddWithValue("@con", nuevoPrest.numeroContrato);
            cmd.Parameters.AddWithValue("@pac", nuevoPrest.paciente);
            cmd.Parameters.AddWithValue("@res", nuevoPrest.responsable);
            cmd.Parameters.AddWithValue("@fecPr", nuevoPrest.fechaPrestamo);
            cmd.Parameters.AddWithValue("@fecEn", nuevoPrest.fechaEntrega);
            cmd.Parameters.AddWithValue("@idArt", nuevoPrest.idArticulo);
            int result = cmd.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
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

    }
}
