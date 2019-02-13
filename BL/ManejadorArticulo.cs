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

        public bool agregarArticulo(BLArticulo articulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.agregarArticulo(convert(articulo));
        }

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

        public bool eliminarArticulo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.eliminarArticulo(idArticulo);
        }

        public BLArticulo obtenerArticulo(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticulo(idArticulo);
            return new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.idCategoria);
        }

        public BLArticulo obtenerArticuloCategoria(int idArticulo)
        {
            DAOArticulo daoArt = new DAOArticulo();
            TOArticulo toArt = daoArt.obtenerArticuloCategoria(idArticulo);
            return new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.propiedad_JPS, toArt.nombreCategoria);
        }

        public bool actualizarArticulo(int idArticulo, string numeroPlaca, string nombre, string descripcion, string estado, string ubicacion, bool propiedad_jps, string categoria)
        {
            DAOArticulo daoArt = new DAOArticulo();
            return daoArt.actualizarArticulo(idArticulo, numeroPlaca, nombre, descripcion, estado, ubicacion, propiedad_jps, categoria);
        }



        private TOArticulo convert(BLArticulo art)
        {
            return new TOArticulo(art.idArticulo, art.numeroPlaca, art.nombArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.ubicacionArticulo, art.propiedad_JPS, art.idCategoria);
        }

        private BLArticulo convert(TOArticulo art)
        {
            return new BLArticulo(art.idArticulo, art.numeroPlaca, art.nombArticulo, art.fechaIngreso, art.descripcArticulo, art.estadoArticulo, art.ubicacionArticulo, art.idCategoria);
        }


    }
}
