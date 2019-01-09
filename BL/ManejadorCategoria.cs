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
    }
}
