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
    //Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar las categorías del sistema
    //Los métodos de esta clase hacen referencia a aquellos en DAOCategoria, y tienen la misma funcionalidad
    public class ManejadorCategoria
    {

        /**
         * Retorna la lista de categorías existentes en la base de datos, ordenadas por su nombre
         * 
         * @return Lista de categorías en base de datos
         **/
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

        /**
         * Retorna una tabla con el nombre de todas las categorías en la base de datos, ordenadas según su identificador
         * 
         * @return Tabla que contiene todas las categorías en la base de datos
         **/
        public DataTable consultarCategoriasOrdenId()
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.consultarCategoriasOrdenId();
        }

        /**
         * Verifica si la categoría especificada existe en la base de datos
         * 
         * @param nombre Nombre de la categoría a verificar
         * @return True en caso de que la categoría no exista, false de lo contrario
         **/
        public bool verificarCategoria(string nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.verificarCategoria(nombre);
        }

        /**
         * Inserta una nueva categoría en la base de datos
         * 
         * @param nombre Nombre de la nueva categoría
         **/
        public void agregarCategoria(String nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            daoCateg.insertarCategoria(nombre);
        }

        /**
         * Retorna la lista de categorías del sistema, a excepción de la categoría especificada
         * 
         * @param categoriaArticulo Nombre de la categoría a excluir de la lista
         * @return Lista de categorías del sistema
         **/
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

        /**
         * Elimina una categoría de la base de datos
         * 
         * @param idCategoria Identificador numérico de la categoría a eliminar
         * @return True si la categoría fue eliminada correctamente, false de la contrario
         **/
        public bool eliminarCategoria(int idCategoria)
        {
            DAOCategoria daoCat = new DAOCategoria();
            return daoCat.eliminarCategoria(idCategoria);
        }

        /**
         * Modifica el nombre de una categoría existente
         * 
         * @param idCategoria Identificador de la categoría a modificar
         * @param nombre Nuevo nombre de la categoría
         * @return True en caso de que la categoría haya sido modificada correctamente, false de la contrario
         **/
        public bool actualizarCategoria(int idCategoria, string nombre)
        {
            DAOCategoria daoCat = new DAOCategoria();
            return daoCat.actualizarCategoria(idCategoria, nombre);
        }

        /**
         * Retorna el identificador de la categoría especificada
         * 
         * @param nombre Nombre de la categoría
         * @return Identificador de la categoría
         **/
        public int obtenerIDCategoria(string nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.obtenerIDCategoria(nombre);
        }

    }
}
