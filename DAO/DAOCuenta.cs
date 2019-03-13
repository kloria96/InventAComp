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
        MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringM);

        public TOCuenta buscarCuenta(string nombre, string contra)
        {
            TOCuenta cuenta = new TOCuenta();
            MySqlCommand buscar = new MySqlCommand("SELECT * FROM cuenta WHERE nombreUsuario = @nombre and contrasenna = @contra", conex);
            buscar.Parameters.AddWithValue("@nombre", nombre);
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
                    cuenta.nombreUsuario = reader.GetString(0);
                    cuenta.contrasenna = reader.GetString(1);
                    cuenta.privilegio = reader.GetString(2);
                    cuenta.estado = reader.GetBoolean(3);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return cuenta;

        }
    }
}
