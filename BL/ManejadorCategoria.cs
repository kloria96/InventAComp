using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BL
{
    public class ManejadorCategoria
    {
        public DataTable consultarCategorias()
        {
            DAOCategoria daoCateg = new DAOCategoria();
            return daoCateg.consultarCategorias();
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
