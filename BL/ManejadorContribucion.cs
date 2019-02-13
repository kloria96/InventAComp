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
    public class ManejadorContribucion
    {
        private DAOContribucion daoContribucion = new DAOContribucion();

        public bool agregarContribucion(BLContribucion nuevaCont)
        {
            return daoContribucion.agregarContribucion(convert(nuevaCont));
        }

        public List<BLContribucion> obtenerContribucionesPrestamo(int idPrestamo)
        {
            List<BLContribucion> lista = new List<BLContribucion>();
            foreach (TOContribucion toContribucion in daoContribucion.obtenerContribucionesPrestamo(idPrestamo))
            {
                lista.Add(new BLContribucion(toContribucion.idContribucion, toContribucion.numeroRecibo, toContribucion.cuota, toContribucion.fecha, toContribucion.idPrestamo));
            }
            return lista;
        }

        private TOContribucion convert(BLContribucion blCont)
        {
            return new TOContribucion(blCont.numeroRecibo, blCont.cuota, blCont.fecha, blCont.idPrestamo);
        }

    }
}
