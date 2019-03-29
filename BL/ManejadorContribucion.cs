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

        public List<BLContribucion> contribucionesPrestamo(string contrato)
        {
            List<BLContribucion> listaBL = new List<BLContribucion>();
            foreach (TOContribucion toCont in daoContribucion.contribucionesPrestamo(contrato))
            {
                BLContribucion cont = new BLContribucion();
                cont.numeroRecibo = toCont.numeroRecibo;
                cont.cuota = toCont.cuota;
                cont.fecha = toCont.fecha;
                listaBL.Add(cont);
            }
            return listaBL;
        }


        private TOContribucion convert(BLContribucion blCont)
        {
            return new TOContribucion(blCont.numeroRecibo, blCont.cuota, blCont.fecha, blCont.idPrestamo);
        }

    }
}
