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
    /// <summary>
    /// Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar las contribuciones
    /// realizadas a los préstamos de artículos en el sistema
    /// Los métodos de esta clase hacen referencia a aquellos en DAOContribucion, y tienen la misma funcionalidad
    /// </summary>
    public class ManejadorContribucion
    {
        private DAOContribucion daoContribucion = new DAOContribucion();

        /// <summary>
        /// Inserta una nueva contribución en la base de datos
        /// </summary>
        /// <param name="nuevaCont">Contribución a ingresar. Objeto que contiene los datos de la nueva contribución a ingresar</param>
        /// <returns>True en caso de que la contribución se haya ingresado correctamente, false de la contrario</returns>
        public bool agregarContribucion(BLContribucion nuevaCont)
        {
            return daoContribucion.agregarContribucion(convert(nuevaCont));
        }

        /// <summary>
        /// Retorna una lista de las contribuciones realizadas al préstamo especificado
        /// </summary>
        /// <param name="idPrestamo">Identificador numérico del préstamo</param>
        /// <returns>Lista de contribuciones realizadas a dicho préstamo</returns>
        public List<BLContribucion> obtenerContribucionesPrestamo(int idPrestamo)
        {
            List<BLContribucion> lista = new List<BLContribucion>();
            foreach (TOContribucion toContribucion in daoContribucion.obtenerContribucionesPrestamo(idPrestamo))
            {
                lista.Add(new BLContribucion(toContribucion.idContribucion, toContribucion.numeroRecibo, toContribucion.cuota, toContribucion.fecha, toContribucion.idPrestamo));
            }
            return lista;
        }

        /// <summary>
        /// Retorna una lista de las contribuciones realizadas al préstamo asociado al número de contrato
        /// </summary>
        /// <param name="contrato">Número de contrato del préstamo</param>
        /// <returns>Lista de contribuciones realizadas a dicho préstamo</returns>
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

        /// <summary>
        /// Convierte una contribución de la capa de Lógica de Negocios (BL) a la capa Objetos de Transferencia (TO). Método
        /// usado localmente
        /// </summary>
        /// <param name="blCont">Contribución de Lógica de Negocios a convertir</param>
        /// <returns>Contribución de Objetos de Transferencia convertido</returns>
        private TOContribucion convert(BLContribucion blCont)
        {
            return new TOContribucion(blCont.numeroRecibo, blCont.cuota, blCont.fecha, blCont.idPrestamo);
        }
    }
}
