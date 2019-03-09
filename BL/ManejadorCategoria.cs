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
    public class ManejadorCategoria
    {
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


        public DataTable consultarCategoriasOrdenId()
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.consultarCategoriasOrdenId();
        }

        public bool verificarCategoria(string nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.verificarCategoria(nombre);
        }

        public void agregarCategoria(String nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            daoCateg.insertarCategoria(nombre);
        }

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

        public bool eliminarCategoria(int idCategoria)
        {
            DAOCategoria daoCat = new DAOCategoria();
            return daoCat.eliminarCategoria(idCategoria);
        }

        public bool actualizarCategoria(int idCategoria, string nombre)
        {
            DAOCategoria daoCat = new DAOCategoria();
            return daoCat.actualizarCategoria(idCategoria, nombre);
        }

        public int obtenerIDCategoria(string nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.obtenerIDCategoria(nombre);
        }

    }
}
