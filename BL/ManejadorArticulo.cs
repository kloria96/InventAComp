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

    /// <summary>
    /// Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar los artículos del sistema
    /// Los métodos de esta clase hacen referencia a aquellos en DAOArticulo, y tienen la misma funcionalidad
    /// </summary>
    public class ManejadorArticulo
    {
        /// <summary>
        /// Inserta un nuevo artículo en la base de datos
        /// </summary>
        /// <param name="articulo">Artículo a ingresar</param>
        /// <returns>True en caso de que el artículo se haya ingresado correctamente, false de la contrario</returns>
        public bool agregarArticulo(BLArticulo articulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.agregarArticulo(convert(articulo));
        }

        /// <summary>
        /// Obtiene los datos de todos los artículos en el sistema
        /// </summary>
        /// <returns>Lista de artículos en la base de datos</returns>
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

        /// <summary>
        /// Recupera todos los artículos en la base de datos cuyo nombre coincida con el texto
        /// </summary>
        /// <param name="value">Texto de filtrado según nombre</param>
        /// <returns>Lista de artículos en la base de datos que coincidan con el texto</returns>
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

        /// <summary>
        /// Recupera todos los artículos en la base de datos cuya categoría coincida con la categoría especificada
        /// </summary>
        /// <param name="value">Categoría de filtrado de los artículos</param>
        /// <returns>Lista de artículos en la base de datos que pertenezcan a la categoría</returns>
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

        /// <summary>
        /// Recupera todos los artículos en la base de datos cuyo nombre coincida con el texto y que se encuentren disponibles
        /// para prestar
        /// </summary>
        /// <param name="value">Texto de filtrado según nombre</param>
        /// <returns>Lista de artículos en la base de datos que coincidan con el texto y que no se encuentren bajo préstamo</returns>
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

        /// <summary>
        /// Recupera todos los artículos en la base de datos cuya categoría coincida con la categoría especificada y que se
        ///  encuentren disponibles para prestar
        /// </summary>
        /// <param name="value">Categoría de filtrado de los artículos</param>
        /// <returns>Lista de artículos en la base de datos que pertenezcan a la categoría y que no se encuentren bajo préstamo</returns>
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

        /// <summary>
        /// Recupera todos los artículos en la base de datos cuya fecha de ingreso se encuentra entre 'fechaInicio' y 'fechaFin'
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio de la búsqueda</param>
        /// <param name="fechaFin">Fecha de fin de la búsqueda</param>
        /// <returns>Lista de artículos en la base de datos que se encuentren bajo las fechas especificadas</returns>
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

        /// <summary>
        /// Elimina un artículo de la base de datos
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo a eliminar</param>
        /// <returns>True en caso de que el artículo se haya eliminado correctamente, false de lo contrario</returns>
        public bool eliminarArticulo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.eliminarArticulo(idArticulo);
        }

        /// <summary>
        /// Recupera los datos del artículo según su identificador
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo</param>
        /// <returns>Artículo</returns>
        public BLArticulo obtenerArticulo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticulo(idArticulo);
            return new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.idCategoria);
        }

        /// <summary>
        /// Recupera los datos de un artículo según su identificador
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo</param>
        /// <returns>Artículo</returns>
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

        /// <summary>
        /// Recupera los datos de un artículo y su categoría, según su identificador
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo</param>
        /// <returns>Artículo</returns>
        public BLArticulo obtenerArticuloCategoria(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticuloCategoria(idArticulo);
            return new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.propiedad_JPS, toArt.prestado, toArt.nombreCategoria);
        }

        /// <summary>
        /// Modifica los datos de un artículo según su identificador y los valores ingresados
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo</param>
        /// <param name="numeroPlaca">Número de placa del artículo</param>
        /// <param name="nombre">Nombre del artículo</param>
        /// <param name="descripcion">Descripción del artículo</param>
        /// <param name="estado">Estado de conservación del artículo</param>
        /// <param name="ubicacion">Ubicación del artículo</param>
        /// <param name="propiedad_jps">Indica si este pertenece a la JPS o no</param>
        /// <param name="categoria">Categoría del artículo</param>
        /// <returns>True si el artículo fue modificado correctamente, false de lo contrario</returns>
        public bool actualizarArticulo(int idArticulo, string numeroPlaca, string nombre, string descripcion, string estado, string ubicacion, bool propiedad_jps, string categoria)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.actualizarArticulo(idArticulo, numeroPlaca, nombre, descripcion, estado, ubicacion, propiedad_jps, categoria);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numPlaca">Número de placa del artículo</param>
        /// <returns>Recupera los datos de un artículo según su número de placa</returns>
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

        /// <summary>
        /// Indica si existe un artículo en base de datos bajo el número de placa especificado
        /// </summary>
        /// <param name="numPlaca">Número de placa del artículo a buscar</param>
        /// <returns>True si el artículo existe, false de lo contrario</returns>
        public bool existeArticuloPlaca(string numPlaca)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.existeArticuloPlaca(numPlaca);
        }

        /// <summary>
        /// Indica si el artículo especificado según su identificador se encuentra actualmente bajo préstamo
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo</param>
        /// <returns>True si el artículo se encuentra bajo préstamo, false de lo contrario</returns>
        public bool articuloEnPrestamo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.articuloEnPrestamo(idArticulo);
        }


        /// <summary>
        /// Convierte un artículo de la capa de Lógica de Negocios (BL) a la capa Objetos de Transferencia (TO). Método usado
        /// localmente
        /// </summary>
        /// <param name="art">Artículo de Lógica de Negocios a convertir</param>
        /// <returns>Artículo de Objetos de Transferencia convertido</returns>
        private TOArticulo convert(BLArticulo art)
        {
            return new TOArticulo(art.idArticulo, art.numeroPlaca, art.nombArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.ubicacionArticulo, art.propiedad_JPS, art.idCategoria);
        }

        /// <summary>
        /// Convierte un artículo de la capa de Objetos de Transferencia (TO) a la capa Lógica de Negocios. Método usado
        /// localmente
        /// </summary>
        /// <param name="art">Artículo de Objetos de Transferencia a convertir</param>
        /// <returns>Artículo de Lógica de Negocios convertido</returns>
        private BLArticulo convert(TOArticulo art)
        {
            return new BLArticulo(art.idArticulo, art.numeroPlaca, art.nombArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.ubicacionArticulo, art.idCategoria);
        }
    }
}
