using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;
using System.Data;

namespace BL
{
    //Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar los artículos del sistema
    public class ManejadorArticulo
    {

        /**
         * Inserta un nuevo artículo en la base de datos
         * 
         * @param articulo Artículo a ingresar
         * @return True en caso de que el artículo se haya ingresado correctamente, falso de la contrario
         **/
        public bool agregarArticulo(BLArticulo articulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.agregarArticulo(convert(articulo));
        }

        /**
         * Obtiene los datos de todos los artículos en el sistema
         * 
         * @return Lista de artículos en la base de datos
         **/
        public List<BLArticulo> consultarArticulos()
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<TOArticulo> listTOArt = daoArt.consultar_Articulos();
            List<BLArticulo> listBLArt = new List<BLArticulo>();
            foreach (TOArticulo toArt in listTOArt)
            {
                //listBLArt.Add(convert2(toArt));
                listBLArt.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
            }
            return listBLArt;
        }


        /**
         * Recupera todos los artículos en la base de datos cuyo nombre coincida con el texto
         * 
         * @param value Texto de filtrado según nombre
         * @return Lista de artículos en la base de datos que coincidan con el texto
         **/
        public List<BLArticulo> obtenerArticulosNombre(string value)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosNombre(value))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
            }
            return lista;
        }

        /**
         * Recupera todos los artículos en la base de datos cuya categoría coincida con la categoría especificada
         * 
         * @param value Categoría de filtrado de los artículos
         * @return Lista de artículos en la base de datos que pertenezcan a la categoría
         **/
        public List<BLArticulo> obtenerArticulosCategoria(string value)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosCategoria(value))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
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
        public List<BLArticulo> obtenerArticulosNombrePrestamo(string value)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosNombre(value))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
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
        public List<BLArticulo> obtenerArticulosCategoriaPrestamo(string value)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosCategoria(value))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
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
        public List<BLArticulo> obtenerArticulosFecha(string fechaInicio, string fechaFin)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosFecha(fechaInicio, fechaFin))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
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
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.eliminarArticulo(idArticulo);
        }

        /**
         * Recupera los datos del artículo según su identificador
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return Artículo
         **/
        public BLArticulo obtenerArticulo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticulo(idArticulo);
            return new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.idCategoria);
        }

        /**
         * Recupera los datos de un artículo según su identificador
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return Artículo
         **/
        public BLArticulo obtenerArticuloBusqueda(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticuloBusqueda(idArticulo);
            BLArticulo articulo = new BLArticulo();
            articulo.idArticulo = toArt.idArticulo;
            articulo.numeroPlaca = toArt.numeroPlaca;
            articulo.nombArticulo = toArt.nombArticulo;
            articulo.descripcArticulo = toArt.descripcArticulo;
            articulo.estadoArticulo = toArt.estadoArticulo;
            articulo.ubicacionArticulo = toArt.ubicacionArticulo;
            articulo.nombCategoria = toArt.nombreCategoria;
            return articulo;
        }

        /**
         * Recupera los datos de un artículo y su categoría, según su identificador
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return Artículo
         **/
        public BLArticulo obtenerArticuloCategoria(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticuloCategoria(idArticulo);
            return new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.propiedad_JPS, toArt.prestado, toArt.nombreCategoria);
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
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.actualizarArticulo(idArticulo, numeroPlaca, nombre, descripcion, estado, ubicacion, propiedad_jps, categoria);
        }

        /**
         * Recupera los datos de un artículo según su número de placa
         * 
         * @param numPlaca Número de placa del artículo
         * @return Artículo
         **/
        public BLArticulo buscarArticuloPlaca(string numPlaca)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo art = daoArt.buscarArticuloPlaca(numPlaca);
            BLArticulo articulo = new BLArticulo();
            articulo.idArticulo = art.idArticulo;
            articulo.numeroPlaca = art.numeroPlaca;
            articulo.nombArticulo = art.nombArticulo;
            articulo.descripcArticulo = art.descripcArticulo;
            articulo.nombCategoria = art.nombreCategoria;
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
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.existeArticuloPlaca(numPlaca);
        }

        /**
         * Indica si el artículo especificado según su identificador se encuentra actualmente bajo préstamo
         * 
         * @param idArticulo Identificador numérico del artículo
         * @return True si el artículo se encuentra bajo préstamo, false de lo contrario
         **/
        public bool articuloEnPrestamo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.articuloEnPrestamo(idArticulo);
        }


        /**
         * Convierte un artículo de la capa de Lógica de Negocios (BL) a la capa Objetos de Transferencia (TO). Método usado
         * localmente
         * 
         * @param art Artículo de Lógica de Negocios a convertir
         * @return Artículo de Objetos de Transferencia convertido
         **/
        private TOArticulo convert(BLArticulo art)
        {
            return new TOArticulo(art.idArticulo, art.numeroPlaca, art.nombArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.ubicacionArticulo, art.propiedad_JPS, art.idCategoria);
        }

        /**
         * Convierte un artículo de la capa de Objetos de Transferencia (TO) a la capa Lógica de Negocios. Método usado
         * localmente
         * 
         * @param art Artículo de Objetos de Transferencia a convertir
         * @return Artículo de Lógica de Negocios convertido
         **/
        private BLArticulo convert(TOArticulo art)
        {
            return new BLArticulo(art.idArticulo, art.numeroPlaca, art.nombArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.ubicacionArticulo, art.idCategoria);
        }


    }
}
