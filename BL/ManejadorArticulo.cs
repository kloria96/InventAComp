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
    public class ManejadorArticulo
    {

        public void agregarArticulo(BLArticulo articulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            daoArt.agregarArticulo(convert(articulo));
        }

        public DataTable consultarArticulos()
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.consultar_Articulos();
        }

        private TOArticulo convert(BLArticulo art)
        {
            return new TOArticulo(art.numeroPlaca, art.nombArticulo, art.idArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.idCategoria);
        }

        private BLArticulo convert(TOArticulo art)
        {
            return new BLArticulo(art.numeroPlaca, art.nombArticulo, art.idArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.idCategoria);
        }

        public List<BLArticulo> obtenerArticulosNombre(string value)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosNombre(value))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.idCategoria));
            }
            return lista;
        }

        public List<BLArticulo> obtenerArticulosCategoria(string value)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosCategoria(value))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.idCategoria));
            }
            return lista;
        }

        public List<BLArticulo> obtenerArticulosFecha(string fechaInicio, string fechaFin)
        {
            DAOArticulo daoArt = new DAOArticulo();
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoArt.obtenerArticulosFecha(fechaInicio, fechaFin))
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.idCategoria));
            }
            return lista;
        }

        public bool eliminarArticulo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.eliminarArticulo(idArticulo);
        }

        public BLArticulo obtenerArticulo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticulo(idArticulo);
            return new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.idCategoria);
        }

        public bool actualizarArticulo(int idArticulo, string numeroPlaca, string nombre, string descripcion, string estado, string categoria)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.actualizarArticulo(idArticulo, numeroPlaca, nombre, descripcion, estado, categoria);
        }

    }
}
