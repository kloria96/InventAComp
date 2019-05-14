using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAO
{
    public class DAOArticulo
    {
        //MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionString);
        //MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringM);
        MySqlConnection conex = new MySqlConnection(Properties.Settings.Default.connectionStringJ);

        // connectionStringJ (Juan Diego)
        // connectionStringM (Melany)
        // connectionString (Asoc. Acompañame)


        /**
         * Obtiene los datos de todos los artículos en el sistema
         * 
         * @return Lista de artículos en la base de datos
         **/
        public List<TOArticulo> consultar_Articulos()
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            
            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.fechaIngreso, a.descripcion, a.estado, a.ubicacion, c.nombre from inventario.articulo as a, inventario.categoria as c where c.idCategoria = a.idCategoria;";
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

        /**
         * Inserta un nuevo artículo en la base de datos
         * 
         * @param nuevoArt Artículo a ingresar
         * @return True en caso de que el artículo se haya ingresado correctamente, false de la contrario
         **/
        public bool agregarArticulo(TOArticulo nuevoArt)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "insert into articulo (numeroPlaca, nombre, fechaIngreso, descripcion, estado, ubicacion, propiedad_jps, prestado, idCategoria) values (@numPlac, @nomb, @fechIng, @descripc, @est, @ubic, @pro, 0, @idCateg)";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            
            cmd.Parameters.AddWithValue("@numPlac", nuevoArt.numeroPlaca);
            cmd.Parameters.AddWithValue("@nomb", nuevoArt.nombArticulo);
            cmd.Parameters.AddWithValue("@fechIng", nuevoArt.fechaIngreso);
            cmd.Parameters.AddWithValue("@descripc", nuevoArt.descripcArticulo);
            cmd.Parameters.AddWithValue("@est", nuevoArt.estadoArticulo);
            cmd.Parameters.AddWithValue("@ubic", nuevoArt.ubicacionArticulo);
            cmd.Parameters.AddWithValue("@pro", nuevoArt.propiedad_JPS);
            cmd.Parameters.AddWithValue("@idCateg", nuevoArt.idCategoria);
            int result = cmd.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
        }

        /**
         * Recupera todos los artículos en la base de datos cuyo nombre coincida con el texto
         * 
         * @param value Texto de filtrado según nombre
         * @return Lista de artículos en la base de datos que coincidan con el texto
         **/
        public List<TOArticulo> obtenerArticulosNombre(string value)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.fechaIngreso, a.descripcion, a.estado, a.ubicacion, c.nombre from inventario.articulo as a, inventario.categoria as c where c.idCategoria = a.idCategoria and a.nombre like @no";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@no", "%" + value + "%");
            
            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOArticulo> lista = new List<TOArticulo>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new TOArticulo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        /**
         * Recupera todos los artículos en la base de datos cuya categoría coincida con la categoría especificada
         * 
         * @param value Categoría de filtrado de los artículos
         * @return Lista de artículos en la base de datos que pertenezcan a la categoría
         **/
        public List<TOArticulo> obtenerArticulosCategoria(string value)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.fechaIngreso, a.descripcion, a.estado, a.ubicacion, c.nombre from inventario.articulo as a, inventario.categoria as c where c.idCategoria = a.idCategoria and c.nombre = @no";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@no", value);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOArticulo> lista = new List<TOArticulo>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new TOArticulo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        /**
         * Recupera todos los artículos en la base de datos cuyo nombre coincida con el texto y que se encuentren disponibles
         * para prestar
         * 
         * @param value Texto de filtrado según nombre
         * @return Lista de artículos en la base de datos que coincidan con el texto y que no se encuentren bajo préstamo
         **/
        public List<TOArticulo> obtenerArticulosNombrePrestamo(string value)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.descripcion, c.nombre from inventario.articulo a join inventario.categoria c on c.idCategoria = a.idCategoria where a.nombre like @no and a.prestado = 0";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@no", "%" + value + "%");

            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOArticulo> lista = new List<TOArticulo>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TOArticulo toArt = new TOArticulo();
                    toArt.idArticulo = reader.GetInt32(0);
                    toArt.numeroPlaca = reader.GetString(1);
                    toArt.nombArticulo = reader.GetString(2);
                    toArt.descripcArticulo = reader.GetString(3);
                    toArt.nombreCategoria = reader.GetString(4);
                    lista.Add(toArt);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        /**
         * Recupera todos los artículos en la base de datos cuya categoría coincida con la categoría especificada y que se
         * encuentren disponibles para prestar
         * 
         * @param value Categoría de filtrado de los artículos
         * @return Lista de artículos en la base de datos que pertenezcan a la categoría y que no se encuentren bajo préstamo
         **/
        public List<TOArticulo> obtenerArticulosCategoriaPrestamo(string value)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }
            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.descripcion, c.nombre from inventario.articulo a, inventario.categoria c on c.idCategoria = a.idCategoria where c.nombre = @no and a.prestado = 0";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@no", value);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOArticulo> lista = new List<TOArticulo>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TOArticulo toArt = new TOArticulo();
                    toArt.idArticulo = reader.GetInt32(0);
                    toArt.numeroPlaca = reader.GetString(1);
                    toArt.nombArticulo = reader.GetString(2);
                    toArt.descripcArticulo = reader.GetString(3);
                    toArt.nombreCategoria = reader.GetString(4);
                    lista.Add(toArt);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        /**
         * Recupera todos los artículos en la base de datos cuya fecha de ingreso se encuentra entre 'fechaInicio' y 'fechaFin'
         * 
         * @param fechaInicio Fecha de inicio de la búsqueda
         * @param fechaFin Fecha de fin de la búsqueda
         * @return Lista de artículos en la base de datos que se encuentren bajo las fechas especificadas
         **/
        public List<TOArticulo> obtenerArticulosFecha(string fechaInicio, string fechaFin)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.fechaIngreso, a.descripcion, a.estado, a.ubicacion, c.nombre from inventario.articulo as a, inventario.categoria as c where c.idCategoria = a.idCategoria and a.fechaIngreso between '" + fechaInicio + "' and '" + fechaFin + "'";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            
            MySqlDataReader reader = cmd.ExecuteReader();
            List<TOArticulo> lista = new List<TOArticulo>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.Add(new TOArticulo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return lista;
        }

        /**
         * Elimina un artículo de la base de datos
         * 
         * @param idArticulo Identificador numérico del artículo a eliminar
         * @return True en caso de que el artículo se haya eliminado correctamente, false de lo contrario
         **/
        public bool eliminarArticulo(int idArticulo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "delete from articulo where idArticulo = @idA";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idA", idArticulo);
            int result = cmd.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
        }

        /**
         * Recupera los datos del artículo según su identificador
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return Artículo
         **/
        public TOArticulo obtenerArticulo(int idArticulo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select * from articulo where idArticulo = @idA";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idA", idArticulo);
            MySqlDataReader reader = cmd.ExecuteReader();
            TOArticulo toArticulo = new TOArticulo();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    toArticulo = new TOArticulo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7));
                }
            }
            
            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return toArticulo;
        }

        /**
         * Recupera los datos de un artículo según su identificador
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return Artículo
         **/
        public TOArticulo obtenerArticuloBusqueda(int idArticulo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.descripcion, a.estado, a.ubicacion, c.nombre from articulo a join categoria c on a.idCategoria = c.idCategoria where a.idArticulo = @idA;";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idA", idArticulo);
            MySqlDataReader reader = cmd.ExecuteReader();
            TOArticulo toArticulo = new TOArticulo();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    toArticulo.idArticulo = reader.GetInt32(0);
                    toArticulo.numeroPlaca = reader.GetString(1);
                    toArticulo.nombArticulo = reader.GetString(2);
                    toArticulo.descripcArticulo = reader.GetString(3);
                    toArticulo.estadoArticulo = reader.GetString(4);
                    toArticulo.ubicacionArticulo = reader.GetString(5);
                    toArticulo.nombreCategoria = reader.GetString(6);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return toArticulo;
        }

        /**
         * Recupera los datos de un artículo y su categoría, según su identificador
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return Artículo
         **/
        public TOArticulo obtenerArticuloCategoria(int idArticulo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.fechaIngreso, a.descripcion, a.estado, a.ubicacion, a.propiedad_jps, a.prestado, c.nombre from inventario.articulo as a, inventario.categoria as c where a.idArticulo = @idA and c.idCategoria = a.idCategoria";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idA", idArticulo);
            MySqlDataReader reader = cmd.ExecuteReader();
            TOArticulo toArticulo = new TOArticulo();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    toArticulo = new TOArticulo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetBoolean(7), reader.GetBoolean(8), reader.GetString(9));
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return toArticulo;
        }

        /**
         * Modifica los datos de un artículo según su identificador y los valores ingresados
         * 
         * @param idArticulo Identificador numérico del artículo
         * @param numeroPlaca Número de placa del artículo
         * @param nombre Nombre del artículo
         * @param descripcion Descripción del artículo
         * @param estado Estado de conservación del artículo
         * @param ubicacion Ubicación del artículo
         * @param propiedad_jps Indica si este pertenece a la JPS o no
         * @param categoria Categoría del artículo
         * @return True si el artículo fue modificado correctamente, false de lo contrario
         **/
        public bool actualizarArticulo(int idArticulo, string numeroPlaca, string nombre, string descripcion, string estado, string ubicacion, bool propiedad_jps, string categoria)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "update articulo set numeroPlaca = @num, nombre = @nom, descripcion = @des, estado = @est, ubicacion = @ubic, propiedad_jps = @pro, idCategoria = (select idCategoria from categoria where nombre = @nomCat) where idArticulo = @idArt";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@num", numeroPlaca);
            cmd.Parameters.AddWithValue("@nom", nombre);
            cmd.Parameters.AddWithValue("@des", descripcion);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@ubic", ubicacion);
            cmd.Parameters.AddWithValue("@nomCat", categoria);
            cmd.Parameters.AddWithValue("@pro", propiedad_jps);
            cmd.Parameters.AddWithValue("@idArt", idArticulo);
            int result = cmd.ExecuteNonQuery();

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
        }

        /**
         * Recupera los datos de un artículo según su número de placa
         * 
         * @param numPlaca Número de placa del artículo
         * @return Artículo
         **/
        public TOArticulo buscarArticuloPlaca(string numPlaca)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select a.idArticulo, a.numeroPlaca, a.nombre, a.descripcion, c.nombre from articulo a join categoria c on a.idCategoria = c.idCategoria where a.numeroPlaca = @num";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@num", numPlaca);
            TOArticulo articulo = new TOArticulo();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    articulo.idArticulo = reader.GetInt32(0);
                    articulo.numeroPlaca = reader.GetString(1);
                    articulo.nombArticulo = reader.GetString(2);
                    articulo.descripcArticulo = reader.GetString(3);
                    articulo.nombreCategoria = reader.GetString(4);
                }
            }

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return articulo;
        }

        /**
         * Indica si existe un artículo en base de datos bajo el número de placa especificado
         * 
         * @param numPlaca Número de placa del artículo a buscar
         * @return True si el artículo existe, false de lo contrario
         **/
        public bool existeArticuloPlaca(string numPlaca)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            String qry = "select count(*) from articulo where numeroPlaca = @num";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@num", numPlaca);
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
        }

        /**
         * Indica si el artículo especificado según su identificador se encuentra actualmente bajo préstamo
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return True si el artículo se encuentra bajo préstamo, false de lo contrario
         **/
        public bool articuloEnPrestamo(int idArticulo)
        {
            if (conex.State != ConnectionState.Open)
            {
                conex.Open();
            }

            string qry = "select count(*) from articulo where prestado = 1 and idArticulo = @idArt";
            MySqlCommand cmd = new MySqlCommand(qry, conex);
            cmd.Parameters.AddWithValue("@idArt", idArticulo);
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            if (conex.State != ConnectionState.Closed)
            {
                conex.Close();
            }
            return (result > 0 ? true : false);
        }

    }
}
