using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    /// <summary>
    /// Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar las categorías del sistema
    /// Los métodos de esta clase hacen referencia a aquellos en DAOCategoria, y tienen la misma funcionalidad
    /// </summary>
    public class ManejadorCategoria
    {
        /// <summary>
        /// Retorna la lista de categorías existentes en la base de datos, ordenadas por su nombre
        /// </summary>
        /// <returns>Lista de categorías en base de datos</returns>
        public List<BLCategoria> consultarCategorias()
        {
            DAOCategoria daoCateg = new DAOCategoria();
            List<BLCategoria> lista = new List<BLCategoria>();
            foreach (TOCategoria categ in daoCateg.consultarCategorias())
            {
                lista.Add(new BLCategoria(categ.idCategoria, categ.nombreCategoria));
            }
            return lista;
        }

        /// <summary>
        /// Retorna una tabla con el nombre de todas las categorías en la base de datos, ordenadas según su identificador
        /// </summary>
        /// <returns>Tabla que contiene todas las categorías en la base de datos</returns>
        public DataTable consultarCategoriasOrdenId()
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.consultarCategoriasOrdenId();
        }

        /// <summary>
        /// Verifica si la categoría especificada existe en la base de datos
        /// </summary>
        /// <param name="nombre">Nombre de la categoría a verificar</param>
        /// <returns>True en caso de que la categoría no exista, false de lo contrario</returns>
        public bool verificarCategoria(string nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.verificarCategoria(nombre);
        }

        /// <summary>
        /// Inserta una nueva categoría en la base de datos
        /// </summary>
        /// <param name="nombre">Nombre de la nueva categoría</param>
        public void agregarCategoria(String nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            daoCateg.insertarCategoria(nombre);
        }

        /// <summary>
        /// Retorna la lista de categorías del sistema, a excepción de la categoría especificada
        /// </summary>
        /// <param name="categoriaArticulo">Nombre de la categoría a excluir de la lista</param>
        /// <returns>Lista de categorías del sistema</returns>
        public List<BLCategoria> consultarCategorias(string categoriaArticulo)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            List<BLCategoria> lista = new List<BLCategoria>();
            foreach (TOCategoria categ in daoCateg.consultarCategorias(categoriaArticulo))
            {
                lista.Add(new BLCategoria(categ.nombreCategoria));
            }
            return lista;
        }

        /// <summary>
        /// Elimina una categoría de la base de datos
        /// </summary>
        /// <param name="idCategoria">Identificador numérico de la categoría a eliminar</param>
        /// <returns>True si la categoría fue eliminada correctamente, false de la contrario</returns>
        public bool eliminarCategoria(int idCategoria)
        {
            DAOCategoria daoCat = new DAOCategoria();
            return daoCat.eliminarCategoria(idCategoria);
        }

        /// <summary>
        /// Modifica el nombre de una categoría existente
        /// </summary>
        /// <param name="idCategoria">Identificador de la categoría a modificar</param>
        /// <param name="nombre">Nuevo nombre de la categoría</param>
        /// <returns>True en caso de que la categoría haya sido modificada correctamente, false de la contrario</returns>
        public bool actualizarCategoria(int idCategoria, string nombre)
        {
            DAOCategoria daoCat = new DAOCategoria();
            return daoCat.actualizarCategoria(idCategoria, nombre);
        }

        /// <summary>
        /// Retorna el identificador de la categoría especificada
        /// </summary>
        /// <param name="nombre">Nombre de la categoría</param>
        /// <returns>Identificador de la categoría</returns>
        public int obtenerIDCategoria(string nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.obtenerIDCategoria(nombre);
        }
    }
}
