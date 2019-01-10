using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;

namespace BL
{
    public class ManejadorArticulo
    {

        public void agregarArticulo(BLArticulo articulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            daoArt.agregarArticulo(convert(articulo));
        }

        public TOArticulo convert(BLArticulo art)
        {
            return new TOArticulo(art.numeroPlaca, art.nombArticulo, art.idArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.idCategoria);
        }

        public BLArticulo convert(TOArticulo art)
        {
            return new BLArticulo(art.numeroPlaca, art.nombArticulo, art.idArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.idCategoria);
        }
    }
}
