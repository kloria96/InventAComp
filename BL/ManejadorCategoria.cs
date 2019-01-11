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
                lista.Add(new BLCategoria(categ.nombreCategoria));
            }
            return lista;
        }


        public DataTable consultarCategoriasOrdenId()
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.consultarCategoriasOrdenId();
        }

        public void agregarCategoria(String nombre)
        {
            DAOCategoria daoCateg = new DAOCategoria();
            daoCateg.insertarCategoria(nombre);
        }

    }
}
