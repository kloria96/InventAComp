using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TO;
using System.Data;

namespace DAO
{
    public class DAOCuenta
    {
        //MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionString);
        MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringM);
        //MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringJ);

        // connectionStringJ (Juan Diego)
        // connectionStringM (Melany)
        // connectionString (Asoc. Acompañame)

        public TOCuenta buscarCuenta(string id, string contra)
        {
            TOCuenta cuenta = new TOCuenta();
            MySqlCommand buscar = new MySqlCommand("SELECT * FROM cuenta WHERE idUsuario = @id and contrasenna = @contra", conex);
            buscar.Parameters.AddWithValue("@id", id);
            buscar.Parameters.AddWithValue("@contra", contra);

            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            MySqlDataReader reader = buscar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cuenta.idUsuario = reader.GetString(0);
                    cuenta.nombreEmpleado = reader.GetString(1);
                    cuenta.contrasenna = reader.GetString(2);
                    cuenta.privilegio = reader.GetString(3);
                    cuenta.estado = reader.GetBoolean(4);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return cuenta;

        }


        public void actualizarInsertarCuenta(TOCuenta cuenta)
        {
            String query = "begin tran if exists(select * from cuenta with (updlock, serializable) where idUsuario = @id) begin update cuenta set contrasenna = @contra, nombreEmpleado = @nombre, privilegio = @priv, estado = @estado where idUsuario = @id; end else begin insert into cuenta(idUsuario, nombreEmpleado, contrasenna, privilegio, estado) values(@id, @contra, @nombre, @priv, @estado); end commit tran;";
            MySqlCommand sentencia = new MySqlCommand(query, conex);
            sentencia.Parameters.AddWithValue("@id", cuenta.idUsuario);
            sentencia.Parameters.AddWithValue("@contra", cuenta.contrasenna);
            sentencia.Parameters.AddWithValue("@nombre", cuenta.nombreEmpleado);
            sentencia.Parameters.AddWithValue("@priv", cuenta.privilegio);
            sentencia.Parameters.AddWithValue("@estado", cuenta.estado);
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            sentencia.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }

        }
    }
}
